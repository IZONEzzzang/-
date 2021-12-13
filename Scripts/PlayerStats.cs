using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerStats : MonoBehaviour
{
    public static float Money;
    public int startMoney = 10;
    public Image healthBar;
    public float health = 50f;
    public float startHealth = 50f;
    public static PlayerStats instance;
    PlayerImage playerImage;

    private void Start()
    {
        Money = startMoney;
        instance = this;
        playerImage = PlayerImage.instance;
    }

    
    public void Defeat()
    {
        if (health == 0)
        {
            SceneManager.LoadScene("Defeat_Scene");
        }
        //gameover
    }
    public static void Clear()
    {
        {
            SceneManager.LoadScene("Win_Scene");
        }
    }
}
