// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public class Inet4Address: global::java.net.InetAddress {
private static long _fserialVersionUID = 3286316764910316507L;

public void @this(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: void <init>(byte[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.net.InetAddress) _r0_o).@this();
    ((global::java.net.Inet4Address) _r0_o)._fipaddress = (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.net.Inet4Address: void <init>(byte[])]
}

public void @this(global::org.xmlvm._nArrayAdapter<sbyte> n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: void <init>(byte[], java.lang.String)]
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
    ((global::java.net.InetAddress) _r0_o).@this();
    ((global::java.net.Inet4Address) _r0_o)._fipaddress = (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o;
    ((global::java.net.Inet4Address) _r0_o)._fhostName = (global::java.lang.String) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.net.Inet4Address: void <init>(byte[], java.lang.String)]
}

public override bool isMulticastAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isMulticastAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r2.i = 0;
    _r0_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i];
    _r0.i = _r0.i & 240;
    _r1.i = 224;
    if (_r0.i != _r1.i) goto label13;
    _r0.i = 1;
    label12:;
    return _r0.i!=0;
    label13:;
    _r0.i = _r2.i;
    goto label12;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isMulticastAddress()]
}

public override bool isAnyLocalAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isAnyLocalAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = 0;
    label1:;
    _r1_o = ((global::java.net.Inet4Address) _r2_o)._fipaddress;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r0.i >= _r1.i) goto label17;
    _r1_o = ((global::java.net.Inet4Address) _r2_o)._fipaddress;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r0.i];
    if (_r1.i == 0) goto label14;
    _r1.i = 0;
    label13:;
    return _r1.i!=0;
    label14:;
    _r0.i = _r0.i + 1;
    goto label1;
    label17:;
    _r1.i = 1;
    goto label13;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isAnyLocalAddress()]
}

public override bool isLoopbackAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isLoopbackAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r2.i = 0;
    _r0_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i];
    _r0.i = _r0.i & 255;
    _r1.i = 127;
    if (_r0.i != _r1.i) goto label13;
    _r0.i = 1;
    label12:;
    return _r0.i!=0;
    label13:;
    _r0.i = _r2.i;
    goto label12;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isLoopbackAddress()]
}

public override bool isLinkLocalAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isLinkLocalAddress()]
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
    _r3.i = 1;
    _r2.i = 0;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i];
    _r0.i = _r0.i & 255;
    _r1.i = 169;
    if (_r0.i != _r1.i) goto label24;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r3.i];
    _r0.i = _r0.i & 255;
    _r1.i = 254;
    if (_r0.i != _r1.i) goto label24;
    _r0.i = _r3.i;
    label23:;
    return _r0.i!=0;
    label24:;
    _r0.i = _r2.i;
    goto label23;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isLinkLocalAddress()]
}

public override bool isSiteLocalAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isSiteLocalAddress()]
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
    _r3.i = 1;
    _r2.i = 0;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i];
    _r0.i = _r0.i & 255;
    _r1.i = 10;
    if (_r0.i == _r1.i) goto label62;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i];
    _r0.i = _r0.i & 255;
    _r1.i = 172;
    if (_r0.i != _r1.i) goto label42;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r3.i];
    _r0.i = _r0.i & 255;
    _r1.i = 15;
    if (_r0.i <= _r1.i) goto label42;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r3.i];
    _r0.i = _r0.i & 255;
    _r1.i = 32;
    if (_r0.i < _r1.i) goto label62;
    label42:;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r2.i];
    _r0.i = _r0.i & 255;
    _r1.i = 192;
    if (_r0.i != _r1.i) goto label64;
    _r0_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r3.i];
    _r0.i = _r0.i & 255;
    _r1.i = 168;
    if (_r0.i != _r1.i) goto label64;
    label62:;
    _r0.i = _r3.i;
    label63:;
    return _r0.i!=0;
    label64:;
    _r0.i = _r2.i;
    goto label63;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isSiteLocalAddress()]
}

