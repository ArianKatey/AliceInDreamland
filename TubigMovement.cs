using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubigMovement : MonoBehaviour
{
    [Range(-1f, 1f)]
    public float scrollSpeed = 0.02f;
    private float offset;
    private Material mat;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
    private void Update()
    {
        offset += (Time.deltaTime + scrollSpeed) / 20f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
