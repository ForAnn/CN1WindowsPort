// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.maps {
public class MapComponent_21: global::java.lang.Object,global::com.codename1.ui.events.ActionListener {
public global::com.codename1.maps.MapComponent _fthis_20;

public void @this(global::com.codename1.maps.MapComponent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$1: void <init>(com.codename1.maps.MapComponent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.maps.MapComponent_21) _r0_o)._fthis_20 = (global::com.codename1.maps.MapComponent) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$1: void <init>(com.codename1.maps.MapComponent)]
}

public virtual void actionPerformed(global::com.codename1.ui.events.ActionEvent n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.maps.MapComponent_21) _r1_o)._fthis_20;
    ((global::com.codename1.maps.MapComponent) _r0_o).zoomOut();
    _r0_o = ((global::com.codename1.maps.MapComponent_21) _r1_o)._fthis_20;
    ((global::com.codename1.maps.MapComponent) _r0_o).repaint();
    _r0_o = ((global::com.codename1.maps.MapComponent_21) _r1_o)._fthis_20;
    global::com.codename1.maps.MapComponent.access_2000((global::com.codename1.maps.MapComponent) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$1: void actionPerformed(com.codename1.ui.events.ActionEvent)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.maps.MapComponent$1]
//XMLVM_END_WRAPPER[com.codename1.maps.MapComponent$1]

} // end of class: MapComponent_21

} // end of namespace: com.codename1.maps
