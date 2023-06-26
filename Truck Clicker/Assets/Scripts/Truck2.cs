using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Truck2 : MonoBehaviour
{
    private static int Running;

    private static int Speed;
    private static int SpeedCost;
    public Text SpeedText2;

    
    // Start is called before the first frame update
    void Start()
    {
        Running = 0;

        Speed = 1;
        SpeedCost = 110;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedText2.text = "Upgrade Truck Speed 2 Cost: " + SpeedCost.ToString() + "   Speed: " + Speed.ToString();
    }

    void OnMouseDown()
    {
        if (Controller.Trucks >= 1) {
            if (Running == 0) {
                Running = 1;
                if (Controller.T1Manager == 0){
                    Controller.Money = Controller.Money - 1;
                }
            } else {
                transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z);
            }
        }
    }

    void FixedUpdate()
     {
        if (Controller.Trucks >= 1){
            if (Running == 1 || Controller.T2Manager == 1){
                if (transform.position.y <= 120){
                    transform.position = new Vector3(transform.position.x, transform.position.y + 1*Speed, transform.position.z);
                } else {
                    transform.position = new Vector3(transform.position.x, -110, transform.position.z);
                    Controller.Money = Controller.Money + 2;
                    Running = 0;
                    if (Controller.T2Manager == 1){
                        Controller.Money -= 1;
                    }
                }
            }
        }
    }

    public void SpeedButton2()
    {
        if (Controller.Money >= SpeedCost){
            Controller.Money -= SpeedCost;
            Speed += 1;
            SpeedCost = SpeedCost + (5*Speed);
        }
    }
}
