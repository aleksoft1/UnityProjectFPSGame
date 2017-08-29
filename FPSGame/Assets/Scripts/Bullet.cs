using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public int playerBulletPower = 10;
    public static int enemyBulletPower = 10;
    public float speed = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision) {
        MonsterHealth monsterHealth = collision.gameObject.GetComponent<MonsterHealth>();
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if (monsterHealth != null) {
            monsterHealth.TakeDamage(playerBulletPower);
        }

        if (playerHealth != null) {
            playerHealth.TakeDamage(enemyBulletPower);
        }

        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Enviroment") {
            Destroy(this.gameObject);
        }
    }
}
