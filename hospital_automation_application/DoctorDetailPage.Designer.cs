namespace hospital_automation_application
{
    partial class DoctorDetailPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDetailPage));
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPatientNameSurname = new System.Windows.Forms.Label();
            this.richTextBoxComplaint = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.labelIdentificationNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.announcementsButton = new System.Windows.Forms.Button();
            this.editInformationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono NL ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(538, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 36);
            this.label7.TabIndex = 2;
            this.label7.Text = "Doctor Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 56);
            this.panel1.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(542, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(790, 659);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Appointment List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(784, 631);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPatientNameSurname);
            this.groupBox2.Controls.Add(this.richTextBoxComplaint);
            this.groupBox2.Location = new System.Drawing.Point(66, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 264);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // labelPatientNameSurname
            // 
            this.labelPatientNameSurname.AutoSize = true;
            this.labelPatientNameSurname.Location = new System.Drawing.Point(19, 34);
            this.labelPatientNameSurname.Name = "labelPatientNameSurname";
            this.labelPatientNameSurname.Size = new System.Drawing.Size(66, 23);
            this.labelPatientNameSurname.TabIndex = 11;
            this.labelPatientNameSurname.Text = "--------";
            // 
            // richTextBoxComplaint
            // 
            this.richTextBoxComplaint.Location = new System.Drawing.Point(16, 60);
            this.richTextBoxComplaint.Name = "richTextBoxComplaint";
            this.richTextBoxComplaint.Size = new System.Drawing.Size(398, 191);
            this.richTextBoxComplaint.TabIndex = 8;
            this.richTextBoxComplaint.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNameSurname);
            this.groupBox1.Controls.Add(this.labelIdentificationNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 236);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Information";
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSurname.Location = new System.Drawing.Point(228, 106);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(52, 23);
            this.labelNameSurname.TabIndex = 3;
            this.labelNameSurname.Text = "-------";
            // 
            // labelIdentificationNumber
            // 
            this.labelIdentificationNumber.AutoSize = true;
            this.labelIdentificationNumber.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentificationNumber.Location = new System.Drawing.Point(226, 75);
            this.labelIdentificationNumber.Name = "labelIdentificationNumber";
            this.labelIdentificationNumber.Size = new System.Drawing.Size(120, 23);
            this.labelIdentificationNumber.TabIndex = 2;
            this.labelIdentificationNumber.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name and Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identification Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(546, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "All rights reserved by Alvina Hospital";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-2, 737);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1391, 26);
            this.panel2.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quitButton);
            this.groupBox3.Controls.Add(this.announcementsButton);
            this.groupBox3.Controls.Add(this.editInformationButton);
            this.groupBox3.Location = new System.Drawing.Point(66, 592);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 137);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quick Access";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(16, 81);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(375, 35);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // announcementsButton
            // 
            this.announcementsButton.Location = new System.Drawing.Point(205, 42);
            this.announcementsButton.Name = "announcementsButton";
            this.announcementsButton.Size = new System.Drawing.Size(186, 35);
            this.announcementsButton.TabIndex = 1;
            this.announcementsButton.Text = "Announcements";
            this.announcementsButton.UseVisualStyleBackColor = true;
            this.announcementsButton.Click += new System.EventHandler(this.announcementsButton_Click);
            // 
            // editInformationButton
            // 
            this.editInformationButton.Location = new System.Drawing.Point(16, 42);
            this.editInformationButton.Name = "editInformationButton";
            this.editInformationButton.Size = new System.Drawing.Size(183, 35);
            this.editInformationButton.TabIndex = 0;
            this.editInformationButton.Text = "Edit Information";
            this.editInformationButton.UseVisualStyleBackColor = true;
            // 
            // DoctorDetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DoctorDetailPage";
            this.Text = "DoctorDetailPage";
            this.Load += new System.EventHandler(this.DoctorDetailPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxComplaint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label labelIdentificationNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPatientNameSurname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button editInformationButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button announcementsButton;
    }
}