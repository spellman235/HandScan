using UnityEngine;
using System.Collections;

public class DestroyCubes : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<KillPlayer>())
        {
            other.gameObject.GetComponent<KillPlayer>().enabled = false;
        }
        if (!other.gameObject.CompareTag("Palm") && !other.gameObject.CompareTag("Player"))
            Destroy(other.gameObject, 1f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<KillPlayer>())
        {
            other.gameObject.GetComponent<KillPlayer>().enabled = false;
        }
        if (!other.gameObject.CompareTag("Palm") && !other.gameObject.CompareTag("Player"))
            Destroy(other.gameObject, 1f);
    }

}
