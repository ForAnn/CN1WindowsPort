// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_28_21_21: global::java.lang.Object,global::java.lang.Runnable {
public global::com.codename1.ui.SideMenuBar_28_21 _fthis_22;

public void @this(global::com.codename1.ui.SideMenuBar_28_21 n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$1$1: void <init>(com.codename1.ui.SideMenuBar$8$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.SideMenuBar_28_21_21) _r0_o)._fthis_22 = (global::com.codename1.ui.SideMenuBar_28_21) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$1$1: void <init>(com.codename1.ui.SideMenuBar$8$1)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$1$1: void run()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    label0:;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0_o = ((global::com.codename1.ui.Display) _r0_o).getCurrent();
    _r1_o = ((global::com.codename1.ui.SideMenuBar_28_21_21) _r2_o)._fthis_22;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_28_21) _r1_o)._fthis_21;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_28) _r1_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r1_o);
    if (_r0_o == _r1_o) goto label28;
    _r0.l = 40L;
    try {
    global::java.lang.Thread.sleep((long) _r0.l);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label26;
        }
        throw ex;
    } // end catch
    goto label0;
    label26:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    goto label0;
    label28:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$1$1: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$8$1$1]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$8$1$1]

} // end of class: SideMenuBar_28_21_21

} // end of namespace: com.codename1.ui
