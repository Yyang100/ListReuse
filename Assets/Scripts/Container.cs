using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Container : MonoBehaviour
{

    public SUIWrapContent warp;
List<string> stringList=new List<string>(); 
	// Use this for initialization
	void Start ()
	{
	    AddString();
	    ShowList(stringList);

	}
	
    void ShowList(List<string> stList )
    {
        warp.maxNum = stList.Count;
        warp.first = 0;
        warp.updateItemCallback = InitItem;
        warp.wrapContent = true;
        warp.Reset(false);
    }

    void InitItem(GameObject item, int index)
    {
        Item it = item.GetComponent<Item>();
        it.SendString(stringList[index]);
    }
    void AddString()
    {
        stringList.Add("1");
        stringList.Add("2");
        stringList.Add("3");
        stringList.Add("4");
        stringList.Add("5");
        stringList.Add("6");
        stringList.Add("7");
        stringList.Add("8");
        stringList.Add("9");
        stringList.Add("10");
    }
}
