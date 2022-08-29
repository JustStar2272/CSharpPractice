using System;
/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
Требуется: 
Создать класс, представляющий учебный класс ClassRoom. 
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax(). 
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса 
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, 
писать, отдыхать.
*/
namespace Les3OOPHW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Нужно передать маасив учеников и разбить их отдельно, затем закинуть в список студентов
            /*Input input = new Input();

            string[] StudentsArray = new string[input.Number];
            string[] badStudentsArray = input.InputStudents(StudentsArray, "bad student's");
            string[] goodStudentsArray = input.InputStudents(StudentsArray, "good student's");
            string[] excelentStudentsArray = input.InputStudents(StudentsArray, "excelent");*/


            ClassRoom cRoom = new ClassRoom(new ExcelentStudent(), new GoodStudent(), new BadStudent(), new GoodStudent());

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();
            cRoom.StableColor();

            Console.ReadKey();


            /* Input input = new Input();
             Student student = new Student();
             input.NumberOfStudents(student);*/



            // Print(students);


        }

        /*static void Print(Student[] students)
        {
            foreach (var student in students)
            {
               // student.PrintFirstName();
            }
        }*/


    }
}
