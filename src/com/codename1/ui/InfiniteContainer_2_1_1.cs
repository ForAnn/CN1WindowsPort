// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class InfiniteContainer_22_21_21: global::java.lang.Object,global::java.lang.Runnable {
public global::org.xmlvm._nArrayAdapter<global::System.Object> _fval_2cmps;

public global::com.codename1.ui.InfiniteContainer_22_21 _fthis_22;

public void @this(global::com.codename1.ui.InfiniteContainer_22_21 n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer$2$1$1: void <init>(com.codename1.ui.InfiniteContainer$2$1, com.codename1.ui.Component[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r0_o)._fthis_22 = (global::com.codename1.ui.InfiniteContainer_22_21) _r1_o;
    ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r0_o)._fval_2cmps = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer$2$1$1: void <init>(com.codename1.ui.InfiniteContainer$2$1, com.codename1.ui.Component[])]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer$2$1$1: void run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r4.i = 0;
    _r0_o = ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r5_o)._fthis_22;
    _r0_o = ((global::com.codename1.ui.InfiniteContainer_22_21) _r0_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.InfiniteContainer_22) _r0_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r5_o)._fval_2cmps;
    _r2_o = ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r5_o)._fval_2cmps;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r3_o = ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r5_o)._fthis_22;
    _r3_o = ((global::com.codename1.ui.InfiniteContainer_22_21) _r3_o)._fthis_21;
    _r3_o = ((global::com.codename1.ui.InfiniteContainer_22) _r3_o)._fthis_20;
    _r3.i = global::com.codename1.ui.InfiniteContainer.access_2100((global::com.codename1.ui.InfiniteContainer) _r3_o);
    if (_r2.i != _r3.i) goto label38;
    _r2.i = 1;
    label25:;
    global::com.codename1.components.InfiniteScrollAdapter.addMoreComponents((global::com.codename1.ui.Container) _r0_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, 0!=_r2.i);
    _r0_o = ((global::com.codename1.ui.InfiniteContainer_22_21_21) _r5_o)._fthis_22;
    _r0_o = ((global::com.codename1.ui.InfiniteContainer_22_21) _r0_o)._fthis_21;
    _r0_o = ((global::com.codename1.ui.InfiniteContainer_22) _r0_o)._fthis_20;
    global::com.codename1.ui.InfiniteContainer.access_2002((global::com.codename1.ui.InfiniteContainer) _r0_o, 0!=_r4.i);
    return;
    label38:;
    _r2.i = _r4.i;
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer$2$1$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.InfiniteContainer$2$1$1]
//XMLVM_END_WRAPPER[com.codename1.ui.InfiniteContainer$2$1$1]

} // end of class: InfiniteContainer_22_21_21

} // end of namespace: com.codename1.ui
