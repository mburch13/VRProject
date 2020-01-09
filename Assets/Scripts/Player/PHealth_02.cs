using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PPlayerHealth : MonoBehaviour
{
	public int startingHealth = 100;                            // The amount of health the player starts the game with.
	public float currentHealth;                                   // The current health the player has.
	public GUIText healthText;
    GameObject otherGameObject;

    GameController gameController;

    void Start() {
        currentHealth = startingHealth;
        SetHealthText();
		GameObject otherGameObject = GameObject.Find("GameController");
        gameController = otherGameObject.GetComponent<GameController>();
    }

	public void TakeDamage(float amount){
		currentHealth -= amount;
		SetHealthText();
		if (currentHealth == 0) {
			if (gameController.score < 10) {
				SceneManager.LoadScene ("scene_gameOver");
			}
			else {
				SceneManager.LoadScene ("scene_gameOver_win");
			}
		}
	}

	public void SetHealthText(){
//		float my_health = currentHealth / startingHealth;
//		healthText.transform.localScale = new Vector3 (Mathf.Clamp (my_health, 0f, 1f), healthText.transform.localScale.y, healthText.transform.localScale.z);
		healthText.text = "Health: " + currentHealth;
	}
}