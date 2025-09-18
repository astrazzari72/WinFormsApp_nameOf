using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_nameOf
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string no = nameof(Form1);
			MessageBox.Show(
				no,
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string no = nameof(button2_Click);
			MessageBox.Show(
				no,
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string varConNomeLungo = "PIPPO";
			string no = nameof(varConNomeLungo);
			MessageBox.Show(
				no,
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		public void SetAge(int age)
		{
			if (age < 0)
				// Invece di scrivere la stringa manualmente:
				// throw new ArgumentException("Età non valida", "age");
				// si preferisce:
				throw new ArgumentException("Età non valida", nameof(age));
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				SetAge(-10);
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					ex.Message,
					"nameof",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string no = nameof(button5);
			MessageBox.Show(
				no,
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
