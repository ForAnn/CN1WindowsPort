// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.list {
public class ContainerList_2Entry: global::com.codename1.ui.Component {
private int _foffset;

public global::com.codename1.ui.list.ContainerList _fthis_20;

public void @this(global::com.codename1.ui.list.ContainerList n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void <init>(com.codename1.ui.list.ContainerList, int)]
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
    _r3.i = n2;
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o)._fthis_20 = (global::com.codename1.ui.list.ContainerList) _r2_o;
    ((global::com.codename1.ui.Component) _r1_o).@this();
    // Value=Container
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o).setUIID((global::java.lang.String) _r0_o);
    _r0.i = 1;
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o).setFocusable(0!=_r0.i);
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o)._foffset = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void <init>(com.codename1.ui.list.ContainerList, int)]
}

public override void initComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void initComponent()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o).getParent();
    _r0.i = ((global::com.codename1.ui.Container) _r0_o).getComponentIndex((global::com.codename1.ui.Component) _r1_o);
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o)._foffset = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void initComponent()]
}

public override void focusGained(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void focusGained()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r2_o)._fthis_20;
    _r0_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r0_o);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r2_o)._foffset;
    ((global::com.codename1.ui.list.ListModel) _r0_o).setSelectedIndex((int) _r1.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void focusGained()]
}

public override void paintBackground(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void paintBackground(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void paintBackground(com.codename1.ui.Graphics)]
}

public override void paintBorder(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void paintBorder(com.codename1.ui.Graphics)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void paintBorder(com.codename1.ui.Graphics)]
}

public override void paint(global::com.codename1.ui.Graphics n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void paint(com.codename1.ui.Graphics)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10_o = n1;
    _r1_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o)._fthis_20;
    _r1_o = global::com.codename1.ui.list.ContainerList.access_2200((global::com.codename1.ui.list.ContainerList) _r1_o);
    _r2_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o)._fthis_20;
    _r3_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o)._fthis_20;
    _r3_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r3_o);
    _r4_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o)._fthis_20;
    _r4_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r4_o);
    _r5.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o)._foffset;
    _r4_o = ((global::com.codename1.ui.list.ListModel) _r4_o).getItemAt((int) _r5.i);
    _r5.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o)._foffset;
    _r6.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o).hasFocus() ? 1 : 0;
    _r7_o = ((global::com.codename1.ui.list.CellRenderer) _r1_o).getCellRendererComponent((global::com.codename1.ui.Component) _r2_o, (global::java.lang.Object) _r3_o, (global::java.lang.Object) _r4_o, (int) _r5.i, 0!=_r6.i);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o).getX();
    ((global::com.codename1.ui.Component) _r7_o).setX((int) _r1.i);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o).getY();
    ((global::com.codename1.ui.Component) _r7_o).setY((int) _r1.i);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o).getWidth();
    ((global::com.codename1.ui.Component) _r7_o).setWidth((int) _r1.i);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o).getHeight();
    ((global::com.codename1.ui.Component) _r7_o).setHeight((int) _r1.i);
    _r1.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.Container)) ? 1 : 0;
    if (_r1.i == 0) goto label75;
    _r0_o = _r7_o;
    _r0_o = _r0_o;
    _r8_o = _r0_o;
    ((global::com.codename1.ui.Container) _r8_o).revalidate();
    label75:;
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r9_o).hasFocus() ? 1 : 0;
    ((global::com.codename1.ui.Component) _r7_o).setFocus(0!=_r1.i);
    ((global::com.codename1.ui.Component) _r7_o).paintComponent((global::com.codename1.ui.Graphics) _r10_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void paint(com.codename1.ui.Graphics)]
}

public override void longPointerPress(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void longPointerPress(int, int)]
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
    _r2.i = n1;
    _r3.i = n2;
    base.longPointerPress((int) _r2.i, (int) _r3.i);
    _r0.i = 1;
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o).pointerReleasedImpl((int) _r2.i, (int) _r3.i, 0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void longPointerPress(int, int)]
}

