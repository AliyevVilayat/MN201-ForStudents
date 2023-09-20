namespace Lab_W_Students_09_20_2023;

public static class Solutions
{
    //1.Simple or Complex number
    public static int  GetSimpleNumbersCount(int range)
    {
        int counter = 0;
        int countOfSimpleNum = 0;

        //5   2,3,4
        for (int j= 2; j < range; j++)
        {
            counter = 0;

            for (int i = 2; i < j; i++)
            {
                if (j % i == 0)
                {
                    counter++;
                }
            }
            
            if(counter==0)
            {
                countOfSimpleNum++;
            }

        }

        return countOfSimpleNum;
    }



    //2. Verilmiş tam ədədin neçə mərtəbəsi olduğunu tapın. (Məs: input 253 - output 3 mərtəbəlidir).
    #region DigitsOfNumber

    public static int GetDigitsCountOfNumber(int num)
    {
        int numCopy = num;
        int counter = default;

        num = GetModul(num);

        while (num > 0)
        {
            num = num / 10;
            counter++;
        }

        return counter;
    }

    private static int GetModul(int num)
    {
        if (num < 0)
        {
            num *= -1;
        }
        return num;
    }

    #endregion

}
