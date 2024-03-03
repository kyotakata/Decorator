using Decorator.Objects;

namespace Decorator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var component = new ComponentA();

            string value = "";

            if (radioButton2.Checked)
            {
                value = component.GetDataUpper();
            }
            else if (radioButton3.Checked)
            {
                value = component.GetDataLower();
            }
            else
            {
                value = component.GetData();
            }
            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var component = new ComponentB();

            string value = "";

            if (radioButton2.Checked)
            {
                value = component.GetDataUpper();
            }
            else if (radioButton3.Checked)
            {
                value = component.GetDataLower();
            }
            else
            {
                value = component.GetData();
            }
            button2.Text = value;

        }
    }
}