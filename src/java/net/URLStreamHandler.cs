// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public abstract class URLStreamHandler: global::java.lang.Object {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: void <init>()]
}

public abstract global::System.Object openConnection(global::java.net.URL n1);

public virtual global::System.Object openConnection(global::java.net.URL n1, global::java.net.Proxy n2){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: java.net.URLConnection openConnection(java.net.URL, java.net.Proxy)]
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
    _r0_o = new global::java.lang.UnsupportedOperationException();
    // Value=luni.9E
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 57)), unchecked((char) unchecked((uint) 69))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: java.net.URLConnection openConnection(java.net.URL, java.net.Proxy)]
}

public virtual void parseURL(global::java.net.URL n1, global::java.lang.String n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: void parseURL(java.net.URL, java.lang.String, int, int)]
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
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r20_o = this;
    _r21_o = n1;
    _r22_o = n2;
    _r23.i = n3;
    _r24.i = n4;
    _r0.i = _r24.i;
    _r1.i = _r23.i;
    if (_r0.i < _r1.i) goto label8;
    if (_r24.i >= 0) goto label80;
    label8:;
    _r3.i = -2147483647;
    _r0.i = _r24.i;
    _r1.i = _r3.i;
    if (_r0.i > _r1.i) goto label27;
    _r3.i = ((global::java.lang.String) _r22_o).length();
    _r0.i = _r23.i;
    _r1.i = _r3.i;
    if (_r0.i >= _r1.i) goto label55;
    if (_r23.i < 0) goto label55;
    label27:;
    // Value=//
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47)), unchecked((char) unchecked((uint) 47))}));
    _r0_o = _r22_o;
    _r1_o = _r3_o;
    _r2.i = _r23.i;
    _r3.i = ((global::java.lang.String) _r0_o).startsWith((global::java.lang.String) _r1_o, (int) _r2.i) ? 1 : 0;
    if (_r3.i == 0) goto label64;
    _r3.i = 47;
    _r4.i = _r23.i + 2;
    _r0_o = _r22_o;
    _r1.i = _r3.i;
    _r2.i = _r4.i;
    _r3.i = ((global::java.lang.String) _r0_o).indexOf((int) _r1.i, (int) _r2.i);
    _r4.i = -1;
    if (_r3.i != _r4.i) goto label64;
    label55:;
    _r3_o = new global::java.lang.StringIndexOutOfBoundsException();
    _r0_o = _r3_o;
    _r1.i = _r24.i;
    ((global::java.lang.StringIndexOutOfBoundsException) _r0_o).@this((int) _r1.i);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.StringIndexOutOfBoundsException) _r3_o);
    label64:;
    _r0_o = _r21_o;
    _r0_o = ((global::java.net.URL) _r0_o)._fstrmHandler;
    _r3_o = _r0_o;
    _r0_o = _r20_o;
    _r1_o = _r3_o;
    if (_r0_o == _r1_o) goto label407;
    _r3_o = new global::java.lang.SecurityException();
    ((global::java.lang.SecurityException) _r3_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.SecurityException) _r3_o);
    label80:;
    _r3_o = ((global::java.lang.String) _r22_o).substring((int) _r23.i, (int) _r24.i);
    _r4.i = _r24.i - _r23.i;
    _r5.i = 0;
    _r6_o = ((global::java.net.URL) _r21_o).getHost();
    _r7.i = ((global::java.net.URL) _r21_o).getPort();
    _r10_o = ((global::java.net.URL) _r21_o).getRef();
    _r8_o = ((global::java.net.URL) _r21_o).getPath();
    _r11_o = ((global::java.net.URL) _r21_o).getQuery();
    _r9_o = ((global::java.net.URL) _r21_o).getAuthority();
    _r12_o = ((global::java.net.URL) _r21_o).getUserInfo();
    _r13.i = 35;
    _r14.i = 0;
    _r13.i = ((global::java.lang.String) _r3_o).indexOf((int) _r13.i, (int) _r14.i);
    // Value=//
    _r14_o = new global::java.lang.String();
    ((global::java.lang.String)_r14_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47)), unchecked((char) unchecked((uint) 47))}));
    _r14.i = ((global::java.lang.String) _r3_o).startsWith((global::java.lang.String) _r14_o) ? 1 : 0;
    if (_r14.i == 0) goto label621;
    // Value=////
    _r14_o = new global::java.lang.String();
    ((global::java.lang.String)_r14_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47)), unchecked((char) unchecked((uint) 47))}));
    _r14.i = ((global::java.lang.String) _r3_o).startsWith((global::java.lang.String) _r14_o) ? 1 : 0;
    if (_r14.i != 0) goto label621;
    _r5.i = 2;
    _r6.i = -1;
    _r7.i = 47;
    _r7.i = ((global::java.lang.String) _r3_o).indexOf((int) _r7.i, (int) _r5.i);
    _r9.i = 63;
    _r9.i = ((global::java.lang.String) _r3_o).indexOf((int) _r9.i, (int) _r5.i);
    _r14.i = -1;
    if (_r9.i == _r14.i) goto label161;
    _r14.i = -1;
    if (_r7.i == _r14.i) goto label160;
    if (_r7.i <= _r9.i) goto label161;
    label160:;
    _r7.i = _r9.i;
    label161:;
    _r9.i = -1;
    if (_r7.i != _r9.i) goto label614;
    // Value=
    _r7_o = new global::java.lang.String();
    ((global::java.lang.String)_r7_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r8.i = _r4.i;
    label167:;
    _r9.i = -1;
    if (_r13.i == _r9.i) goto label611;
    if (_r13.i >= _r8.i) goto label611;
    _r9.i = _r13.i;
    label173:;
    _r14.i = 64;
    _r14.i = ((global::java.lang.String) _r3_o).lastIndexOf((int) _r14.i, (int) _r9.i);
    _r15_o = ((global::java.lang.String) _r3_o).substring((int) _r5.i, (int) _r9.i);
    _r16.i = -1;
    _r0.i = _r14.i;
    _r1.i = _r16.i;
    if (_r0.i <= _r1.i) goto label201;
    _r5_o = ((global::java.lang.String) _r3_o).substring((int) _r5.i, (int) _r14.i);
    _r12.i = _r14.i + 1;
    _r19.i = _r12.i;
    _r12_o = _r5_o;
    _r5.i = _r19.i;
    label201:;
    _r16.i = 58;
    _r17.i = -1;
    _r0.i = _r14.i;
    _r1.i = _r17.i;
    if (_r0.i != _r1.i) goto label211;
    _r14.i = _r5.i;
    label211:;
    _r0_o = _r3_o;
    _r1.i = _r16.i;
    _r2.i = _r14.i;
    _r14.i = ((global::java.lang.String) _r0_o).indexOf((int) _r1.i, (int) _r2.i);
    _r16.i = 93;
    _r0_o = _r3_o;
    _r1.i = _r16.i;
    _r16.i = ((global::java.lang.String) _r0_o).indexOf((int) _r1.i);
    _r17.i = -1;
    _r0.i = _r16.i;
    _r1.i = _r17.i;
    if (_r0.i == _r1.i) goto label266;
    try {
    _r17.i = ((global::java.lang.String) _r3_o).length();
    _r18.i = _r16.i + 1;
    _r0.i = _r17.i;
    _r1.i = _r18.i;
    if (_r0.i <= _r1.i) goto label411;
    _r17.i = _r16.i + 1;
    _r0_o = _r3_o;
    _r1.i = _r17.i;
    _r14.i = ((global::java.lang.String) _r0_o).charAt((int) _r1.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label580;
        }
        throw ex;
    } // end catch
    _r17.i = 58;
    _r0.i = _r14.i;
    _r1.i = _r17.i;
    if (_r0.i != _r1.i) goto label408;
    _r14.i = _r16.i + 1;
    label266:;
    _r16.i = -1;
    _r0.i = _r14.i;
    _r1.i = _r16.i;
    if (_r0.i == _r1.i) goto label275;
    if (_r14.i <= _r8.i) goto label414;
    label275:;
    _r5_o = ((global::java.lang.String) _r3_o).substring((int) _r5.i, (int) _r9.i);
    _r9_o = _r12_o;
    _r14.i = _r8.i;
    _r8_o = _r15_o;
    _r19.i = _r6.i;
    _r6_o = _r5_o;
    _r5_o = _r7_o;
    _r7.i = _r19.i;
    label288:;
    _r12.i = -1;
    if (_r13.i <= _r12.i) goto label608;
    _r10.i = _r13.i + 1;
    _r10_o = ((global::java.lang.String) _r3_o).substring((int) _r10.i, (int) _r4.i);
    _r12_o = _r10_o;
    label298:;
    _r10.i = -1;
    if (_r13.i != _r10.i) goto label457;
    _r10.i = _r4.i;
    label302:;
    _r15.i = 63;
    _r15.i = ((global::java.lang.String) _r3_o).lastIndexOf((int) _r15.i, (int) _r10.i);
    _r16.i = 0;
    _r17.i = -1;
    _r0.i = _r15.i;
    _r1.i = _r17.i;
    if (_r0.i <= _r1.i) goto label476;
    _r11.i = _r15.i + 1;
    _r10_o = ((global::java.lang.String) _r3_o).substring((int) _r11.i, (int) _r10.i);
    if (_r15.i != 0) goto label603;
    if (_r5_o == null) goto label603;
    // Value=
    _r11_o = new global::java.lang.String();
    ((global::java.lang.String)_r11_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r11.i = ((global::java.lang.String) _r5_o).equals((global::java.lang.Object) _r11_o) ? 1 : 0;
    if (_r11.i == 0) goto label460;
    // Value=/
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r11_o = _r5_o;
    _r5.i = _r16.i;
    label340:;
    _r13.i = 47;
    _r13.i = ((global::java.lang.String) _r11_o).lastIndexOf((int) _r13.i);
    _r13.i = _r13.i + 1;
    _r16.i = 0;
    _r0_o = _r11_o;
    _r1.i = _r16.i;
    _r2.i = _r13.i;
    _r11_o = ((global::java.lang.String) _r0_o).substring((int) _r1.i, (int) _r2.i);
    label358:;
    _r13_o = _r11_o;
    _r11_o = _r10_o;
    _r10.i = _r15.i;
    label361:;
    _r15.i = -1;
    if (_r14.i <= _r15.i) goto label589;
    if (_r14.i >= _r4.i) goto label483;
    _r4.i = ((global::java.lang.String) _r3_o).charAt((int) _r14.i);
    _r15.i = 47;
    if (_r4.i != _r15.i) goto label483;
    _r3_o = ((global::java.lang.String) _r3_o).substring((int) _r14.i, (int) _r10.i);
    _r4_o = _r3_o;
    _r3.i = _r5.i;
    label380:;
    if (_r4_o != null) goto label384;
    // Value=
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    label384:;
    if (_r6_o != null) goto label389;
    // Value=
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r6_o = _r5_o;
    label389:;
    if (_r3.i == 0) goto label583;
    _r3_o = global::org.apache.harmony.luni.util.URLUtil.canonicalizePath((global::java.lang.String) _r4_o);
    _r10_o = _r3_o;
    label396:;
    _r5_o = ((global::java.net.URL) _r21_o).getProtocol();
    _r3_o = _r20_o;
    _r4_o = _r21_o;
    ((global::java.net.URLStreamHandler) _r3_o).setURL((global::java.net.URL) _r4_o, (global::java.lang.String) _r5_o, (global::java.lang.String) _r6_o, (int) _r7.i, (global::java.lang.String) _r8_o, (global::java.lang.String) _r9_o, (global::java.lang.String) _r10_o, (global::java.lang.String) _r11_o, (global::java.lang.String) _r12_o);
    label407:;
    return;
    label408:;
    _r14.i = -1;
    goto label266;
    label411:;
    _r14.i = -1;
    goto label266;
    label414:;
    _r5_o = ((global::java.lang.String) _r3_o).substring((int) _r5.i, (int) _r14.i);
    _r6.i = _r14.i + 1;
    _r6_o = ((global::java.lang.String) _r3_o).substring((int) _r6.i, (int) _r9.i);
    _r9.i = ((global::java.lang.String) _r6_o).length();
    if (_r9.i != 0) goto label442;
    _r6.i = -1;
    _r9_o = _r12_o;
    _r14.i = _r8.i;
    _r8_o = _r15_o;
    _r19.i = _r6.i;
    _r6_o = _r5_o;
    _r5_o = _r7_o;
    _r7.i = _r19.i;
    goto label288;
    label442:;
    _r6.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r6_o);
    _r9_o = _r12_o;
    _r14.i = _r8.i;
    _r8_o = _r15_o;
    _r19.i = _r6.i;
    _r6_o = _r5_o;
    _r5_o = _r7_o;
    _r7.i = _r19.i;
    goto label288;
    label457:;
    _r10.i = _r13.i;
    goto label302;
    label460:;
    // Value=/
    _r11_o = new global::java.lang.String();
    ((global::java.lang.String)_r11_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r11.i = ((global::java.lang.String) _r5_o).startsWith((global::java.lang.String) _r11_o) ? 1 : 0;
    if (_r11.i == 0) goto label598;
    _r11.i = 1;
    _r19.i = _r11.i;
    _r11_o = _r5_o;
    _r5.i = _r19.i;
    goto label340;
    label476:;
    if (_r13.i == 0) goto label593;
    _r11_o = null;
    _r13_o = _r5_o;
    _r5.i = _r16.i;
    goto label361;
    label483:;
    if (_r10.i <= _r14.i) goto label589;
    if (_r13_o != null) goto label515;
    // Value=
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r19.i = _r5.i;
    _r5_o = _r4_o;
    _r4.i = _r19.i;
    label494:;
    _r13.i = 47;
    _r13.i = ((global::java.lang.String) _r5_o).lastIndexOf((int) _r13.i);
    _r13.i = _r13.i + 1;
    if (_r13.i != 0) goto label542;
    _r3_o = ((global::java.lang.String) _r3_o).substring((int) _r14.i, (int) _r10.i);
    _r19.i = _r4.i;
    _r4_o = _r3_o;
    _r3.i = _r19.i;
    goto label380;
    label515:;
    // Value=
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r4.i = ((global::java.lang.String) _r13_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label531;
    // Value=/
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r19.i = _r5.i;
    _r5_o = _r4_o;
    _r4.i = _r19.i;
    goto label494;
    label531:;
    // Value=/
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r4.i = ((global::java.lang.String) _r13_o).startsWith((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label586;
    _r4.i = 1;
    _r5_o = _r13_o;
    goto label494;
    label542:;
    _r15_o = new global::java.lang.StringBuilder();
    _r16.i = 0;
    _r0_o = _r5_o;
    _r1.i = _r16.i;
    _r2.i = _r13.i;
    _r5_o = ((global::java.lang.String) _r0_o).substring((int) _r1.i, (int) _r2.i);
    _r5_o = global::java.lang.String.valueOf((global::java.lang.Object) _r5_o);
    ((global::java.lang.StringBuilder) _r15_o).@this((global::java.lang.String) _r5_o);
    _r3_o = ((global::java.lang.String) _r3_o).substring((int) _r14.i, (int) _r10.i);
    _r3_o = ((global::java.lang.StringBuilder) _r15_o).append((global::java.lang.String) _r3_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    _r19.i = _r4.i;
    _r4_o = _r3_o;
    _r3.i = _r19.i;
    goto label380;
    label580:;
    _r16_o = _ex.getJavaException();
    _ex = null;
    goto label266;
    label583:;
    _r10_o = _r4_o;
    goto label396;
    label586:;
    _r4.i = _r5.i;
    _r5_o = _r13_o;
    goto label494;
    label589:;
    _r3.i = _r5.i;
    _r4_o = _r13_o;
    goto label380;
    label593:;
    _r13_o = _r5_o;
    _r5.i = _r16.i;
    goto label361;
    label598:;
    _r11_o = _r5_o;
    _r5.i = _r16.i;
    goto label340;
    label603:;
    _r11_o = _r5_o;
    _r5.i = _r16.i;
    goto label358;
    label608:;
    _r12_o = _r10_o;
    goto label298;
    label611:;
    _r9.i = _r8.i;
    goto label173;
    label614:;
    _r19_o = _r8_o;
    _r8.i = _r7.i;
    _r7_o = _r19_o;
    goto label167;
    label621:;
    _r14.i = _r5.i;
    _r5_o = _r8_o;
    _r8_o = _r9_o;
    _r9_o = _r12_o;
    goto label288;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: void parseURL(java.net.URL, java.lang.String, int, int)]
}

public virtual void setURL(global::java.net.URL n1, global::java.lang.String n2, global::java.lang.String n3, int n4, global::java.lang.String n5, global::java.lang.String n6){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: void setURL(java.net.URL, java.lang.String, java.lang.String, int, java.lang.String, java.lang.String)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5.i = n4;
    _r6_o = n5;
    _r7_o = n6;
    _r0_o = ((global::java.net.URL) _r2_o)._fstrmHandler;
    if (_r1_o == _r0_o) goto label10;
    _r0_o = new global::java.lang.SecurityException();
    ((global::java.lang.SecurityException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.SecurityException) _r0_o);
    label10:;
    ((global::java.net.URL) _r2_o).set((global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (int) _r5.i, (global::java.lang.String) _r6_o, (global::java.lang.String) _r7_o);
    return;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: void setURL(java.net.URL, java.lang.String, java.lang.String, int, java.lang.String, java.lang.String)]
}

public virtual void setURL(global::java.net.URL n1, global::java.lang.String n2, global::java.lang.String n3, int n4, global::java.lang.String n5, global::java.lang.String n6, global::java.lang.String n7, global::java.lang.String n8, global::java.lang.String n9){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: void setURL(java.net.URL, java.lang.String, java.lang.String, int, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5.i = n4;
    _r6_o = n5;
    _r7_o = n6;
    _r8_o = n7;
    _r9_o = n8;
    _r10_o = n9;
    _r0_o = ((global::java.net.URL) _r2_o)._fstrmHandler;
    if (_r1_o == _r0_o) goto label10;
    _r0_o = new global::java.lang.SecurityException();
    ((global::java.lang.SecurityException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.SecurityException) _r0_o);
    label10:;
    ((global::java.net.URL) _r2_o).set((global::java.lang.String) _r3_o, (global::java.lang.String) _r4_o, (int) _r5.i, (global::java.lang.String) _r6_o, (global::java.lang.String) _r7_o, (global::java.lang.String) _r8_o, (global::java.lang.String) _r9_o, (global::java.lang.String) _r10_o);
    return;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: void setURL(java.net.URL, java.lang.String, java.lang.String, int, java.lang.String, java.lang.String, java.lang.String, java.lang.String, java.lang.String)]
}

public virtual global::System.Object toExternalForm(global::java.net.URL n1){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: java.lang.String toExternalForm(java.net.URL)]
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
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::java.net.URL) _r4_o).getProtocol();
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = 58;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.net.URL) _r4_o).getAuthority();
    if (_r1_o == null) goto label41;
    _r1.i = ((global::java.lang.String) _r1_o).length();
    if (_r1.i <= 0) goto label41;
    // Value=//
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47)), unchecked((char) unchecked((uint) 47))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.net.URL) _r4_o).getAuthority();
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label41:;
    _r1_o = ((global::java.net.URL) _r4_o).getFile();
    _r2_o = ((global::java.net.URL) _r4_o).getRef();
    if (_r1_o == null) goto label54;
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label54:;
    if (_r2_o == null) goto label64;
    _r1.i = 35;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    label64:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: java.lang.String toExternalForm(java.net.URL)]
}

