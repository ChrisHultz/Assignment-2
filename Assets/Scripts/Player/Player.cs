using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

  public int health;
  public event Action<Player> onPlayerDeath;

  void OnCollisionEnter (Collision col) {
      Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
      if(enemy) {
        collidedWithEnemy(enemy);
      }
  }

  void collidedWithEnemy(Enemy enemy) {
    enemy.Attack(this);
    if(health <= 0) {
      if(onPlayerDeath != null) {
        onPlayerDeath(this);
      }
    }
  }
}
