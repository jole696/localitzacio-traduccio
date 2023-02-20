namespace demo_calculadora
{
    public partial class Form1 : Form
    {

        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        public Form1()
        {
            InitializeComponent();
            //assignar el mateix eventhandler a tots els botons del teclat numeric
            button1.Click += new EventHandler(teclat_Click);
            button2.Click += new EventHandler(teclat_Click);
            button3.Click += new EventHandler(teclat_Click);

            // carregar items al listbox
            comboBox1.Items.Add("Euro");
            comboBox1.Items.Add("YEN");
            comboBox1.Items.Add("$AUS");

            //
            //accedir a constants d'una altra classe
            //dades_conversor.USD_TO_EUR;
            //

            //gestió combobox
            comboBox1.Text = "Tria una opció";
        }

        private void teclat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            txtAmount.Text += number;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            //Button button = (Button)sender;
            //string number = button.Text;
            //txtAmount.Text += number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Format("Has triat índex {0} ", comboBox1.SelectedIndex.ToString));
            //txtAmount.Text = array2D[0, 0];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                comboBox1.Text = "Tria una opció";
            }
            else
            {
                comboBox1.Text = comboBox1.SelectedText;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}