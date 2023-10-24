namespace GammaShifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void choiseMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choiseMethod.SelectedIndex == 0)
            {
                dopYsl.Visible = true;
                labelDopYsl.Visible = true;
                labelDopYsl.Text = "Дополнительное условие: ключ";
                labelDopYsl.Location = new Point(451, 111);
                dopYsl.Text = "";
            }
            else if (choiseMethod.SelectedIndex == 1)
            {
                dopYsl.Visible = true;
                labelDopYsl.Visible = true;
                labelDopYsl.Text = "Дополнительное условие: ключ";
                labelDopYsl.Location = new Point(451, 111);
                dopYsl.Text = "";
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (choiseMethod.SelectedIndex == 0)
                itogEncrypt.Text = modN.Decoding(entryMassenge.Text, dopYsl.Text);

            else if (choiseMethod.SelectedIndex == 1)
                itogEncrypt.Text = mod2.Decoding(entryMassenge.Text, dopYsl.Text);
        }
    }
}