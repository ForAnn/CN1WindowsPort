// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.layouts {
public class GridBagLayout_2Grid: global::java.lang.Object {
private global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide _fcols;

private global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide _frows;

public global::com.codename1.ui.layouts.GridBagLayout _fthis_20;

private void @this(global::com.codename1.ui.layouts.GridBagLayout n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void <init>(com.codename1.ui.layouts.GridBagLayout)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r1_o = null;
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r2_o)._fthis_20 = (global::com.codename1.ui.layouts.GridBagLayout) _r3_o;
    ((global::java.lang.Object) _r2_o).@this();
    _r0_o = new global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide();
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).@this((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r2_o, (global::com.codename1.ui.layouts.GridBagLayout_21) _r1_o);
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r2_o)._fcols = (global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o;
    _r0_o = new global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide();
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).@this((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r2_o, (global::com.codename1.ui.layouts.GridBagLayout_21) _r1_o);
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r2_o)._frows = (global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void <init>(com.codename1.ui.layouts.GridBagLayout)]
}

public virtual void validate(global::com.codename1.ui.layouts.GridBagLayout_2ParentInfo n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void validate(com.codename1.ui.layouts.GridBagLayout$ParentInfo)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r4_o)._fcols;
    _r1_o = ((global::com.codename1.ui.layouts.GridBagLayout_2ParentInfo) _r5_o)._fhorCompSides;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r4_o)._fthis_20;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout) _r2_o)._fcolumnWidths;
    _r3_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r4_o)._fthis_20;
    _r3_o = ((global::com.codename1.ui.layouts.GridBagLayout) _r3_o)._fcolumnWeights;
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).validate((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::org.xmlvm._nArrayAdapter<int>) _r2_o, (global::org.xmlvm._nArrayAdapter<double>) _r3_o);
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r4_o)._frows;
    _r1_o = ((global::com.codename1.ui.layouts.GridBagLayout_2ParentInfo) _r5_o)._fvertCompSides;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r4_o)._fthis_20;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout) _r2_o)._frowHeights;
    _r3_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r4_o)._fthis_20;
    _r3_o = ((global::com.codename1.ui.layouts.GridBagLayout) _r3_o)._frowWeights;
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).validate((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o, (global::org.xmlvm._nArrayAdapter<int>) _r2_o, (global::org.xmlvm._nArrayAdapter<double>) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void validate(com.codename1.ui.layouts.GridBagLayout$ParentInfo)]
}

public virtual global::System.Object minimumSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: com.codename1.ui.geom.Dimension minimumSize()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = new global::com.codename1.ui.geom.Dimension();
    _r1_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r3_o)._fcols;
    _r1.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r1_o).getMinLength();
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r3_o)._frows;
    _r2.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).getMinLength();
    ((global::com.codename1.ui.geom.Dimension) _r0_o).@this((int) _r1.i, (int) _r2.i);
    return (global::com.codename1.ui.geom.Dimension) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: com.codename1.ui.geom.Dimension minimumSize()]
}

public virtual global::System.Object preferredSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: com.codename1.ui.geom.Dimension preferredSize()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = new global::com.codename1.ui.geom.Dimension();
    _r1_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r3_o)._fcols;
    _r1.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r1_o).getPrefLength();
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r3_o)._frows;
    _r2.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).getPrefLength();
    ((global::com.codename1.ui.geom.Dimension) _r0_o).@this((int) _r1.i, (int) _r2.i);
    return (global::com.codename1.ui.geom.Dimension) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: com.codename1.ui.geom.Dimension preferredSize()]
}

public virtual global::System.Object componentDisplayArea(global::com.codename1.ui.layouts.GridBagLayout_2ComponentSide n1, global::com.codename1.ui.layouts.GridBagLayout_2ComponentSide n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: com.codename1.ui.geom.Rectangle componentDisplayArea(com.codename1.ui.layouts.GridBagLayout$ComponentSide, com.codename1.ui.layouts.GridBagLayout$ComponentSide)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r7_o)._fcols;
    _r3.i = ((global::com.codename1.ui.layouts.GridBagLayout_2ComponentSide) _r8_o)._fgridStart;
    _r4.i = ((global::com.codename1.ui.layouts.GridBagLayout_2ComponentSide) _r8_o)._fgridLength;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).componentDisplaySide((int) _r3.i, (int) _r4.i);
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r7_o)._frows;
    _r3.i = ((global::com.codename1.ui.layouts.GridBagLayout_2ComponentSide) _r9_o)._fgridStart;
    _r4.i = ((global::com.codename1.ui.layouts.GridBagLayout_2ComponentSide) _r9_o)._fgridLength;
    _r1_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).componentDisplaySide((int) _r3.i, (int) _r4.i);
    _r2_o = new global::com.codename1.ui.geom.Rectangle();
    _r3.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r0_o)._fstart;
    _r4.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r1_o)._fstart;
    _r5.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r0_o)._flength;
    _r6.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r1_o)._flength;
    ((global::com.codename1.ui.geom.Rectangle) _r2_o).@this((int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    return (global::com.codename1.ui.geom.Rectangle) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: com.codename1.ui.geom.Rectangle componentDisplayArea(com.codename1.ui.layouts.GridBagLayout$ComponentSide, com.codename1.ui.layouts.GridBagLayout$ComponentSide)]
}

