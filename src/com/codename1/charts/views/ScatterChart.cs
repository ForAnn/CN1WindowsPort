// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class ScatterChart: global::com.codename1.charts.views.XYChart {

static ScatterChart() {
    // Value=Scatter
    _fTYPE = new global::java.lang.String();
    _fTYPE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
}

public static global::java.lang.String _fTYPE;

private static float _fSIZE = (float)3.0D;

private static int _fSHAPE_1WIDTH = 10;

private float _fsize;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::com.codename1.charts.views.XYChart) _r1_o).@this();
    _r0.f = (float)3.0D;
    ((global::com.codename1.charts.views.ScatterChart) _r1_o)._fsize = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void <init>()]
}

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
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
    _r3_o = n2;
    ((global::com.codename1.charts.views.XYChart) _r1_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o);
    _r0.f = (float)3.0D;
    ((global::com.codename1.charts.views.ScatterChart) _r1_o)._fsize = _r0.f;
    _r0.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o).getPointSize();
    ((global::com.codename1.charts.views.ScatterChart) _r1_o)._fsize = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
}

public override void setDatasetRenderer(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void setDatasetRenderer(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
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
    _r3_o = n2;
    base.setDatasetRenderer((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r2_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o);
    _r0.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r3_o).getPointSize();
    ((global::com.codename1.charts.views.ScatterChart) _r1_o)._fsize = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void setDatasetRenderer(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
}

public override void drawSeries(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::java.util.List n3, global::com.codename1.charts.renderers.XYSeriesRenderer n4, float n5, int n6, int n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11_o = n1;
    _r12_o = n2;
    _r13_o = n3;
    _r14_o = n4;
    _r15.f = n5;
    _r16.i = n6;
    _r17.i = n7;
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r14_o).getColor();
    ((global::com.codename1.charts.compat.Paint) _r12_o).setColor((int) _r0.i);
    _r9.f = ((global::com.codename1.charts.compat.Paint) _r12_o).getStrokeWidth();
    _r0.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r14_o).isFillPoints() ? 1 : 0;
    if (_r0.i == 0) goto label72;
    _r0_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    ((global::com.codename1.charts.compat.Paint) _r12_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r0_o);
    label22:;
    _r7.i = ((global::java.util.List) _r13_o).size();
    _r8_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r14_o).getPointStyle();
    _r0_o = global::com.codename1.charts.views.PointStyle._fX;
    if (_r8_o != _r0_o) goto label85;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r14_o).getPointStrokeWidth();
    ((global::com.codename1.charts.compat.Paint) _r12_o).setStrokeWidth((float) _r0.f);
    _r6.i = 0;
    label42:;
    if (_r6.i >= _r7.i) goto label265;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r6.i);
    _r14_o = _r14_o;
    _r0.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r1.i = _r6.i + 1;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r1.i);
    _r14_o = _r14_o;
    _r1.f = ((global::java.lang.Float) _r14_o).floatValue();
    ((global::com.codename1.charts.views.ScatterChart) _r10_o).drawX((global::com.codename1.charts.compat.Canvas) _r11_o, (global::com.codename1.charts.compat.Paint) _r12_o, (float) _r0.f, (float) _r1.f);
    _r6.i = _r6.i + 2;
    goto label42;
    label72:;
    _r0.f = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r14_o).getPointStrokeWidth();
    ((global::com.codename1.charts.compat.Paint) _r12_o).setStrokeWidth((float) _r0.f);
    _r0_o = global::com.codename1.charts.compat.Paint_2Style._fSTROKE;
    ((global::com.codename1.charts.compat.Paint) _r12_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r0_o);
    goto label22;
    label85:;
    _r0_o = global::com.codename1.charts.views.PointStyle._fCIRCLE;
    if (_r8_o != _r0_o) goto label120;
    _r6.i = 0;
    label90:;
    if (_r6.i >= _r7.i) goto label265;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r6.i);
    _r14_o = _r14_o;
    _r0.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r1.i = _r6.i + 1;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r1.i);
    _r14_o = _r14_o;
    _r1.f = ((global::java.lang.Float) _r14_o).floatValue();
    ((global::com.codename1.charts.views.ScatterChart) _r10_o).drawCircle((global::com.codename1.charts.compat.Canvas) _r11_o, (global::com.codename1.charts.compat.Paint) _r12_o, (float) _r0.f, (float) _r1.f);
    _r6.i = _r6.i + 2;
    goto label90;
    label120:;
    _r0_o = global::com.codename1.charts.views.PointStyle._fTRIANGLE;
    if (_r8_o != _r0_o) goto label161;
    _r0.i = 6;
    _r3_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r0.i]);
    _r6.i = 0;
    label128:;
    if (_r6.i >= _r7.i) goto label265;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r6.i);
    _r14_o = _r14_o;
    _r4.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r0.i = _r6.i + 1;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r0.i);
    _r14_o = _r14_o;
    _r5.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r0_o = _r10_o;
    _r1_o = _r11_o;
    _r2_o = _r12_o;
    ((global::com.codename1.charts.views.ScatterChart) _r0_o).drawTriangle((global::com.codename1.charts.compat.Canvas) _r1_o, (global::com.codename1.charts.compat.Paint) _r2_o, (global::org.xmlvm._nArrayAdapter<float>) _r3_o, (float) _r4.f, (float) _r5.f);
    _r6.i = _r6.i + 2;
    goto label128;
    label161:;
    _r0_o = global::com.codename1.charts.views.PointStyle._fSQUARE;
    if (_r8_o != _r0_o) goto label196;
    _r6.i = 0;
    label166:;
    if (_r6.i >= _r7.i) goto label265;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r6.i);
    _r14_o = _r14_o;
    _r0.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r1.i = _r6.i + 1;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r1.i);
    _r14_o = _r14_o;
    _r1.f = ((global::java.lang.Float) _r14_o).floatValue();
    ((global::com.codename1.charts.views.ScatterChart) _r10_o).drawSquare((global::com.codename1.charts.compat.Canvas) _r11_o, (global::com.codename1.charts.compat.Paint) _r12_o, (float) _r0.f, (float) _r1.f);
    _r6.i = _r6.i + 2;
    goto label166;
    label196:;
    _r0_o = global::com.codename1.charts.views.PointStyle._fDIAMOND;
    if (_r8_o != _r0_o) goto label238;
    _r0.i = 8;
    _r3_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r0.i]);
    _r6.i = 0;
    label205:;
    if (_r6.i >= _r7.i) goto label265;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r6.i);
    _r14_o = _r14_o;
    _r4.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r0.i = _r6.i + 1;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r0.i);
    _r14_o = _r14_o;
    _r5.f = ((global::java.lang.Float) _r14_o).floatValue();
    _r0_o = _r10_o;
    _r1_o = _r11_o;
    _r2_o = _r12_o;
    ((global::com.codename1.charts.views.ScatterChart) _r0_o).drawDiamond((global::com.codename1.charts.compat.Canvas) _r1_o, (global::com.codename1.charts.compat.Paint) _r2_o, (global::org.xmlvm._nArrayAdapter<float>) _r3_o, (float) _r4.f, (float) _r5.f);
    _r6.i = _r6.i + 2;
    goto label205;
    label238:;
    _r0_o = global::com.codename1.charts.views.PointStyle._fPOINT;
    if (_r8_o != _r0_o) goto label265;
    _r6.i = 0;
    label243:;
    if (_r6.i >= _r7.i) goto label265;
    _r10_o = ((global::java.util.List) _r13_o).get((int) _r6.i);
    _r10_o = _r10_o;
    _r0.i = _r6.i + 1;
    _r14_o = ((global::java.util.List) _r13_o).get((int) _r0.i);
    _r14_o = _r14_o;
    ((global::com.codename1.charts.compat.Canvas) _r11_o).drawPoint((global::java.lang.Float) _r10_o, (global::java.lang.Float) _r14_o, (global::com.codename1.charts.compat.Paint) _r12_o);
    _r6.i = _r6.i + 2;
    goto label243;
    label265:;
    ((global::com.codename1.charts.compat.Paint) _r12_o).setStrokeWidth((float) _r9.f);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawSeries(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, java.util.List, com.codename1.charts.renderers.XYSeriesRenderer, float, int, int)]
}

