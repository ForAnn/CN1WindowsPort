// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.@internal.net.www.protocol.http {
public class HttpConnection: global::java.lang.Object {

static HttpConnection() {
    @static();
}

private bool _fusingSecureSocket;

private global::java.net.Socket _fsocket;

private global::java.lang.Object _fsslSocket;

private global::java.io.InputStream _finputStream;

private global::java.io.OutputStream _foutputStream;

private global::java.io.InputStream _fsslInputStream;

private global::java.io.OutputStream _fsslOutputStream;

private global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration _fconfig;

private static global::java.lang.Class _fSOCKET_1TIMEOUT_1CLASS;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection.SocketTimeoutExceptionClass();
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection._fSOCKET_1TIMEOUT_1CLASS = (global::java.lang.Class) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void <clinit>()]
}

public void @this(global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration n1, int n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void <init>(org.apache.harmony.luni.internal.net.www.protocol.http.HttpConfiguration, int)]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6_o = n1;
    _r7.i = n2;
    ((global::java.lang.Object) _r5_o).@this();
    _r0.i = 0;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r5_o)._fusingSecureSocket = 0!=_r0.i;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r5_o)._fconfig = (global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r6_o;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r6_o).getHostName();
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r6_o).getHostPort();
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r6_o).getProxy();
    if (_r2_o == null) goto label30;
    _r3_o = ((global::java.net.Proxy) _r2_o).type();
    _r4_o = global::java.net.Proxy_2Type._fHTTP;
    if (_r3_o != _r4_o) goto label48;
    label30:;
    _r2_o = new global::java.net.Socket();
    ((global::java.net.Socket) _r2_o).@this();
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r5_o)._fsocket = (global::java.net.Socket) _r2_o;
    label37:;
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r5_o)._fsocket;
    _r3_o = new global::java.net.InetSocketAddress();
    ((global::java.net.InetSocketAddress) _r3_o).@this((global::java.lang.String) _r0_o, (int) _r1.i);
    ((global::java.net.Socket) _r2_o).connect((global::java.net.SocketAddress) _r3_o, (int) _r7.i);
    return;
    label48:;
    _r3_o = new global::java.net.Socket();
    ((global::java.net.Socket) _r3_o).@this((global::java.net.Proxy) _r2_o);
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r5_o)._fsocket = (global::java.net.Socket) _r3_o;
    goto label37;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void <init>(org.apache.harmony.luni.internal.net.www.protocol.http.HttpConfiguration, int)]
}

public virtual void closeSocketAndStreams(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void closeSocketAndStreams()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1_o = null;
    _r0.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fusingSecureSocket ? 1 : 0;
    if (_r0.i == 0) goto label38;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslOutputStream;
    if (_r0_o == null) goto label16;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslOutputStream;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslOutputStream = (global::java.io.OutputStream) _r1_o;
    try {
    ((global::java.io.OutputStream) _r0_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label72;
        }
        throw ex;
    } // end catch
    label16:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslInputStream;
    if (_r0_o == null) goto label27;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslInputStream;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslInputStream = (global::java.io.InputStream) _r1_o;
    try {
    ((global::java.io.InputStream) _r0_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label74;
        }
        throw ex;
    } // end catch
    label27:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslSocket;
    if (_r0_o == null) goto label38;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslSocket;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsslSocket = (global::org.xmlvm.runtime.RedTypeMarker) _r1_o;
    try {
    ((global::java.net.Socket) _r0_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label76;
        }
        throw ex;
    } // end catch
    label38:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._foutputStream;
    if (_r0_o == null) goto label49;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._foutputStream;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._foutputStream = (global::java.io.OutputStream) _r1_o;
    try {
    ((global::java.io.OutputStream) _r0_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label78;
        }
        throw ex;
    } // end catch
    label49:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._finputStream;
    if (_r0_o == null) goto label60;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._finputStream;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._finputStream = (global::java.io.InputStream) _r1_o;
    try {
    ((global::java.io.InputStream) _r0_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label80;
        }
        throw ex;
    } // end catch
    label60:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsocket;
    if (_r0_o == null) goto label71;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsocket;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r2_o)._fsocket = (global::java.net.Socket) _r1_o;
    try {
    ((global::java.net.Socket) _r0_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label82;
        }
        throw ex;
    } // end catch
    label71:;
    return;
    label72:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label16;
    label74:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label27;
    label76:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label38;
    label78:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label49;
    label80:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label60;
    label82:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label71;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void closeSocketAndStreams()]
}

