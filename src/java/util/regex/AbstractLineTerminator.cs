// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public abstract class AbstractLineTerminator: global::java.lang.Object {

static AbstractLineTerminator() {
    @static();
}

public static global::java.util.regex.AbstractLineTerminator _funixLT;

public static global::java.util.regex.AbstractLineTerminator _funicodeLT;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractLineTerminator: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = null;
    global::java.util.regex.AbstractLineTerminator._funixLT = (global::java.util.regex.AbstractLineTerminator) _r0_o;
    global::java.util.regex.AbstractLineTerminator._funicodeLT = (global::java.util.regex.AbstractLineTerminator) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractLineTerminator: void <clinit>()]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractLineTerminator: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.AbstractLineTerminator: void <init>()]
}

public abstract bool isLineTerminator(int n1);

public abstract bool isAfterLineTerminator(int n1, int n2);

public static global::System.Object getInstance(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractLineTerminator: java.util.regex.AbstractLineTerminator getInstance(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = n1;
    _r0.i = _r1.i & 1;
    if (_r0.i == 0) goto label21;
    _r0_o = global::java.util.regex.AbstractLineTerminator._funixLT;
    if (_r0_o == null) goto label11;
    _r0_o = global::java.util.regex.AbstractLineTerminator._funixLT;
    label10:;
    return (global::java.util.regex.AbstractLineTerminator) _r0_o;
    label11:;
    _r0_o = new global::java.util.regex.AbstractLineTerminator_21();
    ((global::java.util.regex.AbstractLineTerminator_21) _r0_o).@this();
    global::java.util.regex.AbstractLineTerminator._funixLT = (global::java.util.regex.AbstractLineTerminator) _r0_o;
    _r0_o = global::java.util.regex.AbstractLineTerminator._funixLT;
    goto label10;
    label21:;
    _r0_o = global::java.util.regex.AbstractLineTerminator._funicodeLT;
    if (_r0_o == null) goto label28;
    _r0_o = global::java.util.regex.AbstractLineTerminator._funicodeLT;
    goto label10;
    label28:;
    _r0_o = new global::java.util.regex.AbstractLineTerminator_22();
    ((global::java.util.regex.AbstractLineTerminator_22) _r0_o).@this();
    global::java.util.regex.AbstractLineTerminator._funicodeLT = (global::java.util.regex.AbstractLineTerminator) _r0_o;
    _r0_o = global::java.util.regex.AbstractLineTerminator._funicodeLT;
    goto label10;
//XMLVM_END_WRAPPER[java.util.regex.AbstractLineTerminator: java.util.regex.AbstractLineTerminator getInstance(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.AbstractLineTerminator]
//XMLVM_END_WRAPPER[java.util.regex.AbstractLineTerminator]

} // end of class: AbstractLineTerminator

} // end of namespace: java.util.regex
