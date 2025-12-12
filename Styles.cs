using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BudgetTracker
{
    public static class Styles
    {
        // Color Palette
        public static Color PrimaryDark = Color.FromArgb(30, 30, 45);       // Sidebar
        public static Color PrimaryLight = Color.FromArgb(44, 44, 62);      // Cards
        public static Color Accent = Color.FromArgb(52, 152, 219);          // Blue Highlight
        public static Color AccentHover = Color.FromArgb(41, 128, 185);
        public static Color Background = Color.FromArgb(240, 242, 245);     // Main Background
        public static Color TextDark = Color.FromArgb(51, 51, 51);
        public static Color TextLight = Color.White;
        public static Color TextGray = Color.FromArgb(149, 165, 166);

        // Fonts
        public static Font HeaderFont = new Font("Segoe UI", 18, FontStyle.Bold);
        public static Font SubHeaderFont = new Font("Segoe UI", 12, FontStyle.SemiBold);
        public static Font BodyFont = new Font("Segoe UI", 10, FontStyle.Regular);

        public static void ApplyFormTheme(Form form)
        {
            form.BackColor = Background;
            form.StartPosition = FormStartPosition.CenterScreen;
            // Optional: Remove default borders for custom chrome, but keeping standard for stability first
            // form.FormBorderStyle = FormBorderStyle.None; 
        }

        public static void ApplyButtonTheme(Button btn, bool isPrimary = true)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            
            if (isPrimary)
            {
                btn.BackColor = Accent;
                btn.ForeColor = TextLight;
                btn.FlatAppearance.MouseOverBackColor = AccentHover;
            }
            else
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Accent;
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, Accent);
            }
        }

        public static void ApplyInputTheme(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Segoe UI", 11);
            txt.BackColor = Color.White;
            txt.ForeColor = TextDark;
        }

        public static void StyleDataGridView(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = PrimaryDark;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = TextLight;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);
            grid.ColumnHeadersHeight = 40;

            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = TextDark;
            grid.DefaultCellStyle.Font = BodyFont;
            grid.DefaultCellStyle.Padding = new Padding(8);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 250); // Light lavender selection
            grid.DefaultCellStyle.SelectionForeColor = TextDark;
            
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 35;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AllowUserToResizeRows = false;
        }
    }
}
