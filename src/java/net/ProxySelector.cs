// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public abstract class ProxySelector: global::java.lang.Object {

static ProxySelector() {
    @static();
}

private static global::java.net.ProxySelector _fdefaultSelector;

private static global::java.net.NetPermission _fgetProxySelectorPermission;

private static global::java.net.NetPermission _fsetProxySelectorPermission;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelector: void <clinit>()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = new global::java.net.ProxySelectorImpl();
    ((global::java.net.ProxySelectorImpl) _r0_o).@this();
    global::java.net.ProxySelector._fdefaultSelector = (global::java.net.ProxySelector) _r0_o;
    _r0_o = new global::java.net.NetPermission();
    // Value=getProxySelector
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.net.NetPermission) _r0_o).@this((global::java.lang.String) _r1_o);
    global::java.net.ProxySelector._fgetProxySelectorPermission = (global::java.net.NetPermission) _r0_o;
    _r0_o = new global::java.net.NetPermission();
    // Value=setProxySelector
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    ((global::java.net.NetPermission) _r0_o).@this((global::java.lang.String) _r1_o);
    global::java.net.ProxySelector._fsetProxySelectorPermission = (global::java.net.NetPermission) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.net.ProxySelector: void <clinit>()]
}

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelector: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.net.ProxySelector: void <init>()]
}

public static global::System.Object getDefault(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelector: java.net.ProxySelector getDefault()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = global::java.lang.System.getSecurityManager();
    if (_r0_o == null) goto label11;
    _r1_o = global::java.net.ProxySelector._fgetProxySelectorPermission;
    ((global::java.lang.SecurityManager) _r0_o).checkPermission((global::java.security.Permission) _r1_o);
    label11:;
    _r0_o = global::java.net.ProxySelector._fdefaultSelector;
    return (global::java.net.ProxySelector) _r0_o;
//XMLVM_END_WRAPPER[java.net.ProxySelector: java.net.ProxySelector getDefault()]
}

public static void setDefault(global::java.net.ProxySelector n1){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelector: void setDefault(java.net.ProxySelector)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0_o = global::java.lang.System.getSecurityManager();
    if (_r0_o == null) goto label11;
    _r1_o = global::java.net.ProxySelector._fsetProxySelectorPermission;
    ((global::java.lang.SecurityManager) _r0_o).checkPermission((global::java.security.Permission) _r1_o);
    label11:;
    global::java.net.ProxySelector._fdefaultSelector = (global::java.net.ProxySelector) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.net.ProxySelector: void setDefault(java.net.ProxySelector)]
}

public abstract global::System.Object select(global::java.net.URI n1);

public abstract void connectFailed(global::java.net.URI n1, global::java.net.SocketAddress n2, global::java.io.IOException n3);

//XMLVM_BEGIN_WRAPPER[java.net.ProxySelector]
//XMLVM_END_WRAPPER[java.net.ProxySelector]

} // end of class: ProxySelector

} // end of namespace: java.net
