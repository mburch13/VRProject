using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLastEnemies : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.name == "yarnBallYellow(Clone)")
        //{
        //    Destroy(col.gameObject);
        //}
        //if (col.gameObject.name == "yarnBallBlue(Clone)")
        //{
        //    Destroy(col.gameObject);
        //}
        //if (col.gameObject.name == "yarnBallRed(Clone)")
        //{
        //    Destroy(col.gameObject);
        //}
        //if (col.gameObject.name == "yarnBallPink(Clone)")
        //{
        //    Destroy(col.gameObject);
        //}

        if (col.collider.gameObject.tag == "Hazard")
        {
            Destroy(col.collider.gameObject);
        }
    }
}