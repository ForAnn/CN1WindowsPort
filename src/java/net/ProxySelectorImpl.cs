// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public class ProxySelectorImpl: global::java.net.ProxySelector {

static ProxySelectorImpl() {
    @static();
}





private static global::java.util.Properties _fnetProps;

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.net.ProxySelector) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: void <init>()]
}

public override void connectFailed(global::java.net.URI n1, global::java.net.SocketAddress n2, global::java.io.IOException n3){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: void connectFailed(java.net.URI, java.net.SocketAddress, java.io.IOException)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5_o = n3;
    if (_r3_o == null) goto label6;
    if (_r4_o == null) goto label6;
    if (_r5_o != null) goto label18;
    label6:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.4D
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 68))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label18:;
    return;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: void connectFailed(java.net.URI, java.net.SocketAddress, java.io.IOException)]
}

public override global::System.Object select(global::java.net.URI n1){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.util.List select(java.net.URI)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r6_o = this;
    _r7_o = n1;
    if (_r7_o != null) goto label14;
    _r4_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.4D
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 52)), unchecked((char) unchecked((uint) 68))}));
    _r5_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r5_o);
    ((global::java.lang.IllegalArgumentException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r4_o);
    label14:;
    _r3_o = ((global::java.net.URI) _r7_o).getScheme();
    if (_r3_o != null) goto label26;
    _r4_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r4_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r4_o);
    label26:;
    _r0_o = ((global::java.net.URI) _r7_o).getHost();
    _r1_o = global::java.net.Proxy._fNO_1PROXY;
    // Value=http
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112))}));
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r4.i == 0) goto label54;
    _r1_o = ((global::java.net.ProxySelectorImpl) _r6_o).selectHttpProxy((global::java.lang.String) _r0_o);
    label44:;
    _r2_o = new global::java.util.ArrayList();
    _r4.i = 1;
    ((global::java.util.ArrayList) _r2_o).@this((int) _r4.i);
    ((global::java.util.List) _r2_o).add((global::java.lang.Object) _r1_o);
    return (global::java.util.List) _r2_o;
    label54:;
    // Value=https
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115))}));
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r4.i == 0) goto label67;
    _r1_o = ((global::java.net.ProxySelectorImpl) _r6_o).selectHttpsProxy();
    goto label44;
    label67:;
    // Value=ftp
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112))}));
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r4.i == 0) goto label80;
    _r1_o = ((global::java.net.ProxySelectorImpl) _r6_o).selectFtpProxy((global::java.lang.String) _r0_o);
    goto label44;
    label80:;
    // Value=socket
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r4.i == 0) goto label44;
    _r1_o = ((global::java.net.ProxySelectorImpl) _r6_o).selectSocksProxy();
    goto label44;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.util.List select(java.net.URI)]
}

