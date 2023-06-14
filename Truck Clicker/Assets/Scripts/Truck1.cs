using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck1 : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
     {
        if (transform.position.y <= 120)
        {
           transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
        } else 
        {
            transform.position = new Vector3(transform.position.x, -110, transform.position.z);
            Controller.Money = Controller.Money + 1;
        }
    }
}
