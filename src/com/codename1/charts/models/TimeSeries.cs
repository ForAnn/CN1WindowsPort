// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.models {
public class TimeSeries: global::com.codename1.charts.models.XYSeries {
public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.TimeSeries: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.models.XYSeries) _r0_o).@this((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.models.TimeSeries: void <init>(java.lang.String)]
}

public virtual void add(global::java.util.Date n1, double n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.TimeSeries: void add(java.util.Date, double)]
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
    _r4.d = n2;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0.l = ((global::java.util.Date) _r3_o).getTime();
    _r0.d = (double) _r0.l;
    base.add((double) _r0.d, (double) _r4.d);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label11;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r2_o);
    return;
    label11:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[com.codename1.charts.models.TimeSeries: void add(java.util.Date, double)]
}

public override double getPadding(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.TimeSeries: double getPadding(double)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.d = n1;
    _r0.d = 1.0D;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.charts.models.TimeSeries: double getPadding(double)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.models.TimeSeries]
//XMLVM_END_WRAPPER[com.codename1.charts.models.TimeSeries]

} // end of class: TimeSeries

} // end of namespace: com.codename1.charts.models
