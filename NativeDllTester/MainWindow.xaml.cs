using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Windows;

namespace NativeDllTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnBrowse(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == true)
            {
                FilePath.Text = dialog.FileName;
            }
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FilePath.Text))
            {

                var library = Kernel32.LoadLibrary(FilePath.Text);

                if (library != IntPtr.Zero)
                {
                    Kernel32.FreeLibrary(library);

                    ErrorCode.Text = string.Empty;
                    ErrorMessage.Text = "No Error";
                }
                else
                {
                    try
                    {
                        throw new Win32Exception();
                    }
                    catch (Win32Exception ex)
                    {
                        ErrorCode.Text = ex.NativeErrorCode.ToString();
                        ErrorMessage.Text = ex.Message;
                    }
                }
            }
        }
    }
}
