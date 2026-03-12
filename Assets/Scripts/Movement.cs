using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _movement;
    [SerializeField] private float _sidemove;

    Rigidbody _rb;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Playermove();
    }

    private void Playermove()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * _movement * Time.deltaTime;
        }
    }
}
