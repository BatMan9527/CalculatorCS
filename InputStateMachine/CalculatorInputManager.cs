using CalculatorCS.Calculator;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CalculatorCS.InputStateMachine;

internal class CalculatorInputManager : INotifyPropertyChanged
{
    public enum CalculatorState
    {
        Initial,
        Number,
        NumberDot,
        Operator,
        Negtive,
        LeftBracket,
        RightBracket,
        Result
    }

    public const char OP_LEFT_BRACKET = '(';
    public const char OP_RIGHT_BRACKET = ')';
    public const char OP_MUL = '×';
    public const char OP_ADD = '＋';
    public const char OP_SUB = '－';
    public const char OP_DIV = '÷';
    public const char OP_CAL = '=';
    public const char OP_NEG = '-';         //区分一下负号和减号的处理
    public const char NUM_0 = '0';
    public const char NUM_1 = '1';
    public const char NUM_2 = '2';
    public const char NUM_3 = '3';
    public const char NUM_4 = '4';
    public const char NUM_5 = '5';
    public const char NUM_6 = '6';
    public const char NUM_7 = '7';
    public const char NUM_8 = '8';
    public const char NUM_9 = '9';
    public const char NUM_DOT = '.';

    private string _message = string.Empty;
    private CalculatorState _currentState = CalculatorState.Initial;
    private string _currentInputLong = string.Empty;
    private string _currentInput = string.Empty;
    private bool _currentNumberDotFlag = false;
    private int _currentPendingBracket = 0;
    private List<string> infix = new List<string>();

    private CalculatorBase calculator = new CalculatorImp();

    //添加一个属性，用于提供至界面绑定
    public string CurrentInputLong { get => _currentInputLong; set => SetValue(ref _currentInputLong, value); }
    public string Message { get => _message; set => SetValue(ref _message, value); }

    //实现INotifyPropertyChanged通知界面更新显示
    public event PropertyChangedEventHandler? PropertyChanged;

    //提供界面数据绑定
    //public string CurrentInputLong { get => _currentInputLong; set => _currentInputLong = value; }

