using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullset4 : MonoBehaviour
{
  [SerializeField] GameObject _Fullset4; 
    [SerializeField] GameObject _Truck4;
    [SerializeField] GameObject _Road4;
    [SerializeField] GameObject _Factory4;

    // Update is called once per frame
    void Update()
    {
        if (Controller.Trucks >= 3){
        _Fullset4.SetActive(true);
       }else {
       _Fullset4.SetActive(false);
       } 
    }
}
