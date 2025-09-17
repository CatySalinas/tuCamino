using System.Collections;
using System.IO;
using UnityEngine;

public class PhotoCamera : MonoBehaviour
{
    public Camera Camera;
    public RenderTexture renderTexture;

    public void TakePhoto() {
        StartCoroutine(CaptureFlowers());
    }


    IEnumerator CaptureFlowers()
    {
        yield return new WaitForEndOfFrame();
        Camera.Render();

        RenderTexture currentActiveRT = RenderTexture.active;

        RenderTexture.active = renderTexture;

        Texture2D screenshot = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
        screenshot.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        screenshot.Apply();

        RenderTexture.active = currentActiveRT;

        byte[] data = screenshot.EncodeToPNG();

        string filename = string.Format("Screenshot_{0}.png", System.DateTime.Now.ToString("yyyyMMdd_HHmmss"));
        string filePath = Path.Combine(Application.persistentDataPath, filename);
        File.WriteAllBytes(filePath, data);
        Debug.Log("Screenshot saved to: " + filePath);

        Destroy(screenshot);

    }
}
