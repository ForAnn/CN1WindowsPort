// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang {
public class Integer_2valueOfCache: global::java.lang.Object {

static Integer_2valueOfCache() {
    @static();
}

public static global::org.xmlvm._nArrayAdapter<global::System.Object> _fCACHE;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.lang.Integer$valueOfCache: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0.i = 256;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    global::java.lang.Integer_2valueOfCache._fCACHE = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    _r0.i = -128;
    label8:;
    _r1.i = 127;
    if (_r0.i <= _r1.i) goto label13;
    return;
    label13:;
    _r1_o = global::java.lang.Integer_2valueOfCache._fCACHE;
    _r2.i = _r0.i + 128;
    _r3_o = new global::java.lang.Integer();
    ((global::java.lang.Integer) _r3_o).@this((int) _r0.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r0.i = _r0.i + 1;
    goto label8;
//XMLVM_END_WRAPPER[java.lang.Integer$valueOfCache: void <clinit>()]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.Integer$valueOfCache: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.Integer$valueOfCache: void <init>()]
}

//XMLVM_BEGIN_WRAPPER[java.lang.Integer$valueOfCache]
//XMLVM_END_WRAPPER[java.lang.Integer$valueOfCache]

} // end of class: Integer_2valueOfCache

} // end of namespace: java.lang
