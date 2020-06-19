using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IPickable
{
    private EventManager _eventManager;

    private void Start()
    {
        _eventManager = GetComponentInParent<Linker>().SceneEventManager;
    }
    public void NotifyAboutPickUp()
    {
        _eventManager.CoinPickedUp?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        NotifyAboutPickUp();
        Destroy(gameObject);
    }
}
