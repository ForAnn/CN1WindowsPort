// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts.mig {
public class CodenameOneMiGComponentWrapper: global::java.lang.Object,global::com.codename1.ui.layouts.mig.ComponentWrapper {

static CodenameOneMiGComponentWrapper() {
    @static();
}

private static bool _fmaxSet;

private static bool _fvp;

private static global::java.lang.String _fVISUAL_1PADDING_1PROPERTY;

private global::com.codename1.ui.Component _fc;

private int _fcompType;

private global::java.lang.Boolean _fbl;

private bool _fprefCalled;

private static global::com.codename1.ui.Font _fSUBST_1FONT;

public static int _fTYPE_1UNSET = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1UNSET;

public static int _fTYPE_1UNKNOWN = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1UNKNOWN;

public static int _fTYPE_1CONTAINER = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1CONTAINER;

public static int _fTYPE_1LABEL = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1LABEL;

public static int _fTYPE_1TEXT_1FIELD = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1TEXT_1FIELD;

public static int _fTYPE_1TEXT_1AREA = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1TEXT_1AREA;

public static int _fTYPE_1BUTTON = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1BUTTON;

public static int _fTYPE_1LIST = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1LIST;

public static int _fTYPE_1TABLE = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1TABLE;

public static int _fTYPE_1SCROLL_1PANE = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1SCROLL_1PANE;

public static int _fTYPE_1IMAGE = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1IMAGE;

public static int _fTYPE_1PANEL = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1PANEL;

public static int _fTYPE_1COMBO_1BOX = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1COMBO_1BOX;

public static int _fTYPE_1SLIDER = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1SLIDER;

public static int _fTYPE_1SPINNER = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1SPINNER;

public static int _fTYPE_1PROGRESS_1BAR = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1PROGRESS_1BAR;

public static int _fTYPE_1TREE = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1TREE;

public static int _fTYPE_1CHECK_1BOX = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1CHECK_1BOX;

public static int _fTYPE_1SCROLL_1BAR = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1SCROLL_1BAR;

public static int _fTYPE_1SEPARATOR = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1SEPARATOR;

public static int _fTYPE_1TABBED_1PANE = com.codename1.ui.layouts.mig._iComponentWrapper._fTYPE_1TABBED_1PANE;

public void @this(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void <init>(com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = -1;
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fcompType = _r0.i;
    _r0_o = null;
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fbl = (global::java.lang.Boolean) _r0_o;
    _r0.i = 0;
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fprefCalled = 0!=_r0.i;
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc = (global::com.codename1.ui.Component) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void <init>(com.codename1.ui.Component)]
}

public virtual int getBaseline(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getBaseline(int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r5_o = this;
    _r6.i = n1;
    _r7.i = n2;
    _r2_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o)._fc;
    if (_r6.i >= 0) goto label44;
    _r3_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o)._fc;
    _r3.i = ((global::com.codename1.ui.Component) _r3_o).getWidth();
    label10:;
    if (_r7.i >= 0) goto label46;
    _r4_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o)._fc;
    _r4.i = ((global::com.codename1.ui.Component) _r4_o).getHeight();
    label18:;
    _r0.i = ((global::com.codename1.ui.Component) _r2_o).getBaseline((int) _r3.i, (int) _r4.i);
    _r2.i = -1;
    if (_r0.i == _r2.i) goto label43;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o).getVisualPadding();
    if (_r1_o == null) goto label43;
    _r2.i = 2;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r2.i];
    _r3.i = 0;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r1_o)[_r3.i];
    _r2.i = _r2.i - _r3.i;
    _r2.i = _r2.i + 1;
    _r2.i = _r2.i / 2;
    _r0.i = _r0.i + _r2.i;
    label43:;
    return _r0.i;
    label44:;
    _r3.i = _r6.i;
    goto label10;
    label46:;
    _r4.i = _r7.i;
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getBaseline(int, int)]
}

public virtual global::System.Object getComponent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: java.lang.Object getComponent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: java.lang.Object getComponent()]
}

