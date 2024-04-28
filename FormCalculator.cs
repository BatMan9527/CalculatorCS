using CalculatorCS.InputStateMachine;

namespace CalculatorCS;

public partial class FormCalculator : Form
{
    public FormCalculator()
    {
        InitializeComponent();

        this.textBox1.DataBindings.Add("Text", calculatorInputManager, "CurrentInputLong");
        this.label1.DataBindings.Add("Text", calculatorInputManager, "Message");
    }


    private CalculatorInputManager calculatorInputManager = new CalculatorInputManager();


    private void button10_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_0);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_1);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_2);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_3);
    }

    private void button4_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_4);
    }

    private void button5_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_5);
    }

    private void button6_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_6);
    }

    private void button7_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_7);
    }

    private void button8_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_8);
    }

    private void button9_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_9);
    }

    private void button11_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.NUM_DOT);
    }

    private void button12_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_NEG);
    }

    private void button13_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_ADD);
    }

    private void button14_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_SUB);
    }

    private void button15_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_MUL);
    }

    private void button16_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_DIV);
    }

    private void button17_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_LEFT_BRACKET);
    }

    private void button18_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_RIGHT_BRACKET);
    }

    private void button19_Click(object sender, EventArgs e)
    {
        calculatorInputManager.Reset();
    }

    private void button20_Click(object sender, EventArgs e)
    {
        calculatorInputManager.Backspace();
    }

    private void button21_Click(object sender, EventArgs e)
    {
        calculatorInputManager.InputCharacter(CalculatorInputManager.OP_CAL);
    }
}
