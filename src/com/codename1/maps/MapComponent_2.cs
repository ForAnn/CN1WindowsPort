// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps {
public class MapComponent_22: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.maps.MapComponent _fthis_20;

public void @this(global::com.codename1.maps.MapComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$2: void <init>(com.codename1.maps.MapComponent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.maps.MapComponent_22) _r0_o)._fthis_20 = (global::com.codename1.maps.MapComponent) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$2: void <init>(com.codename1.maps.MapComponent)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.maps.MapComponent_22) _r1_o)._fthis_20;
    ((global::com.codename1.maps.MapComponent) _r0_o).zoomIn();
    _r0_o = ((global::com.codename1.maps.MapComponent_22) _r1_o)._fthis_20;
    ((global::com.codename1.maps.MapComponent) _r0_o).repaint();
    _r0_o = ((global::com.codename1.maps.MapComponent_22) _r1_o)._fthis_20;
    global::com.codename1.maps.MapComponent.access_2000((global::com.codename1.maps.MapComponent) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$2: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$2]
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$2]

} // end of class: MapComponent_22

} // end of namespace: com.codename1.maps
