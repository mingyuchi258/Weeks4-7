using Unity.VisualScripting;
using UnityEngine;

public class missile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.up * 5 * Time.deltaTime;
    }
}
