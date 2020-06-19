using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PositionValidator))]
public class EnemyDestroyer : MonoBehaviour
{
    private PositionValidator _positionValidator;
    private Linker _linker;
    
    private void  Start()
    {
        _positionValidator = GetComponent<PositionValidator>();
        _linker = GetComponentInParent<Linker>();
    }
    private void Update()
    {
        if (!_positionValidator.IsValidPosition())
        {
            Destroy(gameObject);
        }
    }
    private void DestroyObject()
    {
        _linker.SceneEventManager.OnEnemyDie?.Invoke();
        Destroy(gameObject);
    }
}
