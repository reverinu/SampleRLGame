using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dungeon
{
    public static readonly int MAXX = 5;
    public static readonly int MAXY = 5;

    ObjectBase[] data;


    // コンストラクタ
    public Dungeon()
    {
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


    public void DrawField()
    {
        for (int y = 0; y < MAXY; y++)
        {
            for (int x = 0; x < MAXX; x++)
            {
                if (data[y * MAXY + x] == null)
                {
                    Console.Write("□");
                }
                else if (data[y * MAXY + x].name == "player")
                {
                    Console.Write("●");
                }
                else if (data[y * MAXY + x].name == "enemy")
                {
                    Console.Write("▲");
                }
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}