public virtual bool equals(global::java.net.URL n1, global::java.net.URL n2){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: boolean equals(java.net.URL, java.net.URL)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r2.i = 0;
    _r0.i = ((global::java.net.URLStreamHandler) _r3_o).sameFile((global::java.net.URL) _r4_o, (global::java.net.URL) _r5_o) ? 1 : 0;
    if (_r0.i != 0) goto label9;
    _r0.i = _r2.i;
    label8:;
    return _r0.i!=0;
    label9:;
    _r0_o = ((global::java.net.URL) _r4_o).getRef();
    _r1_o = ((global::java.net.URL) _r5_o).getRef();
    if (_r0_o == _r1_o) goto label29;
    if (_r0_o == null) goto label27;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label29;
    label27:;
    _r0.i = _r2.i;
    goto label8;
    label29:;
    _r0_o = ((global::java.net.URL) _r4_o).getQuery();
    _r1_o = ((global::java.net.URL) _r5_o).getQuery();
    if (_r0_o == _r1_o) goto label49;
    if (_r0_o == null) goto label47;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label49;
    label47:;
    _r0.i = _r2.i;
    goto label8;
    label49:;
    _r0.i = 1;
    goto label8;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: boolean equals(java.net.URL, java.net.URL)]
}

public virtual int getDefaultPort(){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: int getDefaultPort()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = -1;
    return _r0.i;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: int getDefaultPort()]
}

