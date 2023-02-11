using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour {

  public EnemyProducer enemyProducer;
  public GameObject playerPrefab;
  float size = Settings.UpdateSize;

	void Start () {
    var player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    player.onPlayerDeath += onPlayerDeath;
    
	}
	
  void onPlayerDeath(Player player) {
    enemyProducer.SpawnEnemies(false);
    Destroy(player.gameObject);

    Invoke("restartGame", 3);
  }

  void restartGame() {
    var enemies = GameObject.FindGameObjectsWithTag("Enemy");
    foreach (var enemy in enemies)
    {
      Destroy(enemy);
    }

    var playerObject = Instantiate(playerPrefab, new Vector3(size, size, size), Quaternion.identity) as GameObject;
    playerPrefab.transform.localScale = new Vector3(size,size,size);
    player.transform.localPosition = new Vector3(player.transform.localPosition.x, 0.5f * size, player.transform.localPosition.z);
    var cameraRig = Camera.main.GetComponent<CameraRig>();
    cameraRig.target = playerObject;
    enemyProducer.SpawnEnemies(true);
    playerObject.GetComponent<Player>().onPlayerDeath += onPlayerDeath;
  }
}
