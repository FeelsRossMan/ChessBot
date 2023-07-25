using System.Collections.Generic;
using System;
using UnityEngine;
namespace Chess {
    public class ChessBitBoardDicts : Dictionary<byte,ulong> {

        public ChessBitBoardDicts printBitboardDict() 
            {
                foreach(KeyValuePair<byte, ulong> entry in this)
                {
                    Debug.Log(Convert.ToString(entry.Key,2).PadLeft(4,'0'));
                    Debug.Log(Convert.ToString((long)entry.Value,2).PadLeft(64,'0'));
                }
                return this;
            }
        }
}