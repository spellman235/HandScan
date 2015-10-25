using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

    private SpriteRenderer sprRend;

	// Use this for initialization
	void Start () {
        sprRend = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        Color color = sprRend.color;
        color.a *= 0.8f;
        sprRend.material.color = color;
	}
}
