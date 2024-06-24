using System;
using UnityEngine;

public class Item : MonoBehaviour
{
    //Имя предмета
    [SerializeField] private String _name = "ItemShop";
    public String Name => _name;

    //Стоимость предмета
    [SerializeField] private float _price = 115f;
    public float Price => _price;

    //Иконка предмета
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite;

    //Редкость предмета (шанс выпадения)
    [SerializeField] private float _dropChance = 10f;
    public float DropChance => _dropChance;
}
