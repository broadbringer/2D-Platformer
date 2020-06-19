using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    /// <summary>
    /// Офигеть, только заметил что у меня тут не события, а простые делегаты. А я ещё думаю, схренали это я могу вызывать события из класса вне...
    /// </summary>
    public Action<EntityState> OnKeyDown;
    public Action<float> OnMoveKeyDown;
    public Action OnEnemyDie;

    public Action HeartPickedUp;
    public Action CoinPickedUp;

    public Action OnHeroDeath;
}
