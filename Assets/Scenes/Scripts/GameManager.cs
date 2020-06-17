using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int coin;
    int keys;
    public Text cointext;
    public Text Keytext;
    public void Addcoin()
    {
        coin++;
        Debug.Log("COINS: " + coin);
        cointext.text = "Coins: " + coin;
    }
    public void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void GameWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void AddKey()
    {
        keys++;
        Debug.Log("Keys: " + keys);
        cointext.text = "keys: " + keys;
    }
    public void ConsumeKey()
    {
        keys--;
    }
    public bool HasKey()
    {
        if (keys > 0)
            return true;
        else
            return false;
        
    }
}
