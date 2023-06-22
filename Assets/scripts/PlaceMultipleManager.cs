using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceMultipleManager : MonoBehaviour
{

    private PlaceIndicator laceIndicator;

    public GameObject objectFirst;
    public GameObject objectSecond;
    public GameObject objectThird;

    private GameObject objectToPlaces;
    private GameObject checkBeforePlace;
    private GameObject newPlacedObject;


    // Start is called before the first frame update
    void Start()
    {
        laceIndicator = FindObjectOfType<PlaceIndicator>();


    }

   // public void InstantiateObject()
   // {
   //     Instantiate(objectToPlaces, laceIndicator.transform.position, laceIndicator.transform.rotation);

   // }

    public void SetObjectToPlace(GameObject  objPrefab)
    {
        objectToPlaces=(objPrefab);
    }


    public void ClickToPlaceFirst()
    {
        SetObjectToPlace(objectFirst);
    }
    public void ClickToPlaceSecond()
    {
        SetObjectToPlace(objectSecond);
    }
    public void ClickToPlaceThird()
    {
        SetObjectToPlace(objectThird);
    }

    public void ClickToCheck()
    {
        if(objectToPlaces==null)
        {
            return;
        }
        if(checkBeforePlace != null)
        {
            Destroy(checkBeforePlace);
        }

        checkBeforePlace = Instantiate(objectToPlaces, laceIndicator.transform.position, laceIndicator.transform.rotation);
    
    }
    // Update is called once per frame
     public void ClickToPlace()
    {
        if(objectToPlaces == null)
        {
            return;
        }
        if(checkBeforePlace !=null)
        {
            newPlacedObject = checkBeforePlace;
            Instantiate(objectToPlaces, laceIndicator.transform.position, laceIndicator.transform.rotation);

            Destroy(checkBeforePlace);

        }
        else
        {
            Instantiate(objectToPlaces, laceIndicator.transform.position, laceIndicator.transform.rotation);
        }
    }


    }

