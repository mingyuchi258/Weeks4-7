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
    }

    public void moveRightLeft(float n)
    {
        Vector3 newpos = transform.position;
        newpos.x = n * 30;
        transform.position = newpos;
    }

    public void shooting()
    {
        newMissile = Instantiate(Mp, transform.position, transform.rotation);
        missileMove = newMissile.GetComponent<missile>();
    }
}
