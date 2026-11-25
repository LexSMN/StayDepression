using UnityEngine;
using UnityEngine.SceneManagement;

public class MUROS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTrigerEnter2D (Collider2D collision)
    {
        if (collision.tag == "sig pasillo")
        {
            SceneManager.LoadScene(2);
        }

        if (collision.tag == "sig Class")
        {
            SceneManager.LoadScene(3);
        }

        if (collision.tag == "sig casa")
        {
            SceneManager.LoadScene(4);
        }

        if (collision.tag == "sig sala")
        {
            SceneManager.LoadScene(5);
        }

        if (collision.tag == "sig cuarto")
        {
            SceneManager.LoadScene(6);
        }

        if (collision.tag == "sig consulta")
        {
            Invoke("dormir", 1);
        }

         private void dormir()
    {
        SceneManager.LoadScene(7);
    }
}
}
