using System;
using System.Threading;

namespace Video_Game_Index
{
    class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void End()
        {
            Console.WriteLine("Error... ending index...");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        public static void Restart()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to find another game (Yes or No): ");
            string user_restart = Console.ReadLine();
            Console.WriteLine();
            Thread.Sleep(1000);

            if (user_restart == "Yes")
            {
                Console.WriteLine("Restarting index...");
                Console.WriteLine();
                Thread.Sleep(3000);
                Start();
            }

            else if (user_restart == "No")
            {
                Console.WriteLine("Ending index...");
                Console.WriteLine();
                Thread.Sleep(3000);
            }

            else
            {
                End();
            }
        }


        public static void Start()
        {
            Game skyrim = new Game("Skyrim", "Bestesda", "Action role-playing game", "Xbox, Playstation, PC, and Nintendo", 2011);
            Game skate_3 = new Game("Skate 3", "EA Sports", "Sports game", "Xbox and Playstation", 2010);
            Game halo_reach = new Game("Halo Reach", "Bungie", "First-person shooter game", "Xbox and PC", 2010);
            Game call_of_duty = new Game("Call of Duty", "Infinity Ward, Treyarch Studios, and Sledgehammer Games", "First-person shooter game", "Xbox, Playstation, PC, Android, and Apple", 2003);
            Game battlefield = new Game("Battlefield", "Dice", "First-person shooter game", "Xbox, Playstation, and PC", 2002);
            Game halo_wars = new Game("Halo wars", "Microsoft Studios and Ensemble Studios", "Real-time strategy game", "Xbox and PC", 2009);
            Game minecraft = new Game("Minecraft", "Mojang Studios", "Open-world Adventure game", "Xbox, Playstation, PC, Android, Apple, Nintendo", 2009);
            Game mario = new Game("Super Mario", "Nintendo", "Open-world Adventure game", "Nintendo, PC, Android, and Wii", 1985);

            Console.WriteLine();
            Console.WriteLine("Welcome to the Video Game Index, this is a program to help you find games that you'll love. KEEP IN MIND THIS INDEX IS CASE SENSITIVE WITH YOUR USER INPUT! ");
            Console.WriteLine();

            Console.WriteLine("What is a video game genre that you would be interested in (Action, Sports, Adventure, Strategy): ");
            string user_genre = Console.ReadLine();
            Console.WriteLine();

            if (user_genre == "Action")
            {
                Console.WriteLine("Choose what action games you would to learn more about (Skyrim, Call of Duty, Halo Reach, Battlefield): ");
                string user_action = Console.ReadLine();
                Console.WriteLine();

                if (user_action == "Skyrim")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + skyrim.name);
                    Console.WriteLine("Developer: " + skyrim.developer);
                    Console.WriteLine("Genre: " + skyrim.genre);
                    Console.WriteLine("Platforms: " + skyrim.platform);
                    Console.WriteLine("First Release Date: " + skyrim.release);
                    Restart();
                }

                else if (user_action == "Call of Duty")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + call_of_duty.name);
                    Console.WriteLine("Developer: " + call_of_duty.developer);
                    Console.WriteLine("Genre: " + call_of_duty.genre);
                    Console.WriteLine("Platforms: " + call_of_duty.platform);
                    Console.WriteLine("First Release Date: " + call_of_duty.release);
                    Restart();
                }

                else if (user_action == "Halo Reach")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + halo_reach.name);
                    Console.WriteLine("Developer: " + halo_reach.developer);
                    Console.WriteLine("Genre: " + halo_reach.genre);
                    Console.WriteLine("Platforms: " + halo_reach.platform);
                    Console.WriteLine("First Release Date: " + halo_reach.release);
                    Restart();
                }

                else if (user_action == "Battlefield")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + battlefield.name);
                    Console.WriteLine("Developer: " + battlefield.developer);
                    Console.WriteLine("Genre: " + battlefield.genre);
                    Console.WriteLine("Platforms: " + battlefield.platform);
                    Console.WriteLine("First Release Date: " + battlefield.release);
                    Restart();
                }

                else
                {
                    End();
                }
            }

            else if (user_genre == "Sports")
            {
                Console.WriteLine("Choose what sports games you would to learn more about (Skate 3): ");
                string user_sport = Console.ReadLine();
                Console.WriteLine();

                if (user_sport == "Skate 3")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + skate_3.name);
                    Console.WriteLine("Developer: " + skate_3.developer);
                    Console.WriteLine("Genre: " + skate_3.genre);
                    Console.WriteLine("Platforms: " + skate_3.platform);
                    Console.WriteLine("First Release Date: " + skate_3.release);
                    Restart();
                }

                else
                {
                    End();
                }
            }

            else if (user_genre == "Adventure")
            {
                Console.WriteLine("Choose what adventure games you would to learn more about (Skyrim, Minecraft, Mario): ");
                string user_adventure = Console.ReadLine();
                Console.WriteLine();

                if (user_adventure == "Skyrim")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + skyrim.name);
                    Console.WriteLine("Developer: " + skyrim.developer);
                    Console.WriteLine("Genre: " + skyrim.genre);
                    Console.WriteLine("Platforms: " + skyrim.platform);
                    Console.WriteLine("First Release Date: " + skyrim.release);
                    Restart();
                }

                else if (user_adventure == "Minecraft")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + minecraft.name);
                    Console.WriteLine("Developer: " + minecraft.developer);
                    Console.WriteLine("Genre: " + minecraft.genre);
                    Console.WriteLine("Platforms: " + minecraft.platform);
                    Console.WriteLine("First Release Date: " + minecraft.release);
                    Restart();
                }

                else if (user_adventure == "Mario")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + mario.name);
                    Console.WriteLine("Developer: " + mario.developer);
                    Console.WriteLine("Genre: " + mario.genre);
                    Console.WriteLine("Platforms: " + mario.platform);
                    Console.WriteLine("First Release Date: " + mario.release);
                    Restart();
                }

                else
                {
                    End();
                }
            }

            else if (user_genre == "Strategy")
            {
                Console.WriteLine("Choose what strategy games you would to learn more about (Halo Wars): ");
                string user_strategy = Console.ReadLine();
                Console.WriteLine();

                if (user_strategy == "Halo Wars")
                {
                    Console.WriteLine();
                    Console.WriteLine("Name: " + halo_wars.name);
                    Console.WriteLine("Developer: " + halo_wars.developer);
                    Console.WriteLine("Genre: " + halo_wars.genre);
                    Console.WriteLine("Platforms: " + halo_wars.platform);
                    Console.WriteLine("First Release Date: " + halo_wars.release);
                    Restart();
                }

                else
                {
                    End();
                }
            }

            else
            {
                Console.WriteLine("Error... Restarting perferred genre question...");
                Console.WriteLine();
                Thread.Sleep(5000);
                Start();
            }
        }
    }
}
