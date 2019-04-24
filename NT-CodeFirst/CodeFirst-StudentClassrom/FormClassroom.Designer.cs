namespace CodeFirst_StudentClassrom
{
    partial class FormClassroom
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
            this.dgvClassroom = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecriptionInsert = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnDescriptionDelete = new System.Windows.Forms.Button();
            this.btnDescriptionUpdate = new System.Windows.Forms.Button();
            this.btnDescriptionMultiSelectedIDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassroom
            // 
            this.dgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassroom.Location = new System.Drawing.Point(56, 118);
            this.dgvClassroom.Name = "dgvClassroom";
            this.dgvClassroom.Size = new System.Drawing.Size(462, 184);
            this.dgvClassroom.TabIndex = 11;
            this.dgvClassroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClassroom_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Description";
            // 
            // btnDecriptionInsert
            // 
            this.btnDecriptionInsert.Location = new System.Drawing.Point(226, 37);
            this.btnDecriptionInsert.Name = "btnDecriptionInsert";
            this.btnDecriptionInsert.Size = new System.Drawing.Size(118, 20);
            this.btnDecriptionInsert.TabIndex = 8;
            this.btnDecriptionInsert.Text = "INSERT";
            this.btnDecriptionInsert.UseVisualStyleBackColor = true;
            this.btnDecriptionInsert.Click += new System.EventHandler(this.btnDecriptionInsert_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(56, 58);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(153, 20);
            this.tbDescription.TabIndex = 6;
            // 
            // btnDescriptionDelete
            // 
            this.btnDescriptionDelete.Location = new System.Drawing.Point(362, 37);
            this.btnDescriptionDelete.Name = "btnDescriptionDelete";
            this.btnDescriptionDelete.Size = new System.Drawing.Size(156, 20);
            this.btnDescriptionDelete.TabIndex = 12;
            this.btnDescriptionDelete.Text = "DELETE";
            this.btnDescriptionDelete.UseVisualStyleBackColor = true;
            this.btnDescriptionDelete.Click += new System.EventHandler(this.btnDescriptionDelete_Click);
            // 
            // btnDescriptionUpdate
            // 
            this.btnDescriptionUpdate.Location = new System.Drawing.Point(226, 63);
            this.btnDescriptionUpdate.Name = "btnDescriptionUpdate";
            this.btnDescriptionUpdate.Size = new System.Drawing.Size(118, 20);
            this.btnDescriptionUpdate.TabIndex = 13;
            this.btnDescriptionUpdate.Text = "UPDATE";
            this.btnDescriptionUpdate.UseVisualStyleBackColor = true;
            this.btnDescriptionUpdate.Click += new System.EventHandler(this.btnDescriptionUpdate_Click);
            // 
            // btnDescriptionMultiSelectedIDelete
            // 
            this.btnDescriptionMultiSelectedIDelete.Location = new System.Drawing.Point(362, 63);
            this.btnDescriptionMultiSelectedIDelete.Name = "btnDescriptionMultiSelectedIDelete";
            this.btnDescriptionMultiSelectedIDelete.Size = new System.Drawing.Size(156, 20);
            this.btnDescriptionMultiSelectedIDelete.TabIndex = 14;
            this.btnDescriptionMultiSelectedIDelete.Text = "DELETE SELECTED ITEMS";
            this.btnDescriptionMultiSelectedIDelete.UseVisualStyleBackColor = true;
            this.btnDescriptionMultiSelectedIDelete.Click += new System.EventHandler(this.btnDescriptionMultiSelectedIDelete_Click);
            // 
            // FormClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnDescriptionMultiSelectedIDelete);
            this.Controls.Add(this.btnDescriptionUpdate);
            this.Controls.Add(this.btnDescriptionDelete);
            this.Controls.Add(this.dgvClassroom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecriptionInsert);
            this.Controls.Add(this.tbDescription);
            this.Name = "FormClassroom";
            this.Text = "FormClassroom";
            this.Load += new System.EventHandler(this.FormClassroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecriptionInsert;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnDescriptionDelete;
        private System.Windows.Forms.Button btnDescriptionUpdate;
        private System.Windows.Forms.Button btnDescriptionMultiSelectedIDelete;
    }
}