private global::System.Object selectHttpProxy(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectHttpProxy(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    _r11_o = this;
    _r12_o = n1;
    _r8.i = 1080;
    _r7.i = 80;
    // Value=proxyPort
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    // Value=http.proxyPort
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r3_o = null;
    _r4_o = global::java.net.Proxy_2Type._fDIRECT;
    // Value=http.nonProxyHosts
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115))}));
    _r2_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemProperty((global::java.lang.String) _r5_o);
    _r5.i = ((global::java.net.ProxySelectorImpl) _r11_o).isNonProxyHost((global::java.lang.String) _r12_o, (global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r5.i == 0) goto label26;
    _r5_o = global::java.net.Proxy._fNO_1PROXY;
    label25:;
    return (global::java.net.Proxy) _r5_o;
    label26:;
    // Value=http.proxyHost
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemProperty((global::java.lang.String) _r5_o);
    if (_r1_o == null) goto label58;
    _r4_o = global::java.net.Proxy_2Type._fHTTP;
    // Value=http.proxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    // Value=proxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r5_o = global::java.lang.String.valueOf((int) _r7.i);
    _r3_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemPropertyOrAlternative((global::java.lang.String) _r9_o, (global::java.lang.String) _r10_o, (global::java.lang.String) _r5_o);
    label48:;
    _r5_o = global::java.net.Proxy_2Type._fSOCKS;
    if (_r4_o != _r5_o) goto label103;
    _r0.i = _r8.i;
    label53:;
    _r5_o = ((global::java.net.ProxySelectorImpl) _r11_o).createProxy((global::java.net.Proxy_2Type) _r4_o, (global::java.lang.String) _r1_o, (global::java.lang.String) _r3_o, (int) _r0.i);
    goto label25;
    label58:;
    // Value=proxyHost
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r6_o = null;
    _r1_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemProperty((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    if (_r1_o == null) goto label82;
    _r4_o = global::java.net.Proxy_2Type._fHTTP;
    // Value=proxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    // Value=http.proxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r5_o = global::java.lang.String.valueOf((int) _r7.i);
    _r3_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemPropertyOrAlternative((global::java.lang.String) _r10_o, (global::java.lang.String) _r9_o, (global::java.lang.String) _r5_o);
    goto label48;
    label82:;
    // Value=socksProxyHost
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemProperty((global::java.lang.String) _r5_o);
    if (_r1_o == null) goto label48;
    _r4_o = global::java.net.Proxy_2Type._fSOCKS;
    // Value=socksProxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r6_o = global::java.lang.String.valueOf((int) _r8.i);
    _r3_o = ((global::java.net.ProxySelectorImpl) _r11_o).getSystemProperty((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    goto label48;
    label103:;
    _r0.i = _r7.i;
    goto label53;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectHttpProxy(java.lang.String)]
}

private global::System.Object selectHttpsProxy(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectHttpsProxy()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    _r8_o = this;
    _r7.i = 1080;
    _r6.i = 443;
    _r2_o = null;
    _r3_o = global::java.net.Proxy_2Type._fDIRECT;
    // Value=https.proxyHost
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::java.net.ProxySelectorImpl) _r8_o).getSystemProperty((global::java.lang.String) _r4_o);
    if (_r1_o == null) goto label37;
    _r3_o = global::java.net.Proxy_2Type._fHTTP;
    // Value=https.proxyPort
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)104)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r5_o = global::java.lang.String.valueOf((int) _r6.i);
    _r2_o = ((global::java.net.ProxySelectorImpl) _r8_o).getSystemProperty((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    label27:;
    _r4_o = global::java.net.Proxy_2Type._fSOCKS;
    if (_r3_o != _r4_o) goto label58;
    _r0.i = _r7.i;
    label32:;
    _r4_o = ((global::java.net.ProxySelectorImpl) _r8_o).createProxy((global::java.net.Proxy_2Type) _r3_o, (global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o, (int) _r0.i);
    return (global::java.net.Proxy) _r4_o;
    label37:;
    // Value=socksProxyHost
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::java.net.ProxySelectorImpl) _r8_o).getSystemProperty((global::java.lang.String) _r4_o);
    if (_r1_o == null) goto label27;
    _r3_o = global::java.net.Proxy_2Type._fSOCKS;
    // Value=socksProxyPort
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r5_o = global::java.lang.String.valueOf((int) _r7.i);
    _r2_o = ((global::java.net.ProxySelectorImpl) _r8_o).getSystemProperty((global::java.lang.String) _r4_o, (global::java.lang.String) _r5_o);
    goto label27;
    label58:;
    _r0.i = _r6.i;
    goto label32;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectHttpsProxy()]
}

private global::System.Object selectFtpProxy(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectFtpProxy(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r8.i = 1080;
    _r7.i = 80;
    _r3_o = null;
    _r4_o = global::java.net.Proxy_2Type._fDIRECT;
    // Value=ftp.nonProxyHosts
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 115))}));
    _r2_o = ((global::java.net.ProxySelectorImpl) _r9_o).getSystemProperty((global::java.lang.String) _r5_o);
    _r5.i = ((global::java.net.ProxySelectorImpl) _r9_o).isNonProxyHost((global::java.lang.String) _r10_o, (global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r5.i == 0) goto label22;
    _r5_o = global::java.net.Proxy._fNO_1PROXY;
    label21:;
    return (global::java.net.Proxy) _r5_o;
    label22:;
    // Value=ftp.proxyHost
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::java.net.ProxySelectorImpl) _r9_o).getSystemProperty((global::java.lang.String) _r5_o);
    if (_r1_o == null) goto label52;
    _r4_o = global::java.net.Proxy_2Type._fHTTP;
    // Value=ftp.proxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r6_o = global::java.lang.String.valueOf((int) _r7.i);
    _r3_o = ((global::java.net.ProxySelectorImpl) _r9_o).getSystemProperty((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    label42:;
    _r5_o = global::java.net.Proxy_2Type._fSOCKS;
    if (_r4_o != _r5_o) goto label73;
    _r0.i = _r8.i;
    label47:;
    _r5_o = ((global::java.net.ProxySelectorImpl) _r9_o).createProxy((global::java.net.Proxy_2Type) _r4_o, (global::java.lang.String) _r1_o, (global::java.lang.String) _r3_o, (int) _r0.i);
    goto label21;
    label52:;
    // Value=socksProxyHost
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r1_o = ((global::java.net.ProxySelectorImpl) _r9_o).getSystemProperty((global::java.lang.String) _r5_o);
    if (_r1_o == null) goto label42;
    _r4_o = global::java.net.Proxy_2Type._fSOCKS;
    // Value=socksProxyPort
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r6_o = global::java.lang.String.valueOf((int) _r8.i);
    _r3_o = ((global::java.net.ProxySelectorImpl) _r9_o).getSystemProperty((global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o);
    goto label42;
    label73:;
    _r0.i = _r7.i;
    goto label47;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectFtpProxy(java.lang.String)]
}

private global::System.Object selectSocksProxy(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectSocksProxy()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r5.i = 1080;
    _r1_o = null;
    _r2_o = global::java.net.Proxy_2Type._fDIRECT;
    // Value=socksProxyHost
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    _r0_o = ((global::java.net.ProxySelectorImpl) _r6_o).getSystemProperty((global::java.lang.String) _r3_o);
    if (_r0_o == null) goto label25;
    _r2_o = global::java.net.Proxy_2Type._fSOCKS;
    // Value=socksProxyPort
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    _r4_o = global::java.lang.String.valueOf((int) _r5.i);
    _r1_o = ((global::java.net.ProxySelectorImpl) _r6_o).getSystemProperty((global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o);
    label25:;
    _r3_o = ((global::java.net.ProxySelectorImpl) _r6_o).createProxy((global::java.net.Proxy_2Type) _r2_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r1_o, (int) _r5.i);
    return (global::java.net.Proxy) _r3_o;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy selectSocksProxy()]
}

private bool isNonProxyHost(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: boolean isNonProxyHost(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    if (_r7_o == null) goto label4;
    if (_r8_o != null) goto label6;
    label4:;
    _r5.i = 0;
    label5:;
    return _r5.i!=0;
    label6:;
    _r3.i = ((global::java.lang.String) _r8_o).length();
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this((int) _r3.i);
    _r2.i = 0;
    label16:;
    _r5.i = ((global::java.lang.String) _r8_o).length();
    if (_r2.i >= _r5.i) goto label47;
    _r1.i = ((global::java.lang.String) _r8_o).charAt((int) _r2.i);
    switch (_r1.i) {
    case 42: goto label41;
    case 46: goto label35;
    }
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    label32:;
    _r2.i = _r2.i + 1;
    goto label16;
    label35:;
    // Value=\134.
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92)), unchecked((char) unchecked((uint) 46))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r5_o);
    goto label32;
    label41:;
    // Value=.*
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46)), unchecked((char) unchecked((uint) 42))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r5_o);
    goto label32;
    label47:;
    _r4_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    _r5.i = ((global::java.lang.String) _r7_o).matches((global::java.lang.String) _r4_o) ? 1 : 0;
    goto label5;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: boolean isNonProxyHost(java.lang.String, java.lang.String)]
}

