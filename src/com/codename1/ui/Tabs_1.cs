// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Tabs_21: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.ui.Component _fval_2b;

public global::com.codename1.ui.Tabs _fthis_20;

public void @this(global::com.codename1.ui.Tabs n1, global::com.codename1.ui.Component n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$1: void <init>(com.codename1.ui.Tabs, com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.Tabs_21) _r0_o)._fthis_20 = (global::com.codename1.ui.Tabs) _r1_o;
    ((global::com.codename1.ui.Tabs_21) _r0_o)._fval_2b = (global::com.codename1.ui.Component) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$1: void <init>(com.codename1.ui.Tabs, com.codename1.ui.Component)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8_o = n1;
    _r6.i = 1;
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r3_o);
    if (_r3_o == null) goto label80;
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r3_o);
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = global::com.codename1.ui.Tabs.access_2100((global::com.codename1.ui.Tabs) _r4_o);
    ((global::com.codename1.ui.Component) _r3_o).setUIID((global::java.lang.String) _r4_o);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r3_o);
    ((global::com.codename1.ui.Component) _r3_o).setShouldCalcPreferredSize(0!=_r6.i);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r3_o);
    ((global::com.codename1.ui.Component) _r3_o).repaint();
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2200((global::com.codename1.ui.Tabs) _r3_o);
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r4_o);
    _r2.i = ((global::com.codename1.ui.Container) _r3_o).getComponentIndex((global::com.codename1.ui.Component) _r4_o);
    _r3.i = -1;
    if (_r2.i == _r3.i) goto label80;
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2300((global::com.codename1.ui.Tabs) _r3_o);
    _r1_o = ((global::com.codename1.ui.Container) _r3_o).getComponentAt((int) _r2.i);
    _r3.i = ((_r1_o != null) && (_r1_o is global::com.codename1.ui.Container)) ? 1 : 0;
    if (_r3.i == 0) goto label80;
    _r1_o = _r1_o;
    ((global::com.codename1.ui.Container) _r1_o).setBlockFocus(0!=_r6.i);
    label80:;
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = global::com.codename1.ui.Tabs.access_2200((global::com.codename1.ui.Tabs) _r4_o);
    _r5_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fval_2b;
    _r4.i = ((global::com.codename1.ui.Container) _r4_o).getComponentIndex((global::com.codename1.ui.Component) _r5_o);
    global::com.codename1.ui.Tabs.access_2402((global::com.codename1.ui.Tabs) _r3_o, (int) _r4.i);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2300((global::com.codename1.ui.Tabs) _r3_o);
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4.i = global::com.codename1.ui.Tabs.access_2400((global::com.codename1.ui.Tabs) _r4_o);
    _r0_o = ((global::com.codename1.ui.Container) _r3_o).getComponentAt((int) _r4.i);
    _r3.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.Container)) ? 1 : 0;
    if (_r3.i == 0) goto label123;
    _r0_o = _r0_o;
    _r3.i = 0;
    ((global::com.codename1.ui.Container) _r0_o).setBlockFocus(0!=_r3.i);
    label123:;
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4.i = global::com.codename1.ui.Tabs.access_2400((global::com.codename1.ui.Tabs) _r4_o);
    _r5_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r5.i = global::com.codename1.ui.Tabs.access_2500((global::com.codename1.ui.Tabs) _r5_o) ? 1 : 0;
    ((global::com.codename1.ui.Tabs) _r3_o).setSelectedIndex((int) _r4.i, 0!=_r5.i);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    global::com.codename1.ui.Tabs.access_2600((global::com.codename1.ui.Tabs) _r3_o);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fval_2b;
    global::com.codename1.ui.Tabs.access_2002((global::com.codename1.ui.Tabs) _r3_o, (global::com.codename1.ui.Component) _r4_o);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r3_o);
    ((global::com.codename1.ui.Component) _r3_o).setShouldCalcPreferredSize(0!=_r6.i);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2200((global::com.codename1.ui.Tabs) _r3_o);
    ((global::com.codename1.ui.Container) _r3_o).revalidate();
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2200((global::com.codename1.ui.Tabs) _r3_o);
    _r4_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r4_o = global::com.codename1.ui.Tabs.access_2000((global::com.codename1.ui.Tabs) _r4_o);
    ((global::com.codename1.ui.Container) _r3_o).scrollComponentToVisible((global::com.codename1.ui.Component) _r4_o);
    _r3_o = ((global::com.codename1.ui.Tabs_21) _r7_o)._fthis_20;
    _r3_o = global::com.codename1.ui.Tabs.access_2300((global::com.codename1.ui.Tabs) _r3_o);
    ((global::com.codename1.ui.Container) _r3_o).revalidate();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$1]
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$1]

} // end of class: Tabs_21

} // end of namespace: com.codename1.ui
