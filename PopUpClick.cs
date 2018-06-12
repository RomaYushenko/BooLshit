using UnityEngine;

public class PopUpClick : MonoBehaviour 
{

    public GameObject PopUp;

    void OnMouseDown()
    {
        PopUp.SetActive(false);
        GameObject[] sss = GameObject.FindGameObjectsWithTag("Color");
        
        for (int i = 0; i < sss.Length; i++)
        {
            sss[i].gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
