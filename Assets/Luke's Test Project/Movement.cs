using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 locationToMoveTo = new Vector3(Input.GetAxisRaw("P1KeyboardHorizontal"), 0, Input.GetAxisRaw("P1KeyboardVertical"));
        transform.Translate(locationToMoveTo * speed * Time.deltaTime);
    }
}