public override global::System.Object clickableAreasForPoints(global::java.util.List n1, global::java.util.List n2, float n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r16_o = this;
    _r17_o = n1;
    _r18_o = n2;
    _r19.f = n3;
    _r20.i = n4;
    _r21.i = n5;
    _r11.i = ((global::java.util.List) _r17_o).size();
    _r2.i = _r11.i / 2;
    _r12_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r2.i]);
    _r10.i = 0;
    label9:;
    if (_r10.i >= _r11.i) goto label133;
    _r0_o = _r16_o;
    _r0_o = ((global::com.codename1.charts.views.ScatterChart) _r0_o)._fmRenderer;
    _r2_o = _r0_o;
    _r13.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r2_o).getSelectableBuffer();
    _r14.i = _r10.i / 2;
    _r15_o = new global::com.codename1.charts.views.ClickableArea();
    _r0_o = _r17_o;
    _r1.i = _r10.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r19_o = _r19_o;
    _r2.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r3.f = (float) _r13.i;
    _r2.f = _r2.f - _r3.f;
    _r2.d = (double) _r2.f;
    _r4.i = _r10.i + 1;
    _r0_o = _r17_o;
    _r1.i = _r4.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r19_o = _r19_o;
    _r4.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r5.f = (float) _r13.i;
    _r4.f = _r4.f - _r5.f;
    _r4.d = (double) _r4.f;
    _r0_o = _r17_o;
    _r1.i = _r10.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r19_o = _r19_o;
    _r6.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r7.f = (float) _r13.i;
    _r6.f = _r6.f + _r7.f;
    _r6.d = (double) _r6.f;
    _r8.i = _r10.i + 1;
    _r0_o = _r17_o;
    _r1.i = _r8.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r19_o = _r19_o;
    _r8.f = ((global::java.lang.Float) _r19_o).floatValue();
    _r9.f = (float) _r13.i;
    _r8.f = _r8.f + _r9.f;
    _r8.d = (double) _r8.f;
    _r3_o = global::com.codename1.charts.views.PkgUtils.makeRect((double) _r2.d, (double) _r4.d, (double) _r6.d, (double) _r8.d);
    _r0_o = _r18_o;
    _r1.i = _r10.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r19_o = _r19_o;
    _r4.d = ((global::java.lang.Double) _r19_o).doubleValue();
    _r2.i = _r10.i + 1;
    _r0_o = _r18_o;
    _r1.i = _r2.i;
    _r19_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r19_o = _r19_o;
    _r6.d = ((global::java.lang.Double) _r19_o).doubleValue();
    _r2_o = _r15_o;
    ((global::com.codename1.charts.views.ClickableArea) _r2_o).@this((global::com.codename1.ui.geom.Rectangle2D) _r3_o, (double) _r4.d, (double) _r6.d);
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r14.i] = _r15_o;
    _r10.i = _r10.i + 2;
    goto label9;
    label133:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: com.codename1.charts.views.ClickableArea[] clickableAreasForPoints(java.util.List, java.util.List, float, int, int)]
}

