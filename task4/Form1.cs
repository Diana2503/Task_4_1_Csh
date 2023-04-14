using System;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        Computer computer;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (computer == null)
            {
                MessageBox.Show("Компьютера не существует!");
                return;
            }

            allInfF.Text = computer.toString();
        }

        private void qpButton_Click(object sender, EventArgs e)
        {
            if (computer == null)
            {
                MessageBox.Show("Компьютера не существует!");
                return;
            }

            label6.Text = $"{this.computer.CalculateQ()}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string processorName = this.nameF.Text;
                double frequency = double.Parse(this.lenghtF.Text);
                int amountRAM = int.Parse(this.cCF.Text);
                double amountHdd = double.Parse(this.velocityF.Text);

                this.computer = new Macintosh(processorName, frequency, amountRAM, amountHdd);

                MessageBox.Show("Компьютер создан!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Компьютера не существует!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
