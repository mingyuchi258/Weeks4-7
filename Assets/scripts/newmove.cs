using UnityEngine;

public class newmove : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newR = transform.eulerAngles;
        newR.z += speed * Time.deltaTime;
        transform.eulerAngles = newR;
    }

    public void AddSpeed()
    {
        speed = 100;
    }

    public void ReduceSpeed()
    {
        speed = 0;
    }
}
