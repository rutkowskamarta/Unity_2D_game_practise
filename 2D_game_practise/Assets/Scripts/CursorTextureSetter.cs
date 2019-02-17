using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorTextureSetter : MonoBehaviour {

    [SerializeField] private Texture2D cursorTexture;

    void Awake()
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
}
