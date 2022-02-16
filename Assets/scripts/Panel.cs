using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject panel;   // ������ �� ������
    int checker = 0;
    private void Start()
    {
        panel.SetActive(false);
    }
    
    private void OnMouseDown()
    {
        GameObject app = GameObject.Find("__app");
        if(app.GetComponent<PanelController>().activePanel != null)
        {
            app.GetComponent<PanelController>().activePanel.GetComponent<Panel>().togglePanel();
        }
        
        //�������� ������� �� �����-�� ������
        //���� �������, �� �������� � ��� toggle panel
        togglePanel();
        app.GetComponent<PanelController>().activePanel = gameObject;
    }
    public void togglePanel()
    {
        if(panel.activeSelf)
        {
            panel.SetActive(false);
            GameObject app = GameObject.Find("__app");
            app.GetComponent<PanelController>().activePanel = null;
        }
        else
        {
            panel.SetActive(true);
        }
    }
}
