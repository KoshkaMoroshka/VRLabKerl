using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lohkiller1 : MonoBehaviour
{
    public static float score = 0;
    public GameObject text;


    void Start()
    {
        text = GameObject.FindGameObjectsWithTag("legushka")[0];
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

    private float getscore()
    {
        return transform.position.x;
    }
}
