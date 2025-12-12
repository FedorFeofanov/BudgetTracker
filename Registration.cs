using System;
using System.Drawing;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            // Form Style
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(400, 550);
            this.BackColor = Styles.Background;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Custom "Card" Panel
            Panel card = new Panel();
            card.Size = new Size(320, 480);
            card.Location = new Point((this.Width - card.Width) / 2, (this.Height - card.Height) / 2);
            card.BackColor = Color.White;
            this.Controls.Add(card);

            // Title
            Label title = new Label();
            title.Text = "Create Account";
            title.Font = Styles.HeaderFont;
            title.ForeColor = Styles.PrimaryDark;
            title.AutoSize = false;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Size = new Size(card.Width, 40);
            title.Location = new Point(0, 30);
            card.Controls.Add(title);

            // Close Button
            Button closeBtn = new Button();
            closeBtn.Text = "X";
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.Size = new Size(30, 30);
            closeBtn.Location = new Point(370, 0);
            closeBtn.Click += (s, e) => {
                 this.Hide();
                 new Form1().ShowDialog(); // Go back to login instead of exit
                 this.Close();
            };
            closeBtn.ForeColor = Color.Gray;
            this.Controls.Add(closeBtn);

            // Relocate Inputs
            int startY = 90;
            int gap = 60;

            // Name
            label4.Parent = card;
            label4.Font = Styles.BodyFont;
            label4.ForeColor = Styles.TextGray;
            label4.Location = new Point(30, startY);
            
            Name.Parent = card;
            Styles.ApplyInputTheme(Name);
            Name.Location = new Point(30, startY + 25);
            Name.Size = new Size(260, 30);

            // Email
            label1.Parent = card;
            label1.Font = Styles.BodyFont;
            label1.ForeColor = Styles.TextGray;
            label1.Location = new Point(30, startY + gap);
            
            Email.Parent = card;
            Styles.ApplyInputTheme(Email);
            Email.Location = new Point(30, startY + gap + 25);
            Email.Size = new Size(260, 30);

            // Password
            label2.Parent = card;
            label2.Font = Styles.BodyFont;
            label2.ForeColor = Styles.TextGray;
            label2.Location = new Point(30, startY + 2 * gap);

            Password.Parent = card;
            Styles.ApplyInputTheme(Password);
            Password.Location = new Point(30, startY + 2 * gap + 25);
            Password.Size = new Size(260, 30);
            
             // Confirm Password
            label3.Parent = card;
            label3.Font = Styles.BodyFont;
            label3.ForeColor = Styles.TextGray;
            label3.Location = new Point(30, startY + 3 * gap);

            Confirm_Pas.Parent = card;
            Styles.ApplyInputTheme(Confirm_Pas);
            Confirm_Pas.Location = new Point(30, startY + 3 * gap + 25);
            Confirm_Pas.Size = new Size(260, 30);

            // Sign Up Button
            button2.Parent = card;
            button2.Text = "SIGN UP";
            Styles.ApplyButtonTheme(button2, true);
            button2.Location = new Point(30, 420);
            button2.Size = new Size(260, 40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string email = Email.Text;
            if (String.IsNullOrEmpty(email))
            {
            MessageBox.Show("Email field cannot be empty. Try again.","Critical failure!",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
            }
            string name = Name.Text;
            if (String.IsNullOrEmpty(name))
            {
            MessageBox.Show("Name field cannot be empty. Try again.","Critical failure!",
            MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
            }
            string password = Password.Text;
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login field cannot be empty. Try again.", "Critical failure!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = DataBase.AddNewUser(email, name, password);
            MessageBox.Show("User created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (user == null)
            {
                MessageBox.Show("Email is already in use. Try again.", "Registration failure!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
