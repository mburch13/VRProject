using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public ShaderVariantCollection MenuCanvas;
    public GameObject MainMenuCanvas;
    public GameObject SettingsMenuCanvas;
    public GameObject InstructionsMenuCanvas;

    private GameController myGameController;
	private PlayerHealth myPlayerHealth;

    // Use this for initialization
    void Start()
    {
        myGameController = GetComponent<GameController>();
		myPlayerHealth = GetComponent<PlayerHealth> ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        MainMenuCanvas.SetActive(false);
        SettingsMenuCanvas.SetActive(false);
        InstructionsMenuCanvas.SetActive(false);
        myGameController.enabled = true;
		myPlayerHealth.enabled = true;

    }

    public void InstructionsButton()
    {
        MainMenuCanvas.SetActive(false);
        SettingsMenuCanvas.SetActive(false);
        InstructionsMenuCanvas.SetActive(true);
    }

    public void SettingsButton()
    {
        MainMenuCanvas.SetActive(false);
        SettingsMenuCanvas.SetActive(true);
        InstructionsMenuCanvas.SetActive(false);
    }

    public void BackButton()
    {
        MainMenuCanvas.SetActive(true);
        SettingsMenuCanvas.SetActive(true);
        InstructionsMenuCanvas.SetActive(false);
    }
}
