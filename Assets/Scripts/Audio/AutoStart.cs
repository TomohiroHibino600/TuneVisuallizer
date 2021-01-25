using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Crosstales.Radio;

public class AutoStart : MonoBehaviour
{
    [SerializeField] SimplePlayer simplePlayer;

    // Start is called before the first frame update
    void Start()
    {
        simplePlayer.Play();
    }
}
