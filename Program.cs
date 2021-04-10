using System;


namespace Vector_class
{

 
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D a = new Vector3D(3, 2, 1);
            Vector3D b = new Vector3D(0, 1, 2);

            Console.WriteLine("Дано: вектор а{0} и вектор b{1}", a.ToString(), b.ToString());

            // Длина векторов
            // Свойства
            Console.WriteLine("Длина векторов a: [{0}]", a.Length);
            Console.WriteLine("Длина векторов b: [{0}]", b.Length);         

            // Угол между векторам (cos)
            Console.WriteLine("Угол между вектором a и b, cos(a^b): {0}", a.Angle(b));

            // Сложение векторов
            Console.WriteLine("a{0} + b{1} = c{2}", a.ToString(), b.ToString(), a.Plus(b));
            Console.WriteLine("a{0} + b{1} = c{2}", a.ToString(), b.ToString(), a + b);

            // Умножение вектора на число
            Console.WriteLine("{0} * a{1} = c{2}", 2, a.ToString(), a.SubDigit(2));
            Console.WriteLine("{0} * a{1} = c{2}", 2, a.ToString(), 2 * a);

            // Скалярное умножение
            Console.WriteLine("a{0} * b{1} = {2}", a.ToString(), b.ToString(), a.SubScalar(b));
            Console.WriteLine("a{0} * b{1} = {2}", a.ToString(), b.ToString(), a * b);

            Console.ReadKey();
        }
    }
}
