using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate: MonoBehaviour
{
	public float movementSpeed = 10;

	void Update(){

		transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

	}
}