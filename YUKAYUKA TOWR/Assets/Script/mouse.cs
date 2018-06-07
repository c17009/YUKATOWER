using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetMouseButtonDown(0))
        {
            Vector3 Screen = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            Vector3 world = Camera.main.ScreenToWorldPoint(Screen);

            //Collider2D col = Physics2D.OverlapPoint(world);
        }*/
    }

    private void OnMouseDown()
    {
        print("AAJHFKJHHF");
    }

    private void OnMouseDrag()
    {
    }
}
