using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paletaManager : MonoBehaviour{

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    // Axis control
    public string inputName;

    private HingeJoint hinge;
   
    // To mobile devices
    // public int mitatPantalla;

    // Start is called before the first frame update
    void Start()  {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        mitatPantalla = Screen.width /2;
    }

     // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
        print ("Tag Update: " + tag);
        
        // Mobile devices
        /*if (Input.GetKeyDown(KeyCode.A) || Input.touchCount > 0)
        {
			print ("Tag KeyCode.A" + tag);

            if (Input.GetTouch(0).position.x < mitatPantalla )
            {
                if (tag == "PaletaEsquerre")
                {
                    spring.targetPosition = pressedPosition;
                    print ("Tag Esquerre");
                }
                else
                {
                    spring.targetPosition = restPosition;
                }
            }
            if (Input.GetTouch(0).position.x >= mitatPantalla)
            {
                if (tag == "PaletaDreta")
                {
                    spring.targetPosition = pressedPosition;
                    print ("Tag Dreta");

                }
                else
                {
                    spring.targetPosition = restPosition;
                }
            }
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
        */

        // Standalone PC
        if (Input.GetAxis (inputName)== a)  {  // Left flipper




        }
        else { // Right flipper





        }




    }
}
    
