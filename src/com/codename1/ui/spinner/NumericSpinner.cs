// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.ui.spinner {
public class NumericSpinner: global::com.codename1.ui.spinner.BaseSpinner {
private global::com.codename1.ui.spinner.Spinner _fspin;

private double _fmin;

private double _fmax;

private double _fvalue;

private double _fstep;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void <init>()]
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
    _r4_o = this;
    _r2.d = 0.0D;
    ((global::com.codename1.ui.spinner.BaseSpinner) _r4_o).@this();
    ((global::com.codename1.ui.spinner.NumericSpinner) _r4_o)._fmin = _r2.d;
    _r0.d = 1000.0D;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r4_o)._fmax = _r0.d;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r4_o)._fvalue = _r2.d;
    _r0.d = 1.0D;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r4_o)._fstep = _r0.d;
    _r0_o = new global::com.codename1.ui.layouts.BorderLayout();
    ((global::com.codename1.ui.layouts.BorderLayout) _r0_o).@this();
    ((global::com.codename1.ui.spinner.NumericSpinner) _r4_o).setLayout((global::com.codename1.ui.layouts.Layout) _r0_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void <init>()]
}

public override void initSpinner(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void initSpinner()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fspin;
    if (_r0_o != null) goto label17;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o).createSpinner();
    ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fspin = (global::com.codename1.ui.spinner.Spinner) _r0_o;
    // Value=Center
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114))}));
    _r1_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fspin;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o).addComponent((global::java.lang.Object) _r0_o, (global::com.codename1.ui.Component) _r1_o);
    label17:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void initSpinner()]
}

public virtual global::System.Object createSpinner(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: com.codename1.ui.spinner.Spinner createSpinner()]
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
    _r8_o = this;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r8_o)._fmin;
    _r2.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r8_o)._fmax;
    _r4.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r8_o)._fvalue;
    _r6.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r8_o)._fstep;
    _r0_o = global::com.codename1.ui.spinner.Spinner.create((double) _r0.d, (double) _r2.d, (double) _r4.d, (double) _r6.d);
    return (global::com.codename1.ui.spinner.Spinner) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: com.codename1.ui.spinner.Spinner createSpinner()]
}

public virtual double getMin(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getMin()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fmin;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getMin()]
}

public virtual void setMin(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setMin(double)]
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
    _r10_o = this;
    _r11.d = n1;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fmin = _r11.d;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue;
    _r0.i = _r11.d > _r0.d ? 1 : (_r11.d == _r0.d ? 0 : -1);
    if (_r0.i <= 0) goto label10;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue = _r11.d;
    label10:;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fspin;
    if (_r0_o == null) goto label31;
    _r9_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fspin;
    _r0_o = new global::com.codename1.ui.spinner.SpinnerNumberModel();
    _r3.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fmax;
    _r5.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue;
    _r7.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fstep;
    _r1.d = _r11.d;
    ((global::com.codename1.ui.spinner.SpinnerNumberModel) _r0_o).@this((double) _r1.d, (double) _r3.d, (double) _r5.d, (double) _r7.d);
    ((global::com.codename1.ui.spinner.Spinner) _r9_o).setModel((global::com.codename1.ui.list.ListModel) _r0_o);
    label31:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setMin(double)]
}

public virtual double getMax(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getMax()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fmax;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getMax()]
}

public virtual void setMax(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setMax(double)]
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
    _r10_o = this;
    _r11.d = n1;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fmax = _r11.d;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue;
    _r0.i = _r11.d > _r0.d ? 1 : (_r11.d == _r0.d ? 0 : -1);
    if (_r0.i >= 0) goto label10;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue = _r11.d;
    label10:;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fspin;
    if (_r0_o == null) goto label31;
    _r9_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fspin;
    _r0_o = new global::com.codename1.ui.spinner.SpinnerNumberModel();
    _r1.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fmin;
    _r5.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue;
    _r7.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fstep;
    _r3.d = _r11.d;
    ((global::com.codename1.ui.spinner.SpinnerNumberModel) _r0_o).@this((double) _r1.d, (double) _r3.d, (double) _r5.d, (double) _r7.d);
    ((global::com.codename1.ui.spinner.Spinner) _r9_o).setModel((global::com.codename1.ui.list.ListModel) _r0_o);
    label31:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setMax(double)]
}

public virtual double getValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fspin;
    if (_r0_o == null) goto label23;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fspin;
    _r2_o = ((global::com.codename1.ui.spinner.Spinner) _r0_o).getModel();
    _r2_o = _r2_o;
    _r2_o = ((global::com.codename1.ui.spinner.SpinnerNumberModel) _r2_o).getValue();
    _r2_o = _r2_o;
    _r0.d = ((global::java.lang.Double) _r2_o).doubleValue();
    label22:;
    return _r0.d;
    label23:;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fvalue;
    goto label22;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getValue()]
}

