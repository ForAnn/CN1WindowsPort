// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class BubbleChart: global::com.codename1.charts.views.XYChart {

static BubbleChart() {
    // Value=Bubble
    _fTYPE = new global::java.lang.String();
    _fTYPE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
}

public static global::java.lang.String _fTYPE;

private static int _fSHAPE_1WIDTH = 10;

private static int _fMIN_1BUBBLE_1SIZE = 2;

private static int _fMAX_1BUBBLE_1SIZE = 20;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::com.codename1.charts.views.XYChart) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: void <init>()]
}

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.charts.views.XYChart) _r0_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
}

public override void drawSeries(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::java.util.List n3, global::com.codename1.charts.renderers.XYSeriesRenderer n4, float n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
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
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r17_o = this;
    _r18_o = n1;
    _r19_o = n2;
    _r20_o = n3;
    _r21_o = n4;
    _r22.f = n5;
    _r23.i = n6;
    _r24.i = n7;
    _r2.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r21_o).getColor();
    _r0_o = _r19_o;
    _r1.i = _r2.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r2_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    _r0_o = _r19_o;
    _r1_o = _r2_o;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    _r11.i = ((global::java.util.List) _r20_o).size();
    _r0_o = _r17_o;
    _r0_o = ((global::com.codename1.charts.views.BubbleChart) _r0_o)._fmDataset;
    _r2_o = _r0_o;
    _r0_o = _r2_o;
    _r1.i = _r23.i;
    _r14_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r0_o).getSeriesAt((int) _r1.i);
    _r14_o = _r14_o;
    _r12.d = ((global::com.codename1.charts.models.XYValueSeries) _r14_o).getMaxValue();
    _r2.d = 20.0D;
    _r8.d = _r2.d / _r12.d;
    _r10.i = 0;
    label45:;
    if (_r10.i >= _r11.i) goto label101;
    _r2.i = _r10.i / 2;
    _r2.i = _r2.i + _r24.i;
    _r2.d = ((global::com.codename1.charts.models.XYValueSeries) _r14_o).getValue((int) _r2.i);
    _r2.d = _r2.d * _r8.d;
    _r4.d = 2.0D;
    _r15.d = _r2.d + _r4.d;
    _r0_o = _r20_o;
    _r1.i = _r10.i;
    _r21_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r21_o = _r21_o;
    _r5.f = ((global::java.lang.Float) _r21_o).floatValue();
    _r2.i = _r10.i + 1;
    _r0_o = _r20_o;
    _r1.i = _r2.i;
    _r21_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r21_o = _r21_o;
    _r6.f = ((global::java.lang.Float) _r21_o).floatValue();
    _r7.f = (float) _r15.d;
    _r2_o = _r17_o;
    _r3_o = _r18_o;
    _r4_o = _r19_o;
    ((global::com.codename1.charts.views.BubbleChart) _r2_o).drawCircle((global::com.codename1.charts.compat.Canvas) _r3_o, (global::com.codename1.charts.compat.Paint) _r4_o, (float) _r5.f, (float) _r6.f, (float) _r7.f);
    _r10.i = _r10.i + 2;
    goto label45;
    label101:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
}

