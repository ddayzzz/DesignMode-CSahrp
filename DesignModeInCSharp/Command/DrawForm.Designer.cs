namespace DesignModeInCSharp.Command
{
    partial class DrawForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.drawPanel1 = new DesignModeInCSharp.Command.DrawPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(877, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(877, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Undo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawPanel1
            // 
            this.drawPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.drawPanel1.Location = new System.Drawing.Point(0, 46);
            this.drawPanel1.Name = "drawPanel1";
            this.drawPanel1.Size = new System.Drawing.Size(877, 361);
            this.drawPanel1.TabIndex = 0;
            this.drawPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawForm_MouseDown);
            this.drawPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel1_MouseUp);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 404);
            this.Controls.Add(this.drawPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DrawForm";
            this.Text = "DrawFormcs";
            this.ResumeLayout(false);

        }

        #endregion

        private DrawPanel drawPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}