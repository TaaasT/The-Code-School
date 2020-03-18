using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Detta är inte monobehavior längre.. detta blir som en mall som jag kan kalla på i andra scripts!
public class Nr13ClassesOObjects
{
    public float health { get; set; }
    public string name = "Wizard";

    

    public void PlayerInfo()
    {
        Debug.Log("Player name is " + name + " And Players Health Is " + health);
    }

    //Denna e skapad till Nr14Constructor!!
    public void Player(string name, float health)
    {
        this.name = name;
        this.health = health;
        PlayerInfo();
    }
    public Nr13ClassesOObjects(string name, float health)
    {
        this.name = name;
        this.health = health;
    }
    public Nr13ClassesOObjects()
    {

    }
}
