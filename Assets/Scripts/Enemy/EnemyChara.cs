using UnityEngine;
using System.Collections;

public class EnemyChara : MonoBehaviour
{
    public GameObject explosion; //use for explosion
    //public GameObject playerExplosion;  //use for explosion
    public int scoreValue;
    private GameController gameController;
    private PlayerHealth healthBoundary;
    public GameObject PlayerHealth;
    public Animator anim;
    private CapsuleCollider capsuleCollider;



    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
        anim.SetTrigger("Alive");
    }

    private void OnEnable()
    {
        capsuleCollider.enabled = true;
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
        anim.SetTrigger("Knocked Out");
        gameController.AddScore(scoreValue);
        capsuleCollider.enabled = false;
        PlayerHealth.SetActive(false);
        PlayerHealth.SetActive(true);
        //        Destroy(other.gameObject);
        //        Destroy(gameObject);
    }
}