public virtual float getPixelUnitFactor(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: float getPixelUnitFactor(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1 ? 1 : 0;
    _r2.f = (float)1.0D;
    _r1.i = global::com.codename1.ui.layouts.mig.PlatformDefaults.getLogicalPixelBase();
    switch (_r1.i) {
    case 100: goto label11;
    case 101: goto label38;
    }
    _r1.f = _r2.f;
    label10:;
    return _r1.f;
    label11:;
    if (_r4.i == 0) goto label26;
    _r1_o = global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fSUBST_1FONT;
    _r2.i = 88;
    _r1.i = ((global::com.codename1.ui.Font) _r1_o).charWidth((char) _r2.i);
    _r1.f = (float) _r1.i;
    _r2.f = (float)6.0D;
    _r1.f = _r1.f / _r2.f;
    goto label10;
    label26:;
    _r1_o = global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fSUBST_1FONT;
    _r1.i = ((global::com.codename1.ui.Font) _r1_o).getHeight();
    _r1.f = (float) _r1.i;
    _r2.f = (float)13.277344D;
    _r1.f = _r1.f / _r2.f;
    goto label10;
    label38:;
    if (_r4.i == 0) goto label71;
    _r1_o = global::com.codename1.ui.layouts.mig.PlatformDefaults.getHorizontalScaleFactor();
    _r0_o = _r1_o;
    label45:;
    if (_r0_o != null) goto label52;
    _r0_o = new global::java.lang.Float();
    ((global::java.lang.Float) _r0_o).@this((float) _r2.f);
    label52:;
    _r1.f = ((global::java.lang.Float) _r0_o).floatValue();
    if (_r4.i == 0) goto label77;
    _r2.i = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o).getHorizontalScreenDPI();
    label62:;
    _r2.f = (float) _r2.i;
    _r1.f = _r1.f * _r2.f;
    _r2.i = global::com.codename1.ui.layouts.mig.PlatformDefaults.getDefaultDPI();
    _r2.f = (float) _r2.i;
    _r1.f = _r1.f / _r2.f;
    goto label10;
    label71:;
    _r1_o = global::com.codename1.ui.layouts.mig.PlatformDefaults.getVerticalScaleFactor();
    _r0_o = _r1_o;
    goto label45;
    label77:;
    _r2.i = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o).getVerticalScreenDPI();
    goto label62;
    label82:;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: float getPixelUnitFactor(boolean)]
}

public virtual int getX(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getX()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getX();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getX()]
}

public virtual int getY(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getY()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getY();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getY()]
}

public virtual int getHeight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getHeight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getHeight();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getHeight()]
}

public virtual int getWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getWidth();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getWidth()]
}

public virtual int getScreenLocationX(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenLocationX()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenLocationX()]
}

public virtual int getScreenLocationY(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenLocationY()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenLocationY()]
}

public virtual int getMinimumHeight(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMinimumHeight(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMinimumHeight(int)]
}

public virtual int getMinimumWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMinimumWidth(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMinimumWidth(int)]
}

public virtual int getPreferredHeight(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getPreferredHeight(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredH();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getPreferredHeight(int)]
}

public virtual int getPreferredWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getPreferredWidth(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).getPreferredW();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getPreferredWidth(int)]
}

public virtual int getMaximumHeight(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMaximumHeight(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o)._fc;
    _r0_o = ((global::com.codename1.ui.Component) _r2_o).getParent();
    if (_r0_o == null) goto label18;
    _r1.i = ((global::com.codename1.ui.Container) _r0_o).getHeight();
    _r2.i = 10;
    if (_r1.i <= _r2.i) goto label18;
    _r2.i = _r1.i;
    label17:;
    return _r2.i;
    label18:;
    _r2_o = global::com.codename1.ui.Display.getInstance();
    _r2.i = ((global::com.codename1.ui.Display) _r2_o).getDisplayHeight();
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMaximumHeight(int)]
}

public virtual int getMaximumWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMaximumWidth(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    _r3_o = this;
    _r4.i = n1;
    _r2_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o)._fc;
    _r0_o = ((global::com.codename1.ui.Component) _r2_o).getParent();
    if (_r0_o == null) goto label18;
    _r1.i = ((global::com.codename1.ui.Container) _r0_o).getWidth();
    _r2.i = 10;
    if (_r1.i <= _r2.i) goto label18;
    _r2.i = _r1.i;
    label17:;
    return _r2.i;
    label18:;
    _r2_o = global::com.codename1.ui.Display.getInstance();
    _r2.i = ((global::com.codename1.ui.Display) _r2_o).getDisplayWidth();
    goto label17;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getMaximumWidth(int)]
}

private bool isMaxSet(global::com.codename1.ui.Component n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isMaxSet(com.codename1.ui.Component)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isMaxSet(com.codename1.ui.Component)]
}

public virtual global::System.Object getParent(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: com.codename1.ui.layouts.mig.ContainerWrapper getParent()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o)._fc;
    _r0_o = ((global::com.codename1.ui.Component) _r1_o).getParent();
    if (_r0_o == null) goto label14;
    _r1_o = new global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper();
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r1_o).@this((global::com.codename1.ui.Container) _r0_o);
    label13:;
    return (global::com.codename1.ui.layouts.mig.ContainerWrapper) _r1_o;
    label14:;
    _r1_o = null;
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: com.codename1.ui.layouts.mig.ContainerWrapper getParent()]
}

