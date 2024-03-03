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
            var conponent = new ComponentA();
            if (radioButton2.Checked)
            {
                conponent = new CompornentAUpper();
            }
            else if (radioButton3.Checked)
            {
                conponent = new CompornentALower();
            }

            var value = conponent.GetData();

            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conponent = new ComponentB();
            if (radioButton2.Checked)
            {
                conponent = new CompornentBUpper();
            }
            else if (radioButton3.Checked)
            {
                conponent = new CompornentBLower();
            }

            var value = conponent.GetData();

            button2.Text = value;

        }
    }
}