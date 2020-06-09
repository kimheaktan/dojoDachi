namespace dojodachi.Models
{
    public class Dachi
    {
        public int Happiness {get;set;} = 20;
        public int Fullness {get;set;} = 20;
        public int Energy {get;set;} = 50;
        public int Meals {get;set;} = 3;

        //Or we can instead of setting the value as above
        // public Dachi()
        // {
        //     Fullness = 20;
        //     Happiness = 20;
        //     Energy = 50;
        //     Meals = 3;
        // }
    }
}
