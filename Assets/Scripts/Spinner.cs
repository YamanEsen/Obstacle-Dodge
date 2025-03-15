using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xangle = 0f;
    [SerializeField] float yangle = 1f;
    [SerializeField] float zangle = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xangle,yangle,zangle);
    }
}
