using System;
public class Test

{

    public static void WalkonAxis(int T, List<int> N)

    {
        List<int> resultList =new List<int>();
      
        foreach (var item in N)
        {
        
              int result =item;
            for (int i = 0; i <= item; i++)
            {
                result+= i;
                
            }
           resultList.Add(result);
        }
        Console.WriteLine("=========================");
        foreach (var item in resultList)
        {
            Console.WriteLine(item);
        }

    }

    public static void Main()

    {
        List<int> N = new List<int>();

        int T = 0;

        T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            N.Add(int.Parse(Console.ReadLine()));
        }

        WalkonAxis(T, N);

    }

}