using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Truck1 : MonoBehaviour

{
    private static int Running;

    private static int Ltext;

    private static int Speed;
    private static int SpeedCost;
    public Text SpeedText1;

    public Text LaunchText;

    // Start is called before the first frame update
    void Start()
    {
        Running = 0;
        LaunchText.text = "Click Truck To Launch";

        Ltext = 1;

        Speed = 1;
        SpeedCost = 75;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedText1.text = "Upgrade Truck Speed 1 Cost: " + SpeedCost.ToString() + "   Speed: " + Speed.ToString();
        
        if (transform.position.y == -110 && Controller.T1Manager == 0){
            if (Ltext == 1){
                LaunchText.text = "Click Truck To Launch";
            }
        } else if (Controller.T1Manager == 1) {
            LaunchText.text = "";
        } else {
        LaunchText.text = "";
        }
        
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
        Ltext = 0;
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

    public void SpeedButton1()
    {
        if (Controller.Money >= SpeedCost){
            Controller.Money -= SpeedCost;
            Speed += 1;
            SpeedCost = SpeedCost + (5*Speed);
        }
    }
}
