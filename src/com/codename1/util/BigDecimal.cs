// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util {
public class BigDecimal: global::java.lang.Object {

static BigDecimal() {
    @static();
}

private static global::com.codename1.util.BigInteger _fZERO;

private static global::com.codename1.util.BigInteger _fONE;

private global::com.codename1.util.BigInteger _fbigInt;

private int _fscale;

public static global::System.Object getInstance(global::com.codename1.util.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal getInstance(com.codename1.util.BigInteger, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r3.i = n2;
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigInteger) _r2_o).shiftLeft((int) _r3.i);
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r3.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal getInstance(com.codename1.util.BigInteger, int)]
}

public void @this(global::com.codename1.util.BigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: void <init>(com.codename1.util.BigInteger, int)]
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
    _r4.i = n2;
    ((global::java.lang.Object) _r2_o).@this();
    if (_r4.i >= 0) goto label13;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=scale may not be negative
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label13:;
    ((global::com.codename1.util.BigDecimal) _r2_o)._fbigInt = (global::com.codename1.util.BigInteger) _r3_o;
    ((global::com.codename1.util.BigDecimal) _r2_o)._fscale = _r4.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: void <init>(com.codename1.util.BigInteger, int)]
}

private void @this(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: void <init>(com.codename1.util.BigDecimal)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o)._fbigInt;
    ((global::com.codename1.util.BigDecimal) _r1_o)._fbigInt = (global::com.codename1.util.BigInteger) _r0_o;
    _r0.i = ((global::com.codename1.util.BigDecimal) _r2_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r1_o)._fscale = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: void <init>(com.codename1.util.BigDecimal)]
}

private void checkScale(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: void checkScale(com.codename1.util.BigDecimal)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::com.codename1.util.BigDecimal) _r2_o)._fscale;
    _r1.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    if (_r0.i == _r1.i) goto label14;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=Only BigDecimal of same scale allowed in arithmetic operations
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)79)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 68)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 115))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label14:;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: void checkScale(com.codename1.util.BigDecimal)]
}

public virtual global::System.Object adjustScale(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal adjustScale(int)]
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
    _r4.i = n1;
    if (_r4.i >= 0) goto label10;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=scale may not be negative
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)115)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101))}));
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label10:;
    _r0.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    if (_r4.i != _r0.i) goto label20;
    _r0_o = new global::com.codename1.util.BigDecimal();
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigDecimal) _r3_o);
    label19:;
    return (global::com.codename1.util.BigDecimal) _r0_o;
    label20:;
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    _r2.i = _r4.i - _r2.i;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).shiftLeft((int) _r2.i);
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r4.i);
    goto label19;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal adjustScale(int)]
}

public virtual global::System.Object add(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal add(com.codename1.util.BigDecimal)]
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
    ((global::com.codename1.util.BigDecimal) _r3_o).checkScale((global::com.codename1.util.BigDecimal) _r4_o);
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r2_o = ((global::com.codename1.util.BigDecimal) _r4_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).add((global::com.codename1.util.BigInteger) _r2_o);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal add(com.codename1.util.BigDecimal)]
}

public virtual global::System.Object add(global::com.codename1.util.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal add(com.codename1.util.BigInteger)]
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
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    _r2_o = ((global::com.codename1.util.BigInteger) _r4_o).shiftLeft((int) _r2.i);
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).add((global::com.codename1.util.BigInteger) _r2_o);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal add(com.codename1.util.BigInteger)]
}

public virtual global::System.Object negate(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal negate()]
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
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).negate();
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal negate()]
}

public virtual global::System.Object subtract(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal subtract(com.codename1.util.BigDecimal)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o).negate();
    _r0_o = ((global::com.codename1.util.BigDecimal) _r1_o).add((global::com.codename1.util.BigDecimal) _r0_o);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal subtract(com.codename1.util.BigDecimal)]
}