public virtual global::System.Object getHostAddress(global::java.net.URL n1){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: java.net.InetAddress getHostAddress(java.net.URL)]
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
    _r3_o = this;
    _r4_o = n1;
    _r2_o = null;
    try {
    _r0_o = ((global::java.net.URL) _r4_o).getHost();
    if (_r0_o == null) goto label13;
    _r1.i = ((global::java.lang.String) _r0_o).length();
    if (_r1.i != 0) goto label15;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.UnknownHostException) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    label13:;
    try {
    _r0_o = _r2_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.UnknownHostException) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    label14:;
    try {
    return (global::java.net.InetAddress) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.UnknownHostException) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    label15:;
    try {
    _r0_o = global::java.net.InetAddress.getByName((global::java.lang.String) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.net.UnknownHostException) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    goto label14;
    label20:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r2_o;
    goto label14;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: java.net.InetAddress getHostAddress(java.net.URL)]
}

public virtual int hashCode(global::java.net.URL n1){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: int hashCode(java.net.URL)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.net.URLStreamHandler) _r1_o).toExternalForm((global::java.net.URL) _r2_o);
    _r0.i = ((global::java.lang.String) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: int hashCode(java.net.URL)]
}

public virtual bool hostsEqual(global::java.net.URL n1, global::java.net.URL n2){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: boolean hostsEqual(java.net.URL, java.net.URL)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r2.i = 1;
    _r0_o = ((global::java.net.URLStreamHandler) _r3_o).getHostAddress((global::java.net.URL) _r4_o);
    _r1_o = ((global::java.net.URLStreamHandler) _r3_o).getHostAddress((global::java.net.URL) _r5_o);
    if (_r0_o == null) goto label18;
    if (_r1_o == null) goto label18;
    _r0.i = ((global::java.net.InetAddress) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    label17:;
    return _r0.i!=0;
    label18:;
    _r0_o = global::java.net.URLStreamHandler.getHost((global::java.net.URL) _r4_o);
    _r1_o = global::java.net.URLStreamHandler.getHost((global::java.net.URL) _r5_o);
    if (_r0_o != null) goto label32;
    if (_r1_o != null) goto label32;
    _r0.i = _r2.i;
    goto label17;
    label32:;
    if (_r0_o == null) goto label42;
    _r0.i = ((global::java.lang.String) _r0_o).equalsIgnoreCase((global::java.lang.String) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label42;
    _r0.i = _r2.i;
    goto label17;
    label42:;
    _r0.i = 0;
    goto label17;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: boolean hostsEqual(java.net.URL, java.net.URL)]
}

public virtual bool sameFile(global::java.net.URL n1, global::java.net.URL n2){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: boolean sameFile(java.net.URL, java.net.URL)]
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
    _r3.i = -1;
    _r2.i = 0;
    _r0_o = ((global::java.net.URL) _r5_o).getProtocol();
    _r1_o = ((global::java.net.URL) _r6_o).getProtocol();
    if (_r0_o == _r1_o) goto label22;
    if (_r0_o == null) goto label20;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label22;
    label20:;
    _r0.i = _r2.i;
    label21:;
    return _r0.i!=0;
    label22:;
    _r0_o = ((global::java.net.URL) _r5_o).getFile();
    _r1_o = ((global::java.net.URL) _r6_o).getFile();
    if (_r0_o == _r1_o) goto label42;
    if (_r0_o == null) goto label40;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label42;
    label40:;
    _r0.i = _r2.i;
    goto label21;
    label42:;
    _r0.i = ((global::java.net.URLStreamHandler) _r4_o).hostsEqual((global::java.net.URL) _r5_o, (global::java.net.URL) _r6_o) ? 1 : 0;
    if (_r0.i != 0) goto label50;
    _r0.i = _r2.i;
    goto label21;
    label50:;
    _r0.i = ((global::java.net.URL) _r5_o).getPort();
    if (_r0.i != _r3.i) goto label60;
    _r0.i = ((global::java.net.URLStreamHandler) _r4_o).getDefaultPort();
    label60:;
    _r1.i = ((global::java.net.URL) _r6_o).getPort();
    if (_r1.i != _r3.i) goto label70;
    _r1.i = ((global::java.net.URLStreamHandler) _r4_o).getDefaultPort();
    label70:;
    if (_r0.i != _r1.i) goto label74;
    _r0.i = 1;
    goto label21;
    label74:;
    _r0.i = _r2.i;
    goto label21;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: boolean sameFile(java.net.URL, java.net.URL)]
}

private static global::System.Object getHost(global::java.net.URL n1){
//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler: java.lang.String getHost(java.net.URL)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = n1;
    _r0_o = ((global::java.net.URL) _r3_o).getHost();
    // Value=file
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)102)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    _r2_o = ((global::java.net.URL) _r3_o).getProtocol();
    _r1.i = ((global::java.lang.String) _r1_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    if (_r1.i == 0) goto label26;
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r1.i = ((global::java.lang.String) _r1_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r1.i == 0) goto label26;
    // Value=localhost
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116))}));
    label26:;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.net.URLStreamHandler: java.lang.String getHost(java.net.URL)]
}

//XMLVM_BEGIN_WRAPPER[java.net.URLStreamHandler]
//XMLVM_END_WRAPPER[java.net.URLStreamHandler]

} // end of class: URLStreamHandler

} // end of namespace: java.net
