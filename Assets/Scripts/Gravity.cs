using UnityEngine;
using System.Collections;
using System;

public class Gravity : MonoBehaviour {

    private Rigidbody rigidbody;
    private System.Random rnd;
    private float rand, speed;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rnd = new System.Random(Guid.NewGuid().GetHashCode());
        speed = -0.3f;

    }
	
	// Update is called once per frame
	void Update () {
        rand = rnd.Next(1, 1000) / 400.0f;
        rigidbody.velocity = new Vector3(0, speed * rand, 0);
    }
}
