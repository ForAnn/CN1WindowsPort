// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class SliderBridge: global::com.codename1.ui.Slider {
private global::org.xmlvm._nArrayAdapter<global::System.Object> _fsources;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::com.codename1.ui.Slider) _r1_o).@this();
    _r0_o = null;
    _r0_o = _r0_o;
    global::com.codename1.components.SliderBridge.bindProgress((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o, (global::com.codename1.ui.Slider) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge: void <init>()]
}

public static void bindProgress(global::com.codename1.io.ConnectionRequest n1, global::com.codename1.ui.Slider n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge: void bindProgress(com.codename1.io.ConnectionRequest, com.codename1.ui.Slider)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r3_o = n2;
    if (_r2_o != null) goto label9;
    _r2_o = null;
    _r2_o = _r2_o;
    global::com.codename1.components.SliderBridge.bindProgress((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::com.codename1.ui.Slider) _r3_o);
    label8:;
    return;
    label9:;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    global::com.codename1.components.SliderBridge.bindProgress((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o, (global::com.codename1.ui.Slider) _r3_o);
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge: void bindProgress(com.codename1.io.ConnectionRequest, com.codename1.ui.Slider)]
}

public static void bindProgress(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::com.codename1.ui.Slider n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge: void bindProgress(com.codename1.io.ConnectionRequest[], com.codename1.ui.Slider)]
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
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = n1;
    _r8_o = n2;
    _r4_o = null;
    _r2.i = 1000;
    if (_r7_o == null) goto label24;
    _r4_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r4_o).@this();
    _r0.i = 0;
    label11:;
    _r5.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r0.i >= _r5.i) goto label22;
    _r5_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r0.i];
    ((global::java.util.Vector) _r4_o).addElement((global::java.lang.Object) _r5_o);
    _r0.i = _r0.i + 1;
    goto label11;
    label22:;
    _r5.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r2.i = _r2.i / _r5.i;
    label24:;
    _r3_o = _r4_o;
    _r1.i = _r2.i;
    _r5_o = global::com.codename1.io.NetworkManager.getInstance();
    _r6_o = new global::com.codename1.components.SliderBridge_21();
    ((global::com.codename1.components.SliderBridge_21) _r6_o).@this((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o, (global::java.util.Vector) _r3_o, (global::com.codename1.ui.Slider) _r8_o, (int) _r1.i);
    ((global::com.codename1.io.NetworkManager) _r5_o).addProgressListener((global::com.codename1.ui.events.ActionListener) _r6_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge: void bindProgress(com.codename1.io.ConnectionRequest[], com.codename1.ui.Slider)]
}

public void @this(global::com.codename1.io.ConnectionRequest n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge: void <init>(com.codename1.io.ConnectionRequest)]
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
    ((global::com.codename1.ui.Slider) _r2_o).@this();
    if (_r3_o == null) goto label13;
    _r0.i = 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    ((global::com.codename1.components.SliderBridge) _r2_o)._fsources = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    label13:;
    _r0_o = ((global::com.codename1.components.SliderBridge) _r2_o)._fsources;
    global::com.codename1.components.SliderBridge.bindProgress((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o, (global::com.codename1.ui.Slider) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge: void <init>(com.codename1.io.ConnectionRequest)]
}

public void @this(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge: void <init>(com.codename1.io.ConnectionRequest[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.Slider) _r0_o).@this();
    ((global::com.codename1.components.SliderBridge) _r0_o)._fsources = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    global::com.codename1.components.SliderBridge.bindProgress((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::com.codename1.ui.Slider) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge: void <init>(com.codename1.io.ConnectionRequest[])]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge]
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge]

} // end of class: SliderBridge

} // end of namespace: com.codename1.components
