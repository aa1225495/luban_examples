
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TestRef extends AbstractBean {
    public TestRef(ByteBuf _buf) { 
        id = _buf.readInt();
        x1 = _buf.readInt();
        x12 = _buf.readInt();
        x2 = _buf.readInt();
        x3 = _buf.readInt();
        x4 = _buf.readInt();
        {int n = Math.min(_buf.readSize(), _buf.size());a1 = new int[n];for(int i = 0 ; i < n ; i++) { int _e;_e = _buf.readInt(); a1[i] = _e;}}
        {int n = Math.min(_buf.readSize(), _buf.size());a2 = new int[n];for(int i = 0 ; i < n ; i++) { int _e;_e = _buf.readInt(); a2[i] = _e;}}
        {int n = Math.min(_buf.readSize(), _buf.size());b1 = new java.util.ArrayList<Integer>(n);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); b1.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());b2 = new java.util.ArrayList<Integer>(n);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); b2.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());c1 = new java.util.HashSet<Integer>(n * 3 / 2);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); c1.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());c2 = new java.util.HashSet<Integer>(n * 3 / 2);for(int i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); c2.add(_e);}}
        {int n = Math.min(_buf.readSize(), _buf.size());d1 = new java.util.HashMap<Integer, Integer>(n * 3 / 2);for(int i = 0 ; i < n ; i++) { Integer _k;  _k = _buf.readInt(); Integer _v;  _v = _buf.readInt();     d1.put(_k, _v);}}
        {int n = Math.min(_buf.readSize(), _buf.size());d2 = new java.util.HashMap<Integer, Integer>(n * 3 / 2);for(int i = 0 ; i < n ; i++) { Integer _k;  _k = _buf.readInt(); Integer _v;  _v = _buf.readInt();     d2.put(_k, _v);}}
        e1 = _buf.readInt();
        e2 = _buf.readLong();
        e3 = _buf.readString();
        f1 = _buf.readInt();
        f2 = _buf.readLong();
        f3 = _buf.readString();
        s1 = cfg.test.RefDynamicBase.deserialize(_buf);
    }

    public static TestRef deserialize(ByteBuf _buf) {
            return new cfg.test.TestRef(_buf);
    }

    public final int id;
    public final int x1;
    public final int x12;
    public final int x2;
    public final int x3;
    public final int x4;
    public final int[] a1;
    public final int[] a2;
    public final java.util.ArrayList<Integer> b1;
    public final java.util.ArrayList<Integer> b2;
    public final java.util.HashSet<Integer> c1;
    public final java.util.HashSet<Integer> c2;
    public final java.util.HashMap<Integer, Integer> d1;
    public final java.util.HashMap<Integer, Integer> d2;
    public final int e1;
    public final long e2;
    public final String e3;
    public final int f1;
    public final long f2;
    public final String f3;
    public final cfg.test.RefDynamicBase s1;

    public static final int __ID__ = -543222491;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + x1 + ","
        + "(format_field_name __code_style field.name):" + x12 + ","
        + "(format_field_name __code_style field.name):" + x2 + ","
        + "(format_field_name __code_style field.name):" + x3 + ","
        + "(format_field_name __code_style field.name):" + x4 + ","
        + "(format_field_name __code_style field.name):" + a1 + ","
        + "(format_field_name __code_style field.name):" + a2 + ","
        + "(format_field_name __code_style field.name):" + b1 + ","
        + "(format_field_name __code_style field.name):" + b2 + ","
        + "(format_field_name __code_style field.name):" + c1 + ","
        + "(format_field_name __code_style field.name):" + c2 + ","
        + "(format_field_name __code_style field.name):" + d1 + ","
        + "(format_field_name __code_style field.name):" + d2 + ","
        + "(format_field_name __code_style field.name):" + e1 + ","
        + "(format_field_name __code_style field.name):" + e2 + ","
        + "(format_field_name __code_style field.name):" + e3 + ","
        + "(format_field_name __code_style field.name):" + f1 + ","
        + "(format_field_name __code_style field.name):" + f2 + ","
        + "(format_field_name __code_style field.name):" + f3 + ","
        + "(format_field_name __code_style field.name):" + s1 + ","
        + "}";
    }
}

