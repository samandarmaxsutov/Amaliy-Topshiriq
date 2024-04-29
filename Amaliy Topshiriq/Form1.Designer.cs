namespace Amaliy_Topshiriq
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
            this.mSoniTextBox = new System.Windows.Forms.TextBox();
            this.n_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nSoniTextBox = new System.Windows.Forms.TextBox();
            this.boshlashButton = new System.Windows.Forms.Button();
            this.label_natija = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chiqishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mSoniTextBox
            // 
            this.mSoniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mSoniTextBox.Location = new System.Drawing.Point(262, 650);
            this.mSoniTextBox.Multiline = true;
            this.mSoniTextBox.Name = "mSoniTextBox";
            this.mSoniTextBox.Size = new System.Drawing.Size(167, 38);
            this.mSoniTextBox.TabIndex = 0;
            this.mSoniTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // n_number
            // 
            this.n_number.AutoSize = true;
            this.n_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n_number.Location = new System.Drawing.Point(45, 653);
            this.n_number.Name = "n_number";
            this.n_number.Size = new System.Drawing.Size(202, 25);
            this.n_number.TabIndex = 1;
            this.n_number.Text = "Qatorlar soni (m=)";
            this.n_number.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ustunlar soni (n=)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nSoniTextBox
            // 
            this.nSoniTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nSoniTextBox.Location = new System.Drawing.Point(262, 581);
            this.nSoniTextBox.Multiline = true;
            this.nSoniTextBox.Name = "nSoniTextBox";
            this.nSoniTextBox.Size = new System.Drawing.Size(167, 38);
            this.nSoniTextBox.TabIndex = 2;
            // 
            // boshlashButton
            // 
            this.boshlashButton.BackColor = System.Drawing.Color.Green;
            this.boshlashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boshlashButton.ForeColor = System.Drawing.SystemColors.Control;
            this.boshlashButton.Location = new System.Drawing.Point(488, 658);
            this.boshlashButton.Name = "boshlashButton";
            this.boshlashButton.Size = new System.Drawing.Size(168, 52);
            this.boshlashButton.TabIndex = 4;
            this.boshlashButton.Text = "Boshlash";
            this.boshlashButton.UseVisualStyleBackColor = false;
            this.boshlashButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_natija
            // 
            this.label_natija.AutoSize = true;
            this.label_natija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_natija.Location = new System.Drawing.Point(465, 581);
            this.label_natija.Name = "label_natija";
            this.label_natija.Size = new System.Drawing.Size(312, 25);
            this.label_natija.TabIndex = 5;
            this.label_natija.Text = "Musbat elementlar yig\'indisi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 467);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Amaliy topshiriq";
            // 
            // chiqishButton
            // 
            this.chiqishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chiqishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiqishButton.ForeColor = System.Drawing.SystemColors.Control;
            this.chiqishButton.Location = new System.Drawing.Point(684, 658);
            this.chiqishButton.Name = "chiqishButton";
            this.chiqishButton.Size = new System.Drawing.Size(168, 52);
            this.chiqishButton.TabIndex = 9;
            this.chiqishButton.Text = "Chiqish";
            this.chiqishButton.UseVisualStyleBackColor = false;
            this.chiqishButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 722);
            this.Controls.Add(this.chiqishButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_natija);
            this.Controls.Add(this.boshlashButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nSoniTextBox);
            this.Controls.Add(this.n_number);
            this.Controls.Add(this.mSoniTextBox);
            this.Name = "Form1";
            this.Text = "Amaliy topshiriq";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mSoniTextBox;
        private System.Windows.Forms.Label n_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nSoniTextBox;
        private System.Windows.Forms.Button boshlashButton;
        private System.Windows.Forms.Label label_natija;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chiqishButton;
    }
}

