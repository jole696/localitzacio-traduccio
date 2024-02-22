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
            button6.Click += new EventHandler(teclat_Click);
            button7.Click += new EventHandler(teclat_Click);
            button8.Click += new EventHandler(teclat_Click);
            button9.Click += new EventHandler(teclat_Click);
            button10.Click += new EventHandler(teclat_Click);
            button11.Click += new EventHandler(teclat_Click);

            
            button12.Click += new EventHandler(erease);


            button5.Click += new EventHandler(convertir);



            // carregar items al listbox
            comboBox1.Items.Add("Euro");
            comboBox1.Items.Add("YEN");
            comboBox1.Items.Add("$AUS");

            comboBox2.Items.Add("Euro");
            comboBox2.Items.Add("YEN");
            comboBox2.Items.Add("$AUS");

            //
            //accedir a constants d'una altra classe
            //dades_conversor.USD_TO_EUR;
            //

            //gestió combobox
            comboBox1.Text = "Tria una opció";
            comboBox2.Text = "Tria una opció";

        }
        private void erease(object sender, EventArgs e)
        {
            txtAmount.Text = "";

        }
        private void convertir(object sender, EventArgs e)
        {
            string text = txtAmount.Text;

            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Necesitas seleccionar las 2 unidades e introducir numeros");
            } else
            {
                double numero = double.Parse(text);
                string selectedItem1 = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                string selectedItem2 = comboBox2.Items[comboBox2.SelectedIndex].ToString();

                //Euro a yen
                if (selectedItem1 == "Euro" && selectedItem2 == "YEN")
                {
                    double tasaDeCambio = 163.04;
                    numero = numero * tasaDeCambio;
                }
                //Euro a $AUS
                if (selectedItem1 == "Euro" && selectedItem2 == "$AUS")
                {
                    double tasaDeCambio = 1.65;
                    numero = numero * tasaDeCambio;
                }
                //YEN a Euro
                if (selectedItem1 == "YEN" && selectedItem2 == "Euro")
                {
                    double tasaDeCambio = 0.0061;
                    numero = numero * tasaDeCambio;

                }
                //YEN a $AUS
                if (selectedItem1 == "YEN" && selectedItem2 == "$AUS")
                {
                    double tasaDeCambio = 0.010;
                    numero = numero * tasaDeCambio;

                }
                //$AUS a Euro
                if (selectedItem1 == "$AUS" && selectedItem2 == "Euro")
                {
                    double tasaDeCambio = 0.61;
                    numero = numero * tasaDeCambio;
                }
                //$AUS a YEN
                if (selectedItem1 == "$AUS" && selectedItem2 == "YEN")
                {
                    double tasaDeCambio = 98.89;
                    numero = numero * tasaDeCambio;
                }

                if (selectedItem1 == selectedItem2)
                {
                    MessageBox.Show("No puedes tranformar el mismo tipo de moneda");
                } else
                {
                    textBox1.Text = numero.ToString();
                }


            }



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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
    }
}