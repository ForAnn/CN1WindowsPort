// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.share {
public class FacebookShare_22_22: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.ui.Dialog _fval_2progress;

public global::com.codename1.share.FacebookShare_22 _fthis_21;

public void @this(global::com.codename1.share.FacebookShare_22 n1, global::com.codename1.ui.Dialog n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.FacebookShare$2$2: void <init>(com.codename1.share.FacebookShare$2, com.codename1.ui.Dialog)]
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
    ((global::com.codename1.share.FacebookShare_22_22) _r0_o)._fthis_21 = (global::com.codename1.share.FacebookShare_22) _r1_o;
    ((global::com.codename1.share.FacebookShare_22_22) _r0_o)._fval_2progress = (global::com.codename1.ui.Dialog) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.FacebookShare$2$2: void <init>(com.codename1.share.FacebookShare$2, com.codename1.ui.Dialog)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.FacebookShare$2$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.share.FacebookShare_22_22) _r1_o)._fval_2progress;
    ((global::com.codename1.ui.Dialog) _r0_o).dispose();
    _r0_o = ((global::com.codename1.share.FacebookShare_22_22) _r1_o)._fthis_21;
    _r0_o = ((global::com.codename1.share.FacebookShare_22) _r0_o)._fthis_20;
    ((global::com.codename1.share.FacebookShare) _r0_o).finish();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.FacebookShare$2$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.share.FacebookShare$2$2]
//XMLVM_END_WRAPPER[com.codename1.share.FacebookShare$2$2]

} // end of class: FacebookShare_22_22

} // end of namespace: com.codename1.share