public override int getLegendShapeWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: int getLegendShapeWidth(int)]
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
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: int getLegendShapeWidth(int)]
}

public override void drawLegendShape(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.renderers.SimpleSeriesRenderer n2, float n3, float n4, int n5, global::com.codename1.charts.compat.Paint n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9_o = n1;
    _r10_o = n2;
    _r11.f = n3;
    _r12.f = n4;
    _r13.i = n5;
    _r14_o = n6;
    _r3.i = 8;
    _r2.f = (float)10.0D;
    _r0_o = _r10_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1.i = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r1_o).isFillPoints() ? 1 : 0;
    if (_r1.i == 0) goto label35;
    _r1_o = global::com.codename1.charts.compat.Paint_2Style._fFILL;
    ((global::com.codename1.charts.compat.Paint) _r14_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    label19:;
    _r10_o = _r10_o;
    _r7_o = ((global::com.codename1.charts.renderers.XYSeriesRenderer) _r10_o).getPointStyle();
    _r1_o = global::com.codename1.charts.views.PointStyle._fX;
    if (_r7_o != _r1_o) goto label41;
    _r1.f = _r11.f + _r2.f;
    ((global::com.codename1.charts.views.ScatterChart) _r8_o).drawX((global::com.codename1.charts.compat.Canvas) _r9_o, (global::com.codename1.charts.compat.Paint) _r14_o, (float) _r1.f, (float) _r12.f);
    label34:;
    return;
    label35:;
    _r1_o = global::com.codename1.charts.compat.Paint_2Style._fSTROKE;
    ((global::com.codename1.charts.compat.Paint) _r14_o).setStyle((global::com.codename1.charts.compat.Paint_2Style) _r1_o);
    goto label19;
    label41:;
    _r1_o = global::com.codename1.charts.views.PointStyle._fCIRCLE;
    if (_r7_o != _r1_o) goto label51;
    _r1.f = _r11.f + _r2.f;
    ((global::com.codename1.charts.views.ScatterChart) _r8_o).drawCircle((global::com.codename1.charts.compat.Canvas) _r9_o, (global::com.codename1.charts.compat.Paint) _r14_o, (float) _r1.f, (float) _r12.f);
    goto label34;
    label51:;
    _r1_o = global::com.codename1.charts.views.PointStyle._fTRIANGLE;
    if (_r7_o != _r1_o) goto label68;
    _r1.i = 6;
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r1.i]);
    _r5.f = _r11.f + _r2.f;
    _r1_o = _r8_o;
    _r2_o = _r9_o;
    _r3_o = _r14_o;
    _r6.f = _r12.f;
    ((global::com.codename1.charts.views.ScatterChart) _r1_o).drawTriangle((global::com.codename1.charts.compat.Canvas) _r2_o, (global::com.codename1.charts.compat.Paint) _r3_o, (global::org.xmlvm._nArrayAdapter<float>) _r4_o, (float) _r5.f, (float) _r6.f);
    goto label34;
    label68:;
    _r1_o = global::com.codename1.charts.views.PointStyle._fSQUARE;
    if (_r7_o != _r1_o) goto label78;
    _r1.f = _r11.f + _r2.f;
    ((global::com.codename1.charts.views.ScatterChart) _r8_o).drawSquare((global::com.codename1.charts.compat.Canvas) _r9_o, (global::com.codename1.charts.compat.Paint) _r14_o, (float) _r1.f, (float) _r12.f);
    goto label34;
    label78:;
    _r1_o = global::com.codename1.charts.views.PointStyle._fDIAMOND;
    if (_r7_o != _r1_o) goto label94;
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r3.i]);
    _r5.f = _r11.f + _r2.f;
    _r1_o = _r8_o;
    _r2_o = _r9_o;
    _r3_o = _r14_o;
    _r6.f = _r12.f;
    ((global::com.codename1.charts.views.ScatterChart) _r1_o).drawDiamond((global::com.codename1.charts.compat.Canvas) _r2_o, (global::com.codename1.charts.compat.Paint) _r3_o, (global::org.xmlvm._nArrayAdapter<float>) _r4_o, (float) _r5.f, (float) _r6.f);
    goto label34;
    label94:;
    _r1_o = global::com.codename1.charts.views.PointStyle._fPOINT;
    if (_r7_o != _r1_o) goto label34;
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r3.i]);
    _r5.f = _r11.f + _r2.f;
    _r1_o = _r8_o;
    _r2_o = _r9_o;
    _r3_o = _r14_o;
    _r6.f = _r12.f;
    ((global::com.codename1.charts.views.ScatterChart) _r1_o).drawDiamond((global::com.codename1.charts.compat.Canvas) _r2_o, (global::com.codename1.charts.compat.Paint) _r3_o, (global::org.xmlvm._nArrayAdapter<float>) _r4_o, (float) _r5.f, (float) _r6.f);
    goto label34;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
}

