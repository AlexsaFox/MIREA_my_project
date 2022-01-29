using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public GameObject[] texts;
    int showTextID;
    public GameObject parentPanel;
    // Start is called before the first frame update
    void Start()
    {
        
        foreach (GameObject text in texts)
        {
            text.SetActive(false);
        }
        texts[0].SetActive(true);
    }

    public void ChangeText()
    {
        texts[showTextID].SetActive(false);
        bool isLast = showTextID == texts.Length - 1;
        if (isLast)
        {
            showTextID = 0;
        }
        else
        {
            showTextID++;
        }
        texts[showTextID].SetActive(true);
        if (isLast)
        {
            parentPanel.GetComponent<Panel>().togglePanel();
        }
    }

    void OnMouseDown()
    {
        ChangeText();
    }
}
