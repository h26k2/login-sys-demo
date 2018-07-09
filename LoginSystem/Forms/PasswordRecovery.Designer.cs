namespace LoginSystem.Forms {
    partial class PasswordRecovery {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.headliner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sendcode_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goBack_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.headliner.AutoSize = true;
            this.headliner.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headliner.Location = new System.Drawing.Point(93, 55);
            this.headliner.Name = "label1";
            this.headliner.Size = new System.Drawing.Size(380, 56);
            this.headliner.TabIndex = 0;
            this.headliner.Text = "Password Recovery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter email or username";
            // 
            // button2
            // 
            this.sendcode_Button.Location = new System.Drawing.Point(360, 228);
            this.sendcode_Button.Name = "button2";
            this.sendcode_Button.Size = new System.Drawing.Size(113, 43);
            this.sendcode_Button.TabIndex = 3;
            this.sendcode_Button.Text = "Send Code";
            this.sendcode_Button.UseVisualStyleBackColor = true;
            this.sendcode_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 42);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.goBack_Button.Location = new System.Drawing.Point(50, 228);
            this.goBack_Button.Name = "button3";
            this.goBack_Button.Size = new System.Drawing.Size(101, 43);
            this.goBack_Button.TabIndex = 5;
            this.goBack_Button.Text = "Go Back";
            this.goBack_Button.UseVisualStyleBackColor = true;
            this.goBack_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 304);
            this.Controls.Add(this.goBack_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sendcode_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headliner);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordRecovery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headliner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendcode_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goBack_Button;
    }
}