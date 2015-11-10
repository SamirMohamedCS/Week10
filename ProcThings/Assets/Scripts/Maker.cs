using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Maker : MonoBehaviour {

    public GameObject mouse, cat;
    public static List<GameObject> mouseList = new List<GameObject>();
    public static List<GameObject> catList = new List<GameObject>();
    bool massCreation = false;

	// Use this for initialization
	void Start () 
	{
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            massCreation = !massCreation;
        }
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!massCreation)
        {
            RaycastHit mouseHit = new RaycastHit();
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(mouseRay, out mouseHit, 1000f))
                {
                    if (mouseHit.collider.gameObject.tag == "Floor")
                    {
                        GameObject newMouse = (GameObject)Instantiate(mouse, new Vector3(mouseHit.point.x, 2.5f, mouseHit.point.z),
                                                                      Quaternion.identity);
                        mouseList.Add(newMouse);
                    }
                }
            }

            if (Input.GetMouseButtonDown(1))
            {
                if (Physics.Raycast(mouseRay, out mouseHit, 1000f))
                {
                    if (mouseHit.collider.gameObject.tag == "Floor")
                    {
                        GameObject newCat = (GameObject)Instantiate(cat, new Vector3(mouseHit.point.x, 2.5f, mouseHit.point.z),
                                                                      Quaternion.identity);
                        catList.Add(newCat);
                    }
                }
            }
        }
        else
        {
            RaycastHit mouseHit = new RaycastHit();
            if (Input.GetMouseButton(0))
            {
                if (Physics.Raycast(mouseRay, out mouseHit, 1000f))
                {
                    if (mouseHit.collider.gameObject.tag == "Floor")
                    {
                        GameObject newMouse = (GameObject)Instantiate(mouse, new Vector3(mouseHit.point.x, 2.5f, mouseHit.point.z),
                                                                      Quaternion.identity);
                        mouseList.Add(newMouse);
                    }
                }
            }

            if (Input.GetMouseButton(1))
            {
                if (Physics.Raycast(mouseRay, out mouseHit, 1000f))
                {
                    if (mouseHit.collider.gameObject.tag == "Floor")
                    {
                        GameObject newCat = (GameObject)Instantiate(cat, new Vector3(mouseHit.point.x, 2.5f, mouseHit.point.z),
                                                                      Quaternion.identity);
                        catList.Add(newCat);
                    }
                }
            }
        }
	}

	public void Restart()
	{
		Application.LoadLevel(0);
	}
}
