using UnityEngine;
using System.Collections;
using System;

public class BoxGenerator : MonoBehaviour {

    public GameObject[] Cubes = new GameObject[3];
    private System.Random rnd;
    private float spawn_CD, rand, t;
    private Vector3 offset;


    // Use this for initialization
    void Start () {
        //A nice random random seed
        rnd = new System.Random(Guid.NewGuid().GetHashCode());
        spawn_CD = 4;
        offset = new Vector3(0.45f, 0, 0);
        t = 1;
    }

    // Update is called once per frame
    void Update () {
        if (spawn_CD >= (300 - t)/100)
        {
            rnd = new System.Random(Guid.NewGuid().GetHashCode());
            t = rnd.Next(0, 250);
            rand = (rnd.Next(0, 100) - 50)/50.0f;
            GameObject spawnCube = Instantiate(Cubes[rnd.Next(0, 9) % 3], transform.position + rand * offset, transform.rotation) as GameObject;
            spawn_CD = 0;
        }
        spawn_CD += Time.deltaTime;
	}
}
