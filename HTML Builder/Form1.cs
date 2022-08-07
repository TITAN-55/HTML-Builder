using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Builder
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            settingsCombo.SelectedIndex = 0;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("StringBuilder html = new StringBuilder();");

            if(settingsCombo.Text.ToLower() == "convert html")
            {
                foreach (string line in htmlText.Text.Split('\n'))
                {
                    line.Replace(@"""", "'");
                    output.AppendLine($"html.AppendLine(\"{line}\");");
                }
            }
            else if (settingsCombo.Text.ToLower() == "convert text")
            {
                foreach (string line in htmlText.Text.Split('\n'))
                {
                    output.AppendLine($"html.AppendLine(\"<p>{line}</p>\");");
                }
            }

            outputText.Text = output.ToString();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputText.Text);
        }
    }
}
