// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.util {
public class SwipeBackSupport: global::java.lang.Object {
public bool _fsideSwipePotential;

public int _finitialDragY;

public int _finitialDragX;

public bool _fdragActivated;

public bool _ftransitionRunning;

public int _fcurrentX;

public global::com.codename1.ui.events.ActionListener _fpointerDragged;

public global::com.codename1.ui.events.ActionListener _fpointerPressed;

public global::com.codename1.ui.events.ActionListener _fpointerReleased;

public global::com.codename1.ui.Form _fdestinationForm;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void <init>()]
}

public static void bindBack(global::com.codename1.ui.Form n1, global::com.codename1.util.LazyValue n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void bindBack(com.codename1.ui.Form, com.codename1.util.LazyValue)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = n1;
    _r2_o = n2;
    _r0_o = new global::com.codename1.ui.util.SwipeBackSupport();
    ((global::com.codename1.ui.util.SwipeBackSupport) _r0_o).@this();
    ((global::com.codename1.ui.util.SwipeBackSupport) _r0_o).bind((global::com.codename1.ui.Form) _r1_o, (global::com.codename1.util.LazyValue) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void bindBack(com.codename1.ui.Form, com.codename1.util.LazyValue)]
}

public static void bindBack(global::com.codename1.util.LazyValue n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void bindBack(com.codename1.util.LazyValue)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0_o = new global::com.codename1.ui.util.SwipeBackSupport();
    ((global::com.codename1.ui.util.SwipeBackSupport) _r0_o).@this();
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1_o = ((global::com.codename1.ui.Display) _r1_o).getCurrent();
    ((global::com.codename1.ui.util.SwipeBackSupport) _r0_o).bind((global::com.codename1.ui.Form) _r1_o, (global::com.codename1.util.LazyValue) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void bindBack(com.codename1.util.LazyValue)]
}

public virtual void bind(global::com.codename1.ui.Form n1, global::com.codename1.util.LazyValue n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void bind(com.codename1.ui.Form, com.codename1.util.LazyValue)]
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
    _r0_o = new global::com.codename1.ui.util.SwipeBackSupport_21();
    ((global::com.codename1.ui.util.SwipeBackSupport_21) _r0_o).@this((global::com.codename1.ui.util.SwipeBackSupport) _r1_o, (global::com.codename1.ui.Form) _r2_o, (global::com.codename1.util.LazyValue) _r3_o);
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fpointerDragged = (global::com.codename1.ui.events.ActionListener) _r0_o;
    _r0_o = new global::com.codename1.ui.util.SwipeBackSupport_22();
    ((global::com.codename1.ui.util.SwipeBackSupport_22) _r0_o).@this((global::com.codename1.ui.util.SwipeBackSupport) _r1_o, (global::com.codename1.ui.Form) _r2_o);
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fpointerReleased = (global::com.codename1.ui.events.ActionListener) _r0_o;
    _r0_o = new global::com.codename1.ui.util.SwipeBackSupport_23();
    ((global::com.codename1.ui.util.SwipeBackSupport_23) _r0_o).@this((global::com.codename1.ui.util.SwipeBackSupport) _r1_o, (global::com.codename1.ui.Form) _r2_o);
    ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fpointerPressed = (global::com.codename1.ui.events.ActionListener) _r0_o;
    _r0_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fpointerDragged;
    ((global::com.codename1.ui.Form) _r2_o).addPointerDraggedListener((global::com.codename1.ui.events.ActionListener) _r0_o);
    _r0_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fpointerReleased;
    ((global::com.codename1.ui.Form) _r2_o).addPointerReleasedListener((global::com.codename1.ui.events.ActionListener) _r0_o);
    _r0_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r1_o)._fpointerPressed;
    ((global::com.codename1.ui.Form) _r2_o).addPointerPressedListener((global::com.codename1.ui.events.ActionListener) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void bind(com.codename1.ui.Form, com.codename1.util.LazyValue)]
}

