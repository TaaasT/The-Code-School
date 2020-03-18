using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nr17 blir nu en child : Nr16 är perent. Nr17 inheritar nu allt från Nr 16 
// inheritance är att man tar alla egenskaper från en allmänn mall. sen kan man lägga till specifika saker
// som tex om detta skulle vara en wizard så behöver han mana men dom andra behöver inte det.
public class Nr17 : Nr16
{
    private float mana = 33f;

    public Nr17 (string name, float health)
    {
        this.Name = name;
        this.Health = health;
    }


    public void ReplenishMana(float mana)
    {
        this.mana = mana;
    }
    
    // Med override så overridar jag Nr16 attack eftersom den har virtual attack. så jag ändrar det så det passar wizzen;)
    public override void Attack()
    {
        Debug.Log("Wizard Attack: Fireball");
    }
}
