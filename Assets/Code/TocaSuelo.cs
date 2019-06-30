using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocaSuelo : MonoBehaviour
{
    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col){
        player.toca_suelo = true;
        Debug.Log("Colisiona: "+ player.toca_suelo);
    }
    void OnCollisionExit2D(Collision2D col)
    {
        player.toca_suelo = false;
    }
}
