// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.platform {
public class OSNetworkSystem: global::java.lang.Object,global::org.apache.harmony.luni.platform.INetworkSystem {

static OSNetworkSystem() {
    @static();
}

private static int _fERRORCODE_1SOCKET_1TIMEOUT = -209;

private static int _fERRORCODE_1SOCKET_1INTERRUPTED = -208;

private static int _fINETADDR_1REACHABLE = 0;

private static bool _fisNetworkInited;

private static global::org.apache.harmony.luni.platform.OSNetworkSystem _fsingleton;

public static bool _f_2assertionsDisabled;

public static int _fSOCKET_1CONNECT_1STEP_1START = org.apache.harmony.luni.platform._iINetworkSystem._fSOCKET_1CONNECT_1STEP_1START;

public static int _fSOCKET_1CONNECT_1STEP_1CHECK = org.apache.harmony.luni.platform._iINetworkSystem._fSOCKET_1CONNECT_1STEP_1CHECK;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1.i = 0;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::org.apache.harmony.luni.platform.OSNetworkSystem));
    _r0.i = ((global::java.lang.Class) _r0_o).desiredAssertionStatus() ? 1 : 0;
    if (_r0.i != 0) goto label22;
    _r0.i = 1;
    label10:;
    global::org.apache.harmony.luni.platform.OSNetworkSystem._f_2assertionsDisabled = 0!=_r0.i;
    global::org.apache.harmony.luni.platform.OSNetworkSystem._fisNetworkInited = 0!=_r1.i;
    _r0_o = new global::org.apache.harmony.luni.platform.OSNetworkSystem();
    ((global::org.apache.harmony.luni.platform.OSNetworkSystem) _r0_o).@this();
    global::org.apache.harmony.luni.platform.OSNetworkSystem._fsingleton = (global::org.apache.harmony.luni.platform.OSNetworkSystem) _r0_o;
    return;
    label22:;
    _r0.i = _r1.i;
    goto label10;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void <clinit>()]
}

public static global::System.Object getOSNetworkSystem(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: org.apache.harmony.luni.platform.OSNetworkSystem getOSNetworkSystem()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.apache.harmony.luni.platform.OSNetworkSystem._fsingleton;
    return (global::org.apache.harmony.luni.platform.OSNetworkSystem) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: org.apache.harmony.luni.platform.OSNetworkSystem getOSNetworkSystem()]
}

private void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void <init>()]
}

public virtual void accept(global::java.io.FileDescriptor n1, global::java.net.SocketImpl n2, global::java.io.FileDescriptor n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void accept(java.io.FileDescriptor, java.net.SocketImpl, java.io.FileDescriptor, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void accept(java.io.FileDescriptor, java.net.SocketImpl, java.io.FileDescriptor, int)]
}

public virtual void acceptStreamSocket(global::java.io.FileDescriptor n1, global::java.net.SocketImpl n2, global::java.io.FileDescriptor n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void acceptStreamSocket(java.io.FileDescriptor, java.net.SocketImpl, java.io.FileDescriptor, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void acceptStreamSocket(java.io.FileDescriptor, java.net.SocketImpl, java.io.FileDescriptor, int)]
}

public virtual int availableStream(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int availableStream(java.io.FileDescriptor)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int availableStream(java.io.FileDescriptor)]
}

public virtual void bind(global::java.io.FileDescriptor n1, global::java.net.InetAddress n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void bind(java.io.FileDescriptor, java.net.InetAddress, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void bind(java.io.FileDescriptor, java.net.InetAddress, int)]
}

public virtual int connect(global::java.io.FileDescriptor n1, int n2, global::java.net.InetAddress n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int connect(java.io.FileDescriptor, int, java.net.InetAddress, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int connect(java.io.FileDescriptor, int, java.net.InetAddress, int)]
}

public virtual void connectDatagram(global::java.io.FileDescriptor n1, int n2, int n3, global::java.net.InetAddress n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void connectDatagram(java.io.FileDescriptor, int, int, java.net.InetAddress)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void connectDatagram(java.io.FileDescriptor, int, int, java.net.InetAddress)]
}

