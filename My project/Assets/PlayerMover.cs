using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = 33f;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        

        transform.Translate(xValue*moveSpeed, 0, zValue*moveSpeed);
    }
}
