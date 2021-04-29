using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehiviour : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Transform sectioninfo;
    public Transform cam;
    public float Speed;
    Vector3 targateangle = Vector3.zero;
    Vector3 desiredScale;
    void Start()
    {
        cam=Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //sectioninfo.localScale = Vector3.Lerp(sectioninfo.localScale,desiredScale,Time.deltaTime*Speed);
        transform.LookAt(cam);
        targateangle = transform.localEulerAngles;
        targateangle.x =0;
        targateangle.z =0;
        transform.localEulerAngles = targateangle;
    }
    public void OpenInfo()
    {
        StartCoroutine(Openforsec());
    }
    
    IEnumerator Openforsec()
    {
        desiredScale = Vector3.one;
        yield return new WaitForSeconds(2.5f);
        desiredScale = Vector3.zero;
        
    }
}