public virtual void setValue(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setValue(double)]
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
    _r2.d = n1;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r1_o)._fvalue = _r2.d;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r1_o)._fspin;
    if (_r0_o == null) goto label22;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r1_o)._fspin;
    _r1_o = ((global::com.codename1.ui.spinner.Spinner) _r0_o).getModel();
    _r1_o = _r1_o;
    _r0_o = new global::java.lang.Double();
    ((global::java.lang.Double) _r0_o).@this((double) _r2.d);
    ((global::com.codename1.ui.spinner.SpinnerNumberModel) _r1_o).setValue((global::java.lang.Object) _r0_o);
    label22:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setValue(double)]
}

public virtual double getStep(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getStep()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r2_o)._fstep;
    return _r0.d;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: double getStep()]
}

public virtual void setStep(double n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setStep(double)]
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
    _r10_o = this;
    _r11.d = n1;
    ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fstep = _r11.d;
    _r0_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fspin;
    if (_r0_o == null) goto label23;
    _r9_o = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fspin;
    _r0_o = new global::com.codename1.ui.spinner.SpinnerNumberModel();
    _r1.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fmin;
    _r3.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fmax;
    _r5.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r10_o)._fvalue;
    _r7.d = _r11.d;
    ((global::com.codename1.ui.spinner.SpinnerNumberModel) _r0_o).@this((double) _r1.d, (double) _r3.d, (double) _r5.d, (double) _r7.d);
    ((global::com.codename1.ui.spinner.Spinner) _r9_o).setModel((global::com.codename1.ui.list.ListModel) _r0_o);
    label23:;
    return;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: void setStep(double)]
}

public override global::System.Object getPropertyNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.String[] getPropertyNames()]
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
    _r0.i = 4;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=min
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 1;
    // Value=max
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 2;
    // Value=value
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    _r1.i = 3;
    // Value=step
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.String[] getPropertyNames()]
}

public override global::System.Object getPropertyTypes(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.Class[] getPropertyTypes()]
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
    _r4_o = this;
    _r3_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Double));
    _r0.i = 4;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Double));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 1;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Double));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 2;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Double));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 3;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.Double));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.Class[] getPropertyTypes()]
}

public override global::System.Object getPropertyTypeNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.String[] getPropertyTypeNames()]
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
    _r4_o = this;
    // Value=double
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = 5;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    _r1.i = 0;
    // Value=double
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 1;
    // Value=double
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 2;
    // Value=double
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 3;
    // Value=double
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    _r1.i = 4;
    // Value=double
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101))}));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r1.i] = _r3_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.String[] getPropertyTypeNames()]
}

public override global::System.Object getPropertyValue(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.Object getPropertyValue(java.lang.String)]
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
    _r3_o = this;
    _r4_o = n1;
    // Value=min
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label16;
    _r0_o = new global::java.lang.Double();
    _r1.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o)._fmin;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    label15:;
    return (global::java.lang.Object) _r0_o;
    label16:;
    // Value=max
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label32;
    _r0_o = new global::java.lang.Double();
    _r1.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o)._fmax;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label15;
    label32:;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label50;
    _r0_o = new global::java.lang.Double();
    _r1.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o).getValue();
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label15;
    label50:;
    // Value=step
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label66;
    _r0_o = new global::java.lang.Double();
    _r1.d = ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o)._fstep;
    ((global::java.lang.Double) _r0_o).@this((double) _r1.d);
    goto label15;
    label66:;
    _r0_o = null;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.Object getPropertyValue(java.lang.String)]
}

public override global::System.Object setPropertyValue(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.String setPropertyValue(java.lang.String, java.lang.Object)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r2_o = null;
    // Value=min
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label22;
    _r0_o = ((global::java.lang.Object) _r5_o).toString();
    _r0.d = global::java.lang.Double.parseDouble((global::java.lang.String) _r0_o);
    ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o).setMin((double) _r0.d);
    _r0_o = _r2_o;
    label21:;
    return (global::java.lang.String) _r0_o;
    label22:;
    // Value=max
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 120))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label43;
    _r0_o = ((global::java.lang.Object) _r5_o).toString();
    _r0.d = global::java.lang.Double.parseDouble((global::java.lang.String) _r0_o);
    ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o).setMax((double) _r0.d);
    _r0_o = _r2_o;
    goto label21;
    label43:;
    // Value=value
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)118)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 101))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label64;
    _r0_o = ((global::java.lang.Object) _r5_o).toString();
    _r0.d = global::java.lang.Double.parseDouble((global::java.lang.String) _r0_o);
    ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o).setValue((double) _r0.d);
    _r0_o = _r2_o;
    goto label21;
    label64:;
    // Value=step
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 112))}));
    _r0.i = ((global::java.lang.String) _r4_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label85;
    _r0_o = ((global::java.lang.Object) _r5_o).toString();
    _r0.d = global::java.lang.Double.parseDouble((global::java.lang.String) _r0_o);
    ((global::com.codename1.ui.spinner.NumericSpinner) _r3_o).setStep((double) _r0.d);
    _r0_o = _r2_o;
    goto label21;
    label85:;
    _r0_o = base.setPropertyValue((global::java.lang.String) _r4_o, (global::java.lang.Object) _r5_o);
    goto label21;
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner: java.lang.String setPropertyValue(java.lang.String, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.ui.spinner.NumericSpinner]
//XMLVM_END_WRAPPER[com.codename1.ui.spinner.NumericSpinner]

} // end of class: NumericSpinner

} // end of namespace: com.codename1.ui.spinner
