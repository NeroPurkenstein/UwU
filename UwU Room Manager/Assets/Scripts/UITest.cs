using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class UITest : MonoBehaviour
{
    public float opacity;
    Color col;
    PointerEventData pointerEventData;
    List<RaycastResult> raycastResultList;
    GameObject[] Floors;
    // Start is called before the first frame update
    void Start()
    {
        opacity = 0.2f;
        Floors = GameObject.FindGameObjectsWithTag("Floor");
        foreach (var g in Floors)
        {
            Debug.Log("Object Found Mention: " + g.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(IsMouseOverUIDetect())
        {
            //Debug.Log("Mouse on UI");
            floorEdit();            
        }
        else if(!IsMouseOverUIDetect())
        {
            for (int i = 0; i < Floors.Length; i++)
            {
                col = Floors[i].GetComponent<Image>().color;
                col.a = 1f;
                Floors[i].GetComponent<Image>().color = col;
            }
        }
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }

    private bool IsMouseOverUIDetect()
    {
        pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;
        raycastResultList = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, raycastResultList);
        /*for(int i=0;i<raycastResultList.Count;i++)
        {
            Debug.Log("Raycast Result [" + i + "]:" + raycastResultList[i].gameObject.name);
        }*/
        return raycastResultList.Count > 0;
    }

    void floorEdit()
    {
        if (raycastResultList[0].gameObject.name == "2F" || raycastResultList[0].gameObject.name == "3F"
               || raycastResultList[0].gameObject.name == "4F" || raycastResultList[0].gameObject.name == "5F"
               || raycastResultList[0].gameObject.name == "6F" || raycastResultList[0].gameObject.name == "7F"
               || raycastResultList[0].gameObject.name == "8F")
        {
            /////////////2F//////////////
            Debug.Log("Target Get" + raycastResultList[0].gameObject.name);
            if (raycastResultList[0].gameObject.name == "2F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "2F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "2F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
            /////////////3F//////////////
            if (raycastResultList[0].gameObject.name == "3F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "3F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "3F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
            /////////////4F//////////////
            if (raycastResultList[0].gameObject.name == "4F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "4F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "4F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
            /////////////5F//////////////
            if (raycastResultList[0].gameObject.name == "5F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "5F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "5F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
            /////////////6F//////////////
            if (raycastResultList[0].gameObject.name == "6F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "6F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "6F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
            if (raycastResultList[0].gameObject.name == "7F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "7F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "7F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
            if (raycastResultList[0].gameObject.name == "8F")
            {
                for (int i = 0; i < Floors.Length; i++)
                {
                    if (Floors[i].gameObject.name != "8F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = opacity;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                    if (Floors[i].gameObject.name == "8F")
                    {
                        col = Floors[i].GetComponent<Image>().color;
                        col.a = 1f;
                        Floors[i].GetComponent<Image>().color = col;
                    }
                }
            }
        }
    }
}
