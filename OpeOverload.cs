using System.Net.NetworkInformation;
using System.Numerics;

namespace revision;

public class OpeOverload
{
    public static void Run(){
        Subscription s1 = new(5);
        Subscription s2 = new(7);
        System.Console.WriteLine(s1+s2);
    }

    public class Subscription(int duration){
        public int duration = duration;
        public static Subscription operator +(Subscription a , Subscription b){
            return new Subscription(a.duration+b.duration);
        }

        public override string ToString()
        {
            return this.duration+"";
        }
    }
}
