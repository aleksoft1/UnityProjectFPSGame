using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public int health = 100;
    public Slider healthSlider;
    // Use this for initialization
    void Start () {
        healthSlider.maxValue = health;
    }

    public void TakeDamage(int amount)
    {
        this.health -= amount;
        if (this.health <= 0) {
            Debug.Log("You are dead");
        }
        healthSlider.value = health;
    }

}
