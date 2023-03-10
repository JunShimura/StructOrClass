using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ValueTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pos = new Vector3(3, 1, 0);
    [SerializeField]
    GameObject instance;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject temp = GameObject.Instantiate(instance);
            temp.transform.position= pos;
            pos += Vector3.right;
            temp = GameObject.Instantiate(instance);
            temp.transform.position = pos;
        }
        if (Input.GetMouseButtonDown(1))
        {
            pos += Vector3.up;
        }
    }
}
