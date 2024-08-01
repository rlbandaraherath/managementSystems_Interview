
namespace managementSystems_app1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtfixedline = new System.Windows.Forms.TextBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtinsert = new System.Windows.Forms.Button();
            this.txtedit = new System.Windows.Forms.Button();
            this.txtdelete = new System.Windows.Forms.Button();
            this.txtdatetime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datetime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fixed line";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "NIC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(164, 48);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(128, 20);
            this.txtcustomerid.TabIndex = 8;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(471, 88);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(127, 20);
            this.txtaddress.TabIndex = 10;
            // 
            // txtfixedline
            // 
            this.txtfixedline.Location = new System.Drawing.Point(471, 44);
            this.txtfixedline.Name = "txtfixedline";
            this.txtfixedline.Size = new System.Drawing.Size(127, 20);
            this.txtfixedline.TabIndex = 11;
            // 
            // txtmobile
            // 
            this.txtmobile.Location = new System.Drawing.Point(164, 159);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(128, 20);
            this.txtmobile.TabIndex = 12;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(164, 124);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(128, 20);
            this.txtnic.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(164, 84);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(128, 20);
            this.txtname.TabIndex = 14;
            // 
            // txtinsert
            // 
            this.txtinsert.Location = new System.Drawing.Point(356, 159);
            this.txtinsert.Name = "txtinsert";
            this.txtinsert.Size = new System.Drawing.Size(75, 23);
            this.txtinsert.TabIndex = 16;
            this.txtinsert.Text = "Insert";
            this.txtinsert.UseVisualStyleBackColor = true;
            this.txtinsert.Click += new System.EventHandler(this.txtinsert_Click);
            // 
            // txtedit
            // 
            this.txtedit.Location = new System.Drawing.Point(456, 159);
            this.txtedit.Name = "txtedit";
            this.txtedit.Size = new System.Drawing.Size(75, 23);
            this.txtedit.TabIndex = 17;
            this.txtedit.Text = "Edit";
            this.txtedit.UseVisualStyleBackColor = true;
            this.txtedit.Click += new System.EventHandler(this.txtedit_Click);
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(562, 159);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(75, 23);
            this.txtdelete.TabIndex = 18;
            this.txtdelete.Text = "Delete";
            this.txtdelete.UseVisualStyleBackColor = true;
            this.txtdelete.Click += new System.EventHandler(this.txtdelete_Click);
            // 
            // txtdatetime
            // 
            this.txtdatetime.Location = new System.Drawing.Point(471, 124);
            this.txtdatetime.Name = "txtdatetime";
            this.txtdatetime.Size = new System.Drawing.Size(127, 20);
            this.txtdatetime.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 264);
            this.Controls.Add(this.txtdatetime);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.txtedit);
            this.Controls.Add(this.txtinsert);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.txtfixedline);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtfixedline;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button txtinsert;
        private System.Windows.Forms.Button txtedit;
        private System.Windows.Forms.Button txtdelete;
        private System.Windows.Forms.DateTimePicker txtdatetime;
    }
}

