using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nr22Enumerations : MonoBehaviour
{

    //deklarerar variabler
  public enum GameState
    {
        Started,
        Paused,
        Ended,
        MainMenu
    }
    // deklarerar först var vi "börjar"
    GameState gameState = GameState.MainMenu;
    
  // hur man ändrar "state"
    void Start()
    {
        if(gameState == GameState.MainMenu)
        {
            gameState = GameState.Started;
        }
        if(gameState == GameState.Started)
        {
            Debug.Log("Our Game has started");
        }
    }

    
}
