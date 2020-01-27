using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDetectBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    GameObject[] Floors;
    //Color[] colors;
    string itemname;
    Color col;
    private Vector3[] defaultPos;
    // Start is called before the first frame update
    void Start()
    {
        Floors = GameObject.FindGameObjectsWithTag("Floor");
        foreach (var g in Floors)
        {
            Debug.Log("Object Found Mention: " + g.name);            
        }
        /*for (int i = 0; i < Floors.Length; i++)
        {
            colors[i] = Floors[i].GetComponent<Image>().color;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(itemname);
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover:" + transform.name);
        //itemname = eventData.pointerEnter.name;        
    }
    public void OnPointerExit(PointerEventData eventData)
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Clicked :" + eventData.pointerEnter.name);
    }
}
