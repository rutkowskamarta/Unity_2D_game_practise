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
       
    }
}
