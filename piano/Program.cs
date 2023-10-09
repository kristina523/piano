using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static Array Octave()
        {

            int[] Octave1 = { 1, 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
            int[] Octave2 = { 2, 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
            int[] Octave3 = { 3, 1046, 1108, 1174, 1244, 1318, 1396, 1480, 1568, 1661, 1720, 1864, 1975 };
            int[] Octave4 = { 4, 2093, 2217, 2394, 2489, 2637, 2793, 2960, 3136, 3332, 3440, 3729, 3951 };
            int[] Octave5 = { 5, 4186, 4434, 4698, 4978, 5274 };
            bool inIsCorrect = false;

            do
            {
                {
                    Console.WriteLine("Введите вашу актаву\nF1-1 Октава(12 нот)\nF2-2 Октава(12 нот)\nF3-3 Октава(12 нот)\nF4-4 Октава(12 нот)\nF5-5 Октава(5 нот)\nF9-Меню пользователя\nEscape-Закрыть программу");

                    var octave = Console.ReadKey();
                    Console.Clear();

                    if (octave.Key == ConsoleKey.F1 || octave.Key == ConsoleKey.F2 || octave.Key == ConsoleKey.F3 || octave.Key == ConsoleKey.F4 || octave.Key == ConsoleKey.F5 || octave.Key == ConsoleKey.F9 || octave.Key == ConsoleKey.Escape)
                    {

                        if (octave.Key == ConsoleKey.F1)
                        {
                            PlayOctave(Octave1);

                            return Octave1;

                        }

                        if (octave.Key == ConsoleKey.F2)
                        {

                            PlayOctave(Octave2);

                            return Octave2;
                        }

                        if (octave.Key == ConsoleKey.F3)
                        {
                            PlayOctave(Octave3);

                            return Octave3;
                        }

                        if (octave.Key == ConsoleKey.F4)
                        {
                            PlayOctave(Octave4);

                            return Octave4;
                        }

                        if (octave.Key == ConsoleKey.F5)
                        {
                            PlayOctave(Octave5);

                            return Octave5;

                        }

                        if (octave.Key == ConsoleKey.F9)
                        {
                            Console.WriteLine("До-A\nДо_Диез-S\nРе-D\nРе_Диез-F\nMи-G\nФа-H\nФа_Диез-J\nCоль-K\nСоль_Диез-L\nЛя-;\nСи_Бемоль-''\nСи-Enter\nНажмите 'escape' для выхода...");
                            do
                            {
                                octave = Console.ReadKey();
                            } while (octave.Key != ConsoleKey.Escape);
                            Console.Clear();

                        }

                        if (octave.Key == ConsoleKey.Escape)
                        {
                            break;
                        }


                    }

                    else
                    {
                        Console.WriteLine("такой выбора  нет");

                    }
                }

            } while (!inIsCorrect);
            return Octave1;
        }

        static void PlayOctave(int[] octave)
        {

            Console.WriteLine("Для выхода к выбору октавы нажмите 'escape'\nНомер октавы-" + octave[0]);

            while (true)
            {

                var note = Console.ReadKey();

                if (octave.Length > 6)
                {
                    if (note.Key == ConsoleKey.A)
                    {
                        Console.Beep(octave[1], 300);

                    }

                    if (note.Key == ConsoleKey.S)
                    {
                        Console.Beep(octave[2], 300);
                    }

                    if (note.Key == ConsoleKey.D)
                    {
                        Console.Beep(octave[3], 300);
                    }

                    if (note.Key == ConsoleKey.F)
                    {
                        Console.Beep(octave[4], 300);
                    }

                    if (note.Key == ConsoleKey.G)
                    {
                        Console.Beep(octave[5], 300);
                    }

                    if (note.Key == ConsoleKey.H)
                    {
                        Console.Beep(octave[6], 300);
                    }

                    if (note.Key == ConsoleKey.J)
                    {
                        Console.Beep(octave[7], 300);
                    }

                    if (note.Key == ConsoleKey.K)
                    {
                        Console.Beep(octave[8], 300);
                    }

                    if (note.Key == ConsoleKey.L)
                    {
                        Console.Beep(octave[9], 300);
                    }

                    if (note.Key == ConsoleKey.Oem1)
                    {
                        Console.Beep(octave[10], 300);
                    }

                    if (note.Key == ConsoleKey.Oem7)
                    {
                        Console.Beep(octave[11], 300);
                    }

                    if (note.Key == ConsoleKey.Enter)
                    {
                        Console.Beep(octave[12], 300);
                    }

                    if (note.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Octave();
                    }
                }
                else
                {
                    if (note.Key == ConsoleKey.A)
                    {
                        Console.Beep(octave[1], 300);

                    }

                    if (note.Key == ConsoleKey.S)
                    {
                        Console.Beep(octave[2], 300);
                    }

                    if (note.Key == ConsoleKey.D)
                    {
                        Console.Beep(octave[3], 300);
                    }

                    if (note.Key == ConsoleKey.F)
                    {
                        Console.Beep(octave[4], 300);
                    }

                    if (note.Key == ConsoleKey.G)
                    {
                        Console.Beep(octave[5], 300);
                    }

                    if (note.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Octave();
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            Octave();
        }
    }
}


