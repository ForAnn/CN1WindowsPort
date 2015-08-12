// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.animations {
public class Motion: global::java.lang.Object {
private static bool _fslowMotion;

public static int _fLINEAR = 0;

public static int _fSPLINE = 1;

public int _fmotionType;




private int _fsourceValue;

private int _fdestinationValue;

private int _fduration;

private long _fstartTime;

private float _finitVelocity;

private float _ffriction;

private int _flastReturnedValue;

private long _fcurrentMotionTime;

private float _fp0;

private float _fp1;

private float _fp2;

private float _fp3;

public static bool isSlowMotion(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: boolean isSlowMotion()]
    global::org.xmlvm._nElement _r0;
    _r0.i = global::com.codename1.ui.animations.Motion._fslowMotion ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: boolean isSlowMotion()]
}

public static void setSlowMotion(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void setSlowMotion(boolean)]
    global::org.xmlvm._nElement _r0;
    _r0.i = n1 ? 1 : 0;
    global::com.codename1.ui.animations.Motion._fslowMotion = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void setSlowMotion(boolean)]
}

public void @this(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void <init>(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r5.i = n3;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.l = -1L;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fcurrentMotionTime = _r0.l;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fsourceValue = _r3.i;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fdestinationValue = _r4.i;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fduration = _r5.i;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._flastReturnedValue = _r3.i;
    _r0.i = global::com.codename1.ui.animations.Motion._fslowMotion ? 1 : 0;
    if (_r0.i == 0) goto label25;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r2_o)._fduration;
    _r0.i = _r0.i * 50;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fduration = _r0.i;
    label25:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void <init>(int, int, int)]
}

public void @this(int n1, float n2, float n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void <init>(int, float, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2_o = this;
    _r3.i = n1;
    _r4.f = n2;
    _r5.f = n3;
    ((global::java.lang.Object) _r2_o).@this();
    _r0.l = -1L;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fcurrentMotionTime = _r0.l;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fsourceValue = _r3.i;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._finitVelocity = _r4.f;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._ffriction = _r5.f;
    _r0.f = global::java.lang.Math.abs((float) _r4.f);
    _r0.f = _r0.f / _r5.f;
    _r0.i = (int) _r0.f;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fduration = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void <init>(int, float, float)]
}

public static global::System.Object createCubicBezierMotion(int n1, int n2, int n3, float n4, float n5, float n6, float n7){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createCubicBezierMotion(int, int, int, float, float, float, float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r5.f = n4;
    _r6.f = n5;
    _r7.f = n6;
    _r8.f = n7;
    _r0_o = new global::com.codename1.ui.animations.Motion();
    ((global::com.codename1.ui.animations.Motion) _r0_o).@this((int) _r2.i, (int) _r3.i, (int) _r4.i);
    _r1.i = 4;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fmotionType = _r1.i;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fp0 = _r5.f;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fp1 = _r6.f;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fp2 = _r7.f;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fp3 = _r8.f;
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createCubicBezierMotion(int, int, int, float, float, float, float)]
}

public static global::System.Object createEaseInOutMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseInOutMotion(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r7.i = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r3.f = (float)0.0D;
    _r4.f = (float)0.42D;
    _r5.f = (float)0.58D;
    _r6.f = (float)1.0D;
    _r0.i = _r7.i;
    _r1.i = _r8.i;
    _r2.i = _r9.i;
    _r0_o = global::com.codename1.ui.animations.Motion.createCubicBezierMotion((int) _r0.i, (int) _r1.i, (int) _r2.i, (float) _r3.f, (float) _r4.f, (float) _r5.f, (float) _r6.f);
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseInOutMotion(int, int, int)]
}

public static global::System.Object createEaseMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseMotion(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r7.i = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r4.f = (float)0.25D;
    _r3.f = (float)0.0D;
    _r6.f = (float)1.0D;
    _r0.i = _r7.i;
    _r1.i = _r8.i;
    _r2.i = _r9.i;
    _r5.f = _r4.f;
    _r0_o = global::com.codename1.ui.animations.Motion.createCubicBezierMotion((int) _r0.i, (int) _r1.i, (int) _r2.i, (float) _r3.f, (float) _r4.f, (float) _r5.f, (float) _r6.f);
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseMotion(int, int, int)]
}