public override global::System.Object clickableAreasForPoints(global::java.util.List n1, global::java.util.List n2, float n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
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
    global::org.xmlvm._nElement _r16;
    global::System.Object _r16_o = null;
    global::org.xmlvm._nElement _r17;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::System.Object _r18_o = null;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r19_o = null;
    global::org.xmlvm._nElement _r20;
    global::System.Object _r20_o = null;
    global::org.xmlvm._nElement _r21;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::System.Object _r23_o = null;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::org.xmlvm._nElement _r25;
    global::System.Object _r25_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r20_o = this;
    _r21_o = n1;
    _r22_o = n2;
    _r23.f = n3;
    _r24.i = n4;
    _r25.i = n5;
    _r13.i = ((global::java.util.List) _r21_o).size();
    _r0_o = _r20_o;
    _r0_o = ((global::com.codename1.charts.views.BubbleChart) _r0_o)._fmDataset;
    _r2_o = _r0_o;
    _r0_o = _r2_o;
    _r1.i = _r24.i;
    _r17_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r0_o).getSeriesAt((int) _r1.i);
    _r17_o = _r17_o;
    _r14.d = ((global::com.codename1.charts.models.XYValueSeries) _r17_o).getMaxValue();
    _r2.d = 20.0D;
    _r10.d = _r2.d / _r14.d;
    _r2.i = _r13.i / 2;
    _r0.i = _r2.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r16_o = _r0_o;
    _r12.i = 0;
    label34:;
    if (_r12.i >= _r13.i) goto label178;
    _r2.i = _r12.i / 2;
    _r2.i = _r2.i + _r25.i;
    _r0_o = _r17_o;
    _r1.i = _r2.i;
    _r2.d = ((global::com.codename1.charts.models.XYValueSeries) _r0_o).getValue((int) _r1.i);
    _r2.d = _r2.d * _r10.d;
    _r4.d = 2.0D;
    _r18.d = _r2.d + _r4.d;
    _r14.i = _r12.i / 2;
    _r15_o = new global::com.codename1.charts.views.ClickableArea();
    _r0_o = _r21_o;
    _r1.i = _r12.i;
    _r20_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r20_o = _r20_o;
    _r2.f = ((global::java.lang.Float) _r20_o).floatValue();
    _r0.d = _r18.d;
    _r0.f = (float) _r0.d;
    _r3.f = _r0.f;
    _r2.f = _r2.f - _r3.f;
    _r2.d = (double) _r2.f;
    _r4.i = _r12.i + 1;
    _r0_o = _r21_o;
    _r1.i = _r4.i;
    _r20_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r20_o = _r20_o;
    _r4.f = ((global::java.lang.Float) _r20_o).floatValue();
    _r0.d = _r18.d;
    _r0.f = (float) _r0.d;
    _r5.f = _r0.f;
    _r4.f = _r4.f - _r5.f;
    _r4.d = (double) _r4.f;
    _r0_o = _r21_o;
    _r1.i = _r12.i;
    _r20_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r20_o = _r20_o;
    _r6.f = ((global::java.lang.Float) _r20_o).floatValue();
    _r0.d = _r18.d;
    _r0.f = (float) _r0.d;
    _r7.f = _r0.f;
    _r6.f = _r6.f + _r7.f;
    _r6.d = (double) _r6.f;
    _r8.i = _r12.i + 1;
    _r0_o = _r21_o;
    _r1.i = _r8.i;
    _r20_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r20_o = _r20_o;
    _r8.f = ((global::java.lang.Float) _r20_o).floatValue();
    _r0.d = _r18.d;
    _r0.f = (float) _r0.d;
    _r9.f = _r0.f;
    _r8.f = _r8.f + _r9.f;
    _r8.d = (double) _r8.f;
    _r3_o = global::com.codename1.charts.views.PkgUtils.makeRect((double) _r2.d, (double) _r4.d, (double) _r6.d, (double) _r8.d);
    _r0_o = _r22_o;
    _r1.i = _r12.i;
    _r20_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r20_o = _r20_o;
    _r4.d = ((global::java.lang.Double) _r20_o).doubleValue();
    _r2.i = _r12.i + 1;
    _r0_o = _r22_o;
    _r1.i = _r2.i;
    _r20_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r20_o = _r20_o;
    _r6.d = ((global::java.lang.Double) _r20_o).doubleValue();
    _r2_o = _r15_o;
    ((global::com.codename1.charts.views.ClickableArea) _r2_o).@this((global::com.codename1.ui.geom.Rectangle2D) _r3_o, (double) _r4.d, (double) _r6.d);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r16_o)[_r14.i] = _r15_o;
    _r12.i = _r12.i + 2;
    goto label34;
    label178:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r16_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
}

public override int getLegendShapeWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: int getLegendShapeWidth(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = 10;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: int getLegendShapeWidth(int)]
}

public override void drawLegendShape(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.renderers.SimpleSeriesRenderer n2, float n3, float n4, int n5, global::com.codename1.charts.compat.Paint n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
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
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9.f = n3;
    _r10.f = n4;
    _r11.i = n5;
    _r12_o = n6;
    _r0_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    ((global::com.codename1.charts.compat.Paint) _r12_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r0_o);
    _r0.f = (float)10.0D;
    _r3.f = _r9.f + _r0.f;
    _r5.f = (float)3.0D;
    _r0_o = _r6_o;
    _r1_o = _r7_o;
    _r2_o = _r12_o;
    _r4.f = _r10.f;
    ((global::com.codename1.charts.views.BubbleChart) _r0_o).drawCircle((global::com.codename1.charts.compat.Canvas) _r1_o, (global::com.codename1.charts.compat.Paint) _r2_o, (float) _r3.f, (float) _r4.f, (float) _r5.f);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
}

private void drawCircle(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, float n3, float n4, float n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: void drawCircle(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float, float)]
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
    _r3.f = n3;
    _r4.f = n4;
    _r5.f = n5;
    ((global::com.codename1.charts.compat.Canvas) _r1_o).drawCircle((float) _r3.f, (float) _r4.f, (float) _r5.f, (global::com.codename1.charts.compat.Paint) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: void drawCircle(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float, float)]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart: java.lang.String getChartType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=Bubble
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)66)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart: java.lang.String getChartType()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.BubbleChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.BubbleChart]

} // end of class: BubbleChart

} // end of namespace: com.codename1.charts.views
