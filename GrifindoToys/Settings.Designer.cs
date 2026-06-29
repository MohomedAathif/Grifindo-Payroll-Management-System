
namespace GrifindoToys
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            noleaves = new NumericUpDown();
            StartDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            EndDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            No_of_leaves = new Guna.UI2.WinForms.Guna2HtmlLabel();
            RangeCycle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtstart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dtend = new Guna.UI2.WinForms.Guna2DateTimePicker();
            noleave = new Guna.UI2.WinForms.Guna2NumericUpDown();
            textdaterange = new Guna.UI2.WinForms.Guna2TextBox();
            btninsert = new Guna.UI2.WinForms.Guna2GradientButton();
            back = new Guna.UI2.WinForms.Guna2ImageButton();
            close = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)noleaves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noleave).BeginInit();
            SuspendLayout();
            // 
            // noleaves
            // 
            noleaves.Location = new Point(194, 172);
            noleaves.Name = "noleaves";
            noleaves.Size = new Size(69, 23);
            noleaves.TabIndex = 6;
            // 
            // StartDate
            // 
            StartDate.BackColor = Color.Transparent;
            StartDate.Font = new Font("Elephant", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartDate.Location = new Point(66, 61);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(70, 19);
            StartDate.TabIndex = 0;
            StartDate.Text = "Start Date";
            // 
            // EndDate
            // 
            EndDate.BackColor = Color.Transparent;
            EndDate.Font = new Font("Elephant", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EndDate.Location = new Point(66, 112);
            EndDate.Name = "EndDate";
            EndDate.Size = new Size(64, 19);
            EndDate.TabIndex = 1;
            EndDate.Text = "End Date";
            // 
            // No_of_leaves
            // 
            No_of_leaves.BackColor = Color.Transparent;
            No_of_leaves.Font = new Font("Elephant", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            No_of_leaves.Location = new Point(66, 158);
            No_of_leaves.Name = "No_of_leaves";
            No_of_leaves.Size = new Size(85, 19);
            No_of_leaves.TabIndex = 2;
            No_of_leaves.Text = "No of Leaves";
            // 
            // RangeCycle
            // 
            RangeCycle.BackColor = Color.Transparent;
            RangeCycle.Font = new Font("Elephant", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RangeCycle.Location = new Point(66, 214);
            RangeCycle.Name = "RangeCycle";
            RangeCycle.Size = new Size(116, 19);
            RangeCycle.TabIndex = 3;
            RangeCycle.Text = "Cycle Date Range";
            // 
            // dtstart
            // 
            dtstart.BorderRadius = 10;
            dtstart.Checked = true;
            dtstart.CustomizableEdges = customizableEdges1;
            dtstart.FillColor = Color.LightSlateGray;
            dtstart.Font = new Font("Segoe UI", 9F);
            dtstart.Format = DateTimePickerFormat.Long;
            dtstart.Location = new Point(220, 44);
            dtstart.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtstart.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtstart.Name = "dtstart";
            dtstart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtstart.Size = new Size(223, 36);
            dtstart.TabIndex = 4;
            dtstart.Value = new DateTime(2025, 12, 18, 21, 43, 21, 746);
            dtstart.ValueChanged += dtstart_ValueChanged_1;
            // 
            // dtend
            // 
            dtend.BorderRadius = 10;
            dtend.Checked = true;
            dtend.CustomizableEdges = customizableEdges3;
            dtend.FillColor = Color.LightSlateGray;
            dtend.Font = new Font("Segoe UI", 9F);
            dtend.Format = DateTimePickerFormat.Long;
            dtend.Location = new Point(220, 95);
            dtend.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtend.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtend.Name = "dtend";
            dtend.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtend.Size = new Size(223, 36);
            dtend.TabIndex = 5;
            dtend.Value = new DateTime(2025, 12, 18, 21, 43, 24, 107);
            dtend.ValueChanged += dtend_ValueChanged_1;
            // 
            // noleave
            // 
            noleave.BackColor = Color.Transparent;
            noleave.BorderRadius = 10;
            noleave.CustomizableEdges = customizableEdges5;
            noleave.Font = new Font("Segoe UI", 9F);
            noleave.Location = new Point(220, 141);
            noleave.Name = "noleave";
            noleave.ShadowDecoration.CustomizableEdges = customizableEdges6;
            noleave.Size = new Size(100, 36);
            noleave.TabIndex = 6;
            // 
            // textdaterange
            // 
            textdaterange.BorderRadius = 10;
            textdaterange.CustomizableEdges = customizableEdges7;
            textdaterange.DefaultText = "";
            textdaterange.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textdaterange.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textdaterange.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textdaterange.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textdaterange.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textdaterange.Font = new Font("Segoe UI", 9F);
            textdaterange.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textdaterange.Location = new Point(220, 197);
            textdaterange.Name = "textdaterange";
            textdaterange.PasswordChar = '\0';
            textdaterange.PlaceholderText = "Enter Cycle Range";
            textdaterange.SelectedText = "";
            textdaterange.ShadowDecoration.CustomizableEdges = customizableEdges8;
            textdaterange.Size = new Size(200, 36);
            textdaterange.TabIndex = 7;
            textdaterange.TextChanged += textdaterange_TextChanged;
            // 
            // btninsert
            // 
            btninsert.BorderRadius = 15;
            btninsert.CustomizableEdges = customizableEdges9;
            btninsert.DisabledState.BorderColor = Color.DarkGray;
            btninsert.DisabledState.CustomBorderColor = Color.DarkGray;
            btninsert.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btninsert.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btninsert.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btninsert.FillColor = Color.Black;
            btninsert.FillColor2 = Color.Silver;
            btninsert.Font = new Font("Bernard MT Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninsert.ForeColor = Color.White;
            btninsert.Location = new Point(249, 270);
            btninsert.Name = "btninsert";
            btninsert.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btninsert.Size = new Size(109, 39);
            btninsert.TabIndex = 8;
            btninsert.Text = "Insert";
            btninsert.Click += btninsert_Click_1;
            // 
            // back
            // 
            back.BackColor = Color.Transparent;
            back.BackgroundImage = (Image)resources.GetObject("back.BackgroundImage");
            back.BackgroundImageLayout = ImageLayout.Zoom;
            back.CheckedState.ImageSize = new Size(64, 64);
            back.HoverState.ImageSize = new Size(64, 64);
            back.Image = (Image)resources.GetObject("back.Image");
            back.ImageOffset = new Point(0, 0);
            back.ImageRotate = 0F;
            back.ImageSize = new Size(1, 1);
            back.Location = new Point(0, 0);
            back.Name = "back";
            back.PressedState.ImageSize = new Size(64, 64);
            back.ShadowDecoration.CustomizableEdges = customizableEdges11;
            back.Size = new Size(28, 28);
            back.TabIndex = 9;
            back.UseWaitCursor = true;
            back.Click += back_Click;
            // 
            // close
            // 
            close.BackColor = Color.Transparent;
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.CheckedState.ImageSize = new Size(64, 64);
            close.HoverState.ImageSize = new Size(64, 64);
            close.Image = (Image)resources.GetObject("close.Image");
            close.ImageOffset = new Point(0, 0);
            close.ImageRotate = 0F;
            close.ImageSize = new Size(1, 1);
            close.Location = new Point(551, 0);
            close.Name = "close";
            close.PressedState.ImageSize = new Size(64, 64);
            close.ShadowDecoration.CustomizableEdges = customizableEdges12;
            close.Size = new Size(28, 28);
            close.TabIndex = 10;
            close.UseWaitCursor = true;
            close.Click += close_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(579, 345);
            Controls.Add(close);
            Controls.Add(back);
            Controls.Add(btninsert);
            Controls.Add(textdaterange);
            Controls.Add(noleave);
            Controls.Add(dtend);
            Controls.Add(dtstart);
            Controls.Add(RangeCycle);
            Controls.Add(No_of_leaves);
            Controls.Add(EndDate);
            Controls.Add(StartDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)noleaves).EndInit();
            ((System.ComponentModel.ISupportInitialize)noleave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dtend_ValueChanged(object sender, EventArgs e)
        {
            
        }

#endregion
        private NumericUpDown noleaves;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox txtdaterange;
        private Bunifu.UI.WinForms.BunifuDatePicker dateend;
        private Bunifu.UI.WinForms.BunifuDatePicker datestart;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 butninsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel StartDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel EndDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel No_of_leaves;
        private Guna.UI2.WinForms.Guna2HtmlLabel RangeCycle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtstart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtend;
        private Guna.UI2.WinForms.Guna2NumericUpDown noleave;
        private Guna.UI2.WinForms.Guna2TextBox textdaterange;
        private Guna.UI2.WinForms.Guna2GradientButton btninsert;
        private Guna.UI2.WinForms.Guna2ImageButton back;
        private Guna.UI2.WinForms.Guna2ImageButton close;
    }
}