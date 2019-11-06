using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wjminion : MonoBehaviour
{
    public GameObject turret;
    public float speed = 5;




    private void Start()
    {
        turret = GameObject.Find("turret");
    }

    // Update is called once per frame
    void Update()
    {
        if (turret != null)
        {
            transform.LookAt(turret.transform.position);
        }

       


        transform.position += transform.forward * Time.deltaTime * speed;

    }



    private void OnCollisionEnter(Collision collision)
    {   //check its a turret
        if (collision.gameObject.tag == ("turret"))
        {

            //hit turret
            Destroy(collision.gameObject);
            //delete turret
            Destroy(gameObject);

        }

    }
}


