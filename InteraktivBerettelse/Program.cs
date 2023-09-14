
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
bool inIRummet = false;
bool merInfoKropp = false;
bool ljuga = false;
string svar = "";
string svar1 = "";
string svar11 = "";
string johan1 = "";
string johan11 = "";
string ded = "\nDu är död, \ntryck på ENTER för att start om";
int vilketrum = 1;
bool notBeenHereRum = true;
bool notBeenHereGåIn = true;
bool notBeenHereKolla = true;
bool notBeenHereVarg = true;
bool notBeenHereUt = true;
bool notBeenHereLjuga = true;
bool notBeenHereLeta = true;
bool notBeenHerePlankorna = true;
bool notBeenHereBokhyllan = true;


Start();

void Start()
{
    Rum();


    //Svar 1

    if (svar == "1")
    {
        GåInIRummet();

        if (svar1 == "1")
        {
            KollaKropp();

            if (svar11 == "1")
            {
                Varg();
            }

            else if (svar11 == "2")
            {
                SnackJohan();
            }
            else
            {
                DuGjortFel();
            }


        }
        if (svar1 == "2")
        {
            Varg();
        }

        else if (svar1 == "3")
        {
            SnackJohan();
        }
        else
        {
            DuGjortFel();
        }
    }



    else if (svar == "2")
    {
        SnackJohan();
    }
    else
    {
        DuGjortFel();

    }
}


//Snacka med Johan
void SnackJohan()
{
    UtUrRummet();

    if (ljuga == true)
    {
        LjugaOmRummet();

        if (johan1 == "1")
        {
            LetaGrejer();

            if (johan11 == "1")
            {
                Plankorna();
            }


            else if (johan11 == "2")
            {
                Bokhyllan();
            }
            else
            {
                DuGjortFel();
            }

        }

        if (johan1 == "2")
        {
            Console.WriteLine("Du följer med honnom in i rummet. Han ser den stora vargen och går bakom den. Du står vid huvudet av hunder så när han petar på den vaknar den och äter dig." + ded);
            Console.ReadLine();
            Dead();
        }

    }
    if (ljuga == false && inIRummet == false)
    {
        Console.WriteLine("\nDu berättar att du inte gick in i rummet, men att du kände lukten av blod och rekomenderar att inte gå in. Han litar på dig och ni går ut ur rummet.");
        Console.WriteLine("Du fick \"Bäst att inte veta\" Endingen. Clicka på ENTER för att försöka igen");
        Console.ReadLine();
        Dead();
    }
    if (ljuga == false && inIRummet == true)
    {
        Console.WriteLine("\nDu berättar vad du såg. Om kroppen, Vargen och att han inte borde gå in. Han tror på dig och bestämmer sig att inte gå in. Efter det du såg och han fick höra bestämde ni er för att sätta en soffa för hålet och glömma bort det ni såg.");
        Console.WriteLine("Du fick \"Vi såg inget\" Endingen. Clicka på ENTER för att försöka igen");
        Console.ReadLine();
        Dead();
    }
}

Console.ReadLine();


//Du gjort fel
void DuGjortFel()
{
    Console.WriteLine("Ogiltigt svar. Clicka på ENTER för att försöka igen");
    Console.ReadLine();
    Start();
}

//Convertar text till bool
void ljugaToBool()
{
    string ljugaText = Console.ReadLine();

    if (ljugaText == "1")
    {
        ljuga = false;
    }

    else if (ljugaText == "2")
    {
        ljuga = true;
    }
    else
    {
        DuGjortFel();
    }
}

//Alla voids

void Rum()
{
    if (notBeenHereRum == true || vilketrum == 1)
    {
        vilketrum = 1;
        Console.WriteLine("\nDu kollar in och ser ett litet mörkt rum. Väggarna runt dig är gjorda av stora stenblock och känns nästan klibbiga.\nLukten av blod fyller dina näsborrar när du kryper dig igeom den lilla ingången till rummet.");
        Console.WriteLine("1. Kolla runt \n2. Gå tillbaka");
        svar = Console.ReadLine();
    }
    notBeenHereRum = false;
}

void GåInIRummet()
{
    if (notBeenHereGåIn == true || vilketrum == 2)
    {
        vilketrum = 2;
        Console.WriteLine("\nDu kollar runt i rummet och ser en blodig kropp ligande emot väggen åt höger. Den verkar livlös och uppriven i flera delar. Köttet på kroppen verkar vara avrivet och flera delar av skeletter syns igenom. Längre bort i rummet synns en stor varg. Den har blod runt munnen och tassarna.");
        inIRummet = true;
        Console.WriteLine("1. Gå och kolla in kroppen\n2. Kolla på vargen\n3. Gå tillbaka");
        svar1 = Console.ReadLine();
    }
    notBeenHereGåIn = false;
}

