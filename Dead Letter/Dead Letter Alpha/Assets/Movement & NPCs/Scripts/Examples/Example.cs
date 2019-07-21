using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    /*
     Assignment Operators:
     = 
     +=   speed = speed + y
     -=
     *=
     /=
     %=   7 % 3 = 1

    
     Arithmetic Operators:
     +
     -
     *
     /
     %

     Comparison Operators:
     ==
     !=
     >
     <
     >=
     <=

     Logical Operators:
     &&
     ||
     !
     */

    public float speed = 0.0f;
    public float distance = 0.0f;
    public float time = 0.0f;

    public float maxSpeedLimit = 70.0f;
    public float minSpeedLimit = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedCheck();
        }
    }

    void SpeedCheck()
    {
        speed = distance / time;
        
        if(speed > maxSpeedLimit)
        {
            print("You are exceeding the speed limit!");
        }
        else if(speed < minSpeedLimit)
        {
            print("You are not going fast enough!");
        }
        else if(speed == maxSpeedLimit || speed == minSpeedLimit)
        {
            print("You are very close to breaking the law!");
        }
        else
        {
            print("You are within the speed limit!");
        }
    }
}
