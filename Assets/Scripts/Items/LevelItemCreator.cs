using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItemCreator : MonoBehaviour
{
    [SerializeField] private List<Transform> _placeablePositions;
    [SerializeField] private Transform _itemsParent;
    
    private LevelItemCollection _itemCollection;
    private float _timer;
    private float _delay = 8;
    
    private void Start()
    {
        _itemCollection = GetComponent<LevelItemCollection>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            CreateItem();
            _timer = 0;
        }
    }
    private void CreateItem()
    {
        var itemIndex = Random.Range(0, _itemCollection.Items.Count);
        var placeIndex = Random.Range(0, _placeablePositions.Count);
        var temp = Instantiate(_itemCollection.Items[itemIndex], _placeablePositions[placeIndex].position, Quaternion.identity);
        temp.transform.parent = _itemsParent;
    }
}
