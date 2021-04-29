using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 stateepos;
    public float Speed = 1;
    Vector3 desiredpos;
    void Start()
    {
        stateepos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.Lerp(stateepos,new Vector3(stateepos.x,stateepos.y+desiredpos.y,stateepos.z), Time.deltaTime * Speed);
    }
    public void Popitup()
    {
        
        desiredpos.y = 5;

        //StartCoroutine(Openforsec());
    }
    IEnumerator Openforsec()
    {
        desiredpos = new Vector3(stateepos.x, stateepos.y + 25, stateepos.z);
        yield return new WaitForSeconds(2.5f);
        desiredpos = stateepos;

    }
}
