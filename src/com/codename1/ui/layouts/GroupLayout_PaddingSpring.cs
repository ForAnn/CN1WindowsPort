// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GroupLayout_2PaddingSpring: global::com.codename1.ui.layouts.GroupLayout_2Spring {
private global::com.codename1.ui.Component _fsource;

private global::com.codename1.ui.Component _ftarget;

private int _ftype;

private bool _fcanGrow;

public global::com.codename1.ui.layouts.GroupLayout _fthis_20;

public void @this(global::com.codename1.ui.layouts.GroupLayout n1, global::com.codename1.ui.Component n2, global::com.codename1.ui.Component n3, int n4, bool n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component, com.codename1.ui.Component, int, boolean)]
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
    _r4.i = n4;
    _r5.i = n5 ? 1 : 0;
    ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r0_o)._fthis_20 = (global::com.codename1.ui.layouts.GroupLayout) _r1_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2Spring) _r0_o).@this((global::com.codename1.ui.layouts.GroupLayout) _r1_o);
    ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r0_o)._fsource = (global::com.codename1.ui.Component) _r2_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r0_o)._ftarget = (global::com.codename1.ui.Component) _r3_o;
    ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r0_o)._ftype = _r4.i;
    ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r0_o)._fcanGrow = 0!=_r5.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: void <init>(com.codename1.ui.layouts.GroupLayout, com.codename1.ui.Component, com.codename1.ui.Component, int, boolean)]
}

public override int calculateMinimumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int calculateMinimumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r1_o).getPadding((int) _r2.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int calculateMinimumSize(int)]
}

public override int calculatePreferredSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int calculatePreferredSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r1_o).getPadding((int) _r2.i);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int calculatePreferredSize(int)]
}

public override int calculateMaximumSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int calculateMaximumSize(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r1_o)._fcanGrow ? 1 : 0;
    if (_r0.i == 0) goto label7;
    _r0.i = 32767;
    label6:;
    return _r0.i;
    label7:;
    _r0.i = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r1_o).getPadding((int) _r2.i);
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int calculateMaximumSize(int)]
}

private int getPadding(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int getPadding(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7.i = n1;
    _r0.i = 1;
    if (_r7.i != _r0.i) goto label27;
    _r4.i = 3;
    label4:;
    _r0_o = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r6_o)._fthis_20;
    _r0_o = global::com.codename1.ui.layouts.GroupLayout.access_21000((global::com.codename1.ui.layouts.GroupLayout) _r0_o);
    _r1_o = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r6_o)._fsource;
    _r2_o = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r6_o)._ftarget;
    _r3.i = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r6_o)._ftype;
    _r5_o = ((global::com.codename1.ui.layouts.GroupLayout_2PaddingSpring) _r6_o)._fthis_20;
    _r5_o = global::com.codename1.ui.layouts.GroupLayout.access_2900((global::com.codename1.ui.layouts.GroupLayout) _r5_o);
    _r0.i = ((global::com.codename1.ui.layouts.LayoutStyle) _r0_o).getPreferredGap((global::com.codename1.ui.Component) _r1_o, (global::com.codename1.ui.Component) _r2_o, (int) _r3.i, (int) _r4.i, (global::com.codename1.ui.Container) _r5_o);
    return _r0.i;
    label27:;
    _r4.i = 5;
    goto label4;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: int getPadding(int)]
}

public override bool willHaveZeroSize(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: boolean willHaveZeroSize(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring: boolean willHaveZeroSize(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GroupLayout$PaddingSpring]

} // end of class: GroupLayout_2PaddingSpring

} // end of namespace: com.codename1.ui.layouts
