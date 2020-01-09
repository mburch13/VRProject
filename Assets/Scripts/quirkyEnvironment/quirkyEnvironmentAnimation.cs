using UnityEngine;
using System.Collections;

public class quirkyEnvironmentAnimation : MonoBehaviour
{
    //public GameObject playerExplosion;  //use for explosion
    private GameController gameController;
    public Animator anim;
    public GameObject barrel;



    void Start()
    {
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
    }

    void Update()
    {
        if (barrel.activeInHierarchy)
        {
            anim.SetTrigger("Active");
            anim.ResetTrigger("Idle");

        }
        if (!barrel.activeInHierarchy)
        {
            anim.SetTrigger("Idle");
            anim.ResetTrigger("Active");
        }
    }
}