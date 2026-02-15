using Unity.VisualScripting;
using UnityEngine;

public class missile : MonoBehaviour
{

    public GameObject Mp;
    //set timer
    public float timeV = 0;
    public float timemaxV = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the missile forward
        transform.position += transform.up * 5 * Time.deltaTime;
        //timer starts counting down
        timeV += Time.deltaTime;
        //destroy the missile if the timer expires
        if (timeV > timemaxV)
        {
            Destroy(Mp);
        }
    }


}
