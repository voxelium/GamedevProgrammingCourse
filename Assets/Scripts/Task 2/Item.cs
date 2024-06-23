using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Имя предмета
    public String Name = "Skoropeya";

    //Стоимость предмета
    public float price = 115f;

    //Иконка предмета
    public Sprite sprite;

    //Редкость предмета (шанс выпадения)
    public float dropChance = 10f;

}
