using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {
    public Transform pausedMenu;
    public Transform settingsMenu;

    public PlayerController playerController;
    public MonsterGunController monsterGunController;

    public Slider playerSpeedSlider;
    public Slider playerJumpHeightSlider;
    public Slider monsterFireRateSlider;

    public Dropdown modeDropDownMenu;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenSettings()
    {
        pausedMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(true);
    }

    public void CloseSettings()
    {
        pausedMenu.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(false);
    }

    public void setPlayerSpeed()
    {
        playerController.speed = playerSpeedSlider.value;
    }

    public void setPlayerJumpHeight()
    {
        playerController.jump = playerJumpHeightSlider.value;
    }

    public void setMonsterFireRate()
    {
        monsterGunController.fireRate = monsterFireRateSlider.value;
    }

    public void setMode()
    {
        switch (modeDropDownMenu.value) {
            case 0:
                Bullet.enemyBulletPower = 10;
                break;
            case 1:
                Bullet.enemyBulletPower = 50;
                break;
            case 2:
                Bullet.enemyBulletPower = 100;
                break;
        }
    }
}
