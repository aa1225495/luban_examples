
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

import '/gen/ai/EOperator.dart';
import '/gen/ai/KeyData.dart';

import '/gen/ai/KeyQueryOperator.dart';

 class BinaryOperator extends KeyQueryOperator
{
    BinaryOperator(
    {
    required this.oper,
    required this.data,
    }
    );

    factory BinaryOperator.deserialize(dynamic _buf){
        final oper;
        oper = EOperator.fromValue(_buf['oper']);
        final data;
        data = KeyData.deserialize(_buf['data']);
        return BinaryOperator(
            oper:oper,
            data:data,
       );
    }

    final EOperator oper;
    final KeyData data;
    static final int __ID__ = -979891605;
     @override
    void resolveRef(Tables tables)
    {
        super.resolveRef(tables);

        data?.resolveRef(tables);
    }

    @override
    String toString() {
        return 'BinaryOperator(oper:$oper, data:$data, )';
    }
}

