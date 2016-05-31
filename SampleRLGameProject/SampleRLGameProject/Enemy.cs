using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Enemy : Character
{
    public Enemy()
    {
        name = GetName();
    }
    
    public override int Get(int MAXX, int MAXY)
    {
        return y * MAXY + x;
    }

    public override string GetName()
    {
        return "enemy";
    }
}
