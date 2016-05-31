using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        Dungeon dungeon = new Dungeon();
        Player player = new Player();
        player.x = 0;
        player.y = 0;

        Enemy enemy = new Enemy();
        enemy.x = 4;
        enemy.y = 4;
        
        while (true)
        {
            dungeon.SetData(player);
            dungeon.SetData(enemy);

            dungeon.DrawField();

            dungeon.RemoveData(player);
            string str = Console.ReadLine();
            if (str == "q")
            {
                break;
            }
            else
            {
                player.Move(str, dungeon);
            }

            

        }
        
    }
}
