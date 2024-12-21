namespace hospital_automation_application
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.buttonPatientLogin = new System.Windows.Forms.Button();
            this.buttonDoctorLogin = new System.Windows.Forms.Button();
            this.buttonSecretaryLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPatientLogin
            // 
            this.buttonPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPatientLogin.BackgroundImage")));
            this.buttonPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPatientLogin.Location = new System.Drawing.Point(30, 55);
            this.buttonPatientLogin.Name = "buttonPatientLogin";
            this.buttonPatientLogin.Size = new System.Drawing.Size(202, 154);
            this.buttonPatientLogin.TabIndex = 0;
            this.buttonPatientLogin.UseVisualStyleBackColor = true;
            this.buttonPatientLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDoctorLogin
            // 
            this.buttonDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoctorLogin.BackgroundImage")));
            this.buttonDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoctorLogin.Location = new System.Drawing.Point(325, 55);
            this.buttonDoctorLogin.Name = "buttonDoctorLogin";
            this.buttonDoctorLogin.Size = new System.Drawing.Size(202, 154);
            this.buttonDoctorLogin.TabIndex = 1;
            this.buttonDoctorLogin.UseVisualStyleBackColor = true;
            this.buttonDoctorLogin.Click += new System.EventHandler(this.buttonDoctorLogin_Click);
            // 
            // buttonSecretaryLogin
            // 
            this.buttonSecretaryLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSecretaryLogin.BackgroundImage")));
            this.buttonSecretaryLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSecretaryLogin.Location = new System.Drawing.Point(598, 55);
            this.buttonSecretaryLogin.Name = "buttonSecretaryLogin";
            this.buttonSecretaryLogin.Size = new System.Drawing.Size(202, 154);
            this.buttonSecretaryLogin.TabIndex = 2;
            this.buttonSecretaryLogin.UseVisualStyleBackColor = true;
            this.buttonSecretaryLogin.Click += new System.EventHandler(this.buttonSecretaryLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 80);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(347, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alvina Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Secretary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-4, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 28);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(298, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "All rights reserved by Alvina Hospital";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPatientLogin);
            this.groupBox1.Controls.Add(this.buttonDoctorLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonSecretaryLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(61, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 301);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Type";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(961, 614);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "Alvina Hospital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPatientLogin;
        private System.Windows.Forms.Button buttonDoctorLogin;
        private System.Windows.Forms.Button buttonSecretaryLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

