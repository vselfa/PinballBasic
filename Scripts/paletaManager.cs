﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class paletaManager : MonoBehaviour{

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 10000f;
    public float flipperDamper = 150f;
    private HingeJoint hinge;
    public int mitatPantalla;

    // Start is called before the first frame update
    void Start()  {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        mitatPantalla = Screen.width /2;

        print ("Tag Inici");
    }

    // Update is called once per frame
    void Update() {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetKeyDown(KeyCode.A) )
        {
			print ("Fletxes horitzontals" + tag);
            spring.targetPosition = pressedPosition;      
        }


    }
}