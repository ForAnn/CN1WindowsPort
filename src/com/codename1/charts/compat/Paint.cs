// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.charts.compat {
public class Paint: global::java.lang.Object {
public static global::com.codename1.ui.Graphics _fg;

private bool _fantiAlias;

private global::com.codename1.ui.Font _ftypeface;

private int _fstrokeCap;

private int _fstrokeJoin;

private float _fstrokeMiter;

private global::com.codename1.charts.compat.Paint_2Style _fstyle;

private float _fstrokeWidth;

private int _fcolor;

private int _falign;

private float _ftextSize;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.f = (float)1.0D;
    _r1.i = 0;
    ((global::java.lang.Object) _r3_o).@this();
    _r0.i = 8;
    _r0_o = global::com.codename1.ui.Font.createSystemFont((int) _r1.i, (int) _r1.i, (int) _r0.i);
    ((global::com.codename1.charts.compat.Paint) _r3_o)._ftypeface = (global::com.codename1.ui.Font) _r0_o;
    ((global::com.codename1.charts.compat.Paint) _r3_o)._fstrokeCap = _r1.i;
    _r0.i = 2;
    ((global::com.codename1.charts.compat.Paint) _r3_o)._fstrokeJoin = _r0.i;
    ((global::com.codename1.charts.compat.Paint) _r3_o)._fstrokeMiter = _r2.f;
    _r0_o = global::com.codename1.charts.compat.Paint_2Style._fSTROKE;
    ((global::com.codename1.charts.compat.Paint) _r3_o)._fstyle = (global::com.codename1.charts.compat.Paint_2Style) _r0_o;
    ((global::com.codename1.charts.compat.Paint) _r3_o)._fstrokeWidth = _r2.f;
    _r0.f = (float)12.0D;
    ((global::com.codename1.charts.compat.Paint) _r3_o)._ftextSize = _r0.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void <init>()]
}

public virtual void getTextWidths(global::java.lang.String n1, global::org.xmlvm._nArrayAdapter<float> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void getTextWidths(java.lang.String, float[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r1_o = ((global::com.codename1.charts.compat.Paint) _r5_o).getTypeface();
    if (_r1_o == null) goto label29;
    _r0_o = ((global::java.lang.String) _r6_o).toCharArray();
    _r2.i = 0;
    label11:;
    _r3.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r2.i >= _r3.i) goto label37;
    _r3.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r2.i >= _r3.i) goto label37;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r0_o)[_r2.i];
    _r3.i = ((global::com.codename1.ui.Font) _r1_o).charWidth((char) _r3.i);
    _r3.f = (float) _r3.i;
    ((global::org.xmlvm._nArrayAdapter<float>) _r7_o)[_r2.i] = _r3.f;
    _r2.i = _r2.i + 1;
    goto label11;
    label29:;
    _r3_o = new global::java.lang.RuntimeException();
    // Value=Faild to get cn1 font
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.RuntimeException) _r3_o).@this((global::java.lang.String) _r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r3_o);
    label37:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void getTextWidths(java.lang.String, float[])]
}