public virtual global::System.Object subtract(global::com.codename1.util.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal subtract(com.codename1.util.BigInteger)]
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
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    _r2_o = ((global::com.codename1.util.BigInteger) _r4_o).shiftLeft((int) _r2.i);
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).subtract((global::com.codename1.util.BigInteger) _r2_o);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal subtract(com.codename1.util.BigInteger)]
}

public virtual global::System.Object multiply(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal multiply(com.codename1.util.BigDecimal)]
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
    _r4_o = this;
    _r5_o = n1;
    ((global::com.codename1.util.BigDecimal) _r4_o).checkScale((global::com.codename1.util.BigDecimal) _r5_o);
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r4_o)._fbigInt;
    _r2_o = ((global::com.codename1.util.BigDecimal) _r5_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).multiply((global::com.codename1.util.BigInteger) _r2_o);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r4_o)._fscale;
    _r3.i = ((global::com.codename1.util.BigDecimal) _r4_o)._fscale;
    _r2.i = _r2.i + _r3.i;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal multiply(com.codename1.util.BigDecimal)]
}

public virtual global::System.Object multiply(global::com.codename1.util.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal multiply(com.codename1.util.BigInteger)]
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
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).multiply((global::com.codename1.util.BigInteger) _r4_o);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal multiply(com.codename1.util.BigInteger)]
}

public virtual global::System.Object divide(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal divide(com.codename1.util.BigDecimal)]
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
    _r4_o = this;
    _r5_o = n1;
    ((global::com.codename1.util.BigDecimal) _r4_o).checkScale((global::com.codename1.util.BigDecimal) _r5_o);
    _r1_o = ((global::com.codename1.util.BigDecimal) _r4_o)._fbigInt;
    _r2.i = ((global::com.codename1.util.BigDecimal) _r4_o)._fscale;
    _r0_o = ((global::com.codename1.util.BigInteger) _r1_o).shiftLeft((int) _r2.i);
    _r1_o = new global::com.codename1.util.BigDecimal();
    _r2_o = ((global::com.codename1.util.BigDecimal) _r5_o)._fbigInt;
    _r2_o = ((global::com.codename1.util.BigInteger) _r0_o).divide((global::com.codename1.util.BigInteger) _r2_o);
    _r3.i = ((global::com.codename1.util.BigDecimal) _r4_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r1_o).@this((global::com.codename1.util.BigInteger) _r2_o, (int) _r3.i);
    return (global::com.codename1.util.BigDecimal) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal divide(com.codename1.util.BigDecimal)]
}

public virtual global::System.Object divide(global::com.codename1.util.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal divide(com.codename1.util.BigInteger)]
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
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).divide((global::com.codename1.util.BigInteger) _r4_o);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal divide(com.codename1.util.BigInteger)]
}

public virtual global::System.Object shiftLeft(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal shiftLeft(int)]
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
    _r4.i = n1;
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigInteger) _r1_o).shiftLeft((int) _r4.i);
    _r2.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    return (global::com.codename1.util.BigDecimal) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigDecimal shiftLeft(int)]
}

public virtual int compareTo(global::com.codename1.util.BigDecimal n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: int compareTo(com.codename1.util.BigDecimal)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    ((global::com.codename1.util.BigDecimal) _r2_o).checkScale((global::com.codename1.util.BigDecimal) _r3_o);
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o)._fbigInt;
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o)._fbigInt;
    _r0.i = ((global::com.codename1.util.BigInteger) _r0_o).compareTo((global::com.codename1.util.BigInteger) _r1_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: int compareTo(com.codename1.util.BigDecimal)]
}

public virtual int compareTo(global::com.codename1.util.BigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: int compareTo(com.codename1.util.BigInteger)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o)._fbigInt;
    _r1.i = ((global::com.codename1.util.BigDecimal) _r2_o)._fscale;
    _r1_o = ((global::com.codename1.util.BigInteger) _r3_o).shiftLeft((int) _r1.i);
    _r0.i = ((global::com.codename1.util.BigInteger) _r0_o).compareTo((global::com.codename1.util.BigInteger) _r1_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: int compareTo(com.codename1.util.BigInteger)]
}

