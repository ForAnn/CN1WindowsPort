// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.html {
public class HTMLForm_2NamedCommand: global::com.codename1.ui.Command {
public global::com.codename1.ui.html.HTMLForm _fhtmlForm;

public global::java.lang.String _fkey;

public global::java.lang.String _fvalue;

public bool _fisSubmit;

public global::com.codename1.ui.html.HTMLForm _fthis_20;

public void @this(global::com.codename1.ui.html.HTMLForm n1, global::java.lang.String n2, global::java.lang.String n3, global::com.codename1.ui.html.HTMLForm n4, bool n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: void <init>(com.codename1.ui.html.HTMLForm, java.lang.String, java.lang.String, com.codename1.ui.html.HTMLForm, boolean)]
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
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4_o = n4;
    _r5.i = n5 ? 1 : 0;
    ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r0_o)._fthis_20 = (global::com.codename1.ui.html.HTMLForm) _r1_o;
    ((global::com.codename1.ui.Command) _r0_o).@this((global::java.lang.String) _r3_o);
    ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r0_o)._fkey = (global::java.lang.String) _r2_o;
    ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r0_o)._fhtmlForm = (global::com.codename1.ui.html.HTMLForm) _r4_o;
    ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r0_o)._fvalue = (global::java.lang.String) _r3_o;
    ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r0_o)._fisSubmit = 0!=_r5.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: void <init>(com.codename1.ui.html.HTMLForm, java.lang.String, java.lang.String, com.codename1.ui.html.HTMLForm, boolean)]
}

public override void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r4_o = n1;
    base.actionPerformed((global::com.codename1.ui.events.ActionEvent) _r4_o);
    _r0.i = ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r3_o)._fisSubmit ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r0_o = ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r3_o)._fhtmlForm;
    _r1_o = ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r3_o)._fkey;
    _r2_o = ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r3_o)._fvalue;
    ((global::com.codename1.ui.html.HTMLForm) _r0_o).submit((global::java.lang.String) _r1_o, (global::java.lang.String) _r2_o);
    label16:;
    return;
    label17:;
    _r0_o = ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r3_o)._fhtmlForm;
    ((global::com.codename1.ui.html.HTMLForm) _r0_o).reset();
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

public override void setCommandName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: void setCommandName(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r0_o)._fvalue = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: void setCommandName(java.lang.String)]
}

public override global::System.Object getCommandName(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: java.lang.String getCommandName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.html.HTMLForm_2NamedCommand) _r1_o)._fvalue;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand: java.lang.String getCommandName()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand]
//XMLVM_END_WRAPPER[com.codename1.ui.html.HTMLForm$NamedCommand]

} // end of class: HTMLForm_2NamedCommand

} // end of namespace: com.codename1.ui.html
