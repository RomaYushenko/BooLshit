using UnityEngine;

public class DragPlatform : MonoBehaviour
{
    public GameObject Platform;
    float posY = 0;

    void OnMouseDown()
    {
        posY = Input.mousePosition.y;
    }

    void OnMouseDrag()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, 
                                                Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Platform.transform.localPosition = new Vector3(Platform.transform.localPosition.x, 
                                                        Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
    }

    void OnMouseUp()
    {
        if (transform.localPosition.y > 0)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 3.8f);
            Platform.transform.localPosition = new Vector3(Platform.transform.localPosition.x, 3.8f);
        }
        else
        {
            transform.localPosition = new Vector3(transform.localPosition.x, -3.5f);
            Platform.transform.localPosition = new Vector3(Platform.transform.localPosition.x, -3.8f);
        }
    }
}
