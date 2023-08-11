
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;

import luban.*;


/**
 * 道具
 */
public final class Item extends AbstractBean {
    public Item(ByteBuf _buf) { 
        id = _buf.readInt();
        name = _buf.readString();
        majorType = _buf.readInt();
        minorType = _buf.readInt();
        maxPileNum = _buf.readInt();
        quality = _buf.readInt();
        icon = _buf.readString();
        iconBackgroud = _buf.readString();
        iconMask = _buf.readString();
        desc = _buf.readString();
        showOrder = _buf.readInt();
    }

    public static Item deserialize(ByteBuf _buf) {
            return new cfg.item.Item(_buf);
    }

    /**
     * 道具id
     */
    public final int id;
    public final String name;
    public final int majorType;
    public final int minorType;
    public final int maxPileNum;
    public final int quality;
    public final String icon;
    public final String iconBackgroud;
    public final String iconMask;
    public final String desc;
    public final int showOrder;

    public static final int __ID__ = 2107285806;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + name + ","
        + "(format_field_name __code_style field.name):" + majorType + ","
        + "(format_field_name __code_style field.name):" + minorType + ","
        + "(format_field_name __code_style field.name):" + maxPileNum + ","
        + "(format_field_name __code_style field.name):" + quality + ","
        + "(format_field_name __code_style field.name):" + icon + ","
        + "(format_field_name __code_style field.name):" + iconBackgroud + ","
        + "(format_field_name __code_style field.name):" + iconMask + ","
        + "(format_field_name __code_style field.name):" + desc + ","
        + "(format_field_name __code_style field.name):" + showOrder + ","
        + "}";
    }
}

