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
        if (Mouse.current.leftButton.isPressed == true && !EventSystem.current.IsPointerOverGameObject())
        {
            Vector2 mousepos = Camera.main.ScreenToWorldPoint(UnityEngine.InputSystem.Mouse.current.position.ReadValue());
            Vector2 D = mousepos - (Vector2)transform.position;
            transform.up = D;

 
           
        }
        if (newMissile != null)
        {
            float d = Vector2.Distance(newMissile.transform.position, tank.newpos);
            if (d < 1)
            {
                Destroy(newMissile);
                R = true;

            }
            else
            {
                R = false;
            }
        }
       else
       {
            R = false;
       }

        //if (tank.sr.bounds.Contains(newMissile.transform.position) == true)
        //{
        //    Destroy(newMissile);
        //}
    }

    public void moveRightLeft(float n)
    {
        Vector3 newpos = transform.position;
        newpos.x = n * 30;
        transform.position = newpos;
    }

    public void shooting()
    {
        if (newMissile == null)
        {
            newMissile = Instantiate(Mp, transform.position, transform.rotation);
            missileMove = newMissile.GetComponent<missile>();
            audiosource.Play();

        }


    }
}