public virtual int getHorizontalScreenDPI(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getHorizontalScreenDPI()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = global::com.codename1.ui.layouts.mig.PlatformDefaults.getDefaultDPI();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getHorizontalScreenDPI()]
}

public virtual int getVerticalScreenDPI(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getVerticalScreenDPI()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = global::com.codename1.ui.layouts.mig.PlatformDefaults.getDefaultDPI();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getVerticalScreenDPI()]
}

public virtual int getScreenWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).getDisplayWidth();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenWidth()]
}

public virtual int getScreenHeight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenHeight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::com.codename1.ui.Display.getInstance();
    _r0.i = ((global::com.codename1.ui.Display) _r0_o).getDisplayHeight();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getScreenHeight()]
}

public virtual bool hasBaseline(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean hasBaseline()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean hasBaseline()]
}

public virtual global::System.Object getLinkId(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: java.lang.String getLinkId()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0_o = ((global::com.codename1.ui.Component) _r0_o).getName();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: java.lang.String getLinkId()]
}

public virtual void setBounds(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void setBounds(int, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r1_o = this;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.i = n4;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    ((global::com.codename1.ui.Component) _r0_o).setX((int) _r2.i);
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    ((global::com.codename1.ui.Component) _r0_o).setY((int) _r3.i);
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    ((global::com.codename1.ui.Component) _r0_o).setWidth((int) _r4.i);
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    ((global::com.codename1.ui.Component) _r0_o).setHeight((int) _r5.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void setBounds(int, int, int, int)]
}

public virtual bool isVisible(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isVisible()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o)._fc;
    _r0.i = ((global::com.codename1.ui.Component) _r0_o).isVisible() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isVisible()]
}

public virtual global::System.Object getVisualPadding(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int[] getVisualPadding()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r5.i = 3;
    _r4.i = 2;
    _r3.i = 1;
    _r2.i = 0;
    _r1.i = 4;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r6_o)._fc;
    _r1_o = ((global::com.codename1.ui.Component) _r1_o).getStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getMargin((int) _r2.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r2.i] = _r1.i;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r6_o)._fc;
    _r1_o = ((global::com.codename1.ui.Component) _r1_o).getStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getMargin((int) _r3.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r3.i] = _r1.i;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r6_o)._fc;
    _r1_o = ((global::com.codename1.ui.Component) _r1_o).getStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getMargin((int) _r4.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r4.i] = _r1.i;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r6_o)._fc;
    _r1_o = ((global::com.codename1.ui.Component) _r1_o).getStyle();
    _r1.i = ((global::com.codename1.ui.plaf.Style) _r1_o).getMargin((int) _r5.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r5.i] = _r1.i;
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int[] getVisualPadding()]
}

public static bool isMaxSizeSetOn1_14(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isMaxSizeSetOn1_4()]
    global::org.xmlvm._nElement _r0;
    _r0.i = global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fmaxSet ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isMaxSizeSetOn1_4()]
}

public static void setMaxSizeSetOn1_14(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void setMaxSizeSetOn1_4(boolean)]
    global::org.xmlvm._nElement _r0;
    _r0.i = n1 ? 1 : 0;
    global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fmaxSet = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void setMaxSizeSetOn1_4(boolean)]
}

public static bool isVisualPaddingEnabled(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isVisualPaddingEnabled()]
    global::org.xmlvm._nElement _r0;
    _r0.i = global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fvp ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean isVisualPaddingEnabled()]
}

public static void setVisualPaddingEnabled(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void setVisualPaddingEnabled(boolean)]
    global::org.xmlvm._nElement _r0;
    _r0.i = n1 ? 1 : 0;
    global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fvp = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void setVisualPaddingEnabled(boolean)]
}

public virtual void paintDebugOutline(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void paintDebugOutline(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void paintDebugOutline(boolean)]
}

public virtual int getComponentType(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getComponentType(boolean)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1 ? 1 : 0;
    _r0.i = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o)._fcompType;
    _r1.i = -1;
    if (_r0.i != _r1.i) goto label11;
    _r0.i = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o).checkType(0!=_r3.i);
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o)._fcompType = _r0.i;
    label11:;
    _r0.i = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o)._fcompType;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getComponentType(boolean)]
}

public virtual int getLayoutHashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getLayoutHashCode()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r3_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o)._fc;
    _r0_o = ((global::com.codename1.ui.Component) _r3_o).getPreferredSize();
    _r3.i = ((global::com.codename1.ui.geom.Dimension) _r0_o).getWidth();
    _r3.i = _r3.i << (0x1f & 10);
    _r4.i = ((global::com.codename1.ui.geom.Dimension) _r0_o).getHeight();
    _r4.i = _r4.i << (0x1f & 15);
    _r1.i = _r3.i + _r4.i;
    _r3_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o)._fc;
    _r3.i = ((global::com.codename1.ui.Component) _r3_o).isVisible() ? 1 : 0;
    if (_r3.i == 0) goto label32;
    _r3.i = 1324511;
    _r1.i = _r1.i + _r3.i;
    label32:;
    _r2_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r5_o).getLinkId();
    if (_r2_o == null) goto label43;
    _r3.i = ((global::java.lang.String) _r2_o).hashCode();
    _r1.i = _r1.i + _r3.i;
    label43:;
    return _r1.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getLayoutHashCode()]
}

