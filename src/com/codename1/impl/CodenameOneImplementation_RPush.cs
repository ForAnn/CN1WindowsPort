// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.impl {
public class CodenameOneImplementation_2RPush: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.impl.CodenameOneImplementation _fthis_20;

public void @this(global::com.codename1.impl.CodenameOneImplementation n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$RPush: void <init>(com.codename1.impl.CodenameOneImplementation)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.impl.CodenameOneImplementation_2RPush) _r0_o)._fthis_20 = (global::com.codename1.impl.CodenameOneImplementation) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$RPush: void <init>(com.codename1.impl.CodenameOneImplementation)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$RPush: void run()]
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
    _r5_o = this;
    _r3.l = -1L;
    // Value=push_id
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 95)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100))}));
    _r0.l = global::com.codename1.io.Preferences.get((global::java.lang.String) _r2_o, (long) _r3.l);
    _r2.i = _r0.l > _r3.l ? 1 : (_r0.l == _r3.l ? 0 : -1);
    if (_r2.i <= 0) goto label44;
    _r2_o = global::com.codename1.impl.CodenameOneImplementation.access_2100();
    if (_r2_o == null) goto label44;
    _r2_o = global::com.codename1.impl.CodenameOneImplementation.access_2100();
    _r3_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r3_o).@this();
    // Value=
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((global::java.lang.String) _r4_o);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).append((long) _r0.l);
    _r3_o = ((global::java.lang.StringBuilder) _r3_o).toString();
    ((global::com.codename1.push.PushCallback) _r2_o).registeredForPush((global::java.lang.String) _r3_o);
    label44:;
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$RPush: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$RPush]
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$RPush]

} // end of class: CodenameOneImplementation_2RPush

} // end of namespace: com.codename1.impl
