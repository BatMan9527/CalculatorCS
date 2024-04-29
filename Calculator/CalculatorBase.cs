using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCS.Calculator;

internal abstract class CalculatorBase
{
    /// <summary>
    /// 加法
    /// </summary>
    public abstract double Add(double num1, double num2);

    /// <summary>
    /// 减法
    /// </summary>
    public abstract double Subtract(double num1, double num2);

    /// <summary>
    /// 乘法
    /// </summary>
    public abstract double Multiply(double num1, double num2);

    /// <summary>
    /// 除法
    /// </summary>
    public abstract double Divide(double num1, double num2);

    /// <summary>
    /// 计算中缀表达式
    /// </summary>
    public abstract double Calculate(IEnumerable<string> infix);


}
