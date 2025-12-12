using System;
using System.Drawing;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyModernStyle();
        }

        private void ApplyModernStyle()
        {
            // Form Style
            this.FormBorderStyle = FormBorderStyle.None;
            this.Size = new Size(400, 500);
            this.BackColor = Styles.Background;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Custom "Card" Panel for Login
            Panel card = new Panel();
            card.Size = new Size(320, 400);
            card.Location = new Point((this.Width - card.Width) / 2, (this.Height - card.Height) / 2);
            card.BackColor = Color.White;
            this.Controls.Add(card);

            // Title
            Label title = new Label();
            title.Text = "Welcome Back";
            title.Font = Styles.HeaderFont;
            title.ForeColor = Styles.PrimaryDark;
            title.AutoSize = false;
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Size = new Size(card.Width, 40);
            title.Location = new Point(0, 30);
            card.Controls.Add(title);

            // Close Button (Top right)
            Button closeBtn = new Button();
            closeBtn.Text = "X";
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.Size = new Size(30, 30);
            closeBtn.Location = new Point(370, 0); // On Form, not card
            closeBtn.Click += (s, e) => Application.Exit();
            closeBtn.ForeColor = Color.Gray;
            this.Controls.Add(closeBtn);

            // Styled Inputs
            // We need to re-parent existing controls to the card or style them if they are added by Designer
            // Since Designer.cs controls are 'this.Controls.Add', we can move them.
            
            // Adjust Label1 (Email)
            label1.Parent = card;
            label1.Text = "Email / Username";
            label1.Location = new Point(30, 90);
            label1.Font = Styles.BodyFont;
            label1.ForeColor = Styles.TextGray;

            // Adjust Login Box
            Login.Parent = card;
            Styles.ApplyInputTheme(Login);
            Login.Location = new Point(30, 115);
            Login.Size = new Size(260, 30);

            // Adjust Label2 (Password)
            label2.Parent = card;
            label2.Location = new Point(30, 160);
            label2.Font = Styles.BodyFont;
            label2.ForeColor = Styles.TextGray;

            // Adjust Password Box
            Password.Parent = card;
            Styles.ApplyInputTheme(Password);
            Password.Location = new Point(30, 185);
            Password.Size = new Size(260, 30);

            // Adjust Login Button
            button1.Parent = card;
            button1.Text = "LOG IN";
            Styles.ApplyButtonTheme(button1, true);
            button1.Location = new Point(30, 240);
            button1.Size = new Size(260, 40);

            // Wrapper for bottom links
            label3.Parent = card;
            label3.Text = "New here?";
            label3.Location = new Point(70, 300);
            
            button2.Parent = card;
            button2.Text = "Create Account";
            Styles.ApplyButtonTheme(button2, false);
            button2.Location = new Point(140, 292);
            button2.Size = new Size(130, 30);
            button2.FlatAppearance.BorderSize = 0;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//go to register
        {
            RegistrationForm register = new RegistrationForm();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//login
        {
            string login = Login.Text;
            string password = Password.Text;
            
            // Simple validation visualization
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) {
                 MessageBox.Show("Please enter credentials.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }

            foreach (User u in DataBase.Users)
            {
                if((login == u.Email ||(login == u.Name) && password == u.Password)){
                    MainForm main = new MainForm();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Incorrect login or password. Try again.", "Login failure!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            Password.Clear();
        }
    }
}
