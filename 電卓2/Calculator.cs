
    class Calculator　//電卓のメソッドをかいている。
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.
                                        // 既定値は除算などの操作でエラーが発生する可能性がある場合の "非数値" です。
                                        // NaN (Not a Number)*1とは結果が存在しない演算の結果(非数)



            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;　　//0で割ったら、例外が発生する。catchで例外を受け取る。
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;　//返している。
        }
    }

