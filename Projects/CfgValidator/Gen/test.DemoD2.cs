
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.test
{
public sealed partial class DemoD2 : test.DemoDynamic
{
    public DemoD2(JsonElement _buf)  : base(_buf) 
    {
        X2 = _buf.GetProperty("x2").GetInt32();
    }

    public static DemoD2 DeserializeDemoD2(JsonElement _buf)
    {
        return new test.DemoD2(_buf);
    }

    public readonly int X2;
   
    public const int __ID__ = -2138341747;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "x1:" + X1 + ","
        + "x2:" + X2 + ","
        + "}";
    }
}

}
