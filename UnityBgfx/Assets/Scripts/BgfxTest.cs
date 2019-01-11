using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SharpBgfx;
using System;
using System.Runtime.InteropServices;

public class BgfxTest : MonoBehaviour
{
    public Image imageTem;
    public Image image;
    private int width;
    private int height;

    // Start is called before the first frame update
    void Start()
    {
        width = (int)image.rectTransform.rect.width;
        height = (int)image.rectTransform.rect.height;

        bool isInit = Bgfx.Init();
        Debug.Log("bgfx initial result: " + isInit);
        // enable debug text
        //Bgfx.SetDebugFeatures(DebugFeatures.DisplayText);
        //// set view 0 clear state
        //Bgfx.SetViewClear(0, ClearTargets.Color | ClearTargets.Depth, 0x303030ff);

        // Bgfx.SetWindowHandle(image.mainTexture.GetNativeTexturePtr());
        //PlatformData platformData = new PlatformData();
        //platformData.DisplayType = System.IntPtr.Zero;
        //platformData.WindowHandle = image.mainTexture.GetNativeTexturePtr();
        //string str = "aassssssssss";

        //IntPtr initstr = Marshal.StringToHGlobalAnsi(str);
        //platformData.Context = imageTem.mainTexture.g;
        //platformData.Backbuffer = System.IntPtr.Zero;
        //platformData.BackbufferDepthStencil = System.IntPtr.Zero;
        //Bgfx.SetPlatformData(platformData);


    }


    //// Update is called once per frame
    //void Update()
    //{

    //    Bgfx.SetViewRect(0, 0, 0, width, height);
    //    Bgfx.DebugTextClear();
    //    Bgfx.DebugTextImage(
    //        Mathf.Max(width / 2 / 8, 20) - 20,
    //        Mathf.Max(height / 2 / 16, 6) - 6,
    //        40, 12,
    //       Logo.Bytes,
    //        160
    //    );

    //    Bgfx.DebugTextWrite(0, 1, DebugColor.Blue, DebugColor.Blue, "SharpBgfx/Samples/00-HelloWorld");

    //    // advance to the next frame. Rendering thread will be kicked to
    //    // process submitted rendering primitives.
    //    Bgfx.Frame();
    //}

    private void OnDestroy()
    {
        Bgfx.Shutdown();
    }
}
