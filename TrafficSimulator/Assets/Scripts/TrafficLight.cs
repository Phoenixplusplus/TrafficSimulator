using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> lightObjects;
    private List<Material> lightMaterials = new List<Material>();
    public enum state { RED, YELLOW, GREEN };

    private state startState = state.RED;
    private state lightState;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lightObjects.Count; i++)
        {
            lightMaterials.Add(lightObjects[i].GetComponent<Renderer>().material);
        }
        lightMaterials[0].EnableKeyword("_Emission");
        lightMaterials[0].SetColor("_Emission", new Color(255, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public state getState()
    {
        return lightState;
    }

    public void setStartState(state _startState)
    {
        startState = _startState;
    }
}
