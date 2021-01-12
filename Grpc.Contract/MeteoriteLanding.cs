using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Grpc.Contract
{
    [ProtoContract]
    public class MeteoriteLanding
    {
        [ProtoMember(1)]
        public string Name { get; set; }

        [ProtoMember(2)]
        public string Id { get; set; }

        [ProtoMember(3)]
        public string Nametype { get; set; }

        [ProtoMember(4)]
        public string Recclass { get; set; }

        [ProtoMember(5)]
        public string Mass { get; set; }

        [ProtoMember(6)]
        public string Fall { get; set; }

        [ProtoMember(7)]
        public DateTime Year { get; set; }

        [ProtoMember(8)]
        public string Reclat { get; set; }

        [ProtoMember(9)]
        public string Reclong { get; set; }

        [ProtoMember(10)]
        public Geolocation Geolocation { get; set; }
    }

    [ProtoContract]
    public class Geolocation
    {
        [ProtoMember(1)]
        public string Type { get; set; }

        [ProtoMember(2)]
        public float[] Coordinates { get; set; }
    }
}
