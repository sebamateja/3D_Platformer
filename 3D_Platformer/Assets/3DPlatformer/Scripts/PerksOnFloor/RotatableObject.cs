using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatableObject : MonoBehaviour
{
    public string name1 = "Ring";
    public string name2 = "Skill";

    private float rotationSpeed = 100.0f;
    private GameObject gameObject1;
    private GameObject gameObject2;

    void Start()
    {
        gameObject1 = GetChildWithName(transform, name1);
        gameObject2 = GetChildWithName(transform, name2);
    }

    void FixedUpdate()
    {
        //gameObject1.transform.localRotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.right);
        //gameObject2.transform.localRotation *= Quaternion.AngleAxis(rotationSpeed * Time.deltaTime, Vector3.right);
        gameObject1.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        gameObject2.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    GameObject GetChildWithName(Transform trans, string name)
    {
        Transform childTrans = trans.Find(name);

        if (childTrans != null)
        {
            Debug.Log("!= null");
            return childTrans.gameObject;
        } else
        {
            Debug.Log("== null");
            return null;
        }
    }
}
