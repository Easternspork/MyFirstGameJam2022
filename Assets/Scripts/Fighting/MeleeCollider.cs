using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCollider : Collidable
{
    public float damage = 5f;
    public float attackCD = 0.5f;
    private float attackTime = 0f;

    protected override void OnCollide(Collider2D[] coll, int hitCount)
    {
        for (int i = 0; i < hitCount; i++)
        {
            if (coll[i].name == "EnemyPF(Clone)" && attackTime < Time.time && Input.GetButton("Fire1"))
            {
                coll[i].gameObject.GetComponent<EnemyController>().hp -= damage;
                Debug.Log("inflicted damage");


                //if (gameObject.GetComponentInParent<Rigidbody2D>().velocity.x > 0)
                //{
                //    coll[i].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(5000, 0));
                //} else if (gameObject.GetComponentInParent<Rigidbody2D>().velocity.x < 0) {
                //    coll[i].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5000, 0));
                //}

                //if (gameObject.GetComponentInParent<Rigidbody2D>().velocity.y > 0)
                //{
                    
                //}
                //else if (gameObject.GetComponentInParent<Rigidbody2D>().velocity.y < 0)
                //{
                //    coll[i].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5000, 0));
                //}

                //coll[i].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(5000, 0));

                attackTime = Time.time + attackCD;
            }
        }
    }   
}
