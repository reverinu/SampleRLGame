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
        Enemy enemy1 = new Enemy();
        enemy1.x = 4;
        enemy1.y = 4;
        Enemy enemy2 = new Enemy();
        enemy2.x = 3;
        enemy2.y = 3;
        dungeon.SetData(player);
        dungeon.SetData(enemy1);
        dungeon.SetData(enemy2);
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
                if (dungeon.IsVacancyInFront(player.GetDirection(str), player.x, player.y))
                {
                    dungeon.RemoveData(player);
                    player.Move(player.GetDirection(str));
                    dungeon.SetData(player);
                }
                Character.Direction dir = enemy1.GetDirection();// Smartじゃない
                if (dungeon.IsVacancyInFront(dir, enemy1.x, enemy1.y))
                {
                    dungeon.RemoveData(enemy1);
                    enemy1.Move(dir);
                    dungeon.SetData(enemy1);
                }
                dir = enemy2.GetDirection();// Smartじゃない
                if (dungeon.IsVacancyInFront(dir, enemy2.x, enemy2.y))
                {
                    dungeon.RemoveData(enemy2);
                    enemy2.Move(dir);
                    dungeon.SetData(enemy2);
                }
            }
        }
    }
}
