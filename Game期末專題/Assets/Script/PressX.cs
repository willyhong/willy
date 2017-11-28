using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressX : MonoBehaviour {

    // Use this for initialization
    public Texture2D Logo;
    public Texture2D SysInfo;
    public Texture2D FriInfo;
    public Texture2D IcoHelp;
    public GUIStyle style;
    public GUIStyle pathStyle;
    private bool displaySysLabel = false;
    private bool displayFriLabel = false;
    IEnumerator Start()
    {
        yield return StartCoroutine(flashSysLabel());
        yield return StartCoroutine(flashFriLabel());
    }
    IEnumerator flashSysLabel()
    {
        while (true)
        {
            displaySysLabel = true;
            yield return new WaitForSeconds(0.5f);
            displaySysLabel = false;
            yield return new WaitForSeconds(0.5f);
        }
    }
    IEnumerator flashFriLabel()
    {
        while (true)
        {
            displayFriLabel = true;
            yield return new WaitForSeconds(0.5f);
            displayFriLabel = false;
            yield return new WaitForSeconds(0.5f);
        }
    }
    void OnGUI()
    {
        GUI.BeginGroup(new Rect(0, 0, 300, 100));
        GUI.Button(new Rect(3, 5, 37, 37), Logo, style);
        GUI.Button(new Rect(45, 8, 150, 15), "test", pathStyle);
        if (displaySysLabel == true)
        {
            GUI.Label(new Rect(45, 25, 16, 16), SysInfo, style);
        }
        GUI.Label(new Rect(61, 25, 16, 16), "0", style);
        if (displayFriLabel == true)
        {
            GUI.Label(new Rect(77, 25, 16, 16), FriInfo, style);
        }
        GUI.Label(new Rect(93, 25, 16, 16), "0", style);
        GUI.Label(new Rect(108, 25, 16, 16), IcoHelp, style);
        GUI.EndGroup();
    }
}
