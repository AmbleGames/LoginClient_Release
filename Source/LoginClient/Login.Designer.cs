namespace BetaLoginClient_MySQL_
{
    partial class Login
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(13, 13);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(161, 20);
            this.txtusername.TabIndex = 0;
            this.txtusername.Tag = "";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(13, 40);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(161, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // btnlogin
            // 
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Location = new System.Drawing.Point(13, 67);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Location = new System.Drawing.Point(99, 67);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncheck
            // 
            this.btncheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheck.Location = new System.Drawing.Point(180, 13);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(75, 77);
            this.btncheck.TabIndex = 4;
            this.btncheck.Text = "MySQL Connection Check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "© Copyright by AmbleGames™ and SnapSofts™";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Label label2;
    }
}

