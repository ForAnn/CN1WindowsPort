// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Formatter_2FloatUtil: global::java.lang.Object {
private global::java.lang.StringBuilder _fresult;

private global::java.lang.Object _fdecimalFormat;

private global::java.util.Formatter_2FormatToken _fformatToken;

private global::java.lang.Object _fargument;

private char _fminusSign;

public void @this(global::java.lang.StringBuilder n1, global::java.util.Formatter_2FormatToken n2, global::org.xmlvm.runtime.RedTypeMarker n3, global::java.lang.Object n4){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: void <init>(java.lang.StringBuilder, java.util.Formatter$FormatToken, java.text.DecimalFormat, java.lang.Object)]
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
    _r4_o = n3;
    _r5_o = n4;
    ((global::java.lang.Object) _r1_o).@this();
    ((global::java.util.Formatter_2FloatUtil) _r1_o)._fresult = (global::java.lang.StringBuilder) _r2_o;
    ((global::java.util.Formatter_2FloatUtil) _r1_o)._fformatToken = (global::java.util.Formatter_2FormatToken) _r3_o;
    ((global::java.util.Formatter_2FloatUtil) _r1_o)._fdecimalFormat = (global::org.xmlvm.runtime.RedTypeMarker) _r4_o;
    ((global::java.util.Formatter_2FloatUtil) _r1_o)._fargument = (global::java.lang.Object) _r5_o;
// Red class access removed: java.text.DecimalFormat getDecimalFormatSymbols
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat getDecimalFormatSymbols");
// Red class access removed: java.text.DecimalFormatSymbols getMinusSign
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormatSymbols getMinusSign");
    ((global::java.util.Formatter_2FloatUtil) _r1_o)._fminusSign = (char) _r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: void <init>(java.lang.StringBuilder, java.util.Formatter$FormatToken, java.text.DecimalFormat, java.lang.Object)]
}

public virtual void transform(global::java.util.Formatter_2FormatToken n1, global::java.lang.StringBuilder n2){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: void transform(java.util.Formatter$FormatToken, java.lang.StringBuilder)]
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
    _r3_o = n1;
    _r4_o = n2;
    ((global::java.util.Formatter_2FloatUtil) _r2_o)._fresult = (global::java.lang.StringBuilder) _r4_o;
    ((global::java.util.Formatter_2FloatUtil) _r2_o)._fformatToken = (global::java.util.Formatter_2FormatToken) _r3_o;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r2_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getConversionType();
    switch (_r0.i) {
    case 65: goto label41;
    case 69: goto label29;
    case 71: goto label37;
    case 97: goto label41;
    case 101: goto label29;
    case 102: goto label33;
    case 103: goto label37;
    }
    _r0_o = new global::java.util.UnknownFormatConversionException();
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r2_o)._fformatToken;
    _r1.i = ((global::java.util.Formatter_2FormatToken) _r1_o).getConversionType();
    _r1_o = global::java.lang.String.valueOf((char) _r1.i);
    ((global::java.util.UnknownFormatConversionException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.UnknownFormatConversionException) _r0_o);
    label29:;
    ((global::java.util.Formatter_2FloatUtil) _r2_o).transform_1e();
    label32:;
    return;
    label33:;
    ((global::java.util.Formatter_2FloatUtil) _r2_o).transform_1f();
    goto label32;
    label37:;
    ((global::java.util.Formatter_2FloatUtil) _r2_o).transform_1g();
    goto label32;
    label41:;
    ((global::java.util.Formatter_2FloatUtil) _r2_o).transform_1a();
    goto label32;
    label46:;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: void transform(java.util.Formatter$FormatToken, java.lang.StringBuilder)]
}

public virtual char getMinusSign(){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: char getMinusSign()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.Formatter_2FloatUtil) _r1_o)._fminusSign;
    return (char) _r0.i;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: char getMinusSign()]
}

public virtual char getAddSign(){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: char getAddSign()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 43;
    return (char) _r0.i;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: char getAddSign()]
}