public static global::System.Object createEaseInMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseInMotion(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r7.i = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r5.f = (float)1.0D;
    _r3.f = (float)0.0D;
    _r4.f = (float)0.42D;
    _r0.i = _r7.i;
    _r1.i = _r8.i;
    _r2.i = _r9.i;
    _r6.f = _r5.f;
    _r0_o = global::com.codename1.ui.animations.Motion.createCubicBezierMotion((int) _r0.i, (int) _r1.i, (int) _r2.i, (float) _r3.f, (float) _r4.f, (float) _r5.f, (float) _r6.f);
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseInMotion(int, int, int)]
}

public static global::System.Object createEaseOutMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseOutMotion(int, int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r7.i = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r3.f = (float)0.0D;
    _r5.f = (float)0.58D;
    _r6.f = (float)1.0D;
    _r0.i = _r7.i;
    _r1.i = _r8.i;
    _r2.i = _r9.i;
    _r4.f = _r3.f;
    _r0_o = global::com.codename1.ui.animations.Motion.createCubicBezierMotion((int) _r0.i, (int) _r1.i, (int) _r2.i, (float) _r3.f, (float) _r4.f, (float) _r5.f, (float) _r6.f);
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createEaseOutMotion(int, int, int)]
}

public static global::System.Object createLinearMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createLinearMotion(int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = new global::com.codename1.ui.animations.Motion();
    ((global::com.codename1.ui.animations.Motion) _r0_o).@this((int) _r2.i, (int) _r3.i, (int) _r4.i);
    _r1.i = 0;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fmotionType = _r1.i;
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createLinearMotion(int, int, int)]
}

public static global::System.Object createSplineMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createSplineMotion(int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = new global::com.codename1.ui.animations.Motion();
    ((global::com.codename1.ui.animations.Motion) _r0_o).@this((int) _r2.i, (int) _r3.i, (int) _r4.i);
    _r1.i = 1;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fmotionType = _r1.i;
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createSplineMotion(int, int, int)]
}

public static global::System.Object createDecelerationMotion(int n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createDecelerationMotion(int, int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r2.i = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = new global::com.codename1.ui.animations.Motion();
    ((global::com.codename1.ui.animations.Motion) _r0_o).@this((int) _r2.i, (int) _r3.i, (int) _r4.i);
    _r1.i = 3;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fmotionType = _r1.i;
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createDecelerationMotion(int, int, int)]
}

public static global::System.Object createFrictionMotion(int n1, int n2, float n3, float n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createFrictionMotion(int, int, float, float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r2.i = n1;
    _r3.i = n2;
    _r4.f = n3;
    _r5.f = n4;
    _r0_o = new global::com.codename1.ui.animations.Motion();
    ((global::com.codename1.ui.animations.Motion) _r0_o).@this((int) _r2.i, (float) _r4.f, (float) _r5.f);
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fdestinationValue = _r3.i;
    _r1.i = 2;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fmotionType = _r1.i;
    return (global::com.codename1.ui.animations.Motion) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: com.codename1.ui.animations.Motion createFrictionMotion(int, int, float, float)]
}

public virtual void start(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void start()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.l = global::java.lang.System.currentTimeMillis();
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fstartTime = _r0.l;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void start()]
}

public virtual long getCurrentMotionTime(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: long getCurrentMotionTime()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r4_o)._fcurrentMotionTime;
    _r2.l = 0L;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i >= 0) goto label16;
    _r0.l = global::java.lang.System.currentTimeMillis();
    _r2.l = ((global::com.codename1.ui.animations.Motion) _r4_o)._fstartTime;
    _r0.l = _r0.l - _r2.l;
    label15:;
    return _r0.l;
    label16:;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r4_o)._fcurrentMotionTime;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: long getCurrentMotionTime()]
}

