using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float divisor=100;

    private float CalculateSpeed(float realSpeed)
    {
        float newSpeed;
        newSpeed = realSpeed / divisor;
        return newSpeed;

    }
    public void Move(GameObject gObj, Space space, float speed)
    {
        gObj.transform.Translate(Vector3.forward * CalculateSpeed(speed), space);
    }
}