void KollaKropp()
{
    if (notBeenHereKolla == true || vilketrum == 3)
    {
        vilketrum = 3;
        Console.WriteLine("\nDu ser kroppen. den e cool");
        merInfoKropp = true;
        Console.WriteLine("1. Kolla på vargen\n2. Gå tillbaka");
        svar11 = Console.ReadLine();
    }
    notBeenHereKolla = false;

}
void Varg()
{
    if (notBeenHereVarg == true || vilketrum == 4)
    {
        Console.WriteLine("\nDu går mot vargen som ligger på golvet. Men medans gå går närmare så ser du den snabbt öppna sina ögon. \nDen stirrar på dig. \nHan ställer sig upp och går mot dig. På en sekund så blir allt svart.\nDu är död.\nKlicka på ENTER för att starta om");
        Console.ReadLine();
        vilketrum = 1;
        Dead();
    }
    notBeenHereVarg = false;
}

//Snack med johan

void UtUrRummet()
{
    if (notBeenHereUt == true || vilketrum == 5)
    {
        vilketrum = 5;
        Console.WriteLine("\nDu kryper ut ur rummet och när du vänder dig om så står Johan bakom dig.\nHan frågar, \n-Vad såg du där inne?");
        Console.WriteLine("1. Säg vad som hände\n2. Ljug om vad som hände ");
        notBeenHereUt = false;
        ljugaToBool();
    }

}

void LjugaOmRummet()
{
    if (notBeenHereLjuga == true || vilketrum == 6)
    {
        vilketrum = 6;
        Console.WriteLine("\nDu berättar att du såg ett tomt rum. Inget konstigt alls. Du uppmanar honnom att gå först eftersom att han har lampan. Han litar på dig och går in i rummet.");
        Console.WriteLine("1.Stäng till hålet.\n2.Gå in efter honnom");
        johan1 = Console.ReadLine();
        notBeenHereLjuga = false;
    }
}

void LetaGrejer()
{
    if (notBeenHereLeta == true || vilketrum == 7)
    {
        vilketrum = 7;
        Console.WriteLine("\nDu letar runt i rummer för grejer att täcka det relativt stora hålet. Du hittar en bokhylla och en stor träbit. Träbiten verkar väldigt lätt och skulle behöva att du håller emot ifall att han försöker rymma. Bokhyllan verkar dock väldigt tung och kanske inte går att flytta på så kort tid.");
        Console.WriteLine("1. Du väljer Träplankorna\n2. Du väljer bokhyllan");
        johan11 = Console.ReadLine();
        notBeenHereLeta = false;
    }

}

void Plankorna()
{
    if (notBeenHerePlankorna == true || vilketrum == 8)
    {
        vilketrum = 1;
        Console.WriteLine("\nDu tar upp plankorna men snubblar! Plankorna tappas och studsar på marken. Dem studsar perfekt för att träffa ditt rövhål. Som att gud var den som bestämde ditt öde så går dem upp i röven och dör." + ded);
        Console.ReadLine();
        notBeenHerePlankorna = false;
        Dead();
    }

}

void Bokhyllan()
{
    if (notBeenHereBokhyllan == true || vilketrum == 9)
    {
        vilketrum = 1;
        Console.WriteLine("Bokhyllan är vädligt stor och tung. MEN DU ÄR TYNGRE!!! Du plockar upp bokhyllan med ditt lilfinger och sätter ner den framför hålet. efter 2 sekunder så hör du vargen ryta. Johan skriker i smärta. ljudet av hans ben som släpas mot golver komma närmare och närmare. Tillslut hör du honom. han bankar hårt mot den stora bokhyllan. Du står och lysnar på någon som du kallade kompis sakta bli uppäten av vargen. Du må ha överlevt, men du vet vad du gjorde. Jag vet vad du gjorde.\n Klicka på ENTER för att starta om ");
        Console.WriteLine("Du fick \"Jag vet vad du gjorde...\" Endingen. Clicka på ENTER för att försöka igen");
        Console.ReadLine();
        notBeenHereBokhyllan = false;
        Dead();
    }
}

void Dead()
{
    inIRummet = false;
    merInfoKropp = false;
    ljuga = false;
    svar = "";
    svar1 = "";
    svar11 = "";
    johan1 = "";
    johan11 = "";
    vilketrum = 1;
    notBeenHereRum = true;
    notBeenHereGåIn = true;
    notBeenHereKolla = true;
    notBeenHereVarg = true;
    notBeenHereUt = true;
    notBeenHereLjuga = true;
    notBeenHereLeta = true;
    notBeenHerePlankorna = true;
    notBeenHereBokhyllan = true;
    Start();
}
