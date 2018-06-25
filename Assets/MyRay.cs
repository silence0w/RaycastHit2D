using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 2D射线检测   将相机改为正交Orthographic  Canvas设置未Screen space-Camera ，同时添加相机。添加collider2d、tag即可
/// </summary>
public class MyRay : MonoBehaviour {

   
	// Use this for initialization
	void Start () {
  

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
           
            Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousepos.x,mousepos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.up);
           
            if (hit.collider != null ) {

               
              //  Debug.Log("打印：" +hit.collider.tag);
                Debug.Log(hit.collider.gameObject.name);
            }

        }

	}

}
