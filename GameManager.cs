using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this GameManager script is the generic script that will work for the whole game
// so do not attach this script to any particular game object

public class GameManager : MonoBehaviour
{
    GameObject[] cubes;
    // set as an array because the variable is representing all the cubes in the game instead of just one cube
    GameObject[] spheres;
    // set as an array because the variable is representing all the spheres in the game instead of just one sphere

    // Start is called before the first frame update
    void Start()
    {
        // GameObject cube = GameObject.FindWithTag("Cube");
        // Destroy(cube);

        cubes = GameObject.FindGameObjectsWithTag("Cube");
        spheres = GameObject.FindGameObjectsWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            foreach(GameObject cube in cubes){
                Destroy(cube.gameObject);
            }
            // self explanatory but the for loop traverses through each element that equals cubes and destroys them
        }
        if(Input.GetMouseButtonDown(1)){
            foreach(GameObject sphere in spheres){
                Destroy(sphere.gameObject);
            }
        }
    }
}