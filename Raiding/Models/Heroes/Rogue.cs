﻿
namespace Raiding.Models.Heroes;

public class Rogue : Fighter
{
    public Rogue(string name) : base(name)
    {
    }

    public override int Power => 80;

}
