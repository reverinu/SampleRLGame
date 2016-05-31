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
        dungeon.SetData(player);
        dungeon.SetData(enemy);
        while (true)
        {
            
            dungeon.DrawField();
            
            string str = Console.ReadLine();
            if (str == "q")
            {
                break;
            }
            else
            {
                //dungeon.RemoveData(player);
                //dungeon.RemoveData(enemy);
                player.logic.Move(player, str, dungeon);
                
                enemy.logic.Move(enemy, str, dungeon);
            }
        }
        
    }
}
