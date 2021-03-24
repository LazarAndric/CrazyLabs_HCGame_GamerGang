using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Movement movement;
    [SerializeField]
    private MoveHandlerScriptableObject moveHandler;

    void Start()
    {
        Instantiate(prefab, gameObject.transform);
    }
    void Update()
    {
        movement.Move(gameObject, Space.Self, moveHandler.speed);
    }
}
