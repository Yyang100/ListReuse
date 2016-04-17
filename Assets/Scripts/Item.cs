using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SendString(string str)
    {
        if (str == null) return;
        this.transform.Find("Label").GetComponent<UILabel>().text = str;
    }
}
