//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class RefBean extends cfg.test.RefDynamicBase {
    public RefBean(JsonObject __json__) { 
        super(__json__);
        { com.google.gson.JsonArray _json0_ = __json__.get("arr").getAsJsonArray(); arr = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  arr.add(_v0); }   }
    }

    public RefBean(int x, java.util.ArrayList<Integer> arr ) {
        super(x);
        this.arr = arr;
    }

    public static RefBean deserializeRefBean(JsonObject __json__) {
        return new RefBean(__json__);
    }

    public final java.util.ArrayList<Integer> arr;
    public java.util.ArrayList<cfg.test.TestBeRef> arr_Ref;

    public static final int __ID__ = 1963260263;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
        { cfg.test.TbTestBeRef __table = (cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef"); this.arr_Ref = new java.util.ArrayList<cfg.test.TestBeRef>(); for(int __e : arr) { this.arr_Ref.add(__table.get(__e)); } }
    }

    @Override
    public String toString() {
        return "{ "
        + "x:" + x + ","
        + "arr:" + arr + ","
        + "}";
    }
}
