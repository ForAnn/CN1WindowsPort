// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.renderers {
public class SimpleSeriesRenderer: global::java.lang.Object {
private int _fmColor;

private global::com.codename1.charts.renderers.BasicStroke _fmStroke;

private bool _fmGradientEnabled;

private double _fmGradientStartValue;

private int _fmGradientStartColor;

private double _fmGradientStopValue;

private int _fmGradientStopColor;

private bool _fmShowLegendItem;

private bool _fmHighlighted;

private bool _fmDisplayBoundingPoints;

private global::com.codename1.charts.util.NumberFormat _fmChartValuesFormat;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r1.i = 1;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.i = 255;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o)._fmColor = _r0.i;
    _r0.i = 0;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o)._fmGradientEnabled = 0!=_r0.i;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o)._fmShowLegendItem = 0!=_r1.i;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o)._fmDisplayBoundingPoints = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void <init>()]
}

public virtual int getColor(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: int getColor()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmColor;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: int getColor()]
}

public virtual void setColor(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setColor(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmColor = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setColor(int)]
}

public virtual global::System.Object getStroke(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: com.codename1.charts.renderers.BasicStroke getStroke()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmStroke;
    return (global::com.codename1.charts.renderers.BasicStroke) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: com.codename1.charts.renderers.BasicStroke getStroke()]
}

public virtual void setStroke(global::com.codename1.charts.renderers.BasicStroke n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setStroke(com.codename1.charts.renderers.BasicStroke)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmStroke = (global::com.codename1.charts.renderers.BasicStroke) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setStroke(com.codename1.charts.renderers.BasicStroke)]
}

public virtual bool isGradientEnabled(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isGradientEnabled()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmGradientEnabled ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isGradientEnabled()]
}

public virtual void setGradientEnabled(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setGradientEnabled(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmGradientEnabled = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setGradientEnabled(boolean)]
}

public virtual double getGradientStartValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: double getGradientStartValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o)._fmGradientStartValue;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: double getGradientStartValue()]
}

public virtual int getGradientStartColor(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: int getGradientStartColor()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmGradientStartColor;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: int getGradientStartColor()]
}

public virtual void setGradientStart(double n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setGradientStart(double, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1.d = n1;
    _r3.i = n2;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmGradientStartValue = _r1.d;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmGradientStartColor = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setGradientStart(double, int)]
}

public virtual double getGradientStopValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: double getGradientStopValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r2_o)._fmGradientStopValue;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: double getGradientStopValue()]
}

public virtual int getGradientStopColor(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: int getGradientStopColor()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmGradientStopColor;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: int getGradientStopColor()]
}

public virtual void setGradientStop(double n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setGradientStop(double, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1.d = n1;
    _r3.i = n2;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmGradientStopValue = _r1.d;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmGradientStopColor = _r3.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setGradientStop(double, int)]
}

public virtual bool isShowLegendItem(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isShowLegendItem()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmShowLegendItem ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isShowLegendItem()]
}

public virtual void setShowLegendItem(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setShowLegendItem(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmShowLegendItem = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setShowLegendItem(boolean)]
}

public virtual bool isHighlighted(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isHighlighted()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmHighlighted ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isHighlighted()]
}

public virtual void setHighlighted(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setHighlighted(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmHighlighted = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setHighlighted(boolean)]
}

public virtual bool isDisplayBoundingPoints(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isDisplayBoundingPoints()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmDisplayBoundingPoints ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: boolean isDisplayBoundingPoints()]
}

public virtual void setDisplayBoundingPoints(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setDisplayBoundingPoints(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmDisplayBoundingPoints = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setDisplayBoundingPoints(boolean)]
}

public virtual global::System.Object getChartValuesFormat(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: com.codename1.charts.util.NumberFormat getChartValuesFormat()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r1_o)._fmChartValuesFormat;
    return (global::com.codename1.charts.util.NumberFormat) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: com.codename1.charts.util.NumberFormat getChartValuesFormat()]
}

public virtual void setChartValuesFormat(global::com.codename1.charts.util.NumberFormat n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setChartValuesFormat(com.codename1.charts.util.NumberFormat)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.renderers.SimpleSeriesRenderer) _r0_o)._fmChartValuesFormat = (global::com.codename1.charts.util.NumberFormat) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer: void setChartValuesFormat(com.codename1.charts.util.NumberFormat)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer]
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.SimpleSeriesRenderer]

} // end of class: SimpleSeriesRenderer

} // end of namespace: com.codename1.charts.renderers
