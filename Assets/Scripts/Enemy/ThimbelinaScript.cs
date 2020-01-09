using UnityEngine;
using System.Collections;

public class ThimbelinaScript : MonoBehaviour
{
    public GameObject explosion; //use for explosion
    //public GameObject playerExplosion;  //use for explosion
//    public int scoreValue;
    private GameController gameController;
    private PlayerHealth healthBoundary;
    public GameObject ThimbelinaCharacter;
    public int healthValue;


    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        Instantiate(explosion, transform.position, transform.rotation);
        //if(other.tag == "Player")
        //{
        //Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        //GameObjectPoolController.GameOver();
        //}
//        healthBoundary.ResetHealth(healthValue);
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}