using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Borders))]
public class EnemySpawner : MonoBehaviour
{
    private Borders _levelBorders;
    private Transform _transform;
    
    [SerializeField] private float _spawnPeriod;
    [SerializeField] private Entity _toInstantiatePrefab;
    [SerializeField] private Transform _enemyParent;

    private float _timer;
    
    private Vector3 _rightBorder => _levelBorders.MaxScreenBounds;
    private Vector3 _instantiatePosition;
    
    private void Start()
    {
        _levelBorders = GetComponent<Borders>();
        _transform = GetComponent<Transform>();
        _instantiatePosition = new Vector3(_rightBorder.x + 3f, _transform.position.y,0);
        _timer = _spawnPeriod;
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _spawnPeriod)
        {
            Spawn();
            _timer = 0;
        }
    }
    private void Spawn()
    {
        var enemy = Instantiate(_toInstantiatePrefab, _instantiatePosition, Quaternion.identity);
        enemy.CachedTransform.parent = _enemyParent;
    }
    
}
