using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour {
	public ShaderVariantCollection MenuCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartButton(){
		SceneManager.LoadScene("scene_health");
//		MenuCanvas.enabled = false;
	}

	public void InstructionsButton(){
		SceneManager.LoadScene ("scene_instructions");
	}

    public void SettingsButton()
    {
        SceneManager.LoadScene ("scene_settings");
    }

    public void BackButton(){
		SceneManager.LoadScene ("scene_mainMenu");
	}
}
