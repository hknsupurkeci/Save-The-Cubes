using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    private bool controller = false;

    public void Update()
    {
        if(!controller)
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        else
            transform.Rotate(Vector3.forward * -speed * Time.deltaTime);

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
                controller = controller ? false : true;
        }
    }
}
