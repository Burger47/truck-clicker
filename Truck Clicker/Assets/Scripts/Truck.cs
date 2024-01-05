using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Truck : MonoBehaviour

{

    public int Running;
    public int Speed;

    // Start is called before the first frame update
    void Start()
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
                transform.position = new Vector3(transform.position.x, transform.position.y + 1*Speed, transform.position.z);
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
