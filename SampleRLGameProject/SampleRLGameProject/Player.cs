using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player : Character
{
    public Player()
    {
        name = GetName();
    }

    
    public override int Get()
    {
        return y * Dungeon.MAXY + x;
    }

    public override string GetName()
    {
        return "player";
    }
}

