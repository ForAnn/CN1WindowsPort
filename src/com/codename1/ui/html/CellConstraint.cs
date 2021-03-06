// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class CellConstraint: global::java.lang.Object {
public int _fwidth;

public int _fheight;

public int _fspanHorizontal;

public int _fspanVertical;

public int _falign;

public int _fvalign;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1.i = 1;
    _r0.i = -1;
    ((global::java.lang.Object) _r2_o).@this();
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fwidth = _r0.i;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fheight = _r0.i;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fspanHorizontal = _r1.i;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fspanVertical = _r1.i;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._falign = _r0.i;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fvalign = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void <init>()]
}

public virtual void setVerticalSpan(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void setVerticalSpan(int)]
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
    _r3.i = n1;
    _r0.i = 1;
    if (_r3.i >= _r0.i) goto label11;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Illegal span
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label11:;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fspanVertical = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void setVerticalSpan(int)]
}

public virtual void setHorizontalSpan(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void setHorizontalSpan(int)]
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
    _r3.i = n1;
    _r0.i = 1;
    if (_r3.i >= _r0.i) goto label11;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Illegal span
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label11:;
    ((global::com.codename1.ui.html.CellConstraint) _r2_o)._fspanHorizontal = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void setHorizontalSpan(int)]
}

public virtual void setWidthPercentage(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void setWidthPercentage(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.html.CellConstraint) _r0_o)._fwidth = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void setWidthPercentage(int)]
}

public virtual void setHeightPercentage(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void setHeightPercentage(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.html.CellConstraint) _r0_o)._fheight = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void setHeightPercentage(int)]
}

public virtual void setHorizontalAlign(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void setHorizontalAlign(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.html.CellConstraint) _r0_o)._falign = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void setHorizontalAlign(int)]
}

public virtual void setVerticalAlign(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint: void setVerticalAlign(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.html.CellConstraint) _r0_o)._fvalign = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint: void setVerticalAlign(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.CellConstraint]
//XMLVM_END_WRAPPER[com.codename1.ui.html.CellConstraint]

} // end of class: CellConstraint

} // end of namespace: com.codename1.ui.html
