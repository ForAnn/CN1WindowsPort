// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Tabs_2TabsLayout: global::com.codename1.ui.layouts.Layout {
public global::com.codename1.ui.Tabs _fthis_20;

public void @this(global::com.codename1.ui.Tabs n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$TabsLayout: void <init>(com.codename1.ui.Tabs)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Tabs_2TabsLayout) _r0_o)._fthis_20 = (global::com.codename1.ui.Tabs) _r1_o;
    ((global::com.codename1.ui.layouts.Layout) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$TabsLayout: void <init>(com.codename1.ui.Tabs)]
}

public override void layoutContainer(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$TabsLayout: void layoutContainer(com.codename1.ui.Container)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    _r10_o = this;
    _r11_o = n1;
    _r9.i = 1;
    _r8.i = 0;
    _r2.i = ((global::com.codename1.ui.Container) _r11_o).getComponentCount();
    _r5.i = ((global::com.codename1.ui.Container) _r11_o).getWidth();
    _r6_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r10_o)._fthis_20;
    _r6.i = global::com.codename1.ui.Tabs.access_2700((global::com.codename1.ui.Tabs) _r6_o);
    _r6.i = _r6.i * 2;
    _r3.i = _r5.i - _r6.i;
    _r1.i = 0;
    label21:;
    if (_r1.i >= _r2.i) goto label148;
    _r5.i = ((global::com.codename1.ui.Container) _r11_o).isRTL() ? 1 : 0;
    if (_r5.i == 0) goto label129;
    _r5.i = _r2.i - _r1.i;
    _r5.i = _r5.i * _r3.i;
    _r6_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r10_o)._fthis_20;
    _r6.i = global::com.codename1.ui.Tabs.access_2700((global::com.codename1.ui.Tabs) _r6_o);
    _r4.i = _r5.i + _r6.i;
    _r5_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r10_o)._fthis_20;
    _r5.i = global::com.codename1.ui.Tabs.access_2800((global::com.codename1.ui.Tabs) _r5_o);
    _r5.i = _r2.i - _r5.i;
    _r5.i = _r5.i * _r3.i;
    _r4.i = _r4.i - _r5.i;
    label50:;
    _r0_o = ((global::com.codename1.ui.Container) _r11_o).getComponentAt((int) _r1.i);
    _r5_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getMargin((int) _r9.i);
    _r5.i = _r5.i + _r4.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r5.i);
    _r5_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getMargin((int) _r8.i);
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r5.i);
    _r5_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getMargin((int) _r9.i);
    _r5.i = _r3.i - _r5.i;
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r7.i = 3;
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin((int) _r7.i);
    _r5.i = _r5.i - _r6.i;
    ((global::com.codename1.ui.Component) _r0_o).setWidth((int) _r5.i);
    _r5.i = ((global::com.codename1.ui.Container) _r11_o).getHeight();
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin((int) _r8.i);
    _r5.i = _r5.i - _r6.i;
    _r6_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r7.i = 2;
    _r6.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getMargin((int) _r7.i);
    _r5.i = _r5.i - _r6.i;
    ((global::com.codename1.ui.Component) _r0_o).setHeight((int) _r5.i);
    _r1.i = _r1.i + 1;
    goto label21;
    label129:;
    _r5.i = _r1.i * _r3.i;
    _r6_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r10_o)._fthis_20;
    _r6.i = global::com.codename1.ui.Tabs.access_2700((global::com.codename1.ui.Tabs) _r6_o);
    _r4.i = _r5.i + _r6.i;
    _r5_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r10_o)._fthis_20;
    _r5.i = global::com.codename1.ui.Tabs.access_2800((global::com.codename1.ui.Tabs) _r5_o);
    _r5.i = _r5.i * _r3.i;
    _r4.i = _r4.i - _r5.i;
    goto label50;
    label148:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$TabsLayout: void layoutContainer(com.codename1.ui.Container)]
}

public override global::System.Object getPreferredSize(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$TabsLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r8_o = this;
    _r9_o = n1;
    _r7.i = 0;
    _r2_o = new global::com.codename1.ui.geom.Dimension();
    ((global::com.codename1.ui.geom.Dimension) _r2_o).@this((int) _r7.i, (int) _r7.i);
    _r4.i = ((global::com.codename1.ui.Container) _r9_o).getWidth();
    _r5_o = ((global::com.codename1.ui.Container) _r9_o).getStyle();
    _r6.i = 1;
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getPadding(0!=_r7.i, (int) _r6.i);
    _r4.i = _r4.i + _r5.i;
    _r5_o = ((global::com.codename1.ui.Container) _r9_o).getStyle();
    _r6.i = 3;
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getPadding(0!=_r7.i, (int) _r6.i);
    _r4.i = _r4.i + _r5.i;
    ((global::com.codename1.ui.geom.Dimension) _r2_o).setWidth((int) _r4.i);
    _r4.i = ((global::com.codename1.ui.Container) _r9_o).getHeight();
    _r5_o = ((global::com.codename1.ui.Container) _r9_o).getStyle();
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getPadding(0!=_r7.i, (int) _r7.i);
    _r4.i = _r4.i + _r5.i;
    _r5_o = ((global::com.codename1.ui.Container) _r9_o).getStyle();
    _r6.i = 2;
    _r5.i = ((global::com.codename1.ui.plaf.Style) _r5_o).getPadding(0!=_r7.i, (int) _r6.i);
    _r4.i = _r4.i + _r5.i;
    ((global::com.codename1.ui.geom.Dimension) _r2_o).setHeight((int) _r4.i);
    _r4_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r8_o)._fthis_20;
    _r4_o = global::com.codename1.ui.Tabs.access_2300((global::com.codename1.ui.Tabs) _r4_o);
    _r0.i = ((global::com.codename1.ui.Container) _r4_o).getComponentCount();
    _r3.i = 0;
    label70:;
    if (_r3.i >= _r0.i) goto label119;
    _r4_o = ((global::com.codename1.ui.Tabs_2TabsLayout) _r8_o)._fthis_20;
    _r4_o = global::com.codename1.ui.Tabs.access_2300((global::com.codename1.ui.Tabs) _r4_o);
    _r4_o = ((global::com.codename1.ui.Container) _r4_o).getComponentAt((int) _r3.i);
    _r1_o = ((global::com.codename1.ui.Component) _r4_o).getPreferredSizeWithMargin();
    _r4.i = ((global::com.codename1.ui.geom.Dimension) _r1_o).getWidth();
    _r5.i = ((global::com.codename1.ui.geom.Dimension) _r2_o).getWidth();
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r5.i);
    ((global::com.codename1.ui.geom.Dimension) _r2_o).setWidth((int) _r4.i);
    _r4.i = ((global::com.codename1.ui.geom.Dimension) _r1_o).getHeight();
    _r5.i = ((global::com.codename1.ui.geom.Dimension) _r2_o).getHeight();
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r5.i);
    ((global::com.codename1.ui.geom.Dimension) _r2_o).setHeight((int) _r4.i);
    _r3.i = _r3.i + 1;
    goto label70;
    label119:;
    return (global::com.codename1.ui.geom.Dimension) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$TabsLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Tabs$TabsLayout]
//XMLVM_END_WRAPPER[com.codename1.ui.Tabs$TabsLayout]

} // end of class: Tabs_2TabsLayout

} // end of namespace: com.codename1.ui
