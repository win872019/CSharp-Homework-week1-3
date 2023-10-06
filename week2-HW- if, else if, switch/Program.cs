namespace week2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // P.64

            //Console.Write("輸入購買商品總金額: ");
            //double money = Convert.ToDouble(Console.ReadLine());

            //if (money < 1000 && money > 0)
            //{
            //    Console.WriteLine($"無折扣，金額為 {money}");
            //}
            //else if (money >= 10000)
            //{
            //    money = (int)Math.Round(money * 0.7, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"七折，金額為 {money}");
            //}
            //else if (money >= 5000 && money < 10000)
            //{
            //    money = (int)Math.Round(money * 0.8, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"八折，金額為 {money}");
            //}
            //else if (money >= 1000 && money < 5000)
            //{
            //    money = (int)Math.Round(money * 0.9, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"九折，金額為 {money}");
            //}
            //else
            //{
            //    Console.WriteLine("無法判讀");
            //}




            //Console.ReadKey();


            // p.64 由大至小判別

            //Console.Write("輸入購買商品總金額: ");
            //double money = Convert.ToDouble(Console.ReadLine());

            //if (money >= 10000)
            //{
            //    money = (int)Math.Round(money * 0.7, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"七折，金額為 {money}");

            //}
            //else if (money >= 5000)
            //{
            //    money = (int)Math.Round(money * 0.8, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"八折，金額為 {money}");                
            //}
            //else if (money >= 1000)
            //{
            //    money = (int)Math.Round(money * 0.9, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"九折，金額為 {money}");
            //}
            //else if (money > 0)
            //{
            //    Console.WriteLine($"無折扣，金額為 {money}");
            //}
            //else
            //{
            //    Console.WriteLine("無法判讀");
            //}
            //Console.ReadKey();


            //P.55

            //Console.Write("輸入 x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 y: ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //if (x > y)
            //{
            //    Console.WriteLine("x大");
            //}
            //else if (x < y)
            //{
            //    Console.WriteLine("y大");
            //}else
            //{
            //    Console.WriteLine("一樣");
            //}
            //Console.ReadKey();


            //P.57

            //Console.Write("輸入 x: ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 y: ");
            //double y = Convert.ToDouble(Console.ReadLine());
            //if (x > y)
            //{
            //    Console.WriteLine($"{x}-{y}={x-y}");            
            //}
            //else
            //{
            //    Console.WriteLine($"{y}-{x}={y-x}");
            //}
            //Console.ReadKey();


            //p.59

            //Console.Write("輸入 x: ");
            //double x = Convert.ToDouble(Console.ReadLine());

            //if (x == 0)
            //{
            //    Console.WriteLine($"{x}");
            //}
            //else if (x < 0)
            //{
            //    Console.WriteLine($"x轉正數為{-x}");
            //}
            //else
            //{
            //    Console.WriteLine($"{x}為正數");
            //}
            //Console.ReadKey();


            //p.61
            //Console.Write("輸入分數: ");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("Grade D");
            //}
            //else
            //{
            //    Console.WriteLine("Grade F");
            //}
            //Console.ReadKey();


            //p.63
            //Console.Write("輸入分數: ");
            //int score = Convert.ToInt32(Console.ReadLine());
            //score = score / 10;

            //switch (score)
            //{
            //    case  10:
            //        Console.WriteLine("Grade A");
            //        break;
            //    case 9:
            //        Console.WriteLine("Grade A");
            //        break;
            //    case 8:
            //        Console.WriteLine("Grade B");
            //        break;
            //    case 7:
            //        Console.WriteLine("Grade C");
            //        break;
            //    case 6:
            //        Console.WriteLine("Grade D");
            //        break;

            //    default:
            //        Console.WriteLine("Grade F");
            //        break;
            //}
            //Console.ReadKey();


            //p.67 2-1
            //Console.Write("輸入 x: ");
            //int x = Convert.ToInt32 (Console.ReadLine());
            //Console.Write("輸入 y: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x >= y)
            //{
            //    Console.WriteLine(x);
            //}else
            //{
            //    Console.WriteLine(y);
            //}
            //Console.ReadKey();


            // p.67 2 - 2
            //int z;
            //Console.Write("輸入 x: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("輸入 y: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    z = 1;
            //}
            //else if (x < 0 && y < 0)
            //{
            //    z = -1;
            //}
            //else
            //{
            //    z = 0;
            //}
            //Console.WriteLine(z);
            //Console.ReadKey();



            // p.67 2 - 3
            //double x, y, u, v, z;
            //Console.Write("輸入 x: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 y: ");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 u: ");
            //u = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 v: ");
            //v = Convert.ToDouble(Console.ReadLine());

            //if ((x + y) > (u + v))
            //{
            //    z = x - y;
            //    Console.WriteLine($"z = x - y， z = {z}");
            //}
            //else
            //{
            //    z = u - v;
            //    Console.WriteLine($"z = u - v， z = {z}");
            //}

            //Console.ReadKey();


            //p.74 2-4

            //double x, y, u, v, z;

            //Console.Write("輸入 x: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 y: ");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 u: ");
            //u = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 v: ");
            //v = Convert.ToDouble(Console.ReadLine());

            //if ((x+y) / (u-v) >= 2)
            //{
            //    z = x - y;
            //    Console.WriteLine($"z=x-y， z={z}");
            //}
            //else
            //{
            //    z = u - v;
            //    Console.WriteLine($"z=u-v， z={z}");
            //}
            //Console.ReadKey();


            //p.74 2-5
            //double x, y, z;

            //Console.Write("輸入 x: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("輸入 y: ");
            //y = Convert.ToDouble(Console.ReadLine());            

            //if (x>=y)
            //{
            //    z = Math.Pow(x, 2);
            //    Console.WriteLine($"z = x^2， z={z}");
            //}
            //else
            //{
            //    z = Math.Pow(y, 2);
            //    Console.WriteLine($"z = y^2， z={z}");
            //}
            //Console.ReadKey();


            //p.79 2-6
            //double income, rate, difference, tax;
            //Console.WriteLine("輸入 income: ");
            //income = Convert.ToDouble(Console.ReadLine());
            //if (income > 4090000)
            //{
            //    rate = 0.4;
            //    difference = 721100;
            //}
            //else if (income > 2180000)
            //{
            //    rate = 0.3;
            //    difference = 312100;
            //}
            //else if (income > 1090000)
            //{
            //    rate = 0.21;
            //    difference = 115900;
            //}
            //else if (income > 410000)
            //{
            //    rate = 0.13;
            //    difference = 28700;
            //}
            //else
            //{
            //    rate = 0.06;
            //    difference = 0;
            //}

            //tax = (income * rate) - difference;
            //Console.WriteLine($"tax = {tax}");


            //p.81
            //int x, y;
            //Console.Write("輸入x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("輸入y:");
            //y = Convert.ToInt32(Console.ReadLine());

            //if (x > 0)
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("1st quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("4st quadrant\n");
            //    }
            //}
            //else if (x == 0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Origin\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Y-axis\n");
            //    }
            //}
            //else
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("2st quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3st quadrant\n");
            //    }
            //}
            //Console.ReadKey();








            //p.83
            //int qty, score;
            //Console.Write("輸入題數:");
            //qty = Convert.ToInt32(Console.ReadLine());

            //if (qty >= 0 && qty <= 10)
            //{
            //    score = 6 * qty;
            //}
            //else if (qty >=11 && qty <=20)
            //{
            //    score = 6 * 10 + (qty - 10) * 2;
            //}
            //else if (qty >= 21 && qty <= 40)
            //{
            //    score = 6 * 10 + 10 * 2 + (qty- 20);
            //}else
            //{
            //    score = 100;
            //}

            //Console.WriteLine($"答對{qty}題，分數: {score}");
            //Console.ReadKey();


            //p.85 BMI
            //double height, weight, BMI;
            //Console.Write("輸入身高(cm):");
            //height = (Convert.ToDouble(Console.ReadLine())) / 100;
            //Console.Write("輸入體重(kg):");
            //weight = Convert.ToDouble(Console.ReadLine());
            //BMI = weight / Math.Pow(height, 2);

            //if (BMI < 18.5)
            //{
            //    Console.WriteLine($"BMI: {BMI} ， 過輕");
            //}
            //else if (BMI >= 18.5 && BMI < 24)
            //{
            //    Console.WriteLine($"BMI: {BMI} ， 正常");
            //}
            //else if (BMI >= 24 && BMI < 27 )
            //{
            //    Console.WriteLine($"BMI: {BMI} ，過重");
            //}
            //else if (BMI >= 27 && BMI < 30)
            //{
            //    Console.WriteLine($"BMI: {BMI} ，輕度肥胖");
            //}
            //else if (BMI >= 30 && BMI < 35)
            //{
            //    Console.WriteLine($"BMI: {BMI} ，中度肥胖");
            //}
            //else
            //{
            //    Console.WriteLine($"BMI: {BMI} ，重度肥胖");
            //}

            //Console.ReadKey();


            //p.85 -2 (not finish?) *對照ppt檔，確認 此版本是否是完成版
            //double x, y, z;
            //Console.Write("x: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y: ");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.Write("z: ");
            //z = Convert.ToDouble(Console.ReadLine());


            //if (x > y)
            //{
            //    if (y > z)
            //    {
            //        Console.WriteLine($"{x}>{y}>{z}, x>y>z");
            //    }
            //    else if (y == z)
            //    {
            //        Console.WriteLine($"{x}>{y}={z}, x>y=z");
            //    }
            //    else
            //    {
            //        if (x > z)
            //        {
            //            Console.WriteLine($"{x}>{z}>{y}, x>z>y");
            //        }
            //        else if(x == z)
            //        {
            //            Console.WriteLine($"{x}={z}>{y}, x=z>y");
            //        }else
            //        {
            //            Console.WriteLine($"{z}>{x}>{y}, z>x>y");
            //        }
            //    }
            //}
            //else if (x == y)
            //{
            //    if (y > z)
            //    {
            //        Console.WriteLine($"{x}={y}>{z}, x=y>z");
            //    }
            //    else if(y == z)
            //    {
            //        Console.WriteLine($"{x}={y}={z}, x=y=z");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{z}>{y}={x}, z>y=x");
            //    }
            //}
            //else
            //{
            //    if (x > z)
            //    {
            //        Console.WriteLine($"{y}>{x}>{z}, y>x>z");
            //    }
            //    else if (x == z)
            //    {
            //        Console.WriteLine($"{y}>{x}={z}, y>x=z");
            //    }
            //    else
            //    {
            //        if(y > z)
            //        {
            //            Console.WriteLine($"{y}>{z}>{x}, y>z>x");
            //        }
            //        else if(y==z)
            //        {
            //            Console.WriteLine($"{y}={z}>{x}, y=z>x");
            //        }else
            //        {
            //            Console.WriteLine($"{z}>{y}>{x}, z>y>x");
            //        }

            //    }
            //}
            //Console.ReadKey();




            //p.85-3

            double hthousand = 100000;
            double bonus = 0;
            Console.Write("輸入利潤: ");
            double profit = Convert.ToDouble(Console.ReadLine());

            if (profit < hthousand)
            {
                bonus = profit * 0.1;
            }
            else if (profit >= hthousand && profit < hthousand * 2)
            {
                bonus = hthousand * 0.1 + (profit - hthousand) * 0.075;
            }
            else if (profit >= hthousand * 2 && profit < hthousand * 4)
            {
                bonus = hthousand * 0.1 + hthousand * 0.075 + (profit - hthousand * 2) * 0.05;
            }
            else if (profit >= hthousand * 4 && profit < hthousand * 6)
            {
                bonus = hthousand * 0.1 + hthousand * 0.075 + (hthousand * 2) * 0.05 + (profit - hthousand * 4) * 0.03;
            }
            else if (profit >= hthousand * 6 && profit < hthousand * 10)
            {
                bonus = hthousand * 0.1 + hthousand * 0.075 + (hthousand * 2) * 0.05 + (hthousand * 2) * 0.03 + (profit - hthousand * 6) * 0.015;
            }
            else
            {
                bonus = hthousand * 0.1 + hthousand * 0.075 + (hthousand * 2) * 0.05 + (hthousand * 2) * 0.03 + (hthousand * 4) * 0.015 + (profit - hthousand * 10) * 0.01;
            }

            Console.WriteLine($"獎金: {bonus}");
            Console.ReadKey();


            //test
            //string a = "sHort";
            //bool ans = IsUpper(string "sHort", int 3);










        }
    }
}

