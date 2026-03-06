
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;

namespace MEGAPLAN.Core
{
    public class WallEngine
    {
        public static Polyline CreateWall(Point2d p1, Point2d p2, double thickness)
        {
            Polyline pl = new Polyline();
            pl.AddVertexAt(0, p1, 0, 0, 0);
            pl.AddVertexAt(1, p2, 0, 0, 0);
            return pl;
        }
    }
}
