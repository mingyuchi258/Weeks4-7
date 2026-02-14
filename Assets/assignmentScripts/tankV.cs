using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class tankV : MonoBehaviour
{
    public Vector2 newpos;
    public SpriteRenderer sr;
    public cannon ca;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newpos = transform.position;
        newpos.x = Random.Range(-8, 9);
        newpos.y = Random.Range(1, 5);
        transform.position = newpos;
    }

    // Update is called once per frame
    void Update()
    {
        if (ca.R == true)
        {
            newpos = transform.position;
            newpos.x = Random.Range(-8, 9);
            newpos.y = Random.Range(1,5);
            transform.position = newpos;
        }
    }

}
