using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Palm") || other.gameObject.layer == 13)
        {
            Destroy(FindObjectOfType<HandController>().gameObject);
            ParticleSystem partSys = Instantiate(ps, transform.position, transform.rotation) as ParticleSystem;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Palm") || other.gameObject.layer == 13)
        {
            Destroy(FindObjectOfType<HandController>().gameObject);
            ParticleSystem partSys = Instantiate(ps, transform.position, transform.rotation) as ParticleSystem;
            Destroy(gameObject);
        }
    }
}
