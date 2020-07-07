using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Speed Potion", menuName = "Inventory/SpeedPotion")]
public class SpeedPotion : Item
{

    public bool speedModifier;
    SnailMovement snailMovement;


    void Start()
    {
        snailMovement = SnailMovement.instance; 
    }

    public override void UseItem()
    {
        speedModifier = false;
        base.UseItem();
        ApplyEffect();
    
    }

    public void ApplyEffect()
    {
        snailMovement.Animating(speedModifier);

        speedModifier = true;
    }
}
