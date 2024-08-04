using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articlesListBox;
        private TextBox titleTextBox;
        private Button saveButton;
        public ArticlesDialogBox()
        {
            articlesListBox = new ListBox(this);
            titleTextBox = new TextBox(this);
            saveButton = new Button(this);
        }

        public void simulateUserInteraction()
        {
            articlesListBox.Selection = "Articel 1";
            Console.WriteLine($"Texbox {titleTextBox.Content}");
            Console.WriteLine($"Button {saveButton.IsEnabled}");
            articlesListBox.Selection =string.Empty;
            Console.WriteLine($"Texbox {titleTextBox.Content}");
            Console.WriteLine($"Button {saveButton.IsEnabled}");

        }
        public override void Changed(UIControl control)
        {
            if (control == articlesListBox)
            {
                updateTitle();
            }
            else if (control == titleTextBox)
                titleChanged();
        }

        private void titleChanged()
        {
            var isEmpty = string.IsNullOrEmpty(titleTextBox.Content);
            saveButton.IsEnabled = (!isEmpty);
        }
        private void updateTitle()
        {
            titleTextBox.Content = articlesListBox.Selection;
        }
    }
}
