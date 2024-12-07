using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
namespace p4cs
{
    class Scratch
    {
        Dictionary<string, List<string>> classes = new Dictionary<string, List<string>>();
        static List<string> Form1 = new List<string>();
        static List<string> Form2 = new List<string>();
        static List<string> Form3 = new List<string>();
        static List<string> Form4 = new List<string>();
        static List<string> Form5 = new List<string>();
        static List<string> Form6 = new List<string>();
        static List<string> Form7 = new List<string>();
        static List<string> Form8 = new List<string>();
        public Scratch()
        {
            classes.Add("Form1", Form1);
            classes.Add("Form2", Form2);
            classes.Add("Form3", Form3);
            classes.Add("Form4", Form4);
            classes.Add("Form5", Form5);
            classes.Add("Form6", Form6);
            classes.Add("Form7", Form7);
            classes.Add("Form8", Form8);
        }
        public static void Main(string[] args)
        {
            char choice;
            do
            {
                Console.Write("\nChoose an option from the following:\n");
                Console.WriteLine("a - Trinary converter.");
                Console.WriteLine("b - School Roster.");
                Console.WriteLine("c - ISBN verifier.");
                Console.WriteLine("q - End the program.");
                choice = Console.ReadKey().KeyChar;
                if (choice != 'a' && choice != 'b' && choice != 'c' && choice != 'q')
                {
                    Console.WriteLine("\nEnter only 'a', 'b', 'c', or 'q'.");
                    continue;
                }
                switch (choice)
                {
                    case 'a':
                        TrinaryConverter();
                        break;
                    case 'b':
                        char option;
                        Console.WriteLine("\n Choose one of the following options:");
                        Console.WriteLine("\na- To add a student to a form");
                        Console.WriteLine("b- To get a list of all students in a form ");
                        Console.WriteLine("c- To find out who is currently enrolled in a school");
                        option = Console.ReadKey().KeyChar;
                        switch (option)
                        {
                            case 'a':
                                AddStudent();
                                break;
                            case 'b':
                                ListOfStudents();
                                break;
                            case 'c':
                                SchoolEnrollment();
                                break;
                        }
                        break;
                    case 'c':
                        ISBNVerifier();
                        break;
                    case 'q':
                        Console.WriteLine("\nThank you for engaging in my menu system");
                        break;
                }
            } while (choice != 'q');
        }
        /* input: 1, expected output:1, actual output:1
        input: 2, expected output:2, actual output:2
        input: 3, expected output:2, actual output:3
        input: 112, expected output:14, actual output:14
        input:7, expected output:error, actual output:error
        input: a, expected output:error, actual ouput:error */
        static void TrinaryConverter()
        {
            Console.Write("\nEnter your trinary number: ");
            string trinaryInput = Console.ReadLine();
            bool isValidTrinary = true;
            int decimalNumber = 0;
            for (int i = trinaryInput.Length - 1; i >= 0; i--)
            {
                char digit = trinaryInput[i];
                if (digit < '0' || digit > '2')
                {
                    isValidTrinary = false;
                    break;
                }
                int trinaryDigit = digit - '0';
                decimalNumber += trinaryDigit * (int)Math.Pow(3, trinaryInput.Length - 1 - i);
            }
            if (isValidTrinary)
            {
                Console.WriteLine("\nThe equivalent decimal number: {0}", decimalNumber);
                Console.WriteLine("\nPlease choose from the following options again");
            }
            else
            {
                Console.WriteLine("Error. Please choose option 'a' again and enter a valid trinary number consisting of digits 0, 1, and 2 
               only.");
            }
        }
        static void AddStudent()
        {
            Console.Write("\nEnter student name: ");
            string studentName = Console.ReadLine().ToLower();
            Console.Write("Added to which form:");
            string addToForm = Console.ReadLine();
            switch (addToForm)
            {
                case "1":
                    if (Form1.Count == 0)
                    {
                        Form1.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form1)
                        {
                            if (name != studentName)
                            {
                                Form1.Add(studentName);
                            }
                        }
                    }
                    break;
                case "2":
                    if (Form2.Count == 0)
                    {
                        Form2.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form2)
                        {
                            if (name != studentName)
                            {
                                Form2.Add(studentName);
                            }
                        }
                    }
                    break;
                case "3":
                    if (Form3.Count == 0)
                    {
                        Form3.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form3)
                        {
                            if (name != studentName)
                            {
                                Form3.Add(studentName);
                            }
                        }
                    }
                    break;
                case "4":
                    if (Form4.Count == 0)
                    {
                        Form4.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form4)
                        {
                            if (name != studentName)
                            {
                                Form4.Add(studentName);
                            }
                        }
                    }
                    break;
                case "5":
                    if (Form5.Count == 0)
                    {
                        Form5.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form5)
                        {
                            if (name != studentName)
                            {
                                Form5.Add(studentName);
                            }
                        }
                    }
                    break;
                case "6":
                    if (Form6.Count == 0)
                    {
                        Form6.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form6)
                        {
                            if (name != studentName)
                            {
                                Form6.Add(studentName);
                            }
                        }
                    }
                    break;
                case "7":
                    if (Form7.Count == 0)
                    {
                        Form7.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form7)
                        {
                            if (name != studentName)
                            {
                                Form7.Add(studentName);
                            }
                        }
                    }
                    break;
                case "8":
                    if (Form8.Count == 0)
                    {
                        Form8.Add(studentName);
                    }
                    else
                    {
                        foreach (string name in Form8)
                        {
                            if (name != studentName)
                            {
                                Form8.Add(studentName);
                            }
                        }
                    }
                    break;
            }
        }
        static void ListOfStudents()
        {
            Console.Write("\n Which form are you looking to find out more about:");
            string listOfNamesInForm = Console.ReadLine();
            switch (listOfNamesInForm)
            {
                case "1":
                    //Console.WriteLine("Form 1 students: " + string.Join(", ", Form1));
                    Console.WriteLine("Form 1 students: ");
                    Console.WriteLine(Form1[0]);
                    break;
                case "2":
                    Console.WriteLine("Form 2 students: " + string.Join(", ", Form2));
                    break;
                case "3":
                    Console.WriteLine("Form 3 students: " + string.Join(", ", Form3));
                    break;
                case "4":
                    Console.WriteLine("Form 4 students: " + string.Join(", ", Form4));
                    break;
                case "5":
                    Console.WriteLine("Form 5 students: " + string.Join(", ", Form5));
                    break;
                case "6":
                    Console.WriteLine("Form 6 students: " + string.Join(", ", Form6));
                    break;
                case "7":
                    Console.WriteLine("Form 7 students: " + string.Join(", ", Form7));
                    break;
                case "8":
                    Console.WriteLine("Form 8 students: " + string.Join(", ", Form8));
                    break;
            }
        }
        static void SchoolEnrollment()
        {
            Scratch scratch = new Scratch();
            foreach (var form in scratch.classes.Keys)
            {
                // Retrieve the list of students for the current form
                List<string> studentsInForm = scratch.classes[form];
                // Sort the students in each form alphabetically
                studentsInForm.Sort();
                Console.WriteLine($"\n {form} students: {string.Join(", ", studentsInForm)}");
            }
        }
        static void ISBNVerifier()
        {
            Console.Write("\n Enter an ISBN-10 : ");
            string userInput = Console.ReadLine();
            if (ISBNVerifier(userInput))
            {
                Console.WriteLine("\n Valid ISBN-10.");
            }
            else
            {
                Console.WriteLine("\n Invalid ISBN-10.");
            }
        }
        static bool ISBNVerifier(string isbn)
        {
            isbn = isbn.Replace("-", "");
            if (isbn.Length != 10)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(isbn[i]) && !(i == 9 && isbn[i] == 'X'))
                {
                    return false;
                }
                int digit = (i == 9 && (isbn[i] == 'X' || isbn[i] == 'x')) ? 10 : int.Parse(isbn[i].ToString());
                sum += digit * (10 - i);
            }
            return sum % 11 == 0;
        }
    }
}
