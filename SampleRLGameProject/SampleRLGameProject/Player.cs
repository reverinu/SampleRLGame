using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player : Character
{
    public int hp = 30;
    public Player()
    {
        name = GetName();
    }

    public override string GetName()
    {
        return "player";
    }

    public Direction GetDirection(string str)
    {
        Direction direction = Direction.None;
        switch (str)
        {
            case "w":
                direction = Direction.Up;
                break;
            case "s":
                direction = Direction.Down;
                break;
            case "a":
                direction = Direction.Left;
                break;
            case "d":
                direction = Direction.Right;
                break;
        }
        return direction;
    }
}

