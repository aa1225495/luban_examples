
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


type TestTbTestMapper struct {
    _dataMap map[int32]*TestTestMapper
    _dataList []*TestTestMapper
}

func NewTestTbTestMapper(_buf []map[string]interface{}) (*TestTbTestMapper, error) {
    _dataList := make([]*TestTestMapper, 0, len(_buf))
    dataMap := make(map[int32]*TestTestMapper)

    for _, _ele_ := range _buf {
        if _v, err2 := NewTestTestMapper(_ele_); err2 != nil {
            return nil, err2
        } else {
            _dataList = append(_dataList, _v)
            dataMap[_v.Id] = _v
        }
    }
    return &TestTbTestMapper{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *TestTbTestMapper) GetDataMap() map[int32]*TestTestMapper {
    return table._dataMap
}

func (table *TestTbTestMapper) GetDataList() []*TestTestMapper {
    return table._dataList
}

func (table *TestTbTestMapper) Get(key int32) *TestTestMapper {
    return table._dataMap[key]
}


