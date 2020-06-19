using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIValue : MonoBehaviour
{
   
   
   [SerializeField] private Hero _hero;
   [SerializeField] private TextMeshProUGUI _health;
   [SerializeField] private TextMeshProUGUI _coins;
   [SerializeField] private TextMeshProUGUI _killedEnemy;
   [SerializeField] private EventManager _eventManager;

   private void OnEnable()
   {
      _eventManager.OnEnemyDie += ChangeKilledEnemyValue;
   }

   private void OnDisable()
   {
      _eventManager.OnEnemyDie -= ChangeKilledEnemyValue;
   }
   private void Update()
   {
      _health.text = _hero.Health.ToString();
      if (_hero.Health < 0)
      {
         _health.text = 0.ToString();
      }
      _coins.text = _hero.Coins.ToString();
      _killedEnemy.text = _hero.KilledEnemy.ToString();
   }

   private void ChangeKilledEnemyValue()
   {
      _hero.KilledEnemy++;
   }
}
