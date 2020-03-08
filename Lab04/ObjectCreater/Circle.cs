using System;

namespace ObjectCreater
{
    public class Circle : IComparable<Circle>
    {
        private int _radius;

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value >= 0)
                    _radius = value;
            }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override string ToString()
        {
            return $"Радиус круга = {_radius}";
        }

        public int CompareTo(Circle other)
        {
            if (other == null) return 1;
            return this.Radius.CompareTo(other.Radius);
        }
    }
}
