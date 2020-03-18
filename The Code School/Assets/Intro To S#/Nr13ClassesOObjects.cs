using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Detta är inte monobehavior längre.. detta blir som en mall som jag kan kalla på i andra scripts!
public class Nr13ClassesOObjects
{
    public float health = 100f;
    public string name = "Wizard";

    public void PlayerInfo()
    {
        Debug.Log("Player name is " + name + " And Players Health Is " + health);
    }

}
