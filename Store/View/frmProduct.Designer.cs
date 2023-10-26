namespace Store.View
{
    partial class frmProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridviewproduct = new Guna.UI.WinForms.GunaDataGridView();
            this.combocategory = new Guna.UI.WinForms.GunaComboBox();
            this.btnload = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewproduct
            // 
            this.gridviewproduct.AllowUserToAddRows = false;
            this.gridviewproduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewproduct.BackgroundColor = System.Drawing.Color.White;
            this.gridviewproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridviewproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewproduct.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewproduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewproduct.EnableHeadersVisualStyles = false;
            this.gridviewproduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewproduct.Location = new System.Drawing.Point(132, 121);
            this.gridviewproduct.Name = "gridviewproduct";
            this.gridviewproduct.ReadOnly = true;
            this.gridviewproduct.RowHeadersVisible = false;
            this.gridviewproduct.RowHeadersWidth = 51;
            this.gridviewproduct.RowTemplate.Height = 24;
            this.gridviewproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridviewproduct.Size = new System.Drawing.Size(574, 326);
            this.gridviewproduct.TabIndex = 0;
            this.gridviewproduct.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridviewproduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridviewproduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewproduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridviewproduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewproduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewproduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewproduct.ThemeStyle.HeaderStyle.Height = 40;
            this.gridviewproduct.ThemeStyle.ReadOnly = true;
            this.gridviewproduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewproduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewproduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridviewproduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewproduct.ThemeStyle.RowsStyle.Height = 24;
            this.gridviewproduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewproduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // combocategory
            // 
            this.combocategory.BackColor = System.Drawing.Color.Transparent;
            this.combocategory.BaseColor = System.Drawing.Color.White;
            this.combocategory.BorderColor = System.Drawing.Color.Silver;
            this.combocategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategory.FocusedColor = System.Drawing.Color.Empty;
            this.combocategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combocategory.ForeColor = System.Drawing.Color.Black;
            this.combocategory.FormattingEnabled = true;
            this.combocategory.Items.AddRange(new object[] {
            "DryFruits",
            "Milk"});
            this.combocategory.Location = new System.Drawing.Point(302, 84);
            this.combocategory.Name = "combocategory";
            this.combocategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combocategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combocategory.Size = new System.Drawing.Size(225, 31);
            this.combocategory.TabIndex = 1;
            // 
            // btnload
            // 
            this.btnload.AnimationHoverSpeed = 0.07F;
            this.btnload.AnimationSpeed = 0.03F;
            this.btnload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnload.BorderColor = System.Drawing.Color.Black;
            this.btnload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnload.FocusedColor = System.Drawing.Color.Empty;
            this.btnload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnload.ForeColor = System.Drawing.Color.White;
            this.btnload.Image = null;
            this.btnload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnload.Location = new System.Drawing.Point(228, 471);
            this.btnload.Name = "btnload";
            this.btnload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.btnload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnload.OnHoverImage = null;
            this.btnload.OnPressedColor = System.Drawing.Color.Black;
            this.btnload.Size = new System.Drawing.Size(160, 42);
            this.btnload.TabIndex = 2;
            this.btnload.Text = "Load";
            this.btnload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a category";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(434, 471);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Text = "Generate";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 525);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.combocategory);
            this.Controls.Add(this.gridviewproduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gridviewproduct;
        private Guna.UI.WinForms.GunaComboBox combocategory;
        private Guna.UI.WinForms.GunaButton btnload;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}