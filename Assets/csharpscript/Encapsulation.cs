using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoScript : MonoBehaviour
{
 public int AddNumber(int a,int b){
return a*b;
 }
    void Start()
    {
        int i;
        for(i=1;i<10;i++){
            int result =AddNumber(12,5);
            Debug.Log("i");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
