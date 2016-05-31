using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Logic
{
    public struct DIRECTION
    {
        public static readonly int UP = 0;
        public static readonly int DOWN = 1;
        public static readonly int LEFT = 2;
        public static readonly int RIGHT = 3;
    }
    public Logic()
    {

    }
    
    public void Move(ObjectBase obj, string str, Dungeon dungeon)
    {
        int direction = SetDirection(obj, str);

        if (IsVacancyInFront(obj.x, obj.y, direction, dungeon))
        {
            dungeon.RemoveData(obj);
            if (direction == DIRECTION.UP)
            {
                obj.y--;
            }
            else if (direction == DIRECTION.DOWN)
            {
                obj.y++;
            }
            else if (direction == DIRECTION.LEFT)
            {
                obj.x--;
            }
            else if (direction == DIRECTION.RIGHT)
            {
                obj.x++;
            }
            dungeon.SetData(obj);
        }
    }
    
    public bool IsVacancyInFront(int x, int y, int direction, Dungeon dungeon)
    {
        if (direction == DIRECTION.UP)
        {
            y--;
            if (y < 0)
            {
                return false;
            }
        }
        else if (direction == DIRECTION.DOWN)
        {
            y++;
            if (y > Dungeon.MAXY - 1)
            {
                return false;
            }
        }
        else if (direction == DIRECTION.LEFT)
        {
            x--;
            if (x < 0)
            {
                return false;
            }
        }
        else if (direction == DIRECTION.RIGHT)
        {
            x++;
            if (x > Dungeon.MAXX - 1)
            {
                return false;
            }
        }
        if (dungeon.GetData(y * Dungeon.MAXY + x) != null)
        {
            if (dungeon.GetData(y * Dungeon.MAXY + x).GetName() == "player" || dungeon.GetData(y * Dungeon.MAXY + x).GetName() == "enemy")
            {
                return false;
            }
        }
        return true;
    }

    public int SetDirection(ObjectBase obj, string str)
    {
        int direction = -1;
        if (obj.name == "player")
        {
            if (str == "w")
            {
                direction = DIRECTION.UP;
            }
            else if (str == "s")
            {
                direction = DIRECTION.DOWN;
            }
            else if (str == "a")
            {
                direction = DIRECTION.LEFT;
            }
            else if (str == "d")
            {
                direction = DIRECTION.RIGHT;
            }
        }
        else if (obj.name == "enemy")
        {
            Random rnd = new Random();
            direction = rnd.Next(0, 4);
        }
        return direction;
    }
}
