using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelItemCollection : MonoBehaviour
{
    [SerializeField] private List<GameObject> _items;
    
    public List<GameObject> Items => _items;
   
}
