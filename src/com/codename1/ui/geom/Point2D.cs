// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.geom {
public class Point2D: global::java.lang.Object {
private double _fx;

private double _fy;

public void @this(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D: void <init>(double, double)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.d = n1;
    _r3.d = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.ui.geom.Point2D) _r0_o)._fx = _r1.d;
    ((global::com.codename1.ui.geom.Point2D) _r0_o)._fy = _r3.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D: void <init>(double, double)]
}

public virtual double getX(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D: double getX()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.geom.Point2D) _r2_o)._fx;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D: double getX()]
}

public virtual double getY(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D: double getY()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.geom.Point2D) _r2_o)._fy;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D: double getY()]
}

public virtual void setX(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D: void setX(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.d = n1;
    ((global::com.codename1.ui.geom.Point2D) _r0_o)._fx = _r1.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D: void setX(double)]
}

public virtual void setY(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D: void setY(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.d = n1;
    ((global::com.codename1.ui.geom.Point2D) _r0_o)._fy = _r1.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D: void setY(double)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D: java.lang.String toString()]
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
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1.d = ((global::com.codename1.ui.geom.Point2D) _r3_o)._fx;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r1.d);
    // Value=, 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.d = ((global::com.codename1.ui.geom.Point2D) _r3_o)._fy;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r1.d);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Point2D]
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Point2D]

} // end of class: Point2D

} // end of namespace: com.codename1.ui.geom
