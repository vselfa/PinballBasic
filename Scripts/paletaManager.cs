using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paletaManager : MonoBehaviour{

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 300f;
    // Axis control
    // public string inputName ="a";

    private HingeJoint hinge;
   
    // To mobile devices
    // public int meitatPantalla;

    // Start is called before the first frame update
    void Start()  {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        // meitatPantalla = Screen.width /2;
    }

     // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;
        
        // Standalone PC
        // See Edit -> Prject settings -> Inoput Manager
        if (Input.GetAxis ("LeftFlipper") == 1)  {  // Left flipper activated with a
            print ("a key: " + tag);
            if (tag == "PaletaEsquerre") {
                spring.targetPosition = pressedPosition;
            }
            else {
                spring.targetPosition = restPosition;
            }
        }
        // See Edit -> Prject settings -> Inoput Manager
        if (Input.GetAxis ("RightFlipper") == 1) {  // Right flipper activated with l
            if (tag == "PaletaDreta") {
                spring.targetPosition = pressedPosition;
            }
            else {
                spring.targetPosition = restPosition;
            }
        }

        hinge.spring = spring;
        hinge.useLimits = true;

        // Mobile devices
        /*if (Input.GetKeyDown(KeyCode.A) || Input.touchCount > 0)
        {
			print ("Tag KeyCode.A" + tag);

            if (Input.GetTouch(0).position.x < meitatPantalla )
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
            if (Input.GetTouch(0).position.x >= meitatPantalla)
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


    }
}
    
