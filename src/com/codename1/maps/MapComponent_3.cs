// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps {
public class MapComponent_23: global::java.lang.Object,global::java.lang.Runnable {
public int _fval_2currTapCount;

public int _fval_2tapX;

public int _fval_2tapY;

public global::com.codename1.maps.MapComponent _fthis_20;

public void @this(global::com.codename1.maps.MapComponent n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$3: void <init>(com.codename1.maps.MapComponent, int, int, int)]
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
    _r2.i = n2;
    _r3.i = n3;
    _r4.i = n4;
    ((global::com.codename1.maps.MapComponent_23) _r0_o)._fthis_20 = (global::com.codename1.maps.MapComponent) _r1_o;
    ((global::com.codename1.maps.MapComponent_23) _r0_o)._fval_2currTapCount = _r2.i;
    ((global::com.codename1.maps.MapComponent_23) _r0_o)._fval_2tapX = _r3.i;
    ((global::com.codename1.maps.MapComponent_23) _r0_o)._fval_2tapY = _r4.i;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$3: void <init>(com.codename1.maps.MapComponent, int, int, int)]
}

public virtual void run(){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$3: void run()]
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
    _r4_o = this;
    _r0.i = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fval_2currTapCount;
    _r1_o = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fthis_20;
    _r1.i = global::com.codename1.maps.MapComponent.access_2100((global::com.codename1.maps.MapComponent) _r1_o);
    if (_r0.i != _r1.i) goto label31;
    _r0_o = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fthis_20;
    _r1.i = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fval_2tapX;
    _r2.i = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fval_2tapY;
    _r3_o = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fthis_20;
    _r3.i = global::com.codename1.maps.MapComponent.access_2100((global::com.codename1.maps.MapComponent) _r3_o);
    ((global::com.codename1.maps.MapComponent) _r0_o).pointerTapped((int) _r1.i, (int) _r2.i, (int) _r3.i);
    _r0_o = ((global::com.codename1.maps.MapComponent_23) _r4_o)._fthis_20;
    _r1.i = 0;
    global::com.codename1.maps.MapComponent.access_2102((global::com.codename1.maps.MapComponent) _r0_o, (int) _r1.i);
    label31:;
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$3: void run()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$3]
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$3]

} // end of class: MapComponent_23

} // end of namespace: com.codename1.maps
