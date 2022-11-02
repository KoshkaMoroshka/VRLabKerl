using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lohkiller2 : MonoBehaviour
{
    public static float score = 0;
    public GameObject text;


    void Start()
    {
        text = GameObject.FindGameObjectsWithTag("zhabke")[0];
    }
    void Update()
    {
        if (transform.position.y < -1)
            Destroy(this.gameObject);

        float s = getscore();
        if (s <= score)
            return;

        text.GetComponent<TextMeshProUGUI>().SetText((score = s).ToString());
    }

    public float getscore()
    {
        return transform.position.x;
    }
    private float resolve()
    {
        float s = 0;
        GameObject[] obj = GameObject.FindGameObjectsWithTag("blue");
        foreach(GameObject o in obj)
        {
            
        }
    }
}
