namespace Barks
{
    partial class Bark
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
            this.lb_titel = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.rhtb_text = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Accountname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titel
            // 
            this.lb_titel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_titel.AutoSize = true;
            this.lb_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titel.ForeColor = System.Drawing.Color.Yellow;
            this.lb_titel.Location = new System.Drawing.Point(7, 46);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(51, 25);
            this.lb_titel.TabIndex = 0;
            this.lb_titel.Text = "titel";
            // 
            // lbl_datum
            // 
            this.lbl_datum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_datum.Location = new System.Drawing.Point(325, 0);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(36, 13);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "datum";
            // 
            // rhtb_text
            // 
            this.rhtb_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rhtb_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rhtb_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rhtb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhtb_text.ForeColor = System.Drawing.Color.Yellow;
            this.rhtb_text.Location = new System.Drawing.Point(12, 75);
            this.rhtb_text.Name = "rhtb_text";
            this.rhtb_text.ReadOnly = true;
            this.rhtb_text.Size = new System.Drawing.Size(217, 132);
            this.rhtb_text.TabIndex = 3;
            this.rhtb_text.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(235, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 132);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Accountname
            // 
            this.lb_Accountname.AutoSize = true;
            this.lb_Accountname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Accountname.ForeColor = System.Drawing.Color.Yellow;
            this.lb_Accountname.Location = new System.Drawing.Point(8, 12);
            this.lb_Accountname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Accountname.Name = "lb_Accountname";
            this.lb_Accountname.Size = new System.Drawing.Size(80, 20);
            this.lb_Accountname.TabIndex = 5;
            this.lb_Accountname.Text = "username";
            // 
            // Bark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lb_Accountname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rhtb_text);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lb_titel);
            this.Name = "Bark";
            this.Size = new System.Drawing.Size(427, 206);
            this.Load += new System.EventHandler(this.Bark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lb_titel;
        public System.Windows.Forms.Label lbl_datum;
        public System.Windows.Forms.RichTextBox rhtb_text;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lb_Accountname;
    }
}
