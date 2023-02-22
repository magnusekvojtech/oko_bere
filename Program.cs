using System;

namespace oko_bere
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write­Line("Vítejte v oko bere");

            Random nahodnaCisla = new Random();
            int kartyHrace = nahodnaCisla.Nex­t(0, 11);
            int kartyPC = nahodnaCisla.Nex­t(0, 11);

        DalsiKarta:
            Console.Write­Line("Chcete další kartu ? ano/ne Počet vašich karet je " + kartyHrace);
            String volba = Console.ReadLine();

            if (volba == "ano")
            {

                kartyHrace += nahodnaCisla.Nex­t(0, 11);

                if (kartyPC < 15)
                {
                    kartyPC += nahodnaCisla.Nex­t(0, 11);

                }
                goto DalsiKarta;
            }

            else if (volba == "ne")
            {
                if (kartyHrace <= 21 && (kartyPC > 21 || kartyPC < kartyHrace))
                {

                    Console.Write­Line("Vyhrál/a jste ! Počítač měl " + kartyPC + " bodů!. ");

                }

                else if (kartyHrace <= 21 && (kartyPC > 21 || kartyPC > kartyHrace))
                {

                    Console.Write­Line("Prohrál/a jste ! Počítač měl " + kartyPC + " bodů! ");

                }

                else if (kartyPC > 21 && kartyHrace > 21)
                {

                    Console.Write­Line("Oba hráči prohráli ! Počítač měl " + kartyPC + " bodů! ");

                }

                else if (kartyPC == kartyHrace)
                {

                    Console.Write­Line("REMÍZA ! ");

                }
                /*
                else if (kartyHrace >21)
                {

                Console.Write­Line("Přesáhl/a jste limit. Prohráváte ! ");

                }
                */
                Console.ReadKey();
            }
            else
            {
                Console.Write­Line("Zadej jen (ano/ne)!");
                goto DalsiKarta;
            }

        }.