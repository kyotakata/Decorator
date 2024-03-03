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

            var value = conponent.GetData();

            button1.Text = value;
        }

    }
}