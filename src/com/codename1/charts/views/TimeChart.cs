// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public class TimeChart: global::com.codename1.charts.views.LineChart {

static TimeChart() {
    // Value=Time
    _fTYPE = new global::java.lang.String();
    _fTYPE.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
}



public static global::java.lang.String _fTYPE;

public static long _fDAY = 86400000L;

private global::java.lang.String _fmDateFormat;

private global::java.lang.Double _fmStartPoint;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::com.codename1.charts.views.LineChart) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: void <init>()]
}

public void @this(global::com.codename1.charts.models.XYMultipleSeriesDataset n1, global::com.codename1.charts.renderers.XYMultipleSeriesRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::com.codename1.charts.views.LineChart) _r0_o).@this((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r1_o, (global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: void <init>(com.codename1.charts.models.XYMultipleSeriesDataset, com.codename1.charts.renderers.XYMultipleSeriesRenderer)]
}

public virtual global::System.Object getDateFormat(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: java.lang.String getDateFormat()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r1_o)._fmDateFormat;
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: java.lang.String getDateFormat()]
}

public virtual void setDateFormat(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: void setDateFormat(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmDateFormat = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: void setDateFormat(java.lang.String)]
}

public override void drawXLabels(global::java.util.List n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, global::com.codename1.charts.compat.Canvas n3, global::com.codename1.charts.compat.Paint n4, int n5, int n6, int n7, double n8, double n9, double n10){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: void drawXLabels(java.util.List, java.lang.Double[], com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, int, int, int, double, double, double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r17;
    global::org.xmlvm._nElement _r19;
    global::System.Object _r21_o = null;
    global::org.xmlvm._nElement _r22;
    global::org.xmlvm._nElement _r23;
    global::org.xmlvm._nElement _r25;
    global::org.xmlvm._nElement _r26;
    global::org.xmlvm._nElement _r27;
    global::org.xmlvm._nElement _r28;
    global::System.Object _r29_o = null;
    global::System.Object _r30_o = null;
    global::System.Object _r31_o = null;
    global::System.Object _r32_o = null;
    global::System.Object _r33_o = null;
    global::org.xmlvm._nElement _r34;
    global::org.xmlvm._nElement _r35;
    global::org.xmlvm._nElement _r36;
    global::org.xmlvm._nElement _r37;
    global::org.xmlvm._nElement _r39;
    global::org.xmlvm._nElement _r41;
    _r29_o = this;
    _r30_o = n1;
    _r31_o = n2;
    _r32_o = n3;
    _r33_o = n4;
    _r34.i = n5;
    _r35.i = n6;
    _r36.i = n7;
    _r37.d = n8;
    _r39.d = n9;
    _r41.d = n10;
    _r25.i = ((global::java.util.List) _r30_o).size();
    if (_r25.i <= 0) goto label263;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r5_o = _r0_o;
    _r27.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r5_o).isShowLabels() ? 1 : 0;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r5_o = _r0_o;
    _r26.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r5_o).isShowGridY() ? 1 : 0;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r5_o = _r0_o;
    _r28.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r5_o).isShowTickMarks() ? 1 : 0;
    _r5.i = 0;
    _r0_o = _r30_o;
    _r1.i = _r5.i;
    _r5_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r5_o = _r5_o;
    _r7.d = ((global::java.lang.Double) _r5_o).doubleValue();
    _r5.i = 1;
    _r5.i = _r25.i - _r5.i;
    _r0_o = _r30_o;
    _r1.i = _r5.i;
    _r5_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r5_o = _r5_o;
    _r9.d = ((global::java.lang.Double) _r5_o).doubleValue();
    _r0_o = _r29_o;
    _r1.d = _r7.d;
    _r3.d = _r9.d;
    _r21_o = ((global::com.codename1.charts.views.TimeChart) _r0_o).getDateFormat((double) _r1.d, (double) _r3.d);
    _r22.i = 0;
    label73:;
    _r0.i = _r22.i;
    _r1.i = _r25.i;
    if (_r0.i >= _r1.i) goto label263;
    _r0_o = _r30_o;
    _r1.i = _r22.i;
    _r5_o = ((global::java.util.List) _r0_o).get((int) _r1.i);
    _r5_o = _r5_o;
    _r7.d = ((global::java.lang.Double) _r5_o).doubleValue();
    _r23.l = global::java.lang.Math.round((double) _r7.d);
    _r0.i = _r34.i;
    _r0.d = (double) _r0.i;
    _r7.d = _r0.d;
    _r0.l = _r23.l;
    _r0.d = (double) _r0.l;
    _r9.d = _r0.d;
    _r9.d = _r9.d - _r39.d;
    _r9.d = _r9.d * _r37.d;
    _r7.d = _r7.d + _r9.d;
    _r6.f = (float) _r7.d;
    if (_r27.i == 0) goto label225;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r5_o = _r0_o;
    _r5.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r5_o).getXLabelsColor();
    _r0_o = _r33_o;
    _r1.i = _r5.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    if (_r28.i == 0) goto label160;
    _r0.i = _r36.i;
    _r0.f = (float) _r0.i;
    _r7.f = _r0.f;
    _r0.i = _r36.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r8_o = _r0_o;
    _r8.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r8_o).getLabelsTextSize();
    _r9.f = (float)3.0D;
    _r8.f = _r8.f / _r9.f;
    _r9.f = _r5.f + _r8.f;
    _r5_o = _r32_o;
    _r8.f = _r6.f;
    _r10_o = _r33_o;
    ((global::com.codename1.charts.compat.Canvas) _r5_o).drawLine((float) _r6.f, (float) _r7.f, (float) _r8.f, (float) _r9.f, (global::com.codename1.charts.compat.Paint) _r10_o);
    label160:;
    _r5_o = new global::java.util.Date();
    _r0_o = _r5_o;
    _r1.l = _r23.l;
    ((global::java.util.Date) _r0_o).@this((long) _r1.l);
    _r0_o = _r21_o;
    _r1_o = _r5_o;
