using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAndRotatingObjects : MonoBehaviour
{
    [Header("Default Movement Speed")]
    public float moveSpeed = 10f;
    [Header("Default Rotation Speed")]
    public float roateSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        transform.Rotate(Vector3.up * roateSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
