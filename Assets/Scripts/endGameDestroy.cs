using UnityEngine;
using System.Collections;

//[System.Serializable]
//public class killZone
//{
//    public float xMin, xMax, zMin, zMax;
//}

public class endGameDestroy : MonoBehaviour
{
    //    private Rigidbody rb;
    GameController gameController;
    public GameObject killZoneBox;
    public Transform killSpawn;

    void OnEnable()
    {
        Instantiate(killZoneBox);
    }

//    void Start()
//    {
//            rb = GetComponent<Rigidbody>();
//        GameObject otherGameObject = GameObject.Find("GameController");
//        gameController = otherGameObject.GetComponent<GameController>();
//        rapidFire.SetActive(false);

//    }
//    public float speed;
//    public float tilt;
//    public Boundary boundary;

//    public GameObject shot;
//    public Transform shotSpawn;
//    public float fireRate;
//    private float nextFire;

//    void Update()
//    {
//        if (Input.GetButton("Fire1") && Time.time > nextFire)
//        {
//            nextFire = Time.time + fireRate;
//            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
//        }
//        if (gameController.score >= 50)
//        {
//            fireRate = .5f;
//            rapidFire.SetActive(true);
//        }
//        if (gameController.score >= 100)
//        {
//            fireRate = 1f;
//            rapidFire.SetActive(false);
//        }

//    }

//    void FixedUpdate()
//    {
//        float moveHorizontal = Input.GetAxis("Horizontal");
//        float moveVertical = Input.GetAxis("Vertical");

//                Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
//                rb.velocity = movement * speed;
//                rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
//    }
}