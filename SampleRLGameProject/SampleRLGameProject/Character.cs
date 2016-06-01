using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character : ObjectBase
{
    public Character()
    {

    }
    public enum Direction : int
    {
        Up,
        Down,
        Right,
        Left,
        None,
    }

    public void Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                y--;
                break;
            case Direction.Down:
                y++;
                break;
            case Direction.Left:
                x--;
                break;
            case Direction.Right:
                x++;
                break;
        }
    }
}
