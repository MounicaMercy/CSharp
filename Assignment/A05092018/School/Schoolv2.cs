using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05092018.School_v1
{
    class Student2
    {
        public int roll_no, grade;
        public string name;
        public int[] marks = new int[6];
        public float percentage;
        
    }
    class Subjects
    {
        public string SubjectName;
        public Student2 student;
        public int HighestMarks;
    }
    class Schoolv2
    {
        static Student2[] students = new Student2[1000];
        static Subjects[] sub = new Subjects[6];
        static void Main(string[] args)
        {
            int[] count = new int[12];
            int decide, i, j, k; 
            float total;
            Console.WriteLine("Enter Subject Names..\n");
            //reading subject names
            for ( k=0;k<sub.Length;k++)
            {
                sub[k] = new Subjects();
                Console.Write("Enter {0} Subject Name:",k+1);
                sub[k].SubjectName = Console.ReadLine();
                sub[k].student = new Student2();
             }
            //reading student name,roll no and grade
            Console.WriteLine("\n");
            for ( i = 0; i <= students.Length; i++)
            {
                students[i] = new Student2();
                //reading roll no and name
                Console.Write("Enter Roll No:");
                students[i].roll_no = int.Parse(Console.ReadLine());
                Console.Write("Enter Name of the student:");
                students[i].name = Console.ReadLine();
                start: //reading grade
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
                //reading marks and calculating total
                Console.WriteLine("\n");
                Console.WriteLine("Enter the marks of the student out of 100");
                total = 0f;
                    for ( j = 0; j <6; j++)
                    {
                        Console.Write("Enter {0} subject marks:", j +1);
                        students[i].marks[j] = Convert.ToInt32(Console.ReadLine());
                        total += students[i].marks[j];
                    }
                Console.WriteLine("Total={0}",total);
                //Getting highest marks with student name and the particular subject name
                if(i==0)
                {
                    for (int seq = 0; seq < 6; seq++)
                    {
                        sub[seq].student = students[i];
                        sub[seq].HighestMarks = students[i].marks[seq];
                    }
                }
                else
                {
                    GetStudent(students[i]);

                }
                //exiting for loop of roll no,name and grade
                Console.WriteLine("\n");
                Console.WriteLine("If you want to exit,press 1 else 0");
                decide = int.Parse(Console.ReadLine());
                if (decide == 1)
                {
                    break;
                }
                
            }
            end://printing grade and count of each grade
            Console.WriteLine("\n");
            Console.WriteLine("Grade \t\t Count");
            for ( i = 0; i < 12; i++)
            {
                Console.WriteLine("Grades of {0}\t\t{1}", i + 1, count[i]);
            }
            //printing subject name,student name and the highest marks
            Console.WriteLine("\n");
            Console.WriteLine("Subject Name\tStudent Name\tMarks");
            for(i=0;i<6;i++)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}",sub[i].SubjectName,sub[i].student.name,sub[i].HighestMarks);
            }
            Console.Read();
        }
        public static void GetStudent(Student2 student)
        {
            for(int i=0;i<sub.Length;i++)
            {
                if((sub[i].HighestMarks)<(student.marks[i]))
                {
                    sub[i].student = student;
                    sub[i].HighestMarks = student.marks[i];
                }
            }
        }
    }
}
  


