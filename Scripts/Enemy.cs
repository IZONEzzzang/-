using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    public float speed = 10f;
    private float doubleSpeed;
    public static int enemyCount = 0;
    public static int imageNum;
    public float startHealth = 10;
    private float health;
    private int hitTime;
    public Image healthBar;
    public float countdown = 10f;

    private Transform target;
    private int wavepointIndex = 0;
    public int trigger;
    private bool isImotal;


    PlayerStats playerStats;
    void Start()
    {
        health = startHealth;
        speed = startSpeed;
        hitTime = 0;
        target = Waypoints.points[0];
        doubleSpeed = speed * 2;
        playerStats = PlayerStats.instance;
    }

    public void TakeDamage(float amount)
    {
        if (isImotal == false)
        {
            health -= amount;
        }
        hitTime++;
        if(trigger == 5)
        {
            if(hitTime >= 5)
            {
                speed = doubleSpeed;
            }
        }
        if (trigger == 1)
        {
            if (health/startHealth <= 0.5)
            {
                speed = doubleSpeed;
            }
        }


        healthBar.fillAmount = health / startHealth;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Enemy.enemyCount--;
    }

    void Update()
    {
        
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
        if (trigger == 4)
        {
            if(countdown <= 0)
            {
                Imotal();
                Invoke("imotal", 3);
                countdown = 10f;
            }
        }
    }
    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.points.Length - 1 )
        {
            Destroy(gameObject);
            enemyCount--;
            playerStats.health -= 10;
            playerStats.healthBar.fillAmount = playerStats.health / playerStats.startHealth;
            if (playerStats.health <= 40)
            {
                imageNum = 1;
            }
            if (playerStats.health <= 20)
            {
                imageNum = 2;
            }
            if (playerStats.health <= 0)
            {
                playerStats.Defeat();
            }
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }
    public void Imotal()
    {
        isImotal = !isImotal;
    }

}
