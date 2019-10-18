using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myadventure2 : MonoBehaviour
{
    private enum States
    {
        menu,
        start,
        dood1,
        dood2,
        doodRooster,
        keuze1,
        keuze2,
        keuze3,
        keuzeRaam,
        keuzeBos,
        keuzeWeg,
        keuzeAuto,
        keuzeLopen,
        keuzePolitie,
        keuzeVertel,
    }
    private States currentState = States.menu;

    void Start()
    {
        menu();
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.menu:
                if (input == "start")
                {
                    start();
                }
                else if (input == "info")
                {
                    keuze2();
                }
                
                else
                {
                    menu();
                }
                break;

            case States.start:
                if (input == "stil")
                {
                    keuze1();
                }
                else if (input == "HELP")
                {
                    dood1();
                }
                else
                {
                    start();
                }
                break;

            case States.keuze1:
                if (input == "ren")
                {
                    dood2();
                }
                else if (input == "zoek")
                {
                    keuze3();
                }
                else
                {
                    keuze1();
                }
                break;

            case States.keuze2:
                if (input == "start")
                {
                    start();
                }
                else if (input == "terug")
                {
                    menu();
                }
                else
                {
                    keuze2();
                }
                break;

            case States.dood1:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    dood1();
                }
                break;

            case States.dood2:
                if (input == "terug")
                {
                    menu();
                }
                else
                {
                    dood2();
                }
                break;

            case States.keuze3:
                if (input == "raam")
                {
                    keuzeRaam();
                }
                else if (input == "rooster")
                {
                    doodRooster();
                }
                else
                {
                    keuze3();
                }
                break;

            case States.doodRooster:
                if (input == "terug")
                {
                    menu();
                }
                break;

            case States.keuzeRaam:
                if (input == "weg")
                {
                    keuzeWeg();
                }
                else if (input == "bos")
                {
                    keuzeBos();
                }
                break;

            case States.keuzeWeg:
                if (input == "auto")
                {
                    keuzeAuto();
                }
                else if (input == "lopen")
                {
                    keuzeLopen();
                }
                break;

            case States.keuzeBos:
                if (input == "terug")
                {
                    menu();
                }
                break;

                case States.keuzePolitie:
                if (input == "menu")
                {
                    menu();
                }
                break;

                case States.keuzeLopen:
                if(input == "menu")
                {
                    menu();
                }
                break;

                case States.keuzeAuto:
                if (input == "politie")
                {
                    keuzePolitie();
                }
                else if (input == "vertel")
                {
                    keuzeVertel();
                }
                break;

                case States.keuzeVertel:
                if (input == "menu")
                {
                    menu();
                }
                break;

        }
    }


    void menu()
    {
        currentState = States.menu;
        Terminal.ClearScreen();
        Terminal.WriteLine("welkom bij de ontvoering");
        Terminal.WriteLine("type start om te beginnen");
        Terminal.WriteLine("type info voor het verhaal");
    }

    void start()
    {
        currentState = States.start;
        Terminal.ClearScreen();
        Terminal.WriteLine("je zit in een donkere kamer");
        Terminal.WriteLine("je weet niet waar je bent");
        Terminal.WriteLine("type HELP om hulp te roepen");
        Terminal.WriteLine("type stil om geen geluid te maken");
    }
    void keuze1()
    {
        currentState = States.keuze1;
        Terminal.ClearScreen();
        Terminal.WriteLine("gelukkig bleef je stil");
        Terminal.WriteLine("de kidnappers hebben niks door");
        Terminal.WriteLine("type ren om weg te rennen");
        Terminal.WriteLine("type zoek voor een veilige vluchtroute");
    }

    void dood1()
    {
        currentState = States.dood1;
        Terminal.ClearScreen();
        Terminal.WriteLine("de kidnappers hoorde je");
        Terminal.WriteLine("je bent dood");
        Terminal.WriteLine("type terug");
    }

    void keuze2()
    {
        currentState = States.keuze2;
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent onvoerd door");
        Terminal.WriteLine("een paar kidnappers");
        Terminal.WriteLine("maak de juiste keuzes om");
        Terminal.WriteLine("het te overleven!");
        Terminal.WriteLine("type start om te beginnen");
        Terminal.WriteLine("type terug om terug te gaan");
    }

    void dood2()
    {
        currentState = States.dood2;
        Terminal.ClearScreen();
        Terminal.WriteLine("de kidnappers zagen je weg rennen");
        Terminal.WriteLine("je bent dood");
        Terminal.WriteLine("type terug om opnieuw te beginnen");
    }

    void keuze3()
    {
        currentState = States.keuze3;
        Terminal.ClearScreen();
        Terminal.WriteLine("je ziet een raam");
        Terminal.WriteLine("en je ziet een ventilatierooster.");
        Terminal.WriteLine("type raam om door het raam te gaan");
        Terminal.WriteLine("type rooster om door de ventilatie");
        Terminal.WriteLine("te gaan");

    }



    void keuzeRaam()
    {
        currentState = States.keuzeRaam;
        Terminal.ClearScreen();
        Terminal.WriteLine("je gaat door het raam");
        Terminal.WriteLine("nu sta je buiten en zie");
        Terminal.WriteLine("je een bos en een openbare weg");
        Terminal.WriteLine("type bos om het bos in te gaan");
        Terminal.WriteLine("type weg om langs de weg te lopen");
    }

    void doodRooster()
    {
        currentState = States.doodRooster;
        Terminal.ClearScreen();
        Terminal.WriteLine("je gaat de ventilatie in");
        Terminal.WriteLine("je blijft vastzitten");
        Terminal.WriteLine("je bent nu dood");
        Terminal.WriteLine("type terug om opnieuw te beginnen");

    }

    void keuzeBos()
    {
        currentState = States.keuzeBos;
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent in het bos,");
        Terminal.WriteLine("je bent verdwaalt.");
        Terminal.WriteLine("je bent nu dood.");
        Terminal.WriteLine("type terug om opnieuw te beginnen");
    }

    void keuzeWeg()
    {
        currentState = States.keuzeWeg;
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent bij de weg beland,");
        Terminal.WriteLine("er rijdt iemand langs.");
        Terminal.WriteLine("type auto om in de mee te rijden.");
        Terminal.WriteLine("type lopen om verder te lopen.");
    }

    void keuzeAuto()
    {
        currentState = States.keuzeAuto;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je zit in de auto,");
        Terminal.WriteLine("de man vraagt wat er is gebeurd.");
        Terminal.WriteLine("type vertel om alles te vertellen.");
        Terminal.WriteLine("type politie om direct naar de politie te gaan.");
    }

    void keuzeLopen()
    {
        currentState = States.keuzeLopen;
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt verder omdat je");
        Terminal.WriteLine("niemand vertrouwd");
        Terminal.WriteLine("even later rijdt er een busje langs.");
        Terminal.WriteLine("het blijken de kidnappers te zijn.");
        Terminal.WriteLine("ze slaan je in elkaar");
        Terminal.WriteLine("je bent dood");
        Terminal.WriteLine("type terug om terug te gaan");
        Terminal.WriteLine("naar het menu");
    }

    void keuzePolitie()
    {
        currentState = States.keuzePolitie;
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent aangekomen bij de politie,");
        Terminal.WriteLine("je verteld wat er is gebeurd");
        Terminal.WriteLine("de politie heeft de kidnappers opgepakt");
        Terminal.WriteLine("je bent veilig!");
        Terminal.WriteLine("type menu om terug te gaan");
        Terminal.WriteLine("naar het menu");
    }

    void keuzeVertel()
    {
        currentState = States.keuzeVertel;
        Terminal.ClearScreen();
        Terminal.WriteLine("je verteld aan de man wat er is gebeurd");
        Terminal.WriteLine("je vraagt of hij je naar");
        Terminal.WriteLine("wilt brengen");
        Terminal.WriteLine("de kidnappers wachten je op thuis");
        Terminal.WriteLine("ze slaan je in elkaar");
        Terminal.WriteLine("je bent nu dood");
        Terminal.WriteLine("type menu om naar het menu te gaan");
    }

}
