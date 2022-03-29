using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ps4Controller : MonoBehaviour
{
    GameObject mov = null;
    float rot = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }
        
        mov  = GameObject.Find("View");
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0].leftStick.up.isPressed)
            {
                mov.transform.position += Vector3.left * Time.deltaTime * 500f;
            }
                
            if (Gamepad.all[0].leftStick.down.isPressed)
            {
                mov.transform.position += Vector3.right * Time.deltaTime * 500f;
            }

            if (Gamepad.all[0].rightStick.right.isPressed)
            {
                rot = (float)(rot+0.01);
                mov.transform.Rotate(0.0f, rot, 0.0f, Space.World);
            }

            if (Gamepad.all[0].rightStick.left.isPressed)
            {
                rot = (float)(rot-0.01);
                mov.transform.Rotate(0.0f, rot, 0.0f, Space.World);
            }
        }
            
    }
}
