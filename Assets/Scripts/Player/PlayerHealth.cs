using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
	public int startingHealth;                            // The amount of health the player starts the game with.
	public float currentHealth;                                   // The current health the player has.
	public GUIText healthText;
    GameObject otherGameObject;
    public GameObject Barrel;
    public GameObject ScoreText;
    public GameObject HealthText;
    public GameObject GameOverLose;
    public GameObject GameOverWin;
    public GameObject GameController;
    public GameObject EnemyCharacter;
//    public GameObject HealthDanger;
//    public GameObject HealthRapidUI;

	public GameObject healthHeartRight1;
	public GameObject healthHeartBottom1;
	public GameObject healthHeartLeft1;

	public GameObject healthHeartRight2;
	public GameObject healthHeartBottom2;
	public GameObject healthHeartLeft2;

	public GameObject healthHeartRight3;
	public GameObject healthHeartBottom3;
	public GameObject healthHeartLeft3;

	public GameObject healthHeartRight4;
	public GameObject healthHeartBottom4;
	public GameObject healthHeartLeft4;


    GameController gameController;


  //  void Start() {
  //      currentHealth = startingHealth;
  //      SetHealthText();
		//GameObject otherGameObject = GameObject.Find("GameController");
  //      gameController = otherGameObject.GetComponent<GameController>();
  //  }

    private void OnEnable()
    {
        startingHealth = 12;
        currentHealth = startingHealth;
        SetHealthText();
        GameObject otherGameObject = GameObject.Find("GameController");
        gameController = otherGameObject.GetComponent<GameController>();
//		gameController.score = 0;

        //HealthDanger.SetActive(false);
        //HealthRapidUI.SetActive(false);

        healthHeartRight1.SetActive(true);
		healthHeartBottom1.SetActive(true);
		healthHeartLeft1.SetActive(true);

		healthHeartRight2.SetActive(true);
		healthHeartBottom2.SetActive(true);
		healthHeartLeft2.SetActive(true);

		healthHeartRight3.SetActive(true);
		healthHeartBottom3.SetActive(true);
		healthHeartLeft3.SetActive(true);

		healthHeartRight4.SetActive(true);
		healthHeartBottom4.SetActive(true);
		healthHeartLeft4.SetActive(true);
    }

    //public void Update()
    //{
    //    if (currentHealth == 1 && gameController.score >= 50 && gameController.score <= 100)
    //    {
    //        HealthRapidUI.SetActive(true);
    //        HealthDanger.SetActive(false);

    //    }
    //}

    public void TakeDamage(float amount) {
        currentHealth -= amount;
        SetHealthText();

        if (currentHealth == 11) {
			healthHeartRight4.SetActive(false);
		}
		if (currentHealth == 10) {
			healthHeartBottom4.SetActive(false);
		}
		if (currentHealth == 9) {
			healthHeartLeft4.SetActive(false);
		}
		if (currentHealth == 8) {
			healthHeartRight3.SetActive(false);
		}
		if (currentHealth == 7) {
			healthHeartBottom3.SetActive(false);
		}
		if (currentHealth == 6) {
			healthHeartLeft3.SetActive(false);
		}
		if (currentHealth == 5) {
			healthHeartRight2.SetActive(false);

		}
		if (currentHealth == 4) {
			healthHeartBottom2.SetActive(false);

		}
		if (currentHealth == 3) {
			healthHeartLeft2.SetActive(false);

		}
		if (currentHealth == 2) {
			healthHeartRight1.SetActive(false);

		}
		if (currentHealth == 1) {
			healthHeartBottom1.SetActive(false);
            //HealthDanger.SetActive(true);

		}


        //        if (EnemyCharacter)

        if (currentHealth == 0) {

			if (gameController.score < 50) {

                Barrel.SetActive(false);
                ScoreText.SetActive(false);
                HealthText.SetActive(false);
                EnemyCharacter.SetActive(false);
				healthHeartLeft1.SetActive(false);
//				Destroy (healthHeart1);
                GameOverLose.SetActive(true);
                GameOverWin.SetActive(false);
//                gameController.score = 0;
                GameController.SetActive(false);
//                currentHealth = 100;
            }
			else {

                Barrel.SetActive(false);
                ScoreText.SetActive(false);
                HealthText.SetActive(false);
                EnemyCharacter.SetActive(false);
				healthHeartLeft1.SetActive(false);
//				Destroy (healthHeart1);
                GameOverLose.SetActive(false);
                GameOverWin.SetActive(true);
//                gameController.score = 0;
                GameController.SetActive(false);
//                currentHealth = 100;
            }
		}
	}

	public void SetHealthText(){
//		float my_health = currentHealth / startingHealth;
//		healthText.transform.localScale = new Vector3 (Mathf.Clamp (my_health, 0f, 1f), healthText.transform.localScale.y, healthText.transform.localScale.z);
		healthText.text = "Health: " + currentHealth;
	}

    public void ResetHealth()
    {
        currentHealth = startingHealth;
        SetHealthText();
    }

    //public void ResetHealth(float amount)
    //{
    //    currentHealth = startingHealth;
    //}
}