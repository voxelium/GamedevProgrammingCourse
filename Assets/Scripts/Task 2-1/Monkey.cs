using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour
{
    [SerializeField] private string _name = "Player";
    [SerializeField] private float _moveSpeed = 1.3f;
    [SerializeField] private int _collectedBananas = 0;
    [SerializeField] private bool _isBananasCollected = false;
    [SerializeField] private float _size = 1;
    [SerializeField] private float _jumpSpeed = 5f;

    private Rigidbody _rigidbody;


    private void Start()
    {
        Debug.Log("Monkey's name: " + _name);
        Debug.Log("Monkey's speed: " + _moveSpeed);
        Debug.Log("Monkey's collected bananas: " + _collectedBananas);
        Debug.Log("All the bananas have been collected: " + _isBananasCollected);
        Debug.Log("Monkey's size: " + _size);
        Debug.Log("Monkey's jump speed: " + _jumpSpeed);

        _rigidbody = GetComponent<Rigidbody>();

        transform.localScale *= _size;
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out Floor floor))
        {
            Vector3 jumpVelocity = new Vector3(0f, _jumpSpeed, 0);
            _rigidbody.velocity = jumpVelocity;
        }
    }


}
