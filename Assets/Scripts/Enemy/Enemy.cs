using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private EntityVelocity _entityVelocity;
    [SerializeField] private BulletCreator _bulletCreator;
    [SerializeField] private EnemyDestroyer _enemyDestroyer;
    private Animator _animator;
    
    private float _time;
    
    private void Start()
    {
        Health = 100;
        Speed = 3f;
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move(-1);
        _time += Time.deltaTime;
        if (_time > 3)
        {
            Shoot();
            _time = 0;
        }
    }
    public override void Move(float direction)
    {
        _entityVelocity.IncreaseByRightVector(direction);
    }

    public override void Jump()
    {
        //If you wanna realize jump
    }

    public override void Shoot()
    {
        _animator.SetTrigger("Shoot");
        _bulletCreator.Create();
    }

    public override void Death()
    {
        if (Health <= 0)
        {
            _animator.SetTrigger("Death");
            _enemyDestroyer.Invoke("DestroyObject", .5f);
        }
    }
}