// Red class access removed: java.text.DateFormat format
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DateFormat format");
    _r0.i = _r36.i;
    _r0.f = (float) _r0.i;
    _r5.f = _r0.f;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r7_o = _r0_o;
    _r7.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r7_o).getLabelsTextSize();
    _r8.f = (float)4.0D;
    _r7.f = _r7.f * _r8.f;
    _r8.f = (float)3.0D;
    _r7.f = _r7.f / _r8.f;
    _r5.f = _r5.f + _r7.f;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r7_o = _r0_o;
    _r7.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r7_o).getXLabelsPadding();
    _r11.f = _r5.f + _r7.f;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r5_o = _r0_o;
    _r13.f = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r5_o).getXLabelsAngle();
    _r7_o = _r29_o;
    _r8_o = _r32_o;
    _r10.f = _r6.f;
    _r12_o = _r33_o;
    ((global::com.codename1.charts.views.TimeChart) _r7_o).drawText((global::com.codename1.charts.compat.Canvas) _r8_o, (global::java.lang.String) _r9_o, (float) _r10.f, (float) _r11.f, (global::com.codename1.charts.compat.Paint) _r12_o, (float) _r13.f);
    label225:;
    if (_r26.i == 0) goto label259;
    _r0_o = _r29_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r5_o = _r0_o;
    _r7.i = 0;
    _r5.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r5_o).getGridColor((int) _r7.i);
    _r0_o = _r33_o;
    _r1.i = _r5.i;
    ((global::com.codename1.charts.compat.Paint) _r0_o).setColor((int) _r1.i);
    _r0.i = _r36.i;
    _r0.f = (float) _r0.i;
    _r7.f = _r0.f;
    _r0.i = _r35.i;
    _r0.f = (float) _r0.i;
    _r9.f = _r0.f;
    _r5_o = _r32_o;
    _r8.f = _r6.f;
    _r10_o = _r33_o;
    ((global::com.codename1.charts.compat.Canvas) _r5_o).drawLine((float) _r6.f, (float) _r7.f, (float) _r8.f, (float) _r9.f, (global::com.codename1.charts.compat.Paint) _r10_o);
    label259:;
    _r22.i = _r22.i + 1;
    goto label73;
    label263:;
    _r11.i = 1;
    _r7_o = _r29_o;
    _r8_o = _r31_o;
    _r9_o = _r32_o;
    _r10_o = _r33_o;
    _r12.i = _r34.i;
    _r13.i = _r35.i;
    _r14.i = _r36.i;
    _r15.d = _r37.d;
    _r17.d = _r39.d;
    _r19.d = _r41.d;
    ((global::com.codename1.charts.views.TimeChart) _r7_o).drawXTextLabels((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r8_o, (global::com.codename1.charts.compat.Canvas) _r9_o, (global::com.codename1.charts.compat.Paint) _r10_o, 0!=_r11.i, (int) _r12.i, (int) _r13.i, (int) _r14.i, (double) _r15.d, (double) _r17.d, (double) _r19.d);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: void drawXLabels(java.util.List, java.lang.Double[], com.codename1.charts.compat.Canvas, com.codename1.charts.compat.Paint, int, int, int, double, double, double)]
}

