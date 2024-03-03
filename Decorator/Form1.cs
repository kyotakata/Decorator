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
            var value = component.GetData();
            button1.Text = value;
        }

    }
}