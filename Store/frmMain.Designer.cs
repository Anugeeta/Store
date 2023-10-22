namespace Store
{
    partial class frmMain
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
            this.ControlPane = new Guna.UI.WinForms.GunaTextBox();
            this.btnexit = new Guna.UI.WinForms.GunaControlBox();
            this.btnmini = new Guna.UI.WinForms.GunaControlBox();
            this.btnmaxi = new Guna.UI.WinForms.GunaControlBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btncategory = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlPane
            // 
            this.ControlPane.BaseColor = System.Drawing.Color.White;
            this.ControlPane.BorderColor = System.Drawing.Color.Silver;
            this.ControlPane.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ControlPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlPane.FocusedBaseColor = System.Drawing.Color.White;
            this.ControlPane.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ControlPane.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.ControlPane.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ControlPane.Location = new System.Drawing.Point(0, 0);
            this.ControlPane.Margin = new System.Windows.Forms.Padding(2);
            this.ControlPane.Name = "ControlPane";
            this.ControlPane.PasswordChar = '\0';
            this.ControlPane.SelectedText = "";
            this.ControlPane.Size = new System.Drawing.Size(960, 591);
            this.ControlPane.TabIndex = 1;
            this.ControlPane.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.AnimationHoverSpeed = 0.07F;
            this.btnexit.AnimationSpeed = 0.03F;
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnexit.IconColor = System.Drawing.Color.White;
            this.btnexit.IconSize = 15F;
            this.btnexit.Location = new System.Drawing.Point(715, 19);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnexit.OnHoverIconColor = System.Drawing.Color.White;
            this.btnexit.OnPressedColor = System.Drawing.Color.Black;
            this.btnexit.Size = new System.Drawing.Size(34, 24);
            this.btnexit.TabIndex = 3;
            // 
            // btnmini
            // 
            this.btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmini.AnimationHoverSpeed = 0.07F;
            this.btnmini.AnimationSpeed = 0.03F;
            this.btnmini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnmini.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.btnmini.IconColor = System.Drawing.Color.White;
            this.btnmini.IconSize = 15F;
            this.btnmini.Location = new System.Drawing.Point(616, 19);
            this.btnmini.Margin = new System.Windows.Forms.Padding(2);
            this.btnmini.Name = "btnmini";
            this.btnmini.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnmini.OnHoverIconColor = System.Drawing.Color.White;
            this.btnmini.OnPressedColor = System.Drawing.Color.Black;
            this.btnmini.Size = new System.Drawing.Size(34, 24);
            this.btnmini.TabIndex = 4;
            // 
            // btnmaxi
            // 
            this.btnmaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxi.AnimationHoverSpeed = 0.07F;
            this.btnmaxi.AnimationSpeed = 0.03F;
            this.btnmaxi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnmaxi.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.btnmaxi.IconColor = System.Drawing.Color.White;
            this.btnmaxi.IconSize = 15F;
            this.btnmaxi.Location = new System.Drawing.Point(665, 19);
            this.btnmaxi.Margin = new System.Windows.Forms.Padding(2);
            this.btnmaxi.Name = "btnmaxi";
            this.btnmaxi.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnmaxi.OnHoverIconColor = System.Drawing.Color.White;
            this.btnmaxi.OnPressedColor = System.Drawing.Color.Black;
            this.btnmaxi.Size = new System.Drawing.Size(34, 24);
            this.btnmaxi.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Store.Properties.Resources.dep2;
            this.pictureBox1.Location = new System.Drawing.Point(50, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "Departmental Store Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnhome
            // 
            this.btnhome.AutoEllipsis = true;
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.IndianRed;
            this.btnhome.Location = new System.Drawing.Point(36, 271);
            this.btnhome.Margin = new System.Windows.Forms.Padding(2);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(106, 37);
            this.btnhome.TabIndex = 8;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.AutoEllipsis = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.IndianRed;
            this.button5.Location = new System.Drawing.Point(36, 461);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "Stock";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnproducts
            // 
            this.btnproducts.AutoEllipsis = true;
            this.btnproducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnproducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.ForeColor = System.Drawing.Color.IndianRed;
            this.btnproducts.Location = new System.Drawing.Point(36, 402);
            this.btnproducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(106, 37);
            this.btnproducts.TabIndex = 13;
            this.btnproducts.Text = "Products";
            this.btnproducts.UseVisualStyleBackColor = false;
            // 
            // btncategory
            // 
            this.btncategory.AutoEllipsis = true;
            this.btncategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btncategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategory.ForeColor = System.Drawing.Color.IndianRed;
            this.btncategory.Location = new System.Drawing.Point(36, 338);
            this.btncategory.Margin = new System.Windows.Forms.Padding(2);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(106, 37);
            this.btncategory.TabIndex = 14;
            this.btncategory.Text = "Categories";
            this.btncategory.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.AutoEllipsis = true;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.IndianRed;
            this.button8.Location = new System.Drawing.Point(36, 521);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 37);
            this.button8.TabIndex = 15;
            this.button8.Text = "Settings";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Gainsboro;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(107, 19);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(52, 21);
            this.lbluser.TabIndex = 16;
            this.lbluser.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Welcome";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.gunaPanel1.Controls.Add(this.pictureBox1);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.btnhome);
            this.gunaPanel1.Controls.Add(this.button8);
            this.gunaPanel1.Controls.Add(this.btncategory);
            this.gunaPanel1.Controls.Add(this.button5);
            this.gunaPanel1.Controls.Add(this.btnproducts);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(200, 591);
            this.gunaPanel1.TabIndex = 18;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(760, 591);
            this.gunaPanel2.TabIndex = 19;
            this.gunaPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel2_Paint);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel3.Controls.Add(this.label2);
            this.gunaPanel3.Controls.Add(this.lbluser);
            this.gunaPanel3.Controls.Add(this.btnmini);
            this.gunaPanel3.Controls.Add(this.btnmaxi);
            this.gunaPanel3.Controls.Add(this.btnexit);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(200, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(760, 49);
            this.gunaPanel3.TabIndex = 19;
            this.gunaPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel3_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 591);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.ControlPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox ControlPane;
        private Guna.UI.WinForms.GunaControlBox btnexit;
        private Guna.UI.WinForms.GunaControlBox btnmini;
        private Guna.UI.WinForms.GunaControlBox btnmaxi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
    }
}