public virtual void connectStreamWithTimeoutSocket(global::java.io.FileDescriptor n1, int n2, int n3, int n4, global::java.net.InetAddress n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void connectStreamWithTimeoutSocket(java.io.FileDescriptor, int, int, int, java.net.InetAddress)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void connectStreamWithTimeoutSocket(java.io.FileDescriptor, int, int, int, java.net.InetAddress)]
}

public virtual int connectWithTimeout(global::java.io.FileDescriptor n1, int n2, int n3, global::java.net.InetAddress n4, int n5, int n6, global::java.lang.Long n7){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int connectWithTimeout(java.io.FileDescriptor, int, int, java.net.InetAddress, int, int, java.lang.Long)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int connectWithTimeout(java.io.FileDescriptor, int, int, java.net.InetAddress, int, int, java.lang.Long)]
}

public virtual void createDatagramSocket(global::java.io.FileDescriptor n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void createDatagramSocket(java.io.FileDescriptor, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void createDatagramSocket(java.io.FileDescriptor, boolean)]
}

public virtual void createServerStreamSocket(global::java.io.FileDescriptor n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void createServerStreamSocket(java.io.FileDescriptor, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void createServerStreamSocket(java.io.FileDescriptor, boolean)]
}

public virtual void createStreamSocket(global::java.io.FileDescriptor n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void createStreamSocket(java.io.FileDescriptor, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void createStreamSocket(java.io.FileDescriptor, boolean)]
}

public virtual void disconnectDatagram(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void disconnectDatagram(java.io.FileDescriptor)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void disconnectDatagram(java.io.FileDescriptor)]
}

public virtual global::System.Object getHostByAddr(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.net.InetAddress getHostByAddr(byte[])]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.net.InetAddress getHostByAddr(byte[])]
}

public virtual global::System.Object getHostByName(global::java.lang.String n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.net.InetAddress getHostByName(java.lang.String, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.net.InetAddress getHostByName(java.lang.String, boolean)]
}

public virtual int getSocketFlags(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int getSocketFlags()]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int getSocketFlags()]
}

public virtual global::System.Object getSocketLocalAddress(global::java.io.FileDescriptor n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.net.InetAddress getSocketLocalAddress(java.io.FileDescriptor, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.net.InetAddress getSocketLocalAddress(java.io.FileDescriptor, boolean)]
}

public virtual int getSocketLocalPort(global::java.io.FileDescriptor n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int getSocketLocalPort(java.io.FileDescriptor, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int getSocketLocalPort(java.io.FileDescriptor, boolean)]
}

public virtual global::System.Object getSocketOption(global::java.io.FileDescriptor n1, int n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.lang.Object getSocketOption(java.io.FileDescriptor, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.lang.Object getSocketOption(java.io.FileDescriptor, int)]
}

public virtual global::System.Object inheritedChannel(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.nio.channels.Channel inheritedChannel()]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: java.nio.channels.Channel inheritedChannel()]
}

public virtual bool isReachableByICMP(global::java.net.InetAddress n1, global::java.net.InetAddress n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean isReachableByICMP(java.net.InetAddress, java.net.InetAddress, int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r0.i = ((global::org.apache.harmony.luni.platform.OSNetworkSystem) _r1_o).isReachableByICMPImpl((global::java.net.InetAddress) _r2_o, (global::java.net.InetAddress) _r3_o, (int) _r4.i, (int) _r5.i);
    if (_r0.i != 0) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean isReachableByICMP(java.net.InetAddress, java.net.InetAddress, int, int)]
}

private int isReachableByICMPImpl(global::java.net.InetAddress n1, global::java.net.InetAddress n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int isReachableByICMPImpl(java.net.InetAddress, java.net.InetAddress, int, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int isReachableByICMPImpl(java.net.InetAddress, java.net.InetAddress, int, int)]
}

public virtual void listenStreamSocket(global::java.io.FileDescriptor n1, int n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void listenStreamSocket(java.io.FileDescriptor, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void listenStreamSocket(java.io.FileDescriptor, int)]
}

