// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts.mig {
public class CodenameOneMiGContainerWrapper: global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper,global::com.codename1.ui.layouts.mig.ContainerWrapper {
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

public void @this(global::com.codename1.ui.Container n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: void <init>(com.codename1.ui.Container)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r0_o).@this((global::com.codename1.ui.Component) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: void <init>(com.codename1.ui.Container)]
}

public virtual global::System.Object getComponents(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: com.codename1.ui.layouts.mig.ComponentWrapper[] getComponents()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r5_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r5_o).getComponent();
    _r0_o = _r0_o;
    _r3.i = ((global::com.codename1.ui.Container) _r0_o).getComponentCount();
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r3.i]);
    _r2.i = 0;
    label13:;
    _r3.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    if (_r2.i >= _r3.i) goto label30;
    _r3_o = new global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper();
    _r4_o = ((global::com.codename1.ui.Container) _r0_o).getComponentAt((int) _r2.i);
    ((global::com.codename1.ui.layouts.mig.CodenameOneMiGComponentWrapper) _r3_o).@this((global::com.codename1.ui.Component) _r4_o);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r2.i = _r2.i + 1;
    goto label13;
    label30:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: com.codename1.ui.layouts.mig.ComponentWrapper[] getComponents()]
}

public virtual int getComponentCount(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: int getComponentCount()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r1_o).getComponent();
    _r1_o = _r1_o;
    _r0.i = ((global::com.codename1.ui.Container) _r1_o).getComponentCount();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: int getComponentCount()]
}

public virtual global::System.Object getLayout(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: java.lang.Object getLayout()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r1_o).getComponent();
    _r1_o = _r1_o;
    _r0_o = ((global::com.codename1.ui.Container) _r1_o).getLayout();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: java.lang.Object getLayout()]
}

public virtual bool isLeftToRight(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: boolean isLeftToRight()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r1_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r1_o).getComponent();
    _r1_o = _r1_o;
    _r0.i = ((global::com.codename1.ui.Container) _r1_o).isRTL() ? 1 : 0;
    if (_r0.i != 0) goto label14;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: boolean isLeftToRight()]
}

public virtual void paintDebugCell(int n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: void paintDebugCell(int, int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r5.i = n3;
    _r6.i = n4;
    _r0_o = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r2_o).getComponent();
    _r0_o = _r0_o;
    _r1.i = ((global::com.codename1.ui.Component) _r0_o).isVisible() ? 1 : 0;
    if (_r1.i != 0) goto label12;
    label12:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: void paintDebugCell(int, int, int, int)]
}

public override int getComponentType(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: int getComponentType(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1 ? 1 : 0;
    _r0.i = 1;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: int getComponentType(boolean)]
}

public override int getLayoutHashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: int getLayoutHashCode()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.i = base.getLayoutHashCode();
    _r1.i = ((global::com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper) _r2_o).isLeftToRight() ? 1 : 0;
    if (_r1.i == 0) goto label14;
    _r1.i = 416343;
    _r0.i = _r0.i + _r1.i;
    label14:;
    _r1.i = 0;
    return _r1.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper: int getLayoutHashCode()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.CodenameOneMiGContainerWrapper]

} // end of class: CodenameOneMiGContainerWrapper

} // end of namespace: com.codename1.ui.layouts.mig
