using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Entity
{
   [SerializeField] private EntityVelocity _entityVelocity;
   [SerializeField] private BulletCreator _bulletCreator;
   [SerializeField] private EventManager _eventManager;

   private EntitySprite _heroSprite;
   private PositionClamper _positionClamper;
   private SpriteRenderer _sprite;
   
   /// <summary>
   /// Есть ли смысл выносить счетчик KilledEnemy и Coins в какой-то другой класс, который описывает очки персонажа или не знаю как назвать правильно.
   /// </summary>
   public int Coins { get; set; }
   public int KilledEnemy { get; set; }
   private void Start()
   {
      Health = 100;
      Speed = 10f;
      _heroSprite = GetComponent<EntitySprite>();
      _positionClamper = GetComponent<PositionClamper>();
   }
   
   public override void Move(float direction)
   {
      _entityVelocity.IncreaseByRightVector(direction);
      _heroSprite.Flip(direction);
   }

   public void StopMove()
   {
      _entityVelocity.SetDefault();
   }
   public override void Jump()
   {
      _entityVelocity.IncreaseByUpVector();
   }

   public override void Shoot()
   {
      _bulletCreator.Create();
   }

   public override void Death()
   {
      if (Health <= 0)
      {
         Destroy(gameObject);
         _eventManager.OnHeroDeath?.Invoke();
      }
   }
}
