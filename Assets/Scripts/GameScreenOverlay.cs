using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreenOverlay : MonoBehaviour {

    public GameObject RapidFire;
    public GameObject HealthLow;
    public GameObject ComboUI;
    public GameObject HealthBox;

    private PlayerHealth thePlayerHealth;
    private GameController theScore;

	// Use this for initialization
	void Start ()
    {
        theScore = GetComponent<GameController>();
        thePlayerHealth = HealthBox.GetComponent<PlayerHealth>();
    }

    //      theScore.score
	
	// Update is called once per frame
	void Update () {

        if (thePlayerHealth.currentHealth <= 3)
        {
            HealthLow.SetActive(true);
        }

        if (thePlayerHealth.currentHealth == 12)
        {
            HealthLow.SetActive(false);
        }

        if (theScore.rapidScore < 50)
        {
            RapidFire.SetActive(false);
        }

        if (theScore.rapidScore >= 50)
        {
            RapidFire.SetActive(true);
        }

        //if (theScore.rapidScore >= 100)
        //{
        //    RapidFire.SetActive(false);
        //}

        if (theScore.rapidScore >= 50 && theScore.rapidScore < 100 && thePlayerHealth.currentHealth <= 3)
        {
            ComboUI.SetActive(true);
            RapidFire.SetActive(false);
            HealthLow.SetActive(false);
        }

        else
        {
            ComboUI.SetActive(false);
        }


    }
}
