// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class OnOffSwitch_22: global::java.lang.Object,global::com.codename1.ui.animations.Animation {
public global::com.codename1.ui.animations.Motion _fval_2current;

public bool _fval_2value;

public global::com.codename1.components.OnOffSwitch _fthis_20;

public void @this(global::com.codename1.components.OnOffSwitch n1, global::com.codename1.ui.animations.Motion n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.OnOffSwitch$2: void <init>(com.codename1.components.OnOffSwitch, com.codename1.ui.animations.Motion, boolean)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3 ? 1 : 0;
    ((global::com.codename1.components.OnOffSwitch_22) _r0_o)._fthis_20 = (global::com.codename1.components.OnOffSwitch) _r1_o;
    ((global::com.codename1.components.OnOffSwitch_22) _r0_o)._fval_2current = (global::com.codename1.ui.animations.Motion) _r2_o;
    ((global::com.codename1.components.OnOffSwitch_22) _r0_o)._fval_2value = 0!=_r3.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.components.OnOffSwitch$2: void <init>(com.codename1.components.OnOffSwitch, com.codename1.ui.animations.Motion, boolean)]
}

public virtual bool animate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.OnOffSwitch$2: boolean animate()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r3.i = 0;
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    _r2_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fval_2current;
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r2_o).getValue();
    global::com.codename1.components.OnOffSwitch.access_2102((global::com.codename1.components.OnOffSwitch) _r1_o, (int) _r2.i);
    _r1.i = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fval_2value ? 1 : 0;
    if (_r1.i == 0) goto label22;
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    _r2.i = -1;
    global::com.codename1.components.OnOffSwitch.access_2128((global::com.codename1.components.OnOffSwitch) _r1_o, (int) _r2.i);
    label22:;
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    _r2.i = 1;
    global::com.codename1.components.OnOffSwitch.access_2202((global::com.codename1.components.OnOffSwitch) _r1_o, 0!=_r2.i);
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fval_2current;
    _r1.i = ((global::com.codename1.ui.animations.Motion) _r1_o).isFinished() ? 1 : 0;
    if (_r1.i == 0) goto label59;
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    global::com.codename1.components.OnOffSwitch.access_2202((global::com.codename1.components.OnOffSwitch) _r1_o, 0!=_r3.i);
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    _r0_o = ((global::com.codename1.components.OnOffSwitch) _r1_o).getComponentForm();
    if (_r0_o == null) goto label52;
    ((global::com.codename1.ui.Form) _r0_o).deregisterAnimated((global::com.codename1.ui.animations.Animation) _r4_o);
    label52:;
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    _r2.i = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fval_2value ? 1 : 0;
    ((global::com.codename1.components.OnOffSwitch) _r1_o).setValue(0!=_r2.i);
    label59:;
    _r1_o = ((global::com.codename1.components.OnOffSwitch_22) _r4_o)._fthis_20;
    ((global::com.codename1.components.OnOffSwitch) _r1_o).repaint();
    return _r3.i!=0;
//XMLVM_END_WRAPPER[com.codename1.components.OnOffSwitch$2: boolean animate()]
}

public virtual void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.OnOffSwitch$2: void paint(com.codename1.ui.Graphics)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.components.OnOffSwitch$2: void paint(com.codename1.ui.Graphics)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.OnOffSwitch$2]
//XMLVM_END_WRAPPER[com.codename1.components.OnOffSwitch$2]

} // end of class: OnOffSwitch_22

} // end of namespace: com.codename1.components
