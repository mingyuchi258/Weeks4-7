using System;
using System.Resources;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class cannon : MonoBehaviour
{
    public GameObject newMissile;
    public GameObject Mp;
    public missile missileMove;

    public tankV tank;

    public bool R = false;

    public AudioSource audiosource;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if holding down the mouse and not using the ui
        if (Mouse.current.leftButton.isPressed == true && !EventSystem.current.IsPointerOverGameObject())
        {
            //cannon pointing in the direction of the mouse
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(UnityEngine.InputSystem.Mouse.current.position.ReadValue());
            Vector2 D = mousepos - (Vector2)transform.position;
            transform.up = D;

 
           
        }
        //if the missile is instantiated
        if (newMissile != null)
        {
            //the missile was destroyed upon contact with the tank.
            float d = Vector2.Distance(newMissile.transform.position, tank.newpos);
            if (d < 1)
            {
                Destroy(newMissile);
                //transmit the message that the tank has been hit
                R = true;

            }
            //transmit the message that the tank has not been hit
            else
            {
                R = false;
            }
        }
       else
       {
            R = false;
       }
    }
    //use the slider to control the cannon's left and right movement
    public void moveRightLeft(float n)
    {

        Vector3 newpos = transform.position;
        newpos.x = n * 30;
        transform.position = newpos;
    }
    //instantiate the missile and add a move script to it.
    public void shooting()
    {
        //it can only be launched when there are no missiles available
        if (newMissile == null)
        {
            newMissile = Instantiate(Mp, transform.position, transform.rotation);
            missileMove = newMissile.GetComponent<missile>();
            audiosource.Play();

        }


    }
}
