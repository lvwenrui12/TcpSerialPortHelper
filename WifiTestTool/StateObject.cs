using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WifiTestTool
{
    public class StateObject
    {
        public Socket workSocket = null;

        // Size of receive buffer.


        public int BufferSize { get; set; } = 1024;

        // Receive buffer.
        public byte[] buffer;

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        public StateObject()
        {
            buffer = new byte[this.BufferSize];
        }
    }
}
