using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnMouseDown(){
        if(this.gameObject.tag == "Cube"){
            Destroy(gameObject);
        }
    }
}
