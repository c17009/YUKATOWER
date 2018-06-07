using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generater : MonoBehaviour {
    public GameObject[] nakano;

	// Use this for initialization
	void Start () {
        int s = Random.Range(0, nakano.Length);
        print("len" + nakano.Length);
        print(s);
        Instantiate(nakano[s], transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void Genarate()
    {
        int v = Random.Range(0, nakano.Length);
        print("len" + nakano.Length);
        print(v);
        Instantiate(nakano[v], transform.position, Quaternion.identity);
    }
}
