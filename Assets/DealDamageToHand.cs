using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DealDamageToHand : MonoBehaviour
{
    public float dmgAmount = 1;
    public float knockback = 10;

    // Use this for initialization
    void Start()
    {

        //GetComponent Enemy or Hazard
        //get damage amount from Enemy or Hazard
        //Enemy can change his damage amount
    }

    // Update is called once per frame
    void Update()
    {

    }

    //If we make colliders appear on attacks, create OnCollisionEnter and OnTriggerEnter collisions
    //destroy collider after they hit something

    public void OnCollisionStay(Collision other)
    {
        //Check for player collision
        if (other.gameObject.layer == 13)
        {
            //Find components necessary to take damage and knockback
            Text t = GameObject.Find("HealthText").GetComponent<Text>();
            //Take damage if the player isnt already currently invincible
            t.GetComponent<Score>().modX(dmgAmount);
            t.GetComponent<Score>().setInv(1f);
          
        }
    }

    //Same code just make sure it happens
    public void OnTriggerStay(Collider other)
    {

        if (other.gameObject.layer == 13)
        {
            //Find components necessary to take damage and knockback
            Text t = GameObject.Find("HealthText").GetComponent<Text>();
            //Take damage if the player isnt already currently invincible
            t.GetComponent<Score>().modX(dmgAmount);
            t.GetComponent<Score>().setInv(1f);
        }
    }
}