private int checkType(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int checkType(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.i = n1 ? 1 : 0;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o)._fc;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.TextField)) ? 1 : 0;
    if (_r1.i == 0) goto label8;
    _r1.i = 3;
    label7:;
    return _r1.i;
    label8:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.Label)) ? 1 : 0;
    if (_r1.i == 0) goto label14;
    _r1.i = 2;
    goto label7;
    label14:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.RadioButton)) ? 1 : 0;
    if (_r1.i != 0) goto label22;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.CheckBox)) ? 1 : 0;
    if (_r1.i == 0) goto label25;
    label22:;
    _r1.i = 16;
    goto label7;
    label25:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.Button)) ? 1 : 0;
    if (_r1.i == 0) goto label31;
    _r1.i = 5;
    goto label7;
    label31:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.ComboBox)) ? 1 : 0;
    if (_r1.i == 0) goto label38;
    _r1.i = 11;
    goto label7;
    label38:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.TextArea)) ? 1 : 0;
    if (_r1.i == 0) goto label44;
    _r1.i = 4;
    goto label7;
    label44:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.Container)) ? 1 : 0;
    if (_r1.i == 0) goto label51;
    _r1.i = 10;
    goto label7;
    label51:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.List)) ? 1 : 0;
    if (_r1.i == 0) goto label57;
    _r1.i = 6;
    goto label7;
    label57:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.table.Table)) ? 1 : 0;
    if (_r1.i == 0) goto label63;
    _r1.i = 7;
    goto label7;
    label63:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.spinner.BaseSpinner)) ? 1 : 0;
    if (_r1.i == 0) goto label70;
    _r1.i = 13;
    goto label7;
    label70:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.Tabs)) ? 1 : 0;
    if (_r1.i == 0) goto label77;
    _r1.i = 19;
    goto label7;
    label77:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.components.InfiniteProgress)) ? 1 : 0;
    if (_r1.i == 0) goto label84;
    _r1.i = 14;
    goto label7;
    label84:;
    _r1.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.Slider)) ? 1 : 0;
    if (_r1.i == 0) goto label91;
    _r1.i = 12;
    goto label7;
    label91:;
    _r1.i = 0;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int checkType(boolean)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r1_o).getComponent();
    _r0.i = ((global::java.lang.Object) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int hashCode()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((_r3_o != null) && (_r3_o is global::com.codename1.ui.layouts.mig.ComponentWrapper)) ? 1 : 0;
    if (_r0.i != 0) goto label6;
    _r0.i = 0;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r2_o)._fc;
    _r3_o = _r3_o;
    _r1_o = ((global::com.codename1.ui.layouts.mig.ComponentWrapper) _r3_o).getComponent();
    _r0.i = ((global::java.lang.Object) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: boolean equals(java.lang.Object)]
}

public virtual int getContentBias(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getContentBias()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o)._fc;
    _r0.i = ((_r0_o != null) && (_r0_o is global::com.codename1.ui.TextArea)) ? 1 : 0;
    if (_r0.i != 0) goto label22;
    _r0_o = global::java.lang.Boolean._fTRUE;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o)._fc;
    // Value=migLayout.dynamicAspectRatio
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 82)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111))}));
    _r1_o = ((global::com.codename1.ui.Component) _r1_o).getClientProperty((global::java.lang.String) _r2_o);
    _r0.i = ((global::java.lang.Boolean) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label24;
    label22:;
    _r0.i = 0;
    label23:;
    return _r0.i;
    label24:;
    _r0.i = -1;
    goto label23;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: int getContentBias()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0.i = 0;
    global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fmaxSet = 0!=_r0.i;
    _r0.i = 1;
    global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fvp = 0!=_r0.i;
    _r0_o = global::com.codename1.ui.layouts.mig.PlatformDefaults._fVISUAL_1PADDING_1PROPERTY;
    global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fVISUAL_1PADDING_1PROPERTY = (global::java.lang.String) _r0_o;
    _r0_o = global::com.codename1.ui.Font.getDefaultFont();
    global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper._fSUBST_1FONT = (global::com.codename1.ui.Font) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper]

} // end of class: CodenameOneMiGComponentWrapper

} // end of namespace: com.codename1.ui.layouts.mig
