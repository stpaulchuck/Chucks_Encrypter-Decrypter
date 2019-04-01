using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncoderDecoderTool
{
	public partial class frmEncoderMain : Form
	{
		byte[] outputbuffer = { };
		byte[] baKeyString;
		byte[] baIVstring;
		string sKeyString = "NoWis!@#Time4AllGOOd&*(M";
		string sIVstring = "aNY#oldk@ey!W@ilLDOifyOU";

		public frmEncoderMain()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEncodeText_Click(object sender, EventArgs e)
		{
			// legal sizes for AES Key = (128 to 256)/block size(currently 8), so 24*8=192
			// legal sizes for AES IV = 128/block size(currently 8), so 16*8=128
			// legal sizes for key in TripleDES is 128-192, IV seems to be mulitples of 8
			baKeyString = Encoding.UTF8.GetBytes(txtKeyString.Text);
			if (rbAES.Checked)
			{
				baIVstring = Encoding.UTF8.GetBytes(txtIVstring.Text.Substring(0, 16));
			}
			else if (rbTripleDES.Checked)
			{
				// seems to have the native ability to trim the string to what it wants
				baIVstring = Encoding.UTF8.GetBytes(txtIVstring.Text);
			}
			SymmetricAlgorithm oAlgorithm = null;
			if (rbTripleDES.Checked)
			{
				oAlgorithm = TripleDES.Create();
			}
			else if (rbAES.Checked)
			{
				oAlgorithm = Aes.Create();
			}
			ICryptoTransform oTransform = oAlgorithm.CreateEncryptor(baKeyString, baIVstring);
			try
			{
				byte[] inputbuffer = Encoding.Unicode.GetBytes(txtInputString.Text);
				outputbuffer = oTransform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
				txtOutputString.Text = Convert.ToBase64String(outputbuffer);
			}
			catch (Exception e9)
			{
				MessageBox.Show(this, "Error encoding!\n" + e9.Message);
			}
			finally
			{
				oTransform.Dispose();
				oTransform = null;
				oAlgorithm.Clear();
				oAlgorithm.Dispose();
				oAlgorithm = null;
			}
		}

		private void btnDecodeText_Click(object sender, EventArgs e)
		{
			try
			{
				baKeyString = Encoding.UTF8.GetBytes(txtKeyString.Text);
				if (rbAES.Checked)
				{
					baIVstring = Encoding.UTF8.GetBytes(txtIVstring.Text.Substring(0, 16));
				}
				else if (rbTripleDES.Checked)
				{
					// seems to have the native ability to trim the string to what it wants
					baIVstring = Encoding.UTF8.GetBytes(txtIVstring.Text);
				}

				SymmetricAlgorithm oAlgorithm = null;
				if (rbTripleDES.Checked)
				{
					oAlgorithm = TripleDES.Create();
				}
				else if (rbAES.Checked)
				{
					oAlgorithm = Aes.Create();
					
				}
				ICryptoTransform oTransform = oAlgorithm.CreateDecryptor(baKeyString, baIVstring);
				byte[] textToByte = Convert.FromBase64String(txtOutputString.Text);
				byte[] decrypted = oTransform.TransformFinalBlock(textToByte, 0, textToByte.Length);
				txtDecodedText.Text = Encoding.Unicode.GetString(decrypted);
			}
			catch (Exception e8)
			{
				MessageBox.Show(this, "decode failed: " + e8.Message + ", " + e8.StackTrace, "Decode Error");
			}
		}

		private void rbTripleDES_CheckedChanged(object sender, EventArgs e)
		{
			if (rbTripleDES.Checked)
				MessageBox.Show(this, "This encryption type is deprecated in favor or AES which is faster and more secure.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void frmEncoderMain_Shown(object sender, EventArgs e)
		{
			txtKeyString.Text = sKeyString;
			txtIVstring.Text = sIVstring;
		}
	} // end class
}  // end namespace
