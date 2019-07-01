using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    
    public GameObject player;
   

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        float pos_x = player.transform.position.x;
        float pos_y = player.transform.position.y;

        this.transform.position = new Vector3(pos_x, pos_y, transform.position.z);
    
    }
}
