using System;
public class Test

{

    public static void Name(int T, List<string> nameList)

    {
        List<string> result = new List<string>();
        string M = "";
        string W = "";

        for (int i = 0; i < nameList.Count; i++)
        {

            M = nameList[i].Split(" ")[0];
            W = nameList[i].Split(" ")[1];

            if (M.Length >= W.Length)
            {
                string tempResult = "";
                for (int j = 0; j < W.Length; j++)
                {

                    if (M.Contains(W[j]) != true)
                    {
                        tempResult = "No";
                        break;
                    }
                }
                if (tempResult != "No")
                {
                    result.Add("Yes");
                }
                else
                {
                    result.Add("No");
                }
            }

            else if (W.Length > M.Length)
            {
                string tempResult = "";
                for (int j = 0; j < M.Length; j++)
                {
                    if (W.Contains(M[j]) != true)
                    {
                        tempResult = "No";
                        break;
                    }
                }
                if (tempResult != "No")
                {
                    result.Add("Yes");
                }
                else
                {
                    result.Add("No");
                }
            }

        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

    }



    public static void Main()

    {

        List<string> nameList = new List<string>();
        int T = 0;

        T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            nameList.Add(Console.ReadLine());

        }

        Name(T, nameList);

    }

}