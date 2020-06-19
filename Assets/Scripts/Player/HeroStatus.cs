using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Не знаю на счёт этого класса, он занимается тем, что реагирует на событие когда игрок подбирает монетки. Как его назвать правильно.
/// </summary>
public class HeroStatus : MonoBehaviour
{
    [SerializeField] private EventManager _eventManager;
    [SerializeField] private Hero _hero;
    
    private void OnEnable()
    {
        _eventManager.CoinPickedUp += SetCoinsValue;
        _eventManager.HeartPickedUp += SetHealthValue;
    }
    private void SetCoinsValue()
    {
        _hero.Coins += 10;
        if (_hero.Coins == 50)
        {
            if (_hero.Health < 100)
            {
                if (_hero.Health + 30 > 100)
                {
                    _hero.Health = 100;
                    return;
                }
                _hero.Health += 30;
            }
            _hero.Coins = 0;
        }
    }
    private void SetHealthValue()
    {
        if (_hero.Health < 100)
        {
            if (_hero.Health + 20 > 100)
            {
                _hero.Health = 100;
                return;
            }
            _hero.Health += 20;
        }
    }
}
