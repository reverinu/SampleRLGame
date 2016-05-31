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

    
    public override int Get(int MAXX, int MAXY)
    {
        return y * MAXY + x;
    }

    public override string GetName()
    {
        return "player";
    }

    public override void Move(string str, Dungeon dungeon)
    {
        if (str == "w")
        {
            y--;
            
            if (y < 0)
            {
                y = 0;
            }
            if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)) != null)
            {
                if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)).GetName() != "enemy")
                {
                    y++;
                }
            }
        }
        else if (str == "s")
        {
            y++;
            
            if (y > Dungeon.MAXY - 1)
            {
                y = Dungeon.MAXY - 1;
            }
            if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)) != null)
            {
                if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)).GetName() != "enemy")
                {
                    y--;
                }
            }
            
        }
        else if (str == "a")
        {
            x--;
            if (x < 0)
            {
                x = 0;
            }
            if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)) != null)
            {
                if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)).GetName() != "enemy")
                {
                    x++;
                }
            }
            
        }
        else if (str == "d")
        {
            x++;
            if (x > Dungeon.MAXX - 1)
            {
                x = Dungeon.MAXX - 1;
            }
            if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)) != null)
            {
                if (dungeon.GetData(Get(Dungeon.MAXX, Dungeon.MAXY)).GetName() != "enemy")
                {
                    x--;
                }
            }
        }
    }
}

