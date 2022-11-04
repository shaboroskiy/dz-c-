using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Shapes
    {
        abstract class Figure
        {
            public abstract string Area();
            public abstract string Perimeter();
            public abstract string ShapeName();

            public void ShowInfo()
            {
                Console.WriteLine(
                    $"Name of figure: {ShapeName()}\n" +
                    $"Area: {Area()}\n" +
                    $"Perimetr: {Perimeter()}"
                    );
                Console.WriteLine();
            }
        }

        class Triangle : Figure
        {
            double sideA, sideB, sideC;   

            
            public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
            {
                SideA = triangleSideA;
                SideB = triangleSideB;
                SideC = triangleSideC;
            }

            
            public double SideA
            {
                get { return sideA; }
                set { sideA = value < 0 ? -value : value; }
            }

            public double SideB
            {
                get { return sideB; }
                set { sideB = value < 0 ? -value : value; }
            }

            public double SideC
            {
                get { return sideC; }
                set { sideC = value < 0 ? -value : value; }
            }

           
            public override string Area()
            {
                double semPer = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
            }

          
            public override string Perimeter()
            {
                return (sideA + sideB + sideC).ToString();
            }

           
            public override string ShapeName()
            {
                return "";
            }
        }

        class Square : Figure
        {
            double side;   

            
            public Square(double squareSide)
            {
                Side = squareSide;
            }

           
            public double Side
            {
                get { return side; }
                set { side = value < 0 ? -value : value; }
            }

           
            public override string Area()
            {
                return (side * side).ToString();
            }

           
            public override string Perimeter()
            {
                return (side * 4).ToString();
            }

            
            public override string ShapeName()
            {
                return "Square";
            }
        }

        class Rectangle : Figure
        {
            double width;   
            double height;   

           
            public Rectangle(double rectangleWidth, double rectangleHeight)
            {
                Width = rectangleWidth;
                Height = rectangleHeight;
            }

            
            public double Width
            {
                get { return width; }
                set { width = value < 0 ? -value : value; }
            }

            public double Height
            {
                get { return height; }
                set { height = value < 0 ? -value : value; }
            }

            
            public override string Area()
            {
                return (width * height).ToString();
            }

            
            public override string Perimeter()
            {
                return (width * 2 + height * 2).ToString();
            }

           
            public override string ShapeName()
            {
                return "Rectangle";
            }
        }

        class Program
        {
            static void Main()
            {
                Figure figure1 = new Triangle(4, 5, 6);
                figure1.ShowInfo();

                Figure figure2 = new Square(5);
                figure2.ShowInfo();

                Figure figure3 = new Rectangle(5, 6);
                figure3.ShowInfo();

                Console.ReadKey();
            }
        }
    }

