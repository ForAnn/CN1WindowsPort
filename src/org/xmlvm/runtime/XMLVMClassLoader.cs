// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xmlvm.runtime {
public class XMLVMClassLoader: global::java.lang.ClassLoader {
public void @this(){
//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.ClassLoader) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader: void <init>()]
}

public override global::System.Object findClass(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader: java.lang.Class findClass(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::java.lang.Class.forName((global::java.lang.String) _r2_o);
    return (global::java.lang.Class) _r0_o;
//XMLVM_END_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader: java.lang.Class findClass(java.lang.String)]
}

public override global::System.Object findResource(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader: java.net.URL findResource(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.lang.Object) _r1_o).getClass();
    _r0_o = ((global::java.lang.Class) _r0_o).getResource((global::java.lang.String) _r2_o);
    return (global::java.net.URL) _r0_o;
//XMLVM_END_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader: java.net.URL findResource(java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader]
//XMLVM_END_WRAPPER[org.xmlvm.runtime.XMLVMClassLoader]

} // end of class: XMLVMClassLoader

} // end of namespace: org.xmlvm.runtime
