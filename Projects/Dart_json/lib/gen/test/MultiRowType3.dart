
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

import 'dart:ffi';
import 'dart:collection';
import '/gen/Tables.dart';

import '/gen/test/MultiRowType1.dart';


 class MultiRowType3 
{
    MultiRowType3(
    {
    required this.id,
    required this.items,
    }
    );

    factory MultiRowType3.deserialize(dynamic _buf){
        final id;
        id = _buf['id'] as int;
        final items;
        {var _json0 = _buf['items'] as List<dynamic>; items = List<MultiRowType1>.empty(growable: true); for(var _e0 in _json0) {MultiRowType1 _v0; _v0 = MultiRowType1.deserialize(_e0); items.add(_v0); } };
        return MultiRowType3(
            id:id,
            items:items,
       );
    }

    final int id;
    final List<MultiRowType1> items;
    static final int __ID__ = 540474972;
     
    void resolveRef(Tables tables)
    {

        for (var _e in items) { _e?.resolveRef(tables); }
    }

    @override
    String toString() {
        return 'MultiRowType3(id:$id, items:$items, )';
    }
}

