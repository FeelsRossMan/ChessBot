using UnityEngine;

namespace Chess
{ 

    public class FenTest : MonoBehaviour
    {
        public string text = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";
        void Start() {
            ChessBitBoardDicts theTest = Fen.bitboardsFromFen(text).printBitboardDict();
            DecimalToBinary.Convert("6");
        }


    }
}