namespace AgileDev_GitPractice;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        
        animals.Add(new Cassowary());
        animals.Add(new TasmanianDevil());
        animals.Add(new HoneyBadger());
        animals.Add(new FunnelWebSpider());
        animals.Add(new BulletAnt());
        animals.Add(new GreatWhiteShark());
        animals.Add(new Chimpanzee());
        animals.Add(new Hippo());
        animals.Add(new BlueRingedOctopus());
        
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}