using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Borders))]
public class BulletDestroyer : MonoBehaviour
{
    private PositionValidator _positionValidator;
    private Borders _levelBorder;

    private void  Start()
    {
        _positionValidator = GetComponent<PositionValidator>();
        _levelBorder = GetComponent<Borders>();
    }
    private void Update()
    {
        if (!_positionValidator.IsValidPosition())
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collistion)
    {
        Destroy(gameObject);
    }

}
