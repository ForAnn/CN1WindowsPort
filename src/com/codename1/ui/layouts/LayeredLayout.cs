// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class LayeredLayout: global::com.codename1.ui.layouts.Layout {
public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.ui.layouts.Layout) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout: void <init>()]
}

public override void layoutContainer(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout: void layoutContainer(com.codename1.ui.Container)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r16;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r18_o = null;
    global::System.Object _r19_o = null;
    _r18_o = this;
    _r19_o = n1;
    _r10_o = ((global::com.codename1.ui.Container) _r19_o).getStyle();
    _r15.i = 0;
    _r16.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r15.i;
    _r2.i = _r16.i;
    _r11.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getPadding(0!=_r1.i, (int) _r2.i);
    _r15.i = ((global::com.codename1.ui.Container) _r19_o).getLayoutHeight();
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).getBottomGap();
    _r15.i = _r15.i - _r16.i;
    _r16.i = 0;
    _r17.i = 2;
    _r0_o = _r10_o;
    _r1.i = _r16.i;
    _r2.i = _r17.i;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getPadding(0!=_r1.i, (int) _r2.i);
    _r3.i = _r15.i - _r16.i;
    _r15.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r16.i = 1;
    _r0_o = _r10_o;
    _r1.i = _r15.i;
    _r2.i = _r16.i;
    _r7.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getPadding(0!=_r1.i, (int) _r2.i);
    _r15.i = ((global::com.codename1.ui.Container) _r19_o).getLayoutWidth();
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).getSideGap();
    _r15.i = _r15.i - _r16.i;
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r17.i = 3;
    _r0_o = _r10_o;
    _r1.i = _r16.i;
    _r2.i = _r17.i;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getPadding(0!=_r1.i, (int) _r2.i);
    _r9.i = _r15.i - _r16.i;
    _r8.i = ((global::com.codename1.ui.Container) _r19_o).getComponentCount();
    _r6.i = 0;
    label86:;
    if (_r6.i >= _r8.i) goto label219;
    _r0_o = _r19_o;
    _r1.i = _r6.i;
    _r4_o = ((global::com.codename1.ui.Container) _r0_o).getComponentAt((int) _r1.i);
    _r10_o = ((global::com.codename1.ui.Component) _r4_o).getStyle();
    _r15.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r16.i = 1;
    _r0_o = _r10_o;
    _r1.i = _r15.i;
    _r2.i = _r16.i;
    _r15.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r13.i = _r7.i + _r15.i;
    _r15.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r16.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r15.i;
    _r2.i = _r16.i;
    _r15.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r14.i = _r11.i + _r15.i;
    _r15.i = _r9.i - _r7.i;
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r17.i = 1;
    _r0_o = _r10_o;
    _r1.i = _r16.i;
    _r2.i = _r17.i;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r15.i = _r15.i - _r16.i;
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r17.i = 3;
    _r0_o = _r10_o;
    _r1.i = _r16.i;
    _r2.i = _r17.i;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r12.i = _r15.i - _r16.i;
    _r15.i = _r3.i - _r11.i;
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r17.i = 0;
    _r0_o = _r10_o;
    _r1.i = _r16.i;
    _r2.i = _r17.i;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r15.i = _r15.i - _r16.i;
    _r16.i = ((global::com.codename1.ui.Container) _r19_o).isRTL() ? 1 : 0;
    _r17.i = 2;
    _r0_o = _r10_o;
    _r1.i = _r16.i;
    _r2.i = _r17.i;
    _r16.i = ((global::com.codename1.ui.plaf.Style) _r0_o).getMargin(0!=_r1.i, (int) _r2.i);
    _r5.i = _r15.i - _r16.i;
    ((global::com.codename1.ui.Component) _r4_o).setX((int) _r13.i);
    ((global::com.codename1.ui.Component) _r4_o).setY((int) _r14.i);
    ((global::com.codename1.ui.Component) _r4_o).setWidth((int) _r12.i);
    ((global::com.codename1.ui.Component) _r4_o).setHeight((int) _r5.i);
    _r6.i = _r6.i + 1;
    goto label86;
    label219:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout: void layoutContainer(com.codename1.ui.Container)]
}

public override global::System.Object getPreferredSize(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    _r13_o = this;
    _r14_o = n1;
    _r12.i = 3;
    _r11.i = 2;
    _r10.i = 1;
    _r9.i = 0;
    _r4.i = 0;
    _r3.i = 0;
    _r5.i = ((global::com.codename1.ui.Container) _r14_o).getComponentCount();
    _r2.i = 0;
    label11:;
    if (_r2.i >= _r5.i) goto label72;
    _r0_o = ((global::com.codename1.ui.Container) _r14_o).getComponentAt((int) _r2.i);
    _r7.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    _r8_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r8_o).getMargin(0!=_r9.i, (int) _r9.i);
    _r7.i = _r7.i + _r8.i;
    _r8_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r8_o).getMargin(0!=_r9.i, (int) _r11.i);
    _r7.i = _r7.i + _r8.i;
    _r3.i = global::java.lang.Math.max((int) _r3.i, (int) _r7.i);
    _r7.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    _r8_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r8_o).getMargin(0!=_r9.i, (int) _r10.i);
    _r7.i = _r7.i + _r8.i;
    _r8_o = ((global::com.codename1.ui.Component) _r0_o).getStyle();
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r8_o).getMargin(0!=_r9.i, (int) _r12.i);
    _r7.i = _r7.i + _r8.i;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r7.i);
    _r2.i = _r2.i + 1;
    goto label11;
    label72:;
    _r6_o = ((global::com.codename1.ui.Container) _r14_o).getStyle();
    _r1_o = new global::com.codename1.ui.geom.Dimension();
    _r7.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getPadding(0!=_r9.i, (int) _r10.i);
    _r7.i = _r7.i + _r4.i;
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getPadding(0!=_r9.i, (int) _r12.i);
    _r7.i = _r7.i + _r8.i;
    _r8.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getPadding(0!=_r9.i, (int) _r9.i);
    _r8.i = _r8.i + _r3.i;
    _r9.i = ((global::com.codename1.ui.plaf.Style) _r6_o).getPadding(0!=_r9.i, (int) _r11.i);
    _r8.i = _r8.i + _r9.i;
    ((global::com.codename1.ui.geom.Dimension) _r1_o).@this((int) _r7.i, (int) _r8.i);
    return (global::com.codename1.ui.geom.Dimension) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=LayeredLayout
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout: java.lang.String toString()]
}

public override bool isOverlapSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout: boolean isOverlapSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout: boolean isOverlapSupported()]
}

public override bool obscuresPotential(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout: boolean obscuresPotential(com.codename1.ui.Container)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout: boolean obscuresPotential(com.codename1.ui.Container)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.LayeredLayout]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.LayeredLayout]

} // end of class: LayeredLayout

} // end of namespace: com.codename1.ui.layouts
