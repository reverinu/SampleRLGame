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
    
    public override int Get()
    {
        return y * Dungeon.MAXY + x;
    }

    public override string GetName()
    {
        return "enemy";
    }

    public  Direction GetDirection()
    {
        Direction direction = Direction.None;
        Random rnd = new Random();
        switch (rnd.Next(0, 4))
        {
            case 0:
                direction = Direction.Up;
                break;
            case 1:
                direction = Direction.Down;
                break;
            case 2:
                direction = Direction.Left;
                break;
            case 3:
                direction = Direction.Right;
                break;
        }

        return direction;
    }
}
