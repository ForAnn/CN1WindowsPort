// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.impl {
public class CodenameOneImplementation_21: global::java.lang.Object,global::java.lang.Runnable {
public bool _fval_2focus;

public global::com.codename1.impl.CodenameOneImplementation _fthis_20;

public void @this(global::com.codename1.impl.CodenameOneImplementation n1, bool n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$1: void <init>(com.codename1.impl.CodenameOneImplementation, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    ((global::com.codename1.impl.CodenameOneImplementation_21) _r0_o)._fthis_20 = (global::com.codename1.impl.CodenameOneImplementation) _r1_o;
    ((global::com.codename1.impl.CodenameOneImplementation_21) _r0_o)._fval_2focus = 0!=_r2.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$1: void <init>(com.codename1.impl.CodenameOneImplementation, boolean)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$1: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation_21) _r1_o)._fthis_20;
    _r0_o = global::com.codename1.impl.CodenameOneImplementation.access_2000((global::com.codename1.impl.CodenameOneImplementation) _r0_o);
    if (_r0_o == null) goto label30;
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation_21) _r1_o)._fthis_20;
    _r0_o = global::com.codename1.impl.CodenameOneImplementation.access_2000((global::com.codename1.impl.CodenameOneImplementation) _r0_o);
    ((global::com.codename1.ui.Component) _r0_o).repaint();
    _r0.i = ((global::com.codename1.impl.CodenameOneImplementation_21) _r1_o)._fval_2focus ? 1 : 0;
    if (_r0.i == 0) goto label30;
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation_21) _r1_o)._fthis_20;
    _r0_o = global::com.codename1.impl.CodenameOneImplementation.access_2000((global::com.codename1.impl.CodenameOneImplementation) _r0_o);
    ((global::com.codename1.ui.Component) _r0_o).requestFocus();
    label30:;
    return;
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.impl.CodenameOneImplementation$1]
//XMLVM_END_WRAPPER[com.codename1.impl.CodenameOneImplementation$1]

} // end of class: CodenameOneImplementation_21

} // end of namespace: com.codename1.impl
