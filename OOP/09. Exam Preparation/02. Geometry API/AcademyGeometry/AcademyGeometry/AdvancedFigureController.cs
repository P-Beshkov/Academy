using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryAPI
{
    public class AdvancedFigureController : GeometryAPI.FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {                
                case "circle":
                    {
                        Vector3D center = Vector3D.Parse(splitFigString[1]);
                        double radius = double.Parse(splitFigString[2]);
                        currentFigure = new Circle(center, radius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D bottom = Vector3D.Parse(splitFigString[1]);
                        Vector3D top = Vector3D.Parse(splitFigString[2]);
                        double radius = double.Parse(splitFigString[3]);
                        currentFigure = new Cylinder(bottom, top, radius);
                        break;
                    }
            }
            base.ExecuteFigureCreationCommand(splitFigString);
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            { 
                case "area":
                    {
                        IAreaMeasurable tempFigure = this.currentFigure as IAreaMeasurable;
                        if (tempFigure != null)
                        {
                            Console.WriteLine("{0:0.00}", tempFigure.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "volume":
                    {
                        IVolumeMeasurable tempFigure = this.currentFigure as IVolumeMeasurable;
                        if (tempFigure != null)
                        {
                            Console.WriteLine("{0:0.00}", tempFigure.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
                case "normal":
                    {
                        IFlat tempFugire = this.currentFigure as IFlat;
                        if (tempFugire != null)
                        {
                            Console.WriteLine("{0:0.00}", tempFugire.GetNormal().ToString());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }
                        break;
                    }
            }
            base.ExecuteFigureInstanceCommand(splitCommand);
        }
    }
}