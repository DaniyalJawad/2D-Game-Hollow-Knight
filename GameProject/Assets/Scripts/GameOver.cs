using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static event Action onPlayerDeath;
    public void Game_Over()
    {
        if(PlayerHealth.currentHealth<=0)
        {
            onPlayerDeath?.Invoke();
        }
    }
}
