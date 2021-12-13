using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Facebook : MonoBehaviour
{
    public float speed = 3f;
    public static int enemyCount = 0;
    public float startHealth = 70;
    private float health;
    private int skillcount = 0;
    public Image healthBar;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        health = startHealth;
        target = Waypoints.points[0];
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log(health);

        healthBar.fillAmount = health / startHealth;

        skillcount++;
        if (skillcount >= 10)
        {
            speed *= 3;
            skillcount = 0;
        }
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

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }
    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            enemyCount--;
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}
