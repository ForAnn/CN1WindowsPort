// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.facebook {
public class FaceBookAccess_210: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.facebook.Post _fval_2post;

public global::com.codename1.ui.events.ActionListener _fval_2callback;

public global::com.codename1.facebook.FaceBookAccess _fthis_20;

public void @this(global::com.codename1.facebook.FaceBookAccess n1, global::com.codename1.facebook.Post n2, global::com.codename1.ui.events.ActionListener n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$10: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.facebook.Post, com.codename1.ui.events.ActionListener)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::com.codename1.facebook.FaceBookAccess_210) _r0_o)._fthis_20 = (global::com.codename1.facebook.FaceBookAccess) _r1_o;
    ((global::com.codename1.facebook.FaceBookAccess_210) _r0_o)._fval_2post = (global::com.codename1.facebook.Post) _r2_o;
    ((global::com.codename1.facebook.FaceBookAccess_210) _r0_o)._fval_2callback = (global::com.codename1.ui.events.ActionListener) _r3_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$10: void <init>(com.codename1.facebook.FaceBookAccess, com.codename1.facebook.Post, com.codename1.ui.events.ActionListener)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$10: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    _r0_o = _r5_o;
    _r0_o = _r0_o;
    _r3_o = _r0_o;
    _r2_o = ((global::com.codename1.io.NetworkEvent) _r3_o).getMetaData();
    _r2_o = _r2_o;
    _r3.i = 0;
    _r1_o = ((global::java.util.Vector) _r2_o).elementAt((int) _r3.i);
    _r1_o = _r1_o;
    _r3_o = ((global::com.codename1.facebook.FaceBookAccess_210) _r4_o)._fval_2post;
    if (_r3_o == null) goto label26;
    _r3_o = ((global::com.codename1.facebook.FaceBookAccess_210) _r4_o)._fval_2post;
    ((global::com.codename1.facebook.Post) _r3_o).copy((global::java.util.Hashtable) _r1_o);
    label26:;
    _r3_o = ((global::com.codename1.facebook.FaceBookAccess_210) _r4_o)._fval_2callback;
    if (_r3_o == null) goto label35;
    _r3_o = ((global::com.codename1.facebook.FaceBookAccess_210) _r4_o)._fval_2callback;
    ((global::com.codename1.ui.events.ActionListener) _r3_o).actionPerformed((global::com.codename1.ui.events.ActionEvent) _r5_o);
    label35:;
    return;
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$10: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.facebook.FaceBookAccess$10]
//XMLVM_END_WRAPPER[com.codename1.facebook.FaceBookAccess$10]

} // end of class: FaceBookAccess_210

} // end of namespace: com.codename1.facebook
