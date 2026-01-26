using UnityEngine;
using UnityEngine.InputSystem;

public class UIDemo : MonoBehaviour
{
    public SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            changeColour();
        }
    }

    public void changeColour()
    {
        sr.color = Random.ColorHSV();
    }

    public void setScaleBig(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
