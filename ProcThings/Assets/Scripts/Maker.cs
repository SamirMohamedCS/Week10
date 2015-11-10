using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Maker : MonoBehaviour {

    public GameObject mouse, cat;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit mouseHit = new RaycastHit();
		if(Input.GetMouseButton (0))
		{
			if(Physics.Raycast (mouseRay, out mouseHit, 100f))
			{
				if(mouseHit.collider.gameObject.tag == "Floor")
				{
					GameObject newMouse = (GameObject)Instantiate (mouse, new Vector3(mouseHit.point.x, 2.5f, mouseHit.point.z),
					                                              Quaternion.identity);
				}
			}
		}

		if(Input.GetMouseButtonDown (1))
		{
            if (Physics.Raycast(mouseRay, out mouseHit, 100f))
            {
                if (mouseHit.collider.gameObject.tag == "Floor")
                {
                    GameObject newMouse = (GameObject)Instantiate(cat, new Vector3(mouseHit.point.x, 2.5f, mouseHit.point.z),
                                                                  Quaternion.identity);
                }
            }
        }
	}

	public void Restart()
	{
		Application.LoadLevel(0);
	}
}
