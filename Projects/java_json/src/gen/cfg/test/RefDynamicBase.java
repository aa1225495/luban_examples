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



public abstract class RefDynamicBase {
    public RefDynamicBase(JsonObject __json__) { 
        x = __json__.get("x").getAsInt();
    }

    public RefDynamicBase(int x ) {
        this.x = x;
    }

    public static RefDynamicBase deserializeRefDynamicBase(JsonObject __json__) {
        switch (__json__.get("$type").getAsString()) {
            case "RefBean": return new cfg.test.RefBean(__json__);
            default: throw new bright.serialization.SerializationException();
        }
    }

    public final int x;
    public cfg.test.TestBeRef x_Ref;

    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
        this.x_Ref = ((cfg.test.TbTestBeRef)_tables.get("test.TbTestBeRef")).get(x);
    }

    @Override
    public String toString() {
        return "{ "
        + "x:" + x + ","
        + "}";
    }
}
