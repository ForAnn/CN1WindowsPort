// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.share {
public class EmailShare_21_22_21_22: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::org.xmlvm._nArrayAdapter<global::System.Object> _fval_2f;

public global::com.codename1.share.EmailShare_21_22_21 _fthis_23;

public void @this(global::com.codename1.share.EmailShare_21_22_21 n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare$1$2$1$2: void <init>(com.codename1.share.EmailShare$1$2$1, com.codename1.share.ShareForm[])]
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
    ((global::com.codename1.share.EmailShare_21_22_21_22) _r0_o)._fthis_23 = (global::com.codename1.share.EmailShare_21_22_21) _r1_o;
    ((global::com.codename1.share.EmailShare_21_22_21_22) _r0_o)._fval_2f = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare$1$2$1$2: void <init>(com.codename1.share.EmailShare$1$2$1, com.codename1.share.ShareForm[])]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare$1$2$1$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 0;
    _r2.i = 1;
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r2.i]);
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21_22) _r4_o)._fval_2f;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r3.i];
    _r2_o = ((global::com.codename1.share.ShareForm) _r2_o).getTo();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r3.i] = _r2_o;
    _r0_o = new global::com.codename1.messaging.Message();
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21_22) _r4_o)._fthis_23;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21) _r2_o)._fthis_22;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22) _r2_o)._fthis_21;
    _r2_o = ((global::com.codename1.share.EmailShare_21) _r2_o)._fval_2toShare;
    ((global::com.codename1.messaging.Message) _r0_o).@this((global::java.lang.String) _r2_o);
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21_22) _r4_o)._fthis_23;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21) _r2_o)._fthis_22;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22) _r2_o)._fthis_21;
    _r2_o = ((global::com.codename1.share.EmailShare_21) _r2_o)._fval_2image;
    ((global::com.codename1.messaging.Message) _r0_o).setAttachment((global::java.lang.String) _r2_o);
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21_22) _r4_o)._fthis_23;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21) _r2_o)._fthis_22;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22) _r2_o)._fthis_21;
    _r2_o = ((global::com.codename1.share.EmailShare_21) _r2_o)._fval_2mimeType;
    ((global::com.codename1.messaging.Message) _r0_o).setMimeType((global::java.lang.String) _r2_o);
    // Value=share
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101))}));
    global::com.codename1.messaging.Message.sendMessage((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::java.lang.String) _r2_o, (global::com.codename1.messaging.Message) _r0_o);
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21_22) _r4_o)._fthis_23;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22_21) _r2_o)._fthis_22;
    _r2_o = ((global::com.codename1.share.EmailShare_21_22) _r2_o)._fthis_21;
    _r2_o = ((global::com.codename1.share.EmailShare_21) _r2_o)._fthis_20;
    ((global::com.codename1.share.EmailShare) _r2_o).finish();
    return;
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare$1$2$1$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.share.EmailShare$1$2$1$2]
//XMLVM_END_WRAPPER[com.codename1.share.EmailShare$1$2$1$2]

} // end of class: EmailShare_21_22_21_22

} // end of namespace: com.codename1.share
