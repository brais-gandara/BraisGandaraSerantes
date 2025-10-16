using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* DECLARACIÓN VARIABLE -> ámbito/encapsulamiento ("public", "private", atributo [SerializedField]) + tipo dato + nombre
   NOMENCLATURA VARIABLE -> globales + privadas: _camelCase // públicas: PascalCase
                   ej: public int IntNumber; private int _intNumber; [SerializeField] lo muestra en visor
*/

public class HelloWorld : MonoBehaviour
{

    // Zona variables globales (DESPUÉS de clase, ANTES de métodos ("void"), funcionan en cualquier método)
    public int IntegerNumber = 0;
    [SerializeField]
    private int _privateNumber = 1;
    public float StudentGrade = 8.0f;
    public string StudentName = "Paca";
    public bool IsAnActiveStudent = true;
    public char Password = '*';
    public long BigNumber = 1218392947299297338;
    public double BigStudentGrade = 8.736722d;
    public byte LittleNumber = 255;



    // Start is called before the first frame update
    void Start()
    {
        // OPERADOR ARITMÉTICO:
        StudentGrade = 5 + (8 - ((9 * 8) / 7));
        // OPERADOR DE MÓDULO: resto de división
        LittleNumber = 2 % 1;// módulo = 0
        LittleNumber = 3 % 2;// módulo = 1

        // IMPRIMIR ERRORES EN CONSOLA + CONCADENACIÓN
        Debug.Log("El resultado de la operación de módulo es: " + LittleNumber);
        Debug.Log(LittleNumber + "342");

    }
    private void Update()
    {
        // INCREMENTO-DECREMENTO. Aumenta número en CADA FOTOGRAMA
        StudentGrade = StudentGrade + 1; // TAMBIÉN StGr++; StGr--; StGr +=1;
        LittleNumber = 254;
        Debug.Log(LittleNumber);

    }
}