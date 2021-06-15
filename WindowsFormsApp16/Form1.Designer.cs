
namespace WindowsFormsApp16
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.labelbdate = new System.Windows.Forms.Label();
            this.labelsurname = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DateBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.MailBox);
            this.groupBox1.Controls.Add(this.snameBox);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.namelabel);
            this.groupBox1.Controls.Add(this.labelbdate);
            this.groupBox1.Controls.Add(this.labelsurname);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.labelphone);
            this.groupBox1.Location = new System.Drawing.Point(200, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 309);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(302, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(97, 193);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(195, 20);
            this.DateBox.TabIndex = 11;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(97, 31);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(195, 20);
            this.nameBox.TabIndex = 0;
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(97, 158);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(195, 20);
            this.MailBox.TabIndex = 10;
            // 
            // snameBox
            // 
            this.snameBox.Location = new System.Drawing.Point(97, 73);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(195, 20);
            this.snameBox.TabIndex = 1;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(97, 119);
            this.PhoneBox.Mask = "(999) 000-0000";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(195, 20);
            this.PhoneBox.TabIndex = 9;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namelabel.Location = new System.Drawing.Point(22, 31);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(48, 18);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "Name";
            // 
            // labelbdate
            // 
            this.labelbdate.AutoSize = true;
            this.labelbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelbdate.Location = new System.Drawing.Point(20, 193);
            this.labelbdate.Name = "labelbdate";
            this.labelbdate.Size = new System.Drawing.Size(70, 18);
            this.labelbdate.TabIndex = 8;
            this.labelbdate.Text = "Birth date";
            // 
            // labelsurname
            // 
            this.labelsurname.AutoSize = true;
            this.labelsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsurname.Location = new System.Drawing.Point(22, 73);
            this.labelsurname.Name = "labelsurname";
            this.labelsurname.Size = new System.Drawing.Size(68, 18);
            this.labelsurname.TabIndex = 5;
            this.labelsurname.Text = "Surname";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail.Location = new System.Drawing.Point(22, 158);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(45, 18);
            this.mail.TabIndex = 7;
            this.mail.Text = "Email";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelphone.Location = new System.Drawing.Point(22, 119);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(51, 18);
            this.labelphone.TabIndex = 6;
            this.labelphone.Text = "Phone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.MaskedTextBox PhoneBox;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label labelbdate;
        private System.Windows.Forms.Label labelsurname;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label labelphone;
    }
}

