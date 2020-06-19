using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart: MonoBehaviour, IPickable
{
    private EventManager _eventManager;

    private void Start()
    {
        _eventManager = GetComponentInParent<Linker>().SceneEventManager;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        NotifyAboutPickUp();
        Destroy(gameObject);
    }
    public void NotifyAboutPickUp()
    {
        _eventManager.HeartPickedUp?.Invoke();
    }
}
