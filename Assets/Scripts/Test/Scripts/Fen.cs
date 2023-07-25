// A class for using Fen notation, primarily used for building boards

using System.Collections.Generic;
using System;
using UnityEngine;


namespace Chess
{
    public static class Fen {
        public static ChessBitBoardDicts bitboardsFromFen(string f = null) {
            
            ChessBitBoardDicts ReturnDict = new PieceList().pieceLocations;
            
            int locationCounter = 0;
            foreach (char c in f) {
                if ("pPkKqQbBrRnN".Contains(c)) {
                    Debug.Log("Piece " + c + " at " + Convert.ToString(locationCounter));
                    ReturnDict[PieceCharByteDict[c]] |= (1UL << locationCounter); 
                    locationCounter++;
                } else if (c == '/') {
                    
                } else {
                    int locationAdder = (int)(char.GetNumericValue(c));
                    Debug.Log("Adding locations: " + Convert.ToString(locationAdder));
                    locationCounter = locationCounter + locationAdder;
                    Debug.Log("Location Counter now at: " + Convert.ToString(locationCounter));
                }
            }
            return ReturnDict;
        }


        private static Dictionary<char, byte> PieceCharByteDict = new Dictionary<char, byte>{
            /*
            Pawn:     X001
            Knight:   X110
            Bishop:   X100
            Rook:     X101
            Queen:    X011
            King:     X010
            Reserved: X000 & X111 
            */
            {'p', 0b0001},
            {'P', 0b1001},
            {'k', 0b0010},
            {'K', 0b1010},
            {'q', 0b0011},
            {'Q', 0b1011},
            {'b', 0b0100},
            {'B', 0b1100},
            {'r', 0b0101},
            {'R', 0b1101},
            {'n', 0b0110},
            {'N', 0b1110},
        };


    }
}