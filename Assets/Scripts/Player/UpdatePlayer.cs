using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatePlayer : MonoBehaviour {
    public GameObject player;
    float size = Settings.UpdateSize;
    private static Color thing = Settings.passColor;

    void FixedUpdate() {
        player.GetComponent<Renderer>().material.color = thing;
        player.transform.localScale = new Vector3(size,size,size);
        player.transform.localPosition = new Vector3(player.transform.localPosition.x, 0.5f * size, player.transform.localPosition.z);
    }
}
