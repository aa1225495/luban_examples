
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbMultiRowTitle {
    private final java.util.HashMap<Integer, cfg.test.MultiRowTitle> _dataMap;
    private final java.util.ArrayList<cfg.test.MultiRowTitle> _dataList;
    
    public TbMultiRowTitle(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.MultiRowTitle>();
        _dataList = new java.util.ArrayList<cfg.test.MultiRowTitle>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.MultiRowTitle _v;
            _v = cfg.test.MultiRowTitle.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.MultiRowTitle> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.MultiRowTitle> getDataList() { return _dataList; }

    public cfg.test.MultiRowTitle get(int key) { return _dataMap.get(key); }

}
