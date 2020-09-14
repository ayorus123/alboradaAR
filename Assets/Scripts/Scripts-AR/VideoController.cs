using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer vp;
    //public Texture defaultTex;
    //public RenderTexture renderTex;

    public void onEnable()
    {
        if (vp != null)
        {
            vp.Play();
        }
    }
    public void onDisabled()
    {
        if (vp != null)
        {
            vp.Stop();
            //Graphics.Blit(defaultTex, renderTex);
        }
    }

}
