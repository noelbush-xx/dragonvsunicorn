using UnityEngine;
using System.Collections;

public class tileGenerator : MonoBehaviour {

	public GameObject[] tiles;


	static int mapHeight = 32;
	static int mapWidth = 24;
	private int[,] map = new int[mapHeight,mapWidth] ; 

	// Use this for initialization
	void Start () {
		Debug.Log (tiles.GetLength (0));
		for (int i=0;i < map.GetLength(0); i++){
			for(int j=0;j < map.GetLength(1);j++){
				int elem = Random.Range(-3,4);
				map[i,j] = elem;
				Instantiate(tiles[elem+3],new Vector3(i,j,0),Quaternion.identity); 
				//Instantiate(tiles[elem+3]); 
			}
		}
		//string.Join(",",map.select(
	}


	// Update is called once per frame
	void Update () {
	
	}
}
