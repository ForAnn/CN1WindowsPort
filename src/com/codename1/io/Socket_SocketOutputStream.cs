// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io {
public class Socket_2SocketOutputStream: global::java.io.OutputStream {
private global::java.lang.Object _fimpl;

private global::com.codename1.io.SocketConnection _fcon;

public void @this(global::java.lang.Object n1, global::com.codename1.io.SocketConnection n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void <init>(java.lang.Object, com.codename1.io.SocketConnection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.io.OutputStream) _r0_o).@this();
    ((global::com.codename1.io.Socket_2SocketOutputStream) _r0_o)._fimpl = (global::java.lang.Object) _r1_o;
    ((global::com.codename1.io.Socket_2SocketOutputStream) _r0_o)._fcon = (global::com.codename1.io.SocketConnection) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void <init>(java.lang.Object, com.codename1.io.SocketConnection)]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void close()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r1_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r2_o)._fimpl;
    _r0.i = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).isSocketConnected((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label27;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r1_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r2_o)._fimpl;
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).disconnectSocket((global::java.lang.Object) _r1_o);
    _r0_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r2_o)._fcon;
    _r1.i = 0;
    ((global::com.codename1.io.SocketConnection) _r0_o).setConnected(0!=_r1.i);
    label27:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void close()]
}

public override void flush(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void flush()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void flush()]
}

public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void write(byte[], int, int)]
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
    if (_r5.i != 0) goto label15;
    _r1.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    if (_r6.i != _r1.i) goto label15;
    _r1_o = global::com.codename1.io.Util.getImplementation();
    _r2_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r3_o)._fimpl;
    ((global::com.codename1.impl.CodenameOneImplementation) _r1_o).writeToSocketStream((global::java.lang.Object) _r2_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o);
    label14:;
    return;
    label15:;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r6.i]);
    _r1.i = 0;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r4_o, (int) _r5.i, (global::java.lang.Object) _r0_o, (int) _r1.i, (int) _r6.i);
    _r1_o = global::com.codename1.io.Util.getImplementation();
    _r2_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r3_o)._fimpl;
    ((global::com.codename1.impl.CodenameOneImplementation) _r1_o).writeToSocketStream((global::java.lang.Object) _r2_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o);
    goto label14;
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void write(byte[], int, int)]
}

public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void write(byte[])]
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
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r1_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r2_o)._fimpl;
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).writeToSocketStream((global::java.lang.Object) _r1_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void write(byte[])]
}

public override void write(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void write(int)]
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
    _r5_o = this;
    _r6.i = n1;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r1_o = ((global::com.codename1.io.Socket_2SocketOutputStream) _r5_o)._fimpl;
    _r2.i = 1;
    _r2_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r2.i]);
    _r3.i = 0;
    _r4.i = (_r6.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r3.i] = (sbyte)_r4.i;
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).writeToSocketStream((global::java.lang.Object) _r1_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream: void write(int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.Socket$SocketOutputStream]
//XMLVM_END_WRAPPER[com.codename1.io.Socket$SocketOutputStream]

} // end of class: Socket_2SocketOutputStream

} // end of namespace: com.codename1.io
