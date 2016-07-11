using UnityEngine;
using System.Collections;


public class AutoDestroy: MonoBehaviour
{
	public float time;


	void OnEnable()
	{
		StartCoroutine("CheckIfAlive");
	}
	
	IEnumerator CheckIfAlive ()
	{
		yield return new WaitForSeconds(time);
		GameObject.Destroy(this.gameObject);
	}
}
