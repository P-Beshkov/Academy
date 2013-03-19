/*10. Implement an ExplodingBlock. It should destroy all blocks 
 * around it when it is destroyed. You must NOT edit any existing
 * .cs file. Hint: what does an explosion "produce"? */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public const char Symbol = '*';
        public new const string CollisionGroupString = "explodingBlock";
        private bool isHit = false;

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = ExplodingBlock.Symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (isHit)
            {
                List<GameObject> explosionParticles = new List<GameObject>();
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(-1, 0)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(1, 0)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(0, 1)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(0, -1)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(1, -1)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(-1, 1)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(-1, -1)));
                explosionParticles.Add(new ExplosionParticle(topLeft, new MatrixCoords(1, 1)));
                return explosionParticles;
            }
            else
            {
                return new List<GameObject>();
            }
        }

        public override void Update()
        {
            base.Update();
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.isHit = true;
            ProduceObjects();
        }
    }
}

