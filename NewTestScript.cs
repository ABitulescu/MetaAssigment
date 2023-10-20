using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [Test]
    public void GameOn()
    {
        if (Application.isPlaying)
        {
            Debug.Log("Game on");
        }
        else
        {
            Debug.Log("Game not on");
        }
    }

    [Test]
    public void CameraPos()
    {
        
        Debug.Log("Camera position =" + Camera.main.transform.position);
    }

    [Test]
    public void CotrollerPositions()
    {
        Debug.Log("RightController position =" + GameObject.Find("RightController").transform.position);
        Debug.Log("LeftController position =" + GameObject.Find("LeftController").transform.position);
    }

    [Test]
    public void Light()
    {
        bool myLight = GameObject.Find("Light");

        if (myLight)
        {
            myLight = false;
        }

    }


}
