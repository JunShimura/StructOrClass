using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ValueTest : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pos = new Vector3(3, 1, 0);
    static List<GameObject> testObject=new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject temp = GameObject.Instantiate(this.gameObject);
            testObject.Add(temp);
            Destroy( temp.GetComponent<ValueTest>());
            temp.transform.position= pos;
            //temp.transform.position.x= 100; //ÉGÉâÅ[Ç…Ç»ÇÈ
        }
        if (Input.GetMouseButtonDown(1))
        {
            pos += Vector3.right;
        }
    }
}
