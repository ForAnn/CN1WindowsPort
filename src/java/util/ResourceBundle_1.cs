// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class ResourceBundle_21: global::java.lang.Object,global::java.security.PrivilegedAction {
new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.ResourceBundle$1: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.ResourceBundle$1: void <init>()]
}

public virtual global::System.Object run(){
//XMLVM_BEGIN_WRAPPER[java.util.ResourceBundle$1: java.lang.ClassLoader run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.lang.Object) _r1_o).getClass();
    _r0_o = ((global::java.lang.Class) _r0_o).getClassLoader();
    if (_r0_o != null) goto label14;
    _r0_o = global::java.lang.ClassLoader.getSystemClassLoader();
    label14:;
    return (global::java.lang.ClassLoader) _r0_o;
//XMLVM_END_WRAPPER[java.util.ResourceBundle$1: java.lang.ClassLoader run()]
}

//XMLVM_BEGIN_WRAPPER[java.util.ResourceBundle$1]
//XMLVM_END_WRAPPER[java.util.ResourceBundle$1]

} // end of class: ResourceBundle_21

} // end of namespace: java.util
