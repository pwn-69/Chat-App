namespace UCSY_Social
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_name = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_bio = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_bio = new System.Windows.Forms.Label();
            this.name_info = new System.Windows.Forms.Label();
            this.password_info = new System.Windows.Forms.Label();
            this.bio_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Rubik", 14F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(300, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "U P D A T E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Rubik", 8F);
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Fill all the Fields to Continue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_name
            // 
            this.input_name.BackColor = System.Drawing.Color.White;
            this.input_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_name.Location = new System.Drawing.Point(35, 95);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(230, 22);
            this.input_name.TabIndex = 1;
            this.input_name.TextChanged += new System.EventHandler(this.input_name_TextChanged);
            this.input_name.Enter += new System.EventHandler(this.input_name_Enter);
            this.input_name.Leave += new System.EventHandler(this.input_name_Leave);
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.White;
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password.Location = new System.Drawing.Point(35, 245);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(230, 22);
            this.input_password.TabIndex = 3;
            this.input_password.UseSystemPasswordChar = true;
            this.input_password.TextChanged += new System.EventHandler(this.input_password_TextChanged);
            this.input_password.Enter += new System.EventHandler(this.input_password_Enter);
            this.input_password.Leave += new System.EventHandler(this.input_password_Leave);
            // 
            // input_email
            // 
            this.input_email.BackColor = System.Drawing.Color.White;
            this.input_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_email.Enabled = false;
            this.input_email.Location = new System.Drawing.Point(35, 145);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(230, 22);
            this.input_email.TabIndex = 0;
            // 
            // input_bio
            // 
            this.input_bio.BackColor = System.Drawing.Color.White;
            this.input_bio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_bio.Location = new System.Drawing.Point(35, 195);
            this.input_bio.Name = "input_bio";
            this.input_bio.Size = new System.Drawing.Size(230, 22);
            this.input_bio.TabIndex = 2;
            this.input_bio.TextChanged += new System.EventHandler(this.input_bio_TextChanged);
            this.input_bio.Enter += new System.EventHandler(this.input_bio_Enter);
            this.input_bio.Leave += new System.EventHandler(this.input_bio_Leave);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.Transparent;
            this.submit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Location = new System.Drawing.Point(100, 315);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(100, 23);
            this.submit_btn.TabIndex = 4;
            this.submit_btn.Text = "F I N I S H";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.White;
            this.label_name.Font = new System.Drawing.Font("Rubik", 8F);
            this.label_name.Location = new System.Drawing.Point(38, 99);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Rubik", 8F);
            this.label4.Location = new System.Drawing.Point(34, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.White;
            this.label_password.Font = new System.Drawing.Font("Rubik", 8F);
            this.label_password.Location = new System.Drawing.Point(38, 249);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(58, 13);
            this.label_password.TabIndex = 0;
            this.label_password.Text = "Password";
            // 
            // label_bio
            // 
            this.label_bio.AutoSize = true;
            this.label_bio.BackColor = System.Drawing.Color.White;
            this.label_bio.Font = new System.Drawing.Font("Rubik", 8F);
            this.label_bio.Location = new System.Drawing.Point(38, 199);
            this.label_bio.Name = "label_bio";
            this.label_bio.Size = new System.Drawing.Size(23, 13);
            this.label_bio.TabIndex = 0;
            this.label_bio.Text = "Bio";
            // 
            // name_info
            // 
            this.name_info.BackColor = System.Drawing.Color.Transparent;
            this.name_info.Font = new System.Drawing.Font("Rubik", 8F);
            this.name_info.ForeColor = System.Drawing.Color.Red;
            this.name_info.Location = new System.Drawing.Point(32, 120);
            this.name_info.Name = "name_info";
            this.name_info.Size = new System.Drawing.Size(233, 13);
            this.name_info.TabIndex = 0;
            this.name_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_info
            // 
            this.password_info.BackColor = System.Drawing.Color.Transparent;
            this.password_info.Font = new System.Drawing.Font("Rubik", 8F);
            this.password_info.ForeColor = System.Drawing.Color.Red;
            this.password_info.Location = new System.Drawing.Point(32, 270);
            this.password_info.Name = "password_info";
            this.password_info.Size = new System.Drawing.Size(233, 13);
            this.password_info.TabIndex = 0;
            this.password_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bio_info
            // 
            this.bio_info.BackColor = System.Drawing.Color.Transparent;
            this.bio_info.Font = new System.Drawing.Font("Rubik", 8F);
            this.bio_info.ForeColor = System.Drawing.Color.Red;
            this.bio_info.Location = new System.Drawing.Point(32, 220);
            this.bio_info.Name = "bio_info";
            this.bio_info.Size = new System.Drawing.Size(233, 13);
            this.bio_info.TabIndex = 0;
            this.bio_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::UCSY_Social.Properties.Resources.top_left;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 365);
            this.Controls.Add(this.bio_info);
            this.Controls.Add(this.password_info);
            this.Controls.Add(this.name_info);
            this.Controls.Add(this.label_bio);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.input_bio);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_name;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_bio;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_bio;
        private System.Windows.Forms.Label name_info;
        private System.Windows.Forms.Label password_info;
        private System.Windows.Forms.Label bio_info;
    }
}