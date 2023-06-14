using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck4 : MonoBehaviour
{
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
        if (Controller.Trucks >= 3)
        {
            if (transform.position.y <= 60)
            {
               transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            } else 
            {
                transform.position = new Vector3(transform.position.x, -58, transform.position.z);
                Controller.Money = Controller.Money + 1;
            }
        }
    }
}