public virtual void transform_1e(){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: void transform_e()]
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
    _r3.i = 69;
    _r2.i = 48;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r2.i);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r1.i = ((global::java.util.Formatter_2FormatToken) _r1_o).getPrecision();
    if (_r1.i <= 0) goto label39;
    _r1.i = 46;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r1.i = ((global::java.util.Formatter_2FormatToken) _r1_o).getPrecision();
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    global::java.util.Arrays.fill((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (char) _r2.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    label39:;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r3.i);
    // Value=+00
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)43)), unchecked((char) unchecked((uint) 48)), unchecked((char) unchecked((uint) 48))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
// Red class access removed: java.text.DecimalFormat applyPattern
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat applyPattern");
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
// Red class access removed: java.text.DecimalFormat format
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat format");
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    _r2.i = 101;
    _r0_o = ((global::java.lang.String) _r0_o).replace((char) _r3.i, (char) _r2.i);
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r1.i = 2;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).isFlagSet((int) _r1.i) ? 1 : 0;
    if (_r0.i == 0) goto label115;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getPrecision();
    if (_r0.i != 0) goto label115;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    // Value=e
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)101))}));
    _r0.i = ((global::java.lang.StringBuilder) _r0_o).indexOf((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
// Red class access removed: java.text.DecimalFormat getDecimalFormatSymbols
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat getDecimalFormatSymbols");
// Red class access removed: java.text.DecimalFormatSymbols getDecimalSeparator
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormatSymbols getDecimalSeparator");
    _r2_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    ((global::java.lang.StringBuilder) _r2_o).insert((int) _r0.i, (char) _r1.i);
    label115:;
    return;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: void transform_e()]
}

