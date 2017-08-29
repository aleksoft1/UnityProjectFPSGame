using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterGunController : MonoBehaviour {
    public GameObject bullet;
    public float fireRate = 2f;
    public Transform bulletSpawnPoint;

    private float secondsSinceLastFire = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        secondsSinceLastFire += Time.deltaTime;
        if (secondsSinceLastFire >= fireRate)
        {
            GameObject currenBullet = Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Destroy(currenBullet, 5);
            secondsSinceLastFire = 0;
        }
    }
}
