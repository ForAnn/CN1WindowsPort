// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class IOException: global::java.lang.Exception {

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.io.IOException: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Exception) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.io.IOException: void <init>()]
}

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.io.IOException: void <init>(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Exception) _r0_o).@this((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.io.IOException: void <init>(java.lang.String)]
}

public void @this(global::java.lang.String n1, global::java.lang.Throwable n2){
//XMLVM_BEGIN_WRAPPER[java.io.IOException: void <init>(java.lang.String, java.lang.Throwable)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.lang.Exception) _r0_o).@this((global::java.lang.String) _r1_o, (global::java.lang.Throwable) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.io.IOException: void <init>(java.lang.String, java.lang.Throwable)]
}

public void @this(global::java.lang.Throwable n1){
//XMLVM_BEGIN_WRAPPER[java.io.IOException: void <init>(java.lang.Throwable)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    if (_r2_o != null) goto label7;
    _r0_o = null;
    label3:;
    ((global::java.lang.Exception) _r1_o).@this((global::java.lang.String) _r0_o, (global::java.lang.Throwable) _r2_o);
    return;
    label7:;
    _r0_o = ((global::java.lang.Throwable) _r2_o).toString();
    goto label3;
//XMLVM_END_WRAPPER[java.io.IOException: void <init>(java.lang.Throwable)]
}

//XMLVM_BEGIN_WRAPPER[java.io.IOException]
//XMLVM_END_WRAPPER[java.io.IOException]

} // end of class: IOException

} // end of namespace: java.io
