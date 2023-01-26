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
            this.lb_Accountname = new System.Windows.Forms.Label();
            this.btn_RemoveBark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_titel
            // 
            this.lb_titel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_titel.AutoSize = true;
            this.lb_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titel.ForeColor = System.Drawing.Color.Yellow;
            this.lb_titel.Location = new System.Drawing.Point(9, 57);
            this.lb_titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(62, 31);
            this.lb_titel.TabIndex = 0;
            this.lb_titel.Text = "titel";
            // 
            // lbl_datum
            // 
            this.lbl_datum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_datum.Location = new System.Drawing.Point(433, 0);
            this.lbl_datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(44, 16);
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
            this.rhtb_text.Location = new System.Drawing.Point(16, 92);
            this.rhtb_text.Margin = new System.Windows.Forms.Padding(4);
            this.rhtb_text.Name = "rhtb_text";
            this.rhtb_text.ReadOnly = true;
            this.rhtb_text.Size = new System.Drawing.Size(427, 162);
            this.rhtb_text.TabIndex = 3;
            this.rhtb_text.Text = "";
            // 
            // lb_Accountname
            // 
            this.lb_Accountname.AutoSize = true;
            this.lb_Accountname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Accountname.ForeColor = System.Drawing.Color.Yellow;
            this.lb_Accountname.Location = new System.Drawing.Point(11, 15);
            this.lb_Accountname.Name = "lb_Accountname";
            this.lb_Accountname.Size = new System.Drawing.Size(99, 25);
            this.lb_Accountname.TabIndex = 5;
            this.lb_Accountname.Text = "username";
            this.lb_Accountname.Click += new System.EventHandler(this.lb_Accountname_Click);
            // 
            // btn_RemoveBark
            // 
            this.btn_RemoveBark.BackColor = System.Drawing.Color.Yellow;
            this.btn_RemoveBark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RemoveBark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveBark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveBark.Location = new System.Drawing.Point(512, 214);
            this.btn_RemoveBark.Name = "btn_RemoveBark";
            this.btn_RemoveBark.Size = new System.Drawing.Size(54, 37);
            this.btn_RemoveBark.TabIndex = 7;
            this.btn_RemoveBark.Text = "X";
            this.btn_RemoveBark.UseVisualStyleBackColor = false;
            this.btn_RemoveBark.Visible = false;
            this.btn_RemoveBark.Click += new System.EventHandler(this.btn_RemoveBark_Click);
            // 
            // Bark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btn_RemoveBark);
            this.Controls.Add(this.lb_Accountname);
            this.Controls.Add(this.rhtb_text);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lb_titel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bark";
            this.Size = new System.Drawing.Size(569, 254);
            this.Load += new System.EventHandler(this.Bark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lb_titel;
        public System.Windows.Forms.Label lbl_datum;
        public System.Windows.Forms.RichTextBox rhtb_text;
        public System.Windows.Forms.Label lb_Accountname;
        private System.Windows.Forms.Button btn_RemoveBark;
    }
}
