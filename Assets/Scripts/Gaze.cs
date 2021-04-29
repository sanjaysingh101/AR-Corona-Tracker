using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Gaze : MonoBehaviour
{
    public GameObject marker;
    public GameObject manager;
    private GameObject mar;
    public GameObject Map;
    Ray ray;
    RaycastHit fit;



    void Start()
    {
        //mar = Instantiate(marker, marker.transform.position, marker.transform.rotation);

    }

    void Update()
    {
        Map = GameObject.FindGameObjectWithTag("map");
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
        {
            marker.transform.localPosition = hit.point;
            marker.transform.localEulerAngles = new Vector3(hit.collider.transform.eulerAngles.x + 90, hit.collider.transform.eulerAngles.y, hit.collider.transform.eulerAngles.z);

            //marker.transform.RotateAround = hit.collider.gameObject.transform.rotation;

            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("1") || go.CompareTag("2") || go.CompareTag("3") || go.CompareTag("4") || go.CompareTag("5") || go.CompareTag("6") || go.CompareTag("7") || go.CompareTag("8") || go.CompareTag("9") || go.CompareTag("10") || go.CompareTag("11") || go.CompareTag("12") || go.CompareTag("13") || go.CompareTag("14") || go.CompareTag("15") || go.CompareTag("16") || go.CompareTag("1") || go.CompareTag("1") || go.CompareTag("1") || go.CompareTag("17") || go.CompareTag("1") || go.CompareTag("18") || go.CompareTag("19") || go.CompareTag("20") || go.CompareTag("21") || go.CompareTag("22") || go.CompareTag("23") || go.CompareTag("24") || go.CompareTag("25") || go.CompareTag("26") || go.CompareTag("27") || go.CompareTag("28") || go.CompareTag("29") || go.CompareTag("30") || go.CompareTag("31") || go.CompareTag("32") || go.CompareTag("33") || go.CompareTag("34") || go.CompareTag("35") || go.CompareTag("36"))
            {


                Debug.Log(go.transform.gameObject.tag);
                go.transform.gameObject.GetComponent<Animation>().Play();

                //go.transform.gameObject.GetComponent<Animation>().Play("ChangeColour");

                //go.transform.GetChild(0).transform.gameObject.GetComponent<InfoBehivioaur>().OpenInfo();
                go.transform.GetChild(0).transform.gameObject.GetComponent<Animation>().Play();

            }

        }
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out fit))
        {
            if (Input.GetMouseButtonDown(0) && fit.transform.gameObject.CompareTag("Respawn"))
            {
                print("reload");
                manager.GetComponent<Manager>().GetData();
                Map.GetComponent<Animation>().Play();
                fit.transform.gameObject.GetComponent<Animation>().Play();

            }
        }

    }

}
