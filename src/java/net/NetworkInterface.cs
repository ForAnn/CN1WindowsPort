// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public class NetworkInterface: global::java.lang.Object {
private static int _fCHECK_1CONNECT_1NO_1PORT = -1;

public static int _fNO_1INTERFACE_1INDEX = 0;

public static int _fUNSET_1INTERFACE_1INDEX = -1;

private global::java.lang.String _fname;

private global::java.lang.String _fdisplayName;

public global::org.xmlvm._nArrayAdapter<global::System.Object> _faddresses;

private int _finterfaceIndex;

private int _fhashCode;

private static global::System.Object getNetworkInterfacesImpl(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.net.NetworkInterface[] getNetworkInterfacesImpl()]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.net.NetworkInterface[] getNetworkInterfacesImpl()]
}

public void @this(global::java.lang.String n1, global::java.lang.String n2, global::org.xmlvm._nArrayAdapter<global::System.Object> n3, int n4){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: void <init>(java.lang.String, java.lang.String, java.net.InetAddress[], int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4.i = n4;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.net.NetworkInterface) _r0_o)._fname = (global::java.lang.String) _r1_o;
    ((global::java.net.NetworkInterface) _r0_o)._fdisplayName = (global::java.lang.String) _r2_o;
    ((global::java.net.NetworkInterface) _r0_o)._faddresses = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o;
    ((global::java.net.NetworkInterface) _r0_o)._finterfaceIndex = _r4.i;
    return;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: void <init>(java.lang.String, java.lang.String, java.net.InetAddress[], int)]
}

public virtual int getIndex(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: int getIndex()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.net.NetworkInterface) _r1_o)._finterfaceIndex;
    return _r0.i;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: int getIndex()]
}

public virtual global::System.Object getFirstAddress(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.net.InetAddress getFirstAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.net.NetworkInterface) _r2_o)._faddresses;
    if (_r0_o == null) goto label16;
    _r0_o = ((global::java.net.NetworkInterface) _r2_o)._faddresses;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = 1;
    if (_r0.i < _r1.i) goto label16;
    _r0_o = ((global::java.net.NetworkInterface) _r2_o)._faddresses;
    _r1.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i];
    label15:;
    return (global::java.net.InetAddress) _r0_o;
    label16:;
    _r0_o = null;
    goto label15;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.net.InetAddress getFirstAddress()]
}

public virtual global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.net.NetworkInterface) _r1_o)._fname;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.lang.String getName()]
}

public virtual global::System.Object getInetAddresses(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.util.Enumeration getInetAddresses()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r9.i = 0;
    _r8_o = ((global::java.net.NetworkInterface) _r10_o)._faddresses;
    if (_r8_o != null) goto label15;
    _r8_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r8_o).@this((int) _r9.i);
    _r8_o = ((global::java.util.Vector) _r8_o).elements();
    label14:;
    return (global::java.util.Enumeration) _r8_o;
    label15:;
    _r0_o = new global::java.util.Vector();
    _r8_o = ((global::java.net.NetworkInterface) _r10_o)._faddresses;
    _r8.i = ((global::org.xmlvm._nIArray) _r8_o).Length;
    ((global::java.util.Vector) _r0_o).@this((int) _r8.i);
    _r6_o = global::java.lang.System.getSecurityManager();
    if (_r6_o != null) goto label45;
    _r8_o = new global::java.util.Vector();
    _r9_o = ((global::java.net.NetworkInterface) _r10_o)._faddresses;
    _r9_o = global::java.util.Arrays.asList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r9_o);
    ((global::java.util.Vector) _r8_o).@this((global::java.util.Collection) _r9_o);
    _r8_o = ((global::java.util.Vector) _r8_o).elements();
    goto label14;
    label45:;
    _r1_o = ((global::java.net.NetworkInterface) _r10_o)._faddresses;
    _r5.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r4.i = 0;
    label49:;
    if (_r4.i >= _r5.i) goto label81;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i];
    if (_r6_o == null) goto label78;
    try {
    _r3_o = ((global::java.net.InetAddress) _r2_o).getHostName();
    // Value=::
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 58))}));
    _r8.i = ((global::java.lang.String) _r3_o).contains((global::java.lang.CharSequence) _r8_o) ? 1 : 0;
    if (_r8.i == 0) goto label71;
    _r3_o = ((global::java.net.NetworkInterface) _r10_o).getFullFormOfCompressedIPV6Address((global::java.lang.String) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.SecurityException) {
            _ex = ex;
            goto label106;
        }
        throw ex;
    } // end catch
    label71:;
    try {
    _r8.i = -1;
    ((global::java.lang.SecurityManager) _r6_o).checkConnect((global::java.lang.String) _r3_o, (int) _r8.i);
    ((global::java.util.Vector) _r0_o).add((global::java.lang.Object) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.SecurityException) {
            _ex = ex;
            goto label106;
        }
        throw ex;
    } // end catch
    label78:;
    _r4.i = _r4.i + 1;
    goto label49;
    label81:;
    _r7_o = ((global::java.util.Vector) _r0_o).elements();
    _r8.i = ((global::java.util.Enumeration) _r7_o).hasMoreElements() ? 1 : 0;
    if (_r8.i == 0) goto label96;
    _r8_o = ((global::java.util.Vector) _r0_o).elements();
    goto label14;
    label96:;
    _r8_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r8_o).@this((int) _r9.i);
    _r8_o = ((global::java.util.Vector) _r8_o).elements();
    goto label14;
    label106:;
    _r8_o = _ex.getJavaException();
    _ex = null;
    goto label78;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.util.Enumeration getInetAddresses()]
}

