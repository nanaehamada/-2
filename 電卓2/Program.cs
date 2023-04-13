
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;    //bool型は真偽値。変数を初期値は『偽』で宣言。⇒アプリを終了しないでくださいとの意。
        
        // Display title as the C# console calculator app.　＝コンソール画面のタイトル。calculatorカリキュレーターは電卓の意。appはアプリケーション。
        Console.WriteLine("Console Calculator in C#\r");    //●\rは『復帰』＝カーソルが行の先頭に移る。　何故ここに記述する？
        Console.WriteLine("------------------------\n");    //●\nは『改行』　何故ここに記述する？
          
        while (!endApp)   //●！の意味？⇒『倫理否定』。『!x』がtrueの場合は『偽』。falseの場合は『正』。でも今回は変数定義より、trueの場合は『正』となる◎endAppエンドアップ
        {
                // Declare variables and set to empty.＝変数を宣言し、初期値は空です。
                string numInput1 = "";　//文字列型
                string numInput2 = "";　//文字列型
                double result = 0;

                // Ask the user to type the first number.＝ユーザーに1つ目の文字を尋ねる。
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();    //ReadLine()…読み込み。ライン(行)をエディタ(編集する)の意味。◎一般的にシェルがコマンドを受け付けるところで使われる。


                double cleanNum1 = 0;　　//初期値0でdouble型変数を定義。

                while (!double.TryParse(numInput1, out cleanNum1))　//while()はループする。文字型を数値型に変換している。
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");　//数値を入力してください。文字だと、ダメだから再度繰り返し表示される。
                    numInput1 = Console.ReadLine();  //ReadLine()…ライン(行)をエディタ(編集する)の意味。◎一般的にシェルがコマンドを受け付けるところで使われる。
          　　  }

                // Ask the user to type the second number.＝ユーザーに2つ目の文字を尋ねる。
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");       //Lineを記述しない場合⇒コンソール画面で、入力する文字が改行されないで、Your option?の後ろに記述される。

                string op = Console.ReadLine();

                try　　　　　　　　　　　　　　　　　//例外を受け取りたい場合はtryの中に記述。　
                
                //try…、catch…、0で割ったり・配列の数より大きくアクセスした場合等
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);　　//電卓に対して操作してね
                    if (double.IsNaN(result))　　　//not a number＝演算した結果数値じゃなくなった。0で割った結果、double型の許容を超えた場合にNaNに変換される。
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);  //正常な演算が出来た場合、{0:0.##}がresult結果に置き換わる。
          　　  }
                catch (Exception e) //Exception e例外の意。Exception全ての例外を意味。（好きな例外を発生した場合のみキャッチすることもできる。）
               
  　
            　　{
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: "); //nが入力されたら、(!endApp)がtrueになるとループを抜け出す。
                if (Console.ReadLine() == "n") endApp = true;　//YesNoのn。

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }

