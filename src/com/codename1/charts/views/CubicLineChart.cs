// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class CubicLineChart: global::com.codename1.charts.views.LineChart {

static CubicLineChart() {
    // Value=Cubic
    _fTYPE = new global::java.lang.String();
    _fTYPE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99))}));
}

public static global::java.lang.String _fTYPE;

private float _fmFirstMultiplier;

private float _fmSecondMultiplier;

private global::com.codename1.charts.compat.PathMeasure _fmPathMeasure;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    ((global::com.codename1.charts.views.LineChart) _r2_o).@this();
    _r0.f = (float)0.33D;
    ((global::com.codename1.charts.views.CubicLineChart) _r2_o)._fmFirstMultiplier = _r0.f;
    _r0.f = (float)1.0D;
    _r1.f = ((global::com.codename1.charts.views.CubicLineChart) _r2_o)._fmFirstMultiplier;
    _r0.f = _r0.f - _r1.f;
    ((global::com.codename1.charts.views.CubicLineChart) _r2_o)._fmSecondMultiplier = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart: void <init>()]
}

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2, float n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer, float)]
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
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r5.f = n3;
    ((global::com.codename1.charts.views.LineChart) _r2_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r3_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r4_o);
    ((global::com.codename1.charts.views.CubicLineChart) _r2_o)._fmFirstMultiplier = _r5.f;
    _r0.f = (float)1.0D;
    _r1.f = ((global::com.codename1.charts.views.CubicLineChart) _r2_o)._fmFirstMultiplier;
    _r0.f = _r0.f - _r1.f;
    ((global::com.codename1.charts.views.CubicLineChart) _r2_o)._fmSecondMultiplier = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer, float)]
}

