// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.transitions {
public class XYSeriesTransition: global::com.codename1.charts.transitions.SeriesTransition {
private global::com.codename1.charts.models.XYSeries _fseries;

private global::com.codename1.charts.models.XYSeries _fcachedSeries;

private global::com.codename1.charts.models.XYSeries _fstartVals;

private global::com.codename1.charts.models.XYSeries _fendVals;

public void @this(global::com.codename1.charts.ChartComponent n1, global::com.codename1.charts.models.XYSeries n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void <init>(com.codename1.charts.ChartComponent, com.codename1.charts.models.XYSeries)]
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
    ((global::com.codename1.charts.transitions.SeriesTransition) _r0_o).@this((global::com.codename1.charts.ChartComponent) _r1_o);
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fseries = (global::com.codename1.charts.models.XYSeries) _r2_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void <init>(com.codename1.charts.ChartComponent, com.codename1.charts.models.XYSeries)]
}

public override void initTransition(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void initTransition()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    base.initTransition();
    _r0_o = new global::com.codename1.charts.models.XYSeries();
    // Value=Start
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)83)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 116))}));
    ((global::com.codename1.charts.models.XYSeries) _r0_o).@this((global::java.lang.String) _r1_o);
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o)._fstartVals = (global::com.codename1.charts.models.XYSeries) _r0_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o)._fseries;
    _r1_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o)._fstartVals;
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o).copyValues((global::com.codename1.charts.models.XYSeries) _r0_o, (global::com.codename1.charts.models.XYSeries) _r1_o);
    _r0_o = new global::com.codename1.charts.models.XYSeries();
    // Value=End
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)69)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100))}));
    ((global::com.codename1.charts.models.XYSeries) _r0_o).@this((global::java.lang.String) _r1_o);
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o)._fendVals = (global::com.codename1.charts.models.XYSeries) _r0_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o)._fcachedSeries;
    _r1_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o)._fendVals;
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r2_o).copyValues((global::com.codename1.charts.models.XYSeries) _r0_o, (global::com.codename1.charts.models.XYSeries) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void initTransition()]
}

private void copyValues(global::com.codename1.charts.models.XYSeries n1, global::com.codename1.charts.models.XYSeries n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void copyValues(com.codename1.charts.models.XYSeries, com.codename1.charts.models.XYSeries)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8_o = n1;
    _r9_o = n2;
    _r2.i = ((global::com.codename1.charts.models.XYSeries) _r8_o).getItemCount();
    _r0.i = 0;
    label5:;
    if (_r0.i >= _r2.i) goto label35;
    _r3.d = ((global::com.codename1.charts.models.XYSeries) _r8_o).getX((int) _r0.i);
    _r1.i = ((global::com.codename1.charts.models.XYSeries) _r9_o).getIndexForKey((double) _r3.d);
    _r3.i = -1;
    if (_r1.i <= _r3.i) goto label21;
    ((global::com.codename1.charts.models.XYSeries) _r9_o).remove((int) _r1.i);
    label21:;
    _r3.d = ((global::com.codename1.charts.models.XYSeries) _r8_o).getX((int) _r0.i);
    _r5.d = ((global::com.codename1.charts.models.XYSeries) _r8_o).getY((int) _r0.i);
    ((global::com.codename1.charts.models.XYSeries) _r9_o).add((double) _r3.d, (double) _r5.d);
    _r0.i = _r0.i + 1;
    goto label5;
    label35:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void copyValues(com.codename1.charts.models.XYSeries, com.codename1.charts.models.XYSeries)]
}

public override void cleanup(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void cleanup()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    base.cleanup();
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r1_o)._fcachedSeries;
    ((global::com.codename1.charts.models.XYSeries) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void cleanup()]
}

