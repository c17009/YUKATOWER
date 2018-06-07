using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nakano : MonoBehaviour {
    Rigidbody2D rb2d;
    private bool Down = false;
  private GameObject Gene;
    private GameObject Mane;
    public float cameraupper;
    private Vector2 before;
    private Vector2 after;
        // Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Mane = GameObject.Find("Main Camera");
        Gene = GameObject.Find("Generater");
        rb2d.constraints = RigidbodyConstraints2D.FreezePositionY;
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (Down != true)
        {
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 1);

            if (Input.touchCount >= 1)
            {
                Touch t = Input.GetTouch(0);
                int disablelayer = ~(1 << LayerMask.NameToLayer("Stage"));
                Vector3 screen = new Vector3(t.position.x, t.position.y, 0);
                Vector3 world = Camera.main.ScreenToWorldPoint(screen);

                Collider2D col = Physics2D.OverlapPoint(world,disablelayer);

                if (col)//yukaにtouchしたら
                {
                    if (t.phase == TouchPhase.Moved)
                    {
                        transform.position = new Vector2(world.x, transform.position.y);
                    }
                    if (t.phase == TouchPhase.Ended)
                    {
                        //Debug.Log("down no yuka");
                        rb2d.constraints = RigidbodyConstraints2D.None;//freezeYの解除
                        Down = true;
                    }

                }

            }
        }
		if(transform.position.y <= -1400)//落下処理
        {
            Debug.Log("OUT!!");
            Destroy(gameObject);
            GameManager.count -= 1;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Down)
        {
            print("coll");
            gameObject.layer = LayerMask.NameToLayer("Stage");
            GameManager.count += 1;
            Gene.GetComponent<Generater>().Genarate();
            Mane.GetComponent<GameManager>().CameraUp();
            print("afjsafjajk");
        }
    }
}




