using System.Timers;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class tankV : MonoBehaviour
{
    public Vector2 newpos;
    public SpriteRenderer sr;
    public cannon ca;
    public float speed;
    public float rspeed;
    public AudioSource audiosource;
    Vector2 left;
    Vector2 right;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        left = Camera.main.ScreenToWorldPoint(Vector2 .zero);
        right = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        newpos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newp = transform.position;
        Vector3 rp = transform.eulerAngles;
        newp.x += speed * Time.deltaTime;

        Vector2 screenpos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenpos.x < 0)
        {
            newp.x = left.x;
            speed = speed * -1;

            rp.z = rp.z-180;
            transform.eulerAngles = rp;
        }
        if (screenpos.x > Screen.width)
        {
            newp.x = right.x;
            speed = speed * -1;

            rp.z = rp.z -180;
            transform.eulerAngles = rp;
        }
        transform.position = newp;

        newpos = transform.position;

        if (ca.R == true)
        {
            newpos = transform.position;
            newpos.x = Random.Range(-8, 9);
            newpos.y = Random.Range(1,5);
            transform.position = newpos;

            audiosource.Play();
        }
    }

}
