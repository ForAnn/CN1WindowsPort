// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.geom {
public class Dimension2D: global::java.lang.Object {
private double _fwidth;

private double _fheight;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: void <init>()]
}

public void @this(global::com.codename1.ui.geom.Dimension2D n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: void <init>(com.codename1.ui.geom.Dimension2D)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.d = ((global::com.codename1.ui.geom.Dimension2D) _r3_o)._fwidth;
    ((global::com.codename1.ui.geom.Dimension2D) _r2_o)._fwidth = _r0.d;
    _r0.d = ((global::com.codename1.ui.geom.Dimension2D) _r3_o)._fheight;
    ((global::com.codename1.ui.geom.Dimension2D) _r2_o)._fheight = _r0.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: void <init>(com.codename1.ui.geom.Dimension2D)]
}

public void @this(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: void <init>(double, double)]
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
    ((global::com.codename1.ui.geom.Dimension2D) _r0_o)._fwidth = _r1.d;
    ((global::com.codename1.ui.geom.Dimension2D) _r0_o)._fheight = _r3.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: void <init>(double, double)]
}

public virtual void setWidth(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: void setWidth(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.d = n1;
    ((global::com.codename1.ui.geom.Dimension2D) _r0_o)._fwidth = _r1.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: void setWidth(double)]
}

public virtual void setHeight(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: void setHeight(double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.d = n1;
    ((global::com.codename1.ui.geom.Dimension2D) _r0_o)._fheight = _r1.d;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: void setHeight(double)]
}

public virtual double getWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: double getWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.geom.Dimension2D) _r2_o)._fwidth;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: double getWidth()]
}

public virtual double getHeight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: double getHeight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.geom.Dimension2D) _r2_o)._fheight;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: double getHeight()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D: java.lang.String toString()]
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
    // Value=width = 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)119)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.d = ((global::com.codename1.ui.geom.Dimension2D) _r3_o)._fwidth;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r1.d);
    // Value= height = 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.d = ((global::com.codename1.ui.geom.Dimension2D) _r3_o)._fheight;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((double) _r1.d);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.geom.Dimension2D]
//XMLVM_END_WRAPPER[com.codename1.ui.geom.Dimension2D]

} // end of class: Dimension2D

} // end of namespace: com.codename1.ui.geom
