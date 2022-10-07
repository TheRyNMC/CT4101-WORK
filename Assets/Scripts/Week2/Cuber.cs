using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuber : MonoBehaviour 
{
    private Vector3 startPosition;
    [SerializeField]
    private float xSpeed = 2f;
    [SerializeField]
    private float rotateSpeed = 360f;
    [SerializeField]
    private float ySpeed = 2f;
    [SerializeField]
    private float displacement = 10f;
    private float elapsedTime = 5;


    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update() { 
    if (Input.GetKey(KeyCode.Space))
    {
        float xMove = xSpeed * Mathf.Cos(xSpeed * Time.time);
        float yMove = ySpeed * Mathf.Sin(xSpeed * Time.time);
        transform.Rotate(xMove, 0, 0);
        transform.position = startPosition + new Vector3 (xMove, yMove, displacement);
        transform.localScale = new Vector3(xMove, yMove, 32);
    }
}
