using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceChange : MonoBehaviour
{
    PlayerStats playerStats;

    public GameObject Study;
    public GameObject Normal;
    public GameObject Fail;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = PlayerStats.instance;
    }

    // Update is called once per frame
    void Update()
    {

        if (playerStats.health > 40)
        {
            Study.SetActive(true);
            Normal.SetActive(false);
            Fail.SetActive(false);
        }

        else if (playerStats.health <= 40 && playerStats.health > 20)
        {
            Study.SetActive(false);
            Normal.SetActive(true);
            Fail.SetActive(false);
        }

        else if (playerStats.health <= 20)
        {
            Study.SetActive(false);
            Normal.SetActive(false);
            Fail.SetActive(true);
        }
    }
}