private global::System.Object getDateFormat(double n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: java.lang.Object getDateFormat(double, double)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r12;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10.d = n1;
    _r12.d = n2;
    _r8.i = 3;
    _r7.i = 2;
    _r5.d = 8.64E7D;
    _r3_o = ((global::com.codename1.charts.views.TimeChart) _r9_o)._fmDateFormat;
    if (_r3_o == null) goto label21;
    _r2_o = null;
    try {
// Red class access removed: java.text.SimpleDateFormat new-instance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.SimpleDateFormat new-instance");
    _r3_o = ((global::com.codename1.charts.views.TimeChart) _r9_o)._fmDateFormat;
// Red class access removed: java.text.SimpleDateFormat <init>
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.SimpleDateFormat <init>");
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    label19:;
    return (global::java.lang.Object) _r2_o;
    label20:;
    _r3_o = _ex.getJavaException();
    _ex = null;
    label21:;
// Red class access removed: java.text.SimpleDateFormat getDateInstance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.SimpleDateFormat getDateInstance");
    _r0.d = _r12.d - _r10.d;
    _r3.i = _r0.d > _r5.d ? 1 : (_r0.d == _r5.d ? 0 : -1);
    if (_r3.i <= 0) goto label45;
    _r3.d = 4.32E8D;
    _r3.i = _r0.d > _r3.d ? 1 : (_r0.d == _r3.d ? 0 : -1);
    if (_r3.i >= 0) goto label45;
// Red class access removed: java.text.SimpleDateFormat getDateTimeInstance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.SimpleDateFormat getDateTimeInstance");
    goto label19;
    label45:;
    _r3.i = _r0.d > _r5.d ? 1 : (_r0.d == _r5.d ? 0 : -1);
    if (_r3.i >= 0) goto label19;
// Red class access removed: java.text.SimpleDateFormat getTimeInstance
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.SimpleDateFormat getTimeInstance");
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: java.lang.Object getDateFormat(double, double)]
}

public override global::System.Object getChartType(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: java.lang.String getChartType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=Time
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)84)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: java.lang.String getChartType()]
}

