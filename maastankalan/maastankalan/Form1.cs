namespace maastankalan
{
    public partial class Form1 : Form
    {
        double maas;
        double toplam;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            maas= Convert.ToDouble(textBox3.Text);  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox2.Items[i]);
            }
            label6.Text = Convert.ToString(toplam);
            label7.Text = Convert.ToString(Convert.ToDouble(maas - toplam));
        }
    }
}