public virtual void setCurrentMotionTime(long n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void setCurrentMotionTime(long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.l = n1;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._fcurrentMotionTime = _r3.l;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r2_o)._flastReturnedValue;
    _r1.i = ((global::com.codename1.ui.animations.Motion) _r2_o)._fdestinationValue;
    if (_r0.i != _r1.i) goto label12;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r2_o)._fsourceValue;
    ((global::com.codename1.ui.animations.Motion) _r2_o)._flastReturnedValue = _r0.i;
    label12:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void setCurrentMotionTime(long)]
}

public virtual void setStartTime(long n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void setStartTime(long)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.l = n1;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fstartTime = _r1.l;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void setStartTime(long)]
}

public virtual bool isFinished(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: boolean isFinished()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r5.i = 1;
    _r4.i = 0;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r6_o)._fcurrentMotionTime;
    _r2.l = 0L;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i >= 0) goto label31;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r6_o).getCurrentMotionTime();
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fduration;
    _r2.l = (long) _r2.i;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i > 0) goto label27;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fdestinationValue;
    _r1.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._flastReturnedValue;
    if (_r0.i != _r1.i) goto label29;
    label27:;
    _r0.i = _r5.i;
    label28:;
    return _r0.i!=0;
    label29:;
    _r0.i = _r4.i;
    goto label28;
    label31:;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r6_o).getCurrentMotionTime();
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fduration;
    _r2.l = (long) _r2.i;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i > 0) goto label48;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fdestinationValue;
    _r1.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._flastReturnedValue;
    if (_r0.i != _r1.i) goto label50;
    label48:;
    _r0.i = _r5.i;
    goto label28;
    label50:;
    _r0.i = _r4.i;
    goto label28;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: boolean isFinished()]
}

private int getSplineValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getSplineValue()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r11_o = null;
    _r11_o = this;
    _r10.f = (float)2.0D;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o).isFinished() ? 1 : 0;
    if (_r6.i == 0) goto label11;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fdestinationValue;
    label10:;
    return _r6.i;
    label11:;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fduration;
    _r4.f = (float) _r6.i;
    _r6.l = ((global::com.codename1.ui.animations.Motion) _r11_o).getCurrentMotionTime();
    _r6.i = (int) _r6.l;
    _r1.f = (float) _r6.i;
    _r6.l = ((global::com.codename1.ui.animations.Motion) _r11_o)._fcurrentMotionTime;
    _r8.l = -1L;
    _r6.i = _r6.l > _r8.l ? 1 : (_r6.l == _r8.l ? 0 : -1);
    if (_r6.i <= 0) goto label36;
    _r6.l = ((global::com.codename1.ui.animations.Motion) _r11_o)._fstartTime;
    _r6.f = (float) _r6.l;
    _r1.f = _r1.f - _r6.f;
    _r6.l = ((global::com.codename1.ui.animations.Motion) _r11_o)._fstartTime;
    _r6.f = (float) _r6.l;
    _r4.f = _r4.f - _r6.f;
    label36:;
    _r1.f = global::java.lang.Math.min((float) _r1.f, (float) _r4.f);
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fdestinationValue;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fsourceValue;
    _r6.i = _r6.i - _r7.i;
    _r3.i = global::java.lang.Math.abs((int) _r6.i);
    _r0.f = _r4.f / _r10.f;
    _r6.f = (float) _r3.i;
    _r7.f = _r0.f * _r0.f;
    _r2.f = _r6.f / _r7.f;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fsourceValue;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fdestinationValue;
    if (_r6.i >= _r7.i) goto label94;
    _r6.i = _r1.f > _r0.f ? 1 : (_r1.f == _r0.f ? 0 : -1);
    if (_r6.i <= 0) goto label84;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fsourceValue;
    _r7.f = -_r0.f;
    _r7.f = _r7.f * _r0.f;
    _r8.f = _r10.f * _r0.f;
    _r8.f = _r8.f * _r1.f;
    _r7.f = _r7.f + _r8.f;
    _r8.f = _r1.f * _r1.f;
    _r8.f = _r8.f / _r10.f;
    _r7.f = _r7.f - _r8.f;
    _r7.f = _r7.f * _r2.f;
    _r7.i = (int) _r7.f;
    _r5.i = _r6.i + _r7.i;
    label82:;
    _r6.i = _r5.i;
    goto label10;
    label84:;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fsourceValue;
    _r7.f = _r2.f * _r1.f;
    _r7.f = _r7.f * _r1.f;
    _r7.f = _r7.f / _r10.f;
    _r7.i = (int) _r7.f;
    _r5.i = _r6.i + _r7.i;
    goto label82;
    label94:;
    _r1.f = _r4.f - _r1.f;
    _r6.i = _r1.f > _r0.f ? 1 : (_r1.f == _r0.f ? 0 : -1);
    if (_r6.i <= 0) goto label117;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fdestinationValue;
    _r7.f = -_r0.f;
    _r7.f = _r7.f * _r0.f;
    _r8.f = _r10.f * _r0.f;
    _r8.f = _r8.f * _r1.f;
    _r7.f = _r7.f + _r8.f;
    _r8.f = _r1.f * _r1.f;
    _r8.f = _r8.f / _r10.f;
    _r7.f = _r7.f - _r8.f;
    _r7.f = _r7.f * _r2.f;
    _r7.i = (int) _r7.f;
    _r5.i = _r6.i + _r7.i;
    goto label82;
    label117:;
    _r6.i = ((global::com.codename1.ui.animations.Motion) _r11_o)._fdestinationValue;
    _r7.f = _r2.f * _r1.f;
    _r7.f = _r7.f * _r1.f;
    _r7.f = _r7.f / _r10.f;
    _r7.i = (int) _r7.f;
    _r5.i = _r6.i + _r7.i;
    goto label82;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getSplineValue()]
}