public override global::System.Object getXLabels(double n1, double n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: java.util.List getXLabels(double, double, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nElement _r15;
    global::org.xmlvm._nElement _r16;
    global::System.Object _r17_o = null;
    global::org.xmlvm._nElement _r18;
    global::org.xmlvm._nElement _r20;
    global::org.xmlvm._nElement _r22;
    global::System.Object _r22_o = null;
    global::org.xmlvm._nElement _r23;
    global::org.xmlvm._nElement _r24;
    global::System.Object _r24_o = null;
    global::System.Object _r26_o = null;
    global::org.xmlvm._nElement _r27;
    global::org.xmlvm._nElement _r29;
    global::org.xmlvm._nElement _r31;
    _r26_o = this;
    _r27.d = n1;
    _r29.d = n2;
    _r31.i = n3;
    _r13_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r13_o).@this();
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmRenderer;
    _r22_o = _r0_o;
    _r22.i = ((global::com.codename1.charts.renderers.XYMultipleSeriesRenderer) _r22_o).isXRoundedLabels() ? 1 : 0;
    if (_r22.i != 0) goto label168;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmDataset;
    _r22_o = _r0_o;
    _r22.i = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r22_o).getSeriesCount();
    if (_r22.i <= 0) goto label163;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmDataset;
    _r22_o = _r0_o;
    _r23.i = 0;
    _r14_o = ((global::com.codename1.charts.models.XYMultipleSeriesDataset) _r22_o).getSeriesAt((int) _r23.i);
    _r11.i = ((global::com.codename1.charts.models.XYSeries) _r14_o).getItemCount();
    _r10.i = 0;
    _r15.i = -1;
    _r7.i = 0;
    label48:;
    if (_r7.i >= _r11.i) goto label70;
    _r20.d = ((global::com.codename1.charts.models.XYSeries) _r14_o).getX((int) _r7.i);
    _r22.i = _r27.d > _r20.d ? 1 : (_r27.d == _r20.d ? 0 : -1);
    if (_r22.i > 0) goto label67;
    _r22.i = _r20.d > _r29.d ? 1 : (_r20.d == _r29.d ? 0 : -1);
    if (_r22.i > 0) goto label67;
    _r10.i = _r10.i + 1;
    if (_r15.i >= 0) goto label67;
    _r15.i = _r7.i;
    label67:;
    _r7.i = _r7.i + 1;
    goto label48;
    label70:;
    _r0.i = _r10.i;
    _r1.i = _r31.i;
    if (_r0.i >= _r1.i) goto label100;
    _r7.i = _r15.i;
    label76:;
    _r22.i = _r15.i + _r10.i;
    _r0.i = _r7.i;
    _r1.i = _r22.i;
    if (_r0.i >= _r1.i) goto label160;
    _r22.d = ((global::com.codename1.charts.models.XYSeries) _r14_o).getX((int) _r7.i);
    _r22_o = global::java.lang.Double.valueOf((double) _r22.d);
    _r0_o = _r13_o;
    _r1_o = _r22_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r7.i = _r7.i + 1;
    goto label76;
    label100:;
    _r0.i = _r10.i;
    _r0.f = (float) _r0.i;
    _r22.f = _r0.f;
    _r0.i = _r31.i;
    _r0.f = (float) _r0.i;
    _r23.f = _r0.f;
    _r16.f = _r22.f / _r23.f;
    _r9.i = 0;
    _r7.i = 0;
    label113:;
    if (_r7.i >= _r11.i) goto label160;
    _r0.i = _r9.i;
    _r1.i = _r31.i;
    if (_r0.i >= _r1.i) goto label160;
    _r0.i = _r7.i;
    _r0.f = (float) _r0.i;
    _r22.f = _r0.f;
    _r22.f = _r22.f * _r16.f;
    _r22.i = global::java.lang.Math.round((float) _r22.f);
    _r0_o = _r14_o;
    _r1.i = _r22.i;
    _r20.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getX((int) _r1.i);
    _r22.i = _r27.d > _r20.d ? 1 : (_r27.d == _r20.d ? 0 : -1);
    if (_r22.i > 0) goto label157;
    _r22.i = _r20.d > _r29.d ? 1 : (_r20.d == _r29.d ? 0 : -1);
    if (_r22.i > 0) goto label157;
    _r22_o = global::java.lang.Double.valueOf((double) _r20.d);
    _r0_o = _r13_o;
    _r1_o = _r22_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r9.i = _r9.i + 1;
    label157:;
    _r7.i = _r7.i + 1;
    goto label113;
    label160:;
    _r22_o = _r13_o;
    label162:;
    return (global::java.util.List) _r22_o;
    label163:;
    _r22_o = base.getXLabels((double) _r27.d, (double) _r29.d, (int) _r31.i);
    goto label162;
    label168:;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmStartPoint;
    _r22_o = _r0_o;
    if (_r22_o != null) goto label249;
    _r17_o = global::java.util.TimeZone.getDefault();
    _r2_o = global::java.util.Calendar.getInstance((global::java.util.TimeZone) _r17_o);
    _r22_o = new global::java.util.Date();
    _r23.l = global::java.lang.Math.round((double) _r27.d);
    ((global::java.util.Date) _r22_o).@this((long) _r23.l);
    _r0_o = _r2_o;
    _r1_o = _r22_o;
    ((global::java.util.Calendar) _r0_o).setTime((global::java.util.Date) _r1_o);
    _r0_o = _r26_o;
    _r1_o = _r2_o;
    _r12.i = ((global::com.codename1.charts.views.TimeChart) _r0_o).getDSTOffset((global::java.util.Calendar) _r1_o);
    _r22.d = 8.64E7D;
      throw new global::org.xmlvm._nNotYetImplementedException("dex:rem-double");
    _r22.d = _r27.d - _r22.d;
    _r24.d = 8.64E7D;
    _r22.d = _r22.d + _r24.d;
    _r24.i = _r12.i * 60;
    _r24.i = _r24.i * 60;
    _r0.i = _r24.i;
    _r0.i = _r0.i * 1000;
    _r24.i = _r0.i;
    _r0.i = _r24.i;
    _r0.d = (double) _r0.i;
    _r24.d = _r0.d;
    _r22.d = _r22.d + _r24.d;
    _r22_o = global::java.lang.Double.valueOf((double) _r22.d);
    _r0_o = _r22_o;
    _r1_o = _r26_o;
    ((global::com.codename1.charts.views.TimeChart) _r1_o)._fmStartPoint = (global::java.lang.Double) _r0_o;
    label249:;
    _r22.i = 25;
    _r0.i = _r31.i;
    _r1.i = _r22.i;
    if (_r0.i <= _r1.i) goto label259;
    _r31.i = 25;
    label259:;
    _r22.d = _r29.d - _r27.d;
    _r0.i = _r31.i;
    _r0.d = (double) _r0.i;
    _r24.d = _r0.d;
    _r5.d = _r22.d / _r24.d;
    _r22.d = 0.0D;
    _r22.i = _r5.d > _r22.d ? 1 : (_r5.d == _r22.d ? 0 : -1);
    if (_r22.i > 0) goto label277;
    _r22_o = _r13_o;
    goto label162;
    label277:;
    _r3.d = 8.64E7D;
    _r22.d = 8.64E7D;
    _r22.i = _r5.d > _r22.d ? 1 : (_r5.d == _r22.d ? 0 : -1);
    if (_r22.i > 0) goto label304;
    label291:;
    _r22.d = 2.0D;
    _r22.d = _r3.d / _r22.d;
    _r22.i = _r5.d > _r22.d ? 1 : (_r5.d == _r22.d ? 0 : -1);
    if (_r22.i >= 0) goto label313;
    _r22.d = 2.0D;
    _r3.d = _r3.d / _r22.d;
    goto label291;
    label304:;
    _r22.i = _r5.d > _r3.d ? 1 : (_r5.d == _r3.d ? 0 : -1);
    if (_r22.i <= 0) goto label313;
    _r22.d = 2.0D;
    _r3.d = _r3.d * _r22.d;
    goto label304;
    label313:;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmStartPoint;
    _r22_o = _r0_o;
    _r22.d = ((global::java.lang.Double) _r22_o).doubleValue();
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.views.TimeChart) _r0_o)._fmStartPoint;
    _r24_o = _r0_o;
    _r24.d = ((global::java.lang.Double) _r24_o).doubleValue();
    _r24.d = _r24.d - _r27.d;
    _r24.d = _r24.d / _r3.d;
    _r24.d = global::java.lang.Math.floor((double) _r24.d);
    _r24.d = _r24.d * _r3.d;
    _r18.d = _r22.d - _r24.d;
    _r7.i = 0;
    _r8.i = _r7.i;
    label347:;
    _r22.i = _r18.d > _r29.d ? 1 : (_r18.d == _r29.d ? 0 : -1);
    if (_r22.i >= 0) goto label372;
    _r7.i = _r8.i + 1;
    _r0.i = _r8.i;
    _r1.i = _r31.i;
    if (_r0.i > _r1.i) goto label373;
    _r22_o = global::java.lang.Double.valueOf((double) _r18.d);
    _r0_o = _r13_o;
    _r1_o = _r22_o;
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r1_o);
    _r18.d = _r18.d + _r3.d;
    _r8.i = _r7.i;
    goto label347;
    label372:;
    _r7.i = _r8.i;
    label373:;
    _r22_o = _r13_o;
    goto label162;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: java.util.List getXLabels(double, double, int)]
}

