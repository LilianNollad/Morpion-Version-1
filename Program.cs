using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morpionV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            morpion();



        }
        static void morpion()
        {
            int cpt_morpions_0, cpt_morpions_1, cpt_morpions_2, cpt_morpions_3, cpt_morpions_4, cpt_morpions_5, cpt_morpions_6, cpt_morpions_7, cpt_morpions_8;
            cpt_morpions_0 = 0;
            cpt_morpions_1 = 0;
            cpt_morpions_2 = 0;
            cpt_morpions_3 = 0;
            cpt_morpions_4 = 0;
            cpt_morpions_5 = 0;
            cpt_morpions_6 = 0;
            cpt_morpions_7 = 0;
            cpt_morpions_8 = 0;


            int[] morp = new int[9];
            morp[0] = 2;
            morp[1] = 2;
            morp[2] = 2;
            morp[3] = 2;
            morp[4] = 2;
            morp[5] = 2;
            morp[6] = 2;
            morp[7] = 2;
            morp[8] = 2;
            string joueur1, joueur2; // definit joueur 1 et joueur 2 en tant que liste de caractère//
            int morpions; //definit morpions comme un entier//
            morpions = 10; // definit morpions comme égale a 10 //
            Console.WriteLine("indiquez le nom du joueur 1"); // demande le nom du joueur 1//
            joueur1 = Console.ReadLine();
            Console.WriteLine("indiquez le nom du joueur 2"); // demande le nom du joueur 2//
            joueur2 = Console.ReadLine();
            for (int i = 0; i < 8; i++) //definit le nombres de tours du morpions 
            {
                


                for (int y = 0; y < 2; y++) // definit si c'est le tour du joueur 1 (y = 0) ou du joueur 2 (y = 1)
                {

                    Console.WriteLine("0  1  2\n3  4  5\n6  7  8");

                    if (y == 0) // donne le nom du joueur qui joue est enregistre la ou le joueur 1  place sa croix //
                    {
                        Console.WriteLine("tour de  " + joueur1);
                        morpions = int.Parse(Console.ReadLine());


                    }
                    if (y == 1)// donne le nom du joueur qui joue est enregistre la ou le joueur 2  place sa croix// 
                    {
                        {
                            Console.WriteLine("tour de  " + joueur2);
                            morpions = int.Parse(Console.ReadLine());


                        }
                    }

                    if (morpions == 0 && y == 0)      // verfie si la case numéro 0 à été coché et quel joueur l'a coché  
                    {
                        cpt_morpions_0 += 1; // enregistre le nombre de fois ou cette case a été coché 
                        if (morp[morpions] != 0 && morp[morpions] != 1) // vérifie que la case n'a pas deja été coché par un autre joueur 
                        {

                            morp[morpions] = 0; // affiche un 0 sur la case 0 pour dire que le joueur 1 a coché la case 0
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");
                            // affiche le tableau acrualisé 






                        }
                    }

                    if (morpions == 0 && y == 1)     // verfie si la case numéro 0 à été coché et quel joueur l'a coché  
                    {
                        cpt_morpions_0 += 1; // enregistre le nombre de fois ou cette case a été coché
                        if (morp[morpions] != 0 && morp[morpions] != 1) // vérifie que la case n'a pas deja été coché par un autre joueur 
                        {

                            morp[morpions] = 1; // affiche un 1 sur la case 0 pour dire que le joueur 2 a coché la case 0
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");
                            // affiche le tableau acrualisé 


                        }
                    }
                    if (morpions == 1 && y == 0)   // verifie que la case numéro 1 a été coché et qui l'a coché         
                    {
                        cpt_morpions_1 += 1; // enregistre le nombre de fois ou cette case a été coché
                        if (morp[morpions] != 0 && morp[morpions] != 1) // vérifie que la case n'a pas deja été coché par un autre joueur 
                        {

                            morp[morpions] = 0;  // affiche un 0 sur la case 1 pour dire que le joueur 1a coché la case 1
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");
                            // affiche le tableau acrualisé 
                        }
                    }

                    if (morpions == 1 && y == 1) // verfie si la case numéro 1 à été coché et quel joueur l'a coché
                    {
                        cpt_morpions_1 += 1; // enregistre le nombre de fois ou cette case a été coché
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 2 && y == 0)
                    {
                        cpt_morpions_2 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;


                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");



                        }
                    }
                    if (morpions == 2 && y == 1)
                    {
                        cpt_morpions_2 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 3 && y == 0)
                    {
                        cpt_morpions_3 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");


                        }
                    }
                    if (morpions == 3 && y == 1)
                    {
                        cpt_morpions_3 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 4 && y == 0)
                    {
                        cpt_morpions_4 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 4 && y == 1)
                    {
                        cpt_morpions_4 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 5 && y == 0)
                    {
                        cpt_morpions_5 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 5 && y == 1)
                    {
                        cpt_morpions_5 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 6 && y == 0)
                    {
                        cpt_morpions_6 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 6 && y == 1)
                    {
                        cpt_morpions_6 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 7 && y == 0)
                    {
                        cpt_morpions_7 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 7 && y == 1)
                    {
                        cpt_morpions_7 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 8 && y == 0)
                    {
                        cpt_morpions_8 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 0;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                    if (morpions == 8 && y == 1)
                    {
                        cpt_morpions_8 += 1;
                        if (morp[morpions] != 0 && morp[morpions] != 1)
                        {

                            morp[morpions] = 1;
                            Console.Write(morp[0] + " " + morp[1] + " " + morp[2] + "\n" + morp[3] + " " + morp[4] + " " + morp[5] + "\n" + morp[6] + " " + morp[7] + " " + morp[8] + "\n\n");

                        }
                    }
                        if (morp[0] == 1 && morp[1] == 1 && morp[2] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[0] == 0 && morp[1] == 0 && morp[2] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                            break;
                        }
                        if (morp[3] == 1 && morp[4] == 1 && morp[5] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[3] == 0 && morp[4] == 0 && morp[5] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                            break;
                        }
                        if (morp[6] == 0 && morp[7] == 0 && morp[8] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                           break;
                        }
                        if (morp[6] == 1 && morp[7] == 1 && morp[8] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[0] == 0 && morp[3] == 0 && morp[6] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                            break;
                        }
                        if (morp[0] == 1 && morp[3] == 1 && morp[6] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[1] == 0 && morp[4] == 0 && morp[7] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                            break;
                        }
                        if (morp[1] == 1 && morp[4] == 1 && morp[7] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[2] == 0 && morp[5] == 0 && morp[8] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                            break;
                        }
                        if (morp[2] == 1 && morp[5] == 1 && morp[8] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[0] == 0 && morp[4] == 0 && morp[8] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur1 + " à gagné !");
                            break;
                        }
                        if (morp[0] == 1 && morp[4] == 1 && morp[8] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[6] == 1 && morp[4] == 1 && morp[2] == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if (morp[6] == 0 && morp[4] == 0 && morp[2] == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("le joueur " + joueur2 + " à gagné !");
                            break;
                        }
                        if(cpt_morpions_0 > 1)
                        {
                          Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                          cpt_morpions_0 = 1;
                          if (y == 0)
                          {
                            y = 1;
                          }
                          else
                          {
                            y = 0;
                          }
                        }
                        if (cpt_morpions_1 > 1)
                        {
                          Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                           cpt_morpions_1 = 1;
                           if (y == 0)
                           {
                             y = 1;
                           }
                           else
                           {
                             y = 0;
                           }


                        }
                        if (cpt_morpions_2> 1)
                        {
                          Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                          cpt_morpions_2 = 1;
                           if (y == 0)
                           {
                            y = 1;
                           }
                           else
                           {
                            y = 0;
                           }


                        }
                        if (cpt_morpions_3 > 1)
                        {
                          Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                          cpt_morpions_3 = 1;
                          if (y == 0)
                          {
                            y = 1;
                          }
                          else
                          {
                            y = 0;
                          }


                        }
                        if (cpt_morpions_4 > 1)
                        {
                          Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                          cpt_morpions_4 = 1;
                          if (y == 0)
                          {
                            y = 1;
                          }
                          else
                          {
                            y = 0;
                          }


                        }
                        if (cpt_morpions_5 > 1)
                        {
                           Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                           cpt_morpions_5 = 1;
                           if (y == 0)
                           {
                            y = 1;
                           }
                           else
                           {
                            y = 0;
                           }



                        }
                        if (cpt_morpions_6 > 1)
                        {
                          
                          Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                          cpt_morpions_6 = 1;
                           if (y == 0)
                           {
                             y = 1;
                           }
                           else
                           {
                            y = 0;
                           }


                        }
                        if (cpt_morpions_7 > 1)
                        {
                           Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                           cpt_morpions_7 = 1;
                           if (y == 0)
                           {
                            y = 1;
                           }
                           else
                           {
                            y = 0;
                           }


                        }
                        if (cpt_morpions_8 > 1)
                        {
                           Console.WriteLine("veuillez cocher une case qui n'est pas deja utilisé ");
                           cpt_morpions_8 = 1;
                           if (y == 0)
                           {
                            y = 1;
                           }
                           else
                           {
                            y = 0;
                           }


                        }
                        if (morpions > 8)
                        {
                          Console.WriteLine("veuillez choisir une case conforme");
                          if (y == 0)
                          {
                            y = 1;
                          }
                          else
                          {
                            y = 0;
                          }


                        }
                        if (morp[0] < 2 && morp[1] < 2 && morp[2] < 2 && morp[3] < 2 && morp[4] < 2 && morp[5] < 2 && morp[6] < 2 && morp[7] < 2 && morp[8] < 2)
                        {
                          Console.Clear();
                          Console.WriteLine(" Match Nul !!!!");
                          break;

                             
                                      
                        }








                }
            }
        }
    }
} 
