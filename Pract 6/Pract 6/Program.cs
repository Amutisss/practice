using System;
using System.Collections.Generic;
using Studentlib;
namespace Pract_6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool exit = false;
                while (true)
                {
                    int Choice = 0;
                    Console.WriteLine("'1' - Вся информацию о студентах.\n'2' - Список студентов по инициалам\n'3' - Список студентов старше 18\n'4' - Список студентов младше 18\n'5' - Добавить студента\n'6' - Удалить студента\n'7' - Изменить студента\n'8' - Поиск студентов\n'9' - Выход");
                    while (true)
                    {
                        Console.WriteLine("Выберите номер: ");
                        Choice = Convert.ToInt32(Console.ReadLine());
                        if (Choice > 10 || Choice < 1)
                        {
                            Console.WriteLine("Такого номера нет");
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (Choice == 1)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            foreach (Student student in Student.ListStudent)
                            {
                                Student.ExitID(student.IDStudent);
                            }
                        }
                    }
                    else if (Choice == 2)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Student.DeleteAllStudent();
                        }
                    }
                    else if (Choice == 3)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Console.Clear();
                            foreach (Student student in Student.ListStudent)
                            {
                                if (student.HeightStudent(student.IDStudent) >= 18)
                                {
                                    Student.ExitID(student.IDStudent);
                                }
                            }
                        }
                    }
                    else if (Choice == 4)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Console.Clear();
                            foreach (Student student in Student.ListStudent)
                            {
                                if (student.HeightStudent(student.IDStudent) <= 18)
                                {
                                    Student.ExitID(student.IDStudent);
                                }
                            }
                        }
                    }
                    else if (Choice == 5)
                    {
                        Console.WriteLine("Введите ФИО студента: ");
                        String FIO = Console.ReadLine().Trim();
                        Console.WriteLine("Введеите группу студента: ");
                        String Group = Console.ReadLine().Trim();
                        Console.WriteLine("Дата рождения: ");
                        Console.WriteLine("Введите день: ");
                        String Day = Console.ReadLine();
                        Console.WriteLine("Введите месяц: ");
                        String Month = Console.ReadLine();
                        Console.WriteLine("Введите год: ");
                        String Year = Console.ReadLine();
                        Student stud = new Student(FIO, Group, new DateTime(Convert.ToInt32(Year), Convert.ToInt32(Month), Convert.ToInt32(Day)));
                        Student.AddStudent(stud);
                        Console.WriteLine("Студент добавлен");
                    }
                    else if (Choice == 6)
                    {
                        Console.WriteLine("Введеите id для удаления: ");
                        int DeleteID = Convert.ToInt32(Console.ReadLine());
                        Student.DeleteStudent(DeleteID);
                        Console.WriteLine("Студент удалён");
                    }
                    else if (Choice == 7)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов");
                        }
                        else
                        {
                            Console.WriteLine("Введете id для изменения студента: ");
                            int idEdit = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите ФИО студента: ");
                            String fioEdit = Console.ReadLine().Trim();
                            Console.Write("Введеите группу студента: ");
                            String groupEdit = Console.ReadLine().Trim();
                            Console.WriteLine("Дата рождения: ");
                            Console.WriteLine("Введите день: ");
                            String dayEdit = Console.ReadLine();
                            Console.WriteLine("Введите месяц: ");
                            String monthEdit = Console.ReadLine();
                            Console.WriteLine("Введите год: ");
                            String yearEdit = Console.ReadLine();
                            Student.EditStudent(fioEdit, groupEdit, new DateTime(Convert.ToInt32(yearEdit), Convert.ToInt32(monthEdit), Convert.ToInt32(dayEdit)), idEdit);
                            Console.WriteLine("Студент изменён");
                        }
                    }
                    else if (Choice == 8)
                    {
                        if (Student.ListStudent.Count == 0)
                        {
                            Console.WriteLine("Нет студентов\n");
                        }
                        else
                        {
                            Console.WriteLine("Поиск студента: ");
                            Console.WriteLine("Введите id студента: ");
                            int idStudent = Convert.ToInt32(Console.ReadLine());
                            Student.ExitID(idStudent);
                        }
                    }
                    else if (Choice == 9)
                    {
                        Console.WriteLine("Выход");
                        exit = true;
                    }
                    if (exit == true)
                    {
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
