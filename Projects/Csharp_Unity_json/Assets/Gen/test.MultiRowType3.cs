
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
public sealed partial class MultiRowType3 : Luban.BeanBase
{
    public MultiRowType3(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { var __json0 = _buf["items"]; if(!__json0.IsArray) { throw new SerializationException(); } Items = new System.Collections.Generic.List<test.MultiRowType1>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.MultiRowType1 __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = test.MultiRowType1.DeserializeMultiRowType1(__e0);  }  Items.Add(__v0); }   }
    }

    public static MultiRowType3 DeserializeMultiRowType3(JSONNode _buf)
    {
        return new test.MultiRowType3(_buf);
    }

    public readonly int Id;
    public readonly System.Collections.Generic.List<test.MultiRowType1> Items;
   
    public const int __ID__ = 540474972;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        foreach (var _e in Items) { _e?.ResolveRef(tables); }
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "items:" + Luban.StringUtil.CollectionToString(Items) + ","
        + "}";
    }
}

}
