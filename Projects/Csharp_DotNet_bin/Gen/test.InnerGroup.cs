
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class InnerGroup : Luban.BeanBase
{
    public InnerGroup(ByteBuf _buf) 
    {
        Y1 = _buf.ReadInt();
    }

    public static InnerGroup DeserializeInnerGroup(ByteBuf _buf)
    {
        return new test.InnerGroup(_buf);
    }

    public readonly int Y1;
   
    public const int __ID__ = -587873083;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
    }

    public override string ToString()
    {
        return "{ "
        + "y1:" + Y1 + ","
        + "}";
    }
}

}
