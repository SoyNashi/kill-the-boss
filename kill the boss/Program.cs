﻿float plr = 0;
float blr = 0;
float pl = 100;
float bl = 100;
/*
float pacc = 1;
float game = 1;
*/
/*
while (game == 1)
{
    string com = "no hay comentario para esta accion";
    string bcom = "no hay comentario para la accion del bos";
    Random rnd = new Random();
    float action = rnd.Next(1, 4);

    float pacc1 = rnd.Next(1, 51);
    float pacc2 = rnd.Next(1, 51);
    float pacc3 = rnd.Next(0, 14);
    float ba = rnd.Next(0, 70);

    Console.WriteLine("Kill The Boss");
    Console.WriteLine("=============");
    Console.WriteLine("Player Life: " + pl);
    Console.WriteLine("Boss Life: " + bl);
    Console.WriteLine("=============");
    Console.WriteLine("1- Normal atack, 2- Heal, 3- Open chest");
}
*/
float pacc = 1;
float game = 1;
int pacc1min = 1;
int pacc1max = 51;
int pacc2min = 1;
int pacc2max = 51;
int bamin = 0;
int bamax = 60;
int case0 = 50;
float super = 0;
string supername = "0- Super atack, ";
float kills = 0;
float killst = 0;
float case4 = 0;
#pragma warning disable CS0219 // La variable está asignada pero nunca se usa su valor
float bosshand = 0;
#pragma warning restore CS0219 // La variable está asignada pero nunca se usa su valor
Random rnd = new Random();
float bossspawn = rnd.Next(5, 20);
// float bossspawn = 1;
float xp = 100;
float xpgain = 100;
float xpshop = 1;

