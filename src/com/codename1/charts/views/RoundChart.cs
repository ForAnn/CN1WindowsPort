// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.views {
public abstract class RoundChart: global::com.codename1.charts.views.AbstractChart {
public static int _fSHAPE_1WIDTH = 10;

public global::com.codename1.charts.models.CategorySeries _fmDataset;

public global::com.codename1.charts.renderers.DefaultRenderer _fmRenderer;

public static int _fNO_1VALUE = 2147483647;

public int _fmCenterX;

public int _fmCenterY;

public bool _fautoCalculateCenter;

public void @this(global::com.codename1.charts.models.CategorySeries n1, global::com.codename1.charts.renderers.DefaultRenderer n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: void <init>(com.codename1.charts.models.CategorySeries, com.codename1.charts.renderers.DefaultRenderer)]
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
    _r0.i = 2147483647;
    ((global::com.codename1.charts.views.AbstractChart) _r1_o).@this();
    ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmCenterX = _r0.i;
    ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmCenterY = _r0.i;
    _r0.i = 1;
    ((global::com.codename1.charts.views.RoundChart) _r1_o)._fautoCalculateCenter = 0!=_r0.i;
    ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmDataset = (global::com.codename1.charts.models.CategorySeries) _r2_o;
    ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmRenderer = (global::com.codename1.charts.renderers.DefaultRenderer) _r3_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: void <init>(com.codename1.charts.models.CategorySeries, com.codename1.charts.renderers.DefaultRenderer)]
}

public virtual void drawTitle(global::com.codename1.charts.compat.Canvas n1, int n2, int n3, int n4, global::com.codename1.charts.compat.Paint n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: void drawTitle(com.codename1.charts.compat.Canvas, int, int, int, com.codename1.charts.compat.Paint)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r10.i = n4;
    _r11_o = n5;
    _r0_o = ((global::com.codename1.charts.views.RoundChart) _r6_o)._fmRenderer;
    _r0.i = ((global::com.codename1.charts.renderers.DefaultRenderer) _r0_o).isShowLabels() ? 1 : 0;
    if (_r0.i == 0) goto label55;
    _r0_o = ((global::com.codename1.charts.views.RoundChart) _r6_o)._fmRenderer;
    _r0.i = ((global::com.codename1.charts.renderers.DefaultRenderer) _r0_o).getLabelsColor();
    ((global::com.codename1.charts.compat.Paint) _r11_o).setColor((int) _r0.i);
    _r0.i = 4;
    ((global::com.codename1.charts.compat.Paint) _r11_o).setTextAlign((int) _r0.i);
    _r0_o = ((global::com.codename1.charts.views.RoundChart) _r6_o)._fmRenderer;
    _r0.f = ((global::com.codename1.charts.renderers.DefaultRenderer) _r0_o).getChartTitleTextSize();
    ((global::com.codename1.charts.compat.Paint) _r11_o).setTextSize((float) _r0.f);
    _r0_o = ((global::com.codename1.charts.views.RoundChart) _r6_o)._fmRenderer;
    _r2_o = ((global::com.codename1.charts.renderers.DefaultRenderer) _r0_o).getChartTitle();
    _r0.i = _r10.i / 2;
    _r0.i = _r0.i + _r8.i;
    _r3.f = (float) _r0.i;
    _r0.f = (float) _r9.i;
    _r1_o = ((global::com.codename1.charts.views.RoundChart) _r6_o)._fmRenderer;
    _r1.f = ((global::com.codename1.charts.renderers.DefaultRenderer) _r1_o).getChartTitleTextSize();
    _r4.f = _r0.f + _r1.f;
    _r0_o = _r6_o;
    _r1_o = _r7_o;
    _r5_o = _r11_o;
    ((global::com.codename1.charts.views.RoundChart) _r0_o).drawString((global::com.codename1.charts.compat.Canvas) _r1_o, (global::java.lang.String) _r2_o, (float) _r3.f, (float) _r4.f, (global::com.codename1.charts.compat.Paint) _r5_o);
    label55:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: void drawTitle(com.codename1.charts.compat.Canvas, int, int, int, com.codename1.charts.compat.Paint)]
}

public override int getLegendShapeWidth(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: int getLegendShapeWidth(int)]
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
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: int getLegendShapeWidth(int)]
}

public override void drawLegendShape(global::com.codename1.charts.compat.Canvas n1, global::com.codename1.charts.renderers.SimpleSeriesRenderer n2, float n3, float n4, int n5, global::com.codename1.charts.compat.Paint n6){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
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
    _r1.f = (float)5.0D;
    _r2.f = _r10.f - _r1.f;
    _r0.f = (float)10.0D;
    _r3.f = _r9.f + _r0.f;
    _r4.f = _r10.f + _r1.f;
    _r0_o = _r7_o;
    _r1.f = _r9.f;
    _r5_o = _r12_o;
    ((global::com.codename1.charts.compat.Canvas) _r0_o).drawRect((float) _r1.f, (float) _r2.f, (float) _r3.f, (float) _r4.f, (global::com.codename1.charts.compat.Paint) _r5_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: void drawLegendShape(com.codename1.charts.compat.Canvas, com.codename1.charts.renderers.SimpleSeriesRenderer, float, float, int, com.codename1.charts.compat.Paint)]
}

public virtual global::System.Object getRenderer(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: com.codename1.charts.renderers.DefaultRenderer getRenderer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmRenderer;
    return (global::com.codename1.charts.renderers.DefaultRenderer) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: com.codename1.charts.renderers.DefaultRenderer getRenderer()]
}

public virtual int getCenterX(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: int getCenterX()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmCenterX;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: int getCenterX()]
}

public virtual int getCenterY(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: int getCenterY()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.views.RoundChart) _r1_o)._fmCenterY;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: int getCenterY()]
}

public virtual void setCenterX(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: void setCenterX(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.views.RoundChart) _r0_o)._fmCenterX = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: void setCenterX(int)]
}

public virtual void setCenterY(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: void setCenterY(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.views.RoundChart) _r0_o)._fmCenterY = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: void setCenterY(int)]
}

public virtual void setAutocalculateCenter(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: void setAutocalculateCenter(boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.views.RoundChart) _r0_o)._fautoCalculateCenter = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: void setAutocalculateCenter(boolean)]
}

public virtual bool isAutocalculateCenter(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart: boolean isAutocalculateCenter()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.views.RoundChart) _r1_o)._fautoCalculateCenter ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart: boolean isAutocalculateCenter()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.views.RoundChart]
//XMLVM_END_WRAPPER[com.codename1.charts.views.RoundChart]

} // end of class: RoundChart

} // end of namespace: com.codename1.charts.views
