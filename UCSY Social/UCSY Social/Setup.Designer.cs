namespace UCSY_Social
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.form_panel = new System.Windows.Forms.Panel();
            this.setup_submit = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.setup_stats = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sq_three_label = new System.Windows.Forms.Label();
            this.sq_two_label = new System.Windows.Forms.Label();
            this.sq_one_label = new System.Windows.Forms.Label();
            this.sq_three_input = new System.Windows.Forms.TextBox();
            this.sq_two_input = new System.Windows.Forms.TextBox();
            this.sq_one_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reg_bio_label = new System.Windows.Forms.Label();
            this.reg_date_input = new System.Windows.Forms.DateTimePicker();
            this.reg_gender_female = new System.Windows.Forms.RadioButton();
            this.reg_gender_male = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_bio_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.form_panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_panel
            // 
            this.form_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_panel.BackColor = System.Drawing.Color.Transparent;
            this.form_panel.Controls.Add(this.setup_submit);
            this.form_panel.Controls.Add(this.back_btn);
            this.form_panel.Controls.Add(this.setup_stats);
            this.form_panel.Controls.Add(this.groupBox2);
            this.form_panel.Controls.Add(this.groupBox1);
            this.form_panel.Controls.Add(this.label1);
            this.form_panel.Location = new System.Drawing.Point(5, 5);
            this.form_panel.Name = "form_panel";
            this.form_panel.Size = new System.Drawing.Size(490, 320);
            this.form_panel.TabIndex = 0;
            // 
            // setup_submit
            // 
            this.setup_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setup_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_submit.Location = new System.Drawing.Point(290, 272);
            this.setup_submit.Name = "setup_submit";
            this.setup_submit.Size = new System.Drawing.Size(100, 23);
            this.setup_submit.TabIndex = 7;
            this.setup_submit.Text = "F I N I S H";
            this.setup_submit.UseVisualStyleBackColor = true;
            this.setup_submit.Click += new System.EventHandler(this.setup_submit_Click);
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Location = new System.Drawing.Point(100, 272);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 23);
            this.back_btn.TabIndex = 8;
            this.back_btn.TabStop = false;
            this.back_btn.Text = "B A C K";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // setup_stats
            // 
            this.setup_stats.Dock = System.Windows.Forms.DockStyle.Top;
            this.setup_stats.ForeColor = System.Drawing.Color.Red;
            this.setup_stats.Location = new System.Drawing.Point(0, 55);
            this.setup_stats.Name = "setup_stats";
            this.setup_stats.Size = new System.Drawing.Size(490, 15);
            this.setup_stats.TabIndex = 0;
            this.setup_stats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sq_three_label);
            this.groupBox2.Controls.Add(this.sq_two_label);
            this.groupBox2.Controls.Add(this.sq_one_label);
            this.groupBox2.Controls.Add(this.sq_three_input);
            this.groupBox2.Controls.Add(this.sq_two_input);
            this.groupBox2.Controls.Add(this.sq_one_input);
            this.groupBox2.Location = new System.Drawing.Point(255, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 160);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security Question";
            // 
            // sq_three_label
            // 
            this.sq_three_label.AutoSize = true;
            this.sq_three_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sq_three_label.Location = new System.Drawing.Point(9, 134);
            this.sq_three_label.Name = "sq_three_label";
            this.sq_three_label.Size = new System.Drawing.Size(171, 15);
            this.sq_three_label.TabIndex = 0;
            this.sq_three_label.Text = "What is Your Favourite Tech?";
            this.sq_three_label.Click += new System.EventHandler(this.sq_three_input_Enter);
            // 
            // sq_two_label
            // 
            this.sq_two_label.AutoSize = true;
            this.sq_two_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sq_two_label.Location = new System.Drawing.Point(9, 84);
            this.sq_two_label.Name = "sq_two_label";
            this.sq_two_label.Size = new System.Drawing.Size(172, 15);
            this.sq_two_label.TabIndex = 0;
            this.sq_two_label.Text = "What is Your Favourite Food?";
            this.sq_two_label.Click += new System.EventHandler(this.sq_two_input_Enter);
            // 
            // sq_one_label
            // 
            this.sq_one_label.AutoSize = true;
            this.sq_one_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sq_one_label.Location = new System.Drawing.Point(9, 34);
            this.sq_one_label.Name = "sq_one_label";
            this.sq_one_label.Size = new System.Drawing.Size(178, 15);
            this.sq_one_label.TabIndex = 0;
            this.sq_one_label.Text = "What is Your Childhood Name?";
            this.sq_one_label.Click += new System.EventHandler(this.sq_one_input_Enter);
            // 
            // sq_three_input
            // 
            this.sq_three_input.Location = new System.Drawing.Point(6, 130);
            this.sq_three_input.Name = "sq_three_input";
            this.sq_three_input.Size = new System.Drawing.Size(223, 22);
            this.sq_three_input.TabIndex = 6;
            this.sq_three_input.Enter += new System.EventHandler(this.sq_three_input_Enter);
            this.sq_three_input.Leave += new System.EventHandler(this.sq_three_input_Leave);
            // 
            // sq_two_input
            // 
            this.sq_two_input.Location = new System.Drawing.Point(6, 80);
            this.sq_two_input.Name = "sq_two_input";
            this.sq_two_input.Size = new System.Drawing.Size(223, 22);
            this.sq_two_input.TabIndex = 5;
            this.sq_two_input.Enter += new System.EventHandler(this.sq_two_input_Enter);
            this.sq_two_input.Leave += new System.EventHandler(this.sq_two_input_Leave);
            // 
            // sq_one_input
            // 
            this.sq_one_input.Location = new System.Drawing.Point(6, 30);
            this.sq_one_input.Name = "sq_one_input";
            this.sq_one_input.Size = new System.Drawing.Size(223, 22);
            this.sq_one_input.TabIndex = 4;
            this.sq_one_input.Enter += new System.EventHandler(this.sq_one_input_Enter);
            this.sq_one_input.Leave += new System.EventHandler(this.sq_one_input_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reg_bio_label);
            this.groupBox1.Controls.Add(this.reg_date_input);
            this.groupBox1.Controls.Add(this.reg_gender_female);
            this.groupBox1.Controls.Add(this.reg_gender_male);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reg_bio_input);
            this.groupBox1.Location = new System.Drawing.Point(10, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Setup";
            // 
            // reg_bio_label
            // 
            this.reg_bio_label.AutoSize = true;
            this.reg_bio_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_bio_label.Location = new System.Drawing.Point(9, 134);
            this.reg_bio_label.Name = "reg_bio_label";
            this.reg_bio_label.Size = new System.Drawing.Size(25, 15);
            this.reg_bio_label.TabIndex = 0;
            this.reg_bio_label.Text = "Bio";
            this.reg_bio_label.Click += new System.EventHandler(this.reg_bio_input_Enter);
            // 
            // reg_date_input
            // 
            this.reg_date_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reg_date_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reg_date_input.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.reg_date_input.Location = new System.Drawing.Point(6, 30);
            this.reg_date_input.Name = "reg_date_input";
            this.reg_date_input.Size = new System.Drawing.Size(223, 21);
            this.reg_date_input.TabIndex = 1;
            // 
            // reg_gender_female
            // 
            this.reg_gender_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_gender_female.Location = new System.Drawing.Point(162, 80);
            this.reg_gender_female.Name = "reg_gender_female";
            this.reg_gender_female.Size = new System.Drawing.Size(67, 18);
            this.reg_gender_female.TabIndex = 2;
            this.reg_gender_female.TabStop = true;
            this.reg_gender_female.Text = "Female";
            this.reg_gender_female.UseVisualStyleBackColor = true;
            // 
            // reg_gender_male
            // 
            this.reg_gender_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_gender_male.Location = new System.Drawing.Point(104, 80);
            this.reg_gender_male.Name = "reg_gender_male";
            this.reg_gender_male.Size = new System.Drawing.Size(52, 18);
            this.reg_gender_male.TabIndex = 2;
            this.reg_gender_male.TabStop = true;
            this.reg_gender_male.Text = "Male";
            this.reg_gender_male.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender";
            // 
            // reg_bio_input
            // 
            this.reg_bio_input.Location = new System.Drawing.Point(6, 130);
            this.reg_bio_input.Name = "reg_bio_input";
            this.reg_bio_input.Size = new System.Drawing.Size(223, 22);
            this.reg_bio_input.TabIndex = 3;
            this.reg_bio_input.Enter += new System.EventHandler(this.reg_bio_input_Enter);
            this.reg_bio_input.Leave += new System.EventHandler(this.reg_bio_input_Leave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Rubik", 14F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(490, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "S E T U P   Y O U R   A C C O U N T";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UCSY_Social.Properties.Resources.top_left;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.form_panel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rubik", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UCSY Social - Setup Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Setup_FormClosed);
            this.Load += new System.EventHandler(this.Setup_Load);
            this.form_panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form_panel;
        private System.Windows.Forms.Button setup_submit;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label setup_stats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sq_three_label;
        private System.Windows.Forms.Label sq_two_label;
        private System.Windows.Forms.Label sq_one_label;
        private System.Windows.Forms.TextBox sq_three_input;
        private System.Windows.Forms.TextBox sq_two_input;
        private System.Windows.Forms.TextBox sq_one_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label reg_bio_label;
        private System.Windows.Forms.DateTimePicker reg_date_input;
        private System.Windows.Forms.RadioButton reg_gender_female;
        private System.Windows.Forms.RadioButton reg_gender_male;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reg_bio_input;
        private System.Windows.Forms.Label label1;
    }
}