public virtual void setSoTimeout(int n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void setSoTimeout(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsocket;
    ((global::java.net.Socket) _r0_o).setSoTimeout((int) _r2.i);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: void setSoTimeout(int)]
}

public virtual global::System.Object getOutputStream(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.io.OutputStream getOutputStream()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fusingSecureSocket ? 1 : 0;
    if (_r0.i == 0) goto label19;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslOutputStream;
    if (_r0_o != null) goto label16;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslSocket;
// Red class access removed: javax.net.ssl.SSLSocket getOutputStream
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocket getOutputStream");
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslOutputStream = (global::java.io.OutputStream) _r0_o;
    label16:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslOutputStream;
    label18:;
    return (global::java.io.OutputStream) _r0_o;
    label19:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._foutputStream;
    if (_r0_o != null) goto label31;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsocket;
    _r0_o = ((global::java.net.Socket) _r0_o).getOutputStream();
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._foutputStream = (global::java.io.OutputStream) _r0_o;
    label31:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._foutputStream;
    goto label18;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.io.OutputStream getOutputStream()]
}

public virtual global::System.Object getInputStream(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.io.InputStream getInputStream()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fusingSecureSocket ? 1 : 0;
    if (_r0.i == 0) goto label19;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslInputStream;
    if (_r0_o != null) goto label16;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslSocket;
// Red class access removed: javax.net.ssl.SSLSocket getInputStream
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocket getInputStream");
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslInputStream = (global::java.io.InputStream) _r0_o;
    label16:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsslInputStream;
    label18:;
    return (global::java.io.InputStream) _r0_o;
    label19:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._finputStream;
    if (_r0_o != null) goto label31;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsocket;
    _r0_o = ((global::java.net.Socket) _r0_o).getInputStream();
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._finputStream = (global::java.io.InputStream) _r0_o;
    label31:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._finputStream;
    goto label18;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.io.InputStream getInputStream()]
}

public virtual global::System.Object getHttpConfiguration(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: org.apache.harmony.luni.internal.net.www.protocol.http.HttpConfiguration getHttpConfiguration()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fconfig;
    return (global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: org.apache.harmony.luni.internal.net.www.protocol.http.HttpConfiguration getHttpConfiguration()]
}

public virtual global::System.Object getSecureSocket(global::org.xmlvm.runtime.RedTypeMarker n1, global::org.xmlvm.runtime.RedTypeMarker n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.lang.Object getSecureSocket(javax.net.ssl.SSLSocketFactory, javax.net.ssl.HostnameVerifier)]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r3.i = 1;
    _r0.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fusingSecureSocket ? 1 : 0;
    if (_r0.i != 0) goto label63;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fconfig;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r0_o).getHostName();
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fconfig;
    _r0.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConfiguration) _r0_o).getHostPort();
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fsocket;
// Red class access removed: javax.net.ssl.SSLSocketFactory createSocket
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocketFactory createSocket");
// Red class access removed: javax.net.ssl.SSLSocket check-cast
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocket check-cast");
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fsslSocket = (global::org.xmlvm.runtime.RedTypeMarker) _r0_o;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fsslSocket;
// Red class access removed: javax.net.ssl.SSLSocket setUseClientMode
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocket setUseClientMode");
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fsslSocket;
// Red class access removed: javax.net.ssl.SSLSocket startHandshake
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocket startHandshake");
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fsslSocket;
// Red class access removed: javax.net.ssl.SSLSocket getSession
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.SSLSocket getSession");
// Red class access removed: javax.net.ssl.HostnameVerifier verify
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: javax.net.ssl.HostnameVerifier verify");
    if (_r0.i != 0) goto label61;
    _r0_o = new global::java.io.IOException();
    // Value=luni.02
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 50))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (global::java.lang.Object) _r1_o);
    ((global::java.io.IOException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
    label61:;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fusingSecureSocket = 0!=_r3.i;
    label63:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r4_o)._fsslSocket;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.lang.Object getSecureSocket(javax.net.ssl.SSLSocketFactory, javax.net.ssl.HostnameVerifier)]
}

