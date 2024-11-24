using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleLightsw : MonoBehaviour
{

    [SerializeField]
    GameObject Lights1;

    [SerializeField]
    GameObject Lights2;

    [SerializeField]
    GameObject Lights3;

    [SerializeField]
    GameObject Lights4;

    [SerializeField]
    GameObject LightOff1;

    [SerializeField]
    GameObject LightOff2;

    public void OnTurnOnLights()
    {
        Lights1.SetActive(!Lights1.activeSelf);
        Lights2.SetActive(!Lights2.activeSelf);
        Lights3.SetActive(!Lights3.activeSelf);
        Lights4.SetActive(!Lights4.activeSelf);
        LightOff1.SetActive(!LightOff1.activeSelf);
        LightOff2.SetActive(!LightOff2.activeSelf);

    }
}