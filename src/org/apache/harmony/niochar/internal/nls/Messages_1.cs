// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.@internal.nls {
public class Messages_21: global::java.lang.Object,global::java.security.PrivilegedAction {
private global::java.lang.String _fval_2resource;

private global::java.util.Locale _fval_2locale;

private global::java.lang.ClassLoader _fval_2loader;

public void @this(global::java.lang.String n1, global::java.util.Locale n2, global::java.lang.ClassLoader n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages$1: void <init>(java.lang.String, java.util.Locale, java.lang.ClassLoader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r0_o)._fval_2resource = (global::java.lang.String) _r1_o;
    ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r0_o)._fval_2locale = (global::java.util.Locale) _r2_o;
    ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r0_o)._fval_2loader = (global::java.lang.ClassLoader) _r3_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages$1: void <init>(java.lang.String, java.util.Locale, java.lang.ClassLoader)]
}

public virtual global::System.Object run(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages$1: java.lang.Object run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r3_o)._fval_2resource;
    _r1_o = ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r3_o)._fval_2locale;
    _r2_o = ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r3_o)._fval_2loader;
    if (_r2_o == null) goto label15;
    _r2_o = ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r3_o)._fval_2loader;
    label10:;
    _r0_o = global::java.util.ResourceBundle.getBundle((global::java.lang.String) _r0_o, (global::java.util.Locale) _r1_o, (global::java.lang.ClassLoader) _r2_o);
    return (global::java.lang.Object) _r0_o;
    label15:;
    _r2_o = global::java.lang.ClassLoader.getSystemClassLoader();
    goto label10;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages$1: java.lang.Object run()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages$1]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages$1]

} // end of class: Messages_21

} // end of namespace: org.apache.harmony.niochar.@internal.nls
