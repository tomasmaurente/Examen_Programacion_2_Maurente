using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica razon de cambio es que se introduzca un nuevo Reward al juego.

    OCP: Esta clase cumple con OCP ya que es independiente al resto del codigo a la hora de implementarse, es decir que no modifica el resto del codigo 
    a la hora de implementarse en otra clase. A esta tipo de clases se la llama clase componente, debido a que exiten para componer a otras, estas clases 
    se crean para asumir una responsabilidad y restarle una razon de cambio a la clase compuesta. Asi se  logra tambien que la clase compuesta pueda 
    obtener nuevas funcionalidades teniendo cambios minimos.
    
    LSP: No se aplica.

    ISP: esta clase cumple ISP ya que define metodos que la clase compuesta usara en su totalidad.

    DIP: Esta clase cumple con DIP ya que no depende de ninguna clase de bajo nivel. Ademas esta implementa IRewardedPlayer para permitir que 
    AbstractPlayer no dependa de RewardedPlayer sino de la Interface IRewardedPlayer.

    EXPERT: Esta clase es la experta en conocer las recompensas del jugador.

    POLYMORPHISM: No se aplica.

    CREATOR: Esta clase aplica el patron ya que crea Puntos, Monedas, y nuevas excepciones. Se justifica ya que se saben los valores que deben
    tener los constructores de Coin y Point y tambien sabe cuando debe arrojar la excepcion, siendo así una clase experta para crear instancias de otra. 

    LEY DE DEMETER: No se aplica.

    ACOPLAMIENTO: Esta clase tiene BAJO acoplamiento ya que hace solo depende de abstracciones.
*/

/// <summary>
/// La finalidad de esta clase es componer al player,
/// esta manejara los rewards que el player obtenga.
/// </summary>

namespace Library
{
    public class RewardedPlayer : IRewardedPlayer
    {
        private List<AbstractReward> listRewards;

        // Si se agrega otro reward se debe declarar en este constructor.
        public RewardedPlayer()
        {
            this.listRewards = new List<AbstractReward>();
            this.listRewards.Add(new Point(0));
            this.listRewards.Add(new Coin(0));
        }
        // Este metodo checkea que los rewards que le fueron otorgados al player sean aceptables y luego los almacena.
        public void AddReward(List<AbstractReward> incomingReward)
        {
            AbstractReward playerReward = null;

            foreach (AbstractReward reward in incomingReward)
            {
                playerReward = listRewards.Find(x => x.GetType() == reward.GetType());

                if (playerReward == null)
                {
                    throw new NoAceptableRewardExeption();
                }
                else
                {
                    if (reward.Value > 0)
                    {
                        playerReward.Value += reward.Value;
                    }
                }
            }
        }
        // Este metodo devuelve la cantidad de puntos que el player tiene.
        public AbstractReward TotalPoints()
        {
            foreach (AbstractReward rewar in this.listRewards)
            {
                if (rewar is Point)
                {
                    return rewar;
                }
            }
            return null;
        }
        // Este metodo devuelve la cantidad de monedas que el player tiene.
        public AbstractReward TotalCoins()
        {
            foreach (AbstractReward rewar in this.listRewards)
            {
                if (rewar is Coin)
                {
                    return rewar;
                }
            }
            return null;
        }
    }
}