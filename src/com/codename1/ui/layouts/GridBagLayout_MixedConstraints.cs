// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GridBagLayout_2MixedConstraints: global::java.lang.Object {
public global::com.codename1.ui.geom.Rectangle _finitial;

public global::com.codename1.ui.geom.Rectangle _fmapped;

public bool _frelative;

public global::com.codename1.ui.layouts.GridBagLayout _fthis_20;

public void @this(global::com.codename1.ui.layouts.GridBagLayout n1, global::com.codename1.ui.layouts.GridBagConstraints n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$MixedConstraints: void <init>(com.codename1.ui.layouts.GridBagLayout, com.codename1.ui.layouts.GridBagConstraints)]
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
    _r5.i = -1;
    ((global::com.codename1.ui.layouts.GridBagLayout_2MixedConstraints) _r6_o)._fthis_20 = (global::com.codename1.ui.layouts.GridBagLayout) _r7_o;
    ((global::java.lang.Object) _r6_o).@this();
    _r0_o = new global::com.codename1.ui.geom.Rectangle();
    _r1.i = ((global::com.codename1.ui.layouts.GridBagConstraints) _r8_o)._fgridx;
    _r2.i = ((global::com.codename1.ui.layouts.GridBagConstraints) _r8_o)._fgridy;
    _r3.i = ((global::com.codename1.ui.layouts.GridBagConstraints) _r8_o)._fgridwidth;
    _r4.i = ((global::com.codename1.ui.layouts.GridBagConstraints) _r8_o)._fgridheight;
    ((global::com.codename1.ui.geom.Rectangle) _r0_o).@this((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    ((global::com.codename1.ui.layouts.GridBagLayout_2MixedConstraints) _r6_o)._finitial = (global::com.codename1.ui.geom.Rectangle) _r0_o;
    _r0_o = new global::com.codename1.ui.geom.Rectangle();
    ((global::com.codename1.ui.geom.Rectangle) _r0_o).@this();
    ((global::com.codename1.ui.layouts.GridBagLayout_2MixedConstraints) _r6_o)._fmapped = (global::com.codename1.ui.geom.Rectangle) _r0_o;
    _r0.i = ((global::com.codename1.ui.layouts.GridBagConstraints) _r8_o)._fgridx;
    if (_r0.i == _r5.i) goto label36;
    _r0.i = ((global::com.codename1.ui.layouts.GridBagConstraints) _r8_o)._fgridy;
    if (_r0.i != _r5.i) goto label40;
    label36:;
    _r0.i = 1;
    label37:;
    ((global::com.codename1.ui.layouts.GridBagLayout_2MixedConstraints) _r6_o)._frelative = 0!=_r0.i;
    return;
    label40:;
    _r0.i = 0;
    goto label37;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$MixedConstraints: void <init>(com.codename1.ui.layouts.GridBagLayout, com.codename1.ui.layouts.GridBagConstraints)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$MixedConstraints]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$MixedConstraints]

} // end of class: GridBagLayout_2MixedConstraints

} // end of namespace: com.codename1.ui.layouts