public virtual int breakText(global::java.lang.String n1, bool n2, float n3, global::org.xmlvm._nArrayAdapter<float> n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: int breakText(java.lang.String, boolean, float, float[])]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r13_o = null;
    _r9_o = this;
    _r10_o = n1;
    _r11.i = n2 ? 1 : 0;
    _r12.f = n3;
    _r13_o = n4;
    _r8.i = 1;
    _r0_o = ((global::java.lang.String) _r10_o).toCharArray();
    _r2_o = ((global::com.codename1.charts.compat.Paint) _r9_o).getTypeface();
    _r6.f = (float)0.0D;
    if (_r2_o == null) goto label62;
    if (_r11.i == 0) goto label45;
    _r7.i = 0;
    _r5.i = _r7.i;
    label16:;
    if (_r11.i == 0) goto label49;
    _r4.i = _r8.i;
    label19:;
    _r1.f = (float)0.0D;
    _r3.i = _r5.i;
    label21:;
    if (_r11.i == 0) goto label26;
    _r7.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r3.i < _r7.i) goto label30;
    label26:;
    if (_r11.i != 0) goto label70;
    if (_r3.i < 0) goto label70;
    label30:;
    _r7.i = ((global::org.xmlvm._nArrayAdapter<char>) _r0_o)[_r3.i];
    _r7.i = ((global::com.codename1.ui.Font) _r2_o).charWidth((char) _r7.i);
    _r6.f = (float) _r7.i;
    _r7.f = _r1.f + _r6.f;
    _r7.i = _r7.f > _r12.f ? 1 : (_r7.f == _r12.f ? 0 : -1);
    if (_r7.i <= 0) goto label52;
    _r7.i = _r3.i;
    label44:;
    return _r7.i;
    label45:;
    _r7.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r7.i = _r7.i - _r8.i;
    _r5.i = _r7.i;
    goto label16;
    label49:;
    _r7.i = -1;
    _r4.i = _r7.i;
    goto label19;
    label52:;
    if (_r13_o == null) goto label59;
    _r7.i = ((global::org.xmlvm._nIArray) _r13_o).Length;
    if (_r3.i >= _r7.i) goto label59;
    ((global::org.xmlvm._nArrayAdapter<float>) _r13_o)[_r3.i] = _r6.f;
    label59:;
    _r1.f = _r1.f + _r6.f;
    _r3.i = _r3.i + _r4.i;
    goto label21;
    label62:;
    _r7_o = new global::java.lang.RuntimeException();
    // Value=Failed to get font
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.RuntimeException) _r7_o).@this((global::java.lang.String) _r8_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r7_o);
    label70:;
    _r7.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    goto label44;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: int breakText(java.lang.String, boolean, float, float[])]
}

public virtual void getTextBounds(global::java.lang.String n1, int n2, int n3, global::com.codename1.ui.geom.Rectangle2D n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void getTextBounds(java.lang.String, int, int, com.codename1.ui.geom.Rectangle2D)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    _r7_o = n4;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r3_o).getTypeface();
    if (_r0_o == null) goto label10;
    ((global::com.codename1.charts.compat.Paint) _r3_o).getCN1TextBounds((global::java.lang.String) _r4_o, (int) _r5.i, (int) _r6.i, (global::com.codename1.ui.geom.Rectangle2D) _r7_o);
    return;
    label10:;
    _r1_o = new global::java.lang.RuntimeException();
    // Value=Failed to get font
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.RuntimeException) _r1_o).@this((global::java.lang.String) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r1_o);
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void getTextBounds(java.lang.String, int, int, com.codename1.ui.geom.Rectangle2D)]
}

public virtual void getCN1TextBounds(global::java.lang.String n1, int n2, int n3, global::com.codename1.ui.geom.Rectangle2D n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void getCN1TextBounds(java.lang.String, int, int, com.codename1.ui.geom.Rectangle2D)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nElement _r14;
    global::org.xmlvm._nElement _r15;
    global::System.Object _r16_o = null;
    _r12_o = this;
    _r13_o = n1;
    _r14.i = n2;
    _r15.i = n3;
    _r16_o = n4;
    _r9_o = ((global::com.codename1.charts.compat.Paint) _r12_o).getTypeface();
    if (_r9_o == null) goto label25;
    _r11.i = ((global::com.codename1.ui.Font) _r9_o).substringWidth((global::java.lang.String) _r13_o, (int) _r14.i, (int) _r15.i);
    _r10.i = ((global::com.codename1.ui.Font) _r9_o).getHeight();
    _r1.d = 0.0D;
    _r3.d = 0.0D;
    _r5.d = (double) _r11.i;
    _r7.d = (double) _r10.i;
    _r0_o = _r16_o;
    ((global::com.codename1.ui.geom.Rectangle2D) _r0_o).setBounds((double) _r1.d, (double) _r3.d, (double) _r5.d, (double) _r7.d);
    label25:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void getCN1TextBounds(java.lang.String, int, int, com.codename1.ui.geom.Rectangle2D)]
}

