using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegManager : MonoBehaviour
{
    private List<GameObject> pegs = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        }
        else
        {
            Debug.LogWarning("Peg already exists in PegManager: " + peg.name);
        }
    }
}
