using System;
using System.Windows.Forms;

namespace Windupscaler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshWindowList();
            Console.WriteLine(Screen.PrimaryScreen.Bounds);
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

        private void upscaleBtn_Click(object sender, EventArgs e)
        {
            var selectedWindow = windowList.SelectedItem as Window;
            if (selectedWindow == null)
            {
                return;
            }
            selectedWindow.MoveWindow(2560, 0, 500, 500, true);
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
