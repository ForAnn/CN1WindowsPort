// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts.mig {
public class Grid_2LinkedDimGroup: global::java.lang.Object {



private global::java.lang.String _flinkCtx;

private int _fspan;

private int _flinkType;

private bool _fisHor;

private bool _ffromEnd;

private global::java.util.ArrayList _f_1compWraps;

private int _flStart;

private int _flSize;

private void @this(global::java.lang.String n1, int n2, int n3, bool n4, bool n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void <init>(java.lang.String, int, int, boolean, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r7.i = n4 ? 1 : 0;
    _r8.i = n5 ? 1 : 0;
    _r2.i = 0;
    ((global::java.lang.Object) _r3_o).@this();
    _r0_o = new global::java.util.ArrayList();
    _r1.i = 4;
    ((global::java.util.ArrayList) _r0_o).@this((int) _r1.i);
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._f_1compWraps = (global::java.util.ArrayList) _r0_o;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._flStart = _r2.i;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._flSize = _r2.i;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._flinkCtx = (global::java.lang.String) _r4_o;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._fspan = _r5.i;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._flinkType = _r6.i;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._fisHor = 0!=_r7.i;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r3_o)._ffromEnd = 0!=_r8.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void <init>(java.lang.String, int, int, boolean, boolean)]
}

private void addCompWrap(global::com.codename1.ui.layouts.mig.Grid_2CompWrap n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void addCompWrap(com.codename1.ui.layouts.mig.Grid$CompWrap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._f_1compWraps;
    ((global::java.util.ArrayList) _r0_o).add((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void addCompWrap(com.codename1.ui.layouts.mig.Grid$CompWrap)]
}

private void setCompWraps(global::java.util.ArrayList n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void setCompWraps(java.util.ArrayList)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._f_1compWraps;
    if (_r0_o == _r2_o) goto label14;
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._f_1compWraps;
    ((global::java.util.ArrayList) _r0_o).clear();
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._f_1compWraps;
    ((global::java.util.ArrayList) _r0_o).addAll((global::java.util.Collection) _r2_o);
    label14:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void setCompWraps(java.util.ArrayList)]
}

private void layout(global::com.codename1.ui.layouts.mig.DimConstraint n1, int n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void layout(com.codename1.ui.layouts.mig.DimConstraint, int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    _r8_o = this;
    _r9_o = n1;
    _r10.i = n2;
    _r11.i = n3;
    _r12.i = n4;
    _r5.i = 1;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._flStart = _r10.i;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._flSize = _r11.i;
    _r1_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r1.i = ((global::java.util.ArrayList) _r1_o).isEmpty() ? 1 : 0;
    if (_r1.i == 0) goto label14;
    label13:;
    return;
    label14:;
    _r1_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r2.i = 0;
    _r1_o = ((global::java.util.ArrayList) _r1_o).get((int) _r2.i);
    _r1_o = _r1_o;
    _r1_o = global::com.codename1.ui.layouts.mig.Grid_2CompWrap.access_21000((global::com.codename1.ui.layouts.mig.Grid_2CompWrap) _r1_o);
    _r0_o = ((global::com.codename1.ui.layouts.mig.ComponentWrapper) _r1_o).getParent();
    _r1.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._flinkType;
    if (_r1.i != _r5.i) goto label48;
    _r1_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r5.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._fisHor ? 1 : 0;
    _r6.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._ffromEnd ? 1 : 0;
    _r2_o = _r9_o;
    _r3.i = _r10.i;
    _r4.i = _r11.i;
    global::com.codename1.ui.layouts.mig.Grid.access_24100((global::com.codename1.ui.layouts.mig.ContainerWrapper) _r0_o, (global::java.util.ArrayList) _r1_o, (global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o, (int) _r3.i, (int) _r4.i, 0!=_r5.i, 0!=_r6.i);
    goto label13;
    label48:;
    _r1.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._flinkType;
    _r2.i = 2;
    if (_r1.i != _r2.i) goto label63;
    _r1_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r2_o = _r9_o;
    _r3.i = _r10.i;
    _r4.i = _r11.i;
    _r6.i = _r12.i;
    global::com.codename1.ui.layouts.mig.Grid.access_24200((global::com.codename1.ui.layouts.mig.ContainerWrapper) _r0_o, (global::java.util.ArrayList) _r1_o, (global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    goto label13;
    label63:;
    _r1_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r5.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._fisHor ? 1 : 0;
    _r7.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._ffromEnd ? 1 : 0;
    _r2_o = _r9_o;
    _r3.i = _r10.i;
    _r4.i = _r11.i;
    _r6.i = _r12.i;
    global::com.codename1.ui.layouts.mig.Grid.access_24300((global::com.codename1.ui.layouts.mig.ContainerWrapper) _r0_o, (global::java.util.ArrayList) _r1_o, (global::com.codename1.ui.layouts.mig.DimConstraint) _r2_o, (int) _r3.i, (int) _r4.i, 0!=_r5.i, (int) _r6.i, 0!=_r7.i);
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void layout(com.codename1.ui.layouts.mig.DimConstraint, int, int, int)]
}

private global::System.Object getMinPrefMax(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int[] getMinPrefMax()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r8_o = null;
    _r8_o = this;
    _r7.i = 2;
    _r6.i = 0;
    _r5.i = 1;
    _r3.i = 3;
    _r2_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r3.i]);
    _r3_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r3.i = ((global::java.util.ArrayList) _r3_o).isEmpty() ? 1 : 0;
    if (_r3.i != 0) goto label68;
    _r1.i = 0;
    label15:;
    if (_r1.i > _r5.i) goto label63;
    _r3.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._flinkType;
    if (_r3.i != _r5.i) goto label34;
    _r3_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r4.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._fisHor ? 1 : 0;
    _r3.i = global::com.codename1.ui.layouts.mig.Grid.access_24400((global::java.util.ArrayList) _r3_o, (int) _r1.i, 0!=_r4.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i] = _r3.i;
    label31:;
    _r1.i = _r1.i + 1;
    goto label15;
    label34:;
    _r3.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._flinkType;
    if (_r3.i != _r7.i) goto label52;
    _r3_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r0_o = global::com.codename1.ui.layouts.mig.Grid.access_24500((global::java.util.ArrayList) _r3_o, (int) _r1.i, 0!=_r6.i);
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r6.i];
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r5.i];
    _r3.i = _r3.i + _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i] = _r3.i;
    goto label31;
    label52:;
    _r3_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._f_1compWraps;
    _r4.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r8_o)._fisHor ? 1 : 0;
    _r3.i = global::com.codename1.ui.layouts.mig.Grid.access_24600((global::java.util.ArrayList) _r3_o, (int) _r1.i, 0!=_r4.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i] = _r3.i;
    goto label31;
    label63:;
    _r3.i = 2097051;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r7.i] = _r3.i;
    label68:;
    return (global::org.xmlvm._nArrayAdapter<int>) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int[] getMinPrefMax()]
}

