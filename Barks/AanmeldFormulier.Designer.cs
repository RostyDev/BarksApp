namespace Barks
{
    partial class AanmeldFormulier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Aanmelden = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_YesAccount = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(968, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 693);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 693);
            this.panel2.TabIndex = 1;
            // 
            // btn_Aanmelden
            // 
            this.btn_Aanmelden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aanmelden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Aanmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aanmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aanmelden.Location = new System.Drawing.Point(153, 525);
            this.btn_Aanmelden.Name = "btn_Aanmelden";
            this.btn_Aanmelden.Size = new System.Drawing.Size(266, 66);
            this.btn_Aanmelden.TabIndex = 10;
            this.btn_Aanmelden.Text = "aanmelden";
            this.btn_Aanmelden.UseVisualStyleBackColor = false;
            this.btn_Aanmelden.Click += new System.EventHandler(this.btn_Aanmelden_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Controls.Add(this.lb_YesAccount);
            this.panel3.Controls.Add(this.btn_Aanmelden);
            this.panel3.Location = new System.Drawing.Point(380, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 637);
            this.panel3.TabIndex = 11;
            // 
            // lb_YesAccount
            // 
            this.lb_YesAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_YesAccount.AutoSize = true;
            this.lb_YesAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_YesAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_YesAccount.Location = new System.Drawing.Point(192, 603);
            this.lb_YesAccount.Name = "lb_YesAccount";
            this.lb_YesAccount.Size = new System.Drawing.Size(199, 20);
            this.lb_YesAccount.TabIndex = 11;
            this.lb_YesAccount.Text = "Al een account? Klik hier!";
            this.lb_YesAccount.Click += new System.EventHandler(this.lb_YesAccount_Click);
            // 
            // AanmeldFormulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AanmeldFormulier";
            this.Size = new System.Drawing.Size(1352, 693);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Aanmelden;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_YesAccount;
    }
}
