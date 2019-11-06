using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wjbullet : MonoBehaviour
{   //if bullet collides with minion then destroy minion and bullet
    private void OnCollisionEnter(Collision collision)
    {   //check its a minion
        if (collision.gameObject.tag == ("minion"))

            //hit minion
            Destroy(collision.gameObject);
            //delete bullet
            Destroy(gameObject);

    }
}
