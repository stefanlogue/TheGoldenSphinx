namespace TheGoldenSphinx
{
    partial class frmViewSuppliers
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
            this.btnViewSuppliersCancel = new System.Windows.Forms.Button();
            this.btnViewSuppliersDelete = new System.Windows.Forms.Button();
            this.btnViewSuppliersEdit = new System.Windows.Forms.Button();
            this.dgvViewSuppliersGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSuppliersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewSuppliersCancel
            // 
            this.btnViewSuppliersCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewSuppliersCancel.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewSuppliersCancel.Location = new System.Drawing.Point(784, 314);
            this.btnViewSuppliersCancel.Name = "btnViewSuppliersCancel";
            this.btnViewSuppliersCancel.Size = new System.Drawing.Size(154, 59);
            this.btnViewSuppliersCancel.TabIndex = 6;
            this.btnViewSuppliersCancel.Text = "Cancel";
            this.btnViewSuppliersCancel.UseVisualStyleBackColor = false;
            this.btnViewSuppliersCancel.Click += new System.EventHandler(this.btnViewSuppliersCancel_Click);
            // 
            // btnViewSuppliersDelete
            // 
            this.btnViewSuppliersDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewSuppliersDelete.Enabled = false;
            this.btnViewSuppliersDelete.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersDelete.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewSuppliersDelete.Location = new System.Drawing.Point(784, 217);
            this.btnViewSuppliersDelete.Name = "btnViewSuppliersDelete";
            this.btnViewSuppliersDelete.Size = new System.Drawing.Size(154, 59);
            this.btnViewSuppliersDelete.TabIndex = 5;
            this.btnViewSuppliersDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnViewSuppliersDelete, "Deleting records cannot be undone!");
            this.btnViewSuppliersDelete.UseVisualStyleBackColor = false;
            this.btnViewSuppliersDelete.Click += new System.EventHandler(this.btnViewSuppliersDelete_Click);
            // 
            // btnViewSuppliersEdit
            // 
            this.btnViewSuppliersEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnViewSuppliersEdit.FlatAppearance.BorderSize = 0;
            this.btnViewSuppliersEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliersEdit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliersEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewSuppliersEdit.Location = new System.Drawing.Point(784, 120);
            this.btnViewSuppliersEdit.Name = "btnViewSuppliersEdit";
            this.btnViewSuppliersEdit.Size = new System.Drawing.Size(154, 59);
            this.btnViewSuppliersEdit.TabIndex = 4;
            this.btnViewSuppliersEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnViewSuppliersEdit, "Unlocks the Table to be edited. \r\nDouble click to edit a field. \r\nClick Save to s" +
        "ave changes\r\n");
            this.btnViewSuppliersEdit.UseVisualStyleBackColor = false;
            this.btnViewSuppliersEdit.Click += new System.EventHandler(this.btnViewSuppliersEdit_Click);
            // 
            // dgvViewSuppliersGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvViewSuppliersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViewSuppliersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewSuppliersGridView.BackgroundColor = System.Drawing.Color.White;
            this.dgvViewSuppliersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViewSuppliersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvViewSuppliersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewSuppliersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViewSuppliersGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViewSuppliersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViewSuppliersGridView.DoubleBuffered = true;
            this.dgvViewSuppliersGridView.EnableHeadersVisualStyles = false;
            this.dgvViewSuppliersGridView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dgvViewSuppliersGridView.HeaderForeColor = System.Drawing.Color.Gainsboro;
            this.dgvViewSuppliersGridView.Location = new System.Drawing.Point(12, 12);
            this.dgvViewSuppliersGridView.Name = "dgvViewSuppliersGridView";
            this.dgvViewSuppliersGridView.ReadOnly = true;
            this.dgvViewSuppliersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvViewSuppliersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvViewSuppliersGridView.RowHeadersVisible = false;
            this.dgvViewSuppliersGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            this.dgvViewSuppliersGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvViewSuppliersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewSuppliersGridView.Size = new System.Drawing.Size(765, 625);
            this.dgvViewSuppliersGridView.TabIndex = 7;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dgvViewSuppliersGridView;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // frmViewSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dgvViewSuppliersGridView);
            this.Controls.Add(this.btnViewSuppliersCancel);
            this.Controls.Add(this.btnViewSuppliersDelete);
            this.Controls.Add(this.btnViewSuppliersEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewSuppliers";
            this.Text = "frmViewSuppliers";
            this.Load += new System.EventHandler(this.frmViewSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSuppliersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewSuppliersCancel;
        private System.Windows.Forms.Button btnViewSuppliersDelete;
        private System.Windows.Forms.Button btnViewSuppliersEdit;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvViewSuppliersGridView;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}