﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wjturret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100))

        {
            transform.LookAt(new Vector3(hit.point.x, 0, hit.point.z));

        }
    }
}