public virtual float measureTextHeight(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: float measureTextHeight(char[], int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::org.xmlvm._nElement _r9;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2;
    _r9.i = n3;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r6_o).getTypeface();
    _r1.f = (float)0.0D;
    if (_r0_o == null) goto label28;
    _r2.i = _r8.i;
    label8:;
    _r4.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r2.i >= _r4.i) goto label36;
    _r4.i = _r8.i + _r9.i;
    if (_r2.i >= _r4.i) goto label36;
    _r4.i = ((global::com.codename1.ui.Font) _r0_o).getHeight();
    _r3.f = (float) _r4.i;
    _r4.i = _r3.f > _r1.f ? 1 : (_r3.f == _r1.f ? 0 : -1);
    if (_r4.i <= 0) goto label25;
    _r1.f = _r3.f;
    label25:;
    _r2.i = _r2.i + 1;
    goto label8;
    label28:;
    _r4_o = new global::java.lang.RuntimeException();
    // Value=Failed to get font
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.RuntimeException) _r4_o).@this((global::java.lang.String) _r5_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r4_o);
    label36:;
    return _r1.f;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: float measureTextHeight(char[], int, int)]
}

public virtual float measureText(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: float measureText(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::java.lang.String) _r4_o).toCharArray();
    _r1.i = 0;
    _r2.i = ((global::java.lang.String) _r4_o).length();
    _r0.f = ((global::com.codename1.charts.compat.Paint) _r3_o).measureText((global::org.xmlvm._nArrayAdapter<char>) _r0_o, (int) _r1.i, (int) _r2.i);
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: float measureText(java.lang.String)]
}

public virtual float measureText(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: float measureText(char[], int, int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r5_o = this;
    _r6_o = n1;
    _r7.i = n2;
    _r8.i = n3;
    _r2.f = (float)0.0D;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r5_o).getTypeface();
    if (_r0_o == null) goto label26;
    _r1.i = _r7.i;
    label8:;
    _r3.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    if (_r1.i >= _r3.i) goto label34;
    _r3.i = _r7.i + _r8.i;
    if (_r1.i >= _r3.i) goto label34;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r6_o)[_r1.i];
    _r3.i = ((global::com.codename1.ui.Font) _r0_o).charWidth((char) _r3.i);
    _r3.f = (float) _r3.i;
    _r2.f = _r2.f + _r3.f;
    _r1.i = _r1.i + 1;
    goto label8;
    label26:;
    _r3_o = new global::java.lang.RuntimeException();
    // Value=Failed to get font
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)70)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116))}));
    ((global::java.lang.RuntimeException) _r3_o).@this((global::java.lang.String) _r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r3_o);
    label34:;
    return _r2.f;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: float measureText(char[], int, int)]
}

public virtual void setAntiAlias(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setAntiAlias(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fantiAlias = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setAntiAlias(boolean)]
}

public virtual global::System.Object getTypeface(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: com.codename1.ui.Font getTypeface()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r1_o)._ftypeface;
    return (global::com.codename1.ui.Font) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: com.codename1.ui.Font getTypeface()]
}

public virtual void setTypeface(global::com.codename1.ui.Font n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setTypeface(com.codename1.ui.Font)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._ftypeface = (global::com.codename1.ui.Font) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setTypeface(com.codename1.ui.Font)]
}

public virtual int getStrokeCap(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: int getStrokeCap()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.compat.Paint) _r1_o)._fstrokeCap;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: int getStrokeCap()]
}

public virtual int getStrokeJoin(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: int getStrokeJoin()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.compat.Paint) _r1_o)._fstrokeJoin;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: int getStrokeJoin()]
}

