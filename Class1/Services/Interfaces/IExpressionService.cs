using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorForm.Services.Interfaces
{
    public interface IExpressionService
    {
        double ProcessExpression(string expression);
    }
}
