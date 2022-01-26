using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : Collidable
{
    public float damage;
    public float attackCD = 1f;
    // time that CD ends
    private float attackTime = 0f;

    public float hp = 15f;

    private LevelManager levelManager;

    protected override void Start()
    {
        base.Start();
        levelManager = FindObjectOfType<LevelManager>();
    }
    private void Kill()
    {
        Destroy(gameObject);
    }

    protected override void OnCollide(Collider2D[] coll, int hitCount)
    {
        

        for (int i = 0; i < hitCount; i++)
        {
            if (coll[i].name == "TreeHitbox" && attackTime < Time.time)
            {
                levelManager.health -= damage;
                attackTime = Time.time + attackCD;
            }
            //else if (coll[i].name == "Player")
            //{
            //    Debug.Log(transform.right.x);
            //    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.right.x * 30, 0));
            //}
        }

        if (hp <= 0)
        {
            Kill();
        }
    }
}