public virtual void transform_1g(){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: void transform_g()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r13_o = this;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getPrecision();
    if (_r0.i != 0) goto label40;
    _r0.i = 1;
    _r1.i = _r0.i;
    label10:;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    ((global::java.util.Formatter_2FormatToken) _r0_o).setPrecision((int) _r1.i);
    _r2.d = 0.0D;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fargument;
    _r0_o = _r0_o;
    _r4.d = ((global::java.lang.Number) _r0_o).doubleValue();
    _r0.i = _r2.d > _r4.d ? 1 : (_r2.d == _r4.d ? 0 : -1);
    if (_r0.i != 0) goto label42;
    _r0.i = _r1.i + -1;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    ((global::java.util.Formatter_2FormatToken) _r1_o).setPrecision((int) _r0.i);
    ((global::java.util.Formatter_2FloatUtil) _r13_o).transform_1f();
    label39:;
    return;
    label40:;
    _r1.i = _r0.i;
    goto label10;
    label42:;
    _r2.i = 1;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fargument;
    _r0_o = _r0_o;
    _r3.d = ((global::java.lang.Number) _r0_o).doubleValue();
    _r3.d = global::java.lang.Math.abs((double) _r3.d);
    _r0.i = global::java.lang.Double.isInfinite((double) _r3.d) ? 1 : 0;
    if (_r0.i == 0) goto label78;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getPrecision();
    _r0.i = _r0.i + -1;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    ((global::java.util.Formatter_2FormatToken) _r1_o).setPrecision((int) _r0.i);
    ((global::java.util.Formatter_2FloatUtil) _r13_o).transform_1e();
    goto label39;
    label78:;
    _r0_o = new global::java.math.BigDecimal();
    _r5_o = new global::java.math.MathContext();
    ((global::java.math.MathContext) _r5_o).@this((int) _r1.i);
    ((global::java.math.BigDecimal) _r0_o).@this((double) _r3.d, (global::java.math.MathContext) _r5_o);
    _r3.d = ((global::java.math.BigDecimal) _r0_o).doubleValue();
    _r5.l = ((global::java.math.BigDecimal) _r0_o).longValue();
    _r7.d = 1.0D;
    _r7.i = _r3.d > _r7.d ? 1 : (_r3.d == _r7.d ? 0 : -1);
    if (_r7.i < 0) goto label196;
    _r7.d = 10.0D;
    _r9.d = (double) _r1.i;
    _r7.d = global::java.lang.Math.pow((double) _r7.d, (double) _r9.d);
    _r7.i = _r3.d > _r7.d ? 1 : (_r3.d == _r7.d ? 0 : -1);
    if (_r7.i >= 0) goto label196;
    _r7.d = (double) _r5.l;
    _r9.d = 10.0D;
    _r11.d = (double) _r1.i;
    _r9.d = global::java.lang.Math.pow((double) _r9.d, (double) _r11.d);
    _r0.i = _r7.d > _r9.d ? 1 : (_r7.d == _r9.d ? 0 : -1);
    if (_r0.i >= 0) goto label291;
    _r0.i = 0;
    _r2_o = global::java.lang.String.valueOf((long) _r5.l);
    _r2.i = ((global::java.lang.String) _r2_o).length();
    _r1.i = _r1.i - _r2.i;
    if (_r1.i >= 0) goto label138;
    _r1.i = 0;
    label138:;
    _r5.d = 10.0D;
    _r2.i = _r1.i + 1;
    _r7.d = (double) _r2.i;
    _r5.d = global::java.lang.Math.pow((double) _r5.d, (double) _r7.d);
    _r2.d = _r3.d * _r5.d;
    _r2.l = global::java.lang.Math.round((double) _r2.d);
    _r2_o = global::java.lang.String.valueOf((long) _r2.l);
    _r2.i = ((global::java.lang.String) _r2_o).length();
    _r3_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    _r3.i = ((global::java.util.Formatter_2FormatToken) _r3_o).getPrecision();
    if (_r2.i > _r3.i) goto label171;
    _r1.i = _r1.i + 1;
    label171:;
    _r2_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    ((global::java.util.Formatter_2FormatToken) _r2_o).setPrecision((int) _r1.i);
    label176:;
    if (_r0.i == 0) goto label293;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getPrecision();
    _r0.i = _r0.i + -1;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    ((global::java.util.Formatter_2FormatToken) _r1_o).setPrecision((int) _r0.i);
    ((global::java.util.Formatter_2FloatUtil) _r13_o).transform_1e();
    goto label39;
    label196:;
    _r5.i = 4;
    _r5_o = ((global::java.math.BigDecimal) _r0_o).movePointRight((int) _r5.i);
    _r5.l = ((global::java.math.BigDecimal) _r5_o).longValue();
    _r7.d = 10.0D;
    _r9.d = -4.0D;
    _r7.d = global::java.lang.Math.pow((double) _r7.d, (double) _r9.d);
    _r7.i = _r3.d > _r7.d ? 1 : (_r3.d == _r7.d ? 0 : -1);
    if (_r7.i < 0) goto label291;
    _r7.d = 1.0D;
    _r3.i = _r3.d > _r7.d ? 1 : (_r3.d == _r7.d ? 0 : -1);
    if (_r3.i >= 0) goto label291;
    _r2.i = 0;
    _r3.i = 4;
    _r4_o = global::java.lang.String.valueOf((long) _r5.l);
    _r4.i = ((global::java.lang.String) _r4_o).length();
    _r3.i = _r3.i - _r4.i;
    _r1.i = _r1.i + _r3.i;
    _r3.i = _r1.i + 1;
    _r3_o = ((global::java.math.BigDecimal) _r0_o).movePointRight((int) _r3.i);
    _r3.l = ((global::java.math.BigDecimal) _r3_o).longValue();
    _r3_o = global::java.lang.String.valueOf((long) _r3.l);
    _r3.i = ((global::java.lang.String) _r3_o).length();
    _r4_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    _r4.i = ((global::java.util.Formatter_2FormatToken) _r4_o).getPrecision();
    if (_r3.i > _r4.i) goto label263;
    _r1.i = _r1.i + 1;
    label263:;
    _r0_o = ((global::java.math.BigDecimal) _r0_o).movePointRight((int) _r1.i);
    _r3.l = ((global::java.math.BigDecimal) _r0_o).longValue();
    _r3.d = (double) _r3.l;
    _r5.d = 10.0D;
    _r0.i = 4;
    _r0.i = _r1.i - _r0.i;
    _r7.d = (double) _r0.i;
    _r5.d = global::java.lang.Math.pow((double) _r5.d, (double) _r7.d);
    _r0.i = _r3.d > _r5.d ? 1 : (_r3.d == _r5.d ? 0 : -1);
    if (_r0.i < 0) goto label291;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r13_o)._fformatToken;
    ((global::java.util.Formatter_2FormatToken) _r0_o).setPrecision((int) _r1.i);
    label291:;
    _r0.i = _r2.i;
    goto label176;
    label293:;
    ((global::java.util.Formatter_2FloatUtil) _r13_o).transform_1f();
    goto label39;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: void transform_g()]
}

public virtual void transform_1f(){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: void transform_f()]
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
    _r3.i = 1;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r2.i = 32;
    _r1.i = ((global::java.util.Formatter_2FormatToken) _r1_o).isFlagSet((int) _r2.i) ? 1 : 0;
    if (_r1.i == 0) goto label40;
    _r1.i = 44;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
