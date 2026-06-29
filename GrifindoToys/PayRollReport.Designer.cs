namespace GrifindoToys
{
    partial class PayRollReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayRollReport));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dataGridView1 = new DataGridView();
            close = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(775, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            close.Location = new Point(745, 0);
            close.Name = "close";
            close.PressedState.ImageSize = new Size(64, 64);
            close.ShadowDecoration.CustomizableEdges = customizableEdges1;
            close.Size = new Size(28, 28);
            close.TabIndex = 52;
            close.UseWaitCursor = true;
            close.Click += close_Click;
            // 
            // PayRollReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(774, 450);
            Controls.Add(close);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayRollReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayRollReport";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ImageButton close;
    }
}