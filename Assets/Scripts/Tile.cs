using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private Pokemon pokemon;
    private Vector2 gridPos;

    public void Initialize(Vector2 pos)
    {
        pokemon = null;
        gridPos = pos;
    }

    public void Clear()
    {
        pokemon = null;
    }

    public void PlacePokemon(Pokemon poke)
    {
        if (poke != null)
        {
            pokemon = poke;
            pokemon.transform.position = transform.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 30, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
