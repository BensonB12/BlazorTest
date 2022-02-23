namespace blazorBank
{
    public abstract class Card
    {
        //SuperType VSuperType = global::SuperType.None;
        public Card(string name, int manaCost)
        {
            Name = name;
            ManaCost = manaCost;
        }

        public string Name { get; }
        public decimal ManaCost { get; }
        public int Loyalty { get; }
        //public string SuperType{get{VSuperType;} set{VSuperType = value;}}
        //public string Art{get; set;};

        public virtual void Save(StreamWriter writer, Card card)
        {
            writer.WriteLine("Name: " + card.Name);
            writer.WriteLine("ManaCost: "+card.ManaCost);
        }
    }

    public class CreatureCard : Card
    {
        public CreatureCard(string name, int manaCost) : base(name, manaCost)
        {
        }
        public int Power { get; set; }
        public int Toughness { get; set; }
    }

    public class Planeswalker : Card
    {
        public Planeswalker(string name, int manaCost, int loyalty) : base(name, manaCost)
        {
            Loyalty = loyalty;
        }
        public int Loyalty { get; }

        public override void Save(StreamWriter writer, Card card)
        {
            base.Save(writer, card);
            writer.WriteLine("Loyalty: "+ Loyalty);
        }
    }

    public class Spell : Card
    {
        public Spell(string name, int manaCost) : base(name, manaCost)
        { }
    }

    public class Land : Card
    {
        public Land(string name) : base(name, 0)
        {
        }
    }
}
public enum SuperType
{
    Basic,
    Legendary,
    Snow,
    Token,
    None
}

