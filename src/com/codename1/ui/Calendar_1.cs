// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Calendar_21: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
private bool _flock;

public global::com.codename1.ui.Button _fval_2left;

public global::com.codename1.ui.Calendar _fthis_20;

public void @this(global::com.codename1.ui.Calendar n1, global::com.codename1.ui.Button n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Calendar$1: void <init>(com.codename1.ui.Calendar, com.codename1.ui.Button)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::com.codename1.ui.Calendar_21) _r1_o)._fthis_20 = (global::com.codename1.ui.Calendar) _r2_o;
    ((global::com.codename1.ui.Calendar_21) _r1_o)._fval_2left = (global::com.codename1.ui.Button) _r3_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 0;
    ((global::com.codename1.ui.Calendar_21) _r1_o)._flock = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Calendar$1: void <init>(com.codename1.ui.Calendar, com.codename1.ui.Button)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Calendar$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    _r10_o = this;
    _r11_o = n1;
    _r9.i = 300;
    _r7.i = 1;
    _r8.i = 0;
    _r5.i = ((global::com.codename1.ui.Calendar_21) _r10_o)._flock ? 1 : 0;
    if (_r5.i == 0) goto label9;
    label8:;
    return;
    label9:;
    ((global::com.codename1.ui.Calendar_21) _r10_o)._flock = 0!=_r7.i;
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r5_o = global::com.codename1.ui.Calendar.access_2000((global::com.codename1.ui.Calendar) _r5_o);
    _r1.i = ((global::com.codename1.ui.Calendar_2MonthView) _r5_o).getMonth();
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r5_o = global::com.codename1.ui.Calendar.access_2000((global::com.codename1.ui.Calendar) _r5_o);
    _r4.i = ((global::com.codename1.ui.Calendar_2MonthView) _r5_o).getYear();
    _r5_o = ((global::com.codename1.ui.events.ActionEvent) _r11_o).getSource();
    _r6_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fval_2left;
    if (_r5_o != _r6_o) goto label163;
    _r1.i = _r1.i + -1;
    if (_r1.i >= 0) goto label47;
    _r1.i = 11;
    _r4.i = _r4.i + -1;
    label47:;
    _r5_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=calTransitionBool
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108))}));
    _r3.i = ((global::com.codename1.ui.plaf.UIManager) _r5_o).isThemeConstant((global::java.lang.String) _r6_o, 0!=_r7.i) ? 1 : 0;
    if (_r3.i == 0) goto label191;
    _r5_o = global::com.codename1.ui.plaf.UIManager.getInstance();
    // Value=calTransitionVertBool
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 86)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108))}));
    _r5.i = ((global::com.codename1.ui.plaf.UIManager) _r5_o).isThemeConstant((global::java.lang.String) _r6_o, 0!=_r8.i) ? 1 : 0;
    if (_r5.i == 0) goto label175;
    _r5_o = ((global::com.codename1.ui.events.ActionEvent) _r11_o).getSource();
    _r6_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fval_2left;
    if (_r5_o != _r6_o) goto label173;
    _r5.i = _r7.i;
    label80:;
    _r0_o = global::com.codename1.ui.animations.CommonTransitions.createSlide((int) _r7.i, 0!=_r5.i, (int) _r9.i);
    label84:;
    _r2_o = new global::com.codename1.ui.Calendar_2MonthView();
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r6_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r6_o = global::com.codename1.ui.Calendar.access_2000((global::com.codename1.ui.Calendar) _r6_o);
    _r6.l = ((global::com.codename1.ui.Calendar_2MonthView) _r6_o)._fcurrentDay;
    ((global::com.codename1.ui.Calendar_2MonthView) _r2_o).@this((global::com.codename1.ui.Calendar) _r5_o, (long) _r6.l);
    global::com.codename1.ui.Calendar_2MonthView.access_2100((global::com.codename1.ui.Calendar_2MonthView) _r2_o, (int) _r4.i, (int) _r1.i);
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r6_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r6_o = global::com.codename1.ui.Calendar.access_2000((global::com.codename1.ui.Calendar) _r6_o);
    ((global::com.codename1.ui.Calendar) _r5_o).replaceAndWait((global::com.codename1.ui.Component) _r6_o, (global::com.codename1.ui.Component) _r2_o, (global::com.codename1.ui.animations.Transition) _r0_o);
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    global::com.codename1.ui.Calendar.access_2002((global::com.codename1.ui.Calendar) _r5_o, (global::com.codename1.ui.Calendar_2MonthView) _r2_o);
    ((global::com.codename1.ui.Calendar_2MonthView) _r2_o).fireActionEvent();
    label121:;
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r5_o = global::com.codename1.ui.Calendar.access_2300((global::com.codename1.ui.Calendar) _r5_o);
    _r6_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r6_o).@this();
    _r7_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r7_o = global::com.codename1.ui.Calendar.access_2200((global::com.codename1.ui.Calendar) _r7_o, (int) _r1.i);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    // Value= 
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((global::java.lang.String) _r7_o);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).append((int) _r4.i);
    _r6_o = ((global::java.lang.StringBuilder) _r6_o).toString();
    ((global::com.codename1.ui.Label) _r5_o).setText((global::java.lang.String) _r6_o);
    ((global::com.codename1.ui.Calendar_21) _r10_o)._flock = 0!=_r8.i;
    goto label8;
    label163:;
    _r1.i = _r1.i + 1;
    _r5.i = 11;
    if (_r1.i <= _r5.i) goto label47;
    _r1.i = 0;
    _r4.i = _r4.i + 1;
    goto label47;
    label173:;
    _r5.i = _r8.i;
    goto label80;
    label175:;
    _r5_o = ((global::com.codename1.ui.events.ActionEvent) _r11_o).getSource();
    _r6_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fval_2left;
    if (_r5_o != _r6_o) goto label189;
    _r5.i = _r7.i;
    label184:;
    _r0_o = global::com.codename1.ui.animations.CommonTransitions.createSlide((int) _r8.i, 0!=_r5.i, (int) _r9.i);
    goto label84;
    label189:;
    _r5.i = _r8.i;
    goto label184;
    label191:;
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    _r5_o = global::com.codename1.ui.Calendar.access_2000((global::com.codename1.ui.Calendar) _r5_o);
    global::com.codename1.ui.Calendar_2MonthView.access_2100((global::com.codename1.ui.Calendar_2MonthView) _r5_o, (int) _r4.i, (int) _r1.i);
    _r5_o = ((global::com.codename1.ui.Calendar_21) _r10_o)._fthis_20;
    ((global::com.codename1.ui.Calendar) _r5_o).componentChanged();
    goto label121;
//XMLVM_END_WRAPPER[com.codename1.ui.Calendar$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Calendar$1]
//XMLVM_END_WRAPPER[com.codename1.ui.Calendar$1]

} // end of class: Calendar_21

} // end of namespace: com.codename1.ui
