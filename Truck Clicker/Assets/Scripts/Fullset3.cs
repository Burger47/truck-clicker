using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullset3 : MonoBehaviour
{
   [SerializeField] GameObject _Fullset3; 
    [SerializeField] GameObject _Truck3;
    [SerializeField] GameObject _Road3;
    [SerializeField] GameObject _Factory3;


    // Update is called once per frame
    void Update()
    {
        if (Controller.Trucks >= 2){
        _Fullset3.SetActive(true);
       }else {
       _Fullset3.SetActive(false);
       } 

    }
}
