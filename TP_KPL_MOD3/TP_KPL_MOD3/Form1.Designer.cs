using System;
using System.Windows.Forms;

namespace TP_KPL_MOD3
{
    public class MainForm : Form
    {
        private TextBox inputTextBox;
        private Button submitButton;
        private Label outputLabel;

        public MainForm()
        {
            
            this.Text = "TP MOD 3_103022300029";
            this.Size = new Size(400, 200);
            


            inputTextBox = new TextBox();
            inputTextBox.ForeColor = Color.White;
            inputTextBox.Location = new System.Drawing.Point(50, 30);
            inputTextBox.BackColor = Color.OrangeRed;
            inputTextBox.Width = 200;
            inputTextBox.Height = 30;
            this.Controls.Add(inputTextBox);

            
            submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.ForeColor = Color.White;
            submitButton.Location = new System.Drawing.Point(260, 28);
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.FlatAppearance.BorderSize = 0;
            submitButton.Height = 25;
            submitButton.BackColor = Color.OrangeRed;
            submitButton.Click += new EventHandler(OnSubmitClicked);
            submitButton.AutoSize = false;
            this.Controls.Add(submitButton);


            outputLabel = new Label();
            outputLabel.Text = "Output";
            outputLabel.ForeColor = Color.White;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter; 
            outputLabel.Width = 200;
            outputLabel.BackColor = Color.OrangeRed;
            outputLabel.AutoSize = false;
            outputLabel.Location = new Point((this.ClientSize.Width - outputLabel.Width) / 2, 80);
            this.Controls.Add(outputLabel);
        }

        private void OnSubmitClicked(object sender, EventArgs e)
        {
            string name = inputTextBox.Text;
            outputLabel.Text = "Halo " + name;
        }
    }
}