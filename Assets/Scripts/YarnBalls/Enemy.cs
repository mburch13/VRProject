using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
	float damage = 1f;

	void Start ()
	{
	}

	void OnTriggerEnter(Collider other)
	{
		other.gameObject.GetComponent<PlayerHealth> ().TakeDamage (damage);
	}
}