using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CostUI : MonoBehaviour
{
    public Text moneyText;
    void Update()
    {
        moneyText.text = "cost" + PlayerStats.Money.ToString();
    }
}
