using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Borders))]
public class PositionValidator : MonoBehaviour
{
    private Borders _levelBorder;
    private Transform _cachedTransform;
    private void  Start()
    {
        _levelBorder = GetComponent<Borders>();
        _cachedTransform = GetComponent<Transform>();
    }
    public bool IsValidPosition()
    {
        if (_cachedTransform.position.x > _levelBorder.MinScreenBounds.x) return true;
        return false;
    }
}
