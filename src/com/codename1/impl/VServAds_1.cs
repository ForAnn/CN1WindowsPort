// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.impl {
public class VServAds_21: global::com.codename1.io.ConnectionRequest {
public global::com.codename1.impl.VServAds _fthis_20;

public void @this(global::com.codename1.impl.VServAds n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.VServAds$1: void <init>(com.codename1.impl.VServAds)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.impl.VServAds_21) _r0_o)._fthis_20 = (global::com.codename1.impl.VServAds) _r1_o;
    ((global::com.codename1.io.ConnectionRequest) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.VServAds$1: void <init>(com.codename1.impl.VServAds)]
}

public override void handleErrorResponseCode(int n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.VServAds$1: void handleErrorResponseCode(int, java.lang.String)]
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
    _r3.i = n1;
    _r4_o = n2;
    _r0_o = ((global::com.codename1.impl.VServAds_21) _r2_o)._fthis_20;
    _r1.i = 1;
    ((global::com.codename1.impl.VServAds) _r0_o)._ffailed = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.VServAds$1: void handleErrorResponseCode(int, java.lang.String)]
}

public override void handleException(global::java.lang.Exception n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.VServAds$1: void handleException(java.lang.Exception)]
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
    _r0_o = ((global::com.codename1.impl.VServAds_21) _r2_o)._fthis_20;
    _r1.i = 1;
    ((global::com.codename1.impl.VServAds) _r0_o)._ffailed = 0!=_r1.i;
    global::com.codename1.io.Log.e((global::java.lang.Throwable) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.VServAds$1: void handleException(java.lang.Exception)]
}

private global::System.Object getString(global::java.util.Hashtable n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.VServAds$1: java.lang.String getString(java.util.Hashtable, java.lang.String)]
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
    _r0_o = ((global::java.util.Hashtable) _r3_o).get((global::java.lang.Object) _r4_o);
    if (_r0_o != null) goto label8;
    _r1_o = null;
    label7:;
    return (global::java.lang.String) _r1_o;
    label8:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::java.util.Vector)) ? 1 : 0;
    if (_r1.i == 0) goto label23;
    _r0_o = _r0_o;
    _r1.i = 0;
    _r2_o = ((global::java.util.Vector) _r0_o).elementAt((int) _r1.i);
    _r2_o = _r2_o;
    _r1_o = _r2_o;
    goto label7;
    label23:;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.impl.VServAds$1: java.lang.String getString(java.util.Hashtable, java.lang.String)]
}

