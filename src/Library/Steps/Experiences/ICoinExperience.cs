 
/*
    SRP: Esta interfaz cumple con SRP ya que su unica responsabilidad es definir las operaciones necesarias para que una Experiencia nueva devuelva
    Coins como reward.
    
    OCP: No se aplica.
*/

namespace Library
{
    public interface ICoinExperience : IStep
    {
        public Coin SetCoinReward(int value);
    }
}