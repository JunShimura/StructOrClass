using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    [SerializeField]
    private Color color0;
    [SerializeField]
    private Color color1;
    [SerializeField]
    private float s = 1;
    Renderer renderer;
    private float t = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime * s;
        float v = Mathf.Sin((Mathf.Sin(t)) + 1) / 2;
        renderer.material.color = Color.Lerp(color0,color1,v);
        Vector3 trans = new Vector3(Mathf.Sqrt(1 - v), v, Mathf.Sqrt(1 -v));
        transform.localScale = trans;
    }
}
