
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



 class DateTimeRange 
{
    DateTimeRange(
    {
    required this.start_time,
    required this.end_time,
    }
    );

    factory DateTimeRange.deserialize(dynamic _buf){
        final start_time;
        start_time = _buf['start_time'] as int;
        final end_time;
        end_time = _buf['end_time'] as int;
        return DateTimeRange(
            start_time:start_time,
            end_time:end_time,
       );
    }

    final int start_time;
    final int end_time;
    static final int __ID__ = 495315430;
     
    void resolveRef(Tables tables)
    {

    }

    @override
    String toString() {
        return 'DateTimeRange(start_time:$start_time, end_time:$end_time, )';
    }
}