public static int access_21800(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int access$1800(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._flStart;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int access$1800(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public static bool access_21900(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: boolean access$1900(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._ffromEnd ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: boolean access$1900(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public static int access_22000(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int access$2000(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._flSize;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int access$2000(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public static global::System.Object access_22400(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: java.util.ArrayList access$2400(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._f_1compWraps;
    return (global::java.util.ArrayList) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: java.util.ArrayList access$2400(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public static int access_22900(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int access$2900(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._fspan;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int access$2900(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public static void access_23000(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1, global::com.codename1.ui.layouts.mig.DimConstraint n2, int n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void access$3000(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup, com.codename1.ui.layouts.mig.DimConstraint, int, int, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r0_o = n1;
    _r1_o = n2;
    _r2.i = n3;
    _r3.i = n4;
    _r4.i = n5;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r0_o).layout((global::com.codename1.ui.layouts.mig.DimConstraint) _r1_o, (int) _r2.i, (int) _r3.i, (int) _r4.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void access$3000(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup, com.codename1.ui.layouts.mig.DimConstraint, int, int, int)]
}

public static global::System.Object access_23300(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int[] access$3300(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o).getMinPrefMax();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: int[] access$3300(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public void @this(global::java.lang.String n1, int n2, int n3, bool n4, bool n5, global::com.codename1.ui.layouts.mig.Grid_21 n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void <init>(java.lang.String, int, int, boolean, boolean, com.codename1.ui.layouts.mig.Grid$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3.i = n3;
    _r4.i = n4 ? 1 : 0;
    _r5.i = n5 ? 1 : 0;
    _r6_o = n6;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i, (int) _r3.i, 0!=_r4.i, 0!=_r5.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void <init>(java.lang.String, int, int, boolean, boolean, com.codename1.ui.layouts.mig.Grid$1)]
}

public static void access_23600(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1, global::java.util.ArrayList n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void access$3600(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup, java.util.ArrayList)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = n1;
    _r1_o = n2;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r0_o).setCompWraps((global::java.util.ArrayList) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void access$3600(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup, java.util.ArrayList)]
}

public static global::System.Object access_23800(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: java.lang.String access$3800(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r1_o)._flinkCtx;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: java.lang.String access$3800(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup)]
}

public static void access_23900(global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup n1, global::com.codename1.ui.layouts.mig.Grid_2CompWrap n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void access$3900(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup, com.codename1.ui.layouts.mig.Grid$CompWrap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = n1;
    _r1_o = n2;
    ((global::com.codename1.ui.layouts.mig.Grid_2LinkedDimGroup) _r0_o).addCompWrap((global::com.codename1.ui.layouts.mig.Grid_2CompWrap) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup: void access$3900(com.codename1.ui.layouts.mig.Grid$LinkedDimGroup, com.codename1.ui.layouts.mig.Grid$CompWrap)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.mig.Grid$LinkedDimGroup]

} // end of class: Grid_2LinkedDimGroup

} // end of namespace: com.codename1.ui.layouts.mig
