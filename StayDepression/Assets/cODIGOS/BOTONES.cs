using UnityEngine;
using UnityEngine.SceneManagement;

public class BOTONES : MonoBehaviour
{
    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void START()
    {
        anim.SetTrigger("Emp");

        Invoke("anistart", 0.5f);

    }

    private void anistart()
    {
        SceneManager.LoadScene(1);
    }
}
