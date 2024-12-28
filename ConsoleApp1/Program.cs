using Assignment_03_oop.Interface;

namespace Assignment_03_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question Part01
            //1- What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class

            //2- Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private

            //3- Can an interface contain fields in C#?
            //b) NO

            //4- In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces

            //5- Which keyword is used to implement an interface in a class in C#?
            //d) implements

            //6- Can an interface contain static methods in C#?
            //a) Yes

            //7- In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public

            //8- What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members

            //9- In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors

            //10- How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas







            #endregion
            #region Implemtation Part02 Code 
            ICircle circle = new Circle(10);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(16, 6);
            rectangle.DisplayShapeInfo();
            #endregion

        }
    }
}
