// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class Quantifier: global::java.util.regex.SpecialToken,global::java.lang.Cloneable {
private int _fmin;

private int _fmax;

private int _fcounter;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    ((global::java.util.regex.SpecialToken) _r1_o).@this();
    _r0.i = 0;
    ((global::java.util.regex.Quantifier) _r1_o)._fcounter = _r0.i;
    ((global::java.util.regex.Quantifier) _r1_o)._fmax = _r2.i;
    ((global::java.util.regex.Quantifier) _r1_o)._fmin = _r2.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: void <init>(int)]
}

public void @this(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: void <init>(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    ((global::java.util.regex.SpecialToken) _r1_o).@this();
    _r0.i = 0;
    ((global::java.util.regex.Quantifier) _r1_o)._fcounter = _r0.i;
    ((global::java.util.regex.Quantifier) _r1_o)._fmin = _r2.i;
    ((global::java.util.regex.Quantifier) _r1_o)._fmax = _r3.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: void <init>(int, int)]
}

public virtual void resetCounter(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: void resetCounter()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    ((global::java.util.regex.Quantifier) _r1_o)._fcounter = _r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: void resetCounter()]
}

public virtual int getCounter(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: int getCounter()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.regex.Quantifier) _r1_o)._fcounter;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: int getCounter()]
}

public virtual void setCounter(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: void setCounter(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.regex.Quantifier) _r0_o)._fcounter = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: void setCounter(int)]
}

public virtual int min(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: int min()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.regex.Quantifier) _r1_o)._fmin;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: int min()]
}

public virtual int max(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: int max()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.regex.Quantifier) _r1_o)._fmax;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: int max()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: java.lang.String toString()]
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
    // Value=\173
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)123))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.util.regex.Quantifier) _r3_o)._fmin;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=,
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.util.regex.Quantifier) _r3_o)._fmax;
    _r2.i = 2147483647;
    if (_r1.i != _r2.i) goto label43;
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label28:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value=\175
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)125))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label43:;
    _r1_o = new global::java.lang.Integer();
    _r2.i = ((global::java.util.regex.Quantifier) _r3_o)._fmax;
    ((global::java.lang.Integer) _r1_o).@this((int) _r2.i);
    _r1_o = ((global::java.lang.Integer) _r1_o).toString();
    goto label28;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: java.lang.String toString()]
}

public override int getType(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: int getType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 2;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: int getType()]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier: java.lang.Object clone()]
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
    _r0_o = new global::java.util.regex.Quantifier();
    _r1.i = ((global::java.util.regex.Quantifier) _r3_o)._fmin;
    _r2.i = ((global::java.util.regex.Quantifier) _r3_o)._fmax;
    ((global::java.util.regex.Quantifier) _r0_o).@this((int) _r1.i, (int) _r2.i);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.Quantifier: java.lang.Object clone()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.Quantifier]
//XMLVM_END_WRAPPER[java.util.regex.Quantifier]

} // end of class: Quantifier

} // end of namespace: java.util.regex
