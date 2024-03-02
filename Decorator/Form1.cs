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
            var conponent = new ComponentA(radioButton2.Checked, radioButton3.Checked);
            var value = conponent.GetData();
            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var conponent = new ComponentB(radioButton2.Checked, radioButton3.Checked);
            var value = conponent.GetData();
            button2.Text = value;

        }
    }
}