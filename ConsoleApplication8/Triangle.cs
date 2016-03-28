using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Triangle
    {

        private int _gipotenuza;
        public int Gipotenuza {
            get { return _gipotenuza; }
            set
            {
                if (value > 0)
                    _gipotenuza = value;
                else
                {
                    throw new Exception("Значение должно быть > 0!");
                }
            } 
        }

        private int _katetOne;
        public int KatetOne
        {
            get { return _katetOne; }
            set
            {
                if (value > 0)
                    _katetOne = value;
                else
                {
                    throw new Exception("Значение должно быть > 0!");
                }
            }
        }

        private int _katetTwo;
        public int KatetTwo {
            get { return _katetTwo; }
            set
            {
                if (value > 0)
                    _katetTwo = value;
                else
                {
                    throw new Exception("Значение должно быть > 0!");
                }
            } 
        }

        public Triangle()
        {
            
        }

        public Triangle(int katetOne, int katetTwo, int gipotenuza)
        {
            KatetOne = katetOne;
            KatetTwo = katetTwo;
            Gipotenuza = gipotenuza;
        }

        public bool GetRectangulared(int katetOne, int katetTwo, int gipotenuza)
        {
            return (Math.Sqrt(katetOne * katetOne + katetTwo * katetTwo) == gipotenuza);
        }

        public bool GetRectangulared()
        {
            return GetRectangulared(KatetOne, KatetTwo, Gipotenuza);
        }

        public double? GetArea()
        {
            if (GetRectangulared())
                return 0.5 * KatetOne * KatetTwo;
            return null;
        }
    }
}
