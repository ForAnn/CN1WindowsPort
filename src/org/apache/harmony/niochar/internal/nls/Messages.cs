// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.niochar.@internal.nls {
public class Messages: global::java.lang.Object {

static Messages() {
    @static();
}

private static global::java.util.ResourceBundle _fbundle;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = null;
    global::org.apache.harmony.niochar.@internal.nls.Messages._fbundle = (global::java.util.ResourceBundle) _r0_o;
    try {
    _r0_o = global::java.util.Locale.getDefault();
    // Value=org.apache.harmony.niochar.internal.nls.messages
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115))}));
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.setLocale((global::java.util.Locale) _r0_o, (global::java.lang.String) _r1_o);
    global::org.apache.harmony.niochar.@internal.nls.Messages._fbundle = (global::java.util.ResourceBundle) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label16;
        }
        throw ex;
    } // end catch
    label15:;
    return;
    label16:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    ((global::java.lang.Throwable) _r0_o).printStackTrace();
    goto label15;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: void <clinit>()]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: void <init>()]
}

public static global::System.Object getString(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages._fbundle;
    if (_r0_o != null) goto label6;
    _r0_o = _r2_o;
    label5:;
    return (global::java.lang.String) _r0_o;
    label6:;
    try {
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages._fbundle;
    _r0_o = ((global::java.util.ResourceBundle) _r0_o).getString((global::java.lang.String) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.util.MissingResourceException) {
            _ex = ex;
            goto label13;
        }
        throw ex;
    } // end catch
    goto label5;
    label13:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=Missing message: 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)77)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label5;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String)]
}

public static global::System.Object getString(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r3_o = n2;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, java.lang.Object)]
}

public static global::System.Object getString(global::java.lang.String n1, int n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, int)]
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
    _r3_o = n1;
    _r4.i = n2;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = global::java.lang.Integer.toString((int) _r4.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r3_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, int)]
}

public static global::System.Object getString(global::java.lang.String n1, char n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, char)]
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
    _r3_o = n1;
    _r4.i = n2;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = global::java.lang.String.valueOf((char) _r4.i);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r3_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, char)]
}

public static global::System.Object getString(global::java.lang.String n1, global::java.lang.Object n2, global::java.lang.Object n3){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, java.lang.Object, java.lang.Object)]
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
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0.i = 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 1;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r4_o;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.getString((global::java.lang.String) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, java.lang.Object, java.lang.Object)]
}

