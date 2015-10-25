using UnityEngine;
using System.Collections;

public class FollowHand : MonoBehaviour
{

    public GameObject l;
    private SkeletalHand hand;
    private Vector3 offset;
    private bool handExists;
    private float create_CD;

    // Use this for initialization
    void Start()
    {
        create_CD = 1;
        handExists = false;
        hand = null;
        offset = new Vector3(0, -0.1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (create_CD > 0.05f)
        {
            if (FindObjectOfType<SkeletalHand>())
            {
                hand = FindObjectOfType<SkeletalHand>();
                GameObject lightobj = Instantiate(l, hand.GetPalmCenter() + offset, transform.rotation) as GameObject;
                Destroy(lightobj, 0.7f);
                hand = null;
            }
        }
        create_CD += Time.deltaTime;
    }



}
