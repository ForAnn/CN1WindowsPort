// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class SliderBridge_21: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
private float _fcurrentLength;

private int _fsoFar;

public global::org.xmlvm._nArrayAdapter<global::System.Object> _fval_2sources;

public global::java.util.Vector _fval_2sourceVec;

public global::com.codename1.ui.Slider _fval_2s;

public int _fval_2portionPerSource;

public void @this(global::org.xmlvm._nArrayAdapter<global::System.Object> n1, global::java.util.Vector n2, global::com.codename1.ui.Slider n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge$1: void <init>(com.codename1.io.ConnectionRequest[], java.util.Vector, com.codename1.ui.Slider, int)]
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
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4.i = n4;
    ((global::com.codename1.components.SliderBridge_21) _r0_o)._fval_2sources = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
    ((global::com.codename1.components.SliderBridge_21) _r0_o)._fval_2sourceVec = (global::java.util.Vector) _r2_o;
    ((global::com.codename1.components.SliderBridge_21) _r0_o)._fval_2s = (global::com.codename1.ui.Slider) _r3_o;
    ((global::com.codename1.components.SliderBridge_21) _r0_o)._fval_2portionPerSource = _r4.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge$1: void <init>(com.codename1.io.ConnectionRequest[], java.util.Vector, com.codename1.ui.Slider, int)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
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
    _r7_o = this;
    _r8_o = n1;
    _r6.i = 1;
    _r5.i = 0;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2sources;
    if (_r3_o == null) goto label19;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2sourceVec;
    _r4_o = ((global::com.codename1.ui.events.ActionEvent) _r8_o).getSource();
    _r3.i = ((global::java.util.Vector) _r3_o).contains((global::java.lang.Object) _r4_o) ? 1 : 0;
    if (_r3.i != 0) goto label19;
    label18:;
    return;
    label19:;
    _r0_o = _r8_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r3.i = ((global::com.codename1.io.NetworkEvent) _r1_o).getProgressType();
    switch (_r3.i) {
    case 1: goto label31;
    case 2: goto label68;
    case 3: goto label68;
    case 4: goto label37;
    }
    goto label18;
    label31:;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    ((global::com.codename1.ui.Slider) _r3_o).setInfinite(0!=_r6.i);
    goto label18;
    label37:;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    ((global::com.codename1.ui.Slider) _r3_o).setInfinite(0!=_r5.i);
    _r3.i = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fsoFar;
    _r4.i = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2portionPerSource;
    _r3.i = _r3.i + _r4.i;
    ((global::com.codename1.components.SliderBridge_21) _r7_o)._fsoFar = _r3.i;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    _r4.i = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fsoFar;
    ((global::com.codename1.ui.Slider) _r3_o).setProgress((int) _r4.i);
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2sources;
    if (_r3_o == null) goto label18;
    _r3_o = global::com.codename1.io.NetworkManager.getInstance();
    ((global::com.codename1.io.NetworkManager) _r3_o).removeProgressListener((global::com.codename1.ui.events.ActionListener) _r7_o);
    goto label18;
    label68:;
    _r3.i = ((global::com.codename1.io.NetworkEvent) _r1_o).getLength();
    if (_r3.i <= 0) goto label117;
    _r3.i = ((global::com.codename1.io.NetworkEvent) _r1_o).getLength();
    _r3.f = (float) _r3.i;
    ((global::com.codename1.components.SliderBridge_21) _r7_o)._fcurrentLength = _r3.f;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    _r4.i = 1000;
    ((global::com.codename1.ui.Slider) _r3_o).setMaxValue((int) _r4.i);
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    ((global::com.codename1.ui.Slider) _r3_o).setInfinite(0!=_r5.i);
    _r3.i = ((global::com.codename1.io.NetworkEvent) _r1_o).getSentReceived();
    _r2.f = (float) _r3.i;
    _r3.f = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fcurrentLength;
    _r3.f = _r2.f / _r3.f;
    _r4.i = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2portionPerSource;
    _r4.f = (float) _r4.i;
    _r2.f = _r3.f * _r4.f;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    _r4.i = (int) _r2.f;
    _r5.i = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fsoFar;
    _r4.i = _r4.i + _r5.i;
    ((global::com.codename1.ui.Slider) _r3_o).setProgress((int) _r4.i);
    goto label18;
    label117:;
    _r3_o = ((global::com.codename1.components.SliderBridge_21) _r7_o)._fval_2s;
    ((global::com.codename1.ui.Slider) _r3_o).setInfinite(0!=_r6.i);
    goto label18;
    label124:;
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.SliderBridge$1]
//XMLVM_END_WRAPPER[com.codename1.components.SliderBridge$1]

} // end of class: SliderBridge_21

} // end of namespace: com.codename1.components
