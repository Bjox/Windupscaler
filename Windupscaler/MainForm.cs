using System;
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

        private void fullscreenBtn_Click(object sender, EventArgs e)
        {
            var selectedWindow = SelectedWindow;
            if (selectedWindow == null)
            { 
                return;
            }
            var screenSize = Screen.PrimaryScreen.Bounds;
            selectedWindow.MoveWindow(0, 0, screenSize.Width, screenSize.Height, true);
        }

        private void aspectBtn_Click(object sender, EventArgs e)
        {
            var selectedWindow = SelectedWindow;
            if (selectedWindow == null)
            {
                return;
            }

            selectedWindow.SetPopup();

            var screenSize = Screen.PrimaryScreen.Bounds;
            var windowSize = selectedWindow.ClientRectSize;

            var wfactor = screenSize.Width / (double)windowSize.Width;  // How much the window must be scaled horizontally to cover the whole screen
            var hfactor = screenSize.Height / (double)windowSize.Height;  // How much the window must be scaled vertically to cover the whole screen
            var scaleFactor = Math.Min(wfactor, hfactor);  // Take the minimum of the two in order to not overflow on either width or height

            // Scale using the same factor in both directions to maintain aspect-ratio
            windowSize.Width = (int)(windowSize.Width * scaleFactor);
            windowSize.Height = (int)(windowSize.Height * scaleFactor);

            var xcenter = (screenSize.Width - windowSize.Width) / 2;
            selectedWindow.MoveWindow(xcenter, 0, windowSize.Width, windowSize.Height, true);
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
