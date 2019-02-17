using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControllerScript : MonoBehaviour {

    [SerializeField] private float smoothDelay = 0.1f;
    [SerializeField] private float playersDelay = 3f;
    [SerializeField] private GameObject playersSprite;
    [SerializeField] private GameObject cursorGameObject;

   
	
	void Update () {
        RotatePlayerTowardsMousePositon();	
	}

    private void RotatePlayerTowardsMousePositon()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouse - (Vector2)transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        cursorGameObject.transform.rotation = Quaternion.Euler(cursorGameObject.transform.eulerAngles.x, cursorGameObject.transform.eulerAngles.y, angle-90);
        playersSprite.transform.rotation = Quaternion.Slerp(playersSprite.transform.rotation, cursorGameObject.transform.rotation, Time.deltaTime * playersDelay);
    }
}
