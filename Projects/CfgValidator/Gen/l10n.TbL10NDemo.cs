
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.l10n
{
public partial class TbL10NDemo
{
    private readonly System.Collections.Generic.Dictionary<int, l10n.L10NDemo> _dataMap;
    private readonly System.Collections.Generic.List<l10n.L10NDemo> _dataList;
    
    public TbL10NDemo(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, l10n.L10NDemo>();
        _dataList = new System.Collections.Generic.List<l10n.L10NDemo>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            l10n.L10NDemo _v;
            _v = l10n.L10NDemo.DeserializeL10NDemo(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, l10n.L10NDemo> DataMap => _dataMap;
    public System.Collections.Generic.List<l10n.L10NDemo> DataList => _dataList;

    public l10n.L10NDemo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public l10n.L10NDemo Get(int key) => _dataMap[key];
    public l10n.L10NDemo this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
