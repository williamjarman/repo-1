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
        transform.LookAt(turret.transform.position);
        transform.position += transform.forward * Time.deltaTime * speed;
        
    }
}
