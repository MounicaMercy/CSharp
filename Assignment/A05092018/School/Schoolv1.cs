using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05092018.School
{
        class Student1
        {
            public int roll_no, grade;
            public string name;
        }
        class Schoolv1
        {
            static void Main(string[] args)
            {
                int[] count = new int[12];
                int decide, i;
                Student1[] students = new Student1[1000];
                //student name,roll no and grade
                for (i = 0; i <= students.Length; i++)
                {

                    students[i] = new Student1();
                    //reading roll no and name
                    Console.Write("Enter Roll No:");
                    students[i].roll_no = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name of the student:");
                    students[i].name = Console.ReadLine();
                    start:
                    Console.Write("Enter the Grade of a Student:");
                    int G = int.Parse(Console.ReadLine());
                    if ((G <= 12) && (G != 0))
                    {
                        if (count[G - 1] > 21)
                        {
                            Console.WriteLine("In {0} grade,the seats are filled", G);
                            goto end;
                        }
                        else
                        {
                            students[i].grade = G;
                            count[G - 1]++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a grade which is in the range of 0-12 only!");
                        goto start;
                    }
                    
                    //exiting for loop of roll no,name and grade
                    Console.WriteLine("If you want to exit,press 1 else 0");
                    decide = int.Parse(Console.ReadLine());
                    if (decide == 1)
                    {
                        break;
                    }
                }
                end:
                Console.WriteLine("\n");
                Console.WriteLine("Grade \t\t Count");
                for (i = 0; i < 12; i++)
                {
                    Console.WriteLine("Grades of {0}\t\t{1}", i + 1, count[i]);
                }
                Console.Read();
            }
        }
    }




