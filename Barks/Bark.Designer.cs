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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_titel
            // 
            this.lb_titel.AutoSize = true;
            this.lb_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titel.Location = new System.Drawing.Point(3, 0);
            this.lb_titel.Name = "lb_titel";
            this.lb_titel.Size = new System.Drawing.Size(51, 25);
            this.lb_titel.TabIndex = 0;
            this.lb_titel.Text = "titel";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(374, 12);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(36, 13);
            this.lbl_datum.TabIndex = 2;
            this.lbl_datum.Text = "datum";
            // 
            // rhtb_text
            // 
            this.rhtb_text.BackColor = System.Drawing.Color.Gray;
            this.rhtb_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rhtb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rhtb_text.Location = new System.Drawing.Point(3, 28);
            this.rhtb_text.Name = "rhtb_text";
            this.rhtb_text.Size = new System.Drawing.Size(421, 89);
            this.rhtb_text.TabIndex = 3;
            this.rhtb_text.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 119);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Bark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rhtb_text);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lb_titel);
            this.Name = "Bark";
            this.Size = new System.Drawing.Size(427, 242);
            this.Load += new System.EventHandler(this.Bark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titel;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.RichTextBox rhtb_text;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
