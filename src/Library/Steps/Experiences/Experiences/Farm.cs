using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es definir la experiencia Farm.
    
    OCP: No se aplica.
    
    LSP: Esta interfaz cumple con LSP ya que en repetidas ocaciones los objetos de esta clase estan en listas que contienen un supertipo.

    ISP: No se aplica.

    DIP: Esta clase cumple con DIP ya que solo depende de AbstractReward, una abstración.

    EXPERT: Esta clase es la experta en conocer la recompensa del Step.

    POLYMORPHISM: No se aplica.

    CREATOR: Esta clase aplica el patron ya que crea Monedas. Se justifica ya que se sabe el valor que debe tener el constructor de Coin,
    siendo así una clase experta para crear instancias de otra. 

    LEY DE DEMETER: No se aplica.

    COHESION: La cohesion de esta clase es ALTA ya que solo existe para definir un Step y que este sea ejecutable

    ACOPLAMIENTO: No se aplica.
*/

namespace Library
{
    public class Farm : ICoinExperience
    {
        private AbstractReward reward;
        public Farm(int coinReward)
        {
            this.reward = SetCoinReward(coinReward);
        }

        public void Execute(int timesInStep, ref List<AbstractReward> rewards)
        {
            rewards.Add(reward);
        }

        public Coin SetCoinReward(int value)
        {
            if (value > 0)
            {
                return new Coin(value);
            }
            return new Coin(0);
        }
    }
}