public virtual global::System.Object getSocket(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.net.Socket getSocket()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r1_o)._fsocket;
    return (global::java.net.Socket) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.net.Socket getSocket()]
}

public virtual bool isStale(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: boolean isStale()]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r4.i = 1;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._fsocket;
    _r0.i = ((global::java.net.Socket) _r0_o).isClosed() ? 1 : 0;
    if (_r0.i != 0) goto label81;
    _r0.i = 0;
    try {
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._finputStream;
    _r1.i = ((global::java.io.InputStream) _r1_o).available();
    if (_r1.i > 0) goto label51;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._fsocket;
    _r1.i = ((global::java.net.Socket) _r1_o).getSoTimeout();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.InterruptedIOException) {
            _ex = ex;
            goto label65;
        }
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label76;
        }
        throw ex;
    } // end catch
    try {
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._fsocket;
    _r3.i = 1;
    ((global::java.net.Socket) _r2_o).setSoTimeout((int) _r3.i);
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._finputStream;
    _r3.i = 1;
    ((global::java.io.InputStream) _r2_o).mark((int) _r3.i);
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._finputStream;
    _r2.i = ((global::java.io.InputStream) _r2_o).read();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    _r3.i = -1;
    if (_r2.i != _r3.i) goto label52;
    _r0.i = _r4.i;
    label46:;
    try {
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._fsocket;
    ((global::java.net.Socket) _r2_o).setSoTimeout((int) _r1.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.InterruptedIOException) {
            _ex = ex;
            goto label65;
        }
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label76;
        }
        throw ex;
    } // end catch
    label51:;
    return _r0.i!=0;
    label52:;
    try {
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._finputStream;
    ((global::java.io.InputStream) _r2_o).reset();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label58;
        }
        throw ex;
    } // end catch
    goto label46;
    label58:;
    _r2_o = _ex.getJavaException();
    _ex = null;
    try {
    _r3_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection) _r6_o)._fsocket;
    ((global::java.net.Socket) _r3_o).setSoTimeout((int) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.InterruptedIOException) {
            _ex = ex;
            goto label65;
        }
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label76;
        }
        throw ex;
    } // end catch
    label65:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r5_o = _r1_o;
    _r1.i = _r0.i;
    _r0_o = _r5_o;
    _r2.i = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection.isSocketTimeoutException((global::java.io.InterruptedIOException) _r0_o) ? 1 : 0;
    if (_r2.i != 0) goto label79;
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label76:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0.i = _r4.i;
    goto label51;
    label79:;
    _r0.i = _r1.i;
    goto label51;
    label81:;
    _r0.i = _r4.i;
    goto label51;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: boolean isStale()]
}

public static bool isSocketTimeoutException(global::java.io.InterruptedIOException n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: boolean isSocketTimeoutException(java.io.InterruptedIOException)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r0_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection._fSOCKET_1TIMEOUT_1CLASS;
    if (_r0_o == null) goto label11;
    _r0_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpConnection._fSOCKET_1TIMEOUT_1CLASS;
    _r0.i = ((global::java.lang.Class) _r0_o).isInstance((global::java.lang.Object) _r1_o) ? 1 : 0;
    label10:;
    return _r0.i!=0;
    label11:;
    _r0.i = 1;
    goto label10;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: boolean isSocketTimeoutException(java.io.InterruptedIOException)]
}

private static global::System.Object SocketTimeoutExceptionClass(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.lang.Class SocketTimeoutExceptionClass()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    try {
    // Value=java.net.SocketTimeoutException
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)106)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r0_o = global::java.lang.Class.forName((global::java.lang.String) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label7;
        }
        throw ex;
    } // end catch
    label6:;
    return (global::java.lang.Class) _r0_o;
    label7:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = null;
    goto label6;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection: java.lang.Class SocketTimeoutExceptionClass()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpConnection]

} // end of class: HttpConnection

} // end of namespace: org.apache.harmony.luni.@internal.net.www.protocol.http
