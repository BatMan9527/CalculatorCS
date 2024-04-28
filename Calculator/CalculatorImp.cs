using CalculatorCS.InputStateMachine;

using System.Text.RegularExpressions;

namespace CalculatorCS.Calculator
{
    internal class CalculatorImp : CalculatorBase
    {
        private int GetPrecedence(char op)
        {
            if (op == CalculatorInputManager.OP_ADD || op == CalculatorInputManager.OP_SUB)
                return 1;
            if (op == CalculatorInputManager.OP_MUL || op == CalculatorInputManager.OP_DIV)
                return 2;

            return 0;
        }

        private bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^-[0-9]+(.[0-9]+)?|[0-9]+(.[0-9]+)?$");
            return regex.IsMatch(text);
        }

        public override double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public override double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1 / num2;
        }

        public override double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public override double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private List<string> ToPostfix(List<string> infix)
        {
            var output = new List<string>();
            var stack = new Stack<char>();

            foreach (var token in infix)
            {
                if (IsNumber(token)) // 如果是数字，直接输出  
                {
                    output.Add(token);
                }
                else if (token[0] == CalculatorInputManager.OP_LEFT_BRACKET) // 如果是左括号，压入栈  
                {
                    stack.Push(token[0]);
                }
                else if (token[0] == CalculatorInputManager.OP_RIGHT_BRACKET) // 如果是右括号，弹出栈顶元素直到遇到左括号  
                {
                    while (stack.Count > 0 && stack.Peek() != CalculatorInputManager.OP_LEFT_BRACKET)
                    {
                        output.Add(stack.Pop().ToString());
                    }
                    stack.Pop(); // 弹出左括号  
                }
                else if (CalculatorInputManager.IsOperator(token[0])) // 如果是运算符  
                {
                    while (stack.Count > 0 && GetPrecedence(token[0]) <= GetPrecedence(stack.Peek()))
                    {
                        output.Add(stack.Pop().ToString());
                    }
                    stack.Push(token[0]);
                }
            }

            // 弹出栈中剩余的运算符  
            while (stack.Count > 0)
            {
                output.Add(stack.Pop().ToString());
            }

            return output;
        }


        public override double Calculate(List<string> infix)
        {
            List<string> postfix = ToPostfix(infix);

            var stack = new Stack<double>();

            foreach (var token in postfix)
            {
                if (IsNumber(token)) // 如果是数字，压入栈  
                {
                    stack.Push(double.Parse(token));
                }
                else // 如果是运算符，从栈中弹出两个元素进行计算，然后将结果压回栈  
                {
                    if (stack.Count < 2)
                    {
                        throw new Exception("操作数不足，输入不正确");
                    }

                    var op2 = stack.Pop();
                    var op1 = stack.Pop();

                    switch (token[0])
                    {
                        case CalculatorInputManager.OP_ADD:
                            stack.Push(op1 + op2); break;
                        case CalculatorInputManager.OP_SUB:
                            stack.Push(op1 - op2); break;
                        case CalculatorInputManager.OP_MUL:
                            stack.Push(op1 * op2); break;
                        case CalculatorInputManager.OP_DIV:
                            stack.Push(op1 / op2); break;
                        default:
                            throw new NotSupportedException("不支持的运算符: " + token[0]);
                    }
                }
            }

            // 栈中应该只剩下一个操作数，即最终结果  
            if (stack.Count != 1)
            {
                throw new Exception("不正确的输入");
            }

            // 栈中应只有一个元素，即表达式的值
            return stack.Pop();
        }
    }
}
