using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnowController : MonoBehaviour
{
    public int max = 6, min = -6;
    public float speed = 1;
    private bool flag = false;
    // Update is called once per frame
    void Update()
    {
       if(transform.position.y < min)
            flag = flag ? false : true;
       if(transform.position.y > max)
            flag = flag ? false : true;

        if (flag)
            transform.position = new Vector3(0, transform.position.y + speed * Time.deltaTime, 0);
        else
            transform.position = new Vector3(0, transform.position.y - speed * Time.deltaTime, 0);
    }
}
