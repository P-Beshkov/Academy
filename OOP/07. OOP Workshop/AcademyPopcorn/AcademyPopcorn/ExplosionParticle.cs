namespace AcademyPopcorn
{
    public class ExplosionParticle : MovingObject
    {
        public ExplosionParticle(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { '*' } }, speed)
        {
        }

        public override void Update()
        {
            base.Update();
            this.IsDestroyed = true;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }

        public override string GetCollisionGroupString()
        {
            return Ball.CollisionGroupString;
        }
    }
}