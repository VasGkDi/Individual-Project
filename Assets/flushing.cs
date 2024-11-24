using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flushing : MonoBehaviour
{

    [SerializeField]
    GameObject flushSound;

    public void OnInteractWithItem()
    {
        flushSound.SetActive(!flushSound.activeSelf);
     
    }
}