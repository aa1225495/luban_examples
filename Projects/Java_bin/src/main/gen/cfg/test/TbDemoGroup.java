
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbDemoGroup {
    private final java.util.HashMap<Integer, cfg.test.DemoGroup> _dataMap;
    private final java.util.ArrayList<cfg.test.DemoGroup> _dataList;
    
    public TbDemoGroup(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.DemoGroup>();
        _dataList = new java.util.ArrayList<cfg.test.DemoGroup>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.DemoGroup _v;
            _v = cfg.test.DemoGroup.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.DemoGroup> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.DemoGroup> getDataList() { return _dataList; }

    public cfg.test.DemoGroup get(int key) { return _dataMap.get(key); }

}
