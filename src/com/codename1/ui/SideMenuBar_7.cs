// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui {
public class SideMenuBar_27: global::java.lang.Object,global::com.codename1.ui.Painter {
public global::com.codename1.ui.Image _fimg;

public global::com.codename1.ui.Image _fval_2image;

public bool _fval_2isRTL;

public global::com.codename1.ui.Image _fval_2shadow;

public global::java.lang.String _fval_2placement;

public global::com.codename1.ui.SideMenuBar _fthis_20;

public void @this(global::com.codename1.ui.SideMenuBar n1, global::com.codename1.ui.Image n2, bool n3, global::com.codename1.ui.Image n4, global::java.lang.String n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$7: void <init>(com.codename1.ui.SideMenuBar, com.codename1.ui.Image, boolean, com.codename1.ui.Image, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.i = n3 ? 1 : 0;
    _r5_o = n4;
    _r6_o = n5;
    ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fthis_20 = (global::com.codename1.ui.SideMenuBar) _r2_o;
    ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fval_2image = (global::com.codename1.ui.Image) _r3_o;
    ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fval_2isRTL = 0!=_r4.i;
    ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fval_2shadow = (global::com.codename1.ui.Image) _r5_o;
    ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fval_2placement = (global::java.lang.String) _r6_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fval_2image;
    ((global::com.codename1.ui.SideMenuBar_27) _r1_o)._fimg = (global::com.codename1.ui.Image) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$7: void <init>(com.codename1.ui.SideMenuBar, com.codename1.ui.Image, boolean, com.codename1.ui.Image, java.lang.String)]
}

public virtual void paint(global::com.codename1.ui.Graphics n1, global::com.codename1.ui.geom.Rectangle n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$7: void paint(com.codename1.ui.Graphics, com.codename1.ui.geom.Rectangle)]
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
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11_o = n1;
    _r12_o = n2;
    _r9.i = 1;
    _r3.i = 0;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg;
    if (_r0_o != null) goto label186;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r0_o);
    // Value=$parent
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    _r7_o = ((global::com.codename1.ui.Container) _r0_o).getClientProperty((global::java.lang.String) _r1_o);
    _r7_o = _r7_o;
    if (_r7_o != null) goto label23;
    label22:;
    return;
    label23:;
    _r6.i = ((global::com.codename1.ui.Component) _r7_o).isVisible() ? 1 : 0;
    ((global::com.codename1.ui.Component) _r7_o).setVisible(0!=_r9.i);
    _r0.i = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2isRTL ? 1 : 0;
    if (_r0.i == 0) goto label117;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0.i = global::com.codename1.ui.SideMenuBar.access_2100((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r1_o);
    _r1.i = ((global::com.codename1.ui.Container) _r1_o).getWidth();
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    _r1.i = ((global::com.codename1.ui.Component) _r7_o).getWidth();
    _r8.i = _r0.i - _r1.i;
    ((global::com.codename1.ui.Graphics) _r11_o).translate((int) _r8.i, (int) _r3.i);
    global::com.codename1.ui.Container._fsidemenuBarTranslation = _r8.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    if (_r0_o == null) goto label104;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r0.i = ((global::com.codename1.ui.Component) _r7_o).getWidth();
    _r0.i = _r0.i + _r8.i;
    _r2_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r2.i = ((global::com.codename1.ui.Image) _r2_o).getWidth();
    _r2.i = _r0.i - _r2.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r4.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r5.i = ((global::com.codename1.ui.Container) _r0_o).getHeight();
    _r0_o = _r11_o;
    ((global::com.codename1.ui.Graphics) _r0_o).tileImage((global::com.codename1.ui.Image) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i);
    label104:;
    ((global::com.codename1.ui.Component) _r7_o).paintComponent((global::com.codename1.ui.Graphics) _r11_o, 0!=_r9.i);
    global::com.codename1.ui.Container._fsidemenuBarTranslation = _r3.i;
    _r0.i = -_r8.i;
    ((global::com.codename1.ui.Graphics) _r11_o).translate((int) _r0.i, (int) _r3.i);
    label113:;
    ((global::com.codename1.ui.Component) _r7_o).setVisible(0!=_r6.i);
    goto label22;
    label117:;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0.i = global::com.codename1.ui.SideMenuBar.access_2100((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r1_o);
    _r1.i = ((global::com.codename1.ui.Container) _r1_o).getX();
    _r8.i = global::java.lang.Math.min((int) _r0.i, (int) _r1.i);
    ((global::com.codename1.ui.Graphics) _r11_o).translate((int) _r8.i, (int) _r3.i);
    global::com.codename1.ui.Container._fsidemenuBarTranslation = _r8.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    if (_r0_o == null) goto label176;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r2.i = _r8.i - _r0.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r4.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r5.i = ((global::com.codename1.ui.Container) _r0_o).getHeight();
    _r0_o = _r11_o;
    ((global::com.codename1.ui.Graphics) _r0_o).tileImage((global::com.codename1.ui.Image) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i);
    label176:;
    ((global::com.codename1.ui.Component) _r7_o).paintComponent((global::com.codename1.ui.Graphics) _r11_o, 0!=_r9.i);
    global::com.codename1.ui.Container._fsidemenuBarTranslation = _r3.i;
    _r0.i = -_r8.i;
    ((global::com.codename1.ui.Graphics) _r11_o).translate((int) _r0.i, (int) _r3.i);
    goto label113;
    label186:;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).areMutableImagesFast() ? 1 : 0;
    if (_r0.i == 0) goto label228;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg;
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getHeight();
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).getDisplayHeight();
    if (_r0.i == _r1.i) goto label228;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2placement;
    _r2_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r2_o = global::com.codename1.ui.SideMenuBar.access_2000((global::com.codename1.ui.SideMenuBar) _r2_o);
    _r0_o = ((global::com.codename1.ui.SideMenuBar) _r0_o).updateRightPanelBgImage((global::java.lang.String) _r1_o, (global::com.codename1.ui.Component) _r2_o);
    ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg = (global::com.codename1.ui.Image) _r0_o;
    label228:;
    _r0.i = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2isRTL ? 1 : 0;
    if (_r0.i == 0) goto label308;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0.i = global::com.codename1.ui.SideMenuBar.access_2100((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r1_o);
    _r1.i = ((global::com.codename1.ui.Container) _r1_o).getWidth();
    _r0.i = global::java.lang.Math.max((int) _r0.i, (int) _r1.i);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg;
    _r1.i = ((global::com.codename1.ui.Image) _r1_o).getWidth();
    _r8.i = _r0.i - _r1.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    if (_r0_o == null) goto label301;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg;
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r0.i = _r0.i + _r8.i;
    _r2_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r2.i = ((global::com.codename1.ui.Image) _r2_o).getWidth();
    _r2.i = _r0.i - _r2.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r4.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r5.i = ((global::com.codename1.ui.Container) _r0_o).getHeight();
    _r0_o = _r11_o;
    ((global::com.codename1.ui.Graphics) _r0_o).tileImage((global::com.codename1.ui.Image) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i);
    label301:;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg;
    ((global::com.codename1.ui.Graphics) _r11_o).drawImage((global::com.codename1.ui.Image) _r0_o, (int) _r8.i, (int) _r3.i);
    goto label22;
    label308:;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0.i = global::com.codename1.ui.SideMenuBar.access_2100((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r1_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r1_o);
    _r1.i = ((global::com.codename1.ui.Container) _r1_o).getX();
    _r8.i = global::java.lang.Math.min((int) _r0.i, (int) _r1.i);
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    if (_r0_o == null) goto label362;
    _r1_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r0.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r2.i = _r8.i - _r0.i;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fval_2shadow;
    _r4.i = ((global::com.codename1.ui.Image) _r0_o).getWidth();
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fthis_20;
    _r0_o = global::com.codename1.ui.SideMenuBar.access_2600((global::com.codename1.ui.SideMenuBar) _r0_o);
    _r5.i = ((global::com.codename1.ui.Container) _r0_o).getHeight();
    _r0_o = _r11_o;
    ((global::com.codename1.ui.Graphics) _r0_o).tileImage((global::com.codename1.ui.Image) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i);
    label362:;
    _r0_o = ((global::com.codename1.ui.SideMenuBar_27) _r10_o)._fimg;
    ((global::com.codename1.ui.Graphics) _r11_o).drawImage((global::com.codename1.ui.Image) _r0_o, (int) _r8.i, (int) _r3.i);
    goto label22;
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$7: void paint(com.codename1.ui.Graphics, com.codename1.ui.geom.Rectangle)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.SideMenuBar$7]
//XMLVM_END_WRAPPER[com.codename1.ui.SideMenuBar$7]

} // end of class: SideMenuBar_27

} // end of namespace: com.codename1.ui
