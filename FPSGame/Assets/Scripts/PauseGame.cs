using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    public Transform pausedMenu;
    public Transform fade;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}
    
    public void Pause()
    {
        if (pausedMenu.gameObject.activeInHierarchy == false)
        {
            fade.gameObject.SetActive(true);
            pausedMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            fade.gameObject.SetActive(false);
            pausedMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