private int getCubicValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getCubicValue()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r14_o = null;
    _r14_o = this;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o).isFinished() ? 1 : 0;
    if (_r10.i == 0) goto label9;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fdestinationValue;
    label8:;
    return _r10.i;
    label9:;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fduration;
    _r9.f = (float) _r10.i;
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o).getCurrentMotionTime();
    _r10.i = (int) _r10.l;
    _r5.f = (float) _r10.i;
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o)._fcurrentMotionTime;
    _r12.l = -1L;
    _r10.i = _r10.l > _r12.l ? 1 : (_r10.l == _r12.l ? 0 : -1);
    if (_r10.i <= 0) goto label34;
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o)._fstartTime;
    _r10.f = (float) _r10.l;
    _r5.f = _r5.f - _r10.f;
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o)._fstartTime;
    _r10.f = (float) _r10.l;
    _r9.f = _r9.f - _r10.f;
    label34:;
    _r5.f = global::java.lang.Math.min((float) _r5.f, (float) _r9.f);
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o)._fcurrentMotionTime;
    _r12.l = -1L;
    _r10.i = _r10.l > _r12.l ? 1 : (_r10.l == _r12.l ? 0 : -1);
    if (_r10.i <= 0) goto label54;
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o)._fstartTime;
    _r10.f = (float) _r10.l;
    _r5.f = _r5.f - _r10.f;
    _r10.l = ((global::com.codename1.ui.animations.Motion) _r14_o)._fstartTime;
    _r10.f = (float) _r10.l;
    _r9.f = _r9.f - _r10.f;
    label54:;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fdestinationValue;
    _r11.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fsourceValue;
    _r10.i = _r10.i - _r11.i;
    _r10.i = global::java.lang.Math.abs((int) _r10.i);
    _r7.f = (float) _r10.i;
    _r8.f = _r5.f / _r9.f;
    _r10.f = (float)1.0D;
    _r10.f = _r10.f - _r8.f;
    _r11.f = (float)1.0D;
    _r11.f = _r11.f - _r8.f;
    _r10.f = _r10.f * _r11.f;
    _r11.f = (float)1.0D;
    _r11.f = _r11.f - _r8.f;
    _r10.f = _r10.f * _r11.f;
    _r11.f = ((global::com.codename1.ui.animations.Motion) _r14_o)._fp0;
    _r0.f = _r10.f * _r11.f;
    _r10.f = (float)3.0D;
    _r11.f = (float)1.0D;
    _r11.f = _r11.f - _r8.f;
    _r10.f = _r10.f * _r11.f;
    _r11.f = (float)1.0D;
    _r11.f = _r11.f - _r8.f;
    _r10.f = _r10.f * _r11.f;
    _r10.f = _r10.f * _r8.f;
    _r11.f = ((global::com.codename1.ui.animations.Motion) _r14_o)._fp1;
    _r1.f = _r10.f * _r11.f;
    _r10.f = (float)3.0D;
    _r11.f = (float)1.0D;
    _r11.f = _r11.f - _r8.f;
    _r10.f = _r10.f * _r11.f;
    _r10.f = _r10.f * _r8.f;
    _r10.f = _r10.f * _r8.f;
    _r11.f = ((global::com.codename1.ui.animations.Motion) _r14_o)._fp2;
    _r2.f = _r10.f * _r11.f;
    _r10.f = _r8.f * _r8.f;
    _r10.f = _r10.f * _r8.f;
    _r11.f = ((global::com.codename1.ui.animations.Motion) _r14_o)._fp3;
    _r6.f = _r10.f * _r11.f;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fdestinationValue;
    _r11.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fsourceValue;
    if (_r10.i <= _r11.i) goto label133;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fsourceValue;
    _r11.f = _r0.f + _r1.f;
    _r11.f = _r11.f + _r2.f;
    _r11.f = _r11.f + _r6.f;
    _r11.f = _r11.f * _r7.f;
    _r11.i = (int) _r11.f;
    _r3.i = _r10.i + _r11.i;
    label131:;
    _r10.i = _r3.i;
    goto label8;
    label133:;
    _r10.f = _r0.f + _r1.f;
    _r10.f = _r10.f + _r2.f;
    _r10.f = _r10.f + _r6.f;
    _r10.f = _r10.f * _r7.f;
    _r4.i = (int) _r10.f;
    _r10.i = ((global::com.codename1.ui.animations.Motion) _r14_o)._fsourceValue;
    _r3.i = _r10.i - _r4.i;
    goto label131;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getCubicValue()]
}