private void drawX(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, float n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawX(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float)]
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
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9.f = n3;
    _r10.f = n4;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r1.f = _r9.f - _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r2.f = _r10.f - _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r3.f = _r9.f + _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r4.f = _r10.f + _r0.f;
    _r0_o = _r7_o;
    _r5_o = _r8_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawLine((float) _r1.f, (float) _r2.f, (float) _r3.f, (float) _r4.f, (global::com.codename1.charts.compat.Paint) _r5_o);
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r1.f = _r9.f + _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r2.f = _r10.f - _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r3.f = _r9.f - _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r4.f = _r10.f + _r0.f;
    _r0_o = _r7_o;
    _r5_o = _r8_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawLine((float) _r1.f, (float) _r2.f, (float) _r3.f, (float) _r4.f, (global::com.codename1.charts.compat.Paint) _r5_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawX(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float)]
}

private void drawCircle(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, float n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawCircle(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4.f = n3;
    _r5.f = n4;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r1_o)._fsize;
    ((global::com.codename1.charts.compat.Canvas) _r2_o).drawCircle((float) _r4.f, (float) _r5.f, (float) _r0.f, (global::com.codename1.charts.compat.Paint) _r3_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawCircle(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float)]
}

private void drawTriangle(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::org.xmlvm._nArrayAdapter<float> n3, float n4, float n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawTriangle(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float[], float, float)]
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
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r8_o = n3;
    _r9.f = n4;
    _r10.f = n5;
    _r4.i = 3;
    _r3.i = 1;
    _r0.i = 0;
    ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r0.i] = _r9.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r5_o)._fsize;
    _r0.f = _r10.f - _r0.f;
    _r1.f = ((global::com.codename1.charts.views.ScatterChart) _r5_o)._fsize;
    _r2.f = (float)2.0D;
    _r1.f = _r1.f / _r2.f;
    _r0.f = _r0.f - _r1.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r3.i] = _r0.f;
    _r0.i = 2;
    _r1.f = ((global::com.codename1.charts.views.ScatterChart) _r5_o)._fsize;
    _r1.f = _r9.f - _r1.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r0.i] = _r1.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r5_o)._fsize;
    _r0.f = _r0.f + _r10.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r4.i] = _r0.f;
    _r0.i = 4;
    _r1.f = ((global::com.codename1.charts.views.ScatterChart) _r5_o)._fsize;
    _r1.f = _r1.f + _r9.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r0.i] = _r1.f;
    _r0.i = 5;
    _r1.f = ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r4.i];
    ((global::org.xmlvm._nArrayAdapter<float>) _r8_o)[_r0.i] = _r1.f;
    ((global::com.codename1.charts.views.ScatterChart) _r5_o).drawPath((global::com.codename1.charts.compat.Canvas) _r6_o, (global::org.xmlvm._nArrayAdapter<float>) _r8_o, (global::com.codename1.charts.compat.Paint) _r7_o, 0!=_r3.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawTriangle(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float[], float, float)]
}

