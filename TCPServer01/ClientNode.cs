using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace TCPServer01
{
    public class ClientNode : IEquatable<string>
    {
        public TcpClient tclient;
        public byte[] Tx, Rx;
        public string strId;

        public ClientNode()
        {
            Tx = new byte[512];
            Rx = new byte[512];
            strId = string.Empty;
            tclient = new TcpClient();
        }

        public ClientNode(TcpClient _tclient, byte[] _tx, byte[] _rx, string _str)
        {
            tclient = _tclient;
            Tx = _tx;
            Rx = _rx;
            strId = _str;
        }

        public ClientNode(TcpClient _tclient)
        {
            tclient = _tclient;
            Tx = new byte[512];
            Rx = new byte[512];
            strId = string.Empty;
        }

        bool IEquatable<string>.Equals(string other)
        {
            if (string.IsNullOrEmpty(other)) return false;

            if (tclient == null) return false;

            return strId.Equals(other);
        }

        public string ToString()
        {
            return strId;
        }
    }
}
