using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{
    public float speedMutiplier = 2.0f;
    public float duration = 5.0f;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(speedMutiplier, duration);
    }
}
