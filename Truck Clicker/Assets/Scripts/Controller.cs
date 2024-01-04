using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    
    public static float Money;

    public Text LaunchText;

    public static int SpeedCost1;
    public Text SpeedText1;

    public static int T1Manager;
    public static int T1ManagerCost;
    public GameObject T1MButton;

    public static int T2Manager;
    public static int T2ManagerCost;
    public GameObject T2MButton;

    public static int T3Manager;
    public static int T3ManagerCost;
    public GameObject T3MButton;

    public static int T4Manager;
    public static int T4ManagerCost;
    public GameObject T4MButton;

    public static int TruckCost;
    public static int Trucks;

    public Text MoneyText;
    public Text ButtonText;
    

    // Start is called before the first frame update
    void Start()
    {
        Money = 10000;

        LaunchText.text = "Click Truck To Launch";

        SpeedCost1 = 75;
        SpeedText1.text = "Upgrade Truck Speed 1 Cost: " + SpeedCost1.ToString() + "   Speed: " + Truck1.Speed.ToString();

        T1Manager = 0;
        T1ManagerCost = 15;
        
        T2Manager = 0;
        T2ManagerCost = 40;
        
        T3Manager = 0;
        T3ManagerCost = 90;
        
        T4Manager = 0;
        T4ManagerCost = 210;

        Trucks = 0;
        TruckCost = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Truck1.Running == 1){
            LaunchText.enabled = false;
        }
        MoneyText.text = Money.ToString();
        ButtonText.text = "Purchase Truck Cost: "+TruckCost.ToString();
    }

    public void OnTruckButtonPress()
    {
        if (Controller.Money >= TruckCost) {
            Controller.Money = Controller.Money - TruckCost;
            TruckCost = TruckCost * 2;
            Controller.Trucks += 1;
            
        }
    }

    public void SpeedButton1()
    {
        if (Money >= SpeedCost1){
            Controller.Money -= SpeedCost1;
            Truck1.Speed += 1;
            SpeedCost1 = SpeedCost1 + (5*Truck1.Speed);
            SpeedText1.text = "Upgrade Truck Speed 1 Cost: " + SpeedCost1.ToString() + "   Speed: " + Truck1.Speed.ToString();;
        }
    }

    public void ManagerButton1()
    {
        if (Controller.Money >= T1ManagerCost && T1Manager != 1)
        {
            Controller.Money = Controller.Money - T1ManagerCost;
            T1Manager += 1;
            T1MButton.SetActive(false);
           
        }
    }

    public void ManagerButton2()
    {
        if (Controller.Money >= T2ManagerCost && T2Manager != 1)
        {
            Controller.Money = Controller.Money - T2ManagerCost;
            T2Manager += 1;
            T2MButton.SetActive(false);
        }
    }

    public void ManagerButton3()
    {
        if (Controller.Money >= T3ManagerCost && T3Manager != 1)
        {
            Controller.Money = Controller.Money - T3ManagerCost;
            T3Manager += 1;
            T3MButton.SetActive(false);
        }
    }

    public void ManagerButton4()
    {
        if (Controller.Money >= T4ManagerCost && T4Manager != 1)
        {
            Controller.Money = Controller.Money - T4ManagerCost;
            T4Manager += 1;
            T4MButton.SetActive(false);
        }
    }
}
