using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerImage : MonoBehaviour
{


    public SpriteRenderer playerImage;                      //�̹��� ��ü
    public Sprite[] sprites = new Sprite[3];                //�̹��� ���
    public static PlayerImage instance;
    // Use this for initialization
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

        playerImage = GetComponent<SpriteRenderer>();
        playerImage.sprite = sprites[0];                  //sprite[0]�� �ش��ϴ� �̹����� ����

    }
    void Update()
    {
        playerImage.sprite = sprites[Enemy.imageNum];
    }
 



}