// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLComponent_23: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.html.HTMLComponent _fthis_20;

public void @this(global::com.codename1.ui.html.HTMLComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLComponent$3: void <init>(com.codename1.ui.html.HTMLComponent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.html.HTMLComponent_23) _r0_o)._fthis_20 = (global::com.codename1.ui.html.HTMLComponent) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLComponent$3: void <init>(com.codename1.ui.html.HTMLComponent)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLComponent$3: void run()]
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
    _r4.i = -1;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2100((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    _r2.i = ((global::com.codename1.ui.html.ResourceThreadQueue) _r2_o).getCSSCount();
    if (_r2.i != _r4.i) goto label18;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    ((global::com.codename1.ui.html.HTMLComponent) _r2_o).displayPage();
    label18:;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2100((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    _r2.i = ((global::com.codename1.ui.html.ResourceThreadQueue) _r2_o).getQueueSize();
    if (_r2.i != 0) goto label90;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r3.i = 4;
    ((global::com.codename1.ui.html.HTMLComponent) _r2_o).setPageStatus((int) _r3.i);
    label36:;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2200((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    if (_r2_o == null) goto label89;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2200((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    _r3.i = 35;
    _r1.i = ((global::java.lang.String) _r2_o).indexOf((int) _r3.i);
    if (_r1.i == _r4.i) goto label89;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2200((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    _r2.i = ((global::java.lang.String) _r2_o).length();
    _r3.i = _r1.i + 1;
    if (_r2.i <= _r3.i) goto label89;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2200((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    _r3.i = _r1.i + 1;
    _r0_o = ((global::java.lang.String) _r2_o).substring((int) _r3.i);
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    ((global::com.codename1.ui.html.HTMLComponent) _r2_o).goToAnchor((global::java.lang.String) _r0_o);
    label89:;
    return;
    label90:;
    _r2_o = ((global::com.codename1.ui.html.HTMLComponent_23) _r5_o)._fthis_20;
    _r2_o = global::com.codename1.ui.html.HTMLComponent.access_2100((global::com.codename1.ui.html.HTMLComponent) _r2_o);
    ((global::com.codename1.ui.html.ResourceThreadQueue) _r2_o).startRunning();
    goto label36;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLComponent$3: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLComponent$3]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLComponent$3]

} // end of class: HTMLComponent_23

} // end of namespace: com.codename1.ui.html
