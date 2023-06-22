using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceManager : MonoBehaviour
{

    private PlaceIndicator laceIndicator;

    public GameObject objectFirst;
    public GameObject objectSecond;
    public GameObject objectThird;

    private GameObject objectToPlaces;


    // Start is called before the first frame update
    void Start()
    {
        laceIndicator = FindObjectOfType<PlaceIndicator>();


    }

    public void InstantiateObject()
    {
        Instantiate(objectToPlaces, laceIndicator.transform.position, laceIndicator.transform.rotation);

    }


    public void ClickToPlaceFirst()
    {
        objectToPlaces = objectFirst;
        InstantiateObject();
    }
    public void ClickToPlaceSecond()
    {
        objectToPlaces = objectSecond;
        InstantiateObject();
    }
    public void ClickToPlaceThird()
    {
        objectToPlaces = objectThird;
        InstantiateObject();
    }
    // Update is called once per frame
    
    }