public virtual int getValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getValue()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r4_o)._fcurrentMotionTime;
    _r2.l = -1L;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i <= 0) goto label21;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r4_o)._fstartTime;
    _r2.l = ((global::com.codename1.ui.animations.Motion) _r4_o).getCurrentMotionTime();
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i <= 0) goto label21;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o)._fsourceValue;
    label20:;
    return _r0.i;
    label21:;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o)._fmotionType;
    switch (_r0.i) {
    case 1: goto label35;
    case 2: goto label49;
    case 3: goto label56;
    case 4: goto label42;
    }
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o).getLinear();
    ((global::com.codename1.ui.animations.Motion) _r4_o)._flastReturnedValue = _r0.i;
    label32:;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o)._flastReturnedValue;
    goto label20;
    label35:;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o).getSplineValue();
    ((global::com.codename1.ui.animations.Motion) _r4_o)._flastReturnedValue = _r0.i;
    goto label32;
    label42:;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o).getCubicValue();
    ((global::com.codename1.ui.animations.Motion) _r4_o)._flastReturnedValue = _r0.i;
    goto label32;
    label49:;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o).getFriction();
    ((global::com.codename1.ui.animations.Motion) _r4_o)._flastReturnedValue = _r0.i;
    goto label32;
    label56:;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r4_o).getRubber();
    ((global::com.codename1.ui.animations.Motion) _r4_o)._flastReturnedValue = _r0.i;
    goto label32;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getValue()]
}

