namespace hwTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-1
            /*      Console.WriteLine("請輸入數字 a, b, c, d，計算(a + b) / (c - d) * d:");
                  Console.Write("a: ");
                  double a = Convert.ToDouble(Console.ReadLine());
                  Console.Write("b: ");
                  double b = Convert.ToDouble(Console.ReadLine());
                  Console.Write("c: ");
                  double c = Convert.ToDouble(Console.ReadLine());
                  Console.Write("d: ");
                  double d = Convert.ToDouble(Console.ReadLine());
                  double answer = (a + b) / (c - d) * d;
                  Console.WriteLine("計算結果等於:" + answer);
                  Console.ReadKey();
              */


            // 1-2
            /*        Console.WriteLine("請輸入數字 a1, b1, c1, a2, b2, c2，計算二元一次方程式 a1x + b1y = c1， a1x + b2y = c2 之 x,y");
                    Console.Write("a1: ");
                    double a1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b1: ");
                    double b1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c1: ");
                    double c1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("a2: ");
                    double a2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b2: ");
                    double b2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c2: ");
                    double c2 = Convert.ToDouble(Console.ReadLine());
                    double x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);
                    double y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);
                    Console.WriteLine("計算結果： x等於 " + x + "，y等於 " + y);
                    Console.ReadKey();
             */


            // 1-3
            /*
                Console.WriteLine("請輸入數字 a, b，計算 c = (a^1 + b^2) / (a^2 - b^2)");
                Console.Write("a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double c = (Math.Pow(a, 1) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
                Console.WriteLine("計算結果: c= " + c);
                Console.ReadKey();
           */

            //1-4

            /*   Console.WriteLine("請輸入數字 a, b，計算 c = √(a^2 + b^2)" );
                  Console.Write("a: ");
                  double a = Convert.ToDouble(Console.ReadLine());
                  Console.Write("b: ");
                  double b = Convert.ToDouble(Console.ReadLine());

                  double c = (Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2))));
                  Console.WriteLine("計算結果: c= " + c);
                  Console.ReadKey();
            */
            //1-5

            /*    Console.WriteLine("請輸入數字 a, b, c，求 c = a - (b + c ) (3 a - c)");
                Console.Write("a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c: ");
                double c = Convert.ToDouble(Console.ReadLine());
                c = (a - (b + c) * ((3 * a) - c));
                Console.WriteLine("c 現值為 " + c);
                Console.ReadKey();
            */


            //1-6
            /*
            Console.Write("輸入任意正負數字(求絕對值)： ");
            double a = Convert.ToDouble(Console.ReadLine());
            double absolute = Math.Abs(a);
            Console.WriteLine($"{a}絕對值為 " + absolute);
            Console.ReadKey();

            */


            // 1- 7
            Console.Write("請輸入西元年份(轉換成民國年份)： ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"西元{a} 年轉換民國年份為 " + (a - 1911) + "年");
            Console.ReadKey();



            //1-8
       /*   Console.WriteLine("請輸入身高體重，輸出BMI ");
            Console.Write("身高(cm): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("體重(kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / Math.Pow(height / 100, 2);
            Console.WriteLine("BMI:" + BMI);
            Console.ReadKey();
       */
        }
    }
}

