using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    [SerializeField] private Item _item;
    [SerializeField] private SpriteRenderer _spriteRenderer;


    private void Start()
    {
        Debug.Log("Имя предмета: " + _item.Name + "\nСтоимость предмета: " + _item.price);
        Debug.Log("Шанс выпадения предмета: " + _item.dropChance);

        _spriteRenderer.sprite = _item.sprite;
    }



}
