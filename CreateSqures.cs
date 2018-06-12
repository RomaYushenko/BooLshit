using UnityEngine;

public class CreateSqures : MonoBehaviour
{
    
    public GameObject pref, platform;
    float posX, posY, newPosX;

    public Sprite [] sprites;

    void Start()
    {
        GameObject[,] Gam = new GameObject[8, 8];
        
        FirstPlaces();
        
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Gam[i, j] = Instantiate(pref, transform);
            }
        }
        
        SortBlocks(Gam);
        ChangeSprite(Gam);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SortBlocks(GameObject[,] mas)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i == 0 && j == 0)
                {
                    mas[i, j].transform.localPosition = new Vector2(newPosX, posY);
                }
                else
                {
                    mas[i, j].transform.localPosition = new Vector2(newPosX, posY);
                }
                
                newPosX += 0.2f;
            }
            
            posY -= 0.2f;
            newPosX = posX;
        }
    }

    void FirstPlaces()
    {
        float width = platform.GetComponent<RectTransform>().sizeDelta.x;
        float height = platform.GetComponent<RectTransform>().sizeDelta.y;

        posX = -(width / 2) + 0.15f;
        posY = (height / 2) - 0.15f;
        
        newPosX = posX;
    }

    void ChangeSprite(GameObject [,] mas)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                int z = Random.Range(0, 14);
                mas[i, j].GetComponent<SpriteRenderer>().sprite = sprites[z];
            }
        }
    }

}