private global::System.Object getFullFormOfCompressedIPV6Address(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.lang.String getFullFormOfCompressedIPV6Address(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    _r13_o = this;
    _r14_o = n1;
    _r11.i = 8;
    // Value=
    _r12_o = new global::java.lang.String();
    ((global::java.lang.String)_r12_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    // Value=::
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 58))}));
    // Value=:
    _r9_o = new global::java.lang.String();
    ((global::java.lang.String)_r9_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r4_o = new global::java.lang.StringBuilder();
    _r8.i = 39;
    ((global::java.lang.StringBuilder) _r4_o).@this((int) _r8.i);
    _r0.i = 8;
    // Value=:
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r3_o = ((global::java.lang.String) _r14_o).split((global::java.lang.String) _r9_o);
    // Value=::
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 58))}));
    _r8.i = ((global::java.lang.String) _r14_o).startsWith((global::java.lang.String) _r10_o) ? 1 : 0;
    if (_r8.i == 0) goto label68;
    // Value=::
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 58))}));
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r14_o = ((global::java.lang.String) _r14_o).replace((global::java.lang.CharSequence) _r10_o, (global::java.lang.CharSequence) _r12_o);
    // Value=:
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r3_o = ((global::java.lang.String) _r14_o).split((global::java.lang.String) _r9_o);
    _r8.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r7.i = _r11.i - _r8.i;
    ((global::java.net.NetworkInterface) _r13_o).restoreCompressedFieldsWithZero((global::java.lang.StringBuilder) _r4_o, (int) _r7.i);
    ((global::java.net.NetworkInterface) _r13_o).appendNonZeroFields((global::java.lang.StringBuilder) _r4_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o);
    label54:;
    _r8.i = ((global::java.lang.StringBuilder) _r4_o).length();
    _r9.i = 1;
    _r8.i = _r8.i - _r9.i;
    ((global::java.lang.StringBuilder) _r4_o).deleteCharAt((int) _r8.i);
    _r8_o = ((global::java.lang.StringBuilder) _r4_o).toString();
    return (global::java.lang.String) _r8_o;
    label68:;
    // Value=::
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 58))}));
    _r8.i = ((global::java.lang.String) _r14_o).endsWith((global::java.lang.String) _r10_o) ? 1 : 0;
    if (_r8.i == 0) goto label100;
    // Value=::
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58)), unchecked((char) unchecked((uint) 58))}));
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r14_o = ((global::java.lang.String) _r14_o).replace((global::java.lang.CharSequence) _r10_o, (global::java.lang.CharSequence) _r12_o);
    // Value=:
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    _r3_o = ((global::java.lang.String) _r14_o).split((global::java.lang.String) _r9_o);
    _r8.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r7.i = _r11.i - _r8.i;
    ((global::java.net.NetworkInterface) _r13_o).appendNonZeroFields((global::java.lang.StringBuilder) _r4_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o);
    ((global::java.net.NetworkInterface) _r13_o).restoreCompressedFieldsWithZero((global::java.lang.StringBuilder) _r4_o, (int) _r7.i);
    goto label54;
    label100:;
    _r8.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r8.i = _r11.i - _r8.i;
    _r7.i = _r8.i + 1;
    _r1_o = _r3_o;
    _r6.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r5.i = 0;
    label108:;
    if (_r5.i >= _r6.i) goto label54;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r5.i];
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r8.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r12_o) ? 1 : 0;
    if (_r8.i == 0) goto label126;
    ((global::java.net.NetworkInterface) _r13_o).restoreCompressedFieldsWithZero((global::java.lang.StringBuilder) _r4_o, (int) _r7.i);
    label123:;
    _r5.i = _r5.i + 1;
    goto label108;
    label126:;
    ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r2_o);
    // Value=:
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r9_o);
    goto label123;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.lang.String getFullFormOfCompressedIPV6Address(java.lang.String)]
}

