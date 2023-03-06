using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interfacecontroler : MonoBehaviour
{
    public  GameObject inventoryPanel;
    public Text itemtext;
    bool invActive;
    void Start()
    {
       itemtext.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) 
        {
            invActive =!invActive;  
            inventoryPanel.SetActive(invActive);
        }
        if(invActive) 
        {
          Cursor.lockState = CursorLockMode.None;
        }
    }
}
