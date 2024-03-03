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

    }
}