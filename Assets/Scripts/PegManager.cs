using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PegManager : MonoBehaviour
{
    [SerializeField] GameObject pegMasterObject;
    [SerializeField] int levelnumber;
    private List<GameObject> pegs = new List<GameObject>();
    int keyPegCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> initialPegs = new List<GameObject>(GameObject.FindGameObjectsWithTag("Peg"));
        foreach (GameObject peg in initialPegs)
        {
            if (peg == null || peg.GetComponent<Peg>() == null)
            {
                Debug.LogWarning("Found a null peg in the scene. Skipping.");
                continue;
            }
            else if (peg.GetComponent<Peg>().isKeyPeg){
                keyPegCount++;
            }
        }
    }

    public void DeleteAllPegs()
    {
        foreach (GameObject peg in pegs)
        {
            if (peg != null)
            {
                Destroy(peg);
            }
        }
        pegs.Clear();
    }

    private void epicGamerDub()
    {
        Debug.Log("Good job, youre now a disapointment to society D:");
        // Add any additional logic for when all key pegs are collected.
        SceneManager.LoadScene("Lvl" + (levelnumber + 1));
    }

    public void AddPeg(GameObject peg)
    {
        if (peg == null)
        {
            Debug.LogError("Attempted to add a null peg to PegManager.");
            return;
        }
        if (!pegs.Contains(peg))
        {
            pegs.Add(peg);
            if (peg.GetComponent<Peg>() != null && peg.GetComponent<Peg>().isKeyPeg)
            {
                keyPegCount--;
                if (keyPegCount <= 0)
                {
                    epicGamerDub();
                }
            }
        }
        else
        {
            Debug.LogWarning("Peg already exists in PegManager: " + peg.name);
        }
    }
}
