// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class IllegalFormatPrecisionException: global::java.util.IllegalFormatException {
private static long _fserialVersionUID = 18711008L;

private int _fp;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatPrecisionException: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.IllegalFormatException) _r0_o).@this();
    ((global::java.util.IllegalFormatPrecisionException) _r0_o)._fp = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.IllegalFormatPrecisionException: void <init>(int)]
}

public virtual int getPrecision(){
//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatPrecisionException: int getPrecision()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.IllegalFormatPrecisionException) _r1_o)._fp;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.IllegalFormatPrecisionException: int getPrecision()]
}

public override global::System.Object getMessage(){
//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatPrecisionException: java.lang.String getMessage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.IllegalFormatPrecisionException) _r1_o)._fp;
    _r0_o = global::java.lang.String.valueOf((int) _r0.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.IllegalFormatPrecisionException: java.lang.String getMessage()]
}

//XMLVM_BEGIN_WRAPPER[java.util.IllegalFormatPrecisionException]
//XMLVM_END_WRAPPER[java.util.IllegalFormatPrecisionException]

} // end of class: IllegalFormatPrecisionException

} // end of namespace: java.util
