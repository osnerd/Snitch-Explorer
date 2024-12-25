using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EntryPoint(args);
        }

        static void EntryPoint(string[] args)
        {
            try
            {
                RunMenuLoop(args);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ResetColor();
            }
        }

        static void RunMenuLoop(string[] args)
        {
            while (true)
            {
                Banner();
                SnitchMenu();

                ConsoleKeyInfo choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        hiddenwikis(args);
                        break;
                    case ConsoleKey.D2:
                        btc(args);
                        break;
                    case ConsoleKey.D3:
                        drugs(args);
                        break;
                    case ConsoleKey.D4:
                        commercial(args);
                        break;
                    case ConsoleKey.D5:
                        elsee(args);
                        break;
                    case ConsoleKey.Q:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid choice. Press any key to try again...");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                }
            }
        }

        static void Banner()
        {
            Console.Clear();
            string[] banner = new string[] 
            {
                @"   ____     _ __      __              _   ",
                @"  / __/__  (_) /_____/ /   ___  ___  (_)__  ___ ",
                @" _\ \/ _ \/ / __/ __/ _ \_/ _ \/ _ \/ / _ \/ _ \",
                @"/___/_//_/_/\__/\__/_//_(_)___/_//_/_/\___/_//_/",
                @"",
                @"   The Only App U Need To Explore Deep Of The Internet"
            };

            ConsoleColor[] colors = new ConsoleColor[] 
            {
                ConsoleColor.Red,
                ConsoleColor.Yellow,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Blue,
                ConsoleColor.Magenta
            };

            foreach (var line in banner)
            {
                PrintWithColorFade(line, colors);
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        static void SnitchMenu()
        {
            Console.Clear();
            Banner();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║               Snitch.tor                 ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" [1] -> Hidden Wikis          [2] -> Bitcoin Anonymity");
            Console.WriteLine(" [3] -> Drug Stores           [4] -> Commercials");
            Console.WriteLine(" [5] -> Everything Else       [Q] -> Quit");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine(" ╔════════════════════════════════════════╗");
            Console.WriteLine(" ║   Enter your choice and press Enter    ║");
            Console.WriteLine(" ╚════════════════════════════════════════╝");
            Console.ResetColor();
        }
        static void hiddenwikis(string[] args)
        {
            Console.Clear();
            Banner();

            string text = @"http://s4k4ceiapwwgcm3mkb6e4diqecpo7kvdnfr5gg7sph7jjppqkvwwqtyd.onion/ – OnionLinks v3
http://6nhmgdpnyoljh5uzr5kwlatx2u3diou4ldeommfxjz3wkhalzgjqxzqd.onion/ – The Hidden Wiki
http://2jwcnprqbugvyi6ok2h2h7u26qc6j5wxm7feh3znlh2qu3h6hjld4kyd.onion/ – Another Hidden Wiki
http://jgwe5cjqdbyvudjqskaajbfibfewew4pndx52dye7ug3mt3jimmktkid.onion/ – Pug’s Ultimate Dark Web Guide
http://zqktlwiuavvvqqt4ybvgvi7tyo4hjl5xgfuvpdf6otjiycgwqbym2qad.onion/wiki/index.php/Main_Page – The original hidden wiki";

            DisplayWithColor(text);

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void btc(string[] args)
        {
            Console.Clear();
            Banner();

            string text = @"http://y22arit74fqnnc2pbieq3wqqvkfub6gnlegx3cl6thclos4f7ya7rvad.onion/ – Dark Mixer – Anonymous bitcoin mixer
http://hqfld5smkr4b4xrjcco7zotvoqhuuoehjdvoin755iytmpk4sm7cbwad.onion/ – Mixabit – Bitcoin mixer
http://mp3fpv6xbrwka4skqliiifoizghfbjy5uyu77wwnfruwub5s4hly2oid.onion/ – EasyCoin – Bitcoin Wallet and Mixer
http://p2qzxkca42e3wccvqgby7jrcbzlf6g7pnkvybnau4szl5ykdydzmvbid.onion/ – Onionwallet – Anonymous and secure bitcoin wallet and mixer
http://ovai7wvp4yj6jl3wbzihypbq657vpape7lggrlah4pl34utwjrpetwid.onion/ – VirginBitcoins – Buy freshly mined clean bitcoins";

            DisplayWithColor(text);

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void drugs(string[] args)
        {
            Console.Clear();
            Banner();

            string text = @"http://wbz2lrxhw4dd7h5t2wnoczmcz5snjpym4pr7dzjmah4vi6yywn37bdyd.onion/ – DCdutchconnectionUK – The dutch connection for the UK
http://iwggpyxn6qv3b2twpwtyhi2sfvgnby2albbcotcysd5f7obrlwbdbkyd.onion/ – DrChronic – Weed straight from the source
http://rfyb5tlhiqtiavwhikdlvb3fumxgqwtg2naanxtiqibidqlox5vispqd.onion/ – TomAndJerry – Cocaine, Heroin, MDMA and LSD from NL
http://ajlu6mrc7lwulwakojrgvvtarotvkvxqosb4psxljgobjhureve4kdqd.onion/ – 420prime – Cannabis in dispensary quality from the UK
http://guzjgkpodzshso2nohspxijzk5jgoaxzqioa7vzy6qdmwpz3hq4mwfid.onion/ – Bitpharma – Biggest european .onion drug store
http://n6qisfgjauj365pxccpr5vizmtb5iavqaug7m7e4ewkxuygk5iim6yyd.onion/ – EuCanna – First Class Cannabis
http://kl4gp72mdxp3uelicjjslqnpomqfr5cbdd3wzo5klo3rjlqjtzhaymqd.onion/ – Smokeables – Finest organic cannabis from the USA
http://7mejofwihleuugda5kfnr7tupvfbaqntjqnfxc4hwmozlcmj2cey3hqd.onion/ – CannabisUK – UK wholesale cannabis supplier
http://2ln3x7ru6psileh7il7jot2ufhol4o7nd54z663xonnnmmku4dgkx3ad.onion/ – Brainmagic – Best Darkweb psychedelics
http://usmost4cbpesx552s2s4ti3c4nk2xgiu763vhcs3b4uc4ppp3zwnscyd.onion/ – NLGrowers – Coffee Shop grade Cannabis from the Netherlands
http://xf2gry25d3tyxkiu2xlvczd3q7jl6yyhtpodevjugnxia2u665asozad.onion/ – Peoples Drug Store – The Darkwebs best Drug supplier!
http://sga5n7zx6qjty7uwvkxpwstyoh73shst6mx3okouv53uks7ks47msayd.onion/ – DeDope – German Weed Store";

            DisplayWithColor(text);

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void commercial(string[] args)
        {
            Console.Clear();
            Banner();

            string text = @"http://prjd5pmbug2cnfs67s3y65ods27vamswdaw2lnwf45ys3pjl55h2gwqd.onion/ – Dark Web Hackers for hire
http://55niksbd22qqaedkw36qw4cpofmbxdtbwonxam7ov2ga62zqbhgty3yd.onion/ – AccMarket – Premium Paypal, Ebay and bank accounts
http://s57divisqlcjtsyutxjz2ww77vlbwpxgodtijcsrgsuts4js5hnxkhqd.onion/ – Cardshop – USA CVV KNOWN BALANCE & Worldwide CC & CVV
http://jbtb75gqlr57qurikzy2bxxjftzkmanynesmoxbzzcp7qf5t46u7ekqd.onion/ – Darkmining – Bitcoin mining with stolen electricity
http://jhi4v5rjly75ggha26cu2eey7thq3uwjxrjfh57x34cd5wslkyl4hweyd.onion/ – HackingTech – Hacking, programming, development and dark web services
http://yx7rswb65pmauhg7rlgogvh9tkvrx37e3bvcvqexkthewiokvm3wdvqd.onion/ – Investbox – Invest in onion related services, and start your Dark Web Business
http://76nkw2je7qemphxzzdhvwfnsljqnvs6mkydqmt2sbgaqsh6jbwtfrvqd.onion/ – Spycammarket – Buy high definition spy cameras
http://zoduzjpvvlmy7khfo4cduirh7y6ae7dzktmjtwp2lrf4wqpb7r3wpkqd.onion/ – ExploitHub – Exploits, Malware and RCE scripts";

            DisplayWithColor(text);

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void elsee(string[] args)
        {
            Console.Clear();
            Banner();

            string text = @"http://bpaowqdhlfgdjfrzy34tvxvvxwexfbpdsdpqfc5x7wumemrkcczzjmqd.onion/ – Secure drop box for confidential information
http://7kfjgkjqxrsnmizodgljoz45rxvsjo7auzq67m7cxppdrz25gwsmlyqd.onion/ – Leak0r – Information leak site for the curious
http://6ozhflzss7gxbt7l3j27xxylg36oycgnv4blhrkb6ekfjsjo5lyzppjd.onion/ – Freedrop – Drop information securely without identifying yourself
http://la2h4eosvqzqzzh6xiwv5rptal4n7lgqqhhvo77lwwf4mzh5vczkyhqd.onion/ – Bigfootfiles – Drop off your classified files
http://mntfn5m7rujn33p7c5vc7ch32hmkmvqv7hdtgggjlebgqu32kzqxnwgd.onion/ – Bunkers – Classified information vaults";
            DisplayWithColor(text);

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        static void DisplayWithColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void PrintWithColorFade(string text, ConsoleColor[] colors)
        {
            int colorIndex = 0;
            foreach (char c in text)
            {
                Console.ForegroundColor = colors[colorIndex];
                Console.Write(c);
                colorIndex = (colorIndex + 1) % colors.Length;
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
