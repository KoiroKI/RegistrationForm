namespace RegistrationForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // usernameLabel
            this.usernameLabel.Location = new System.Drawing.Point(12, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);

            // usernameTextBox
            this.usernameTextBox.Location = new System.Drawing.Point(93, 12);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(179, 20);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // passwordLabel
            this.passwordLabel.Location = new System.Drawing.Point(12, 41);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordLabel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);

            // passwordTextBox
            this.passwordTextBox.Location = new System.Drawing.Point(93, 38);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(179, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // emailLabel
            this.emailLabel.Location = new System.Drawing.Point(12, 67);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(75, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emailLabel.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);

            // emailTextBox
            this.emailTextBox.Location = new System.Drawing.Point(93, 64);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(179, 20);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

            // registerButton
            this.registerButton.Location = new System.Drawing.Point(93, 90);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(179, 23);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button registerButton;
    }
}
