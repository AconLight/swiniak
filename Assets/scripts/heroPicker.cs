using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroPicker : MonoBehaviour
{

    public GameObject headPicker;
    public GameObject bodyPicker;
    public GameObject legPicker;
    private List<GameObject> pickers;

    private int currentPicker = 0;

    public void moveRight() {
        currentPicker += 1;
        currentPicker %= pickers.Count;
    }

    public void moveLeft() {
        currentPicker -= 1;
        currentPicker %= pickers.Count;
    }

    // Start is called before the first frame update
    void Start()
    {
        pickers = new List<GameObject>();
        pickers.Add(headPicker);
        pickers.Add(bodyPicker);
        pickers.Add(legPicker);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
