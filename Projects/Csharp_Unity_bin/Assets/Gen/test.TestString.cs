
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
public sealed partial class TestString : Luban.BeanBase
{
    public TestString(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        S1 = _buf.ReadString();
        Cs1 = test.CompactString.DeserializeCompactString(_buf);
        Cs2 = test.CompactString.DeserializeCompactString(_buf);
    }

    public static TestString DeserializeTestString(ByteBuf _buf)
    {
        return new test.TestString(_buf);
    }

    public readonly int Id;
    public readonly string S1;
    public readonly test.CompactString Cs1;
    public readonly test.CompactString Cs2;
   
    public const int __ID__ = 338485823;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        Cs1?.ResolveRef(tables);
        Cs2?.ResolveRef(tables);
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "s1:" + S1 + ","
        + "cs1:" + Cs1 + ","
        + "cs2:" + Cs2 + ","
        + "}";
    }
}

}
