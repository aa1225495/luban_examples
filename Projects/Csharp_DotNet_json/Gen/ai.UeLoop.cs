
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.ai
{
public sealed partial class UeLoop : ai.Decorator
{
    public UeLoop(JsonElement _buf)  : base(_buf) 
    {
        NumLoops = _buf.GetProperty("num_loops").GetInt32();
        InfiniteLoop = _buf.GetProperty("infinite_loop").GetBoolean();
        InfiniteLoopTimeoutTime = _buf.GetProperty("infinite_loop_timeout_time").GetSingle();
    }

    public static UeLoop DeserializeUeLoop(JsonElement _buf)
    {
        return new ai.UeLoop(_buf);
    }

    public readonly int NumLoops;
    public readonly bool InfiniteLoop;
    public readonly float InfiniteLoopTimeoutTime;
   
    public const int __ID__ = -513308166;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "flowAbortMode:" + FlowAbortMode + ","
        + "numLoops:" + NumLoops + ","
        + "infiniteLoop:" + InfiniteLoop + ","
        + "infiniteLoopTimeoutTime:" + InfiniteLoopTimeoutTime + ","
        + "}";
    }
}

}
