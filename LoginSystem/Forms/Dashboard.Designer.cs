namespace LoginSystem.Forms {
    partial class Dashboard {
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
            this.headline = new System.Windows.Forms.Label();
            this.sorryLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headline.Location = new System.Drawing.Point(149, 61);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(365, 56);
            this.headline.TabIndex = 0;
            this.headline.Text = "Demo Dashboard";
            // 
            // label2
            // 
            this.sorryLabel.AutoSize = true;
            this.sorryLabel.Location = new System.Drawing.Point(121, 110);
            this.sorryLabel.Name = "sorryLAbel";
            this.sorryLabel.Size = new System.Drawing.Size(481, 35);
            this.sorryLabel.TabIndex = 1;
            this.sorryLabel.Text = "We\'re sorry we are working on this form!";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(188, 158);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(121, 57);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(383, 169);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(131, 35);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Username";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 285);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.sorryLabel);
            this.Controls.Add(this.headline);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Label sorryLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label username_label;
    }
}