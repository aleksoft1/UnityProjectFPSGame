using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour {
    public int health = 100;
    private Slider healthSlider;
    // Use this for initialization
    void Start () {
        healthSlider = GetComponentInChildren<Slider>();
        healthSlider.maxValue = health;
    }

    public void TakeDamage(int amount) {
        this.health -= amount;
        if (this.health <= 0) {
            Score.points += 10;
            Destroy(transform.gameObject);
        }
        healthSlider.value = health;
    }
}
