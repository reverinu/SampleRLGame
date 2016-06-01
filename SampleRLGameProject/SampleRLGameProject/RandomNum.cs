using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RandomNum
{
    private static RandomNum randomNum = new RandomNum();
    private Random rnd = new Random();

    private RandomNum()
    {

    }
    public static RandomNum GetInstanse()
    {
        return randomNum;
    }

    public int GetRandomNum()
    {
        return rnd.Next(0, 4);
    }
}
