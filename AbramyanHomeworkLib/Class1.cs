using System;

namespace AbramyanHomeworkLib
{
    public class Class1
    {
        public static int ReadInteger()
        {
            return Int32.Parse(Console.ReadLine());
        }
        public static int[] For4(int price)
        {
            int[] answer = new int[10];
            for (int i = 0; i < 10; i++)
            {
                answer[i] = i * price;
            }
            return answer;
        }
        public static long For8(int A, int B)
        {
            long answer = A;
            for (int i = A + 1; i <= B; i++)
            {
                answer *= i;
            }
            return answer;
        }
        public static double For12(int N)
        {
            double answer = 1.1;
            for (double i = answer + 0.1; i < N / 10; i+=0.1)
            {
                answer *= i;
            }
            return answer;
        }
        public static int[] For16(double A, int N)
        {
            int[] FirstAnswer = new int[N];
            int AnsCounter = 0;
            for (int i = 1; i <= N; i++)
            {
                double x = Math.Pow(A, i);
                if (x % 1 == 0)
                {
                    FirstAnswer[AnsCounter] = Convert.ToInt32(x);
                    AnsCounter++;
                } 
            }
            int[] TrueAnswer = new int[AnsCounter];
            for (int i = 0; i < AnsCounter; i++)
            {
                TrueAnswer[i] = FirstAnswer[i];
            }
            return TrueAnswer;
        }
        public static decimal For20(int N)
        {
            decimal Answer = 0;
            for (int i = 1; i <= N; i++)
            {
                Answer += Factorial(i);
            }
            return Answer;
        }
        public static decimal Factorial(int x)
        {
            decimal factorial = 1;
            for (int i = 2; i <= x; i++)
            {
                factorial *= i;
            }
            return factorial;
        } 
        public static decimal For24(decimal X, int N)
        {
            decimal Answer = X;
            for (int i = 2; i <= N - 2; i+=4)
            {
                Answer -= decimal.Divide(DecPow(X, i), Factorial(i));
                Answer += decimal.Divide(DecPow(X, i + 1), Factorial(i + 2));
            }
            return Answer;
        }
        public static decimal DecPow(decimal d1, int i)
        {
            return Convert.ToDecimal(Math.Pow(Convert.ToDouble(d1), i));
        }
    }
}
