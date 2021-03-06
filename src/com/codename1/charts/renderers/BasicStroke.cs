// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.renderers {
public class BasicStroke: global::java.lang.Object {

static BasicStroke() {
    @static();
}

public static global::com.codename1.charts.renderers.BasicStroke _fSOLID;

public static global::com.codename1.charts.renderers.BasicStroke _fDASHED;

public static global::com.codename1.charts.renderers.BasicStroke _fDOTTED;

private int _fmCap;

private int _fmJoin;

private float _fmMiter;

private global::org.xmlvm._nArrayAdapter<float> _fmIntervals;

private float _fmPhase;

public void @this(int n1, int n2, float n3, global::org.xmlvm._nArrayAdapter<float> n4, float n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: void <init>(int, int, float, float[], float)]
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
    _r1.i = n1;
    _r2.i = n2;
    _r3.f = n3;
    _r4_o = n4;
    _r5.f = n5;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o)._fmCap = _r1.i;
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o)._fmJoin = _r2.i;
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o)._fmMiter = _r3.f;
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o)._fmIntervals = (global::org.xmlvm._nArrayAdapter<float>) _r4_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: void <init>(int, int, float, float[], float)]
}

public virtual int getCap(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: int getCap()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.BasicStroke) _r1_o)._fmCap;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: int getCap()]
}

public virtual int getJoin(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: int getJoin()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.renderers.BasicStroke) _r1_o)._fmJoin;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: int getJoin()]
}

public virtual float getMiter(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: float getMiter()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.BasicStroke) _r1_o)._fmMiter;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: float getMiter()]
}

public virtual global::System.Object getIntervals(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: float[] getIntervals()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.renderers.BasicStroke) _r1_o)._fmIntervals;
    return (global::org.xmlvm._nArrayAdapter<float>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: float[] getIntervals()]
}

public virtual float getPhase(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: float getPhase()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.renderers.BasicStroke) _r1_o)._fmPhase;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: float getPhase()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke: void <clinit>()]
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
    _r8.i = 1;
    _r1.i = 0;
    _r7.f = (float)1.0D;
    _r6.i = 2;
    _r0_o = new global::com.codename1.charts.renderers.BasicStroke();
    _r3.f = (float)4.0D;
    _r4_o = null;
    _r5.f = (float)0.0D;
    _r2.i = _r1.i;
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o).@this((int) _r1.i, (int) _r2.i, (float) _r3.f, (global::org.xmlvm._nArrayAdapter<float>) _r4_o, (float) _r5.f);
    global::com.codename1.charts.renderers.BasicStroke._fSOLID = (global::com.codename1.charts.renderers.BasicStroke) _r0_o;
    _r0_o = new global::com.codename1.charts.renderers.BasicStroke();
    _r3.f = (float)10.0D;
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r6.i]);
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[]{(float)10.0D, (float)10.0D});
    _r1.i = _r8.i;
    _r2.i = _r6.i;
    _r5.f = _r7.f;
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o).@this((int) _r1.i, (int) _r2.i, (float) _r3.f, (global::org.xmlvm._nArrayAdapter<float>) _r4_o, (float) _r5.f);
    global::com.codename1.charts.renderers.BasicStroke._fDASHED = (global::com.codename1.charts.renderers.BasicStroke) _r0_o;
    _r0_o = new global::com.codename1.charts.renderers.BasicStroke();
    _r3.f = (float)5.0D;
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r6.i]);
    _r4_o = new global::org.xmlvm._nArrayAdapter<float>(new float[]{(float)2.0D, (float)10.0D});
    _r1.i = _r8.i;
    _r2.i = _r6.i;
    _r5.f = _r7.f;
    ((global::com.codename1.charts.renderers.BasicStroke) _r0_o).@this((int) _r1.i, (int) _r2.i, (float) _r3.f, (global::org.xmlvm._nArrayAdapter<float>) _r4_o, (float) _r5.f);
    global::com.codename1.charts.renderers.BasicStroke._fDOTTED = (global::com.codename1.charts.renderers.BasicStroke) _r0_o;
    return;
    label52:;
    label60:;
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.renderers.BasicStroke]
//XMLVM_END_WRAPPER[com.codename1.charts.renderers.BasicStroke]

} // end of class: BasicStroke

} // end of namespace: com.codename1.charts.renderers
