using System.Text;
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
		private class MyClass
		{
			public int MyProp;
			public int MyFunc(int a)
			{
				return a;
			}
			public static string GetNameOf()
			{
				return @$"{nameof(MyClass)}
	.{nameof(MyProp)};
	.{nameof(MyFunc)};";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			// In C# nameof non valuta un’espressione o un’istanza, ma prende un identificatore (il nome di un tipo, variabile, membro, metodo, proprietà, ecc.) e lo restituisce come stringa.
			// Perciò NON puoi fare nameof(this) o nameof(this.currentMethod).
			// nameof(this) non compila → this non è un identificatore valido per nameof.
			// nameof(this.currentMethod)
			// nameof(currentMethod) non esistono

			string no = nameof(MyClass.GetNameOf);
			MessageBox.Show(
				no,
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			// Dentro la classe con metodo GetNameOf
			string no = MyClass.GetNameOf();
			MessageBox.Show(
				no,
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			// Fuori dalla classe → devo creare un'istanza
			var obj = new MyClass();
			string n0 = nameof(MyClass);
			string n3 = nameof(obj.MyProp);  // "MyProp"
			string n4 = nameof(obj.MyFunc);  // "MyFunc"
			MessageBox.Show(
				$"{n0} {n3} {n4}",
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
		class MyStaticClass
		{
			public static int MyStaticProp { get; set; }
			public static void MyStaticFunc() { }
		}
		private void button9_Click(object sender, EventArgs e)
		{
			// Statica → non serve un'istanza
			string n1 = nameof(MyStaticClass);                // "MyClass"
			string n2 = nameof(MyStaticClass.MyStaticProp);   // "MyStaticProp"
			string n3 = nameof(MyStaticClass.MyStaticFunc);   // "MyStaticFunc"
			MessageBox.Show(
				$"{n1} {n2} {n3}", //
				"nameof",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
