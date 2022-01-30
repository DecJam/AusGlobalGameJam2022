using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lines : MonoBehaviour
{
    public GameObject topClaw;
    public GameObject bottomClaw;

    public GameObject topLine;
    public GameObject bottomLine;


    void Update()
    {
        topLine.GetComponent<LineRenderer>().SetPosition(0, transform.position);
        bottomLine.GetComponent<LineRenderer>().SetPosition(0, transform.position);

        topLine.GetComponent<LineRenderer>().SetPosition(1, topClaw.transform.position);
        bottomLine.GetComponent<LineRenderer>().SetPosition(1, bottomClaw.transform.position);
    }
}
