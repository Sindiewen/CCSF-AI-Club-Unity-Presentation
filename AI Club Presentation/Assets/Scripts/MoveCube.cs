using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public float speedx;
    public float speedz;

    private Vector3 movement;

    private void Awake()
    {
        
    }

    // Use this for initialization
    private void Start ()
    {
		
	}
	
	// Update is called once per frame
	private void Update ()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        transform.Translate(movement.x * speedx, 0, movement.z * speedz);
        Debug.Log("Moving " + movement.x * speedx + " " + movement.z * speedz);
	}
}
