using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ktk.Framework.Forms.MVVM
{
    public class WindowManager
    {
        /// <summary>
        /// Opens the specified window with the specifed view model
        /// </summary>
        /// <param name="window"></param>
        /// <param name="viewModel"></param>
        public static void ShowWindow(Window window, object viewModel)
        {
            window.DataContext = viewModel;
            window.Show();
        }

        /// <summary>
        /// Opens the specified window with the specifed view model.  If allowVMToClose is true, ShowWindow will provide a close action to the VM
        /// </summary>
        /// <param name="window"></param>
        /// <param name="viewModel"></param>
        public static void ShowWindow(Window window, object viewModel, bool allowVMToClose)
        {
            window.DataContext = viewModel;

            if(allowVMToClose && viewModel is ICloseable)
            {
                ((ICloseable)viewModel).CloseAction = new Action(() => window.Close());
            }

            window.Show();
        }

        public static bool? ShowDialog(Window dialogWindow, object viewModel)
        {
            dialogWindow.DataContext = viewModel;
            return dialogWindow.ShowDialog();
        }
    }
}
