using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wjspawner : MonoBehaviour
{
    public GameObject minionPrefab;
    public float timer = 3f;
    // Update is called once per frame
    void Update()
    {
        //this sets a time delay on spawn
        timer -= Time.deltaTime;
        if(timer <=0f)
        {
            timer = 3f;
            //this spawns the minions
        GameObject newminion = Instantiate(minionPrefab, transform.position, transform.rotation);

        }
       
        
    }
}
