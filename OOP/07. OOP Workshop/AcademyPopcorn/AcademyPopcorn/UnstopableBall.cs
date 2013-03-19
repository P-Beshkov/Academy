using System;
using System.Linq;

namespace AcademyPopcorn
{
    public class UnstopableBall : Ball
    {
        public new const string CollisionGroupString = "unstopableBall";
        public UnstopableBall(MatrixCoords topLeft, MatrixCoords speed):  base(topLeft, speed)
        {
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unstopableBall";
        }

    }
}
