/// Class: CS155
/// Author: Manju Mehta
/// Due Date: 11/30/15
/// Homework 12 - Student Class
/// Approach: Create setters, getters and all the mthods to compute values
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW12_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inp = File.OpenText("E:\\Student.txt");
            // student class wrapped in another class
            StudentPack pack = new StudentPack();
            // read till end of file
            String line;
            while ((line = inp.ReadLine()) != null)
            {
                // data is separated by space
                String[] data = line.Split(' ');
                // convert string to int
                int score = int.Parse(data[2]);
                // file is in order firstname lastname score
                Student s = new Student(score, data[0], data[1]);
                pack.addStudent(s);

            }
            // printing in the console
            Console.WriteLine("\nMedian is {0}: ", pack.getMedianScore());
            Console.WriteLine("\nHighScore is {0}: ", pack.getHighScore());
            Console.WriteLine("\nLowscore is {0}: ", pack.getLowScore());
            Console.WriteLine("\nAverage Score is: {0}", pack.getAverageScore());

            // writing to a file
            StreamWriter file = new StreamWriter("E:\\StudentStat", true);
            
                file.WriteLine("\nMedian is {0}: ", pack.getMedianScore());
                file.WriteLine("\nHighScore is {0}: ", pack.getHighScore());
                file.WriteLine("\nLowscore is {0}: ", pack.getLowScore());
                file.WriteLine("\nAverage Score is: {0}", pack.getAverageScore());
            
            inp.Close(); // close file
            file.Close();
            // Console.WriteLine(pack);
            Console.ReadLine();
        }

    }

    public class Student : IComparable<Student>
    // public class Student
    {
        private int score;
        private String firstName;
        private String lastName;

        // auto corected this code
        public Student(int s, String f, String l)
        {
            this.score = s;
            this.firstName = f;
            this.lastName = l;
        }

        public int getScore()
        {
            return this.score;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public String getLastName()
        {
            return this.lastName;
        }

        public void setScore(int s)
        {
            this.score = s;
        }

        public void setFirstName(String f)
        {
            this.firstName = f;
        }

        public void setLastName(String l)
        {
            this.lastName = l;
        }

        public int CompareTo(Student other)
        {
            if (this.score == other.getScore()) return 0;
            if (this.score > other.getScore()) return 1;
            return -1;
        }

    }

    // All the methods and StudentPack class

    class StudentPack
    {
        private List<Student> students;

        public StudentPack()
        {
            this.students = new List<Student>();
        }


        public void addStudent(Student s)
        {
            this.students.Add(s);
        }

        public double getMedianScore()
        {
            // logic to get median to be added
            return 0.0;
        }

        public double getAverageScore()
        {
            int count = 0; int sum = 0;
            foreach (Student s in this.students)
            {
                sum += s.getScore();
                count++;
            }
            if (this.students.Count > 0)
            {
                double average = sum / count;
                return average;
            }
            else return 0;
        }

    public int getHighScore()
        {
            int len = 1;    
            this.students.Sort();
            len = this.students.Count;
            return this.students.ElementAt<Student>(len-1).getScore();
        } 

        public int getLowScore()
        {
            this.students.Sort();
            return this.students.ElementAt<Student>(0).getScore();
        }

        public override string ToString()
        {
            string returnstring = "";
            
            foreach (Student s in this.students)
            {
                returnstring += s.getFirstName() + "  " + s.getLastName();
                
            }
            return returnstring;
        }
    }
}
