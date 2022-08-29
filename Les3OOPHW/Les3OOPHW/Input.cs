using System;

namespace Les3OOPHW
{
    //UNUSIBLE CLASS!!!
    internal class Input
    {
        int number = 0;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public void NumberOfStudents(Student student)
        {

            Console.WriteLine("Input the number of students lower than 10");
            while (number <= 0 || number > 10)
            {
                number = int.Parse(Console.ReadLine());
                if (number <= 0 || number > 10)
                    Console.WriteLine("Input in arange 1 to 10");
                else
                {
                    // student.NumberOfStudets = number;
                }
            }


            /*for (int i = 0; i < badStudentsArray.Length; i++)
            {
                Console.WriteLine($"bad student's: {badStudentsArray[i]}");
            }
            for (int i = 0; i < goodStudentsArray.Length; i++)
            {
                Console.WriteLine($"good student's: {goodStudentsArray[i]}");
            }
            for (int i = 0; i < excelentStudentsArray.Length; i++)
            {
                Console.WriteLine($"exclent student's: {excelentStudentsArray[i]}");
            }*/
        }

        public string[] InputStudents(string[] StudentsArray, string typeOfStudents)
        {
            string yesOrNo = null;
            int counter = 0;


            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Input {typeOfStudents} First Names");
                StudentsArray[i] = Console.ReadLine();
                counter++;
                yesOrNo = null;

                do
                {
                    Console.WriteLine("Do u want to add 1 more?");
                    yesOrNo = Console.ReadLine();
                    yesOrNo = yesOrNo.ToLower();
                    if (yesOrNo == "no")
                    {
                        break;
                    }
                } while (yesOrNo != "yes");

                if (yesOrNo == "no")
                {
                    number -= counter;
                    Array.Resize(ref StudentsArray, counter);
                    /* for (int j = 0; j < StudentsArray.Length; j++)
                     {
                         Console.WriteLine(StudentsArray[j]);
                     }*/
                    return StudentsArray;
                }
                else continue;
            }

            number -= counter;
            Array.Resize(ref StudentsArray, counter);
            Console.WriteLine($"There's {number} left");
            /*  for (int j = 0; j < StudentsArray.Length; j++)
              {
                  Console.WriteLine(StudentsArray[j]);
              }*/
            return StudentsArray;
        }

        /* public void BadStudents()
         {
             string[] badStudentsArray = new string[number];
             string yesOrNo = null;
             int counter = 0;

             for (int i = 0; i < number; i++)
             {
                 Console.WriteLine("Input bad studen's First Names");
                 badStudentsArray[i] = Console.ReadLine();
                 counter++;
                 yesOrNo = null;

                 do
                 {
                     Console.WriteLine("Do u want to add 1 more?");
                     yesOrNo = Console.ReadLine();
                     yesOrNo = yesOrNo.ToLower();
                     if (yesOrNo == "no")
                     {
                         break;
                     }
                 } while (yesOrNo != "yes");

                 if (yesOrNo == "no")
                 {
                     number -= counter;
                     Array.Resize(ref badStudentsArray, counter);
                     for (int j = 0; j < badStudentsArray.Length; j++)
                     {
                         Console.WriteLine(badStudentsArray[j]);
                     }
                     break;
                 }
                 else continue;
             }

         }

         public void GoodStudents()
         {
             string[] goodStudentsArray = new string[number];
             string yesOrNo = null;
             int counter = 0;


             for (int i = 0; i < number; i++)
             {
                 Console.WriteLine("Input good studen's First Names");
                 goodStudentsArray[i] = Console.ReadLine();
                 counter++;
                 yesOrNo = null;

                 do
                 {
                     Console.WriteLine("Do u want to add 1 more?");
                     yesOrNo = Console.ReadLine();
                     yesOrNo = yesOrNo.ToLower();
                     if (yesOrNo == "no")
                     {
                         break;
                     }
                 } while (yesOrNo != "yes");

                 if (yesOrNo == "no")
                 {
                     number -= counter;
                     Array.Resize(ref goodStudentsArray, counter);
                     for (int j = 0; j < goodStudentsArray.Length; j++)
                     {
                         Console.WriteLine(goodStudentsArray[j]);
                     }
                     break;
                 }
                 else continue;
             }

             number -= counter;
             Console.WriteLine($"There's {number} left");
             Array.Resize(ref goodStudentsArray, counter);
             for (int j = 0; j < goodStudentsArray.Length; j++)
             {
                 Console.WriteLine(goodStudentsArray[j]);
             }
         }*/

    }
}
