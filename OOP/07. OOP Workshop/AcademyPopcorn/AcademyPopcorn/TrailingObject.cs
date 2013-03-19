/*05.Implement a TrailObject class. It should inherit the GameObject class and should have a 
 * constructor which takes an additional "lifetime" integer. The TrailObject should disappear
 * after a "lifetime" amount of turns. You must NOT edit any existing .cs file. Then test the
 * TrailObject by adding an instance of it in the engine through the AcademyPopcornMain.cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int lifetime;
        public TrailObject(MatrixCoords topLeft,int lifetime) : base(topLeft,new char[,]{{(char)(lifetime+48)}})
        {
            this.lifetime = lifetime;

        }
        
        public override void Update()
        {
            lifetime--;
            this.body=new char[,]{{(char)(lifetime+48)}};
            if (lifetime==0)
            {
                this.IsDestroyed = true;                
            }
        }
    }
}
