using UnityEngine;
using System.Collections;

public class DestroyTest : MonoBehaviour
{
	int loopCnt = 0;

	public Event ev;

	// Use this for initialization
	void Start ()
	{

	}

	void FixedUpdate()
	{
		Debug.Log ( "loopcnt fixed : " + loopCnt );

		if (loopCnt >= 10)
		{
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		loopCnt++;
		Debug.Log ( "loopcnt : " + loopCnt );
	}
}
