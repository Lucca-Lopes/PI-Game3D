using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="new item",menuName="item/Create new item")]
public class item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
}
