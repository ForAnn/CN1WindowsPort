// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class AutoCompleteTextField_24: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.ui.List _fval_2l;

public global::com.codename1.ui.Form _fval_2f;

public global::com.codename1.ui.AutoCompleteTextField _fthis_20;

public void @this(global::com.codename1.ui.AutoCompleteTextField n1, global::com.codename1.ui.List n2, global::com.codename1.ui.Form n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.AutoCompleteTextField$4: void <init>(com.codename1.ui.AutoCompleteTextField, com.codename1.ui.List, com.codename1.ui.Form)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.ui.AutoCompleteTextField_24) _r0_o)._fthis_20 = (global::com.codename1.ui.AutoCompleteTextField) _r1_o;
    ((global::com.codename1.ui.AutoCompleteTextField_24) _r0_o)._fval_2l = (global::com.codename1.ui.List) _r2_o;
    ((global::com.codename1.ui.AutoCompleteTextField_24) _r0_o)._fval_2f = (global::com.codename1.ui.Form) _r3_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.AutoCompleteTextField$4: void <init>(com.codename1.ui.AutoCompleteTextField, com.codename1.ui.List, com.codename1.ui.Form)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.AutoCompleteTextField$4: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 0;
    _r1_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fval_2l;
    _r0_o = ((global::com.codename1.ui.List) _r0_o).getSelectedItem();
    _r0_o = _r0_o;
    global::com.codename1.ui.AutoCompleteTextField.access_2302((global::com.codename1.ui.AutoCompleteTextField) _r1_o, (global::java.lang.String) _r0_o);
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r1_o = global::com.codename1.ui.AutoCompleteTextField.access_2300((global::com.codename1.ui.AutoCompleteTextField) _r1_o);
    ((global::com.codename1.ui.AutoCompleteTextField) _r0_o).setParentText((global::java.lang.String) _r1_o);
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r1_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).isTextEditing((global::com.codename1.ui.Component) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label66;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r2_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r3.i = ((global::com.codename1.ui.AutoCompleteTextField) _r0_o).getMaxSize();
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r4.i = ((global::com.codename1.ui.AutoCompleteTextField) _r0_o).getConstraint();
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fval_2l;
    _r0_o = ((global::com.codename1.ui.List) _r0_o).getSelectedItem();
    _r0_o = _r0_o;
    ((global::com.codename1.ui.Display) _r1_o).editString((global::com.codename1.ui.Component) _r2_o, (int) _r3.i, (int) _r4.i, (global::java.lang.String) _r0_o);
    label66:;
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r0_o = global::com.codename1.ui.AutoCompleteTextField.access_2400((global::com.codename1.ui.AutoCompleteTextField) _r0_o);
    ((global::com.codename1.ui.Container) _r0_o).setVisible(0!=_r5.i);
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fthis_20;
    _r0_o = global::com.codename1.ui.AutoCompleteTextField.access_2400((global::com.codename1.ui.AutoCompleteTextField) _r0_o);
    ((global::com.codename1.ui.Container) _r0_o).setEnabled(0!=_r5.i);
    _r0_o = ((global::com.codename1.ui.AutoCompleteTextField_24) _r6_o)._fval_2f;
    ((global::com.codename1.ui.Form) _r0_o).repaint();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.AutoCompleteTextField$4: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.AutoCompleteTextField$4]
//XMLVM_END_WRAPPER[com.codename1.ui.AutoCompleteTextField$4]

} // end of class: AutoCompleteTextField_24

} // end of namespace: com.codename1.ui