private void appendNonZeroFields(global::java.lang.StringBuilder n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: void appendNonZeroFields(java.lang.StringBuilder, java.lang.String[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0.i = 0;
    label1:;
    _r1.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    if (_r0.i >= _r1.i) goto label17;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    // Value=:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    _r0.i = _r0.i + 1;
    goto label1;
    label17:;
    return;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: void appendNonZeroFields(java.lang.StringBuilder, java.lang.String[])]
}

private void restoreCompressedFieldsWithZero(global::java.lang.StringBuilder n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: void restoreCompressedFieldsWithZero(java.lang.StringBuilder, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r2_o = this;
    _r3_o = n1;
    _r4.i = n2;
    _r0.i = 0;
    label1:;
    if (_r0.i >= _r4.i) goto label16;
    // Value=0
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)48))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    // Value=:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r1_o);
    _r0.i = _r0.i + 1;
    goto label1;
    label16:;
    return;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: void restoreCompressedFieldsWithZero(java.lang.StringBuilder, int)]
}

public virtual global::System.Object getDisplayName(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.lang.String getDisplayName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::java.net.NetworkInterface) _r2_o)._fdisplayName;
    // Value=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0_o = ((global::java.net.NetworkInterface) _r2_o)._fdisplayName;
    label12:;
    return (global::java.lang.String) _r0_o;
    label13:;
    _r0_o = ((global::java.net.NetworkInterface) _r2_o)._fname;
    goto label12;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.lang.String getDisplayName()]
}

public static global::System.Object getByName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.net.NetworkInterface getByName(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = n1;
    if (_r4_o != null) goto label14;
    _r2_o = new global::java.lang.NullPointerException();
    // Value=luni.6D
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 68))}));
    _r3_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r3_o);
    ((global::java.lang.NullPointerException) _r2_o).@this((global::java.lang.String) _r3_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r2_o);
    label14:;
    _r0_o = global::java.net.NetworkInterface.getNetworkInterfaces();
    if (_r0_o == null) goto label44;
    label20:;
    _r2.i = ((global::java.util.Enumeration) _r0_o).hasMoreElements() ? 1 : 0;
    if (_r2.i == 0) goto label44;
    _r1_o = ((global::java.util.Enumeration) _r0_o).nextElement();
    _r1_o = _r1_o;
    _r2_o = ((global::java.net.NetworkInterface) _r1_o).getName();
    _r2.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r2.i == 0) goto label20;
    _r2_o = _r1_o;
    label43:;
    return (global::java.net.NetworkInterface) _r2_o;
    label44:;
    _r2_o = null;
    goto label43;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.net.NetworkInterface getByName(java.lang.String)]
}

public static global::System.Object getByInetAddress(global::java.net.InetAddress n1){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.net.NetworkInterface getByInetAddress(java.net.InetAddress)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r5_o = n1;
    if (_r5_o != null) goto label14;
    _r3_o = new global::java.lang.NullPointerException();
    // Value=luni.68
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 54)), unchecked((char) unchecked((uint) 56))}));
    _r4_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r4_o);
    ((global::java.lang.NullPointerException) _r3_o).@this((global::java.lang.String) _r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r3_o);
    label14:;
    _r0_o = global::java.net.NetworkInterface.getNetworkInterfaces();
    if (_r0_o == null) goto label76;
    label20:;
    _r3.i = ((global::java.util.Enumeration) _r0_o).hasMoreElements() ? 1 : 0;
    if (_r3.i == 0) goto label76;
    _r1_o = ((global::java.util.Enumeration) _r0_o).nextElement();
    _r1_o = _r1_o;
    _r3_o = ((global::java.net.NetworkInterface) _r1_o)._faddresses;
    if (_r3_o == null) goto label20;
    _r3_o = ((global::java.net.NetworkInterface) _r1_o)._faddresses;
    _r3.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r3.i == 0) goto label20;
    _r3_o = new global::java.util.Vector();
    _r4_o = ((global::java.net.NetworkInterface) _r1_o)._faddresses;
    _r4_o = global::java.util.Arrays.asList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o);
    ((global::java.util.Vector) _r3_o).@this((global::java.util.Collection) _r4_o);
    _r2_o = ((global::java.util.Vector) _r3_o).elements();
    if (_r2_o == null) goto label20;
    label58:;
    _r3.i = ((global::java.util.Enumeration) _r2_o).hasMoreElements() ? 1 : 0;
    if (_r3.i == 0) goto label20;
    _r3_o = ((global::java.util.Enumeration) _r2_o).nextElement();
    _r3.i = ((global::java.net.InetAddress) _r5_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r3.i == 0) goto label58;
    _r3_o = _r1_o;
    label75:;
    return (global::java.net.NetworkInterface) _r3_o;
    label76:;
    _r3_o = null;
    goto label75;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.net.NetworkInterface getByInetAddress(java.net.InetAddress)]
}

