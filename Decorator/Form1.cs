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
            IComponent component = new ComponentA();// varだと具象クラスの型(ComponentA)になるので、IComponentを指定する。

            if (radioButton2.Checked)
            {
                component = new DecoratorUpper(component); //よって、ここでエラーにならない
            }
            else if(radioButton3.Checked)
            {
                component = new DecoratorLower(component);
            }

            var value = component.GetData();
            button1.Text = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IComponent component = new ComponentB();// varだと具象クラスの型(ComponentB)になるので、IComponentを指定する。

            if (radioButton2.Checked)
            {
                component = new DecoratorUpper(component); //よって、ここでエラーにならない
            }
            else if (radioButton3.Checked)
            {
                component = new DecoratorLower(component);
            }

            var value = component.GetData();
            button2.Text = value;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IComponent component = new ComponentA();
            component = new DecoratorUpper(component);
            component = new DecoratorLower(component);
            button3.Text = component.GetPrice().ToString();
        }
    }
}