public virtual global::System.Object floor(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigInteger floor()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o)._fbigInt;
    _r1.i = ((global::com.codename1.util.BigDecimal) _r2_o)._fscale;
    _r0_o = ((global::com.codename1.util.BigInteger) _r0_o).shiftRight((int) _r1.i);
    return (global::com.codename1.util.BigInteger) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigInteger floor()]
}

public virtual global::System.Object round(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigInteger round()]
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
    _r0_o = new global::com.codename1.util.BigDecimal();
    _r1_o = global::com.codename1.util.BigDecimal._fONE;
    _r2.i = 1;
    ((global::com.codename1.util.BigDecimal) _r0_o).@this((global::com.codename1.util.BigInteger) _r1_o, (int) _r2.i);
    _r1.i = ((global::com.codename1.util.BigDecimal) _r3_o)._fscale;
    _r1_o = ((global::com.codename1.util.BigDecimal) _r0_o).adjustScale((int) _r1.i);
    _r1_o = ((global::com.codename1.util.BigDecimal) _r3_o).add((global::com.codename1.util.BigDecimal) _r1_o);
    _r1_o = ((global::com.codename1.util.BigDecimal) _r1_o).floor();
    return (global::com.codename1.util.BigInteger) _r1_o;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: com.codename1.util.BigInteger round()]
}

public virtual int intValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: int intValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r1_o).floor();
    _r0.i = ((global::com.codename1.util.BigInteger) _r0_o).intValue();
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: int intValue()]
}

public virtual long longValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: long longValue()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o).floor();
    _r0.l = ((global::com.codename1.util.BigInteger) _r0_o).longValue();
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: long longValue()]
}

