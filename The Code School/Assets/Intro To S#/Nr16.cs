using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr16
{
    private float health = 100f;
    private string name = "Default";

    public Nr16()
    {

    }
    public Nr16(string name, float health)
    {
        this.name = name;
        this.health = health;
    }

    public void PlayerInfo()
    {
        Debug.Log("Player Name Is: " + name + " And Players Health Is: " + health);
    }



    // samma som nere fast myk smidigare
    public float Health
    { get 
        {
         return health;
        }
      set{
            health = value;
        }
    }

    public string Name  
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    // Detta e till lektion 17
    public virtual void Attack()
    {
        Debug.Log("The player is attacking");
    }



    /* Detta e 1:a sätt att göra det på
    public void SetHealth(float health)
    {
        this.health = health;
    }

    public float GetHealth()
    {
        return this.health;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
    
    public string GetName()
    {
        return this.name;
    }
    */


}