public virtual int getDSTOffset(global::java.util.Calendar n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: int getDSTOffset(java.util.Calendar)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r2_o = global::java.util.Calendar.getInstance();
    _r0_o = ((global::java.util.Calendar) _r2_o).getTimeZone();
    _r2.i = ((global::java.util.TimeZone) _r0_o).getRawOffset();
    _r3.i = 60000;
    _r1.i = _r2.i / _r3.i;
    _r2.i = ((global::com.codename1.charts.views.TimeChart) _r4_o).getOffsetInMinutes((global::java.util.Calendar) _r5_o, (global::java.util.TimeZone) _r0_o);
    _r2.i = _r2.i - _r1.i;
    return _r2.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: int getDSTOffset(java.util.Calendar)]
}

public virtual int getOffsetInMinutes(global::java.util.Calendar n1, global::java.util.TimeZone n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart: int getOffsetInMinutes(java.util.Calendar, java.util.TimeZone)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
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
    _r0.i = 0;
    _r1.i = ((global::java.util.Calendar) _r8_o).get((int) _r0.i);
    _r0.i = 1;
    _r2.i = ((global::java.util.Calendar) _r8_o).get((int) _r0.i);
    _r0.i = 2;
    _r3.i = ((global::java.util.Calendar) _r8_o).get((int) _r0.i);
    _r0.i = 5;
    _r4.i = ((global::java.util.Calendar) _r8_o).get((int) _r0.i);
    _r0.i = 7;
    _r5.i = ((global::java.util.Calendar) _r8_o).get((int) _r0.i);
    _r0.i = 14;
    _r6.i = ((global::java.util.Calendar) _r8_o).get((int) _r0.i);
    _r0_o = _r9_o;
    _r0.i = ((global::java.util.TimeZone) _r0_o).getOffset((int) _r1.i, (int) _r2.i, (int) _r3.i, (int) _r4.i, (int) _r5.i, (int) _r6.i);
    _r1.i = 60000;
    _r0.i = _r0.i / _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart: int getOffsetInMinutes(java.util.Calendar, java.util.TimeZone)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.TimeChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.TimeChart]

} // end of class: TimeChart

} // end of namespace: com.codename1.charts.views