public static global::System.Object getNetworkInterfaces(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.util.Enumeration getNetworkInterfaces()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    _r6_o = global::java.net.NetworkInterface.getNetworkInterfacesImpl();
    if (_r6_o != null) goto label8;
    _r10_o = null;
    label7:;
    return (global::java.util.Enumeration) _r10_o;
    label8:;
    _r2_o = _r6_o;
    _r7.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r4.i = 0;
    _r5.i = _r4.i;
    label12:;
    if (_r5.i >= _r7.i) goto label73;
    _r9_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r5.i];
    _r10_o = ((global::java.net.NetworkInterface) _r9_o)._faddresses;
    if (_r10_o == null) goto label69;
    _r3_o = ((global::java.net.NetworkInterface) _r9_o)._faddresses;
    _r8.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r4.i = 0;
    label24:;
    if (_r4.i >= _r8.i) goto label69;
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r4.i];
    _r10.i = 16;
    _r11_o = ((global::java.net.InetAddress) _r1_o)._fipaddress;
    _r11.i = ((global::org.xmlvm._nIArray) _r11_o).Length;
    if (_r10.i != _r11.i) goto label66;
    _r10.i = ((global::java.net.InetAddress) _r1_o).isLinkLocalAddress() ? 1 : 0;
    if (_r10.i != 0) goto label47;
    _r10.i = ((global::java.net.InetAddress) _r1_o).isSiteLocalAddress() ? 1 : 0;
    if (_r10.i == 0) goto label66;
    label47:;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r10_o = _r0_o;
    ((global::java.net.Inet6Address) _r10_o)._fscopedIf = (global::java.net.NetworkInterface) _r9_o;
    _r0_o = _r1_o;
    _r0_o = _r0_o;
    _r10_o = _r0_o;
    _r11_o = ((global::java.net.NetworkInterface) _r9_o)._fname;
    ((global::java.net.Inet6Address) _r10_o)._fifname = (global::java.lang.String) _r11_o;
    _r1_o = _r1_o;
    _r10.i = 1;
    ((global::java.net.Inet6Address) _r1_o)._fscope_1ifname_1set = 0!=_r10.i;
    label66:;
    _r4.i = _r4.i + 1;
    goto label24;
    label69:;
    _r4.i = _r5.i + 1;
    _r5.i = _r4.i;
    goto label12;
    label73:;
    _r10_o = new global::java.util.Vector();
    _r11_o = global::java.util.Arrays.asList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r6_o);
    ((global::java.util.Vector) _r10_o).@this((global::java.util.Collection) _r11_o);
    _r10_o = ((global::java.util.Vector) _r10_o).elements();
    goto label7;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.util.Enumeration getNetworkInterfaces()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: boolean equals(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r7.i = 1;
    _r6.i = 0;
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    if (_r10_o != _r9_o) goto label8;
    _r4.i = _r7.i;
    label7:;
    return _r4.i!=0;
    label8:;
    _r4.i = ((_r10_o != null) && (_r10_o is global::java.net.NetworkInterface)) ? 1 : 0;
    if (_r4.i != 0) goto label14;
    _r4.i = _r6.i;
    goto label7;
    label14:;
    _r0_o = _r10_o;
    _r0_o = _r0_o;
    _r2_o = _r0_o;
    _r4.i = ((global::java.net.NetworkInterface) _r2_o).getIndex();
    _r5.i = ((global::java.net.NetworkInterface) _r9_o)._finterfaceIndex;
    if (_r4.i == _r5.i) goto label28;
    _r4.i = _r6.i;
    goto label7;
    label28:;
    _r4_o = ((global::java.net.NetworkInterface) _r9_o)._fname;
    // Value=
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r8_o) ? 1 : 0;
    if (_r4.i != 0) goto label52;
    _r4_o = ((global::java.net.NetworkInterface) _r2_o).getName();
    _r5_o = ((global::java.net.NetworkInterface) _r9_o)._fname;
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r4.i != 0) goto label52;
    _r4.i = _r6.i;
    goto label7;
    label52:;
    _r4_o = ((global::java.net.NetworkInterface) _r9_o)._fname;
    // Value=
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r8_o) ? 1 : 0;
    if (_r4.i == 0) goto label76;
    _r4_o = ((global::java.net.NetworkInterface) _r2_o).getName();
    _r5_o = ((global::java.net.NetworkInterface) _r9_o)._fdisplayName;
    _r4.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r5_o) ? 1 : 0;
    if (_r4.i != 0) goto label76;
    _r4.i = _r6.i;
    goto label7;
    label76:;
    _r3_o = ((global::java.net.NetworkInterface) _r2_o).getInetAddresses();
    _r1_o = ((global::java.net.NetworkInterface) _r9_o).getInetAddresses();
    if (_r3_o != null) goto label92;
    if (_r1_o != null) goto label90;
    _r4.i = _r7.i;
    goto label7;
    label90:;
    _r4.i = _r6.i;
    goto label7;
    label92:;
    if (_r1_o != null) goto label96;
    _r4.i = _r6.i;
    goto label7;
    label96:;
    _r4.i = ((global::java.util.Enumeration) _r3_o).hasMoreElements() ? 1 : 0;
    if (_r4.i == 0) goto label126;
    _r4.i = ((global::java.util.Enumeration) _r1_o).hasMoreElements() ? 1 : 0;
    if (_r4.i == 0) goto label126;
    _r9_o = ((global::java.util.Enumeration) _r1_o).nextElement();
    _r9_o = _r9_o;
    _r4_o = ((global::java.util.Enumeration) _r3_o).nextElement();
    _r4.i = ((global::java.net.InetAddress) _r9_o).equals((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r4.i != 0) goto label96;
    _r4.i = _r6.i;
    goto label7;
    label126:;
    _r4.i = ((global::java.util.Enumeration) _r3_o).hasMoreElements() ? 1 : 0;
    if (_r4.i != 0) goto label141;
    _r4.i = ((global::java.util.Enumeration) _r1_o).hasMoreElements() ? 1 : 0;
    if (_r4.i != 0) goto label141;
    _r4.i = _r7.i;
    goto label7;
    label141:;
    _r4.i = _r6.i;
    goto label7;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.net.NetworkInterface) _r1_o)._fhashCode;
    if (_r0.i != 0) goto label12;
    _r0_o = ((global::java.net.NetworkInterface) _r1_o)._fname;
    _r0.i = ((global::java.lang.String) _r0_o).hashCode();
    ((global::java.net.NetworkInterface) _r1_o)._fhashCode = _r0.i;
    label12:;
    _r0.i = ((global::java.net.NetworkInterface) _r1_o)._fhashCode;
    return _r0.i;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: int hashCode()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r6_o = this;
    // Value=]
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    // Value=[
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91))}));
    _r1_o = new global::java.lang.StringBuilder();
    _r3.i = 25;
    ((global::java.lang.StringBuilder) _r1_o).@this((int) _r3.i);
    // Value=[
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.net.NetworkInterface) _r6_o)._fname;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    // Value=][
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93)), unchecked((char) unchecked((uint) 91))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    _r3_o = ((global::java.net.NetworkInterface) _r6_o)._fdisplayName;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    // Value=]
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r5_o);
    _r2_o = ((global::java.net.NetworkInterface) _r6_o).getInetAddresses();
    if (_r2_o == null) goto label72;
    label42:;
    _r3.i = ((global::java.util.Enumeration) _r2_o).hasMoreElements() ? 1 : 0;
    if (_r3.i == 0) goto label72;
    _r0_o = ((global::java.util.Enumeration) _r2_o).nextElement();
    _r0_o = _r0_o;
    // Value=[
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.net.InetAddress) _r0_o).toString();
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    // Value=]
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r5_o);
    goto label42;
    label72:;
    _r3_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    return (global::java.lang.String) _r3_o;
//XMLVM_END_WRAPPER[java.net.NetworkInterface: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[java.net.NetworkInterface]
//XMLVM_END_WRAPPER[java.net.NetworkInterface]

} // end of class: NetworkInterface

} // end of namespace: java.net
