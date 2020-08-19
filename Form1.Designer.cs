namespace FaceRecognition
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
            this.TrainImageBox = new System.Windows.Forms.PictureBox();
            this.TestImageBox = new System.Windows.Forms.PictureBox();
            this.TrainButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.PictureBox();
            this.ListBox2 = new System.Windows.Forms.PictureBox();
            this.ListBox3 = new System.Windows.Forms.PictureBox();
            this.ListBox4 = new System.Windows.Forms.PictureBox();
            this.ListBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrainImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainImageBox
            // 
            this.TrainImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.TrainImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrainImageBox.Location = new System.Drawing.Point(423, 90);
            this.TrainImageBox.Name = "TrainImageBox";
            this.TrainImageBox.Size = new System.Drawing.Size(177, 203);
            this.TrainImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TrainImageBox.TabIndex = 4;
            this.TrainImageBox.TabStop = false;
            this.TrainImageBox.Click += new System.EventHandler(this.TrainImageBox_Click);
            // 
            // TestImageBox
            // 
            this.TestImageBox.BackColor = System.Drawing.SystemColors.Window;
            this.TestImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TestImageBox.Location = new System.Drawing.Point(178, 90);
            this.TestImageBox.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.TestImageBox.Name = "TestImageBox";
            this.TestImageBox.Size = new System.Drawing.Size(177, 203);
            this.TestImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestImageBox.TabIndex = 5;
            this.TestImageBox.TabStop = false;
            this.TestImageBox.Click += new System.EventHandler(this.TestImageBox_Click);
            // 
            // TrainButton
            // 
            this.TrainButton.BackColor = System.Drawing.Color.Plum;
            this.TrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainButton.Location = new System.Drawing.Point(46, 149);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(101, 44);
            this.TrainButton.TabIndex = 6;
            this.TrainButton.TabStop = false;
            this.TrainButton.Text = "Find the Match";
            this.TrainButton.UseVisualStyleBackColor = false;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.Location = new System.Drawing.Point(46, 90);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(101, 41);
            this.TestButton.TabIndex = 7;
            this.TestButton.Text = "Generate Test Image";
            this.TestButton.UseVisualStyleBackColor = false;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox1.Location = new System.Drawing.Point(671, 43);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(61, 54);
            this.ListBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ListBox1.TabIndex = 11;
            this.ListBox1.TabStop = false;
            this.ListBox1.Click += new System.EventHandler(this.ListBox1_Click);
            // 
            // ListBox2
            // 
            this.ListBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox2.Location = new System.Drawing.Point(671, 103);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(61, 54);
            this.ListBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ListBox2.TabIndex = 12;
            this.ListBox2.TabStop = false;
            this.ListBox2.Click += new System.EventHandler(this.ListBox2_Click);
            // 
            // ListBox3
            // 
            this.ListBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox3.Location = new System.Drawing.Point(671, 163);
            this.ListBox3.Name = "ListBox3";
            this.ListBox3.Size = new System.Drawing.Size(61, 54);
            this.ListBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ListBox3.TabIndex = 13;
            this.ListBox3.TabStop = false;
            this.ListBox3.Click += new System.EventHandler(this.ListBox3_Click);
            // 
            // ListBox4
            // 
            this.ListBox4.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox4.Location = new System.Drawing.Point(671, 223);
            this.ListBox4.Name = "ListBox4";
            this.ListBox4.Size = new System.Drawing.Size(61, 54);
            this.ListBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ListBox4.TabIndex = 14;
            this.ListBox4.TabStop = false;
            this.ListBox4.Click += new System.EventHandler(this.ListBox4_Click);
            // 
            // ListBox5
            // 
            this.ListBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox5.Location = new System.Drawing.Point(671, 283);
            this.ListBox5.Name = "ListBox5";
            this.ListBox5.Size = new System.Drawing.Size(61, 54);
            this.ListBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ListBox5.TabIndex = 15;
            this.ListBox5.TabStop = false;
            this.ListBox5.Click += new System.EventHandler(this.ListBox5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Test Image";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Matching Image";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Training images";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "1)";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "2)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(280, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Face Recognition System";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListBox5);
            this.Controls.Add(this.ListBox4);
            this.Controls.Add(this.ListBox3);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.TestImageBox);
            this.Controls.Add(this.TrainImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TrainImageBox;
        private System.Windows.Forms.PictureBox TestImageBox;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.PictureBox ListBox1;
        private System.Windows.Forms.PictureBox ListBox2;
        private System.Windows.Forms.PictureBox ListBox3;
        private System.Windows.Forms.PictureBox ListBox4;
        private System.Windows.Forms.PictureBox ListBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

