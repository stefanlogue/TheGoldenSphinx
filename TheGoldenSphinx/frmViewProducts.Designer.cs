namespace TheGoldenSphinx
{
    partial class frmViewProducts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnViewProductsEdit = new System.Windows.Forms.Button();
            this.btnViewProductsDelete = new System.Windows.Forms.Button();
            this.btnViewProductsCancel = new System.Windows.Forms.Button();
            this.dgvViewProductsGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewProductsEdit
            // 
            this.btnViewProductsEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewProductsEdit.FlatAppearance.BorderSize = 0;
            this.btnViewProductsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewProductsEdit.Location = new System.Drawing.Point(784, 120);
            this.btnViewProductsEdit.Name = "btnViewProductsEdit";
            this.btnViewProductsEdit.Size = new System.Drawing.Size(154, 59);
            this.btnViewProductsEdit.TabIndex = 1;
            this.btnViewProductsEdit.Text = "Edit";
            this.btnViewProductsEdit.UseVisualStyleBackColor = false;
            // 
            // btnViewProductsDelete
            // 
            this.btnViewProductsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewProductsDelete.FlatAppearance.BorderSize = 0;
            this.btnViewProductsDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewProductsDelete.Location = new System.Drawing.Point(784, 217);
            this.btnViewProductsDelete.Name = "btnViewProductsDelete";
            this.btnViewProductsDelete.Size = new System.Drawing.Size(154, 59);
            this.btnViewProductsDelete.TabIndex = 2;
            this.btnViewProductsDelete.Text = "Delete";
            this.btnViewProductsDelete.UseVisualStyleBackColor = false;
            // 
            // btnViewProductsCancel
            // 
            this.btnViewProductsCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewProductsCancel.FlatAppearance.BorderSize = 0;
            this.btnViewProductsCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProductsCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProductsCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewProductsCancel.Location = new System.Drawing.Point(784, 314);
            this.btnViewProductsCancel.Name = "btnViewProductsCancel";
            this.btnViewProductsCancel.Size = new System.Drawing.Size(154, 59);
            this.btnViewProductsCancel.TabIndex = 3;
            this.btnViewProductsCancel.Text = "Cancel";
            this.btnViewProductsCancel.UseVisualStyleBackColor = false;
            this.btnViewProductsCancel.Click += new System.EventHandler(this.btnViewProductsCancel_Click);
            // 
            // dgvViewProductsGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvViewProductsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewProductsGridView.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewProductsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvViewProductsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewProductsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewProductsGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewProductsGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewProductsGridView.DoubleBuffered = true;
            this.dgvViewProductsGridView.EnableHeadersVisualStyles = false;
            this.dgvViewProductsGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dgvViewProductsGridView.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.dgvViewProductsGridView.Location = new System.Drawing.Point(13, 13);
            this.dgvViewProductsGridView.Name = "dgvViewProductsGridView";
            this.dgvViewProductsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewProductsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewProductsGridView.RowHeadersVisible = false;
            this.dgvViewProductsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvViewProductsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvViewProductsGridView.Size = new System.Drawing.Size(765, 625);
            this.dgvViewProductsGridView.TabIndex = 4;
            this.dgvViewProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewProductsGridView_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dgvViewProductsGridView;
            // 
            // frmViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dgvViewProductsGridView);
            this.Controls.Add(this.btnViewProductsCancel);
            this.Controls.Add(this.btnViewProductsDelete);
            this.Controls.Add(this.btnViewProductsEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewProducts";
            this.Text = "frmViewProducts";
            this.Load += new System.EventHandler(this.frmViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewProductsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewProductsEdit;
        private System.Windows.Forms.Button btnViewProductsDelete;
        private System.Windows.Forms.Button btnViewProductsCancel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewProductsGridView;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}