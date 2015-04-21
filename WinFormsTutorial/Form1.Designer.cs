namespace WinFormsTutorial
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.chkPauseLeft = new System.Windows.Forms.CheckBox();
            this.btnShowLeft = new System.Windows.Forms.Button();
            this.btnClearLeft = new System.Windows.Forms.Button();
            this.btnPreviousLeft = new System.Windows.Forms.Button();
            this.btnNextLeft = new System.Windows.Forms.Button();
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.chkPauseRight = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.73921F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.26079F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1269, 579);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 473);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.lblStatusLeft);
            this.panel1.Controls.Add(this.chkPauseLeft);
            this.panel1.Controls.Add(this.btnShowLeft);
            this.panel1.Controls.Add(this.btnClearLeft);
            this.panel1.Controls.Add(this.btnPreviousLeft);
            this.panel1.Controls.Add(this.btnNextLeft);
            this.panel1.Controls.Add(this.checkBoxLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 94);
            this.panel1.TabIndex = 3;
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLeft.Location = new System.Drawing.Point(10, 77);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(0, 13);
            this.lblStatusLeft.TabIndex = 14;
            // 
            // chkPauseLeft
            // 
            this.chkPauseLeft.AutoSize = true;
            this.chkPauseLeft.Location = new System.Drawing.Point(140, 50);
            this.chkPauseLeft.Name = "chkPauseLeft";
            this.chkPauseLeft.Size = new System.Drawing.Size(56, 17);
            this.chkPauseLeft.TabIndex = 13;
            this.chkPauseLeft.Text = "Pause";
            this.chkPauseLeft.UseVisualStyleBackColor = true;
            // 
            // btnShowLeft
            // 
            this.btnShowLeft.AutoSize = true;
            this.btnShowLeft.Location = new System.Drawing.Point(28, 21);
            this.btnShowLeft.Name = "btnShowLeft";
            this.btnShowLeft.Size = new System.Drawing.Size(89, 23);
            this.btnShowLeft.TabIndex = 6;
            this.btnShowLeft.Text = "Show a Picture";
            this.btnShowLeft.UseVisualStyleBackColor = true;
            this.btnShowLeft.Click += new System.EventHandler(this.btnShowLeft_Click);
            // 
            // btnClearLeft
            // 
            this.btnClearLeft.AutoSize = true;
            this.btnClearLeft.Location = new System.Drawing.Point(123, 21);
            this.btnClearLeft.Name = "btnClearLeft";
            this.btnClearLeft.Size = new System.Drawing.Size(95, 23);
            this.btnClearLeft.TabIndex = 8;
            this.btnClearLeft.Text = "Clear the Picture";
            this.btnClearLeft.UseVisualStyleBackColor = true;
            this.btnClearLeft.Click += new System.EventHandler(this.btnClearLeft_Click);
            // 
            // btnPreviousLeft
            // 
            this.btnPreviousLeft.Location = new System.Drawing.Point(355, 21);
            this.btnPreviousLeft.Name = "btnPreviousLeft";
            this.btnPreviousLeft.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousLeft.TabIndex = 11;
            this.btnPreviousLeft.Text = "Previous";
            this.btnPreviousLeft.UseVisualStyleBackColor = true;
            this.btnPreviousLeft.Click += new System.EventHandler(this.btnPreviousLeft_Click);
            // 
            // btnNextLeft
            // 
            this.btnNextLeft.Location = new System.Drawing.Point(468, 21);
            this.btnNextLeft.Name = "btnNextLeft";
            this.btnNextLeft.Size = new System.Drawing.Size(75, 23);
            this.btnNextLeft.TabIndex = 12;
            this.btnNextLeft.Text = "Next";
            this.btnNextLeft.UseVisualStyleBackColor = true;
            this.btnNextLeft.Click += new System.EventHandler(this.btnNextLeft_Click);
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.AutoSize = true;
            this.checkBoxLeft.Location = new System.Drawing.Point(28, 50);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(60, 17);
            this.checkBoxLeft.TabIndex = 7;
            this.checkBoxLeft.Text = "Stretch";
            this.checkBoxLeft.UseVisualStyleBackColor = true;
            this.checkBoxLeft.CheckedChanged += new System.EventHandler(this.checkBoxLeft_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.lblStatusRight);
            this.panel2.Controls.Add(this.chkPauseRight);
            this.panel2.Controls.Add(this.showButton);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(637, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 94);
            this.panel2.TabIndex = 4;
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.Location = new System.Drawing.Point(4, 75);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(0, 13);
            this.lblStatusRight.TabIndex = 7;
            // 
            // chkPauseRight
            // 
            this.chkPauseRight.AutoSize = true;
            this.chkPauseRight.Location = new System.Drawing.Point(158, 51);
            this.chkPauseRight.Name = "chkPauseRight";
            this.chkPauseRight.Size = new System.Drawing.Size(56, 17);
            this.chkPauseRight.TabIndex = 6;
            this.chkPauseRight.Text = "Pause";
            this.chkPauseRight.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.AutoSize = true;
            this.showButton.Location = new System.Drawing.Point(43, 21);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(89, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show a Picture";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(437, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(138, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear the Picture";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(327, 21);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(637, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 473);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a Picture File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Picture Comparer";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowLeft;
        private System.Windows.Forms.Button btnClearLeft;
        private System.Windows.Forms.Button btnPreviousLeft;
        private System.Windows.Forms.Button btnNextLeft;
        private System.Windows.Forms.CheckBox checkBoxLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkPauseLeft;
        private System.Windows.Forms.CheckBox chkPauseRight;
        private System.Windows.Forms.Label lblStatusLeft;
        private System.Windows.Forms.Label lblStatusRight;
    }
}

