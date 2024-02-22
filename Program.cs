using System;
using org.matheval;

namespace math;

class Program {
  private static Operator operatorEnum = Operator.None;
  private static string operandStr = "";

  public static void Main(string[] args) {
    string? inExpression = Console.ReadLine();

    if (inExpression == null) {
      DisplayHelp();
      return;
    }

    foreach (string str in args) {
      if (str.StartsWith("-")) {
        char[] chars = str.ToCharArray();
        foreach (char chr in chars) {
          switch (chr.ToString()) {
            case "h":
              DisplayHelp();
              return;
            case "a":
              operatorEnum = Operator.Add;
              break;
            case "s":
              operatorEnum = Operator.Subtract;
              break;
            case "m":
              operatorEnum = Operator.Multiply;
              break;
            case "d":
              operatorEnum = Operator.Divide;
              break;
          }
        }
      }else {
        operandStr = str;
      }
    }

    if (operatorEnum == Operator.None) {
      DisplayHelp();
      return;
    }

    switch(operatorEnum) {
      case Operator.Add:
        operandStr = " + " + operandStr;
        break;
      case Operator.Subtract:
        operandStr = " - " + operandStr;
        break;
      case Operator.Multiply:
        operandStr = " * " + operandStr;
        break;
      case Operator.Divide:
        operandStr = " / " + operandStr;
        break;
    }

    Expression expression = new Expression("(" + inExpression + ")" + operandStr);
		Console.Write(expression.Eval());
  }

  private static void DisplayHelp() {
    Console.WriteLine("{expression} | math -{OPTION} {OPERAND}");
    Console.WriteLine("eg: echo \"(1*3)\" | math -a 1");
    Console.WriteLine("Options:");
    Console.WriteLine("  a: add");
    Console.WriteLine("  s: subtract");
    Console.WriteLine("  m: multiply");
    Console.WriteLine("  d: divide");
    Console.WriteLine("  h: display this help string");
  }

  private enum Operator {
    Add,
    Subtract,
    Multiply,
    Divide,
    None
  }
}
