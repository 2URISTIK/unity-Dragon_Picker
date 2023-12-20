using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Option : MonoBehaviour
{
    private int Music1 = 1;
    private int Music2 = 1;
    private int Sound1 = 0;

    private void Start()
    {
        PlayerPrefs.SetInt("Music1", Music1);
        PlayerPrefs.SetInt("Music2", Music2);
        PlayerPrefs.SetInt("Sound1", Sound1);
    }

    public void SetMusic1()
    {
        if (Music1 == 1)
        {
            Music1 = 0;
        }
        else
        {
            Music1 = 1;
        }
        PlayerPrefs.SetInt("Music1", Music1);
    }
    public void SetMusic2()
    {
        if (Music2 == 1)
        {
            Music2 = 0;
            GetComponent<AudioSource>().enabled= false;
        }
        else
        {
            Music2 = 1;
            GetComponent<AudioSource>().enabled = true;
        }
        PlayerPrefs.SetInt("Music2", Music2);
    }

    public void SetSound1()
    {
        if (Sound1 == 1)
        {
            Sound1 = 0;
        }
        else
        {
            Sound1 = 1;
        }
        PlayerPrefs.SetInt("Sound1", Sound1);
    }
}
