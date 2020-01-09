using UnityEngine;
using System.Collections;

public class EnemyCharacter : MonoBehaviour
{
    public GameObject explosion; //use for explosion
    //public GameObject playerExplosion;  //use for explosion
    public int scoreValue;
    private GameController gameController;
    private PlayerHealth healthBoundary;
    public GameObject PlayerHealth;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
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
        anim.Play("Dancing", -1, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        Instantiate (explosion, transform.position, transform.rotation);





        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
        anim.Play("Knock Out", -1, 0);
        PlayerHealth.SetActive(false);
        PlayerHealth.SetActive(true);
//        healthBoundary.ResetHealth();
        

    }
}