using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTest : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,30,0)*Time.deltaTime*speed);
    }
}
