using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _instancePosition;

    private void Start()
    {
        _instancePosition = GetComponent<Transform>();
    }
    public void Create()
    {
        var bullet = Instantiate(_bullet, _instancePosition.position, Quaternion.identity);
        bullet.transform.SetParent(_instancePosition);
    }
}
