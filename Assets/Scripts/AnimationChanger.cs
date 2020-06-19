using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanger : MonoBehaviour
{
    [SerializeField] private EventManager _eventManager;
    
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _eventManager.OnKeyDown += ChangeTrigger;
        _eventManager.OnMoveKeyDown += ChangeFloat;
    }

    private void OnDisable()
    {
        if (_eventManager.OnKeyDown != null) _eventManager.OnKeyDown -= ChangeTrigger;
        if (_eventManager.OnMoveKeyDown != null) _eventManager.OnMoveKeyDown -= ChangeFloat;
    }
    private void ChangeTrigger(EntityState state)
    {
        switch (state)
        {
            case EntityState.Run:
                _animator.SetTrigger("Run");
                break;
            case EntityState.Attack:
                _animator.SetTrigger("Attack");
                break;
            case EntityState.Hurt:
                _animator.SetTrigger("Hurt");
                break;
            case EntityState.Jump:
                _animator.SetTrigger("Jump");
                break;
            case EntityState.Die:
                _animator.SetTrigger("Die");
                break;
        }
    }

    private void ChangeFloat(float value)
    {
        _animator.SetFloat("Speed",Mathf.Abs(value));
    }
}

public enum EntityState
{
    Idle,
    Run,
    Attack,
    Hurt,
    Jump,
    Die
}