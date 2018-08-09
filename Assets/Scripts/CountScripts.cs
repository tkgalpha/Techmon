using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScripts : MonoBehaviour {


	public  int number;
	public Text text;
	public  Text  damage;
	public int total;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
		number = 0;
		sound = GetComponent<AudioSource> ();
	
		
	}
	
	// Update is called once per frame
	void Update () {
		if (number >= 100) {
			Application.LoadLevel ("GameClear");
		}
		
	}
	public void CountUp(){
		number = number + 1;
		text.text = number.ToString ();
	}
	public void Attack(){
		total += number;
		damage.text = number.ToString ();
		sound.PlayOneShot (sound.clip);


	}
			

}
