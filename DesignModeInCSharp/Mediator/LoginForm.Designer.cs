namespace DesignModeInCSharp.Mediator
{
    partial class LoginForm
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
            this.colleagueTextField_username = new DesignModeInCSharp.Mediator.ColleagueTextField();
            this.colleagueCheckBox2 = new DesignModeInCSharp.Mediator.ColleagueCheckBox();
            this.colleagueCheckBox1 = new DesignModeInCSharp.Mediator.ColleagueCheckBox();
            this.colleagueButton_cancel = new DesignModeInCSharp.Mediator.ColleagueButton();
            this.colleagueButton_ok = new DesignModeInCSharp.Mediator.ColleagueButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colleagueTextField_password = new DesignModeInCSharp.Mediator.ColleagueTextField();
            this.SuspendLayout();
            // 
            // colleagueTextField_username
            // 
            this.colleagueTextField_username.Location = new System.Drawing.Point(130, 64);
            this.colleagueTextField_username.Name = "colleagueTextField_username";
            this.colleagueTextField_username.Size = new System.Drawing.Size(340, 25);
            this.colleagueTextField_username.TabIndex = 4;
            // 
            // colleagueCheckBox2
            // 
            this.colleagueCheckBox2.AutoSize = true;
            this.colleagueCheckBox2.Location = new System.Drawing.Point(130, 22);
            this.colleagueCheckBox2.Name = "colleagueCheckBox2";
            this.colleagueCheckBox2.Size = new System.Drawing.Size(59, 19);
            this.colleagueCheckBox2.TabIndex = 3;
            this.colleagueCheckBox2.Text = "登录";
            this.colleagueCheckBox2.UseVisualStyleBackColor = true;
            // 
            // colleagueCheckBox1
            // 
            this.colleagueCheckBox1.AutoSize = true;
            this.colleagueCheckBox1.Location = new System.Drawing.Point(39, 22);
            this.colleagueCheckBox1.Name = "colleagueCheckBox1";
            this.colleagueCheckBox1.Size = new System.Drawing.Size(59, 19);
            this.colleagueCheckBox1.TabIndex = 2;
            this.colleagueCheckBox1.Text = "游客";
            this.colleagueCheckBox1.UseVisualStyleBackColor = true;
            // 
            // colleagueButton_cancel
            // 
            this.colleagueButton_cancel.Location = new System.Drawing.Point(381, 158);
            this.colleagueButton_cancel.Name = "colleagueButton_cancel";
            this.colleagueButton_cancel.Size = new System.Drawing.Size(89, 27);
            this.colleagueButton_cancel.TabIndex = 1;
            this.colleagueButton_cancel.Text = "取消";
            this.colleagueButton_cancel.UseVisualStyleBackColor = true;
            // 
            // colleagueButton_ok
            // 
            this.colleagueButton_ok.Location = new System.Drawing.Point(274, 158);
            this.colleagueButton_ok.Name = "colleagueButton_ok";
            this.colleagueButton_ok.Size = new System.Drawing.Size(89, 27);
            this.colleagueButton_ok.TabIndex = 0;
            this.colleagueButton_ok.Text = "确定";
            this.colleagueButton_ok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码：";
            // 
            // colleagueTextField_password
            // 
            this.colleagueTextField_password.Location = new System.Drawing.Point(130, 105);
            this.colleagueTextField_password.Name = "colleagueTextField_password";
            this.colleagueTextField_password.PasswordChar = '*';
            this.colleagueTextField_password.Size = new System.Drawing.Size(340, 25);
            this.colleagueTextField_password.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 199);
            this.Controls.Add(this.colleagueTextField_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colleagueTextField_username);
            this.Controls.Add(this.colleagueCheckBox2);
            this.Controls.Add(this.colleagueCheckBox1);
            this.Controls.Add(this.colleagueButton_cancel);
            this.Controls.Add(this.colleagueButton_ok);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueButton colleagueButton_ok;
        private ColleagueButton colleagueButton_cancel;
        private ColleagueCheckBox colleagueCheckBox1;
        private ColleagueCheckBox colleagueCheckBox2;
        private ColleagueTextField colleagueTextField_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ColleagueTextField colleagueTextField_password;
    }
}