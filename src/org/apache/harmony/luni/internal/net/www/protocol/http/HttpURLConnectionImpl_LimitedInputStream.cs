// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.@internal.net.www.protocol.http {
public class HttpURLConnectionImpl_2LimitedInputStream: global::java.io.InputStream {
public int _fbytesRemaining;

public global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl _fthis_20;

public void @this(global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl n1, int n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: void <init>(org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r0_o)._fthis_20 = (global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o;
    ((global::java.io.InputStream) _r0_o).@this();
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r0_o)._fbytesRemaining = _r2.i;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: void <init>(org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl, int)]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: void close()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1.i = 0;
    _r0.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fbytesRemaining;
    if (_r0.i <= 0) goto label39;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fbytesRemaining = _r1.i;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fthis_20;
    _r1.i = 1;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o, 0!=_r1.i);
    label13:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fthis_20;
    _r0.i = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2100((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label38;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fthis_20;
    _r0_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2200((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o);
    if (_r0_o == null) goto label38;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fthis_20;
    _r0_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2200((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o);
    ((global::java.net.CacheRequest) _r0_o).abort();
    label38:;
    return;
    label39:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r0_o, 0!=_r1.i);
    goto label13;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: void close()]
}

public override int available(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: int available()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2300((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    _r0.i = ((global::java.io.InputStream) _r1_o).available();
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fbytesRemaining;
    if (_r0.i <= _r1.i) goto label17;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r2_o)._fbytesRemaining;
    label16:;
    return _r1.i;
    label17:;
    _r1.i = _r0.i;
    goto label16;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: int available()]
}

public override int read(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: int read()]
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
    _r4_o = this;
    _r3.i = 0;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fbytesRemaining;
    if (_r1.i > 0) goto label12;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o, 0!=_r3.i);
    _r1.i = -1;
    label11:;
    return _r1.i;
    label12:;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2300((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    _r0.i = ((global::java.io.InputStream) _r1_o).read();
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fthis_20;
    _r1.i = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2400((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label47;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2500((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    if (_r1_o == null) goto label47;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2500((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    ((global::java.io.OutputStream) _r1_o).write((int) _r0.i);
    label47:;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fbytesRemaining;
    _r2.i = 1;
    _r1.i = _r1.i - _r2.i;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fbytesRemaining = _r1.i;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fbytesRemaining;
    if (_r1.i > 0) goto label62;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r4_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o, 0!=_r3.i);
    label62:;
    _r1.i = _r0.i;
    goto label11;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: int read()]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: int read(byte[], int, int)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r2.i = 0;
    if (_r5.i < 0) goto label6;
    _r1.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    if (_r5.i <= _r1.i) goto label18;
    label6:;
    _r1_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.12
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 50))}));
    _r2_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (int) _r5.i);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r1_o);
    label18:;
    if (_r6.i < 0) goto label24;
    _r1.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r1.i = _r1.i - _r5.i;
    if (_r1.i >= _r6.i) goto label36;
    label24:;
    _r1_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.18
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 56))}));
    _r2_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (int) _r6.i);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r1_o);
    label36:;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fbytesRemaining;
    if (_r1.i > 0) goto label47;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o, 0!=_r2.i);
    _r1.i = -1;
    label46:;
    return _r1.i;
    label47:;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fbytesRemaining;
    if (_r6.i <= _r1.i) goto label53;
    _r6.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fbytesRemaining;
    label53:;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2300((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    _r0.i = ((global::java.io.InputStream) _r1_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o, (int) _r5.i, (int) _r6.i);
    if (_r0.i <= 0) goto label95;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fbytesRemaining;
    _r1.i = _r1.i - _r0.i;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fbytesRemaining = _r1.i;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fthis_20;
    _r1.i = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2600((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label95;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2500((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    if (_r1_o == null) goto label95;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fthis_20;
    _r1_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2500((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o);
    ((global::java.io.OutputStream) _r1_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o, (int) _r5.i, (int) _r0.i);
    label95:;
    _r1.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fbytesRemaining;
    if (_r1.i > 0) goto label104;
    _r1_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r3_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r1_o, 0!=_r2.i);
    label104:;
    _r1.i = _r0.i;
    goto label46;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: int read(byte[], int, int)]
}

public virtual long skip(int n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: long skip(int)]
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
    _r6_o = this;
    _r7.i = n1;
    _r5.i = 0;
    _r2.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fbytesRemaining;
    if (_r2.i > 0) goto label13;
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r2_o, 0!=_r5.i);
    _r2.l = -1L;
    label12:;
    return _r2.l;
    label13:;
    _r2.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fbytesRemaining;
    if (_r7.i <= _r2.i) goto label19;
    _r7.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fbytesRemaining;
    label19:;
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fthis_20;
    _r2_o = global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2300((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r2_o);
    _r3.l = (long) _r7.i;
    _r0.l = ((global::java.io.InputStream) _r2_o).skip((long) _r3.l);
    _r2.l = 0L;
    _r2.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r2.i <= 0) goto label43;
    _r2.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fbytesRemaining;
    _r2.l = (long) _r2.i;
    _r2.l = _r2.l - _r0.l;
    _r2.i = (int) _r2.l;
    ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fbytesRemaining = _r2.i;
    label43:;
    _r2.i = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fbytesRemaining;
    if (_r2.i > 0) goto label52;
    _r2_o = ((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl_2LimitedInputStream) _r6_o)._fthis_20;
    global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl.access_2000((global::org.apache.harmony.luni.@internal.net.www.protocol.http.HttpURLConnectionImpl) _r2_o, 0!=_r5.i);
    label52:;
    _r2.l = _r0.l;
    goto label12;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream: long skip(int)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.net.www.protocol.http.HttpURLConnectionImpl$LimitedInputStream]

} // end of class: HttpURLConnectionImpl_2LimitedInputStream

} // end of namespace: org.apache.harmony.luni.@internal.net.www.protocol.http
