namespace DesignModeInCSharp.State
{
    partial class SafeForm
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
            this.components = new System.ComponentModel.Container();
            this.label_time = new System.Windows.Forms.Label();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.button_use = new System.Windows.Forms.Button();
            this.button_alarm = new System.Windows.Forms.Button();
            this.button_phone = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(30, 12);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(55, 15);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "<Time>";
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(33, 37);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.Size = new System.Drawing.Size(571, 282);
            this.textBox_msg.TabIndex = 1;
            // 
            // button_use
            // 
            this.button_use.Location = new System.Drawing.Point(33, 338);
            this.button_use.Name = "button_use";
            this.button_use.Size = new System.Drawing.Size(126, 35);
            this.button_use.TabIndex = 2;
            this.button_use.Text = "使用金库";
            this.button_use.UseVisualStyleBackColor = true;
            this.button_use.Click += new System.EventHandler(this.button_use_Click);
            // 
            // button_alarm
            // 
            this.button_alarm.Location = new System.Drawing.Point(185, 338);
            this.button_alarm.Name = "button_alarm";
            this.button_alarm.Size = new System.Drawing.Size(126, 35);
            this.button_alarm.TabIndex = 3;
            this.button_alarm.Text = "按下警铃";
            this.button_alarm.UseVisualStyleBackColor = true;
            this.button_alarm.Click += new System.EventHandler(this.button_alarm_Click);
            // 
            // button_phone
            // 
            this.button_phone.Location = new System.Drawing.Point(334, 338);
            this.button_phone.Name = "button_phone";
            this.button_phone.Size = new System.Drawing.Size(126, 35);
            this.button_phone.TabIndex = 4;
            this.button_phone.Text = "正常通话";
            this.button_phone.UseVisualStyleBackColor = true;
            this.button_phone.Click += new System.EventHandler(this.button_phone_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(478, 338);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(126, 35);
            this.button_end.TabIndex = 5;
            this.button_end.Text = "结束";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tag = "5秒相当于一个小时";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 384);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_phone);
            this.Controls.Add(this.button_alarm);
            this.Controls.Add(this.button_use);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.label_time);
            this.Name = "SafeForm";
            this.Text = "SafeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.TextBox textBox_msg;
        private System.Windows.Forms.Button button_use;
        private System.Windows.Forms.Button button_alarm;
        private System.Windows.Forms.Button button_phone;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Timer timer1;
    }
}