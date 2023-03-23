namespace BaiTapBuoiLyThuyet2
{
    partial class CheckListBox_p60
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
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "CC và MT LT 1",
            "Cơ sở dữ liệu",
            "Tiếng Anh 2",
            "Quản trị mạng",
            "Photoshop",
            "Đồ án",
            "Tin học cở sở"});
            this.clbMonHoc.Location = new System.Drawing.Point(142, 169);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(313, 72);
            this.clbMonHoc.TabIndex = 0;
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // btnXemDS
            // 
            this.btnXemDS.Location = new System.Drawing.Point(229, 291);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(127, 23);
            this.btnXemDS.TabIndex = 1;
            this.btnXemDS.Text = "Xem danh sách";
            this.btnXemDS.UseVisualStyleBackColor = true;
            // 
            // CheckListBox_p60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.clbMonHoc);
            this.Name = "CheckListBox_p60";
            this.Text = "Demo CheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Button btnXemDS;
    }
}