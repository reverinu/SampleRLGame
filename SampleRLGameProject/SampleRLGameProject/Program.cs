using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    private static readonly int MAXX = 10;
    private static readonly int MAXY = 10;
    static void Main(string[] args)
    {
        int score = 0;
        string inputKey = "";
        Dungeon dungeon = new Dungeon(MAXX, MAXY);
        Player player = new Player();
        player.Set(MAXX, MAXY);
        player.x = 0;
        player.y = 0;
        Enemy enemy1 = new Enemy();
        enemy1.Set(MAXX, MAXY);
        enemy1.x = 7;
        enemy1.y = 7;
        Enemy enemy2 = new Enemy();
        enemy2.Set(MAXX, MAXY);
        enemy2.x = 5;
        enemy2.y = 5;
        Enemy enemy3 = new Enemy();
        enemy3.Set(MAXX, MAXY);
        enemy3.x = 0;
        enemy3.y = 5;
        Enemy enemy4 = new Enemy();
        enemy4.Set(MAXX, MAXY);
        enemy4.x = 5;
        enemy4.y = 0;
        Enemy enemy5 = new Enemy();
        enemy5.Set(MAXX, MAXY);
        enemy5.x = 9;
        enemy5.y = 9;
        Goal goal = new Goal();
        goal.Set(MAXX, MAXY);
        goal.x = 9;
        goal.y = 9;
        dungeon.SetData(player);
        dungeon.SetData(enemy1);
        dungeon.SetData(enemy2);
        dungeon.SetData(enemy3);
        dungeon.SetData(enemy4);
        dungeon.SetData(goal);

        Console.WriteLine("ルール説明");
        Console.WriteLine("プレイヤー（●）をゴール（■）まで持って行けたらゲームクリア");
        Console.WriteLine("エネミー（▲）に当たったり、HPが0になったらゲームオーバー");
        Console.WriteLine("wasdキーでプレイヤー操作、qキーでゲーム終了");
        Console.WriteLine();
        Console.WriteLine("HP :" + player.hp);
        while (true)
        {
            dungeon.DrawField();

            if (player.x == goal.x && player.y == goal.y)
            {
                score += player.hp;
                Console.WriteLine("Game Clear!!!!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();

                dungeon.RemoveData(player);
                player.x = 0;
                player.y = 0;
                player.hp += 21;
                inputKey = "";
                dungeon.SetData(player);
            }
            else if (player.hp <= 0)
            {
                Console.WriteLine("Game Over!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();
                break;
            }
            else if (player.x == enemy1.x && player.y == enemy1.y)
            {
                Console.WriteLine("Game Over!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();
                break;
            }
            else if (player.x == enemy2.x && player.y == enemy2.y)
            {
                Console.WriteLine("Game Over!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();
                break;
            }
            else if (player.x == enemy3.x && player.y == enemy3.y)
            {
                Console.WriteLine("Game Over!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();
                break;
            }
            else if (player.x == enemy4.x && player.y == enemy4.y)
            {
                Console.WriteLine("Game Over!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();
                break;
            }
            else if (player.x == enemy5.x && player.y == enemy5.y)
            {
                Console.WriteLine("Game Over!!");
                Console.WriteLine("Your Score :" + score);
                string end = Console.ReadLine();
                break;
            }
            else
            {
                inputKey = Console.ReadLine();
            }
            if (inputKey == "q")
            {
                break;
            }
            else
            {
                if (dungeon.IsVacancyInFront(player.GetDirection(inputKey), player.x, player.y))
                {
                    --player.hp;
                    dungeon.RemoveData(player);
                    player.Move(player.GetDirection(inputKey));
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
                dir = enemy3.GetDirection();// Smartじゃない
                if (dungeon.IsVacancyInFront(dir, enemy3.x, enemy3.y))
                {
                    dungeon.RemoveData(enemy3);
                    enemy3.Move(dir);
                    dungeon.SetData(enemy3);
                }
                dir = enemy4.GetDirection();// Smartじゃない
                if (dungeon.IsVacancyInFront(dir, enemy4.x, enemy4.y))
                {
                    dungeon.RemoveData(enemy4);
                    enemy4.Move(dir);
                    dungeon.SetData(enemy4);
                }
                dir = enemy5.GetDirection();// Smartじゃない
                if (dungeon.IsVacancyInFront(dir, enemy5.x, enemy5.y))
                {
                    dungeon.RemoveData(enemy5);
                    enemy5.Move(dir);
                    dungeon.SetData(enemy5);
                }
            }
            Console.WriteLine("HP :" + player.hp);
            dungeon.SetData(goal);
        }
    }
}
