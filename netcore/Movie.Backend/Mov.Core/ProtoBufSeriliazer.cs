using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mov.Core
{
    public class ProtobufSerializer : Interface2
    {
        public T Deserialize<T>(byte[] data)
        {
            using var ms = new MemoryStream(data);
            return Deserialize<T>(ms);
        }

        public T Deserialize<T>(MemoryStream memoryStream)
        {
            return Serializer.Deserialize<T>(memoryStream);
        }

        public byte[] Serialize<T>(T obj)
        {
            using var ms = new MemoryStream();
            Serialize(ms, obj);
            var bytes = ms.ToArray();
            return bytes;
        }

        public void Serialize<T>(MemoryStream memoryStream, T obj)
        {
            Serializer.Serialize(memoryStream, obj);
        }
    }
}