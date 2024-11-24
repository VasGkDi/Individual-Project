using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleLights : MonoBehaviour
{

    [SerializeField]
    GameObject flushing;

    public void OnInteractWithItem()
    {
        flushing.SetActive(!flushing.activeSelf);
        

    }
}