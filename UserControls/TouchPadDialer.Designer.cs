﻿namespace TwilioEmulator
{
    partial class TouchPadDialer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbTouchPad = new System.Windows.Forms.TabControl();
            this.tbKeyPad = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAsterik = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.tbScript = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbTouchPad.SuspendLayout();
            this.tbKeyPad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTouchPad
            // 
            this.tbTouchPad.Controls.Add(this.tbKeyPad);
            this.tbTouchPad.Controls.Add(this.tbScript);
            this.tbTouchPad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTouchPad.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTouchPad.Location = new System.Drawing.Point(0, 0);
            this.tbTouchPad.Name = "tbTouchPad";
            this.tbTouchPad.SelectedIndex = 0;
            this.tbTouchPad.Size = new System.Drawing.Size(553, 466);
            this.tbTouchPad.TabIndex = 3;
            // 
            // tbKeyPad
            // 
            this.tbKeyPad.Controls.Add(this.tableLayoutPanel1);
            this.tbKeyPad.Controls.Add(this.btnStatus);
            this.tbKeyPad.Location = new System.Drawing.Point(4, 22);
            this.tbKeyPad.Name = "tbKeyPad";
            this.tbKeyPad.Padding = new System.Windows.Forms.Padding(3);
            this.tbKeyPad.Size = new System.Drawing.Size(545, 440);
            this.tbKeyPad.TabIndex = 0;
            this.tbKeyPad.Text = "Keypad";
            this.tbKeyPad.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAsterik, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnHash, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 374);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(2, 2);
            this.btn1.Margin = new System.Windows.Forms.Padding(1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(176, 90);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(181, 2);
            this.btn2.Margin = new System.Windows.Forms.Padding(1);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(176, 90);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2\r\nABC";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(360, 2);
            this.btn3.Margin = new System.Windows.Forms.Padding(1);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(177, 90);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3\r\nDEF";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(2, 95);
            this.btn4.Margin = new System.Windows.Forms.Padding(1);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(176, 90);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4\r\nGHI";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(181, 95);
            this.btn5.Margin = new System.Windows.Forms.Padding(1);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(176, 90);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5\r\nJKL";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(360, 95);
            this.btn6.Margin = new System.Windows.Forms.Padding(1);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(177, 90);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6\r\nMNO";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(2, 188);
            this.btn7.Margin = new System.Windows.Forms.Padding(1);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(176, 90);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7\r\nPQRS";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(181, 188);
            this.btn8.Margin = new System.Windows.Forms.Padding(1);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(176, 90);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8\r\nTUV";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(360, 188);
            this.btn9.Margin = new System.Windows.Forms.Padding(1);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(177, 90);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9\r\nWXYZ";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btnAsterik
            // 
            this.btnAsterik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAsterik.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsterik.Location = new System.Drawing.Point(2, 281);
            this.btnAsterik.Margin = new System.Windows.Forms.Padding(1);
            this.btnAsterik.Name = "btnAsterik";
            this.btnAsterik.Size = new System.Drawing.Size(176, 91);
            this.btnAsterik.TabIndex = 9;
            this.btnAsterik.Text = "*";
            this.btnAsterik.UseVisualStyleBackColor = true;
            // 
            // btnHash
            // 
            this.btnHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHash.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.Location = new System.Drawing.Point(360, 281);
            this.btnHash.Margin = new System.Windows.Forms.Padding(1);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(177, 91);
            this.btnHash.TabIndex = 10;
            this.btnHash.Text = "#";
            this.btnHash.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(181, 281);
            this.btn0.Margin = new System.Windows.Forms.Padding(1);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(176, 91);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatus.Location = new System.Drawing.Point(3, 3);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(539, 60);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "Dial Number";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // tbScript
            // 
            this.tbScript.Location = new System.Drawing.Point(4, 22);
            this.tbScript.Name = "tbScript";
            this.tbScript.Padding = new System.Windows.Forms.Padding(3);
            this.tbScript.Size = new System.Drawing.Size(545, 440);
            this.tbScript.TabIndex = 1;
            this.tbScript.Text = "Script";
            this.tbScript.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TouchPadDialer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTouchPad);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TouchPadDialer";
            this.Size = new System.Drawing.Size(553, 466);
            this.tbTouchPad.ResumeLayout(false);
            this.tbKeyPad.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbTouchPad;
        private System.Windows.Forms.TabPage tbKeyPad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAsterik;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.TabPage tbScript;
        private System.Windows.Forms.Timer timer1;
    }
}