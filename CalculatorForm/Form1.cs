using CalculatorForm.Services;
using CalculatorForm.Services.Interfaces;
using System.Text;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {
        private StringBuilder ExpressionBuilder { get; set; }
        //private ICalculatorService CalculatorService { get; set; }
        private IExpressionService ExpressionService { get; set; }

        public CalculatorForm()
        {
            ExpressionBuilder = new StringBuilder();
            ExpressionService = new ExpressionService();
            ExpressionBuilder.Clear();            
            InitializeComponent();
        }

        private void StringBuilderButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Append("Hello ");
            ExpressionBuilder.Append("user ");
            ExpressionBuilder.Append("this ");
            ExpressionBuilder.Append("is ");
            ExpressionBuilder.Append("a ");
            ExpressionBuilder.Append("stringbuilder. ");
            ResultTextBox.Text = ExpressionBuilder.ToString();
            ExpressionBuilder.Clear();
        }

        private void ButtonsClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            ExpressionBuilder.Append(button.Tag);
            LogBox.Text += button.Tag;
            if (ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = "";
                ResultTextBox.Text += button.Tag;
            }
            else
            {
                ResultTextBox.Text += button.Tag;
            }
        }


        /*private void Key1Button_Click(object sender, EventArgs e)
        {
            AppendExpression("1");
        }

        private void Key2Button_Click(object sender, EventArgs e)
        {
            AppendExpression("2");
        }

        private void Key3Button_Click(object sender, EventArgs e)
        {
            AppendExpression("3");
        }

        private void Key4Button_Click(object sender, EventArgs e)
        {
            AppendExpression("4");
        }

        private void Key5Button_Click(object sender, EventArgs e)
        {
            AppendExpression("5");
        }

        private void Key6Button_Click(object sender, EventArgs e)
        {
            AppendExpression("6");
        }

        private void Key7Button_Click(object sender, EventArgs e)
        {
            AppendExpression("7");
        }

        private void Key8Button_Click(object sender, EventArgs e)
        {
            AppendExpression("8");
        }

        private void Key9Button_Click(object sender, EventArgs e)
        {
            AppendExpression("9");
        }

        private void Key0Button_Click(object sender, EventArgs e)
        {
            AppendExpression("0");
        }

        private void KeyComaButton_Click(object sender, EventArgs e)
        {
            AppendExpression(",");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AppendExpression("+");
        }

        private void SubstractButton_Click(object sender, EventArgs e)
        {
            AppendExpression("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            AppendExpression("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            AppendExpression("/");
        }*/

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResultTextBox.Text = ExpressionBuilder.ToString();
            ResultTextBox.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AppendExpression(button.Text);
            var expression = ResultTextBox.Text;
            var result = ExpressionService.ProcessExpression(expression);
            ResultTextBox.Text = result.ToString();
            ExpressionBuilder.Clear();
        }

        private void AppendExpression(string express)
        {
            ExpressionBuilder.Append($"{express}");
            ResultTextBox.Text = ExpressionBuilder.ToString();

            var textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), ResultTextBox.Font);
            while (textLenght.Width > ResultTextBox.Width)
            {
                ResultTextBox.Font = new Font(ResultTextBox.Font.FontFamily, ResultTextBox.Font.Size - 1f);
                textLenght = TextRenderer.MeasureText(ExpressionBuilder.ToString(), ResultTextBox.Font);
            }
        }
    }
}