public static global::System.Object getString(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, java.lang.Object[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2_o = n2;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages._fbundle;
    if (_r0_o == null) goto label16;
    try {
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages._fbundle;
    _r0_o = ((global::java.util.ResourceBundle) _r0_o).getString((global::java.lang.String) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.util.MissingResourceException) {
            _ex = ex;
            goto label15;
        }
        throw ex;
    } // end catch
    label10:;
    _r0_o = global::org.apache.harmony.niochar.@internal.nls.Messages.format((global::java.lang.String) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    return (global::java.lang.String) _r0_o;
    label15:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    label16:;
    _r0_o = _r1_o;
    goto label10;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String getString(java.lang.String, java.lang.Object[])]
}

public static global::System.Object format(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String format(java.lang.String, java.lang.Object[])]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = n1;
    _r11_o = n2;
    _r8.i = 123;
    _r7.i = 1;
    _r4.i = 0;
    _r0_o = new global::java.lang.StringBuilder();
    _r1.i = ((global::java.lang.String) _r10_o).length();
    _r2.i = ((global::org.xmlvm._nIArray) _r11_o).Length;
    _r2.i = _r2.i * 20;
    _r1.i = _r1.i + _r2.i;
    ((global::java.lang.StringBuilder) _r0_o).@this((int) _r1.i);
    _r1.i = ((global::org.xmlvm._nIArray) _r11_o).Length;
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r2.i = _r4.i;
    label21:;
    _r3.i = ((global::org.xmlvm._nIArray) _r11_o).Length;
    if (_r2.i < _r3.i) goto label53;
    _r2.i = ((global::java.lang.String) _r10_o).indexOf((int) _r8.i, (int) _r4.i);
    _r3.i = _r4.i;
    label29:;
    if (_r2.i >= 0) goto label73;
    _r1.i = ((global::java.lang.String) _r10_o).length();
    if (_r3.i >= _r1.i) goto label48;
    _r1.i = ((global::java.lang.String) _r10_o).length();
    _r1_o = ((global::java.lang.String) _r10_o).substring((int) _r3.i, (int) _r1.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    label48:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label53:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r11_o)[_r2.i];
    if (_r3_o != null) goto label64;
    // Value=<null>
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 62))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    label61:;
    _r2.i = _r2.i + 1;
    goto label21;
    label64:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r11_o)[_r2.i];
    _r3_o = ((global::java.lang.Object) _r3_o).toString();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    goto label61;
    label73:;
    if (_r2.i == 0) goto label109;
    _r4.i = _r2.i - _r7.i;
    _r4.i = ((global::java.lang.String) _r10_o).charAt((int) _r4.i);
    _r5.i = 92;
    if (_r4.i != _r5.i) goto label109;
    if (_r2.i == _r7.i) goto label96;
    _r4.i = _r2.i - _r7.i;
    _r3_o = ((global::java.lang.String) _r10_o).substring((int) _r3.i, (int) _r4.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    label96:;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r8.i);
    _r2.i = _r2.i + 1;
    label101:;
    _r3.i = ((global::java.lang.String) _r10_o).indexOf((int) _r8.i, (int) _r2.i);
    _r9.i = _r3.i;
    _r3.i = _r2.i;
    _r2.i = _r9.i;
    goto label29;
    label109:;
    _r4.i = ((global::java.lang.String) _r10_o).length();
    _r5.i = 3;
    _r4.i = _r4.i - _r5.i;
    if (_r2.i <= _r4.i) goto label133;
    _r2.i = ((global::java.lang.String) _r10_o).length();
    _r2_o = ((global::java.lang.String) _r10_o).substring((int) _r3.i, (int) _r2.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r2_o);
    _r2.i = ((global::java.lang.String) _r10_o).length();
    goto label101;
    label133:;
    _r4.i = _r2.i + 1;
    _r4.i = ((global::java.lang.String) _r10_o).charAt((int) _r4.i);
    _r5.i = 10;
    _r4.i = global::java.lang.Character.digit((char) _r4.i, (int) _r5.i);
    _r4.i = (_r4.i << 24) >> 24;
    if (_r4.i < 0) goto label158;
    _r5.i = _r2.i + 2;
    _r5.i = ((global::java.lang.String) _r10_o).charAt((int) _r5.i);
    _r6.i = 125;
    if (_r5.i == _r6.i) goto label170;
    label158:;
    _r4.i = _r2.i + 1;
    _r3_o = ((global::java.lang.String) _r10_o).substring((int) _r3.i, (int) _r4.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    _r2.i = _r2.i + 1;
    goto label101;
    label170:;
    _r3_o = ((global::java.lang.String) _r10_o).substring((int) _r3.i, (int) _r2.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    _r3.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r4.i < _r3.i) goto label188;
    // Value=<missing argument>
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 62))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    label185:;
    _r2.i = _r2.i + 3;
    goto label101;
    label188:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r4.i];
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r3_o);
    goto label185;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.lang.String format(java.lang.String, java.lang.Object[])]
}

public static global::System.Object setLocale(global::java.util.Locale n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.util.ResourceBundle setLocale(java.util.Locale, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r3_o = n2;
    try {
// Red class access removed: org.apache.harmony.kernel.vm.VM bootCallerClassLoader
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.kernel.vm.VM bootCallerClassLoader");
    _r1_o = new global::org.apache.harmony.niochar.@internal.nls.Messages_21();
    ((global::org.apache.harmony.niochar.@internal.nls.Messages_21) _r1_o).@this((global::java.lang.String) _r3_o, (global::java.util.Locale) _r2_o, (global::java.lang.ClassLoader) _r0_o);
    _r2_o = global::java.security.AccessController.doPrivileged((global::java.security.PrivilegedAction) _r1_o);
    _r2_o = _r2_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.util.MissingResourceException) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    _r0_o = _r2_o;
    label16:;
    return (global::java.util.ResourceBundle) _r0_o;
    label17:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = null;
    goto label16;
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages: java.util.ResourceBundle setLocale(java.util.Locale, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages]
//XMLVM_END_WRAPPER[org.apache.harmony.niochar.internal.nls.Messages]

} // end of class: Messages

} // end of namespace: org.apache.harmony.niochar.@internal.nls
