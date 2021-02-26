using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xSpeed = 0f;
    [SerializeField] float ySpeed = 0f;
    [SerializeField] float zSpeed = 0f;

    float xAngle;
    float yAngle;
    float zAngle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xAngle = xSpeed * Time.deltaTime;
        yAngle = ySpeed * Time.deltaTime;
        zAngle = zSpeed * Time.deltaTime;

        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
