using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck1 : MonoBehaviour
{
    private static int Running;
    

    // Start is called before the first frame update
    void Start()
    {
        Running = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (Running == 0){
            Running = 1;
            if (Controller.T1Manager == 0){
                Controller.Money = Controller.Money - 1;
            }
        } else {
        transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
        }
    }

    void FixedUpdate()
     {
        if (Running == 1 || Controller.T1Manager == 1){
            if (transform.position.y <= 120){
                transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
            } else {
                transform.position = new Vector3(transform.position.x, -110, transform.position.z);
                Controller.Money = Controller.Money + 2;
                Running = 0;
                if (Controller.T1Manager == 1){
                    Controller.Money -= 1;
                }
            }
        }
    }
}
