// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class CoordinateLayout: global::com.codename1.ui.layouts.Layout {
private int _fwidth;

private int _fheight;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = -1;
    ((global::com.codename1.ui.layouts.Layout) _r1_o).@this();
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r1_o)._fwidth = _r0.i;
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r1_o)._fheight = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void <init>()]
}

public void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void <init>(int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    _r0_o = this;
    _r1.i = n1;
    _r2.i = n2;
    ((global::com.codename1.ui.layouts.Layout) _r0_o).@this();
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r0_o)._fwidth = _r1.i;
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r0_o)._fheight = _r2.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void <init>(int, int)]
}

public void @this(global::com.codename1.ui.geom.Dimension n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void <init>(com.codename1.ui.geom.Dimension)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::com.codename1.ui.geom.Dimension) _r3_o).getWidth();
    _r1.i = ((global::com.codename1.ui.geom.Dimension) _r3_o).getHeight();
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r2_o).@this((int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void <init>(com.codename1.ui.geom.Dimension)]
}

public override void layoutContainer(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void layoutContainer(com.codename1.ui.Container)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r7.i = ((global::com.codename1.ui.layouts.CoordinateLayout) _r9_o)._fwidth;
    if (_r7.i >= 0) goto label5;
    label4:;
    return;
    label5:;
    _r2.i = ((global::com.codename1.ui.Container) _r10_o).getComponentCount();
    _r4.i = ((global::com.codename1.ui.Container) _r10_o).getWidth();
    _r3.i = ((global::com.codename1.ui.Container) _r10_o).getHeight();
    _r1.i = 0;
    label18:;
    if (_r1.i >= _r2.i) goto label65;
    _r0_o = ((global::com.codename1.ui.Container) _r10_o).getComponentAt((int) _r1.i);
    _r7.i = ((global::com.codename1.ui.Component) _r0_o).getX();
    _r7.i = _r7.i * _r4.i;
    _r8.i = ((global::com.codename1.ui.layouts.CoordinateLayout) _r9_o)._fwidth;
    _r5.i = _r7.i / _r8.i;
    _r7.i = ((global::com.codename1.ui.Component) _r0_o).getY();
    _r7.i = _r7.i * _r3.i;
    _r8.i = ((global::com.codename1.ui.layouts.CoordinateLayout) _r9_o)._fheight;
    _r6.i = _r7.i / _r8.i;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r5.i);
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r6.i);
    _r7.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    ((global::com.codename1.ui.Component) _r0_o).setWidth((int) _r7.i);
    _r7.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    ((global::com.codename1.ui.Component) _r0_o).setHeight((int) _r7.i);
    _r1.i = _r1.i + 1;
    goto label18;
    label65:;
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r9_o)._fwidth = _r4.i;
    ((global::com.codename1.ui.layouts.CoordinateLayout) _r9_o)._fheight = _r3.i;
    goto label4;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: void layoutContainer(com.codename1.ui.Container)]
}

public override global::System.Object getPreferredSize(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r3_o = new global::com.codename1.ui.geom.Dimension();
    ((global::com.codename1.ui.geom.Dimension) _r3_o).@this();
    _r2.i = ((global::com.codename1.ui.Container) _r8_o).getComponentCount();
    _r1.i = 0;
    label10:;
    if (_r1.i >= _r2.i) goto label59;
    _r0_o = ((global::com.codename1.ui.Container) _r8_o).getComponentAt((int) _r1.i);
    _r4.i = ((global::com.codename1.ui.geom.Dimension) _r3_o).getWidth();
    _r5.i = ((global::com.codename1.ui.Component) _r0_o).getX();
    _r6.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    _r5.i = _r5.i + _r6.i;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r5.i);
    ((global::com.codename1.ui.geom.Dimension) _r3_o).setWidth((int) _r4.i);
    _r4.i = ((global::com.codename1.ui.geom.Dimension) _r3_o).getHeight();
    _r5.i = ((global::com.codename1.ui.Component) _r0_o).getY();
    _r6.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    _r5.i = _r5.i + _r6.i;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r5.i);
    ((global::com.codename1.ui.geom.Dimension) _r3_o).setHeight((int) _r4.i);
    _r1.i = _r1.i + 1;
    goto label10;
    label59:;
    return (global::com.codename1.ui.geom.Dimension) _r3_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: com.codename1.ui.geom.Dimension getPreferredSize(com.codename1.ui.Container)]
}

public override bool isOverlapSupported(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: boolean isOverlapSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout: boolean isOverlapSupported()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.CoordinateLayout]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.CoordinateLayout]

} // end of class: CoordinateLayout

} // end of namespace: com.codename1.ui.layouts
