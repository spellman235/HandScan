using UnityEngine;
using System.Collections;

public class DealDamageToMe : MonoBehaviour
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
            Player player = GetComponent<Player>();
            Health hp = GetComponent<Health>();
            //Take damage if the player isnt already currently invincible
            if (!player.GetInvincible())
            {
                //Deal damage, knockback
                //get amt (1), dmgAmount(1) from Enemy/Hazard
                player.SetInvTime(1.5f);
                hp.takeDamage(dmgAmount, knockback);
                
                player.setBlink();
            }



        }
    }

    //Same code just make sure it happens
    public void OnTriggerStay(Collider other)
    {

        //Check for player collision
        if (other.gameObject.layer == 13)
        {
            //Find components necessary to take damage and knockback
            Player player = GetComponent<Player>();
            Health hp = GetComponent<Health>();
            //Take damage if the player isnt already currently invincible
            if (!player.GetInvincible())
            {
                Debug.Log("hey");

                //Deal damage, knockback
                //get amt (1), dmgAmount(1) from Enemy/Hazard
                player.SetInvTime(1.5f);
                hp.takeDamage(dmgAmount, knockback);
                player.setBlink();
               
            }



        }
    }
}

