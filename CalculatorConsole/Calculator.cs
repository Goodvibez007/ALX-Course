using CalculatorForm.Services;
using CalculatorForm.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class Calculator
    {
        private IExpressionService Service;

        public Calculator()
        {
            Service = new ExpressionService();
        }

        public void Run()
        {
            Console.WriteLine("Enter an expression: ");
            var expression = Console.ReadLine();
            expression = RefactorExpression(expression);
            var result = Service.ProcessExpression(expression);
            Console.WriteLine($"Result: {result}");
        }

        private string? RefactorExpression(string? expression)
        {
            expression = expression.Trim();
            expression = expression.Replace(" ", String.Empty);
            if (!expression.EndsWith("="))
            {
                expression += "=";
            }
            return expression;
        }
    }
}
