using System;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class ShipBase
{
    public ShipBase(ArmorBase armor)
        : this(armor, new ImpulseEngine())
    {
    }

    public ShipBase(
        ArmorBase armor,
        ImpulseEngineBase impulseEngine,
        JumpingEngineBase jumpingEngine = null,
        DeflectorBase deflector = null)
    {
        ImpulseEngine = impulseEngine;
        JumpingEngine = jumpingEngine;
        Deflector = deflector;

        Armor = armor ?? throw new ArgumentNullException(nameof(armor));
    }

    public int Team { get; }

    public ImpulseEngineBase ImpulseEngine { get; set; }

    public JumpingEngineBase? JumpingEngine { get; set; }

    public DeflectorBase Deflector { get; set; }

    public ArmorBase Armor { get; set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        this.Deflector.TakeDamage(obstacle);
        this.Armor?.TakeDamage(obstacle);

        if (obstacle.Damage > 0)
        {
            this.isAlive = false;
            this.Team = 2;
        }
    }
}