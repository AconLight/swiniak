using System.Numerics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partPicker : MonoBehaviour
{
    public GameObject bg;

    public GameObject rightArrow;

    public GameObject leftArrow;
    public List<GameObject> availableParts;

    private int currentPart = 0;
    // Start is called before the first frame update

    public void moveRight() {
        currentPart += 1;
        currentPart %= availableParts.Count;
    }

    public void moveLeft() {
        currentPart -= 1;
        currentPart %= availableParts.Count;
    }

    public int arrowShift;

    void Start()
    {
        UnityEngine.Object.Instantiate(rightArrow, new UnityEngine.Vector3(arrowShift, 0, 0), UnityEngine.Quaternion.identity);
        UnityEngine.Object.Instantiate(leftArrow, new UnityEngine.Vector3(-arrowShift, 0, 0), UnityEngine.Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
