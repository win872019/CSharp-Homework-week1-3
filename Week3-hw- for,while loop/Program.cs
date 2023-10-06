namespace Week3_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int max = int.MinValue;  (n個整數求最大值)
            //int min = int.MaxValue;  (n個整數求最小值)

            //web.form 可寫CSS


            //p.91
            //int sum = 0;
            //int tmp;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("輸入一個整數: ");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum += tmp;
            //}
            //Console.WriteLine($"總和{sum}");


            //p.93
            //int sum = 0;
            //int i = 0;
            //int tmp;

            //while (i < 5)
            //{
            //    Console.Write("輸入一個整數: ");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    sum += tmp;
            //    i++;
            //}
            //Console.WriteLine($"總和{sum}");
            //Console.ReadKey();


            //p.94-95
            //double sum = 0;
            //Console.Write("輸入一數字N，求N個數字的和，N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    sum += Convert.ToDouble(Console.ReadLine());
            //}
            //Console.WriteLine($"{n}個數字的和為{sum}");
            //Console.ReadKey();


            //p.96
            //double sum = 0;
            //int i = 0;
            //Console.Write("輸入一數字N，求N個數字的和，N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (i < n)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    sum += Convert.ToDouble(Console.ReadLine());                
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字的和為{sum}");
            //Console.ReadKey();


            //p.97-99
            //double max = double.MinValue;
            //double num;
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}
            //Console.WriteLine($"最大值為{max}");
            //Console.ReadKey();




            //p.100
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //double max = double.MinValue;
            //double num;
            //while (i < n)
            //{
            //    Console.Write($"輸入第{i + 1}數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字裡的最大值為{max}");
            //Console.ReadKey();





            //p.101-103
            //確認是否為奇數，再確認是否為最大數
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double max = double.MinValue;
            //double tmp;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    tmp = Convert.ToDouble(Console.ReadLine());
            //    if (tmp != 0 && tmp % 2 == 1)
            //    {

            //        if (tmp > max)
            //        {
            //            max = tmp;
            //        }
            //    }

            //}
            //Console.WriteLine($"輸入的數字裡最大的奇數為{max}");
            //Console.ReadKey();


            //p.104  *
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int max = int.MinValue;
            //int tmp;
            //int i = 1;
            //while (i <= n)
            //{
            //    Console.Write($"輸入第{i}個數字: ");
            //    tmp = Convert.ToInt32(Console.ReadLine());
            //    if (tmp != 0 && tmp % 2 != 0)
            //    {
            //        if (tmp > max)
            //        {
            //            max = tmp;
            //        }
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字裡最大的奇數為{max}");
            //Console.ReadKey();


            //p.105-106
            //Console.Write(("輸入一整數N: "));
            //int n = Convert.ToInt32(Console.ReadLine());
            //int num = 1;
            //for (int i = 2; i <= n; i++)
            //{
            //    num *=  i;  
            //}
            //Console.WriteLine($"{n}!={num}");


            //p.107
            //Console.Write(("輸入一整數N: "));
            //int n = Convert.ToInt32(Console.ReadLine());
            //int num = 1;
            //int i = 2;
            //while (i <= n)
            //{
            //    num *= i;
            //    i++;
            //}
            //Console.WriteLine($"{n}!={num}");






            //p.108-109 

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}");

            //    }
            //    Console.WriteLine("\n");

            //}
            //Console.ReadKey();



            //p.110   *注意：第1層迴圈開頭必需  j = 1; 下拉看 observation
            //int i = 1;
            //int j;
            //while (i <= 9)
            //{
            //    j = 1;
            //    while (j <= 9)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}");
            //        j++;
            //    }
            //    Console.WriteLine("\n");
            //    i++;
            //}
            //Console.ReadKey();






            //p.110 's observation*
            //int i = 2;
            //int j=1;

            //while (i <= 9)                
            //{
            //    //j = 1;
            //    Console.WriteLine($"樓上的i={i}");
            //    Console.WriteLine($"樓上的j={j}");
            //    while (j<=9)
            //    {
            //        Console.WriteLine($"{i}*{j}={i * j}");
            //        j++;
            //    }
            //    Console.WriteLine("\n");
            //    Console.WriteLine($"底部的j={ j}");
            //    i++;
            //    Console.WriteLine($"底部的i={i}");
            //}
            //Console.ReadKey();


            //p.111-112 (*)
            //for (int j = 1; j <= 9; j += 3)
            //{

            //    for (int i = 1; i <= 9; i++)
            //    {
            //        Console.WriteLine($"{j}*{i}={j*i}\t{j + 1}*{i}={(j +1) * i}\t{j + 2}*{i}={(j + 2) * i}");

            //    }
            //    Console.Write("\n");
            //}

            //Console.ReadKey();


            //p.113(*)
            //int j = 1;
            //int i ;
            //while (j <= 9)
            //{
            //    i = 1;
            //    while (i <= 9)
            //    {
            //        Console.WriteLine($"{j}*{i}={i}\t{j + 1}*{i}={(j + 1) * i}\t{j + 2}*{i}={(j + 2) * i}");
            //        i++;
            //    }
            //    Console.Write("\n");
            //    j += 3;
            //}
            //Console.ReadKey();





            //p.114 3-1 (p.116)
            //double min = double.MaxValue;
            //double num;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();


            //p.114 3-1 (p.117)
            //int n = 10;
            //int i = 0;
            //double min = double.MaxValue;
            //double num;
            //while (i <n )
            //{
            //    Console.Write($"輸入第{i + 1}數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字裡的最小值為{min}");
            //Console.ReadKey();





            //p.114 3-2 (p.119)
            //double min = double.MaxValue;
            //double num;
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine($"最小值為{min}");
            //Console.ReadKey();


            //p.114 3-2 (p.120)
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //double min = double.MaxValue;
            //double num;
            //while (i < n)
            //{
            //    Console.Write($"輸入第{i + 1}數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字裡的最小值為{min}");
            //Console.ReadKey();



            //p.114 3-3 (p.122)
            //string greater = "";
            //double num;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > 12)
            //    {
            //        greater += Convert.ToString(num) + " ";
            //    }
            //}
            //Console.WriteLine($"大於12的數字有{greater}");
            //Console.ReadKey();



            //p.114 3-3 (p.123)
            //string greater = "";
            //double num;
            //int i = 0;
            //while ( i < 10)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > 12)
            //    {
            //        greater += Convert.ToString(num) + " ";
            //    }
            //    i++;
            //}
            //Console.WriteLine($"大於12的數字有{greater}");
            //Console.ReadKey();


            //p.114 3-4 (p.125)
            //double sum=0;
            //double num;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > 12)
            //    {
            //       sum += num;
            //    }
            //}
            //Console.WriteLine($"所有大於12的數字的總和為{sum}");
            //Console.ReadKey();



            //p.114 3-4 (p.126)
            //double sum = 0;
            //double num;
            //int i = 0;
            //while(i < 10)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > 12)
            //    {
            //        sum += num;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"所有大於12的數字的總和為{sum}");
            //Console.ReadKey();


            //p.127 3-5 (p.129)
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double max = double.MinValue;
            //double tmp;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    tmp = Convert.ToDouble(Console.ReadLine());
            //    if (tmp != 0 && tmp % 2 == 1)
            //    {
            //        if (tmp > max)
            //        {
            //            max = tmp;
            //        }
            //    }
            //}
            //Console.WriteLine($"輸入的數字裡最大的奇數為{max}");
            //Console.ReadKey();


            //p.127 3-5 (p.130)
            //Console.Write("輸入一整數N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double max = double.MinValue;
            //double tmp;
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    tmp = Convert.ToDouble(Console.ReadLine());
            //    if (tmp != 0 && tmp % 2 != 0)
            //    {
            //        if (tmp > max)
            //        {
            //            max = tmp;
            //        }
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字裡最大的奇數為{max}");
            //Console.ReadKey();


            //p.127 3-6 (p.132)
            //double sum = 0;
            //double num;
            //Console.Write("輸入一數字N，求其所有正數之平方的加總，N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        sum += Math.Pow(num, 2);
            //    }

            //}
            //Console.WriteLine($"所有正數之平方的加總為{sum}");
            //Console.ReadKey();


            //p.127 3-6 (p.133)
            //double sum = 0;
            //int i = 0;
            //double num;
            //Console.Write("輸入一數字N，求其所有正數之平方的加總，N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (i < n)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num > 0)
            //    {
            //        sum += Math.Pow(num, 2);
            //    }
            //    i++;
            //}
            //Console.WriteLine($"所有正數之平方的加總為{sum}");
            //Console.ReadKey();



            //p.127 3-7 (p.135)
            //double num;
            //Console.Write("輸入一數字N，將其所有負數轉換成正數，N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num < 0)
            //    {
            //        Console.WriteLine($"{num}轉換正數為{-num}");
            //    }
            //    else if (num > 0)
            //    {
            //        Console.WriteLine($"{num}為正數");
            //    }else
            //    {
            //        Console.WriteLine(num);
            //    }

            //}
            // Console.ReadKey();


            //p.127 3-7 (p.136)
            //double num;
            //Console.Write("輸入一數字N，將其所有負數轉換成正數，N: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while ( i < n)
            //{
            //    Console.Write($"輸入第{i + 1}個數字: ");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    if (num < 0)
            //    {
            //        Console.WriteLine($"{num}轉換正數為{-num}");
            //    }
            //    else if (num > 0)
            //    {
            //        Console.WriteLine($"{num}為正數");
            //    }
            //    else
            //    {
            //        Console.WriteLine(num);
            //    }
            //    i++;

            //}
            //Console.ReadKey();



            //p.138 (p.139)
            // 判斷 100~200間有多少質數 (way.1)

            //int count = 0;
            //string primeNum = "";

            //for (int i = 100; i <= 200; i++)
            //{
            //    count = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //        if (count > 2)
            //        {
            //            break;
            //        }
            //    }
            //    if (count == 2)
            //    {
            //        primeNum +=Convert.ToString(i)+" ";
            //    }
            //}

            //Console.WriteLine($"100~200 的質數有 {primeNum}");
            //Console.ReadKey();



            // 判斷 100~200間有多少質數 (way.2 - 除數篩選範圍: Math.Sqrt())

            //int count = 0;
            //string primeNum = "";


            //for (int i = 100; i <= 200; i++)
            //{
            //    count = 0;
            //    for (int j = 1; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //        if (count >= 2)
            //        {
            //            break;
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        primeNum += Convert.ToString(i) + " ";
            //    }
            //}

            //Console.WriteLine($"100~200 的質數有 {primeNum}");
            //Console.ReadKey();




            //p.137 (p.140) *
            //簡單判定一數是否為質數-https://www.tutorialspoint.com/Chash-Program-to-check-if-a-number-is-prime-or-not
            //Console.Write("輸入一整數：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string ans = "";
            //int a = 0;                               //輸入的數字n是否為質數?
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }

            // }
            //if (a == 2)                                   //輸入的數字n是質數
            //{
            //    Console.WriteLine("{0} 是質數", n);
            //}
            //else                                          //輸入的數字n不是質數
            //{
            //    for (int j = 2; j < n; j++)   //開始找 2~(n-1) 範圍內的質數
            //    {
            //        if (n % j == 0)          //判斷j是否為n的因數
            //        {
            //            int b = 0;           //j是n的因數，判斷j是否為質數
            //            for (int k = 1; k <= j; k++)    //判斷j是否只能被 1 和 自己 整除
            //            {
            //                if (j % k == 0)
            //                {
            //                    b++;
            //                }
            //            }
            //            if (b == 2)               //j是質數 ，且上面已證明j是n的因數
            //            {
            //                ans += Convert.ToString(j) + " ";

            //            }
            //        }
            //    }
            //    Console.WriteLine($"{n}的質因數有{ans}");
            //    Console.ReadKey();
            //}



            //p.137 (p.140) -- 優化version -- if(a>3) 提前確認 非質數 即停止後面多跑的迴圈 *
            //Console.Write("輸入一整數：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string ans = "";
            //int a = 0;                               //輸入的數字n是否為質數?
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }
            //    if(a>3)                           //已能確認輸入的數字n不是質數
            //    {

            //        for (int j = 2; j < n; j++)   //開始找 2~(n-1) 範圍內的質因數(because和數一定有 2~(n-1)範圍的因數)
            //        {
            //            if (n % j == 0)          //判斷j是否為n的因數
            //            {
            //                int b = 0;           //j是n的因數，判斷j是否為質數
            //                for (int k = 1; k <= j; k++)    //判斷j是否只能被 1 和 自己 整除
            //                {
            //                    if (j % k == 0)
            //                    {
            //                        b++;
            //                    }
            //                    if(b>3)                //已能確認j非質數,提前終止loop
            //                    {
            //                        break;
            //                    }
            //                }
            //                if (b == 2)               //j是質數 ，且上面已證明j是n的因數
            //                {
            //                    ans += Convert.ToString(j) + " ";

            //                }
            //            }
            //        }
            //        Console.WriteLine($"{n}的質因數有{ans}");
            //        break;
            //    }

            //}
            //if (a == 2)                                   //輸入的數字n是質數
            //{
            //    Console.WriteLine("{0} 是質數", n);
            //}                
            // Console.ReadKey();








            //p.137 (p.141)*
            //Console.Write("輸入一整數：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string ans = "";
            //int a = 0;     
            //int i = 1;                          //輸入的數字n是否為質數?
            //while ( i <= n)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }
            //    i++;
            //}
            //if (a == 2)                                   //輸入的數字n是質數(because從1~自己本身只能被兩數整除)
            //{
            //    Console.WriteLine("{0} 是質數", n);
            //}
            //else                                          //輸入的數字n不是質數
            //{
            //    int j = 2;
            //    while ( j < n)   //開始找 2~(n-1) 範圍內的質數
            //    {
            //        if (n % j == 0)          //判斷j是否為n的因數
            //        {
            //            int b = 0;           //j是n的因數，判斷j是否為質數
            //            int k = 1;
            //            while ( k <= j )    //判斷j是否只能被 1 和 自己 整除
            //            {
            //                if (j % k == 0)
            //                {
            //                    b++;
            //                }
            //                k++;
            //            }
            //            if (b == 2)               //j是質數 ，且上面已證明j是n的因數
            //            {
            //                ans += Convert.ToString(j) + " ";

            //            }
            //        }
            //        j++;
            //    }
            //    Console.WriteLine($"{n}的質因數有{ans}");
            //    Console.ReadKey();
            //}





            //p.137 (p.141)-- 優化version -- if(a>3) 提前確認 非質數 即停止後面多跑的迴圈 *
            //Console.Write("輸入一整數：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //string ans = "";
            //int a = 0;
            //int i = 1;                          //輸入的數字n是否為質數?
            //while (i <= n)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }
            //    if (a > 3)                          //已能確認輸入的數字n不是質數
            //    {
            //        int j = 2;
            //        while (j < n)   //開始找 2~(n-1) 範圍內的質因數
            //        {
            //            if (n % j == 0)          //先判斷j是否為n的因數
            //            {
            //                int b = 0;           //j是n的因數，判斷j是否為質數
            //                int k = 1;
            //                while (k <= j)    //判斷j是否只能被 1 和 自己 整除
            //                {
            //                    if (j % k == 0)
            //                    {
            //                        b++;
            //                    }
            //                    if (b > 3)                  //已能確認j非質數,提前終止loop
            //                    {
            //                        break;
            //                    }
            //                    k++;
            //                }
            //                if (b == 2)               //j是質數 ，且上面已證明j是n的因數
            //                {
            //                    ans += Convert.ToString(j) + " ";

            //                }
            //            }
            //            j++;
            //        }
            //        Console.WriteLine($"{n}的質因數有{ans}");
            //        break;
            //    }
            //    i++;
            //}
            //if (a == 2)                                   //輸入的數字n是質數(because從1~自己本身只能被兩數整除)
            //{
            //    Console.WriteLine("{0} 是質數", n);
            //}
            //Console.ReadKey();








            //p.137 (p.142)(*)
            //int num = 0;
            //for (int i = 100; i <= 300; i++)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        num += 1;
            //    }

            //}
            //Console.WriteLine(num);


            //p.137 (p.143)(*)
            //int num = 0;
            //int i = 100;
            //while (i <= 300)
            //{
            //    if (i % 3 == 0 && i % 7 == 0)
            //    {
            //        num += 1;
            //    }
            //    i++;
            //}
            //Console.WriteLine(num);



            //p.148 求2數的最大公因數*

            //Console.Write("輸入一整數M:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("輸入一整數N:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //while(x!=y)
            //{
            //    if (x > y)
            //    {
            //        x = x - y;
            //    }else
            //    {
            //        y = y - x;
            //    }
            //}

            //Console.WriteLine($"最大公因數為{x}");            
            //Console.ReadKey();








            //p.152(p.153) *
            //Console.Write("輸入N； ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int s = 0;
            //if(i<=n)
            //{
            //    while(i<=n)
            //    {
            //        Console.Write($"輸入第{i}個數字: ");
            //        int x = Convert.ToInt32(Console.ReadLine());
            //        s = s + x;
            //        i++;
            //    }
            //    Console.WriteLine($"{n}個數字的和為{s}");
            //}
            //else
            //{
            //    Console.WriteLine($"S = {s}");
            //}
            //Console.ReadKey();



            //p.154 4-2 (p.158)
            // double sum=0;
            // Console.Write("輸入最起始值: ");
            // double a1=Convert.ToDouble(Console.ReadLine());
            // Console.Write("輸入間格差: ");
            // double d = Convert.ToDouble(Console.ReadLine());
            // Console.Write("輸入項數n: ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // int i = 0;
            //while (i < n)
            // {
            //     sum = sum + (a1 + (i * d));
            //     i++;
            // }
            // Console.WriteLine($"等差數的總和{sum}");
            // Console.ReadKey();


            //p.154 4-3 (p.160)
            //double sum = 0;
            //Console.Write("輸入項數n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while (i < n)
            //{
            //    Console.Write($"第{i+1}個數字: ");
            //    double num = Convert.ToDouble(Console.ReadLine());
            //    if(num<13)
            //    {
            //        sum += num;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"{n}個數字裡數值小於13的數值的總和為{sum}");
            //Console.ReadKey();


            //p.161 4-4(p.163)
            //Console.Write("輸入N: ");
            //int n =Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //double num;
            //while(i<n)
            //{
            //    Console.Write($"輸入第{i + 1}個數字");
            //    num=Convert.ToDouble(Console.ReadLine());
            //    if(num>7 && num<10)
            //    {
            //        Console.WriteLine($"{ num}大於7且小於10");
            //        break;
            //    }
            //    i++;
            //}
            //Console.ReadKey();



            //p.161 4-4(p.163) break test
            //for(int i = 0; i <8;i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == 6)
            //    {
            //        break;
            //        Console.WriteLine($"break執行後if內之i={i}");
            //    }
            //    Console.WriteLine("這行有執行");
            //}
            //Console.ReadKey();


            //p.161 4-5(p.165)
            //int n = 1;
            //while (n <= 5) 
            //{
            //    Console.Write($"輸入a{n}: ");
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    Console.Write($"輸入b{n}: ");
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    if ( a > b )
            //    {
            //        Console.WriteLine($"a{n}>b{n}，{a}>{b}");
            //        break;
            //    }
            //    n++;

            //}
            //Console.ReadKey();


            //p.169 Eric吃漢堡
            //Console.Write("輸入吃漢堡的時間: ");
            //double time = Convert.ToDouble(Console.ReadLine());
            //if (time < 5)
            //{
            //    Console.WriteLine("無法吃完一個漢堡");
            //}
            //else
            //{
            //    int through = 5;

            //    int counting = 1;
            //    while (time > 0)
            //    {
            //        if (time >= 5)
            //        {
            //            Console.WriteLine($"時間經過{through}分鐘，吃第{counting}個漢堡");
            //            counting++;
            //            time -= 5;
            //            through += 5;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"時間剩{time}分鐘，不夠再吃一個漢堡");
            //            break;                           //***********
            //        }

            //    }
            //}
            //Console.ReadKey();


            ////p.169 小明還房貸
            //int credit = 560;
            //int month = 0;
            //while (credit > 0)
            //{
            //    if ( month!=0&&month % 12 == 0)
            //    {
            //        credit -= 5;
            //    }
            //    else
            //    {
            //        credit -= 4;
            //    }
            //    month++;

            //}
            //Console.WriteLine($"需要{month}個月還清");
            //Console.ReadKey();





            //p.169 (p.172) 系統隨機產生一個數字 *需優化：提示 區間 優於  大於or小於

            //comment out部分：第一次Debug
            //第一次的bug：if(input < ans){}裡的
            //Console.Write($"答案大於{input}，繼續輸入: ");
            //提示句要寫 答案"大"於 ， 寫成答案"小"於
            //造成給出反方向提示

            //玩遊戲者 猜的方法： 可用 binary search


            //Random Num = new Random();
            //int ans = Num.Next(0, 100);
            //Console.Write("0-100猜一個數字，輸入整數: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //while (input != ans)
            //{
            //    //Console.WriteLine($"if上的 input={input} ans={ans}");
            //    if (input < ans)
            //    {
            //        //Console.WriteLine($"if下一的 input={input} ans={ans}");
            //        Console.Write($"答案大於{input}，繼續輸入: ");
            //        input = Convert.ToInt32(Console.ReadLine());
            //        //Console.WriteLine($"if下二的 input={input} ans={ans}");
            //        continue;
            //    }
            //    else
            //    {
            //        //Console.WriteLine($"else下一的 input={input} ans={ans}");
            //        Console.Write($"答案小於{input}，繼續輸入: ");
            //        input = Convert.ToInt32(Console.ReadLine());
            //        //Console.WriteLine($"else下二的 input={input} ans={ans}");
            //        continue;
            //    }
            //}
            //Console.WriteLine($"恭喜猜對!答案為{ans}");
            //Console.ReadKey();



            //p.169 (p.172) 系統隨機產生一個數字 --hw繳交 version
            //Random Num = new Random();
            //int ans = Num.Next(0, 100);
            //Console.Write("0-100猜一個數字，輸入整數: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //while (input != ans)
            //{
            //    if (input < ans)
            //    {    
            //        Console.Write($"答案大於{input}，繼續輸入: ");
            //        input = Convert.ToInt32(Console.ReadLine());
            //        continue;
            //    }
            //    else
            //    {
            //        Console.Write($"答案小於{input}，繼續輸入: ");
            //        input = Convert.ToInt32(Console.ReadLine());
            //        continue;
            //    }
            //}
            //Console.WriteLine($"恭喜猜對!答案為{ans}");
            //Console.ReadKey();





            //p.146

            //p.147
            //double x;
            //Console.Write("輸入一個整數: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //while (x >= 0)
            //{
            //    Console.Write("輸入一個整數: ");
            //    x = Convert.ToDouble(Console.ReadLine());
            //}
            //Console.WriteLine("end");
            //Console.ReadKey();


            //p.154 (p.156)
            //4-1
            //    double max=0;
            //    int i = 0;
            //    double num;
            //    Console.Write("輸入一數字N，求N個數字的最大值，N: ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    while (i < n)
            //    {
            //        Console.Write($"輸入第{i+1}個數字: ");
            //        num = Convert.ToDouble(Console.ReadLine());
            //        if (num > max)
            //        {
            //            max = num;
            //        }
            //        i++;
            //    }
            //    Console.WriteLine($"{n}個數字中，最大值為{max}");
            //    Console.ReadKey();
            //}
        }
    }
}