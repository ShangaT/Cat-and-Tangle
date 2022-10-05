using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Text record;

    // Start is called before the first frame update
    void Start()
    {
        record.text = " " + PlayerPrefs.GetInt("Record").ToString();
    }
}
