using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected Transform _cachedTransform;
    protected float speed = 15f;
    public int Damage { get; set; }
    protected void Start()
    {
        _cachedTransform = GetComponent<Transform>();
        _cachedTransform.parent = null;
        Damage = 10;
    }
    
    private void Update()
    {
        Move();
    }
    
    protected virtual void Move()
    {
        _cachedTransform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
