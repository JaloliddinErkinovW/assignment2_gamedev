using UnityEngine;
using System.Collections;

public class ScoreManagerScript : MonoBehaviour {

    public static int Score { get; set; }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (previousScore != Score) //save perf from non needed calculations
        { 
            if(Score < 10)
            {
                //just draw units
                Units.sprite = numberSprites[Score];
            }
            
        }

	}


    int previousScore = -1;
    public Sprite[] numberSprites;
    public SpriteRenderer Units;
}
