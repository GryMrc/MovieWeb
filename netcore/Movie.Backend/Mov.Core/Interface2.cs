using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mov.Core
{
    public interface Interface2
    {
        byte[] Serialize<T>(T obj);
        void Serialize<T>(MemoryStream memoryStream, T obj);
        T Deserialize<T>(byte[] data);
        T Deserialize<T>(MemoryStream memoryStream);
    }
}
