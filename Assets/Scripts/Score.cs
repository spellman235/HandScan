using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {


    private float x, invTime;

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = x.ToString();
        x = 10;
        invTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
        invTime -= Time.deltaTime;
        //Debug.Log(x);
        if(x <= 0)
        {
            Destroy(FindObjectOfType<HandController>());
        }

    }

    public void setInv(float som)
    {
        if(invTime <= 0)
        invTime = som;
    }

    public float modX(float subtract)
    {
        if(invTime <= 0)
        x -= subtract;

        return x;
    }
}
