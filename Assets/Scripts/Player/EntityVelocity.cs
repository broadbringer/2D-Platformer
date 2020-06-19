using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EntityVelocity : MonoBehaviour
{
    [SerializeField] private Entity _entity;
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    public void IncreaseByRightVector(float direction)
    {
        var velocity = Vector3.right * direction * _entity.Speed;
        _rigidbody2D.velocity = new Vector2(velocity.x, _rigidbody2D.velocity.y);
    }
    public void IncreaseByUpVector()
    {
        var jumpVelocity = Vector3.up * 30f;
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x,jumpVelocity.y);
    }
    public void SetDefault()
    {
        var xVelocty = new Vector2(0, _rigidbody2D.velocity.y); 
        _rigidbody2D.velocity = xVelocty;
    }
}
