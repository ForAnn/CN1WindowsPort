// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class Container_21: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.Component _fval_2cmp;

public global::com.codename1.ui.Container _fthis_20;

public void @this(global::com.codename1.ui.Container n1, global::com.codename1.ui.Component n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Container$1: void <init>(com.codename1.ui.Container, com.codename1.ui.Component)]
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
    ((global::com.codename1.ui.Container_21) _r0_o)._fthis_20 = (global::com.codename1.ui.Container) _r1_o;
    ((global::com.codename1.ui.Container_21) _r0_o)._fval_2cmp = (global::com.codename1.ui.Component) _r2_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Container$1: void <init>(com.codename1.ui.Container, com.codename1.ui.Component)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Container$1: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.Container_21) _r2_o)._fval_2cmp;
    _r1.i = 0;
    ((global::com.codename1.ui.Component) _r0_o).refreshTheme(0!=_r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.Container$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.Container$1]
//XMLVM_END_WRAPPER[com.codename1.ui.Container$1]

} // end of class: Container_21

} // end of namespace: com.codename1.ui
