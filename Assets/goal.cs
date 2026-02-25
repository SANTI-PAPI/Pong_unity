
using UnityEngine;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    void OncollisionEnterD(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Respawn")
        {
            collision2D.gameObject.transform.position = new Vector2(0,0);
        }

    }
}
