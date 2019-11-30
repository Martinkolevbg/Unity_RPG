using UnityEngine;
using System.Collections;

public class Floater : MonoBehaviour
{

    [SerializeField] float rotationSpeed = 3.0f;
    [SerializeField] float tolerance = 0.5f;
    [SerializeField] float frequency = 0.5f;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {
        posOffset = transform.position;
    }
    void Update()
    {
        RotateObject();

        UpDownFloating();
    }

    private void UpDownFloating()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * tolerance;

        transform.position = tempPos;
    }

    private void RotateObject()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * rotationSpeed, 0f), Space.World);
    }
}