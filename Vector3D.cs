using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_class
{
    public class Vector3D
    {


        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vector3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }





        public double Length
        {
            get
            {
                return Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z), 2);
            }
            set
            {
                this.Length = value;
            }
        }




        //угол между двумя векторами
        public double Angle(Vector3D v)
        {
            double cos = Math.Round((X * v.X + Y * v.Y + Z * v.Z) / (this.Length * v.Length), 4);
            return cos;
        }


        // Сложение векторов
        public Vector3D Plus(Vector3D v)
        {
            double xx = X + v.X;
            double yy = Y + v.Y;
            double zz = Z + v.Z;
            return new Vector3D(xx, yy, zz);
        }
        // Переопределение операции +
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }


        // Вычитание векторов
        public Vector3D Minus(Vector3D v)
        {
            double xx = X - v.X;
            double yy = Y - v.Y;
            double zz = Z - v.Z;
            return new Vector3D(xx, yy, zz);
        }
        // Переопределение операции -
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }



        // Умножение вектора на число
        public Vector3D SubDigit(double digit)
        {
            return new Vector3D(X * digit, Y * digit, Z * digit);
        }
        // Переопределение операции *
        public static Vector3D operator *(double digit, Vector3D v1)
        {
            return new Vector3D(digit * v1.X, digit * v1.Y, digit * v1.Z);
        }


        // Скалярное умножение векторов
        public double SubScalar(Vector3D v)
        {
            return Math.Round(this.Length * v.Length * this.Angle(v), 2);
        }
        // Переопределение операции *
        public static double operator *(Vector3D v1, Vector3D v2)
        {
            return Math.Round(v1.Length * v2.Length * v1.Angle(v2), 2);
        }


        // Векторное умножение векторов

        public Vector3D SubVector(Vector3D v)
        {
            return new Vector3D((Y * v.Z - Z * v.Y), (-1) * (X * v.Z - Z * v.X), (X * v.Y - Y * v.X));
        }


        // Переопределение метода ToString()
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }



    }
}
