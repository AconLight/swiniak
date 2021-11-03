using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partPicker : MonoBehaviour
{
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


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
