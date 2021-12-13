using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float shotSpeed = 70f;
    public float explosionRadius = 0f;
    public int Towerdamage = 2;
    public float slowAmount = 0.5f;
    public GameObject HitEffect;
    public GameObject ExplodeEffect;
    public int slow = 0;
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
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
           
                HitTarget();
        }
    }*/

    void HitTarget()
        {

            if (explosionRadius > 0f)
            {
                Explode();
                Instantiate(ExplodeEffect, transform.position, Quaternion.identity);
        }
            else
            {
                Damage(target);
                Instantiate(HitEffect, transform.position, Quaternion.identity);
        }
            Destroy(gameObject);
        }

        void Damage(Transform enemy)
        {
            Enemy e = enemy.GetComponent<Enemy>();
            if (e != null)
            {
                e.TakeDamage(Towerdamage);
            }
            if(slow == 1)
            {
            e.Slow(0.5f);
            }
        }
  
        void Explode()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
            foreach (Collider collider in colliders)
            {
                if (collider.tag == "Enemy")
                {

                    Damage(collider.transform);
                }
            }
        }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

}
