
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.ai
{
public partial class TbBlackboard
{
    private readonly System.Collections.Generic.Dictionary<string, ai.Blackboard> _dataMap;
    private readonly System.Collections.Generic.List<ai.Blackboard> _dataList;
    
    public TbBlackboard(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<string, ai.Blackboard>();
        _dataList = new System.Collections.Generic.List<ai.Blackboard>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ai.Blackboard _v;
            _v = ai.Blackboard.DeserializeBlackboard(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Name, _v);
        }
    }

    public System.Collections.Generic.Dictionary<string, ai.Blackboard> DataMap => _dataMap;
    public System.Collections.Generic.List<ai.Blackboard> DataList => _dataList;

    public ai.Blackboard GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ai.Blackboard Get(string key) => _dataMap[key];
    public ai.Blackboard this[string key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
