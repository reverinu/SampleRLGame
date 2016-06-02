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
    
    public override string GetName()
    {
        return "enemy";
    }

    public  Direction GetDirection()
    {
        Direction direction = Direction.None;
        RandomNum rnd = RandomNum.GetInstanse();
        int r = rnd.GetRandomNum();
        switch (r)
        {
            case 0:
                direction = Direction.Up;
                break;
            case 1:
                direction = Direction.Down;
                break;
            case 2:
                direction = Direction.Right;
                break;
            case 3:
                direction = Direction.Left;
                break;
        }

        return direction;
    }
}