public override void readResponse(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.VServAds$1: void readResponse(java.io.InputStream)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = this;
    _r12_o = n1;
    _r7.i = 0;
    // Value=notify-once
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101))}));
    // Value=notify
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121))}));
    // Value=data
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97))}));
    _r2_o = new global::com.codename1.io.JSONParser();
    ((global::com.codename1.io.JSONParser) _r2_o).@this();
    _r4_o = new global::java.io.InputStreamReader();
    // Value=UTF-8
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::java.io.InputStreamReader) _r4_o).@this((global::java.io.InputStream) _r12_o, (global::java.lang.String) _r5_o);
    _r1_o = ((global::com.codename1.io.JSONParser) _r2_o).parse((global::java.io.Reader) _r4_o);
    _r4.i = ((global::java.util.Hashtable) _r1_o).size();
    if (_r4.i != 0) goto label30;
    label29:;
    return;
    label30:;
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=style
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    _r4_o = ((global::java.util.Hashtable) _r1_o).get((global::java.lang.Object) _r4_o);
    _r4_o = _r4_o;
    _r4_o = ((global::java.util.Vector) _r4_o).elementAt((int) _r7.i);
    _r4_o = _r4_o;
    // Value=background-color
    _r6_o = new global::java.lang.String();
    ((global::java.lang.String)_r6_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)98)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114))}));
    _r4_o = ((global::java.util.Hashtable) _r4_o).get((global::java.lang.Object) _r6_o);
    _r4_o = _r4_o;
    _r6.i = 16;
    _r4.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o, (int) _r6.i);
    global::com.codename1.impl.VServAds.access_2002((global::com.codename1.impl.VServAds) _r5_o, (int) _r4.i);
    // Value=action
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110))}));
    _r4_o = ((global::java.util.Hashtable) _r1_o).get((global::java.lang.Object) _r4_o);
    _r4_o = _r4_o;
    _r0_o = ((global::java.util.Vector) _r4_o).elementAt((int) _r7.i);
    _r0_o = _r0_o;
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=notify
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121))}));
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o).getString((global::java.util.Hashtable) _r0_o, (global::java.lang.String) _r9_o);
    global::com.codename1.impl.VServAds.access_2102((global::com.codename1.impl.VServAds) _r4_o, (global::java.lang.String) _r5_o);
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    _r4_o = global::com.codename1.impl.VServAds.access_2100((global::com.codename1.impl.VServAds) _r4_o);
    if (_r4_o != null) goto label107;
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=notify-once
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101))}));
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o).getString((global::java.util.Hashtable) _r0_o, (global::java.lang.String) _r10_o);
    global::com.codename1.impl.VServAds.access_2102((global::com.codename1.impl.VServAds) _r4_o, (global::java.lang.String) _r5_o);
    label107:;
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=data
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97))}));
    _r4_o = ((global::java.util.Hashtable) _r0_o).get((global::java.lang.Object) _r8_o);
    _r4_o = _r4_o;
    global::com.codename1.impl.VServAds.access_2202((global::com.codename1.impl.VServAds) _r5_o, (global::java.lang.String) _r4_o);
    // Value=render
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r4_o = ((global::java.util.Hashtable) _r1_o).get((global::java.lang.Object) _r4_o);
    _r4_o = _r4_o;
    _r3_o = ((global::java.util.Vector) _r4_o).elementAt((int) _r7.i);
    _r3_o = _r3_o;
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=type
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101))}));
    _r4_o = ((global::java.util.Hashtable) _r3_o).get((global::java.lang.Object) _r4_o);
    _r4_o = _r4_o;
    global::com.codename1.impl.VServAds.access_2302((global::com.codename1.impl.VServAds) _r5_o, (global::java.lang.String) _r4_o);
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=notify
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121))}));
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o).getString((global::java.util.Hashtable) _r3_o, (global::java.lang.String) _r9_o);
    global::com.codename1.impl.VServAds.access_2402((global::com.codename1.impl.VServAds) _r4_o, (global::java.lang.String) _r5_o);
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    _r4_o = global::com.codename1.impl.VServAds.access_2400((global::com.codename1.impl.VServAds) _r4_o);
    if (_r4_o != null) goto label177;
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=notify-once
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101))}));
    _r5_o = ((global::com.codename1.impl.VServAds_21) _r11_o).getString((global::java.util.Hashtable) _r3_o, (global::java.lang.String) _r10_o);
    global::com.codename1.impl.VServAds.access_2402((global::com.codename1.impl.VServAds) _r4_o, (global::java.lang.String) _r5_o);
    label177:;
    _r4_o = ((global::com.codename1.impl.VServAds_21) _r11_o)._fthis_20;
    // Value=data
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97))}));
    _r11_o = ((global::java.util.Hashtable) _r3_o).get((global::java.lang.Object) _r8_o);
    _r11_o = _r11_o;
    global::com.codename1.impl.VServAds.access_2502((global::com.codename1.impl.VServAds) _r4_o, (global::java.lang.String) _r11_o);
    goto label29;
//XMLVM_END_WRAPPER[com.codename1.impl.VServAds$1: void readResponse(java.io.InputStream)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.impl.VServAds$1]
//XMLVM_END_WRAPPER[com.codename1.impl.VServAds$1]

} // end of class: VServAds_21

} // end of namespace: com.codename1.impl