public override void drawPath(global::com.codename1.charts.compat.Canvas n1, global::java.util.List n2, global::com.codename1.charts.compat.Paint n3, bool n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart: void drawPath(com.codename1.charts.compat.Canvas, java.util.List, com.codename1.charts.compat.Paint, boolean)]
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
    global::org.xmlvm._nElement _r26;
    global::System.Object _r26_o = null;
    global::org.xmlvm._nElement _r27;
    global::System.Object _r27_o = null;
    global::org.xmlvm._nElement _r28;
    global::System.Object _r28_o = null;
    global::org.xmlvm._nElement _r29;
    global::System.Object _r29_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r25_o = this;
    _r26_o = n1;
    _r27_o = n2;
    _r28_o = n3;
    _r29.i = n4 ? 1 : 0;
    _r21_o = new global::com.codename1.ui.geom.GeneralPath();
    ((global::com.codename1.ui.geom.GeneralPath) _r21_o).@this();
    _r3.i = 0;
    _r0_o = _r27_o;
    _r1.i = _r3.i;
    _r3_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r3_o = _r3_o;
    _r23.f = ((global::java.lang.Float) _r3_o).floatValue();
    _r3.i = 1;
    _r0_o = _r27_o;
    _r1.i = _r3.i;
    _r3_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r3_o = _r3_o;
    _r24.f = ((global::java.lang.Float) _r3_o).floatValue();
    _r0_o = _r21_o;
    _r1.f = _r23.f;
    _r2.f = _r24.f;
    ((global::com.codename1.ui.geom.GeneralPath) _r0_o).moveTo((float) _r1.f, (float) _r2.f);
    _r20.i = ((global::java.util.List) _r27_o).size();
    if (_r29.i == 0) goto label50;
    _r20.i = _r20.i + -4;
    label50:;
    _r5_o = new global::com.codename1.charts.models.Point();
    ((global::com.codename1.charts.models.Point) _r5_o).@this();
    _r22_o = new global::com.codename1.charts.models.Point();
    ((global::com.codename1.charts.models.Point) _r22_o).@this();
    _r10_o = new global::com.codename1.charts.models.Point();
    ((global::com.codename1.charts.models.Point) _r10_o).@this();
    _r6.i = 0;
    label66:;
    _r0.i = _r6.i;
    _r1.i = _r20.i;
    if (_r0.i >= _r1.i) goto label192;
    _r3.i = _r6.i + 2;
    _r0.i = _r3.i;
    _r1.i = _r20.i;
    if (_r0.i >= _r1.i) goto label188;
    _r3.i = _r6.i + 2;
    _r7.i = _r3.i;
    label81:;
    _r3.i = _r6.i + 4;
    _r0.i = _r3.i;
    _r1.i = _r20.i;
    if (_r0.i >= _r1.i) goto label190;
    _r3.i = _r6.i + 4;
    _r12.i = _r3.i;
    label91:;
    _r0_o = _r25_o;
    _r0.f = ((global::com.codename1.charts.views.CubicLineChart) _r0_o)._fmSecondMultiplier;
    _r8.f = _r0.f;
    _r3_o = _r25_o;
    _r4_o = _r27_o;
    ((global::com.codename1.charts.views.CubicLineChart) _r3_o).calc((global::java.util.List) _r4_o, (global::com.codename1.charts.models.Point) _r5_o, (int) _r6.i, (int) _r7.i, (float) _r8.f);
    _r0_o = _r27_o;
    _r1.i = _r7.i;
    _r3_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r3_o = _r3_o;
    _r3.f = ((global::java.lang.Float) _r3_o).floatValue();
    _r0_o = _r22_o;
    _r1.f = _r3.f;
    ((global::com.codename1.charts.models.Point) _r0_o).setX((float) _r1.f);
    _r3.i = _r7.i + 1;
    _r0_o = _r27_o;
    _r1.i = _r3.i;
    _r3_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r3_o = _r3_o;
    _r3.f = ((global::java.lang.Float) _r3_o).floatValue();
    _r0_o = _r22_o;
    _r1.f = _r3.f;
    ((global::com.codename1.charts.models.Point) _r0_o).setY((float) _r1.f);
    _r0_o = _r25_o;
    _r0.f = ((global::com.codename1.charts.views.CubicLineChart) _r0_o)._fmFirstMultiplier;
    _r13.f = _r0.f;
    _r8_o = _r25_o;
    _r9_o = _r27_o;
    _r11.i = _r7.i;
    ((global::com.codename1.charts.views.CubicLineChart) _r8_o).calc((global::java.util.List) _r9_o, (global::com.codename1.charts.models.Point) _r10_o, (int) _r11.i, (int) _r12.i, (float) _r13.f);
    _r14.f = ((global::com.codename1.charts.models.Point) _r5_o).getX();
    _r15.f = ((global::com.codename1.charts.models.Point) _r5_o).getY();
    _r16.f = ((global::com.codename1.charts.models.Point) _r22_o).getX();
    _r17.f = ((global::com.codename1.charts.models.Point) _r22_o).getY();
    _r18.f = ((global::com.codename1.charts.models.Point) _r10_o).getX();
    _r19.f = ((global::com.codename1.charts.models.Point) _r10_o).getY();
    _r13_o = _r21_o;
    ((global::com.codename1.ui.geom.GeneralPath) _r13_o).curveTo((float) _r14.f, (float) _r15.f, (float) _r16.f, (float) _r17.f, (float) _r18.f, (float) _r19.f);
    _r6.i = _r6.i + 2;
    goto label66;
    label188:;
    _r7.i = _r6.i;
    goto label81;
    label190:;
    _r12.i = _r7.i;
    goto label91;
    label192:;
    _r3_o = new global::com.codename1.charts.compat.PathMeasure();
    _r4.i = 0;
    _r0_o = _r3_o;
    _r1_o = _r21_o;
    _r2.i = _r4.i;
    ((global::com.codename1.charts.compat.PathMeasure) _r0_o).@this((global::com.codename1.ui.geom.GeneralPath) _r1_o, 0!=_r2.i);
    _r0_o = _r3_o;
    _r1_o = _r25_o;
    ((global::com.codename1.charts.views.CubicLineChart) _r1_o)._fmPathMeasure = (global::com.codename1.charts.compat.PathMeasure) _r0_o;
    if (_r29.i == 0) goto label288;
    _r6.i = _r20.i;
    label211:;
    _r3.i = _r20.i + 4;
    if (_r6.i >= _r3.i) goto label253;
    _r0_o = _r27_o;
    _r1.i = _r6.i;
    _r25_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r25_o = _r25_o;
    _r3.f = ((global::java.lang.Float) _r25_o).floatValue();
    _r4.i = _r6.i + 1;
    _r0_o = _r27_o;
    _r1.i = _r4.i;
    _r25_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r25_o = _r25_o;
    _r4.f = ((global::java.lang.Float) _r25_o).floatValue();
    _r0_o = _r21_o;
    _r1.f = _r3.f;
    _r2.f = _r4.f;
    ((global::com.codename1.ui.geom.GeneralPath) _r0_o).lineTo((float) _r1.f, (float) _r2.f);
    _r6.i = _r6.i + 2;
    goto label211;
    label253:;
    _r3.i = 0;
    _r0_o = _r27_o;
    _r1.i = _r3.i;
    _r25_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r25_o = _r25_o;
    _r3.f = ((global::java.lang.Float) _r25_o).floatValue();
    _r4.i = 1;
    _r0_o = _r27_o;
    _r1.i = _r4.i;
    _r25_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r25_o = _r25_o;
    _r4.f = ((global::java.lang.Float) _r25_o).floatValue();
    _r0_o = _r21_o;
    _r1.f = _r3.f;
    _r2.f = _r4.f;
    ((global::com.codename1.ui.geom.GeneralPath) _r0_o).lineTo((float) _r1.f, (float) _r2.f);
    label288:;
    _r0_o = _r26_o;
    _r1_o = _r21_o;
    _r2_o = _r28_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawPath((global::com.codename1.ui.geom.Shape) _r1_o, (global::com.codename1.charts.compat.Paint) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart: void drawPath(com.codename1.charts.compat.Canvas, java.util.List, com.codename1.charts.compat.Paint, boolean)]
}

