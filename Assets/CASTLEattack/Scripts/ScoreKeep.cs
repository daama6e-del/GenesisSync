using UnityEngine;

public class Score : MonoBehaviour
{
    public void Endlevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int shotCount = cannon.shotsCount;
        }

    }
}
