namespace Barks
{
    partial class barkspagine
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bark1 = new Barks.Bark();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bark1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(119, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 606);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bark1
            // 
            this.bark1.BackColor = System.Drawing.Color.Gray;
            this.bark1.Location = new System.Drawing.Point(3, 3);
            this.bark1.Name = "bark1";
            this.bark1.Size = new System.Drawing.Size(427, 242);
            this.bark1.TabIndex = 0;
            // 
            // barkspagine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "barkspagine";
            this.Size = new System.Drawing.Size(1023, 645);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bark bark1;
    }
}
