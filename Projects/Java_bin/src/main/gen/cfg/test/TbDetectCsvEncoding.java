
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbDetectCsvEncoding {
    private final java.util.HashMap<Integer, cfg.test.DetectEncoding> _dataMap;
    private final java.util.ArrayList<cfg.test.DetectEncoding> _dataList;
    
    public TbDetectCsvEncoding(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.DetectEncoding>();
        _dataList = new java.util.ArrayList<cfg.test.DetectEncoding>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.DetectEncoding _v;
            _v = cfg.test.DetectEncoding.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.DetectEncoding> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.DetectEncoding> getDataList() { return _dataList; }

    public cfg.test.DetectEncoding get(int key) { return _dataMap.get(key); }

}