public override void pointerReleased(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void pointerReleased(int, int)]
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
    _r2.i = n1;
    _r3.i = n2;
    base.pointerReleased((int) _r2.i, (int) _r3.i);
    _r0.i = 0;
    ((global::com.codename1.ui.list.ContainerList_2Entry) _r1_o).pointerReleasedImpl((int) _r2.i, (int) _r3.i, 0!=_r0.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void pointerReleased(int, int)]
}

public virtual void pointerReleasedImpl(int n1, int n2, bool n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void pointerReleasedImpl(int, int, boolean)]
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
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r15_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r12_o = this;
    _r13.i = n1;
    _r14.i = n2;
    _r15.i = n3 ? 1 : 0;
    _r0.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o).isDragActivated() ? 1 : 0;
    if (_r0.i != 0) goto label104;
    _r0_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r0_o = global::com.codename1.ui.list.ContainerList.access_2200((global::com.codename1.ui.list.ContainerList) _r0_o);
    _r1_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r2_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r2_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r2_o);
    _r3_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r3_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r3_o);
    _r4.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._foffset;
    _r3_o = ((global::com.codename1.ui.list.ListModel) _r3_o).getItemAt((int) _r4.i);
    _r4.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._foffset;
    _r5.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o).hasFocus() ? 1 : 0;
    _r8_o = ((global::com.codename1.ui.list.CellRenderer) _r0_o).getCellRendererComponent((global::com.codename1.ui.Component) _r1_o, (global::java.lang.Object) _r2_o, (global::java.lang.Object) _r3_o, (int) _r4.i, 0!=_r5.i);
    _r0.i = ((_r8_o != null) && (_r8_o is global::com.codename1.ui.Container)) ? 1 : 0;
    if (_r0.i == 0) goto label111;
    _r6.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o).getAbsoluteX();
    _r7.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o).getAbsoluteY();
    _r0.i = _r13.i - _r6.i;
    _r1.i = ((global::com.codename1.ui.Component) _r8_o).getX();
    _r9.i = _r0.i + _r1.i;
    _r0.i = _r14.i - _r7.i;
    _r1.i = ((global::com.codename1.ui.Component) _r8_o).getY();
    _r10.i = _r0.i + _r1.i;
    _r8_o = _r8_o;
    _r11_o = ((global::com.codename1.ui.Container) _r8_o).getComponentAt((int) _r9.i, (int) _r10.i);
    if (_r11_o == null) goto label111;
    _r0.i = 0;
    ((global::com.codename1.ui.Component) _r11_o).setX((int) _r0.i);
    _r0.i = 0;
    ((global::com.codename1.ui.Component) _r11_o).setY((int) _r0.i);
    if (_r15.i == 0) goto label105;
    ((global::com.codename1.ui.Component) _r11_o).longPointerPress((int) _r9.i, (int) _r10.i);
    _r0_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r1_o = new global::com.codename1.ui.events.ActionEvent();
    _r2_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r3.i = 1;
    ((global::com.codename1.ui.events.ActionEvent) _r1_o).@this((global::java.lang.Object) _r2_o, (int) _r13.i, (int) _r14.i, 0!=_r3.i);
    ((global::com.codename1.ui.list.ContainerList) _r0_o).fireActionEvent((global::com.codename1.ui.events.ActionEvent) _r1_o);
    label104:;
    return;
    label105:;
    ((global::com.codename1.ui.Component) _r11_o).pointerPressed((int) _r9.i, (int) _r10.i);
    ((global::com.codename1.ui.Component) _r11_o).pointerReleased((int) _r9.i, (int) _r10.i);
    label111:;
    _r0_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    _r1_o = new global::com.codename1.ui.events.ActionEvent();
    _r2_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r12_o)._fthis_20;
    ((global::com.codename1.ui.events.ActionEvent) _r1_o).@this((global::java.lang.Object) _r2_o, (int) _r13.i, (int) _r14.i, 0!=_r15.i);
    ((global::com.codename1.ui.list.ContainerList) _r0_o).fireActionEvent((global::com.codename1.ui.events.ActionEvent) _r1_o);
    goto label104;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void pointerReleasedImpl(int, int, boolean)]
}

