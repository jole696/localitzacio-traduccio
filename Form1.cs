namespace demo_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //assignar el mateix eventhandler a tots els botons del teclat numeric
            button1.Click += new EventHandler(teclat_Click);
            button2.Click += new EventHandler(teclat_Click);
            button3.Click += new EventHandler(teclat_Click);
            //



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
    }
}