public virtual void oneTimeInitialization(bool n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void oneTimeInitialization(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0.i = global::org.apache.harmony.luni.platform.OSNetworkSystem._fisNetworkInited ? 1 : 0;
    if (_r0.i != 0) goto label10;
    ((global::org.apache.harmony.luni.platform.OSNetworkSystem) _r1_o).oneTimeInitializationImpl(0!=_r2.i);
    _r0.i = 1;
    global::org.apache.harmony.luni.platform.OSNetworkSystem._fisNetworkInited = 0!=_r0.i;
    label10:;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void oneTimeInitialization(boolean)]
}

private void oneTimeInitializationImpl(bool n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void oneTimeInitializationImpl(boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void oneTimeInitializationImpl(boolean)]
}

public virtual int peekDatagram(global::java.io.FileDescriptor n1, global::java.net.InetAddress n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int peekDatagram(java.io.FileDescriptor, java.net.InetAddress, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int peekDatagram(java.io.FileDescriptor, java.net.InetAddress, int)]
}

public virtual int read(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int read(java.io.FileDescriptor, byte[], int, int, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int read(java.io.FileDescriptor, byte[], int, int, int)]
}

public virtual int readDirect(global::java.io.FileDescriptor n1, long n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int readDirect(java.io.FileDescriptor, long, int, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int readDirect(java.io.FileDescriptor, long, int, int)]
}

public virtual int receiveDatagram(global::java.io.FileDescriptor n1, global::java.net.DatagramPacket n2, global::org.xmlvm._nArrayAdapter<sbyte> n3, int n4, int n5, int n6, bool n7){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int receiveDatagram(java.io.FileDescriptor, java.net.DatagramPacket, byte[], int, int, int, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int receiveDatagram(java.io.FileDescriptor, java.net.DatagramPacket, byte[], int, int, int, boolean)]
}

public virtual int receiveDatagramDirect(global::java.io.FileDescriptor n1, global::java.net.DatagramPacket n2, long n3, int n4, int n5, int n6, bool n7){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int receiveDatagramDirect(java.io.FileDescriptor, java.net.DatagramPacket, long, int, int, int, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int receiveDatagramDirect(java.io.FileDescriptor, java.net.DatagramPacket, long, int, int, int, boolean)]
}

public virtual int receiveStream(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int receiveStream(java.io.FileDescriptor, byte[], int, int, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int receiveStream(java.io.FileDescriptor, byte[], int, int, int)]
}

public virtual int recvConnectedDatagram(global::java.io.FileDescriptor n1, global::java.net.DatagramPacket n2, global::org.xmlvm._nArrayAdapter<sbyte> n3, int n4, int n5, int n6, bool n7){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int recvConnectedDatagram(java.io.FileDescriptor, java.net.DatagramPacket, byte[], int, int, int, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int recvConnectedDatagram(java.io.FileDescriptor, java.net.DatagramPacket, byte[], int, int, int, boolean)]
}

public virtual int recvConnectedDatagramDirect(global::java.io.FileDescriptor n1, global::java.net.DatagramPacket n2, long n3, int n4, int n5, int n6, bool n7){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int recvConnectedDatagramDirect(java.io.FileDescriptor, java.net.DatagramPacket, long, int, int, int, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int recvConnectedDatagramDirect(java.io.FileDescriptor, java.net.DatagramPacket, long, int, int, int, boolean)]
}

