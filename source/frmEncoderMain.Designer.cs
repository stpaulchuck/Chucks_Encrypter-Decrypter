namespace EncoderDecoderTool
{
    partial class frmEncoderMain
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
			this.btnDecodeText = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDecodedText = new System.Windows.Forms.TextBox();
			this.btnEncodeText = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOutputString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtInputString = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtKeyString = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtIVstring = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbAES = new System.Windows.Forms.RadioButton();
			this.rbTripleDES = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDecodeText
			// 
			this.btnDecodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDecodeText.Location = new System.Drawing.Point(72, 326);
			this.btnDecodeText.Margin = new System.Windows.Forms.Padding(4);
			this.btnDecodeText.Name = "btnDecodeText";
			this.btnDecodeText.Size = new System.Drawing.Size(153, 28);
			this.btnDecodeText.TabIndex = 23;
			this.btnDecodeText.Text = "Decode Result Text";
			this.btnDecodeText.UseVisualStyleBackColor = true;
			this.btnDecodeText.Click += new System.EventHandler(this.btnDecodeText_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(400, 310);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "decoded text";
			// 
			// txtDecodedText
			// 
			this.txtDecodedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDecodedText.Location = new System.Drawing.Point(255, 327);
			this.txtDecodedText.Margin = new System.Windows.Forms.Padding(4);
			this.txtDecodedText.Name = "txtDecodedText";
			this.txtDecodedText.Size = new System.Drawing.Size(351, 23);
			this.txtDecodedText.TabIndex = 21;
			this.txtDecodedText.Text = "8.8.8.8";
			this.txtDecodedText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnEncodeText
			// 
			this.btnEncodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncodeText.Location = new System.Drawing.Point(163, 241);
			this.btnEncodeText.Margin = new System.Windows.Forms.Padding(4);
			this.btnEncodeText.Name = "btnEncodeText";
			this.btnEncodeText.Size = new System.Drawing.Size(115, 28);
			this.btnEncodeText.TabIndex = 20;
			this.btnEncodeText.Text = "Encode Text";
			this.btnEncodeText.UseVisualStyleBackColor = true;
			this.btnEncodeText.Click += new System.EventHandler(this.btnEncodeText_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(342, 398);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(81, 28);
			this.btnExit.TabIndex = 19;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(498, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Result";
			// 
			// txtOutputString
			// 
			this.txtOutputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutputString.Location = new System.Drawing.Point(342, 245);
			this.txtOutputString.Margin = new System.Windows.Forms.Padding(4);
			this.txtOutputString.Name = "txtOutputString";
			this.txtOutputString.Size = new System.Drawing.Size(351, 23);
			this.txtOutputString.TabIndex = 17;
			this.txtOutputString.Text = "8.8.8.8";
			this.txtOutputString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Text To Encode";
			// 
			// txtInputString
			// 
			this.txtInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputString.Location = new System.Drawing.Point(48, 193);
			this.txtInputString.Margin = new System.Windows.Forms.Padding(4);
			this.txtInputString.Name = "txtInputString";
			this.txtInputString.Size = new System.Drawing.Size(351, 23);
			this.txtInputString.TabIndex = 15;
			this.txtInputString.Text = "eat my shorts";
			this.txtInputString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(178, 91);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 25;
			this.label4.Text = "Key String";
			// 
			// txtKeyString
			// 
			this.txtKeyString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtKeyString.Location = new System.Drawing.Point(48, 108);
			this.txtKeyString.Margin = new System.Windows.Forms.Padding(4);
			this.txtKeyString.Name = "txtKeyString";
			this.txtKeyString.Size = new System.Drawing.Size(307, 23);
			this.txtKeyString.TabIndex = 24;
			this.txtKeyString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(485, 91);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 27;
			this.label5.Text = "IV String";
			// 
			// txtIVstring
			// 
			this.txtIVstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIVstring.Location = new System.Drawing.Point(381, 108);
			this.txtIVstring.Margin = new System.Windows.Forms.Padding(4);
			this.txtIVstring.Name = "txtIVstring";
			this.txtIVstring.Size = new System.Drawing.Size(312, 23);
			this.txtIVstring.TabIndex = 26;
			this.txtIVstring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbAES);
			this.groupBox1.Controls.Add(this.rbTripleDES);
			this.groupBox1.Location = new System.Drawing.Point(226, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(306, 45);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Encryption Type";
			// 
			// rbAES
			// 
			this.rbAES.AutoSize = true;
			this.rbAES.Checked = true;
			this.rbAES.Location = new System.Drawing.Point(199, 18);
			this.rbAES.Name = "rbAES";
			this.rbAES.Size = new System.Drawing.Size(46, 17);
			this.rbAES.TabIndex = 1;
			this.rbAES.TabStop = true;
			this.rbAES.Text = "AES";
			this.rbAES.UseVisualStyleBackColor = true;
			// 
			// rbTripleDES
			// 
			this.rbTripleDES.AutoSize = true;
			this.rbTripleDES.Location = new System.Drawing.Point(38, 18);
			this.rbTripleDES.Name = "rbTripleDES";
			this.rbTripleDES.Size = new System.Drawing.Size(73, 17);
			this.rbTripleDES.TabIndex = 0;
			this.rbTripleDES.Text = "TripleDES";
			this.rbTripleDES.UseVisualStyleBackColor = true;
			this.rbTripleDES.CheckedChanged += new System.EventHandler(this.rbTripleDES_CheckedChanged);
			// 
			// frmEncoderMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 456);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtIVstring);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtKeyString);
			this.Controls.Add(this.btnDecodeText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDecodedText);
			this.Controls.Add(this.btnEncodeText);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtOutputString);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtInputString);
			this.Name = "frmEncoderMain";
			this.Text = "Chuck\'s Encrypter/decrypter";
			this.Shown += new System.EventHandler(this.frmEncoderMain_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecodeText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecodedText;
        private System.Windows.Forms.Button btnEncodeText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIVstring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.RadioButton rbTripleDES;
    }
}

