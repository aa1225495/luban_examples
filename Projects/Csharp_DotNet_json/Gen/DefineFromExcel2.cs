
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg
{
public sealed partial class DefineFromExcel2 : Luban.BeanBase
{
    public DefineFromExcel2(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        X1 = _buf.GetProperty("x1").GetBoolean();
        X5 = _buf.GetProperty("x5").GetInt64();
        X6 = _buf.GetProperty("x6").GetSingle();
        X8 = _buf.GetProperty("x8").GetInt32();
        X10 = _buf.GetProperty("x10").GetString();
        X13 = (test.DemoEnum)_buf.GetProperty("x13").GetInt32();
        X132 = (test.DemoFlag)_buf.GetProperty("x13_2").GetInt32();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf.GetProperty("x14"));
        X15 = test.Shape.DeserializeShape(_buf.GetProperty("x15"));
        V2 = vector2.Deserializevector2(_buf.GetProperty("v2"));
        T1 = _buf.GetProperty("t1").GetInt64();
        { var __json0 = _buf.GetProperty("k1"); int _n0 = __json0.GetArrayLength(); K1 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  K1[__index0++] = __v0; }   }
        { var __json0 = _buf.GetProperty("k2"); int _n0 = __json0.GetArrayLength(); K2 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  K2[__index0++] = __v0; }   }
        { var __json0 = _buf.GetProperty("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  K8.Add(_k0, _v0); }   }
        { var __json0 = _buf.GetProperty("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.DemoE2 __v0;  __v0 = test.DemoE2.DeserializeDemoE2(__e0);  K9.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("k10"); K10 = new System.Collections.Generic.List<vector3>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { vector3 __v0;  __v0 = vector3.Deserializevector3(__e0);  K10.Add(__v0); }   }
        { var __json0 = _buf.GetProperty("k11"); K11 = new System.Collections.Generic.List<vector4>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { vector4 __v0;  __v0 = vector4.Deserializevector4(__e0);  K11.Add(__v0); }   }
    }

    public static DefineFromExcel2 DeserializeDefineFromExcel2(JsonElement _buf)
    {
        return new DefineFromExcel2(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool X1;
    public readonly long X5;
    public readonly float X6;
    public readonly int X8;
    public readonly string X10;
    public readonly test.DemoEnum X13;
    public readonly test.DemoFlag X132;
    public readonly test.DemoDynamic X14;
    public readonly test.Shape X15;
    public readonly vector2 V2;
    public readonly long T1;
    public readonly int[] K1;
    public readonly int[] K2;
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    public readonly System.Collections.Generic.List<test.DemoE2> K9;
    public readonly System.Collections.Generic.List<vector3> K10;
    public readonly System.Collections.Generic.List<vector4> K11;
   
    public const int __ID__ = 482045152;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        
        
        X14?.ResolveRef(tables);
        X15?.ResolveRef(tables);
        
        
        
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "x1:" + X1 + ","
        + "x5:" + X5 + ","
        + "x6:" + X6 + ","
        + "x8:" + X8 + ","
        + "x10:" + X10 + ","
        + "x13:" + X13 + ","
        + "x132:" + X132 + ","
        + "x14:" + X14 + ","
        + "x15:" + X15 + ","
        + "v2:" + V2 + ","
        + "t1:" + T1 + ","
        + "k1:" + Luban.StringUtil.CollectionToString(K1) + ","
        + "k2:" + Luban.StringUtil.CollectionToString(K2) + ","
        + "k8:" + Luban.StringUtil.CollectionToString(K8) + ","
        + "k9:" + Luban.StringUtil.CollectionToString(K9) + ","
        + "k10:" + Luban.StringUtil.CollectionToString(K10) + ","
        + "k11:" + Luban.StringUtil.CollectionToString(K11) + ","
        + "}";
    }
}

}
