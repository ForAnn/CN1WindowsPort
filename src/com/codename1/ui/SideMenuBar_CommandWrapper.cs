// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_2CommandWrapper: global::com.codename1.ui.Command {
public global::com.codename1.ui.Command _fcmd;

public global::com.codename1.ui.SideMenuBar _fthis_20;

public void @this(global::com.codename1.ui.SideMenuBar n1, global::com.codename1.ui.Command n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void <init>(com.codename1.ui.SideMenuBar, com.codename1.ui.Command)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r3_o)._fthis_20 = (global::com.codename1.ui.SideMenuBar) _r4_o;
    _r0_o = ((global::com.codename1.ui.Command) _r5_o).getCommandName();
    _r1_o = ((global::com.codename1.ui.Command) _r5_o).getIcon();
    _r2.i = ((global::com.codename1.ui.Command) _r5_o).getId();
    ((global::com.codename1.ui.Command) _r3_o).@this((global::java.lang.String) _r0_o, (global::com.codename1.ui.Image) _r1_o, (int) _r2.i);
    ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r3_o)._fcmd = (global::com.codename1.ui.Command) _r5_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void <init>(com.codename1.ui.SideMenuBar, com.codename1.ui.Command)]
}

public override global::System.Object getClientProperty(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: java.lang.Object getClientProperty(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r1_o)._fcmd;
    _r0_o = ((global::com.codename1.ui.Command) _r0_o).getClientProperty((global::java.lang.String) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: java.lang.Object getClientProperty(java.lang.String)]
}

public override void putClientProperty(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void putClientProperty(java.lang.String, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r1_o)._fcmd;
    ((global::com.codename1.ui.Command) _r0_o).putClientProperty((global::java.lang.String) _r2_o, (global::java.lang.Object) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void putClientProperty(java.lang.String, java.lang.Object)]
}

public override bool isEnabled(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: boolean isEnabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r1_o)._fcmd;
    _r0.i = ((global::com.codename1.ui.Command) _r0_o).isEnabled() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: boolean isEnabled()]
}

public override void setEnabled(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void setEnabled(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r1_o)._fcmd;
    ((global::com.codename1.ui.Command) _r0_o).setEnabled(0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void setEnabled(boolean)]
}

public override void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fthis_20;
    _r0.i = ((global::com.codename1.ui.SideMenuBar) _r0_o)._ftransitionRunning ? 1 : 0;
    if (_r0.i == 0) goto label7;
    label6:;
    return;
    label7:;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fthis_20;
    ((global::com.codename1.ui.SideMenuBar) _r0_o).closeMenu();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fthis_20;
    global::com.codename1.ui.SideMenuBar.access_2900((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r0_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_21000((global::com.codename1.ui.SideMenuBar) _r1_o);
    ((global::com.codename1.ui.Form) _r0_o).addShowListener((global::com.codename1.ui.events.ActionListener) _r1_o);
    _r0_o = new global::java.lang.Thread();
    _r1_o = new global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter();
    ((global::com.codename1.ui.SideMenuBar_2CommandWrapper_2ShowWaiter) _r1_o).@this((global::com.codename1.ui.SideMenuBar_2CommandWrapper) _r2_o);
    ((global::java.lang.Thread) _r0_o).@this((global::java.lang.Runnable) _r1_o);
    ((global::java.lang.Thread) _r0_o).start();
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$CommandWrapper]

} // end of class: SideMenuBar_2CommandWrapper

} // end of namespace: com.codename1.ui
