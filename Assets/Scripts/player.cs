using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem

public class player : MonoBehaviour
{   [SerializedFeild] float moveSpd = 5f;
    Vector2 rawInput;

    void Update()
    {
    
    }

    void OnMove(InputValue value)
    {
        rawInput = value.Get<Vector2>();
        Debug.Log(rawInput);
    }
    void move()
    {
        Vector3 delta = rawInput * moveSpd * Time.deltaTime;
        transform.position += delta;
    }
}
