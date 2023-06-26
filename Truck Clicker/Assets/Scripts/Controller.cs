using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    
    public static float Money;

    public static int T1Manager;
    public static int T1ManagerCost;

    public static int T2Manager;
    public static int T2ManagerCost;

    public static int T3Manager;
    public static int T3ManagerCost;

    public static int T4Manager;
    public static int T4ManagerCost;

    public static int TruckCost;
    public static int Trucks;

    public Text MoneyText;
    public Text ButtonText;
    

    // Start is called before the first frame update
    void Start()
    {
        Money = 10000;

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

    public void ManagerButton1()
    {
        if (Controller.Money >= T1ManagerCost && T1Manager != 1)
        {
            Controller.Money = Controller.Money - T1ManagerCost;
            T1Manager += 1;
        }
    }

    public void ManagerButton2()
    {
        if (Controller.Money >= T2ManagerCost && T2Manager != 1)
        {
            Controller.Money = Controller.Money - T2ManagerCost;
            T2Manager += 1;
        }
    }

    public void ManagerButton3()
    {
        if (Controller.Money >= T3ManagerCost && T3Manager != 1)
        {
            Controller.Money = Controller.Money - T3ManagerCost;
            T3Manager += 1;
        }
    }

    public void ManagerButton4()
    {
        if (Controller.Money >= T4ManagerCost && T4Manager != 1)
        {
            Controller.Money = Controller.Money - T4ManagerCost;
            T4Manager += 1;
        }
    }
}
