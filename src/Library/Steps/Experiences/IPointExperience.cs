 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que una Experiencia nueva devuelva
    Points como reward.
*/

namespace Library
{
    public interface IPointExperience : IStep
    {
        public Point SetPointReward(int value);
    }
}