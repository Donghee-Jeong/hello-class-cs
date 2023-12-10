using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    private void Start() {
        Animal tom = new Animal();
        tom.name = "톰";
        tom.sound = "야옹~";

        tom.PlaySound();
    }
}
