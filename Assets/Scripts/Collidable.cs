using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    protected Collider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update()
    {
        int hitCount = boxCollider.OverlapCollider(filter, hits);
        OnCollide(hits, hitCount);
    }

    protected virtual void OnCollide(Collider2D[] coll, int hitCount)
    {
        for (int i = 0; i < hitCount; i++)
        {
            Collider2D collider = coll[i];
            Debug.Log(collider.name);
        }
    }
}
