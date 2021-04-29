using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager rayManager;
    private GameObject visual;
    public GameObject textobject;
    public GameObject spawnobject;
    public GameObject Manager;
    public GameObject ARinvisibleplane;
    public GameObject trophy;
    public ARSessionOrigin ASOrigin;
    //public ARSession AS;

    void Start()
    {
        
        rayManager = FindObjectOfType<ARRaycastManager>();
        visual = transform.GetChild(0).gameObject;

        
        visual.SetActive(false);
    }

    void Update()
    {
       
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rayManager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        
        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            
            if (!visual.activeInHierarchy && spawnobject == null)
            {
                visual.SetActive(true);

            }
            if (spawnobject != null)
            {
                visual.SetActive(false);
                textobject.SetActive(false);
                // spawnobject.transform.localEulerAngles = new Vector3(0,0,0);
            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && spawnobject == null)
            {
                Instantiate(ARinvisibleplane, hits[0].pose.position, hits[0].pose.rotation);
                spawnobject = Instantiate(trophy, hits[0].pose.position,transform.rotation);
                
                StartCoroutine(GetData());
                
                
                //Instantiate(trophy, hits[0].pose.position, hits[0].pose.rotation);
                ASOrigin.enabled=false;
                //AS.enabled=false;


            }
            
        }
    }
    IEnumerator GetData()
    {
        yield return new WaitForSeconds(2);
        Manager.GetComponent<Manager>().GetData();

    }
    public void Show()
    {
        spawnobject = Instantiate(trophy, transform.position,transform.rotation);
    }
}