private void calc(global::java.util.List n1, global::com.codename1.charts.models.Point n2, int n3, int n4, float n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart: void calc(java.util.List, com.codename1.charts.models.Point, int, int, float)]
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
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r10.i = n3;
    _r11.i = n4;
    _r12.f = n5;
    _r7_o = ((global::java.util.List) _r8_o).get((int) _r10.i);
    _r7_o = _r7_o;
    _r2.f = ((global::java.lang.Float) _r7_o).floatValue();
    _r6.i = _r10.i + 1;
    _r7_o = ((global::java.util.List) _r8_o).get((int) _r6.i);
    _r7_o = _r7_o;
    _r3.f = ((global::java.lang.Float) _r7_o).floatValue();
    _r7_o = ((global::java.util.List) _r8_o).get((int) _r11.i);
    _r7_o = _r7_o;
    _r4.f = ((global::java.lang.Float) _r7_o).floatValue();
    _r6.i = _r11.i + 1;
    _r7_o = ((global::java.util.List) _r8_o).get((int) _r6.i);
    _r7_o = _r7_o;
    _r5.f = ((global::java.lang.Float) _r7_o).floatValue();
    _r0.f = _r4.f - _r2.f;
    _r1.f = _r5.f - _r3.f;
    _r6.f = _r0.f * _r12.f;
    _r6.f = _r6.f + _r2.f;
    ((global::com.codename1.charts.models.Point) _r9_o).setX((float) _r6.f);
    _r6.f = _r1.f * _r12.f;
    _r6.f = _r6.f + _r3.f;
    ((global::com.codename1.charts.models.Point) _r9_o).setY((float) _r6.f);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart: void calc(java.util.List, com.codename1.charts.models.Point, int, int, float)]
}

public override void drawPoints(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::java.util.List n3, global::com.codename1.charts.renderers.XYSeriesRenderer n4, float n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart: void drawPoints(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
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
    global::org.xmlvm._nElement _r26;
    global::System.Object _r26_o = null;
    global::org.xmlvm._nElement _r27;
    global::System.Object _r27_o = null;
    global::org.xmlvm._nElement _r28;
    global::System.Object _r28_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r21_o = this;
    _r22_o = n1;
    _r23_o = n2;
    _r24_o = n3;
    _r25_o = n4;
    _r26.f = n5;
    _r27.i = n6;
    _r28.i = n7;
    _r0_o = _r21_o;
    _r1_o = _r25_o;
    _r4.i = ((global::com.codename1.charts.views.CubicLineChart) _r0_o).isRenderPoints((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o) ? 1 : 0;
    if (_r4.i == 0) goto label146;
    _r3_o = ((global::com.codename1.charts.views.CubicLineChart) _r21_o).getPointsChart();
    if (_r3_o == null) goto label146;
    _r0_o = _r21_o;
    _r0_o = ((global::com.codename1.charts.views.CubicLineChart) _r0_o)._fmPathMeasure;
    _r4_o = _r0_o;
    _r4.f = ((global::com.codename1.charts.compat.PathMeasure) _r4_o).getLength();
    _r0.f = _r4.f;
    _r0.i = (int) _r0.f;
    _r16.i = _r0.i;
    _r18.i = ((global::java.util.List) _r24_o).size();
    _r4.i = 2;
    _r11_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r4.i]);
    _r14.i = 0;
    label37:;
    _r0.i = _r14.i;
    _r1.i = _r16.i;
    if (_r0.i >= _r1.i) goto label129;
    _r0_o = _r21_o;
    _r0_o = ((global::com.codename1.charts.views.CubicLineChart) _r0_o)._fmPathMeasure;
    _r4_o = _r0_o;
    _r5_o = null;
    ((global::com.codename1.charts.compat.PathMeasure) _r4_o).getPosTan((int) _r14.i, (global::org.xmlvm._nArrayAdapter<float>) _r11_o, (global::org.xmlvm._nArrayAdapter<float>) _r5_o);
    _r19.d = 1.7976931348623157E308D;
    _r17.i = 1;
    _r15.i = 0;
    label59:;
    _r0.i = _r15.i;
    _r1.i = _r18.i;
    if (_r0.i >= _r1.i) goto label126;
    if (_r17.i == 0) goto label126;
    _r0_o = _r24_o;
    _r1.i = _r15.i;
    _r4_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r4_o = _r4_o;
    _r4.f = ((global::java.lang.Float) _r4_o).floatValue();
    _r5.i = 0;
    _r5.f = ((global::org.xmlvm._nArrayAdapter<float>) _r11_o)[_r5.i];
    _r4.f = _r4.f - _r5.f;
    _r4.f = global::java.lang.Math.abs((float) _r4.f);
    _r12.d = (double) _r4.f;
    _r4.d = 1.0D;
    _r4.i = _r12.d > _r4.d ? 1 : (_r12.d == _r4.d ? 0 : -1);
    if (_r4.i >= 0) goto label112;
    _r4.i = _r15.i + 1;
    _r5.i = 1;
    _r5.f = ((global::org.xmlvm._nArrayAdapter<float>) _r11_o)[_r5.i];
    _r5_o = global::java.lang.Float.valueOf((float) _r5.f);
    _r0_o = _r24_o;
    _r1.i = _r4.i;
    _r2_o = _r5_o;
    ((global::java.util.List) _r0_o).set((int) _r1.i, (global::java.lang.Object) _r2_o);
    _r19.d = _r12.d;
    label112:;
    _r4.i = _r19.d > _r12.d ? 1 : (_r19.d == _r12.d ? 0 : -1);
    if (_r4.i <= 0) goto label122;
    _r4.i = 1;
    _r17.i = _r4.i;
    label119:;
    _r15.i = _r15.i + 2;
    goto label59;
    label122:;
    _r4.i = 0;
    _r17.i = _r4.i;
    goto label119;
    label126:;
    _r14.i = _r14.i + 1;
    goto label37;
    label129:;
    _r4_o = _r22_o;
    _r5_o = _r23_o;
    _r6_o = _r24_o;
    _r7_o = _r25_o;
    _r8.f = _r26.f;
    _r9.i = _r27.i;
    _r10.i = _r28.i;
    ((global::com.codename1.charts.views.ScatterChart) _r3_o).drawSeries((global::com.codename1.charts.compat.Canvas) _r4_o, (global::com.codename1.charts.compat.Paint) _r5_o, (global::java.util.List) _r6_o, (global::com.codename1.charts.renderers.XYSeriesRenderer) _r7_o, (float) _r8.f, (int) _r9.i, (int) _r10.i);
    label146:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart: void drawPoints(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart: java.lang.String getChartType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=Cubic
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart: java.lang.String getChartType()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.CubicLineChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.CubicLineChart]

} // end of class: CubicLineChart

} // end of namespace: com.codename1.charts.views
