// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.net {
public class SocketOutputStream: global::java.io.OutputStream {
private global::org.apache.harmony.luni.net.PlainSocketImpl _fsocket;

public void @this(global::java.net.SocketImpl n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void <init>(java.net.SocketImpl)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.io.OutputStream) _r0_o).@this();
    ((global::org.apache.harmony.luni.net.SocketOutputStream) _r0_o)._fsocket = (global::org.apache.harmony.luni.net.PlainSocketImpl) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void <init>(java.net.SocketImpl)]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void close()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.net.SocketOutputStream) _r1_o)._fsocket;
    ((global::org.apache.harmony.luni.net.PlainSocketImpl) _r0_o).close();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void close()]
}

public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void write(byte[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::org.apache.harmony.luni.net.SocketOutputStream) _r3_o)._fsocket;
    _r1.i = 0;
    _r2.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    ((global::org.apache.harmony.luni.net.PlainSocketImpl) _r0_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o, (int) _r1.i, (int) _r2.i);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void write(byte[])]
}

public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void write(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r5.i = n3;
    if (_r3_o == null) goto label31;
    if (_r4.i < 0) goto label19;
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r4.i > _r0.i) goto label19;
    if (_r5.i < 0) goto label19;
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = _r0.i - _r4.i;
    if (_r5.i > _r0.i) goto label19;
    _r0_o = ((global::org.apache.harmony.luni.net.SocketOutputStream) _r2_o)._fsocket;
    ((global::org.apache.harmony.luni.net.PlainSocketImpl) _r0_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r4.i, (int) _r5.i);
    return;
    label19:;
    _r0_o = new global::java.lang.ArrayIndexOutOfBoundsException();
    // Value=luni.13
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 51))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.ArrayIndexOutOfBoundsException) _r0_o);
    label31:;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=luni.11
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 49))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
//XMLVM_END_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void write(byte[], int, int)]
}

public override void write(int n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void write(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r3.i = 1;
    _r2.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r3.i]);
    _r1.i = _r5.i & 255;
    _r1.i = (_r1.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i] = (sbyte)_r1.i;
    _r1_o = ((global::org.apache.harmony.luni.net.SocketOutputStream) _r4_o)._fsocket;
    ((global::org.apache.harmony.luni.net.PlainSocketImpl) _r1_o).write((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r2.i, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream: void write(int)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.net.SocketOutputStream]

} // end of class: SocketOutputStream

} // end of namespace: org.apache.harmony.luni.net
