// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLComponent_2HTMLComboBox: global::com.codename1.ui.ComboBox {
public global::com.codename1.ui.html.HTMLComponent _fthis_20;

public void @this(global::com.codename1.ui.html.HTMLComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLComponent$HTMLComboBox: void <init>(com.codename1.ui.html.HTMLComponent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.html.HTMLComponent_2HTMLComboBox) _r0_o)._fthis_20 = (global::com.codename1.ui.html.HTMLComponent) _r1_o;
    ((global::com.codename1.ui.ComboBox) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLComponent$HTMLComboBox: void <init>(com.codename1.ui.html.HTMLComponent)]
}

public override global::System.Object createPopupList(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLComponent$HTMLComboBox: com.codename1.ui.List createPopupList()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = new global::com.codename1.ui.html.MultiComboBox();
    _r1_o = ((global::com.codename1.ui.html.HTMLComponent_2HTMLComboBox) _r3_o).getModel();
    _r2.i = 0;
    ((global::com.codename1.ui.html.MultiComboBox) _r0_o).@this((global::com.codename1.ui.list.ListModel) _r1_o, 0!=_r2.i);
    _r1.i = ((global::com.codename1.ui.html.HTMLComponent_2HTMLComboBox) _r3_o).isSmoothScrolling() ? 1 : 0;
    ((global::com.codename1.ui.List) _r0_o).setSmoothScrolling(0!=_r1.i);
    _r1.i = ((global::com.codename1.ui.html.HTMLComponent_2HTMLComboBox) _r3_o).getFixedSelection();
    ((global::com.codename1.ui.List) _r0_o).setFixedSelection((int) _r1.i);
    _r1.i = ((global::com.codename1.ui.html.HTMLComponent_2HTMLComboBox) _r3_o).getItemGap();
    ((global::com.codename1.ui.List) _r0_o).setItemGap((int) _r1.i);
    // Value=ComboBoxList
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    ((global::com.codename1.ui.List) _r0_o).setUIID((global::java.lang.String) _r1_o);
    return (global::com.codename1.ui.List) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLComponent$HTMLComboBox: com.codename1.ui.List createPopupList()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLComponent$HTMLComboBox]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLComponent$HTMLComboBox]

} // end of class: HTMLComponent_2HTMLComboBox

} // end of namespace: com.codename1.ui.html
