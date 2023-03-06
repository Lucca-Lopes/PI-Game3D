using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventorycontroler : MonoBehaviour
{
    public Object[] slots;
    public Image[] SlotImage;
    public int []SlotAmount;

    private interfacecontroler icontroller; 
    void Start()
    {
        icontroller = FindObjectOfType<interfacecontroler>();   
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width /2,Screen.height /2));
        if(Physics.Raycast(ray, out hit, 5f))
        {
            if(hit.collider.tag=="object")
            {
                icontroller.itemtext.text = "aperte (e) para coletar o item" + hit.transform.GetComponent<Objecttybe>().objectType.itenName;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    for(int i=0; i <slots.Length; i++)
                    {
                        if (slots[i] == null || slots[i].name == hit.transform.GetComponent<Objecttybe>().objectType.name)
                        {
                            slots[i]= hit.transform.GetComponent<Objecttybe>().objectType;
                            SlotAmount[i]++;
                            SlotImage[i].sprite = slots[i].itemSprinte;

                            Destroy(hit.transform.gameObject);
                            break;
                        }
                    }
                }
                else if(hit.collider.tag != "object")
                {
                    icontroller.itemtext.text = null;
                }
            }
        }
    }
}
