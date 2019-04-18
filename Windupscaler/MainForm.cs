using System;
using System.Drawing;
using System.Windows.Forms;

namespace Windupscaler
{
    public partial class MainForm : Form
    {
        private Window SelectedWindow
        {
            get
            {
                return windowList.SelectedItem as Window;
            }
            set
            {
                windowList.SelectedItem = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            RefreshWindowList();

            customRadioBtn.CheckedChanged += (sender, e) => {
                var isChecked = customRadioBtn.Checked;
                customResolutionXInput.Enabled = isChecked;
                customResolutionYInput.Enabled = isChecked;

                var selectedWindow = SelectedWindow;
                if (isChecked && selectedWindow != null)
                {
                    var selectedWindowSize = selectedWindow.ClientRectSize;
                    customResolutionXInput.Text = selectedWindowSize.Width.ToString();
                    customResolutionYInput.Text = selectedWindowSize.Height.ToString();
                }
                else
                {
                    customResolutionXInput.Clear();
                    customResolutionYInput.Clear();
                }
            };

            aspectRatioRadioBtn.CheckedChanged += (sender, e) =>
            {
                accommodateTaskbarCheckbox.Enabled = aspectRatioRadioBtn.Checked;
            };

            windowList.SelectedValueChanged += (sender, e) =>
            {
                var selectedWindow = SelectedWindow;
                if (selectedWindow == null)
                {
                    scaleBtn.Enabled = false;
                    return;
                }
                scaleBtn.Enabled = true;
                if (customRadioBtn.Checked)
                {
                    var selectedWindowSize = selectedWindow.ClientRectSize;
                    customResolutionXInput.Text = selectedWindowSize.Width.ToString();
                    customResolutionYInput.Text = selectedWindowSize.Height.ToString();
                }
            };
        }

        private void RefreshWindowList()
        {
            windowList.Items.Clear();
            var windows = Window.GetWindows(window => window.IsVisible && !string.IsNullOrWhiteSpace(window.Title));
            foreach (var window in windows)
            {
                windowList.Items.Add(window);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshWindowList();
        }

        private void scaleBtn_Click(object sender, EventArgs e)
        {
            var selectedWindow = SelectedWindow;
            if (selectedWindow == null)
            {
                return;
            }

            if (borderlessCheckbox.Checked)
            {
                selectedWindow.SetBorderless();
            }

            if (fullscreenRadioBtn.Checked)
            {
                FullscreenScale(selectedWindow);
            }
            else if (aspectRatioRadioBtn.Checked)
            {
                KeepAspectRatioScale(selectedWindow);
            }
            else if (customRadioBtn.Checked)
            {
                CustomResolutionScale(selectedWindow);
            }
        }

        private void FullscreenScale(Window window)
        {
            var screenSize = Screen.PrimaryScreen.Bounds;
            window.MoveWindow(0, 0, screenSize.Width, screenSize.Height, true);
        }

        private void KeepAspectRatioScale(Window window)
        {
            var windowSize = window.ClientRectSize;
            var screenSize = Screen.PrimaryScreen.Bounds;

            if (accommodateTaskbarCheckbox.Checked)
            {
                screenSize.Height = screenSize.Height - 33;
            }

            var wfactor = screenSize.Width / (double)windowSize.Width;  // How much the window must be scaled horizontally to cover the whole screen
            var hfactor = screenSize.Height / (double)windowSize.Height;  // How much the window must be scaled vertically to cover the whole screen
            var scaleFactor = Math.Min(wfactor, hfactor);  // Take the minimum of the two in order to not overflow on either width or height

            // Scale using the same factor in both directions to maintain aspect-ratio
            windowSize.Width = (int)(windowSize.Width * scaleFactor);
            windowSize.Height = (int)(windowSize.Height * scaleFactor);

            var xcenter = (screenSize.Width - windowSize.Width) / 2;
            window.MoveWindow(xcenter, 0, windowSize.Width, windowSize.Height, true);
        }

        private void CustomResolutionScale(Window window)
        {
            var windowSize = new Size(ValidateAndGetCustomResolutionInput(customResolutionXInput), ValidateAndGetCustomResolutionInput(customResolutionYInput));
            if (windowSize.Width == 0 || windowSize.Height == 0)
            {
                return;
            }

            var screenSize = Screen.PrimaryScreen.Bounds;
            var xcenter = (screenSize.Width - windowSize.Width) / 2;
            var ycenter = (screenSize.Height - windowSize.Height) / 2;
            window.MoveWindow(xcenter, ycenter, windowSize.Width, windowSize.Height, true);
        }

        private static int ValidateAndGetCustomResolutionInput(TextBox textbox)
        {
            int value;
            if (!int.TryParse(textbox.Text, out value) || value < 0 || value > 9999)
            {
                textbox.Clear();
                textbox.Focus();
                return 0;
            }
            return value;
        }
    }

    public partial class Window
    {
        public override string ToString()
        {
            return Title;
        }
    }
}
