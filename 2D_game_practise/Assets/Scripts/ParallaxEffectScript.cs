using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffectScript : MonoBehaviour {
    [SerializeField] private Transform[] backgroundLayers;
    [SerializeField] private float[] speeds;

    [SerializeField] private PlayerControllerScript playerControllerScipt;


	void Start () {
		
	}
	
	void Update () {
        ParallaxEffect();
	}

    private void ParallaxEffect()
    {
        Vector2 direction = playerControllerScipt.movementVector;
   
        backgroundLayers[0].transform.Translate(-direction*speeds[0]);
        backgroundLayers[1].transform.Translate(-direction*speeds[1]);
        backgroundLayers[2].transform.Translate(-direction*speeds[2]);
        //backgroundLayers[1].transform.Translate(new Vector2(direction.x * speeds[1], direction.y*-speeds[1]));
        //backgroundLayers[2].transform.Translate(new Vector2(direction.x * speeds[2], direction.y*-speeds[2]));
       
    }
}
