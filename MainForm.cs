using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetTracker
{
    public partial class MainForm : Form
    {
        // Panels for different views
        private Panel dashboardPanel;
        private Panel transactionsPanel;
        private Panel debtsPanel;

        public MainForm()
        {
            InitializeComponent();
            ApplyModernStyle();
            ShowDashboard(); // Default view
        }

        private void ApplyModernStyle()
        {
            this.Size = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.Sizable; // Restore resizing
            this.Text = "Budget Tracker";
            this.BackColor = Styles.Background;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Remove default controls from strict layout managed by Designer and re-add them to our new layout
            this.Controls.Clear(); 

            // 1. Sidebar Panel
            Panel sidebar = new Panel();
            sidebar.Dock = DockStyle.Left;
            sidebar.Width = 220;
            sidebar.BackColor = Styles.PrimaryDark;
            this.Controls.Add(sidebar);

            // logo / title
            Label brand = new Label();
            brand.Text = "BUDGET\nTRACKER";
            brand.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            brand.ForeColor = Styles.TextLight;
            brand.TextAlign = ContentAlignment.MiddleCenter;
            brand.Size = new Size(220, 80);
            brand.Location = new Point(0, 20);
            sidebar.Controls.Add(brand);

            // Sidebar Buttons
            int menuY = 120;
            AddMenuButton(sidebar, "Dashboard", menuY, (s, e) => ShowDashboard());
            AddMenuButton(sidebar, "Transactions", menuY + 50, (s, e) => ShowTransactions());
            AddMenuButton(sidebar, "Debts", menuY + 100, (s, e) => ShowDebts());
            AddMenuButton(sidebar, "Logout", this.Height - 80, (s, e) => Logout());

            // 2. Main Content Area
            Panel contentArea = new Panel();
            contentArea.Dock = DockStyle.Fill;
            contentArea.Padding = new Padding(20);
            this.Controls.Add(contentArea);

            // Initialize Views
            InitDashboardView(contentArea);
            InitTransactionsView(contentArea);
            InitDebtsView(contentArea);
        }

        private void AddMenuButton(Panel parent, string text, int y, EventHandler onClick)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btn.ForeColor = Color.Gainsboro;
            btn.BackColor = Color.Transparent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Size = new Size(220, 45);
            btn.Location = new Point(0, y);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(30, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
            btn.Click += onClick;
            
            // Hover effect
            btn.MouseEnter += (s, e) => btn.ForeColor = Color.White;
            btn.MouseLeave += (s, e) => btn.ForeColor = Color.Gainsboro;
            
            parent.Controls.Add(btn);

            if(text == "Logout") btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void InitDashboardView(Panel parent)
        {
            dashboardPanel = new Panel();
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Visible = false;
            parent.Controls.Add(dashboardPanel);

            // Quick Stats Cards
            int cardW = 200;
            AddStatCard(dashboardPanel, "Current Balance", "$1,250.00", 20, 20);
            AddStatCard(dashboardPanel, "Total Income", "$4,500.00", 240, 20);
            AddStatCard(dashboardPanel, "Total Expenses", "$3,250.00", 460, 20);

            // Chart
            Chart expenseChart = new Chart();
            expenseChart.Size = new Size(600, 350);
            expenseChart.Location = new Point(20, 150);
            
            ChartArea ca = new ChartArea();
            ca.Name = "MainArea";
            ca.BackColor = Color.White;
            expenseChart.ChartAreas.Add(ca);

            Series s = new Series();
            s.ChartType = SeriesChartType.Doughnut;
            s.Points.AddXY("Food", 400);
            s.Points.AddXY("Rent", 1200);
            s.Points.AddXY("Utilities", 300);
            s.Points.AddXY("Transport", 150);
            expenseChart.Series.Add(s);

            Title title = new Title("Expenses Breakdown");
            title.Font = Styles.SubHeaderFont;
            expenseChart.Titles.Add(title);

            dashboardPanel.Controls.Add(expenseChart);
        }

        private void AddStatCard(Panel parent, string title, string value, int x, int y)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 100);
            card.Location = new Point(x, y);
            card.BackColor = Color.White;
            
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.ForeColor = Styles.TextGray;
            lblTitle.Location = new Point(15, 15);
            lblTitle.AutoSize = true;
            card.Controls.Add(lblTitle);

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblValue.ForeColor = Styles.TextDark;
            lblValue.Location = new Point(15, 45);
            lblValue.AutoSize = true;
            card.Controls.Add(lblValue);

            parent.Controls.Add(card);
        }

        private void InitTransactionsView(Panel parent)
        {
            transactionsPanel = new Panel();
            transactionsPanel.Dock = DockStyle.Fill;
            transactionsPanel.Visible = false;
            parent.Controls.Add(transactionsPanel);

            Label header = new Label();
            header.Text = "Transactions";
            header.Font = Styles.HeaderFont;
            header.Location = new Point(20, 0);
            header.AutoSize = true;
            transactionsPanel.Controls.Add(header);

            Button addBtn = new Button();
            addBtn.Text = "+ New Transaction";
            Styles.ApplyButtonTheme(addBtn);
            addBtn.Size = new Size(180, 40);
            addBtn.Location = new Point(20, 50);
            addBtn.Click += button1_Click; // Re-use connection
            transactionsPanel.Controls.Add(addBtn);

            // DataGridView placeholder
            DataGridView grid = new DataGridView();
            Styles.StyleDataGridView(grid);
            grid.Location = new Point(20, 110);
            grid.Size = new Size(700, 400);
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            
            // Dummy columns
            grid.Columns.Add("Date", "Date");
            grid.Columns.Add("Desc", "Description");
            grid.Columns.Add("Amount", "Amount");
            grid.Rows.Add("2023-10-01", "Grocery Store", "-$124.50");
            grid.Rows.Add("2023-10-02", "Salary", "+$2500.00");

            transactionsPanel.Controls.Add(grid);
        }

        private void InitDebtsView(Panel parent)
        {
            debtsPanel = new Panel();
            debtsPanel.Dock = DockStyle.Fill;
            debtsPanel.Visible = false;
            parent.Controls.Add(debtsPanel);

             Label header = new Label();
            header.Text = "Debts & Loans";
            header.Font = Styles.HeaderFont;
            header.Location = new Point(20, 0);
            header.AutoSize = true;
            debtsPanel.Controls.Add(header);

            Button addBtn = new Button();
            addBtn.Text = "+ Add Debt/Loan";
            Styles.ApplyButtonTheme(addBtn);
            addBtn.Size = new Size(180, 40);
            addBtn.Location = new Point(20, 50);
            addBtn.Click += button2_Click;
            debtsPanel.Controls.Add(addBtn);
            
            // Grid placeholder
            DataGridView grid = new DataGridView();
            Styles.StyleDataGridView(grid);
            grid.Location = new Point(20, 110);
            grid.Size = new Size(700, 400);
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            grid.Columns.Add("Person", "Person");
            grid.Columns.Add("Amount", "Amount");
            grid.Rows.Add("John Doe", "$50.00");
            
            debtsPanel.Controls.Add(grid);
        }

        private void ShowDashboard()
        {
            HideAllViews();
            dashboardPanel.Visible = true;
        }

        private void ShowTransactions()
        {
            HideAllViews();
            transactionsPanel.Visible = true;
        }

        private void ShowDebts()
        {
            HideAllViews();
            debtsPanel.Visible = true;
        }

        private void HideAllViews()
        {
            if(dashboardPanel != null) dashboardPanel.Visible = false;
            if(transactionsPanel != null) transactionsPanel.Visible = false;
            if(debtsPanel != null) debtsPanel.Visible = false;
        }

        private void Logout()
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)// Go to transaction entry
        {
            // Open as modal instead of switching completely to avoid breaking this dashboard state
            TransactionEntryForm transaction = new TransactionEntryForm();
            transaction.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)// go to debt entry
        {
            DebtEntryForm debt = new DebtEntryForm();
            debt.ShowDialog();
        }
    }
}
