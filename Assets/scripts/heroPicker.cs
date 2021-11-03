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
        GameObject myHeadPicker = UnityEngine.Object.Instantiate(headPicker, new UnityEngine.Vector3(0, 0, 0), UnityEngine.Quaternion.identity);
        GameObject myBodyPicker = UnityEngine.Object.Instantiate(bodyPicker, new UnityEngine.Vector3(0, -1, 0), UnityEngine.Quaternion.identity);
        GameObject myLegPicker = UnityEngine.Object.Instantiate(legPicker, new UnityEngine.Vector3(0, -2, 0), UnityEngine.Quaternion.identity);
        myHeadPicker.transform.parent = gameObject.transform;
        myBodyPicker.transform.parent = gameObject.transform;
        myLegPicker.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
