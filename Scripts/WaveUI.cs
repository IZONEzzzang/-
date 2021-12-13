using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveUI : MonoBehaviour
{
    public Text waveCountText;
    void Update()
    {
        waveCountText.text = "WAVE" + WaveSpawner.waveCount.ToString();
    }
}
