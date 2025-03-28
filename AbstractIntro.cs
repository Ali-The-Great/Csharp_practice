namespace revision;

public class AbstractIntro
{
    public static void Run(){
        Pokemon p = new Chikorita();
        p.Description();
        Pokemon p2 = new Torchic();
        p2.Description();
    }
    public abstract class Pokemon{
        public abstract void Description();
    }
    public class Chikorita : Pokemon
    {
        public override void Description()
        {
            System.Console.WriteLine("Chikorita : A sweet aroma gently wafts from the leaf on its head. It is docile and loves to soak up the sun's rays.");
        }
    }

    public class Torchic : Pokemon
    {
        public override void Description()
        {
            System.Console.WriteLine("Torchic : If attacked, it strikes back by spitting balls of fire it forms in its stomach. A Torchic dislikes darkness because it can't see its surroundings.");
        }
    }
}
