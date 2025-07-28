namespace BookAddress
{
    partial class FormAB
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
            this.lab = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.laddress = new System.Windows.Forms.Label();
            this.lphone = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.tphone = new System.Windows.Forms.TextBox();
            this.taddress = new System.Windows.Forms.TextBox();
            this.bexit = new System.Windows.Forms.Button();
            this.bpre = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bsubmit = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(310, 19);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(217, 37);
            this.lab.TabIndex = 0;
            this.lab.Text = "Address Book";
            this.lab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(34, 87);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(97, 32);
            this.lname.TabIndex = 1;
            this.lname.Text = "Name:";
            this.lname.Click += new System.EventHandler(this.label1_Click);
            // 
            // laddress
            // 
            this.laddress.AutoSize = true;
            this.laddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laddress.Location = new System.Drawing.Point(34, 162);
            this.laddress.Name = "laddress";
            this.laddress.Size = new System.Drawing.Size(126, 32);
            this.laddress.TabIndex = 3;
            this.laddress.Text = "Address:";
            this.laddress.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lphone
            // 
            this.lphone.AutoSize = true;
            this.lphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lphone.Location = new System.Drawing.Point(34, 237);
            this.lphone.Name = "lphone";
            this.lphone.Size = new System.Drawing.Size(212, 32);
            this.lphone.TabIndex = 5;
            this.lphone.Text = "Phone Number:";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(253, 87);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(514, 26);
            this.tname.TabIndex = 2;
            // 
            // tphone
            // 
            this.tphone.Location = new System.Drawing.Point(253, 237);
            this.tphone.Name = "tphone";
            this.tphone.Size = new System.Drawing.Size(514, 26);
            this.tphone.TabIndex = 6;
            // 
            // taddress
            // 
            this.taddress.Location = new System.Drawing.Point(253, 162);
            this.taddress.Name = "taddress";
            this.taddress.Size = new System.Drawing.Size(514, 26);
            this.taddress.TabIndex = 4;
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bexit.Location = new System.Drawing.Point(623, 314);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(145, 41);
            this.bexit.TabIndex = 11;
            this.bexit.Text = "Exit";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // bpre
            // 
            this.bpre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpre.Location = new System.Drawing.Point(41, 314);
            this.bpre.Name = "bpre";
            this.bpre.Size = new System.Drawing.Size(145, 41);
            this.bpre.TabIndex = 7;
            this.bpre.Text = "Previous";
            this.bpre.UseVisualStyleBackColor = true;
            this.bpre.Click += new System.EventHandler(this.bpre_Click);
            // 
            // badd
            // 
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(235, 314);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(145, 41);
            this.badd.TabIndex = 8;
            this.badd.Text = "Add";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bsubmit
            // 
            this.bsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsubmit.Location = new System.Drawing.Point(429, 314);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(145, 41);
            this.bsubmit.TabIndex = 10;
            this.bsubmit.Text = "View";
            this.bsubmit.UseVisualStyleBackColor = true;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclear.Location = new System.Drawing.Point(332, 377);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(145, 41);
            this.bclear.TabIndex = 9;
            this.bclear.Text = "Clear";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // FormAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 481);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bsubmit);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bpre);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.taddress);
            this.Controls.Add(this.tphone);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.lphone);
            this.Controls.Add(this.laddress);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.lab);
            this.Name = "FormAB";
            this.Text = " ";
            this.Load += new System.EventHandler(this.formload);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label laddress;
        private System.Windows.Forms.Label lphone;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tphone;
        private System.Windows.Forms.TextBox taddress;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.Button bpre;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.Button bclear;
    }
}

