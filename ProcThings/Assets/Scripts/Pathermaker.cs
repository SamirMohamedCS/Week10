using UnityEngine;
using System.Collections;

public class Pathermaker : MonoBehaviour {

	public static int floorMakerCount = 1;
	public static int totalTiles = 0;
    int counter;
    public Transform floorPrefab, pathmakerPrefab;
	//int thickness = 1;
	int numTiles = 50;
	float rotation = 0f;
	float instantiationChance = .98f;
    float min = -100, max = 100;
    Quaternion standardTileRotation;

	void Start()
	{
		//thickness = Random.Range (1, 3);
		numTiles = Random.Range (40, 90);
		rotation = Random.Range (-1, 1) * 90f;
		instantiationChance = Random.Range (.97f, .99f);
        standardTileRotation = transform.rotation * Quaternion.Euler(0, 90, 90);
	}
	
	
	// Update is called once per frame
	void Update () 
    {
	    if(counter < numTiles)
        {
            float rand = Random.value;
            //float rotation = 0f;
			Vector3 direction = new Vector3(5f, 0f, 0f);
            if(rand < .25f)
            {
				direction = new Vector3(5f, 0f, 0f);
            }
            else if (rand < .5f)
            {
				direction = new Vector3(0f, 0f, 5f);
            }
			else if (rand < .75f)
			{
				direction = new Vector3(0f, 0f, -5f);
			}
            else if (rand > instantiationChance)
            {
                //make prefab
                Instantiate(pathmakerPrefab, transform.position, Quaternion.Euler (0f, rotation, 0f));
				floorMakerCount++;
            }

			if(totalTiles > 2000 || transform.position.x > max || transform.position.x < min
                                    || transform.position.y > max || transform.position.y < min
                                    || transform.position.z > max || transform.position.z < min)
            {
                counter = numTiles + 1;
            }
			else //if(thickness == 1)
			{
				Instantiate(floorPrefab, transform.position, standardTileRotation);
				totalTiles++;
			}
			/*else if (thickness == 2)
			{ 
				Instantiate(floorPrefab, transform.position, Quaternion.identity);
				Instantiate(floorPrefab, transform.position - direction, Quaternion.identity);
				totalTiles +=2;
			}
			else if (thickness == 3) 
			{ 
				Instantiate(floorPrefab, transform.position, Quaternion.identity);
				Instantiate(floorPrefab, transform.position - direction, Quaternion.identity);
				Instantiate(floorPrefab, transform.position + direction, Quaternion.identity);
				totalTiles +=3;
			}*/
										


			transform.Translate(direction);
            counter++;
        }
		else if(floorMakerCount < 4)
		{
			Instantiate(pathmakerPrefab, transform.position, Quaternion.Euler (0f, rotation, 0f));
			floorMakerCount++;
		}
	}
}
