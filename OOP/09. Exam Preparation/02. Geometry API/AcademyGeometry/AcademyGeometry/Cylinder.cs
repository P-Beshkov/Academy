using System;

namespace GeometryAPI
{
    class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        private double radius;
        private double height;
        public Cylinder(Vector3D bottomCenter, Vector3D topCenter, double radius) : base(bottomCenter,topCenter)
        {
            this.Radius = radius;
            Vector3D diff =this.vertices[0]-this.vertices[1];
            this.Height = Math.Sqrt(diff.X * diff.X + diff.Y * diff.Y + diff.Z * diff.Z);
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public double GetArea()
        {
            return this.Height * 2 * Math.PI * this.Radius+2*Math.PI*this.Radius*this.Radius;
        }

        public double GetVolume()
        {
            return this.Radius * this.Radius * Math.PI * this.Height;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }
    }
}