public virtual int getScale(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: int getScale()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.util.BigDecimal) _r1_o)._fscale;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: int getScale()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: java.lang.String toString()]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r14_o = this;
    _r13.i = -1;
    _r11.i = ((global::com.codename1.util.BigDecimal) _r14_o)._fscale;
    if (_r11.i != 0) goto label12;
    _r11_o = ((global::com.codename1.util.BigDecimal) _r14_o)._fbigInt;
    _r11_o = ((global::com.codename1.util.BigInteger) _r11_o).toString();
    label11:;
    return (global::java.lang.String) _r11_o;
    label12:;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r14_o).floor();
    _r11_o = ((global::com.codename1.util.BigDecimal) _r14_o)._fbigInt;
    _r12.i = ((global::com.codename1.util.BigDecimal) _r14_o)._fscale;
    _r12_o = ((global::com.codename1.util.BigInteger) _r0_o).shiftLeft((int) _r12.i);
    _r1_o = ((global::com.codename1.util.BigInteger) _r11_o).subtract((global::com.codename1.util.BigInteger) _r12_o);
    _r11_o = ((global::com.codename1.util.BigDecimal) _r14_o)._fbigInt;
    _r11.i = ((global::com.codename1.util.BigInteger) _r11_o).signum();
    if (_r11.i != _r13.i) goto label48;
    _r11_o = global::com.codename1.util.BigDecimal._fONE;
    _r12.i = ((global::com.codename1.util.BigDecimal) _r14_o)._fscale;
    _r11_o = ((global::com.codename1.util.BigInteger) _r11_o).shiftLeft((int) _r12.i);
    _r1_o = ((global::com.codename1.util.BigInteger) _r11_o).subtract((global::com.codename1.util.BigInteger) _r1_o);
    label48:;
    _r11.i = ((global::com.codename1.util.BigInteger) _r0_o).signum();
    if (_r11.i != _r13.i) goto label68;
    _r11_o = global::com.codename1.util.BigDecimal._fZERO;
    _r11.i = ((global::com.codename1.util.BigInteger) _r1_o).equals((global::java.lang.Object) _r11_o) ? 1 : 0;
    if (_r11.i != 0) goto label68;
    _r11_o = global::com.codename1.util.BigDecimal._fONE;
    _r0_o = ((global::com.codename1.util.BigInteger) _r0_o).add((global::com.codename1.util.BigInteger) _r11_o);
    label68:;
    _r7_o = ((global::com.codename1.util.BigInteger) _r0_o).toString();
    _r11.i = ((global::com.codename1.util.BigDecimal) _r14_o)._fscale;
    _r2_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r11.i]);
    _r11.i = 2;
    _r4_o = ((global::com.codename1.util.BigInteger) _r1_o).toString((int) _r11.i);
    _r3.i = ((global::java.lang.String) _r4_o).length();
    _r11.i = ((global::com.codename1.util.BigDecimal) _r14_o)._fscale;
    _r10.i = _r11.i - _r3.i;
    _r5.i = 0;
    label90:;
    if (_r5.i >= _r10.i) goto label99;
    _r11.i = 48;
    ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r5.i] = (char)_r11.i;
    _r5.i = _r5.i + 1;
    goto label90;
    label99:;
    _r6.i = 0;
    label100:;
    if (_r6.i >= _r3.i) goto label113;
    _r11.i = _r10.i + _r6.i;
    _r12.i = ((global::java.lang.String) _r4_o).charAt((int) _r6.i);
    ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r11.i] = (char)_r12.i;
    _r6.i = _r6.i + 1;
    goto label100;
    label113:;
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String) _r8_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r2_o);
    _r9_o = new global::java.lang.StringBuffer();
    ((global::java.lang.StringBuffer) _r9_o).@this((global::java.lang.String) _r7_o);
    // Value=.
    _r11_o = new global::java.lang.String();
    ((global::java.lang.String)_r11_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    ((global::java.lang.StringBuffer) _r9_o).append((global::java.lang.String) _r11_o);
    ((global::java.lang.StringBuffer) _r9_o).append((global::java.lang.String) _r8_o);
    _r11_o = ((global::java.lang.StringBuffer) _r9_o).toString();
    goto label11;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: java.lang.String toString()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: boolean equals(java.lang.Object)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r5.i = 1;
    _r4.i = 0;
    if (_r6_o != _r7_o) goto label6;
    _r2.i = _r5.i;
    label5:;
    return _r2.i!=0;
    label6:;
    _r2.i = ((_r7_o != null) && (_r7_o is global::com.codename1.util.BigDecimal)) ? 1 : 0;
    if (_r2.i != 0) goto label12;
    _r2.i = _r4.i;
    goto label5;
    label12:;
    _r0_o = _r7_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r2_o = ((global::com.codename1.util.BigDecimal) _r6_o)._fbigInt;
    _r3_o = ((global::com.codename1.util.BigDecimal) _r1_o)._fbigInt;
    _r2.i = ((global::com.codename1.util.BigInteger) _r2_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    _r2.i = ((global::com.codename1.util.BigDecimal) _r6_o)._fscale;
    _r3.i = ((global::com.codename1.util.BigDecimal) _r1_o)._fscale;
    if (_r2.i != _r3.i) goto label34;
    _r2.i = _r5.i;
    goto label5;
    label34:;
    _r2.i = _r4.i;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::com.codename1.util.BigDecimal) _r2_o)._fbigInt;
    _r0.i = ((global::com.codename1.util.BigInteger) _r0_o).hashCode();
    _r1.i = ((global::com.codename1.util.BigDecimal) _r2_o)._fscale;
    _r0.i = _r0.i ^ _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: int hashCode()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0.l = 0L;
    _r0_o = global::com.codename1.util.BigInteger.valueOf((long) _r0.l);
    global::com.codename1.util.BigDecimal._fZERO = (global::com.codename1.util.BigInteger) _r0_o;
    _r0.l = 1L;
    _r0_o = global::com.codename1.util.BigInteger.valueOf((long) _r0.l);
    global::com.codename1.util.BigDecimal._fONE = (global::com.codename1.util.BigInteger) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.BigDecimal]
//XMLVM_END_WRAPPER[com.codename1.util.BigDecimal]

} // end of class: BigDecimal

} // end of namespace: com.codename1.util
