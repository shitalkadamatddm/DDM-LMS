namespace DDM_LMS
{
    partial class EditStaffUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchEmployeeEsUc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewEmployeeSearchResult = new System.Windows.Forms.DataGridView();
            this.buttonSearchEmployeeEsUc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 29);
            this.label1.TabIndex = 69;
            this.label1.Text = "Diabetes Digital Media Leaves Management System";
            // 
            // textBoxSearchEmployeeEsUc
            // 
            this.textBoxSearchEmployeeEsUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchEmployeeEsUc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxSearchEmployeeEsUc.Location = new System.Drawing.Point(98, 105);
            this.textBoxSearchEmployeeEsUc.Name = "textBoxSearchEmployeeEsUc";
            this.textBoxSearchEmployeeEsUc.Size = new System.Drawing.Size(383, 23);
            this.textBoxSearchEmployeeEsUc.TabIndex = 71;
            this.textBoxSearchEmployeeEsUc.Text = "Please enter employee email address";
            this.textBoxSearchEmployeeEsUc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(271, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 22);
            this.label14.TabIndex = 72;
            this.label14.Text = "Edit/Delete Employee";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DDM_LMS.Properties.Resources.Search_icon24;
            this.pictureBox2.Location = new System.Drawing.Point(52, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 31);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DDM_LMS.Properties.Resources.hope;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 63);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewEmployeeSearchResult
            // 
            this.dataGridViewEmployeeSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeSearchResult.Location = new System.Drawing.Point(52, 159);
            this.dataGridViewEmployeeSearchResult.Name = "dataGridViewEmployeeSearchResult";
            this.dataGridViewEmployeeSearchResult.Size = new System.Drawing.Size(619, 81);
            this.dataGridViewEmployeeSearchResult.TabIndex = 76;
            // 
            // buttonSearchEmployeeEsUc
            // 
            this.buttonSearchEmployeeEsUc.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSearchEmployeeEsUc.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearchEmployeeEsUc.FlatAppearance.BorderSize = 0;
            this.buttonSearchEmployeeEsUc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchEmployeeEsUc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchEmployeeEsUc.ForeColor = System.Drawing.Color.White;
            this.buttonSearchEmployeeEsUc.Location = new System.Drawing.Point(518, 99);
            this.buttonSearchEmployeeEsUc.Name = "buttonSearchEmployeeEsUc";
            this.buttonSearchEmployeeEsUc.Size = new System.Drawing.Size(153, 37);
            this.buttonSearchEmployeeEsUc.TabIndex = 77;
            this.buttonSearchEmployeeEsUc.Text = "Search";
            this.buttonSearchEmployeeEsUc.UseVisualStyleBackColor = false;
            this.buttonSearchEmployeeEsUc.Click += new System.EventHandler(this.buttonSearchEmployeeEsUc_Click);
            // 
            // EditStaffUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSearchEmployeeEsUc);
            this.Controls.Add(this.dataGridViewEmployeeSearchResult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxSearchEmployeeEsUc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditStaffUserControl";
            this.Size = new System.Drawing.Size(722, 566);
            this.Load += new System.EventHandler(this.EditStaffUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchEmployeeEsUc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeSearchResult;
        private System.Windows.Forms.Button buttonSearchEmployeeEsUc;
    }
}
