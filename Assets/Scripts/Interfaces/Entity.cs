using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    private Transform _transform;
    
    public int Health { get; set; }
    
    public float Speed { get; set; }
    
    public Transform CachedTransform
    {
        get
        {
            if (_transform == null)
            {
                _transform = GetComponent<Transform>();
            }
            return _transform;
        }
    }
    
    public abstract void Move(float direction = 0);
    public abstract void Jump();
    public abstract void Shoot();
    public abstract void Death();
    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        Death();
    }
    
}
