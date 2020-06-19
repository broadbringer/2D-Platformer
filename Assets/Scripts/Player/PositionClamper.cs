using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionClamper : MonoBehaviour
{
    [SerializeField] private Borders _levelBorders;
    private SpriteRenderer _spriteRenderer;
    private float objectWidth;
    private float objectHeight;

    public Transform CachedTransform;
    
    private void Start()
    {
        CachedTransform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        objectWidth = _spriteRenderer.bounds.size.x/2;
        objectHeight = _spriteRenderer.bounds.size.y / 2;
        
    }
    private void LateUpdate()
    {
        Vector3 tempPosition = CachedTransform.position;
        tempPosition.x = Mathf.Clamp(tempPosition.x, _levelBorders.MinScreenBounds.x + objectWidth,_levelBorders.MaxScreenBounds.x - objectWidth
            );
        tempPosition.y = Mathf.Clamp(tempPosition.y, -12f, _levelBorders.MaxScreenBounds.y - objectHeight);
        CachedTransform.position = tempPosition;
    }
}