private int getLinear(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getLinear()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r8_o = null;
    _r8_o = this;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o).isFinished() ? 1 : 0;
    if (_r4.i == 0) goto label9;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fdestinationValue;
    label8:;
    return _r4.i;
    label9:;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fduration;
    _r2.f = (float) _r4.i;
    _r4.l = ((global::com.codename1.ui.animations.Motion) _r8_o).getCurrentMotionTime();
    _r4.i = (int) _r4.l;
    _r0.f = (float) _r4.i;
    _r4.l = ((global::com.codename1.ui.animations.Motion) _r8_o)._fcurrentMotionTime;
    _r6.l = -1L;
    _r4.i = _r4.l > _r6.l ? 1 : (_r4.l == _r6.l ? 0 : -1);
    if (_r4.i <= 0) goto label34;
    _r4.l = ((global::com.codename1.ui.animations.Motion) _r8_o)._fstartTime;
    _r4.f = (float) _r4.l;
    _r0.f = _r0.f - _r4.f;
    _r4.l = ((global::com.codename1.ui.animations.Motion) _r8_o)._fstartTime;
    _r4.f = (float) _r4.l;
    _r2.f = _r2.f - _r4.f;
    label34:;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fdestinationValue;
    _r5.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fsourceValue;
    _r1.i = _r4.i - _r5.i;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fsourceValue;
    _r4.f = (float) _r4.i;
    _r5.f = _r0.f / _r2.f;
    _r6.f = (float) _r1.i;
    _r5.f = _r5.f * _r6.f;
    _r4.f = _r4.f + _r5.f;
    _r3.i = (int) _r4.f;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fdestinationValue;
    _r5.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fsourceValue;
    if (_r4.i >= _r5.i) goto label62;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fdestinationValue;
    _r4.i = global::java.lang.Math.max((int) _r4.i, (int) _r3.i);
    goto label8;
    label62:;
    _r4.i = ((global::com.codename1.ui.animations.Motion) _r8_o)._fdestinationValue;
    _r4.i = global::java.lang.Math.min((int) _r4.i, (int) _r3.i);
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getLinear()]
}

private int getFriction(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getFriction()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r2.l = ((global::com.codename1.ui.animations.Motion) _r6_o).getCurrentMotionTime();
    _r1.i = (int) _r2.l;
    _r0.i = 0;
    _r2.f = ((global::com.codename1.ui.animations.Motion) _r6_o)._finitVelocity;
    _r2.f = global::java.lang.Math.abs((float) _r2.f);
    _r3.f = (float) _r1.i;
    _r2.f = _r2.f * _r3.f;
    _r3.f = ((global::com.codename1.ui.animations.Motion) _r6_o)._ffriction;
    _r4.f = (float) _r1.i;
    _r5.f = (float) _r1.i;
    _r4.f = _r4.f * _r5.f;
    _r5.f = (float)2.0D;
    _r4.f = _r4.f / _r5.f;
    _r3.f = _r3.f * _r4.f;
    _r2.f = _r2.f - _r3.f;
    _r0.i = (int) _r2.f;
    _r2.f = ((global::com.codename1.ui.animations.Motion) _r6_o)._finitVelocity;
    _r3.f = (float)0.0D;
    _r2.i = _r2.f > _r3.f ? 1 : (_r2.f == _r3.f ? 0 : -1);
    if (_r2.i >= 0) goto label34;
    _r0.i = _r0.i * -1;
    label34:;
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fsourceValue;
    _r0.i = _r0.i + _r2.i;
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fdestinationValue;
    _r3.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fsourceValue;
    if (_r2.i <= _r3.i) goto label50;
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fdestinationValue;
    _r2.i = global::java.lang.Math.min((int) _r0.i, (int) _r2.i);
    label49:;
    return _r2.i;
    label50:;
    _r2.i = ((global::com.codename1.ui.animations.Motion) _r6_o)._fdestinationValue;
    _r2.i = global::java.lang.Math.max((int) _r0.i, (int) _r2.i);
    goto label49;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getFriction()]
}

