using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    
    public static float Money;

    public GameObject TruckOriginal;

    public GameObject TruckContainer;

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

        SpeedCost1 = 75;
        //SpeedText1.text = "Upgrade Truck Speed 1 Cost: " + SpeedCost1.ToString() + "   Speed: " + Truck.Speed.ToString();

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

        GameObject Temp = Instantiate(TruckOriginal);
        Temp.transform.parent = TruckContainer.transform;
        Temp.GetComponent<Truck>().Speed = 1;
        Temp.GetComponent<Truck>().Running = 0;
        Temp.name = "Truck" + (Trucks+1);

    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Money.ToString();
        ButtonText.text = "Purchase Truck Cost: "+TruckCost.ToString();
    }

    public void OnTruckButtonPress()
    {
        if (Money >= TruckCost) {
            Money = Money - TruckCost;
            TruckCost = TruckCost * 2;
            Trucks += 1;

            GameObject Temp = Instantiate(TruckOriginal, new Vector3(TruckOriginal.transform.position.x + Trucks * 115, TruckOriginal.transform.position.y, TruckOriginal.transform.position.z), TruckOriginal.transform.rotation);
            Temp.transform.parent = TruckContainer.transform;
            Temp.GetComponent<Truck>().Speed = 1;
            Temp.GetComponent<Truck>().Running = 0;
            Temp.name = "Truck" + (Trucks+1);
        }
    }

    public void SpeedButton1()
    {
        if (Money >= SpeedCost1){
            Money -= SpeedCost1;
            //Truck.Speed += 1;
           //SpeedCost1 = SpeedCost1 + (5*Truck.Speed);
            //SpeedText1.text = "Upgrade Truck Speed 1 Cost: " + SpeedCost1.ToString() + "   Speed: " + Truck.Speed.ToString();;
        }
    }

    public void ManagerButton1()
    {
        if (Money >= T1ManagerCost && T1Manager != 1)
        {
            Money = Money - T1ManagerCost;
            T1Manager += 1;
            T1MButton.SetActive(false);
           
        }
    }

    public void ManagerButton2()
    {
        if (Money >= T2ManagerCost && T2Manager != 1)
        {
            Money = Money - T2ManagerCost;
            T2Manager += 1;
            T2MButton.SetActive(false);
        }
    }

    public void ManagerButton3()
    {
        if (Money >= T3ManagerCost && T3Manager != 1)
        {
            Money = Money - T3ManagerCost;
            T3Manager += 1;
            T3MButton.SetActive(false);
        }
    }

    public void ManagerButton4()
    {
        if (Money >= T4ManagerCost && T4Manager != 1)
        {
            Money = Money - T4ManagerCost;
            T4Manager += 1;
            T4MButton.SetActive(false);
        }
    }
}
