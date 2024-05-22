using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> enemiesInScreen;

    public bool isGameOver;

    public Text coinText;
    int coins;
    
    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyEnemiesInScreen();
        }
    }

    public void DestroyEnemiesInScreen()
    {
        foreach (GameObject enemy in enemiesInScreen)
        {
            Destroy(enemy);
        }
    }
}

    