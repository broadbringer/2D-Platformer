using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Bullet
{
    private SpriteRenderer _heroSpriteRenderer;
    private float _direction;
    
    private new void Start()
    {
        _heroSpriteRenderer = transform.parent.GetComponentInParent<SpriteRenderer>();
        _direction = GetDirection();
        base.Start();
        Damage = 40;
    }
    private void Update()
    {
        Move();
    }
    protected override void Move()
    {
        _cachedTransform.Translate(Vector3.right * _direction * speed * Time.deltaTime);
    }
    private float GetDirection()
    {
        if (_heroSpriteRenderer.flipX)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            return -1;
        }
        return 1;
    }
    
}