public override void keyReleased(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void keyReleased(int)]
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
    _r3_o = this;
    _r4.i = n1;
    base.keyReleased((int) _r4.i);
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).getGameAction((int) _r4.i);
    _r1.i = 8;
    if (_r0.i != _r1.i) goto label27;
    _r0_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r3_o)._fthis_20;
    _r1_o = new global::com.codename1.ui.events.ActionEvent();
    _r2_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r3_o)._fthis_20;
    ((global::com.codename1.ui.events.ActionEvent) _r1_o).@this((global::java.lang.Object) _r2_o, (int) _r4.i);
    ((global::com.codename1.ui.list.ContainerList) _r0_o).fireActionEvent((global::com.codename1.ui.events.ActionEvent) _r1_o);
    label27:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: void keyReleased(int)]
}

public override global::System.Object calcPreferredSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry: com.codename1.ui.geom.Dimension calcPreferredSize()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r1_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o)._fthis_20;
    _r1_o = global::com.codename1.ui.list.ContainerList.access_2200((global::com.codename1.ui.list.ContainerList) _r1_o);
    _r2_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o)._fthis_20;
    _r3_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o)._fthis_20;
    _r3_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r3_o);
    _r4_o = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o)._fthis_20;
    _r4_o = global::com.codename1.ui.list.ContainerList.access_2100((global::com.codename1.ui.list.ContainerList) _r4_o);
    _r5.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o)._foffset;
    _r4_o = ((global::com.codename1.ui.list.ListModel) _r4_o).getItemAt((int) _r5.i);
    _r5.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o)._foffset;
    _r6.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o).hasFocus() ? 1 : 0;
    _r7_o = ((global::com.codename1.ui.list.CellRenderer) _r1_o).getCellRendererComponent((global::com.codename1.ui.Component) _r2_o, (global::java.lang.Object) _r3_o, (global::java.lang.Object) _r4_o, (int) _r5.i, 0!=_r6.i);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o).getWidth();
    if (_r1.i > 0) goto label80;
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).getDisplayWidth();
    ((global::com.codename1.ui.Component) _r7_o).setWidth((int) _r1.i);
    _r1_o = global::com.codename1.ui.Display.getInstance();
    _r1.i = ((global::com.codename1.ui.Display) _r1_o).getDisplayHeight();
    ((global::com.codename1.ui.Component) _r7_o).setHeight((int) _r1.i);
    label64:;
    _r1.i = ((_r7_o != null) && (_r7_o is global::com.codename1.ui.Container)) ? 1 : 0;
    if (_r1.i == 0) goto label75;
    _r0_o = _r7_o;
    _r0_o = _r0_o;
    _r9_o = _r0_o;
    ((global::com.codename1.ui.Container) _r9_o).revalidate();
    label75:;
    _r8_o = ((global::com.codename1.ui.Component) _r7_o).getPreferredSize();
    return (global::com.codename1.ui.geom.Dimension) _r8_o;
    label80:;
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o).getWidth();
    ((global::com.codename1.ui.Component) _r7_o).setWidth((int) _r1.i);
    _r1.i = ((global::com.codename1.ui.list.ContainerList_2Entry) _r10_o).getHeight();
    ((global::com.codename1.ui.Component) _r7_o).setHeight((int) _r1.i);
    goto label64;
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry: com.codename1.ui.geom.Dimension calcPreferredSize()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.list.ContainerList$Entry]
//XMLVM_END_WRAPPER[com.codename1.ui.list.ContainerList$Entry]

} // end of class: ContainerList_2Entry

} // end of namespace: com.codename1.ui.list
