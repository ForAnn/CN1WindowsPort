// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.@internal.net.www.protocol.http {
public class Handler: global::java.net.URLStreamHandler {
public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.net.URLStreamHandler) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: void <init>()]
}

public override global::System.Object openConnection(global::java.net.URL n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: java.net.URLConnection openConnection(java.net.URL)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl();
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.Handler) _r2_o).getDefaultPort();
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o).@this((global::java.net.URL) _r3_o, (int) _r1.i);
    return (global::java.net.URLConnection) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: java.net.URLConnection openConnection(java.net.URL)]
}

public override global::System.Object openConnection(global::java.net.URL n1, global::java.net.Proxy n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: java.net.URLConnection openConnection(java.net.URL, java.net.Proxy)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    if (_r3_o == null) goto label4;
    if (_r4_o != null) goto label16;
    label4:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.1B
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 66))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label16:;
    _r0_o = new global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl();
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.Handler) _r2_o).getDefaultPort();
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o).@this((global::java.net.URL) _r3_o, (int) _r1.i, (global::java.net.Proxy) _r4_o);
    return (global::java.net.URLConnection) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: java.net.URLConnection openConnection(java.net.URL, java.net.Proxy)]
}

public override int getDefaultPort(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: int getDefaultPort()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 80;
    return _r0.i;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler: int getDefaultPort()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.Handler]

} // end of class: Handler

} // end of namespace: org.apache.harmony.luni.@internal.net.www.protocol.http