public virtual void fit2Client(global::com.codename1.ui.geom.Rectangle n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void fit2Client(com.codename1.ui.geom.Rectangle)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r0_o = new global::com.codename1.ui.layouts.GridBagLayout_2Segment();
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r5_o)._fthis_20;
    _r3.i = ((global::com.codename1.ui.geom.Rectangle) _r6_o).getX();
    _r4.i = ((global::com.codename1.ui.geom.Rectangle) _r6_o).getWidth();
    ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r0_o).@this((global::com.codename1.ui.layouts.GridBagLayout) _r2_o, (int) _r3.i, (int) _r4.i);
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r5_o)._fcols;
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).fit2Client((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r0_o);
    _r2.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r0_o)._fstart;
    ((global::com.codename1.ui.geom.Rectangle) _r6_o).setX((int) _r2.i);
    _r2.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r0_o)._flength;
    ((global::com.codename1.ui.geom.Rectangle) _r6_o).setWidth((int) _r2.i);
    _r1_o = new global::com.codename1.ui.layouts.GridBagLayout_2Segment();
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r5_o)._fthis_20;
    _r3.i = ((global::com.codename1.ui.geom.Rectangle) _r6_o).getY();
    _r4.i = ((global::com.codename1.ui.geom.Rectangle) _r6_o).getHeight();
    ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r1_o).@this((global::com.codename1.ui.layouts.GridBagLayout) _r2_o, (int) _r3.i, (int) _r4.i);
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r5_o)._frows;
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).fit2Client((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r1_o);
    _r2.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r1_o)._fstart;
    ((global::com.codename1.ui.geom.Rectangle) _r6_o).setY((int) _r2.i);
    _r2.i = ((global::com.codename1.ui.layouts.GridBagLayout_2Segment) _r1_o)._flength;
    ((global::com.codename1.ui.geom.Rectangle) _r6_o).setHeight((int) _r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void fit2Client(com.codename1.ui.geom.Rectangle)]
}

public virtual global::System.Object getWidths(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] getWidths()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._fcols;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).getLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] getWidths()]
}

public virtual global::System.Object getHeights(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] getHeights()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._frows;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).getLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] getHeights()]
}

public virtual global::System.Object lookupWidths(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupWidths()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._fcols;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).lookupLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupWidths()]
}

public virtual global::System.Object lookupHeights(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupHeights()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._frows;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).lookupLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupHeights()]
}

public virtual global::System.Object lookupMinWidths(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupMinWidths()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._fcols;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).lookupMinLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupMinWidths()]
}

public virtual global::System.Object lookupMinHeights(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupMinHeights()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._frows;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).lookupMinLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupMinHeights()]
}

public virtual global::System.Object lookupPrefWidths(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupPrefWidths()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._fcols;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).lookupPrefLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupPrefWidths()]
}

public virtual global::System.Object lookupPrefHeights(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupPrefHeights()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r1_o)._frows;
    _r0_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r0_o).lookupPrefLengths();
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: int[] lookupPrefHeights()]
}

public virtual global::System.Object getWeights(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: double[][] getWeights()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 2;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r3_o)._fcols;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).getWeights();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 1;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r3_o)._frows;
    _r2_o = ((global::com.codename1.ui.layouts.GridBagLayout_2Grid_2GridSide) _r2_o).getWeights();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: double[][] getWeights()]
}

public void @this(global::com.codename1.ui.layouts.GridBagLayout n1, global::com.codename1.ui.layouts.GridBagLayout_21 n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void <init>(com.codename1.ui.layouts.GridBagLayout, com.codename1.ui.layouts.GridBagLayout$1)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.ui.layouts.GridBagLayout_2Grid) _r0_o).@this((global::com.codename1.ui.layouts.GridBagLayout) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid: void <init>(com.codename1.ui.layouts.GridBagLayout, com.codename1.ui.layouts.GridBagLayout$1)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid]
//XMLVM_END_WRAPPER[com.codename1.ui.layouts.GridBagLayout$Grid]

} // end of class: GridBagLayout_2Grid

} // end of namespace: com.codename1.ui.layouts
