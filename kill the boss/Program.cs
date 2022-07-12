float pl = 100;
float bl = 100;

float pacc = 1;
float game = 1;

while ( game == 1)
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
    float paccv = 1;
    while (paccv == 1)
    {
        try
        {
            pacc = float.Parse(Console.ReadLine());
            paccv = 0;
        }
        catch
        {
            paccv = 1;
        }
    }
    
    switch (pacc)
    {
        case 0:
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
                case 11:
                    com = ("Se le ha sumado " + 100 + " puntos de vida al boss");
                    bl = bl + 100;
                    break;
                case 12:
                    com = ("Se le ha restado " + 50 + " puntos de vida al jugador");
                    pl = pl - 50;
                    break;
                case 13:
                    com = ("Se le ha restado " + 50 + " puntos de vida al boss");
                    bl = bl - 50;
                    break;
            }
            break;
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

    Console.Clear();
    Console.WriteLine(com);
    Console.WriteLine(bcom);
    Console.WriteLine("=============");

    if (bl <= 0)
    {
        Console.WriteLine("=============");
        Console.WriteLine("Kill The Boss");
        Console.WriteLine("=============");
        Console.WriteLine("Player Life: " + pl);
        Console.WriteLine("Boss Life: " + bl);
        Console.WriteLine("=============");
        Console.WriteLine("El Boss ha sido derrotado");

        game = 0;
    }
    if (pl <= 0)
    {
        Console.WriteLine("=============");
        Console.WriteLine("Kill The Boss");
        Console.WriteLine("=============");
        Console.WriteLine("Player Life: " + pl);
        Console.WriteLine("Boss Life: " + bl);
        Console.WriteLine("=============");
        Console.WriteLine("Has muerto");
        game = 0;
    }
    else
    {

    }
}
