using System;
/*
Создать класс, представляющий учебный класс ClassRoom. 
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax(). 
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса 
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, 
писать, отдыхать.*/
namespace Les3OOPHW
{
    internal class ClassRoom
    {
        Student[] arrPupil = new Student[4];

        public ClassRoom(params Student[] _pupils)
        {
            arrPupil = _pupils;
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Study: ");
            foreach (Student student in arrPupil)
            {
                student.Study();

            }

        }
        public void PrintInfoRead()
        {
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Read: ");
            foreach (Student student in arrPupil)
            {
                student.Read();
            }

        }

        public void PrintInfoRelax()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Relax: ");
            foreach (Student student in arrPupil)
            {
                student.Relax();
            }

        }
        public void PrintInfoWrite()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Write: ");
            foreach (Student student in arrPupil)
            {
                student.Write();
            }

        }

        public void StableColor()
        {
            Console.WriteLine(new string('-', 40));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
