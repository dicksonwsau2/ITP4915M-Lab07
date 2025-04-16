namespace ITP4915M_Lab07
{
    partial class FormMain
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
            btnLogin = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 74);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.Enabled = false;
            btnLogout.Location = new Point(100, 149);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += this.btnLogout_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 268);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Name = "FormMain";
            Text = "Top Page";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnLogout;
    }
}