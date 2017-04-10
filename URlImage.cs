using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class URlImage : MonoBehaviour {

	public Image img;

	public string url;

	//test
	public Image[] imagess;
	public string[] urles;


	// Use this for initialization
	IEnumerator Start () 
	{
		WWW www = new WWW (url);
		yield return www;
		img.sprite = Sprite.Create (www.texture, new Rect (0, 0, www.texture.width, www.texture.height), new Vector2 (0, 0));



		WWW www2 = new WWW (urles [0]);
		yield return www2;
		imagess [0].sprite = Sprite.Create (www2.texture, new Rect (0, 0, www2.texture.width, www2.texture.height), new Vector2 (0, 0));


			


	}

	IEnumerator wait()
	{
		WWW www = new WWW (urles [0]);
		yield return www;
		imagess [0].sprite = Sprite.Create (www.texture, new Rect (0, 0, www.texture.width, www.texture.height), new Vector2 (0, 0));
	}

	
	// Update is called once per frame
	void Update () {
	



	}
}
