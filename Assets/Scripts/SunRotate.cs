using UnityEngine;

public class SunRotate : MonoBehaviour
{

    public float rotateSpeed = 360;

    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles + Vector3.up * Time.deltaTime * rotateSpeed);
    }

}