using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public static int Money;
    public static int Trucks;
    public Text MoneyText;
    public static int Cost;

    // Start is called before the first frame update
    void Start()
    {
        Money = 0;
        Trucks = 0;
        Cost = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Money.ToString();
    }

    public void OnButtonPress()
    {
        if (Controller.Money >= Cost)
        {
            Controller.Money = Controller.Money - Cost;
            Cost = Cost * 2;
            Controller.Trucks += 1;
        }
    }
}