public virtual float getStrokeMiter(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: float getStrokeMiter()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.compat.Paint) _r1_o)._fstrokeMiter;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: float getStrokeMiter()]
}

public virtual global::System.Object getStyle(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: com.codename1.charts.compat.Paint$Style getStyle()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r1_o)._fstyle;
    return (global::com.codename1.charts.compat.Paint_2Style) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: com.codename1.charts.compat.Paint$Style getStyle()]
}

public virtual void setStrokeCap(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeCap(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fstrokeCap = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeCap(int)]
}

public virtual void setStrokeJoin(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeJoin(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fstrokeJoin = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeJoin(int)]
}

public virtual void setStrokeMiter(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeMiter(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fstrokeMiter = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeMiter(float)]
}

public virtual float getStrokeWidth(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: float getStrokeWidth()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.compat.Paint) _r1_o)._fstrokeWidth;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: float getStrokeWidth()]
}

public virtual void setStrokeWidth(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeWidth(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.f = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fstrokeWidth = _r1.f;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setStrokeWidth(float)]
}

public virtual int getColor(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: int getColor()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.compat.Paint) _r1_o)._fcolor;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: int getColor()]
}

public virtual void setColor(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setColor(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fcolor = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setColor(int)]
}

public virtual void setStyle(global::com.codename1.charts.compat.Paint_2Style n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setStyle(com.codename1.charts.compat.Paint$Style)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._fstyle = (global::com.codename1.charts.compat.Paint_2Style) _r1_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setStyle(com.codename1.charts.compat.Paint$Style)]
}

public virtual void setTextAlign(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setTextAlign(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::com.codename1.charts.compat.Paint) _r0_o)._falign = _r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setTextAlign(int)]
}

public virtual int getTextAlign(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: int getTextAlign()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.charts.compat.Paint) _r1_o)._falign;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: int getTextAlign()]
}

public virtual void setTextSize(float n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: void setTextSize(float)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.f = n1;
    ((global::com.codename1.charts.compat.Paint) _r2_o)._ftextSize = _r3.f;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r2_o)._ftypeface;
    if (_r0_o == null) goto label15;
    _r0_o = ((global::com.codename1.charts.compat.Paint) _r2_o)._ftypeface;
    _r1.i = 0;
    _r0_o = ((global::com.codename1.ui.Font) _r0_o).derive((float) _r3.f, (int) _r1.i);
    ((global::com.codename1.charts.compat.Paint) _r2_o)._ftypeface = (global::com.codename1.ui.Font) _r0_o;
    label15:;
    return;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: void setTextSize(float)]
}

public virtual float getTextSize(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: float getTextSize()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.f = ((global::com.codename1.charts.compat.Paint) _r1_o)._ftextSize;
    return _r0.f;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: float getTextSize()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    // Value=Paint[ color:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 91)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.charts.compat.Paint) _r2_o)._fcolor;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=, align:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.charts.compat.Paint) _r2_o)._falign;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=, textSize:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 122)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.f = ((global::com.codename1.charts.compat.Paint) _r2_o)._ftextSize;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((float) _r1.f);
    // Value=, style:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::com.codename1.charts.compat.Paint) _r2_o)._fstyle;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=, strokeWidth:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 87)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.f = ((global::com.codename1.charts.compat.Paint) _r2_o)._fstrokeWidth;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((float) _r1.f);
    // Value=,, strokeMiter:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 77)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.f = ((global::com.codename1.charts.compat.Paint) _r2_o)._fstrokeMiter;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((float) _r1.f);
    // Value=, strokeJoin:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 74)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.charts.compat.Paint) _r2_o)._fstrokeJoin;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value= strokeCap:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 58))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::com.codename1.charts.compat.Paint) _r2_o)._fstrokeCap;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value=]
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.charts.compat.Paint]
//XMLVM_END_WRAPPER[com.codename1.charts.compat.Paint]

} // end of class: Paint

} // end of namespace: com.codename1.charts.compat