private int getRubber(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getRubber()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    _r12_o = this;
    _r11.f = (float)2.0D;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o).isFinished() ? 1 : 0;
    if (_r7.i == 0) goto label11;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fdestinationValue;
    label10:;
    return _r7.i;
    label11:;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fduration;
    _r5.f = (float) _r7.i;
    _r7.l = ((global::com.codename1.ui.animations.Motion) _r12_o).getCurrentMotionTime();
    _r7.i = (int) _r7.l;
    _r1.f = (float) _r7.i;
    _r7.l = ((global::com.codename1.ui.animations.Motion) _r12_o)._fcurrentMotionTime;
    _r9.l = -1L;
    _r7.i = _r7.l > _r9.l ? 1 : (_r7.l == _r9.l ? 0 : -1);
    if (_r7.i <= 0) goto label36;
    _r7.l = ((global::com.codename1.ui.animations.Motion) _r12_o)._fstartTime;
    _r7.f = (float) _r7.l;
    _r1.f = _r1.f - _r7.f;
    _r7.l = ((global::com.codename1.ui.animations.Motion) _r12_o)._fstartTime;
    _r7.f = (float) _r7.l;
    _r5.f = _r5.f - _r7.f;
    label36:;
    _r1.f = global::java.lang.Math.min((float) _r1.f, (float) _r5.f);
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fdestinationValue;
    _r8.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fsourceValue;
    _r7.i = _r7.i - _r8.i;
    _r4.i = global::java.lang.Math.abs((int) _r7.i);
    _r0.f = _r5.f / _r11.f;
    _r7.f = (float) _r4.i;
    _r8.f = _r0.f * _r0.f;
    _r3.f = _r7.f / _r8.f;
    _r7.f = -_r0.f;
    _r7.f = _r7.f * _r0.f;
    _r8.f = _r11.f * _r0.f;
    _r8.f = _r8.f * _r1.f;
    _r7.f = _r7.f + _r8.f;
    _r8.f = _r1.f * _r1.f;
    _r8.f = _r8.f / _r11.f;
    _r7.f = _r7.f - _r8.f;
    _r7.f = _r7.f * _r3.f;
    _r2.i = (int) _r7.f;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fsourceValue;
    _r8.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fdestinationValue;
    if (_r7.i >= _r8.i) goto label91;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fsourceValue;
    _r8.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fsourceValue;
    _r8.i = _r8.i + _r2.i;
    _r6.i = global::java.lang.Math.max((int) _r7.i, (int) _r8.i);
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fdestinationValue;
    _r6.i = global::java.lang.Math.min((int) _r7.i, (int) _r6.i);
    label89:;
    _r7.i = _r6.i;
    goto label10;
    label91:;
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fsourceValue;
    _r8.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fsourceValue;
    _r8.i = _r8.i - _r2.i;
    _r6.i = global::java.lang.Math.min((int) _r7.i, (int) _r8.i);
    _r7.i = ((global::com.codename1.ui.animations.Motion) _r12_o)._fdestinationValue;
    _r6.i = global::java.lang.Math.max((int) _r7.i, (int) _r6.i);
    goto label89;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getRubber()]
}

public virtual int getSourceValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getSourceValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r1_o)._fsourceValue;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getSourceValue()]
}

public virtual int getDestinationValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getDestinationValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r1_o)._fdestinationValue;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getDestinationValue()]
}

public virtual void setSourceValue(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: void setSourceValue(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.ui.animations.Motion) _r0_o)._fsourceValue = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: void setSourceValue(int)]
}

public virtual long getStartTime(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: long getStartTime()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.l = ((global::com.codename1.ui.animations.Motion) _r2_o)._fstartTime;
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: long getStartTime()]
}

public virtual int getDuration(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion: int getDuration()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.ui.animations.Motion) _r1_o)._fduration;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion: int getDuration()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.animations.Motion]
//XMLVM_END_WRAPPER[com.codename1.ui.animations.Motion]

} // end of class: Motion

} // end of namespace: com.codename1.ui.animations
