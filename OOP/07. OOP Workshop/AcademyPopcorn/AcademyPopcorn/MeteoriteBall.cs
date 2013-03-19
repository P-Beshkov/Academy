/*06. Implement a MeteoriteBall. It should inherit the Ball class and should leave a 
 * trail of TrailObject objects. Each trail objects should last for 3 "turns". Other 
 * than that, the Meteorite ball should behave the same way as the normal ball. 
 * You must NOT edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public List<TrailObject> trail;

        public MeteoriteBall(MatrixCoords topLeft,MatrixCoords speed) : base(topLeft,speed)
        {
            trail = new List<TrailObject>();
        }

        public override void Update()
        {            
            trail.Add(new TrailObject(this.TopLeft, 3));
            this.TopLeft += Speed;            
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> produceObjects = new List<GameObject>();
            produceObjects.Add(new TrailObject(base.topLeft, 3));
            return produceObjects;
        }
    }
}