while ( game == 1)
{
    supername = "";
    string com = "no hay comentario para esta accion";
    string bcom = "no hay comentario para la accion del boss";
    float action = rnd.Next(1, 4);
    float pacc1 = rnd.Next(pacc1min, pacc1max);
    float pacc2 = rnd.Next(pacc2min, pacc2max);
    float pacc3 = rnd.Next(0, 12);
    xpgain = rnd.Next(50, 125);
    float ba = rnd.Next(bamin, bamax);
    if (super >= 4)
    {
        supername = "0- Super atack, ";
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Kill The Boss");
    Console.WriteLine("=============");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Player Life: " + pl);
    Console.WriteLine("Boss Life: " + bl);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=============");
    Console.WriteLine("Bosses derrotados: " + kills);
    // Console.WriteLine("Bosses derrotados temporales: " + killst);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(supername + "1- Normal atack, 2- Heal, 3- Open chest, 5- Mejoras");
    float paccv = 1;
    while (paccv == 1)
    {
        try
        {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            pacc = float.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            paccv = 0;
        }
        catch
        {
            paccv = 1;
        }
    }
    if (pacc == 5)
    {
        xpshop = 1;
        while (xpshop == 1)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kill The Boss - Upgrades Shop");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("XP: " + xp);
            // Console.WriteLine("Boss Life: " + bl);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============");
            // Console.WriteLine("Bosses derrotados: " + kills);
            // Console.WriteLine("Bosses derrotados temporales: " + killst);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1- Mejorar ataque (300xp), 2- Mejorar curaciom (300xp), 3- Mejorar salud (500xp), 4- salir");
            float xpsh = 3;
            float paccvaxp = 1;
            while (paccvaxp == 1)
            {
                try
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    xpsh = float.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                    paccvaxp = 0;
                }
                catch
                {
                    paccvaxp = 1;
                }
            }
            switch (xpsh)
            {
                case 1:
                    if (xp >= 300)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ataque mejorada por 300XP a cambio de +10 en la media.");
                        pacc1min = pacc1min + 10;
                        pacc1max = pacc1max + 10;
                        xp = xp - 300;
                    }
                    break;
                case 3:
                    if (xp >= 500)
                    {
                        xp = xp - 500;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vida mejorada por 500XP a cambio de +20 de vida.");
                        plr = plr + 20;
                        pl = pl + plr;
                    }
                    break;
                case 2:
                    if (xp >= 300)
                    {
                        xp = xp - 300;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Curacion mejorada por 300XP a cambio de +10 en la media.");
                        pacc2min = pacc2min + 10;
                        pacc2max = pacc2max + 10;
                    }
                    break;
                case 4:
                    xpshop = 0;
                    Console.Clear();
                    break;
            }
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Kill The Boss");
        Console.WriteLine("=============");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Player Life: " + pl);
        Console.WriteLine("Boss Life: " + bl);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=============");
        Console.WriteLine("Bosses derrotados: " + kills);
        // Console.WriteLine("Bosses derrotados temporales: " + killst);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(supername + "1- Normal atack, 2- Heal, 3- Open chest");
        float paccva = 1;
        while (paccva == 1)
        {
            try
            {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                pacc = float.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                paccva = 0;
            }
            catch
            {
                paccva = 1;
            }
        }
    }

    switch (pacc)
    {
        case 0:
            if (super >= 4)
            {
                super = 0;
                bl = bl - (pacc1 + case0);

                com = ("Has atacado con el daño siguiente: " + (pacc1 + case0));
            }
            else
            {
                bl = bl - pacc1;
                com = ("Has atacado con el daño siguiente: " + pacc1);
            }
            break;
        case 1:
            bl = bl - pacc1;
            com = ("Has atacado con el daño siguiente: " + pacc1);
            break;
        case 2:
            com = ("Te has curado estos puntos de vida: " + pacc2);
            pl = pl + pacc2;
            break;
        case 3:
            switch (pacc3)
            {
                case 0:
                    com = ("Se le ha sumado " + pacc2 + " puntos de vida al jugador");
                    pl = pl + pacc2;
                    break;
                case 1:
                    com = ("Se le ha sumado " + pacc2 + " puntos de vida al boss");
                    bl = bl + pacc2;
                    break;
                case 2:
                    com = ("Se le ha restado " + pacc2 + " puntos de vida al jugador");
                    pl = pl - pacc2;
                    break;
                case 3:
                    com = ("Se le ha restado " + pacc2 + " puntos de vida al boss");
                    bl = bl - pacc2;
                    break;
                case 4:
                    com = ("Se le ha restado " + pacc1 + " puntos de vida al boss");
                    bl = bl - pacc1;
                    break;
                case 5:
                    com = ("Se le ha restado " + pacc1 + " puntos de vida al jugador");
                    pl = pl - pacc1;
                    break;
                case 6:
                    com = ("Se le ha sumado " + pacc1 + " puntos de vida al boss");
                    bl = bl + pacc1;
                    break;
                case 7:
                    com = ("Se le ha sumado " + pacc1 + " puntos de vida al jugador");
                    pl = pl + pacc1;
                    break;
                case 8:
                    com = ("Se le ha sumado " + 100 + " puntos de vida al jugador");
                    pl = pl + 100;
                    break;
                case 9:
                    com = ("Se le ha sumado " + 100 + " puntos de vida al boss");
                    bl = bl + 100;
                    break;
                case 10:
                    com = ("Se le ha restado " + 50 + " puntos de vida al jugador");
                    pl = pl - 50;
                    break;
                case 11:
                    com = ("Se le ha restado " + 50 + " puntos de vida al boss");
                    bl = bl - 50;
                    break;
            }
            break;
        /*
                case 4:
                    case4 = 1;
                    super = 0;
                    bl = bl - (pacc1 * 100);
                    com = ("Has atacado con el daño siguiente: " + (pacc1 * 100));
                    break;
        */
        /*
                default:
                    if (super >= 4)
                    {
                        super = 0;
                        bl = bl - (pacc1 + case0);

                        com = ("Has atacado con el daño siguiente: " + (pacc1 + case0));
                    }
                    else
                    {
                        bl = bl - pacc1;
                        com = ("Has atacado con el daño siguiente: " + pacc1);
                    }
                    break;
        */

    }

    switch (action)
    {
        case 1:
            bcom = ("El boss ha atacado al jugador: -" + pacc2);
            pl = pl - pacc2;
            break;
        case 2:
            bcom = ("El boss se ha curado: " + pacc1);
            bl = bl + pacc1;
            break;
        case 3:
            bcom = ("El boss ha atacado al jugador: -" + ba);
            pl = pl - ba;
            break;
       
    }
    if (killst == bossspawn)
    {
    //     bosshand = 1;
    // }
    // while (bosshand == 1)
    // {
        /*
        ProcessStartInfo startinfo = new ProcessStartInfo();
        startinfo.FileName = @"D:\\XX\\XX\\bin\\Debug\\XXX.exe";
        startinfo.CreateNoWindow = true;
        startinfo.UseShellExecute = true;
        Process myProcess = Process.Start(startinfo);
        myProcess.Start();
        */
        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
        // C:\Users\mrnil\source\repos\kill the boss\kill the boss\bin\Debug\net6.0\OtherBoses\OtherBoses\bin\Debug\net6.0
        pProcess.StartInfo.FileName = "Otherboss.bat";
        // pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
        pProcess.Start();
        pProcess.WaitForExit();
        pProcess.Close();
        killst = 0;
        bossspawn = rnd.Next(5, 20);
     //   bosshand = 0;
    }
    super = super + 1;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(com);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(bcom);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("=============");
    if (case4 == 1)
    {
        Console.WriteLine("(pacc1min, pacc1max)" + (pacc1min, pacc1max));
        Console.WriteLine("(pacc2min, pacc2max)" + (pacc2min, pacc2max));
        Console.WriteLine("(bamin, bamaz)" + (bamin, bamax));
        if (bl <= 0)
        {
            if (pl <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Kill The Boss");
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player Life: " + pl);
                Console.WriteLine("Boss Life: " + bl);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Has muerto");
                game = 0;
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Kill The Boss");
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player Life: " + pl);
                Console.WriteLine("Boss Life: " + bl);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El Boss ha sido derrotado");
                pacc1min = pacc1min + 10;
                pacc1max = pacc1max + 10;
                pacc2min = pacc2min + 10;
                pacc2max = pacc2max + 10;
                bamin = bamin + 10;
                bamax = bamax + 10;
                case0 = case0 + 10;
                plr = plr + 20;
                blr = blr + 20;
                kills++;
                killst++;
                xp = xp + xpgain;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("=============");
                Console.WriteLine("El Boss Ha Vuelto");
                Console.WriteLine("+10 mas fuerte!!");
                Console.WriteLine("Haver si sobrevives");
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vida del hugador restaurada");
                pl = 100;
                bl = 100;
                pl = pl + plr;
                Console.WriteLine("Vida del Boss Restaurada");
                bl = bl + blr;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============");
            }


        }

    }
    else
    {
        if (bl <= 0)
        {
            if (pl <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Kill The Boss");
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player Life: " + pl);
                Console.WriteLine("Boss Life: " + bl);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Has muerto");
                game = 0;
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Kill The Boss");
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Player Life: " + pl);
                Console.WriteLine("Boss Life: " + bl);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El Boss ha sido derrotado");
                pacc1min = pacc1min + 10;
                pacc1max = pacc1max + 10;
                pacc2min = pacc2min + 10;
                pacc2max = pacc2max + 10;
                bamin = bamin + 10;
                bamax = bamax + 10;
                case0 = case0 + 10;
                plr = plr + 20;
                blr = blr + 20;
                kills++;
                killst++; 
                xp = xp + xpgain;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("=============");
                Console.WriteLine("El Boss Ha Vuelto");
                Console.WriteLine("+10 mas fuerte!!");
                Console.WriteLine("Haver si sobrevives");
                Console.WriteLine("=============");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vida del hugador restaurada");
                pl = 100;
                bl = 100;
                pl = pl + plr;
                Console.WriteLine("Vida del Boss Restaurada");
                bl = bl + blr;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=============");
            }


        }


    }
    if (bl <= 0)
    {
        if (pl <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kill The Boss");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Player Life: " + pl);
            Console.WriteLine("Boss Life: " + bl);
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Has muerto");
            game = 0;
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Kill The Boss");
        Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Player Life: " + pl);
        Console.WriteLine("Boss Life: " + bl);
            Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("El Boss ha sido derrotado");
            pacc1min = pacc1min + 10;
            pacc1max = pacc1max + 10;
            pacc2min = pacc2min + 10;
            pacc2max = pacc2max + 10;
            bamin = bamin + 10;
            bamax = bamax + 10;
            case0 = case0 + 10;
            plr = plr + 20;
            blr = blr + 20;
            kills++;
            killst++;
            xp = xp + xpgain;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=============");
            Console.WriteLine("El Boss Ha Vuelto");
            Console.WriteLine("+10 mas fuerte!!");
            Console.WriteLine("Haver si sobrevives");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vida del hugador restaurada");
            pl = 100;
            bl = 100;
            pl = pl + plr;
            Console.WriteLine("Vida del Boss Restaurada");
            bl = bl + blr;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=============");
        }

        
    }
    if (pl <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Kill The Boss");
        Console.WriteLine("=============");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Player Life: " + pl);
        Console.WriteLine("Boss Life: " + bl);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=============");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Has muerto");
        game = 0;
    }
    else
    {

    }
}
