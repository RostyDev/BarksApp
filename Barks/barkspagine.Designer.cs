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
            this.flp_BarksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_BarksPanel
            // 
            this.flp_BarksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flp_BarksPanel.BackColor = System.Drawing.Color.Gray;
            this.flp_BarksPanel.Location = new System.Drawing.Point(349, 0);
            this.flp_BarksPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flp_BarksPanel.Name = "flp_BarksPanel";
            this.flp_BarksPanel.Size = new System.Drawing.Size(621, 701);
            this.flp_BarksPanel.TabIndex = 0;
            // 
            // barkspagine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.flp_BarksPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "barkspagine";
            this.Size = new System.Drawing.Size(1339, 701);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_BarksPanel;
    }
}
