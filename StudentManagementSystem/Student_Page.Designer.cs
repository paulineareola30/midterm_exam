namespace StudentManagementSystem
{
    partial class Student_Page
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.StudentListDataGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListDataGridView
            // 
            this.StudentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListDataGridView.Location = new System.Drawing.Point(16, 62);
            this.StudentListDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StudentListDataGridView.Name = "StudentListDataGridView";
            this.StudentListDataGridView.RowHeadersWidth = 51;
            this.StudentListDataGridView.Size = new System.Drawing.Size(747, 369);
            this.StudentListDataGridView.TabIndex = 0;
            this.StudentListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentListDataGridView_CellContentClick);
            // Remove Row Header and set AutoSizeMode to fill
            this.StudentListDataGridView.RowHeadersVisible = false;
            this.StudentListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // Remove the empty last row
            this.StudentListDataGridView.AllowUserToAddRows = false; 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(16, 18);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(207, 29);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Student Records";
            // 
            // Student_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 456);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.StudentListDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Student_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Records";
            this.Load += new System.EventHandler(this.Student_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView StudentListDataGridView;
        private System.Windows.Forms.Label TitleLabel;
    }
}
