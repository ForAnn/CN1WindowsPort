// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class MissingFormatWidthException: global::java.util.IllegalFormatException {
private static long _fserialVersionUID = 15560123L;

private global::java.lang.String _fs;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.util.MissingFormatWidthException: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.IllegalFormatException) _r1_o).@this();
    if (_r2_o != null) goto label11;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label11:;
    ((global::java.util.MissingFormatWidthException) _r1_o)._fs = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.util.MissingFormatWidthException: void <init>(java.lang.String)]
}

public virtual global::System.Object getFormatSpecifier(){
//XMLVM_BEGIN_WRAPPER[java.util.MissingFormatWidthException: java.lang.String getFormatSpecifier()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.MissingFormatWidthException) _r1_o)._fs;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.MissingFormatWidthException: java.lang.String getFormatSpecifier()]
}

public override global::System.Object getMessage(){
//XMLVM_BEGIN_WRAPPER[java.util.MissingFormatWidthException: java.lang.String getMessage()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.MissingFormatWidthException) _r1_o)._fs;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.MissingFormatWidthException: java.lang.String getMessage()]
}

//XMLVM_BEGIN_WRAPPER[java.util.MissingFormatWidthException]
//XMLVM_END_WRAPPER[java.util.MissingFormatWidthException]

} // end of class: MissingFormatWidthException

} // end of namespace: java.util