public virtual bool select(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, int n3, int n4, long n5, global::org.xmlvm._nArrayAdapter<int> n6){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean select(java.io.FileDescriptor[], java.io.FileDescriptor[], int, int, long, int[])]
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
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9_o = n1;
    _r10_o = n2;
    _r11.i = n3;
    _r12.i = n4;
    _r13.l = n5;
    _r15_o = n6;
    if (_r11.i < 0) goto label4;
    if (_r12.i >= 0) goto label10;
    label4:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label10:;
    _r0.i = _r11.i + _r12.i;
    if (_r0.i != 0) goto label16;
    _r0.i = 1;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0.i = global::org.apache.harmony.luni.platform.OSNetworkSystem._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label34;
    _r0.i = ((global::org.apache.harmony.luni.platform.OSNetworkSystem) _r8_o).validateFDs((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r9_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r10_o, (int) _r11.i, (int) _r12.i) ? 1 : 0;
    if (_r0.i != 0) goto label34;
    _r0_o = new global::java.lang.AssertionError();
    // Value=Invalid file descriptor arrays
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)73)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 115))}));
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label34:;
    _r0_o = _r8_o;
    _r1_o = _r9_o;
    _r2_o = _r10_o;
    _r3.i = _r11.i;
    _r4.i = _r12.i;
    _r5_o = _r15_o;
    _r6.l = _r13.l;
    _r0.i = ((global::org.apache.harmony.luni.platform.OSNetworkSystem) _r0_o).selectImpl((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (int) _r3.i, (int) _r4.i, (global::org.xmlvm._nArrayAdapter<int>) _r5_o, (long) _r6.l);
    if (_r0.i < 0) goto label49;
    _r0.i = 1;
    goto label15;
    label49:;
    _r1.i = -209;
    if (_r0.i == _r1.i) goto label57;
    _r1.i = -208;
    if (_r0.i != _r1.i) goto label59;
    label57:;
    _r0.i = 0;
    goto label15;
    label59:;
    _r0_o = new global::java.net.SocketException();
    ((global::java.net.SocketException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.net.SocketException) _r0_o);
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean select(java.io.FileDescriptor[], java.io.FileDescriptor[], int, int, long, int[])]
}

private int selectImpl(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, int n3, int n4, global::org.xmlvm._nArrayAdapter<int> n5, long n6){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int selectImpl(java.io.FileDescriptor[], java.io.FileDescriptor[], int, int, int[], long)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int selectImpl(java.io.FileDescriptor[], java.io.FileDescriptor[], int, int, int[], long)]
}

public virtual int sendConnectedDatagram(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4, bool n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendConnectedDatagram(java.io.FileDescriptor, byte[], int, int, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendConnectedDatagram(java.io.FileDescriptor, byte[], int, int, boolean)]
}

public virtual int sendConnectedDatagramDirect(global::java.io.FileDescriptor n1, long n2, int n3, int n4, bool n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendConnectedDatagramDirect(java.io.FileDescriptor, long, int, int, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendConnectedDatagramDirect(java.io.FileDescriptor, long, int, int, boolean)]
}

public virtual int sendDatagram(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4, int n5, bool n6, int n7, global::java.net.InetAddress n8){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendDatagram(java.io.FileDescriptor, byte[], int, int, int, boolean, int, java.net.InetAddress)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendDatagram(java.io.FileDescriptor, byte[], int, int, int, boolean, int, java.net.InetAddress)]
}

public virtual int sendDatagram2(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4, int n5, global::java.net.InetAddress n6){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendDatagram2(java.io.FileDescriptor, byte[], int, int, int, java.net.InetAddress)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendDatagram2(java.io.FileDescriptor, byte[], int, int, int, java.net.InetAddress)]
}

public virtual int sendDatagramDirect(global::java.io.FileDescriptor n1, long n2, int n3, int n4, int n5, bool n6, int n7, global::java.net.InetAddress n8){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendDatagramDirect(java.io.FileDescriptor, long, int, int, int, boolean, int, java.net.InetAddress)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int sendDatagramDirect(java.io.FileDescriptor, long, int, int, int, boolean, int, java.net.InetAddress)]
}

public virtual void sendUrgentData(global::java.io.FileDescriptor n1, sbyte n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void sendUrgentData(java.io.FileDescriptor, byte)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void sendUrgentData(java.io.FileDescriptor, byte)]
}

public virtual void setInetAddress(global::java.net.InetAddress n1, global::org.xmlvm._nArrayAdapter<sbyte> n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void setInetAddress(java.net.InetAddress, byte[])]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void setInetAddress(java.net.InetAddress, byte[])]
}

public virtual void setNonBlocking(global::java.io.FileDescriptor n1, bool n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void setNonBlocking(java.io.FileDescriptor, boolean)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void setNonBlocking(java.io.FileDescriptor, boolean)]
}

