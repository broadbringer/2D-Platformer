using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Hero _hero;
    [SerializeField] private EventManager _eventManager;
    
    private void Update()
    {
        HandleInput();
    }
    private void HandleInput()
    {
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            var direction = Input.GetAxisRaw("Horizontal");
            _hero.Move(direction);
            _eventManager.OnMoveKeyDown?.Invoke(direction);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _hero.Jump();
            _eventManager.OnKeyDown?.Invoke(EntityState.Jump);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _hero.Shoot();
            _eventManager.OnKeyDown?.Invoke(EntityState.Attack);
        }
        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
           _hero.StopMove();
        }
        
    }
}