public override void update(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void update(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r26_o = this;
    _r27.i = n1;
    _r0.i = _r27.i;
    _r0.d = (double) _r0.i;
    _r5.d = _r0.d;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fendVals;
    _r22_o = _r0_o;
    _r11.i = ((global::com.codename1.charts.models.XYSeries) _r22_o).getItemCount();
    _r10.i = 0;
    label15:;
    if (_r10.i >= _r11.i) goto label148;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fendVals;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.i = _r10.i;
    _r18.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getX((int) _r1.i);
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fendVals;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.i = _r10.i;
    _r20.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getY((int) _r1.i);
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fstartVals;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.d = _r18.d;
    _r13.i = ((global::com.codename1.charts.models.XYSeries) _r0_o).getIndexForKey((double) _r1.d);
    _r9.i = _r10.i;
    _r22.i = -1;
    _r0.i = _r13.i;
    _r1.i = _r22.i;
    if (_r0.i != _r1.i) goto label132;
    _r22.d = 0.0D;
    _r14.d = _r22.d;
    label69:;
    _r7.d = _r20.d;
    _r22.d = _r7.d - _r14.d;
    _r22.d = _r22.d * _r5.d;
    _r24.d = 100.0D;
    _r22.d = _r22.d / _r24.d;
    _r16.d = _r14.d + _r22.d;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fseries;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.d = _r18.d;
    _r12.i = ((global::com.codename1.charts.models.XYSeries) _r0_o).getIndexForKey((double) _r1.d);
    _r22.i = -1;
    _r0.i = _r12.i;
    _r1.i = _r22.i;
    if (_r0.i <= _r1.i) goto label114;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fseries;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.i = _r12.i;
    ((global::com.codename1.charts.models.XYSeries) _r0_o).remove((int) _r1.i);
    label114:;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fseries;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.d = _r18.d;
    _r3.d = _r16.d;
    ((global::com.codename1.charts.models.XYSeries) _r0_o).add((double) _r1.d, (double) _r3.d);
    _r10.i = _r10.i + 1;
    goto label15;
    label132:;
    _r0_o = _r26_o;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fstartVals;
    _r22_o = _r0_o;
    _r0_o = _r22_o;
    _r1.i = _r13.i;
    _r22.d = ((global::com.codename1.charts.models.XYSeries) _r0_o).getY((int) _r1.i);
    _r14.d = _r22.d;
    goto label69;
    label148:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void update(int)]
}

public virtual global::System.Object getBuffer(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: com.codename1.charts.models.XYSeries getBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r3_o)._fcachedSeries;
    if (_r0_o != null) goto label23;
    _r0_o = new global::com.codename1.charts.models.XYSeries();
    _r1_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r3_o)._fseries;
    _r1_o = ((global::com.codename1.charts.models.XYSeries) _r1_o).getTitle();
    _r2_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r3_o)._fseries;
    _r2.i = ((global::com.codename1.charts.models.XYSeries) _r2_o).getScaleNumber();
    ((global::com.codename1.charts.models.XYSeries) _r0_o).@this((global::java.lang.String) _r1_o, (int) _r2.i);
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r3_o)._fcachedSeries = (global::com.codename1.charts.models.XYSeries) _r0_o;
    label23:;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r3_o)._fcachedSeries;
    return (global::com.codename1.charts.models.XYSeries) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: com.codename1.charts.models.XYSeries getBuffer()]
}

public virtual void setBuffer(global::com.codename1.charts.models.XYSeries n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void setBuffer(com.codename1.charts.models.XYSeries)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.transitions.XYSeriesTransition) _r0_o)._fcachedSeries = (global::com.codename1.charts.models.XYSeries) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: void setBuffer(com.codename1.charts.models.XYSeries)]
}

public virtual global::System.Object getSeries(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: com.codename1.charts.models.XYSeries getSeries()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.transitions.XYSeriesTransition) _r1_o)._fseries;
    return (global::com.codename1.charts.models.XYSeries) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition: com.codename1.charts.models.XYSeries getSeries()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition]
//XMLVM_END_WRAPPER[com.codename1.charts.transitions.XYSeriesTransition]

} // end of class: XYSeriesTransition

} // end of namespace: com.codename1.charts.transitions
