using System.Collections.Generic;

/*
    SRP: Esta clase cumple con SRP ya que su unica responsabilidad es componer AbstractPlayer, su unica razon de cambio es que se le quiera agregar 
    una funcionalidad, ante este caso bastaría con seguir componiendo la clase. Al componer la clase, las responsabilidades y las razones de cambio
    pasan a ser de la clase componente, restandole responsabilidades y las razones de cambio a la clase compuesta, en este caso AbstractPlayer.

    OCP: Esta clase cumple con OCP. El caso de querer almacenar un nuevo tipo de informacion, se debe proceder como se hizo con RewardedPlayer. Se 
    debe crear una clase que pueda manejar esa informacion, e implementar una interfaz que permita el uso de esta segunda clase. De esta manera, 
    podemos extender AbstractPlayer haciendo cambios minimos.
     
    LSP: Esta clase cumple con LSP ya que en repetidas ocaciones es utilizado para crear listas de AbstractPlayers, esto genera que si el dia de mañana
    definiera un nuevo tipo de player, como podria serlo un "traveler" solo se necesitaría definir la clase y que ella herede AbstractPlayer, con esto
    cualquier traveler no tendria problema alguno en el codigo.

    
*/

namespace Library
{
    public abstract class AbstractPlayer : IRewardedPlayer, IStepCounter
    {
        public StepCounter StepCounter { get; }
        public RewardedPlayer RewardedPlayer { get; }
        public string Name { get; private set; }

        public AbstractPlayer(string name)
        : base()
        {
            this.Name = name;
            this.RewardedPlayer = new RewardedPlayer();
            this.StepCounter = new StepCounter();
        }
        public void ExecuteStep(IStep step)
        {
            if (step != null)
            {
                int timesInStep = this.GetStepInformation(step);
                List<AbstractReward> rewards = new List<AbstractReward>();
                step.Execute(timesInStep, ref rewards);
                this.AddReward(rewards);
                this.ReceiveStepConfirmation(step);
            }
        }
        public void AddReward(List<AbstractReward> incomingReward)
        {
            this.RewardedPlayer.AddReward(incomingReward);
        }
        public AbstractReward TotalPoints()
        {
            return this.RewardedPlayer.TotalPoints();
        }
        public AbstractReward TotalCoins()
        {
            return this.RewardedPlayer.TotalCoins();
        }
        public int GetStepInformation(IStep step)
        {
            return this.StepCounter.GetStepInformation(step);
        }
        public void ReceiveStepConfirmation(IStep step)
        {
            this.StepCounter.ReceiveStepConfirmation(step);
        }
    }
}
