/*
Note that I currently don't know how to setup a nibble in C# so were going to use bytes with the first four bits set to 0000 for now

Pieces are represented by the following nibbles:
Pawn:     X001
Knight:   X110
Bishop:   X100
Rook:     X101
Queen:    X011
King:     X010
Reserved: X000 & X111 
Where the first bit represents black(0) or white(1)
i.e. the bitboard for black rooks would be under 0111
*/
using System.Collections.Generic;
namespace Chess
{
    public class PieceList {
        public ChessBitBoardDicts pieceLocations = new ChessBitBoardDicts();

        public PieceList()
        {
            // Pawns X001
            pieceLocations.Add(0b0001, 0U);
            pieceLocations.Add(0b1001, 0U);
            // Kings X010
            pieceLocations.Add(0b0010, 0U);
            pieceLocations.Add(0b1010, 0U);
            // Queens X011
            pieceLocations.Add(0b0011, 0U);
            pieceLocations.Add(0b1011, 0U);
            // Bishops X100
            pieceLocations.Add(0b0100, 0U);
            pieceLocations.Add(0b1100, 0U);
            // Knights X110
            pieceLocations.Add(0b0110, 0U);
            pieceLocations.Add(0b1110, 0U);
            // Rooks X101
            pieceLocations.Add(0b0101,0U);
            pieceLocations.Add(0b1101,0U);
        }


        //TODO: Create a setup bitboards function
    }
}