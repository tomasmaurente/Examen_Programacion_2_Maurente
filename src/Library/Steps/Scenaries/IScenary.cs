 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que un Step sea un Escenario.
*/

namespace Library
{
    public interface IScenary : IStep
    {
        public Point PointsOfVisit(int timesInStep);
    }
}