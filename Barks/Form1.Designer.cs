namespace Barks
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Uitlog = new System.Windows.Forms.Button();
            this.btn_CloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 68);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Uitlog);
            this.panel2.Controls.Add(this.btn_CloseForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(886, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 68);
            this.panel2.TabIndex = 2;
            // 
            // btn_Uitlog
            // 
            this.btn_Uitlog.BackColor = System.Drawing.Color.Black;
            this.btn_Uitlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Uitlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Uitlog.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Uitlog.Location = new System.Drawing.Point(2, 18);
            this.btn_Uitlog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Uitlog.Name = "btn_Uitlog";
            this.btn_Uitlog.Size = new System.Drawing.Size(91, 37);
            this.btn_Uitlog.TabIndex = 1;
            this.btn_Uitlog.Text = "uitloggen";
            this.btn_Uitlog.UseVisualStyleBackColor = false;
            this.btn_Uitlog.Visible = false;
            this.btn_Uitlog.Click += new System.EventHandler(this.btn_Uitlog_Click);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.Black;
            this.btn_CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseForm.ForeColor = System.Drawing.Color.Yellow;
            this.btn_CloseForm.Location = new System.Drawing.Point(97, 18);
            this.btn_CloseForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(37, 37);
            this.btn_CloseForm.TabIndex = 0;
            this.btn_CloseForm.Text = "X";
            this.btn_CloseForm.UseVisualStyleBackColor = false;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1022, 713);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CloseForm;
        private System.Windows.Forms.Panel panel2;
        //private InlogScreen inlogScreen1;
        private System.Windows.Forms.Button btn_Uitlog;
    }
}