public override bool isMCGlobal(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isMCGlobal()]
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
    _r1.i = ((global::java.net.Inet4Address) _r4_o).isMulticastAddress() ? 1 : 0;
    if (_r1.i != 0) goto label9;
    _r1.i = _r3.i;
    label8:;
    return _r1.i!=0;
    label9:;
    _r1_o = ((global::java.net.Inet4Address) _r4_o)._fipaddress;
    _r0.i = global::java.net.InetAddress.bytesToInt((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o, (int) _r3.i);
    _r1.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 8)));
    _r2.i = 14680065;
    if (_r1.i >= _r2.i) goto label24;
    _r1.i = _r3.i;
    goto label8;
    label24:;
    _r1.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 24)));
    _r2.i = 238;
    if (_r1.i <= _r2.i) goto label32;
    _r1.i = _r3.i;
    goto label8;
    label32:;
    _r1.i = 1;
    goto label8;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isMCGlobal()]
}

public override bool isMCNodeLocal(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isMCNodeLocal()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isMCNodeLocal()]
}

public override bool isMCLinkLocal(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isMCLinkLocal()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r2.i = 0;
    _r0_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r0.i = global::java.net.InetAddress.bytesToInt((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r2.i);
    _r0.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 8)));
    _r1.i = 14680064;
    if (_r0.i != _r1.i) goto label15;
    _r0.i = 1;
    label14:;
    return _r0.i!=0;
    label15:;
    _r0.i = _r2.i;
    goto label14;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isMCLinkLocal()]
}

public override bool isMCSiteLocal(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isMCSiteLocal()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r2.i = 0;
    _r0_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r0.i = global::java.net.InetAddress.bytesToInt((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r2.i);
    _r0.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 16)));
    _r1.i = 61439;
    if (_r0.i != _r1.i) goto label16;
    _r0.i = 1;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0.i = _r2.i;
    goto label15;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isMCSiteLocal()]
}

public override bool isMCOrgLocal(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean isMCOrgLocal()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r2.i = 0;
    _r1_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r1.i = global::java.net.InetAddress.bytesToInt((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o, (int) _r2.i);
    _r0.i = (int) (((uint) _r1.i) >> (0x1f & ((int) 16)));
    _r1.i = 61376;
    if (_r0.i < _r1.i) goto label21;
    _r1.i = 61379;
    if (_r0.i > _r1.i) goto label21;
    _r1.i = 1;
    label20:;
    return _r1.i!=0;
    label21:;
    _r1.i = _r2.i;
    goto label20;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean isMCOrgLocal()]
}

public override global::System.Object getHostAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: java.lang.String getHostAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1.i = 0;
    label6:;
    _r2.i = 4;
    if (_r1.i >= _r2.i) goto label29;
    _r2_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r1.i];
    _r2.i = _r2.i & 255;
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r2.i);
    _r2.i = 3;
    if (_r1.i == _r2.i) goto label26;
    _r2.i = 46;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r2.i);
    label26:;
    _r1.i = _r1.i + 1;
    goto label6;
    label29:;
    _r2_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r2_o;
//XMLVM_END_WRAPPER[java.net.Inet4Address: java.lang.String getHostAddress()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.net.Inet4Address) _r2_o)._fipaddress;
    _r1.i = 0;
    _r0.i = global::java.net.InetAddress.bytesToInt((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r1.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.net.Inet4Address: int hashCode()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = base.equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.net.Inet4Address: boolean equals(java.lang.Object)]
}

private global::System.Object writeReplace(){
//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address: java.lang.Object writeReplace()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = new global::java.net.InetAddress();
    _r1_o = ((global::java.net.Inet4Address) _r3_o)._fipaddress;
    _r2_o = ((global::java.net.Inet4Address) _r3_o)._fhostName;
    ((global::java.net.InetAddress) _r0_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o, (global::java.lang.String) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.net.Inet4Address: java.lang.Object writeReplace()]
}

//XMLVM_BEGIN_WRAPPER[java.net.Inet4Address]
//XMLVM_END_WRAPPER[java.net.Inet4Address]

} // end of class: Inet4Address

} // end of namespace: java.net
