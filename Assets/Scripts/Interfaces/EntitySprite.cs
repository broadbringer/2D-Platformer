using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySprite : MonoBehaviour
{
    private SpriteRenderer _sprite;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }
    public void Flip(float direction)
    {
        if (direction > 0)
        {
            if (_sprite.flipX)
            {
                _sprite.flipX = false;
            }
        }
        else if(direction <0)
        {
            if (!_sprite.flipX)
            {
                _sprite.flipX = true;
            }
        }
    }
    
}
