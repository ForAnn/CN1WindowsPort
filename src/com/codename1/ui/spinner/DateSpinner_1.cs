// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.spinner {
public class DateSpinner_21: global::com.codename1.ui.spinner.SpinnerRenderer {
public global::com.codename1.ui.spinner.DateSpinner _fthis_20;

public void @this(global::com.codename1.ui.spinner.DateSpinner n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateSpinner$1: void <init>(com.codename1.ui.spinner.DateSpinner)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.spinner.DateSpinner_21) _r0_o)._fthis_20 = (global::com.codename1.ui.spinner.DateSpinner) _r1_o;
    ((global::com.codename1.ui.spinner.SpinnerRenderer) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateSpinner$1: void <init>(com.codename1.ui.spinner.DateSpinner)]
}

public override global::System.Object getListCellRendererComponent(global::com.codename1.ui.List n1, global::java.lang.Object n2, int n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateSpinner$1: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10.i = n3;
    _r11.i = n4 ? 1 : 0;
    if (_r9_o == null) goto label39;
    _r5.i = ((_r9_o != null) && (_r9_o is global::java.lang.Integer)) ? 1 : 0;
    if (_r5.i == 0) goto label39;
    _r9_o = _r9_o;
    _r1.i = ((global::java.lang.Integer) _r9_o).intValue();
    _r5_o = ((global::com.codename1.ui.spinner.DateSpinner_21) _r7_o)._fthis_20;
    _r5.i = global::com.codename1.ui.spinner.DateSpinner.access_2000((global::com.codename1.ui.spinner.DateSpinner) _r5_o) ? 1 : 0;
    if (_r5.i == 0) goto label44;
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((int) _r1.i);
    _r9_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    label39:;
    _r5_o = base.getListCellRendererComponent((global::com.codename1.ui.List) _r8_o, (global::java.lang.Object) _r9_o, (int) _r10.i, 0!=_r11.i);
    return (global::com.codename1.ui.Component) _r5_o;
    label44:;
    _r5_o = ((global::com.codename1.ui.spinner.DateSpinner_21) _r7_o).getUIManager();
    _r3_o = ((global::com.codename1.ui.plaf.UIManager) _r5_o).getBundle();
    _r5_o = global::com.codename1.ui.spinner.DateTimeRenderer._fMONTHS;
    _r6.i = 1;
    _r6.i = _r1.i - _r6.i;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o)[_r6.i];
    if (_r3_o == null) goto label90;
    _r5_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r5_o).@this();
    // Value=Calendar.
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46))}));
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r6_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r4_o);
    _r5_o = ((global::java.lang.StringBuilder) _r5_o).toString();
    _r2_o = ((global::java.util.Map) _r3_o).get((global::java.lang.Object) _r5_o);
    if (_r2_o == null) goto label90;
    _r0_o = _r2_o;
    _r0_o = _r0_o;
    _r4_o = _r0_o;
    label90:;
    _r9_o = _r4_o;
    goto label39;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateSpinner$1: com.codename1.ui.Component getListCellRendererComponent(com.codename1.ui.List, java.lang.Object, int, boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.DateSpinner$1]
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.DateSpinner$1]

} // end of class: DateSpinner_21

} // end of namespace: com.codename1.ui.spinner
