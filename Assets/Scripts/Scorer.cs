using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit"){
            hits ++;
        Debug.Log("you hit something this many times :  " + hits);
        }
       
    }
}
