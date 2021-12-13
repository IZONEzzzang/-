using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_eraser : MonoBehaviour
{
    private Transform target;

    public float shotSpeed = 90f;

    public int Tower1damage = 4;

    public void Seek(Transform target2)
    {
        target = target2;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = shotSpeed * Time.deltaTime;


        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);


        void HitTarget()
        {
            Damage(target);
            Destroy(gameObject);
        }

        void Damage(Transform enemy)
        {
            Enemy e = enemy.GetComponent<Enemy>();
            if (e != null)
            {
                e.TakeDamage(Tower1damage);
            }
        }
    }
}
