// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.push {
public class PushInboxUI_22: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.push.PushInboxUI _fthis_20;

public void @this(global::com.codename1.push.PushInboxUI n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.push.PushInboxUI$2: void <init>(com.codename1.push.PushInboxUI)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.push.PushInboxUI_22) _r0_o)._fthis_20 = (global::com.codename1.push.PushInboxUI) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.push.PushInboxUI$2: void <init>(com.codename1.push.PushInboxUI)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.push.PushInboxUI$2: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::com.codename1.push.PushInbox.getInstance();
    ((global::com.codename1.push.PushInbox) _r0_o).syncInbox();
    return;
//XMLVM_END_WRAPPER[com.codename1.push.PushInboxUI$2: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.push.PushInboxUI$2]
//XMLVM_END_WRAPPER[com.codename1.push.PushInboxUI$2]

} // end of class: PushInboxUI_22

} // end of namespace: com.codename1.push