private global::System.Object createProxy(global::java.net.Proxy_2Type n1, global::java.lang.String n2, global::java.lang.String n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy createProxy(java.net.Proxy$Type, java.lang.String, java.lang.String, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r8.i = n4;
    _r3_o = global::java.net.Proxy_2Type._fDIRECT;
    if (_r5_o != _r3_o) goto label7;
    _r2_o = global::java.net.Proxy._fNO_1PROXY;
    label6:;
    return (global::java.net.Proxy) _r2_o;
    label7:;
    try {
    _r3_o = global::java.lang.Integer.valueOf((global::java.lang.String) _r7_o);
    _r1.i = ((global::java.lang.Integer) _r3_o).intValue();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NumberFormatException) {
            _ex = ex;
            goto label25;
        }
        throw ex;
    } // end catch
    label15:;
    _r2_o = new global::java.net.Proxy();
    _r3_o = global::java.net.InetSocketAddress.createUnresolved((global::java.lang.String) _r6_o, (int) _r1.i);
    ((global::java.net.Proxy) _r2_o).@this((global::java.net.Proxy_2Type) _r5_o, (global::java.net.SocketAddress) _r3_o);
    goto label6;
    label25:;
    _r3_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r3_o;
    _r1.i = _r8.i;
    goto label15;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.net.Proxy createProxy(java.net.Proxy$Type, java.lang.String, java.lang.String, int)]
}

private global::System.Object getSystemProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.lang.String getSystemProperty(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = null;
    _r0_o = ((global::java.net.ProxySelectorImpl) _r1_o).getSystemProperty((global::java.lang.String) _r2_o, (global::java.lang.String) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.lang.String getSystemProperty(java.lang.String)]
}

private global::System.Object getSystemProperty(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.lang.String getSystemProperty(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    return (global::java.lang.String) _r2_o;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.lang.String getSystemProperty(java.lang.String, java.lang.String)]
}

private global::System.Object getSystemPropertyOrAlternative(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: java.lang.String getSystemPropertyOrAlternative(java.lang.String, java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = ((global::java.net.ProxySelectorImpl) _r1_o).getSystemProperty((global::java.lang.String) _r2_o);
    if (_r0_o != null) goto label13;
    _r0_o = ((global::java.net.ProxySelectorImpl) _r1_o).getSystemProperty((global::java.lang.String) _r3_o);
    if (_r0_o != null) goto label13;
    _r0_o = _r4_o;
    label13:;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: java.lang.String getSystemPropertyOrAlternative(java.lang.String, java.lang.String, java.lang.String)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl: void <clinit>()]
    global::System.Object _r0_o = null;
    _r0_o = null;
    global::java.net.ProxySelectorImpl._fnetProps = (global::java.util.Properties) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[java.net.ProxySelectorImpl]
//XMLVM_END_WRAPPER[java.net.ProxySelectorImpl]

} // end of class: ProxySelectorImpl

} // end of namespace: java.net