// Red class access removed: java.text.DecimalFormat getGroupingSize
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat getGroupingSize");
    if (_r1.i <= _r3.i) goto label40;
    _r1.i = _r1.i - _r3.i;
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    _r2.i = 35;
    global::java.util.Arrays.fill((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (char) _r2.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    label40:;
    _r1.i = 0;
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r1.i = ((global::java.util.Formatter_2FormatToken) _r1_o).getPrecision();
    if (_r1.i <= 0) goto label73;
    _r1.i = 46;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r1.i = ((global::java.util.Formatter_2FormatToken) _r1_o).getPrecision();
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    _r2.i = 48;
    global::java.util.Arrays.fill((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (char) _r2.i);
    ((global::java.lang.StringBuilder) _r0_o).append((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    label73:;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
// Red class access removed: java.text.DecimalFormat applyPattern
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat applyPattern");
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
    _r2_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
// Red class access removed: java.text.DecimalFormat format
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat format");
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r1.i = 2;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).isFlagSet((int) _r1.i) ? 1 : 0;
    if (_r0.i == 0) goto label127;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getPrecision();
    if (_r0.i != 0) goto label127;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fdecimalFormat;
// Red class access removed: java.text.DecimalFormat getDecimalFormatSymbols
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormat getDecimalFormatSymbols");
// Red class access removed: java.text.DecimalFormatSymbols getDecimalSeparator
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: java.text.DecimalFormatSymbols getDecimalSeparator");
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    ((global::java.lang.StringBuilder) _r1_o).append((char) _r0.i);
    label127:;
    return;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: void transform_f()]
}

public virtual void transform_1a(){
//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil: void transform_a()]
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
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getConversionType();
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
    _r1.i = ((_r1_o != null) && (_r1_o is global::java.lang.Float)) ? 1 : 0;
    if (_r1.i == 0) goto label38;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
    _r0_o = _r0_o;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    _r0.f = ((global::java.lang.Float) _r0_o).floatValue();
    _r0_o = global::java.lang.Float.toHexString((float) _r0.f);
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r0_o);
    label29:;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).isPrecisionSet() ? 1 : 0;
    if (_r0.i != 0) goto label74;
    label37:;
    return;
    label38:;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
    _r1.i = ((_r1_o != null) && (_r1_o is global::java.lang.Double)) ? 1 : 0;
    if (_r1.i == 0) goto label62;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
    _r0_o = _r0_o;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    _r2.d = ((global::java.lang.Double) _r0_o).doubleValue();
    _r0_o = global::java.lang.Double.toHexString((double) _r2.d);
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r0_o);
    goto label29;
    label62:;
    _r1_o = new global::java.util.IllegalFormatConversionException();
    _r2_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fargument;
    _r2_o = ((global::java.lang.Object) _r2_o).getClass();
    ((global::java.util.IllegalFormatConversionException) _r1_o).@this((char) _r0.i, (global::java.lang.Class) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.IllegalFormatConversionException) _r1_o);
    label74:;
    _r0_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fformatToken;
    _r0.i = ((global::java.util.Formatter_2FormatToken) _r0_o).getPrecision();
    if (_r0.i != 0) goto label83;
    _r0.i = 1;
    label83:;
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    // Value=.
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    _r1.i = ((global::java.lang.StringBuilder) _r1_o).indexOf((global::java.lang.String) _r2_o);
    _r1.i = _r1.i + 1;
    _r2_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    // Value=p
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112))}));
    _r2.i = ((global::java.lang.StringBuilder) _r2_o).indexOf((global::java.lang.String) _r3_o);
    _r3.i = _r2.i - _r1.i;
    if (_r3.i == _r0.i) goto label37;
    if (_r3.i >= _r0.i) goto label121;
    _r0.i = _r0.i - _r3.i;
    _r0_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r0.i]);
    _r1.i = 48;
    global::java.util.Arrays.fill((global::org.xmlvm._nArrayAdapter<char>) _r0_o, (char) _r1.i);
    _r1_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    ((global::java.lang.StringBuilder) _r1_o).insert((int) _r2.i, (global::org.xmlvm._nArrayAdapter<char>) _r0_o);
    goto label37;
    label121:;
    _r3_o = ((global::java.util.Formatter_2FloatUtil) _r4_o)._fresult;
    _r0.i = _r0.i + _r1.i;
    ((global::java.lang.StringBuilder) _r3_o).delete((int) _r0.i, (int) _r2.i);
    goto label37;
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil: void transform_a()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Formatter$FloatUtil]
//XMLVM_END_WRAPPER[java.util.Formatter$FloatUtil]

} // end of class: Formatter_2FloatUtil

} // end of namespace: java.util
