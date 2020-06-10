using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RBRTrackFinder.Views
{
    /// <summary>
    /// Logika interakcji dla klasy MessageView.xaml
    /// </summary>
    public partial class MessageView : UserControl
    {
        public MessageView()
        {
            InitializeComponent();
        }

        private void ReplyText_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            ReplyText.Text = "";
        }

        private void NewMessageSubject_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            NewMessageSubject.Text = "";
        }

        private void NewMessageContent_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            NewMessageContent.Text = "";
        }
    }
}
