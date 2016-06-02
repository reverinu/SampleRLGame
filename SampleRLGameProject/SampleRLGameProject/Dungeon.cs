using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dungeon
{
    private int MAXX = 0;
    private int MAXY = 0;
    ObjectBase[] data;
    
    // コンストラクタ
    public Dungeon(int x, int y)
    {
        MAXX = x;
        MAXY = y;
        data = new ObjectBase[MAXX * MAXY];
    }

    public void SetData(ObjectBase obj)
    {
        data[obj.Get()] = obj;
    }

    public ObjectBase GetData(int pos)
    {
        return data[pos];
    }

    public void RemoveData(ObjectBase obj)
    {
        data[obj.Get()] = null;
    }

    public bool IsVacancyInFront(Character.Direction direction, int x, int y)
    {
        switch (direction)
        {
            case Character.Direction.Up:
                --y;
                break;
            case Character.Direction.Down:
                ++y;
                break;
            case Character.Direction.Left:
                --x;
                break;
            case Character.Direction.Right:
                ++x;
                break;
        }
        if (y < 0 || y > MAXY - 1 || x < 0 || x > MAXX - 1)
        {
            return false;
        }
        return true;
    }
    public void DrawField()
    {
        for (int y = 0; y < MAXY; ++y)
        {
            for (int x = 0; x < MAXX; ++x)
            {
                if (data[y * MAXX + x] == null)
                {
                    Console.Write("□");
                }
                else if (data[y * MAXX + x].name == "player")
                {
                    Console.Write("●");
                }
                else if (data[y * MAXX + x].name == "enemy")
                {
                    Console.Write("▲");
                }
                else if (data[y * MAXX + x].name == "goal")
                {
                    Console.Write("■");
                }
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}