private void drawSquare(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, float n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawSquare(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float)]
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
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9.f = n3;
    _r10.f = n4;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r1.f = _r9.f - _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r2.f = _r10.f - _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r3.f = _r9.f + _r0.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r6_o)._fsize;
    _r4.f = _r10.f + _r0.f;
    _r0_o = _r7_o;
    _r5_o = _r8_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawRect((float) _r1.f, (float) _r2.f, (float) _r3.f, (float) _r4.f, (global::com.codename1.charts.compat.Paint) _r5_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawSquare(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float, float)]
}

private void drawDiamond(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.compat.Paint n2, global::org.xmlvm._nArrayAdapter<float> n3, float n4, float n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: void drawDiamond(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float[], float, float)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r6_o = n3;
    _r7.f = n4;
    _r8.f = n5;
    _r2.i = 1;
    _r0.i = 0;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r7.f;
    _r0.f = ((global::com.codename1.charts.views.ScatterChart) _r3_o)._fsize;
    _r0.f = _r8.f - _r0.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r2.i] = _r0.f;
    _r0.i = 2;
    _r1.f = ((global::com.codename1.charts.views.ScatterChart) _r3_o)._fsize;
    _r1.f = _r7.f - _r1.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r1.f;
    _r0.i = 3;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r8.f;
    _r0.i = 4;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r7.f;
    _r0.i = 5;
    _r1.f = ((global::com.codename1.charts.views.ScatterChart) _r3_o)._fsize;
    _r1.f = _r1.f + _r8.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r1.f;
    _r0.i = 6;
    _r1.f = ((global::com.codename1.charts.views.ScatterChart) _r3_o)._fsize;
    _r1.f = _r1.f + _r7.f;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r1.f;
    _r0.i = 7;
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r8.f;
    ((global::com.codename1.charts.views.ScatterChart) _r3_o).drawPath((global::com.codename1.charts.compat.Canvas) _r4_o, (global::org.xmlvm._nArrayAdapter<float>) _r6_o, (global::com.codename1.charts.compat.Paint) _r5_o, 0!=_r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: void drawDiamond(com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, float[], float, float)]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart: java.lang.String getChartType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=Scatter
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart: java.lang.String getChartType()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.ScatterChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.ScatterChart]

} // end of class: ScatterChart

} // end of namespace: com.codename1.charts.views
