using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerImage : MonoBehaviour
{


    public SpriteRenderer playerImage;                      //이미지 자체
    public Sprite[] sprites = new Sprite[3];                //이미지 목록
    public static PlayerImage instance;
    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

        playerImage = GetComponent<SpriteRenderer>();
        playerImage.sprite = sprites[0];                  //sprite[0]에 해당하는 이미지를 넣음

    }
    void Update()
    {
        playerImage.sprite = sprites[Enemy.imageNum];
    }
 



}