    protected void SetValue<T>(ref T oldValue, T newValue, [CallerMemberName] string propertyName = "")
    {
        if (object.Equals(oldValue, newValue)) { return; }

        oldValue = newValue;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private bool IsAbleToCalculate()
    {
        if (_currentState != CalculatorState.Number && _currentState != CalculatorState.RightBracket)
        {
            Message = "当前还不可计算！";
            return false;
        }
        if (_currentPendingBracket != 0)
        {
            Message = "括号不匹配！";
            return false;
        }

        return true;
    }

    /// <summary>
    /// 重置数字输入状态
    /// </summary>
    private void ResetInputNumber()
    {
        _currentInput = string.Empty;
        _currentNumberDotFlag = false;
    }

    /// <summary>
    /// 初始状态处理
    /// </summary>
    private void ProcessStateInitial(char c)
    {
        if (char.IsDigit(c))
        {
            _currentInput += c;
            CurrentInputLong += c;
            _currentState = CalculatorState.Number;
        }
        else if (c == OP_LEFT_BRACKET)
        {
            CurrentInputLong += c;
            infix.Add(c.ToString());
            _currentPendingBracket++;
            _currentState = CalculatorState.LeftBracket;
        }
        else if (c == OP_NEG)
        {
            _currentInput += '-';
            CurrentInputLong += '-';
            _currentState = CalculatorState.Negtive;
        }
        else
        {
            Message = "非法输入.";
        }
    }

    /// <summary>
    /// 输入数字状态处理
    /// </summary>
    private void ProcessStateNumber(char c)
    {
        //输入数字之后,可以输入数字，小数点，右括号和运算符
        if (char.IsDigit(c))
        {
            _currentInput += c;
            CurrentInputLong += c;
        }
        else if (c == NUM_DOT)
        {
            if (_currentNumberDotFlag)
            {
                //throw new ArgumentException("Invalid decimal point input.");
                return;
            }

            _currentInput += c;
            CurrentInputLong += c;
            _currentState = CalculatorState.NumberDot;
        }
        else if (c == OP_RIGHT_BRACKET)
        {
            if (_currentPendingBracket <= 0) { return; }

            infix.Add(_currentInput);
            ResetInputNumber();
            CurrentInputLong += c;
            infix.Add(c.ToString());
            _currentPendingBracket--;
            _currentState = CalculatorState.RightBracket;
        }
        else if (IsOperator(c))
        {
            infix.Add(_currentInput);
            ResetInputNumber();
            CurrentInputLong += c;
            infix.Add(c.ToString());
            _currentState = CalculatorState.Operator;
        }
        else if (c == OP_CAL)
        {
            if (!IsAbleToCalculate()) { return; }

            if (_currentInput.Length > 0)
            {
                infix.Add(_currentInput);
            }

            string resText;
            if (TryGetResult(out resText))
            {
                _currentInput = resText;
                CurrentInputLong = resText;
                _currentState = CalculatorState.Result;
            }
        }
        else
        {
            Message = "非法输入.";
        }
    }
    private void ProcessStateNumberDot(char c)
    {
        //输入小数点后，只能继续输入数字
        if (char.IsDigit(c))
        {
            _currentInput += c;
            CurrentInputLong += c;
            _currentState = CalculatorState.Number;
        }
    }
    private void ProcessStateOperator(char c)
    {
        //输入运算符后，可继续输入负号，数字，左括号
        if (char.IsDigit(c))
        {
            _currentInput += c;
            CurrentInputLong += c;
            _currentState = CalculatorState.Number;
        }
        else if (c == OP_LEFT_BRACKET)
        {
            infix.Add(c.ToString());
            CurrentInputLong += c;
            _currentState = CalculatorState.LeftBracket;
        }
        else if (c == OP_NEG)
        {
            _currentInput += '-';
            CurrentInputLong += '-';
            _currentState = CalculatorState.Negtive;
        }
        else
        {
            Message = "非法输入.";
        }
    }
    private void ProcessStateNegtive(char c)
    {
        //输入负号后，只能继续输入数字
        if (char.IsDigit(c))
        {
            _currentInput += c;
            CurrentInputLong += c;
            _currentState = CalculatorState.Number;
        }
    }
    private void ProcessStateLeftBracket(char c)
    {
        //输入左括号后，还可继续输入负号，数字
        if (char.IsDigit(c))
        {
            _currentInput += c;
            CurrentInputLong += c;
            _currentState = CalculatorState.Number;
        }
        else if (c == OP_NEG)
        {
            _currentInput += '-';
            CurrentInputLong += '-';
            _currentState = CalculatorState.Negtive;
        }
        else
        {
            Message = "非法输入.";
        }

    }
    private void ProcessStateRightBracket(char c)
    {
        //输入右括号后，只可继续输入运算符
        if (IsOperator(c))
        {
            ResetInputNumber();
            infix.Add(c.ToString());
            CurrentInputLong += c;
            _currentState = CalculatorState.Operator;
        }
        else if (c == OP_CAL)
        {
            if (!IsAbleToCalculate()) { return; }

            if (_currentInput.Length > 0)
            {
                infix.Add(_currentInput);
            }

            string resText;
            if (TryGetResult(out resText))
            {
                _currentInput = resText;
                CurrentInputLong = resText;
                _currentState = CalculatorState.Result;
            }
        }
        else
        {
            Message = "非法输入.";
        }
    }
    private void ProcessStateResult(char c)
    {
        if (IsOperator(c))
        {
            //输出完结果以后，可继续输入运算符连续运算
            infix.Add(_currentInput);
            ResetInputNumber();
            infix.Add(c.ToString());
            CurrentInputLong += c;
            _currentState = CalculatorState.Operator;
        }
        else if (c == OP_CAL)
        {
            return;
        }
        else
        {
            //输入其它情况则置为初始态
            Reset();
            InputCharacter(c);
        }
    }

    private bool TryGetResult(out string resText)
    {
        resText = string.Empty;
        if (_currentPendingBracket != 0) { return false; }

        try
        {
            double result = calculator.Calculate(infix);
            resText = result.ToString("0.####");

            //重置当前表达式
            infix.Clear();
            Message = string.Empty;
            return true;
        }
        catch (Exception ex)
        {
            Message = ex.Message;
            return false;
        }
    }

    public void InputCharacter(char c)
    {
        switch (_currentState)
        {
            case CalculatorState.Initial:
                ProcessStateInitial(c);
                break;

            case CalculatorState.Number:
                ProcessStateNumber(c);
                break;

            case CalculatorState.NumberDot:
                ProcessStateNumberDot(c);
                break;

            case CalculatorState.Operator:
                ProcessStateOperator(c);
                break;

            case CalculatorState.Negtive:
                ProcessStateNegtive(c);
                break;

            case CalculatorState.LeftBracket:
                ProcessStateLeftBracket(c);
                break;

            case CalculatorState.RightBracket:
                ProcessStateRightBracket(c);
                break;

            case CalculatorState.Result:
                ProcessStateResult(c);
                break;
        }
    }

    public void Reset()
    {
        _currentState = CalculatorState.Initial;
        CurrentInputLong = string.Empty;
        _currentInput = string.Empty;
        _currentNumberDotFlag = false;
        _currentPendingBracket = 0;
        infix.Clear();
        Message = string.Empty;
    }

    public void Backspace()
    {
        if (CurrentInputLong.Length > 0)
        {
            CurrentInputLong.Remove(CurrentInputLong.Length - 1, 1);
        }


        string sourceInput = CurrentInputLong;
        Reset();
        //这里有点没想好，目前回退就按照重新输入一遍处理了
        foreach (var c in sourceInput)
        {
            InputCharacter(c);
        }
    }

    public static bool IsOperator(char c)
    {
        return c == OP_MUL
            || c == OP_ADD
            || c == OP_SUB
            || c == OP_DIV;
    }


}
