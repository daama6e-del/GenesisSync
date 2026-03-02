using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text ScoreDisplay;
    public int ThreeStars = 4;
    public int TwoStars = 10;
    public Animator scoreAnimator;
    public int nextLevel = 0;
    public void Endlevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();

        int shotCount = cannon.shotsCount;

        if (cannon)
        {
            Animation playIt = scoreAnimator.GetComponent<Animation>(); //Some how it work by actually trying trial and error. It works- Do not touchie!

            if (shotCount < ThreeStars)
            {
                ScoreDisplay.text = "Good Job, you get a gold star for the day.";
                scoreAnimator.SetInteger("Stars", 3);
                Instantiate(scoreAnimator);
            }

            else if (shotCount < TwoStars)
            {
                ScoreDisplay.text = "Everyone gets a gold star, you get two.";
                scoreAnimator.SetInteger("Stars", 2);
                Instantiate(scoreAnimator);
            }

            else
            {
                ScoreDisplay.text = "What are you???";
                scoreAnimator.SetInteger("Stars", 1);
                Instantiate(scoreAnimator);
            }
            Invoke("NextLevel", 0.4f);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
