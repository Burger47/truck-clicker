using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullset2 : MonoBehaviour
{
    [SerializeField] GameObject _Fullset2; 
    [SerializeField] GameObject _Truck2;
    [SerializeField] GameObject _Road2;
    [SerializeField] GameObject _Factory2;



    // Update is called once per frame
    public void Update()
    {
       if (Controller.Trucks >= 1){
        _Fullset2.SetActive(true);
       }else {
       _Fullset2.SetActive(false);
       }
 

    }
}