public virtual void startBackTransition(global::com.codename1.ui.Form n1, global::com.codename1.ui.Form n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void startBackTransition(com.codename1.ui.Form, com.codename1.ui.Form)]
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
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r4_o = ((global::com.codename1.ui.Form) _r8_o).getTransitionOutAnimator();
    _r5.i = 1;
    _r3_o = ((global::com.codename1.ui.animations.Transition) _r4_o).copy(0!=_r5.i);
    _r4.i = ((_r3_o != null) && (_r3_o is global::com.codename1.ui.animations.CommonTransitions)) ? 1 : 0;
    if (_r4.i == 0) goto label90;
    _r2_o = ((global::com.codename1.ui.Form) _r7_o).getTransitionOutAnimator();
    _r4_o = global::com.codename1.ui.animations.CommonTransitions.createEmpty();
    ((global::com.codename1.ui.Form) _r7_o).setTransitionOutAnimator((global::com.codename1.ui.animations.Transition) _r4_o);
    _r1_o = new global::com.codename1.ui.util.SwipeBackSupport_24();
    ((global::com.codename1.ui.util.SwipeBackSupport_24) _r1_o).@this((global::com.codename1.ui.util.SwipeBackSupport) _r6_o);
    _r4_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r6_o)._fpointerDragged;
    ((global::com.codename1.ui.Form) _r1_o).addPointerDraggedListener((global::com.codename1.ui.events.ActionListener) _r4_o);
    _r4_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r6_o)._fpointerReleased;
    ((global::com.codename1.ui.Form) _r1_o).addPointerReleasedListener((global::com.codename1.ui.events.ActionListener) _r4_o);
    _r4_o = ((global::com.codename1.ui.util.SwipeBackSupport) _r6_o)._fpointerPressed;
    ((global::com.codename1.ui.Form) _r1_o).addPointerPressedListener((global::com.codename1.ui.events.ActionListener) _r4_o);
    _r4_o = global::com.codename1.ui.animations.CommonTransitions.createEmpty();
    ((global::com.codename1.ui.Form) _r1_o).setTransitionInAnimator((global::com.codename1.ui.animations.Transition) _r4_o);
    _r4_o = global::com.codename1.ui.animations.CommonTransitions.createEmpty();
    ((global::com.codename1.ui.Form) _r1_o).setTransitionOutAnimator((global::com.codename1.ui.animations.Transition) _r4_o);
    ((global::com.codename1.ui.Form) _r1_o).show();
    ((global::com.codename1.ui.Form) _r7_o).setTransitionOutAnimator((global::com.codename1.ui.animations.Transition) _r2_o);
    _r0_o = _r3_o;
    _r0_o = _r0_o;
    _r4_o = _r0_o;
    _r5_o = new global::com.codename1.ui.util.SwipeBackSupport_25();
    ((global::com.codename1.ui.util.SwipeBackSupport_25) _r5_o).@this((global::com.codename1.ui.util.SwipeBackSupport) _r6_o);
    ((global::com.codename1.ui.animations.CommonTransitions) _r4_o).setMotion((global::com.codename1.util.LazyValue) _r5_o);
    ((global::com.codename1.ui.animations.Transition) _r3_o).init((global::com.codename1.ui.Component) _r7_o, (global::com.codename1.ui.Component) _r8_o);
    ((global::com.codename1.ui.animations.Transition) _r3_o).initTransition();
    _r4_o = new global::com.codename1.ui.util.SwipeBackSupport_26();
    ((global::com.codename1.ui.util.SwipeBackSupport_26) _r4_o).@this((global::com.codename1.ui.util.SwipeBackSupport) _r6_o, (global::com.codename1.ui.animations.Transition) _r3_o);
    ((global::com.codename1.ui.Form) _r1_o).setGlassPane((global::com.codename1.ui.Painter) _r4_o);
    label90:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport: void startBackTransition(com.codename1.ui.Form, com.codename1.ui.Form)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.util.SwipeBackSupport]
//XMLVM_END_WRAPPER[com.codename1.ui.util.SwipeBackSupport]

} // end of class: SwipeBackSupport

} // end of namespace: com.codename1.ui.util
