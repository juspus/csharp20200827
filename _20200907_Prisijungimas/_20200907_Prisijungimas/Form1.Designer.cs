namespace _20200907_Prisijungimas
{
    partial class PrisijungimoForma
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
            this.vartotojoLbl = new System.Windows.Forms.Label();
            this.slaptazodisLbl = new System.Windows.Forms.Label();
            this.vartotojasTxtBx = new System.Windows.Forms.TextBox();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.StatusasLbl = new System.Windows.Forms.Label();
            this.prisijungesLbl = new System.Windows.Forms.Label();
            this.statusIndLbl = new System.Windows.Forms.Label();
            this.prisijungusioVardLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vartotojoLbl
            // 
            this.vartotojoLbl.AutoSize = true;
            this.vartotojoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vartotojoLbl.Location = new System.Drawing.Point(12, 9);
            this.vartotojoLbl.Name = "vartotojoLbl";
            this.vartotojoLbl.Size = new System.Drawing.Size(100, 25);
            this.vartotojoLbl.TabIndex = 0;
            this.vartotojoLbl.Text = "Vartotojas";
            // 
            // slaptazodisLbl
            // 
            this.slaptazodisLbl.AutoSize = true;
            this.slaptazodisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.slaptazodisLbl.Location = new System.Drawing.Point(12, 59);
            this.slaptazodisLbl.Name = "slaptazodisLbl";
            this.slaptazodisLbl.Size = new System.Drawing.Size(114, 25);
            this.slaptazodisLbl.TabIndex = 1;
            this.slaptazodisLbl.Text = "Slaptažodis";
            // 
            // vartotojasTxtBx
            // 
            this.vartotojasTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.vartotojasTxtBx.Location = new System.Drawing.Point(156, 6);
            this.vartotojasTxtBx.Name = "vartotojasTxtBx";
            this.vartotojasTxtBx.Size = new System.Drawing.Size(144, 30);
            this.vartotojasTxtBx.TabIndex = 2;
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordTxtBx.Location = new System.Drawing.Point(156, 56);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(144, 30);
            this.passwordTxtBx.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.loginBtn.Location = new System.Drawing.Point(12, 101);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(132, 43);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Prisijungti";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LogoutBtn.Location = new System.Drawing.Point(174, 101);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(126, 43);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Atsijungti";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // StatusasLbl
            // 
            this.StatusasLbl.AutoSize = true;
            this.StatusasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.StatusasLbl.Location = new System.Drawing.Point(14, 168);
            this.StatusasLbl.Name = "StatusasLbl";
            this.StatusasLbl.Size = new System.Drawing.Size(85, 22);
            this.StatusasLbl.TabIndex = 6;
            this.StatusasLbl.Text = "Statusas:";
            // 
            // prisijungesLbl
            // 
            this.prisijungesLbl.AutoSize = true;
            this.prisijungesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.prisijungesLbl.Location = new System.Drawing.Point(14, 207);
            this.prisijungesLbl.Name = "prisijungesLbl";
            this.prisijungesLbl.Size = new System.Drawing.Size(96, 22);
            this.prisijungesLbl.TabIndex = 7;
            this.prisijungesLbl.Text = "Vartotojas:";
            // 
            // statusIndLbl
            // 
            this.statusIndLbl.AutoSize = true;
            this.statusIndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.statusIndLbl.ForeColor = System.Drawing.Color.Red;
            this.statusIndLbl.Location = new System.Drawing.Point(152, 168);
            this.statusIndLbl.Name = "statusIndLbl";
            this.statusIndLbl.Size = new System.Drawing.Size(112, 22);
            this.statusIndLbl.TabIndex = 8;
            this.statusIndLbl.Text = "neprisijungta";
            // 
            // prisijungusioVardLbl
            // 
            this.prisijungusioVardLbl.AutoSize = true;
            this.prisijungusioVardLbl.Location = new System.Drawing.Point(156, 215);
            this.prisijungusioVardLbl.Name = "prisijungusioVardLbl";
            this.prisijungusioVardLbl.Size = new System.Drawing.Size(0, 13);
            this.prisijungusioVardLbl.TabIndex = 9;
            // 
            // PrisijungimoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 256);
            this.Controls.Add(this.prisijungusioVardLbl);
            this.Controls.Add(this.statusIndLbl);
            this.Controls.Add(this.prisijungesLbl);
            this.Controls.Add(this.StatusasLbl);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxtBx);
            this.Controls.Add(this.vartotojasTxtBx);
            this.Controls.Add(this.slaptazodisLbl);
            this.Controls.Add(this.vartotojoLbl);
            this.Name = "PrisijungimoForma";
            this.Text = "Prisijungimo Forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vartotojoLbl;
        private System.Windows.Forms.Label slaptazodisLbl;
        private System.Windows.Forms.TextBox vartotojasTxtBx;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label StatusasLbl;
        private System.Windows.Forms.Label prisijungesLbl;
        private System.Windows.Forms.Label statusIndLbl;
        private System.Windows.Forms.Label prisijungusioVardLbl;
    }
}

