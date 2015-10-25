using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TurnBlue : MonoBehaviour {

    public Material blueMaterial;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("LevelObject"))
        {
            GetComponent<MeshRenderer>().material = blueMaterial;
            //var guiText = FindObjectOfType<Text>();
            //guiText.text = (++guiText.GetComponent<Score>().x).ToString();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("LevelObject"))
        {
            GetComponent<MeshRenderer>().material = blueMaterial;
            //var guiText = FindObjectOfType<Text>();
            //guiText.text = (++guiText.GetComponent<Score>().x).ToString();
        }
    }
}
