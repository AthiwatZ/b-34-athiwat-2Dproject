using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StregthPowerUp : PowerUp
{
    float strengthMultipiler = 2f;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(strengthMultipiler);
    }
}
