using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{

    public float timer;
    public int frameNumber = 10; //framenumber per second
    public int frameCount = 0;

    private Renderer rend;
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update ()
    {
        timer += Time.deltaTime;
        if (timer>=1.0f/frameNumber)
        {
            frameCount++;
            timer -= 1.0f / frameNumber;
            int frameIndex = frameCount % 3;

            rend.material.SetTextureOffset("_MainTex", new Vector2(0.3333333f*frameCount,0));
			
        }
    }
}