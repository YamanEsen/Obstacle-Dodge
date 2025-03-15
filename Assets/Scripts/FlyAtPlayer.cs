using System;
using System.Numerics;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float speed = 0.01f;
    [SerializeField] Transform player;
    UnityEngine.Vector3 playerPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        
        playerPosition = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
        
    }

    void MoveToPlayer()
    {
        transform.position = UnityEngine.Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReached(){
        if(transform.position == playerPosition){
            Destroy(gameObject);
        }
    }
}
