abstract class Character
{
    private string CharacterType { get; set; }
    public bool IsVulnerable { get; set; } = false;
    
    protected Character(string characterType)
    {
        this.CharacterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return this.IsVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {this.CharacterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.IsVulnerable ? 10 : 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
        this.IsVulnerable = true;
    }

    public override int DamagePoints(Character target)
    {
        return this.IsVulnerable ? 3 : 12;
    }

    public void PrepareSpell()
    {
        this.IsVulnerable = false;
    }
}
