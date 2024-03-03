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
            IComponent component = new ComponentA();// var���Ƌ�ۃN���X�̌^(ComponentA)�ɂȂ�̂ŁAIComponent���w�肷��B

            if (radioButton2.Checked)
            {
                component = new DecoratorUpper(component); //����āA�����ŃG���[�ɂȂ�Ȃ�
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
            IComponent component = new ComponentB();// var���Ƌ�ۃN���X�̌^(ComponentB)�ɂȂ�̂ŁAIComponent���w�肷��B

            if (radioButton2.Checked)
            {
                component = new DecoratorUpper(component); //����āA�����ŃG���[�ɂȂ�Ȃ�
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