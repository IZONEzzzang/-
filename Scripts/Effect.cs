using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public float time = 0.5f;
    public void DestroyEffect()
    {
        Destroy(gameObject);
    }
    public void Start()
    {
        Invoke("DestroyEffect", time);
    }
}