public virtual void setSocketOption(global::java.io.FileDescriptor n1, int n2, global::java.lang.Object n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void setSocketOption(java.io.FileDescriptor, int, java.lang.Object)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void setSocketOption(java.io.FileDescriptor, int, java.lang.Object)]
}

public virtual void shutdownInput(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void shutdownInput(java.io.FileDescriptor)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void shutdownInput(java.io.FileDescriptor)]
}

public virtual void shutdownOutput(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void shutdownOutput(java.io.FileDescriptor)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void shutdownOutput(java.io.FileDescriptor)]
}

public virtual void socketClose(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void socketClose(java.io.FileDescriptor)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: void socketClose(java.io.FileDescriptor)]
}

public virtual bool supportsUrgentData(global::java.io.FileDescriptor n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean supportsUrgentData(java.io.FileDescriptor)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean supportsUrgentData(java.io.FileDescriptor)]
}

private bool validateFDs(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean validateFDs(java.io.FileDescriptor[], java.io.FileDescriptor[])]
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
    _r3.i = 0;
    _r0.i = ((global::org.xmlvm._nIArray) _r5_o).Length;
    _r1.i = _r3.i;
    label3:;
    if (_r1.i < _r0.i) goto label11;
    _r0.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r1.i = _r3.i;
    label7:;
    if (_r1.i < _r0.i) goto label24;
    _r0.i = 1;
    label10:;
    return _r0.i!=0;
    label11:;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o)[_r1.i];
    _r2.i = ((global::java.io.FileDescriptor) _r2_o).valid() ? 1 : 0;
    if (_r2.i != 0) goto label21;
    _r0.i = _r3.i;
    goto label10;
    label21:;
    _r1.i = _r1.i + 1;
    goto label3;
    label24:;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o)[_r1.i];
    _r2.i = ((global::java.io.FileDescriptor) _r2_o).valid() ? 1 : 0;
    if (_r2.i != 0) goto label34;
    _r0.i = _r3.i;
    goto label10;
    label34:;
    _r1.i = _r1.i + 1;
    goto label7;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean validateFDs(java.io.FileDescriptor[], java.io.FileDescriptor[])]
}

private bool validateFDs(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean validateFDs(java.io.FileDescriptor[], java.io.FileDescriptor[], int, int)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3;
    _r7.i = n4;
    _r2.i = 0;
    _r0.i = _r2.i;
    label2:;
    if (_r0.i < _r6.i) goto label9;
    _r0.i = _r2.i;
    label5:;
    if (_r0.i < _r7.i) goto label22;
    _r0.i = 1;
    label8:;
    return _r0.i!=0;
    label9:;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    _r1.i = ((global::java.io.FileDescriptor) _r1_o).valid() ? 1 : 0;
    if (_r1.i != 0) goto label19;
    _r0.i = _r2.i;
    goto label8;
    label19:;
    _r0.i = _r0.i + 1;
    goto label2;
    label22:;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o)[_r0.i];
    _r1.i = ((global::java.io.FileDescriptor) _r1_o).valid() ? 1 : 0;
    if (_r1.i != 0) goto label32;
    _r0.i = _r2.i;
    goto label8;
    label32:;
    _r0.i = _r0.i + 1;
    goto label5;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: boolean validateFDs(java.io.FileDescriptor[], java.io.FileDescriptor[], int, int)]
}

public virtual int write(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<sbyte> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int write(java.io.FileDescriptor, byte[], int, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int write(java.io.FileDescriptor, byte[], int, int)]
}

public virtual int writeDirect(global::java.io.FileDescriptor n1, long n2, int n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int writeDirect(java.io.FileDescriptor, long, int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: int writeDirect(java.io.FileDescriptor, long, int)]
}

public virtual long writev(global::java.io.FileDescriptor n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, global::org.xmlvm._nArrayAdapter<int> n3, global::org.xmlvm._nArrayAdapter<int> n4, int n5){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: long writev(java.io.FileDescriptor, java.lang.Object[], int[], int[], int)]
      throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem: long writev(java.io.FileDescriptor, java.lang.Object[], int[], int[], int)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.platform.OSNetworkSystem]

} // end of class: OSNetworkSystem

} // end of namespace: org.apache.harmony.luni.platform
