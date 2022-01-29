using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBlockForward : MonoBehaviour
{
    void Update()
    {
        Quaternion parentRotation = transform.parent.parent.rotation;
        Quaternion rotationCorrection = Quaternion.Euler(parentRotation.eulerAngles.x, parentRotation.eulerAngles.y * -(1/24), parentRotation.eulerAngles.z);

        transform.SetPositionAndRotation(transform.position, rotationCorrection);
        //transform.Rotate(new Vector3(rotationCorrection.eulerAngles.x, rotationCorrection.eulerAngles.y * -1, rotationCorrection.eulerAngles.z));
    }
}
