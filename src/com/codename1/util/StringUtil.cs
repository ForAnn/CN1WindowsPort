// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util {
public class StringUtil: global::java.lang.Object {
private static global::com.codename1.impl.CodenameOneImplementation _fimpl;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: void <init>()]
}

public static void setImplementation(global::com.codename1.impl.CodenameOneImplementation n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: void setImplementation(com.codename1.impl.CodenameOneImplementation)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = n1;
    global::com.codename1.util.StringUtil._fimpl = (global::com.codename1.impl.CodenameOneImplementation) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: void setImplementation(com.codename1.impl.CodenameOneImplementation)]
}

public static global::System.Object replaceAll(global::java.lang.String n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: java.lang.String replaceAll(java.lang.String, java.lang.String, java.lang.String)]
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
    _r5_o = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r4.i = -1;
    _r1_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r1_o).@this();
    _r0.i = 0;
    _r2_o = _r5_o;
    _r0.i = ((global::java.lang.String) _r2_o).indexOf((global::java.lang.String) _r6_o);
    if (_r0.i != _r4.i) goto label16;
    _r3_o = _r5_o;
    label15:;
    return (global::java.lang.String) _r3_o;
    label16:;
    if (_r0.i == _r4.i) goto label43;
    _r3.i = 0;
    _r3_o = ((global::java.lang.String) _r2_o).substring((int) _r3.i, (int) _r0.i);
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r3_o);
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r7_o);
    _r3.i = ((global::java.lang.String) _r6_o).length();
    _r3.i = _r3.i + _r0.i;
    _r2_o = ((global::java.lang.String) _r2_o).substring((int) _r3.i);
    _r0.i = ((global::java.lang.String) _r2_o).indexOf((global::java.lang.String) _r6_o);
    goto label16;
    label43:;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    _r3_o = ((global::java.lang.StringBuilder) _r1_o).toString();
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: java.lang.String replaceAll(java.lang.String, java.lang.String, java.lang.String)]
}

public static global::System.Object tokenizeString(global::java.lang.String n1, char n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: java.util.Vector tokenizeString(java.lang.String, char)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = n1;
    _r8.i = n2;
    _r5_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r5_o).@this();
    _r4.i = ((global::java.lang.String) _r7_o).length();
    _r3.i = 0;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r2.i = 0;
    label16:;
    if (_r2.i >= _r4.i) goto label58;
    _r1.i = ((global::java.lang.String) _r7_o).charAt((int) _r2.i);
    if (_r1.i != _r8.i) goto label53;
    if (_r3.i == 0) goto label33;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r8.i);
    _r3.i = 0;
    label30:;
    _r2.i = _r2.i + 1;
    goto label16;
    label33:;
    _r3.i = 1;
    _r6.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r6.i <= 0) goto label30;
    _r6_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.Vector) _r5_o).addElement((global::java.lang.Object) _r6_o);
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    goto label30;
    label53:;
    _r3.i = 0;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    goto label30;
    label58:;
    _r6.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r6.i <= 0) goto label71;
    _r6_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.Vector) _r5_o).addElement((global::java.lang.Object) _r6_o);
    label71:;
    return (global::java.util.Vector) _r5_o;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: java.util.Vector tokenizeString(java.lang.String, char)]
}

public static global::System.Object tokenizeString(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: java.util.Vector tokenizeString(java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = n1;
    _r8_o = n2;
    _r5.i = ((global::java.lang.String) _r8_o).length();
    _r6.i = 1;
    if (_r5.i != _r6.i) goto label17;
    _r5.i = 0;
    _r5.i = ((global::java.lang.String) _r8_o).charAt((int) _r5.i);
    _r5_o = global::com.codename1.util.StringUtil.tokenizeString((global::java.lang.String) _r7_o, (char) _r5.i);
    label16:;
    return (global::java.util.Vector) _r5_o;
    label17:;
    _r4_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r4_o).@this();
    _r3.i = ((global::java.lang.String) _r7_o).length();
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r2.i = 0;
    label32:;
    if (_r2.i >= _r3.i) goto label70;
    _r1.i = ((global::java.lang.String) _r7_o).charAt((int) _r2.i);
    _r5.i = ((global::java.lang.String) _r8_o).indexOf((int) _r1.i);
    _r6.i = -1;
    if (_r5.i <= _r6.i) goto label66;
    _r5.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r5.i <= 0) goto label63;
    _r5_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.Vector) _r4_o).addElement((global::java.lang.Object) _r5_o);
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    label63:;
    _r2.i = _r2.i + 1;
    goto label32;
    label66:;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    goto label63;
    label70:;
    _r5.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r5.i <= 0) goto label83;
    _r5_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.Vector) _r4_o).addElement((global::java.lang.Object) _r5_o);
    label83:;
    _r5_o = _r4_o;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: java.util.Vector tokenizeString(java.lang.String, java.lang.String)]
}

public static global::System.Object tokenize(global::java.lang.String n1, char n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: java.util.List tokenize(java.lang.String, char)]
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
    _r3.i = n2;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    _r1_o = global::com.codename1.util.StringUtil._fimpl;
    ((global::com.codename1.impl.CodenameOneImplementation) _r1_o).splitString((global::java.lang.String) _r2_o, (char) _r3.i, (global::java.util.ArrayList) _r0_o);
    return (global::java.util.List) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: java.util.List tokenize(java.lang.String, char)]
}

public static global::System.Object tokenize(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil: java.util.List tokenize(java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = n1;
    _r8_o = n2;
    _r5.i = ((global::java.lang.String) _r8_o).length();
    _r6.i = 1;
    if (_r5.i != _r6.i) goto label17;
    _r5.i = 0;
    _r5.i = ((global::java.lang.String) _r8_o).charAt((int) _r5.i);
    _r5_o = global::com.codename1.util.StringUtil.tokenize((global::java.lang.String) _r7_o, (char) _r5.i);
    label16:;
    return (global::java.util.List) _r5_o;
    label17:;
    _r4_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r4_o).@this();
    _r3.i = ((global::java.lang.String) _r7_o).length();
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r2.i = 0;
    label32:;
    if (_r2.i >= _r3.i) goto label70;
    _r1.i = ((global::java.lang.String) _r7_o).charAt((int) _r2.i);
    _r5.i = ((global::java.lang.String) _r8_o).indexOf((int) _r1.i);
    _r6.i = -1;
    if (_r5.i <= _r6.i) goto label66;
    _r5.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r5.i <= 0) goto label63;
    _r5_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.ArrayList) _r4_o).add((global::java.lang.Object) _r5_o);
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    label63:;
    _r2.i = _r2.i + 1;
    goto label32;
    label66:;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    goto label63;
    label70:;
    _r5.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r5.i <= 0) goto label83;
    _r5_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    ((global::java.util.ArrayList) _r4_o).add((global::java.lang.Object) _r5_o);
    label83:;
    _r5_o = _r4_o;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil: java.util.List tokenize(java.lang.String, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.StringUtil]
//XMLVM_END_WRAPPER[com.codename1.util.StringUtil]

} // end of class: StringUtil

} // end of namespace: com.codename1.util
