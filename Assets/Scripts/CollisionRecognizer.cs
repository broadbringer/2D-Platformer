using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionRecognizer : MonoBehaviour
{
    private Entity _entity;

    private void Start()
    {
        _entity = GetComponent<Entity>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        var bullet = collision.gameObject.GetComponent<Bullet>();
        if (bullet)
        {
            _entity.TakeDamage(bullet.Damage);
        }
    }
    
}
