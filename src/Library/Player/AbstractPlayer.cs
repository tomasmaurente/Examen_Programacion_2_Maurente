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

    ISP: Esta clase cumple con ISP ya que separa dos responsabilidades en dos interfaces, IRewardedPlayer y IStepCounter. Si bien se utilizan ambas 
    responsabilidades (por lo que podria ser una sola interfaz general) siguiendo SRP se separaron en dos interfaces distintas.

    DIP: esta clase cumple con DIP ya que solo depende de abstraciones. En el caso de RewardedPlayer esta clase depende de IRewardedPLayer y no de la 
    clase en si. Lo mismo sucede con StepCounter, los Rewards y Los Steps. 

    EXPERT: Esta clase es la experta en conocer el nombre del jugador.

    POLYMORPHISM: No se aplica.

    CREATOR: Esta clase aplica el patron ya que crea a RewardedPLayer y StepCounter, esto es por la propia implementacion de la clase, la cual 
    necesita de estas instancias. Es decir que esta clase agrega objetos de otra clase.

    LEY DE DEMETER: Esta clase cumple con el patron ya que las clases que la utilizan no interactuan con sus componentes ni saben que componentes contiene,
    es decir, no sabe su estructura interna. Esto es gracias a que los componentes estan instanciados y  los metodos que estos cotienen se los llama a 
    traves del objeto compuesto.

    COHESION: La cohesion de esta clase es ALTA ya que solo existe para definir los metodos necesarios para deinir un player.

    ACOPLAMIENTO: Esta clase tiene BAJO acoplamiento ya que hace solo depende de abstracciones.
*/

/// <summary>
/// La finalidad de esta clase es definir al player, aqui se definen todos los metodos necesarios para que un player circule por el codigo.
/// </summary>

namespace Library
{
    public abstract class AbstractPlayer : IRewardedPlayer, IStepCounter
    {
        public IStepCounter StepCounter { get; }
        public IRewardedPlayer RewardedPlayer { get; }
        public string Name { get; private set; }

        public AbstractPlayer(string name)
        : base()
        {
            this.Name = name;
            this.RewardedPlayer = new RewardedPlayer();
            this.StepCounter = new StepCounter();
        }
        // Este metodo ejecuta un step pasado por parametro, el player le pregunta al step la recompensa que le corresponde, luego el propio player
        // gestiona como acumula la recompensa. 
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
