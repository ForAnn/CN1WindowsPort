// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.util {
public class TBitLevel: global::java.lang.Object {
private void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: void <init>()]
}

public static int bitLength(global::com.codename1.util.TBigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: int bitLength(com.codename1.util.TBigInteger)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = n1;
    _r5.i = 1;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fsign;
    if (_r3.i != 0) goto label7;
    _r3.i = 0;
    label6:;
    return _r3.i;
    label7:;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fnumberLength;
    _r0.i = _r3.i << (0x1f & 5);
    _r3_o = ((global::com.codename1.util.TBigInteger) _r6_o)._fdigits;
    _r4.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fnumberLength;
    _r4.i = _r4.i - _r5.i;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r4.i];
    _r3.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fsign;
    if (_r3.i >= 0) goto label33;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r6_o).getFirstNonzeroDigit();
    _r3.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fnumberLength;
    _r3.i = _r3.i - _r5.i;
    if (_r2.i != _r3.i) goto label33;
    _r1.i = _r1.i + -1;
    label33:;
    _r3.i = global::com.codename1.util.TBitLevel.numberOfLeadingZeros((int) _r1.i);
    _r0.i = _r0.i - _r3.i;
    _r3.i = _r0.i;
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: int bitLength(com.codename1.util.TBigInteger)]
}

public static int numberOfLeadingZeros(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: int numberOfLeadingZeros(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3.i = n1;
    _r2.i = 32;
    if (_r3.i != 0) goto label6;
    _r1.i = _r2.i;
    label5:;
    return _r1.i;
    label6:;
    _r0.i = 0;
    _r1.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 16)));
    if (_r1.i == 0) goto label15;
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 16)));
    _r0.i = _r0.i | 16;
    label15:;
    _r1.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 8)));
    if (_r1.i == 0) goto label23;
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 8)));
    _r0.i = _r0.i | 8;
    label23:;
    _r1.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 4)));
    if (_r1.i == 0) goto label31;
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 4)));
    _r0.i = _r0.i | 4;
    label31:;
    _r1.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 2)));
    if (_r1.i == 0) goto label39;
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 2)));
    _r0.i = _r0.i | 2;
    label39:;
    _r1.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 1)));
    if (_r1.i == 0) goto label47;
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & ((int) 1)));
    _r0.i = _r0.i | 1;
    label47:;
    _r1.i = _r2.i - _r0.i;
    _r2.i = 1;
    _r1.i = _r1.i - _r2.i;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: int numberOfLeadingZeros(int)]
}

public static int bitCount(global::com.codename1.util.TBigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: int bitCount(com.codename1.util.TBigInteger)]
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
    _r4_o = n1;
    _r0.i = 0;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r4_o)._fsign;
    if (_r2.i != 0) goto label7;
    _r2.i = 0;
    label6:;
    return _r2.i;
    label7:;
    _r1.i = ((global::com.codename1.util.TBigInteger) _r4_o).getFirstNonzeroDigit();
    _r2.i = ((global::com.codename1.util.TBigInteger) _r4_o)._fsign;
    if (_r2.i <= 0) goto label32;
    label15:;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r4_o)._fnumberLength;
    if (_r1.i >= _r2.i) goto label70;
    _r2_o = ((global::com.codename1.util.TBigInteger) _r4_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    _r2.l = (long) _r2.i;
    _r2.i = global::com.codename1.util.TBigDecimal.bitCount((long) _r2.l);
    _r0.i = _r0.i + _r2.i;
    _r1.i = _r1.i + 1;
    goto label15;
    label32:;
    _r2_o = ((global::com.codename1.util.TBigInteger) _r4_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    _r2.i = -_r2.i;
    _r2.l = (long) _r2.i;
    _r2.i = global::com.codename1.util.TBigDecimal.bitCount((long) _r2.l);
    _r0.i = _r0.i + _r2.i;
    _r1.i = _r1.i + 1;
    label45:;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r4_o)._fnumberLength;
    if (_r1.i >= _r2.i) goto label64;
    _r2_o = ((global::com.codename1.util.TBigInteger) _r4_o)._fdigits;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    _r2.i = _r2.i ^ -1;
    _r2.l = (long) _r2.i;
    _r2.i = global::com.codename1.util.TBigDecimal.bitCount((long) _r2.l);
    _r0.i = _r0.i + _r2.i;
    _r1.i = _r1.i + 1;
    goto label45;
    label64:;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r4_o)._fnumberLength;
    _r2.i = _r2.i << (0x1f & 5);
    _r0.i = _r2.i - _r0.i;
    label70:;
    _r2.i = _r0.i;
    goto label6;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: int bitCount(com.codename1.util.TBigInteger)]
}

public static bool testBit(global::com.codename1.util.TBigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: boolean testBit(com.codename1.util.TBigInteger, int)]
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
    _r3_o = n1;
    _r4.i = n2;
    _r2.i = 1;
    _r0_o = ((global::com.codename1.util.TBigInteger) _r3_o)._fdigits;
    _r1.i = _r4.i >> (0x1f & 5);
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r0_o)[_r1.i];
    _r1.i = _r4.i & 31;
    _r1.i = _r2.i << (0x1f & _r1.i);
    _r0.i = _r0.i & _r1.i;
    if (_r0.i == 0) goto label16;
    _r0.i = _r2.i;
    label15:;
    return _r0.i!=0;
    label16:;
    _r0.i = 0;
    goto label15;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: boolean testBit(com.codename1.util.TBigInteger, int)]
}

public static bool nonZeroDroppedBits(int n1, global::org.xmlvm._nArrayAdapter<int> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: boolean nonZeroDroppedBits(int, int[])]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5.i = n1;
    _r6_o = n2;
    _r2.i = _r5.i >> (0x1f & 5);
    _r0.i = _r5.i & 31;
    _r1.i = 0;
    label5:;
    if (_r1.i >= _r2.i) goto label14;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i];
    if (_r3.i != 0) goto label14;
    _r1.i = _r1.i + 1;
    goto label5;
    label14:;
    if (_r1.i != _r2.i) goto label24;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i];
    _r4.i = 32;
    _r4.i = _r4.i - _r0.i;
    _r3.i = _r3.i << (0x1f & _r4.i);
    if (_r3.i == 0) goto label26;
    label24:;
    _r3.i = 1;
    label25:;
    return _r3.i!=0;
    label26:;
    _r3.i = 0;
    goto label25;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: boolean nonZeroDroppedBits(int, int[])]
}

public static global::System.Object shiftLeft(global::com.codename1.util.TBigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger shiftLeft(com.codename1.util.TBigInteger, int)]
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
    _r6_o = n1;
    _r7.i = n2;
    _r0.i = _r7.i >> (0x1f & 5);
    _r7.i = _r7.i & 31;
    _r4.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fnumberLength;
    _r4.i = _r4.i + _r0.i;
    if (_r7.i != 0) goto label30;
    _r5.i = 0;
    label10:;
    _r2.i = _r4.i + _r5.i;
    _r1_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r2.i]);
    _r4_o = ((global::com.codename1.util.TBigInteger) _r6_o)._fdigits;
    global::com.codename1.util.TBitLevel.shiftLeft((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r0.i, (int) _r7.i);
    _r3_o = new global::com.codename1.util.TBigInteger();
    _r4.i = ((global::com.codename1.util.TBigInteger) _r6_o)._fsign;
    ((global::com.codename1.util.TBigInteger) _r3_o).@this((int) _r4.i, (int) _r2.i, (global::org.xmlvm._nArrayAdapter<int>) _r1_o);
    ((global::com.codename1.util.TBigInteger) _r3_o).cutOffLeadingZeroes();
    return (global::com.codename1.util.TBigInteger) _r3_o;
    label30:;
    _r5.i = 1;
    goto label10;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger shiftLeft(com.codename1.util.TBigInteger, int)]
}

public static void inplaceShiftLeft(global::com.codename1.util.TBigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: void inplaceShiftLeft(com.codename1.util.TBigInteger, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = n1;
    _r6.i = n2;
    _r4.i = 1;
    _r0.i = _r6.i >> (0x1f & 5);
    _r1.i = ((global::com.codename1.util.TBigInteger) _r5_o)._fnumberLength;
    _r2_o = ((global::com.codename1.util.TBigInteger) _r5_o)._fdigits;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r5_o)._fnumberLength;
    _r3.i = _r3.i - _r4.i;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r3.i];
    _r2.l = (long) _r2.i;
    _r2.i = global::com.codename1.util.TBigDecimal.numberOfLeadingZeros((long) _r2.l);
    _r3.i = _r6.i & 31;
    _r2.i = _r2.i - _r3.i;
    if (_r2.i < 0) goto label43;
    _r2.i = 0;
    label23:;
    _r2.i = _r2.i + _r0.i;
    _r1.i = _r1.i + _r2.i;
    ((global::com.codename1.util.TBigInteger) _r5_o)._fnumberLength = _r1.i;
    _r1_o = ((global::com.codename1.util.TBigInteger) _r5_o)._fdigits;
    _r2_o = ((global::com.codename1.util.TBigInteger) _r5_o)._fdigits;
    _r3.i = _r6.i & 31;
    global::com.codename1.util.TBitLevel.shiftLeft((global::org.xmlvm._nArrayAdapter<int>) _r1_o, (global::org.xmlvm._nArrayAdapter<int>) _r2_o, (int) _r0.i, (int) _r3.i);
    ((global::com.codename1.util.TBigInteger) _r5_o).cutOffLeadingZeroes();
    ((global::com.codename1.util.TBigInteger) _r5_o).unCache();
    return;
    label43:;
    _r2.i = _r4.i;
    goto label23;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: void inplaceShiftLeft(com.codename1.util.TBigInteger, int)]
}

public static void shiftLeft(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3, int n4){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: void shiftLeft(int[], int[], int, int)]
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
    _r6_o = n1;
    _r7_o = n2;
    _r8.i = n3;
    _r9.i = n4;
    _r5.i = 0;
    _r4.i = 1;
    if (_r9.i != 0) goto label17;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r2.i = _r2.i - _r8.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r7_o, (int) _r5.i, (global::java.lang.Object) _r6_o, (int) _r8.i, (int) _r2.i);
    label9:;
    _r0.i = 0;
    label10:;
    if (_r0.i >= _r8.i) goto label54;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i] = _r5.i;
    _r0.i = _r0.i + 1;
    goto label10;
    label17:;
    _r2.i = 32;
    _r1.i = _r2.i - _r9.i;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r2.i = _r2.i - _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r2.i] = _r5.i;
    _r2.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    _r0.i = _r2.i - _r4.i;
    label28:;
    if (_r0.i <= _r8.i) goto label9;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i];
    _r3.i = _r0.i - _r8.i;
    _r3.i = _r3.i - _r4.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r3.i];
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & (_r1.i)));
    _r2.i = _r2.i | _r3.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r0.i] = _r2.i;
    _r2.i = _r0.i - _r4.i;
    _r3.i = _r0.i - _r8.i;
    _r3.i = _r3.i - _r4.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r3.i];
    _r3.i = _r3.i << (0x1f & _r9.i);
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r2.i] = _r3.i;
    _r0.i = _r0.i + -1;
    goto label28;
    label54:;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: void shiftLeft(int[], int[], int, int)]
}

public static void shiftLeftOneBit(global::org.xmlvm._nArrayAdapter<int> n1, global::org.xmlvm._nArrayAdapter<int> n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: void shiftLeftOneBit(int[], int[], int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = n1;
    _r5_o = n2;
    _r6.i = n3;
    _r0.i = 0;
    _r1.i = 0;
    label2:;
    if (_r1.i >= _r6.i) goto label16;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r1.i];
    _r3.i = _r2.i << (0x1f & 1);
    _r3.i = _r3.i | _r0.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r1.i] = _r3.i;
    _r0.i = (int) (((uint) _r2.i) >> (0x1f & ((int) 31)));
    _r1.i = _r1.i + 1;
    goto label2;
    label16:;
    if (_r0.i == 0) goto label20;
    ((global::org.xmlvm._nArrayAdapter<int>) _r4_o)[_r6.i] = _r0.i;
    label20:;
    return;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: void shiftLeftOneBit(int[], int[], int)]
}

public static global::System.Object shiftLeftOneBit(global::com.codename1.util.TBigInteger n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger shiftLeftOneBit(com.codename1.util.TBigInteger)]
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
    _r5_o = n1;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r5_o)._fnumberLength;
    _r1.i = _r3.i + 1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r4_o = ((global::com.codename1.util.TBigInteger) _r5_o)._fdigits;
    global::com.codename1.util.TBitLevel.shiftLeftOneBit((global::org.xmlvm._nArrayAdapter<int>) _r0_o, (global::org.xmlvm._nArrayAdapter<int>) _r4_o, (int) _r3.i);
    _r2_o = new global::com.codename1.util.TBigInteger();
    _r4.i = ((global::com.codename1.util.TBigInteger) _r5_o)._fsign;
    ((global::com.codename1.util.TBigInteger) _r2_o).@this((int) _r4.i, (int) _r1.i, (global::org.xmlvm._nArrayAdapter<int>) _r0_o);
    ((global::com.codename1.util.TBigInteger) _r2_o).cutOffLeadingZeroes();
    return (global::com.codename1.util.TBigInteger) _r2_o;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger shiftLeftOneBit(com.codename1.util.TBigInteger)]
}

public static global::System.Object shiftRight(global::com.codename1.util.TBigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger shiftRight(com.codename1.util.TBigInteger, int)]
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
    _r7_o = n1;
    _r8.i = n2;
    _r1.i = _r8.i >> (0x1f & 5);
    _r8.i = _r8.i & 31;
    _r5.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    if (_r1.i < _r5.i) goto label18;
    _r5.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fsign;
    if (_r5.i >= 0) goto label15;
    _r5_o = global::com.codename1.util.TBigInteger._fMINUS_1ONE;
    label14:;
    return (global::com.codename1.util.TBigInteger) _r5_o;
    label15:;
    _r5_o = global::com.codename1.util.TBigInteger._fZERO;
    goto label14;
    label18:;
    _r5.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    _r3.i = _r5.i - _r1.i;
    _r5.i = _r3.i + 1;
    _r2_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r5.i]);
    _r5_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    global::com.codename1.util.TBitLevel.shiftRight((global::org.xmlvm._nArrayAdapter<int>) _r2_o, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r5_o, (int) _r1.i, (int) _r8.i);
    _r5.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fsign;
    if (_r5.i >= 0) goto label85;
    _r0.i = 0;
    label36:;
    if (_r0.i >= _r1.i) goto label47;
    _r5_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r0.i];
    if (_r5.i != 0) goto label47;
    _r0.i = _r0.i + 1;
    goto label36;
    label47:;
    if (_r0.i < _r1.i) goto label61;
    if (_r8.i <= 0) goto label85;
    _r5_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r0.i];
    _r6.i = 32;
    _r6.i = _r6.i - _r8.i;
    _r5.i = _r5.i << (0x1f & _r6.i);
    if (_r5.i == 0) goto label85;
    label61:;
    _r0.i = 0;
    label62:;
    if (_r0.i >= _r3.i) goto label75;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    _r6.i = -1;
    if (_r5.i != _r6.i) goto label75;
    _r5.i = 0;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i] = _r5.i;
    _r0.i = _r0.i + 1;
    goto label62;
    label75:;
    if (_r0.i != _r3.i) goto label79;
    _r3.i = _r3.i + 1;
    label79:;
    _r5.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    _r5.i = _r5.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i] = _r5.i;
    label85:;
    _r4_o = new global::com.codename1.util.TBigInteger();
    _r5.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fsign;
    ((global::com.codename1.util.TBigInteger) _r4_o).@this((int) _r5.i, (int) _r3.i, (global::org.xmlvm._nArrayAdapter<int>) _r2_o);
    ((global::com.codename1.util.TBigInteger) _r4_o).cutOffLeadingZeroes();
    _r5_o = _r4_o;
    goto label14;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger shiftRight(com.codename1.util.TBigInteger, int)]
}

public static void inplaceShiftRight(global::com.codename1.util.TBigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: void inplaceShiftRight(com.codename1.util.TBigInteger, int)]
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
    _r7_o = n1;
    _r8.i = n2;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r7_o).signum();
    if (_r8.i == 0) goto label12;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r7_o).signum();
    if (_r3.i != 0) goto label13;
    label12:;
    return;
    label13:;
    _r1.i = _r8.i >> (0x1f & 5);
    _r3.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    _r3.i = _r3.i - _r1.i;
    ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength = _r3.i;
    _r3_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r4.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    _r5_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r6.i = _r8.i & 31;
    _r3.i = global::com.codename1.util.TBitLevel.shiftRight((global::org.xmlvm._nArrayAdapter<int>) _r3_o, (int) _r4.i, (global::org.xmlvm._nArrayAdapter<int>) _r5_o, (int) _r1.i, (int) _r6.i) ? 1 : 0;
    if (_r3.i != 0) goto label74;
    if (_r2.i >= 0) goto label74;
    _r0.i = 0;
    label37:;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    if (_r0.i >= _r3.i) goto label56;
    _r3_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    _r4.i = -1;
    if (_r3.i != _r4.i) goto label56;
    _r3_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r4.i = 0;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i] = _r4.i;
    _r0.i = _r0.i + 1;
    goto label37;
    label56:;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    if (_r0.i != _r3.i) goto label66;
    _r3.i = ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength;
    _r3.i = _r3.i + 1;
    ((global::com.codename1.util.TBigInteger) _r7_o)._fnumberLength = _r3.i;
    label66:;
    _r3_o = ((global::com.codename1.util.TBigInteger) _r7_o)._fdigits;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i];
    _r4.i = _r4.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r0.i] = _r4.i;
    label74:;
    ((global::com.codename1.util.TBigInteger) _r7_o).cutOffLeadingZeroes();
    ((global::com.codename1.util.TBigInteger) _r7_o).unCache();
    goto label12;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: void inplaceShiftRight(com.codename1.util.TBigInteger, int)]
}

public static bool shiftRight(global::org.xmlvm._nArrayAdapter<int> n1, int n2, global::org.xmlvm._nArrayAdapter<int> n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: boolean shiftRight(int[], int, int[], int, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = n1;
    _r7.i = n2;
    _r8_o = n3;
    _r9.i = n4;
    _r10.i = n5;
    _r5.i = 1;
    _r4.i = 0;
    _r0.i = 1;
    _r1.i = 0;
    label4:;
    if (_r1.i >= _r9.i) goto label17;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r1.i];
    if (_r3.i != 0) goto label15;
    _r3.i = _r5.i;
    label11:;
    _r0.i = _r0.i & _r3.i;
    _r1.i = _r1.i + 1;
    goto label4;
    label15:;
    _r3.i = _r4.i;
    goto label11;
    label17:;
    if (_r10.i != 0) goto label24;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r8_o, (int) _r9.i, (global::java.lang.Object) _r6_o, (int) _r4.i, (int) _r7.i);
    _r1.i = _r7.i;
    label23:;
    return _r0.i!=0;
    label24:;
    _r3.i = 32;
    _r2.i = _r3.i - _r10.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r1.i];
    _r3.i = _r3.i << (0x1f & _r2.i);
    if (_r3.i != 0) goto label58;
    _r3.i = _r5.i;
    label34:;
    _r0.i = _r0.i & _r3.i;
    _r1.i = 0;
    label36:;
    _r3.i = _r7.i - _r5.i;
    if (_r1.i >= _r3.i) goto label60;
    _r3.i = _r1.i + _r9.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r3.i];
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & (_r10.i)));
    _r4.i = _r1.i + _r9.i;
    _r4.i = _r4.i + 1;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r4.i];
    _r4.i = _r4.i << (0x1f & _r2.i);
    _r3.i = _r3.i | _r4.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r3.i;
    _r1.i = _r1.i + 1;
    goto label36;
    label58:;
    _r3.i = _r4.i;
    goto label34;
    label60:;
    _r3.i = _r1.i + _r9.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<int>) _r8_o)[_r3.i];
    _r3.i = (int) (((uint) _r3.i) >> (0x1f & (_r10.i)));
    ((global::org.xmlvm._nArrayAdapter<int>) _r6_o)[_r1.i] = _r3.i;
    _r1.i = _r1.i + 1;
    goto label23;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: boolean shiftRight(int[], int, int[], int, int)]
}

public static global::System.Object flipBit(global::com.codename1.util.TBigInteger n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger flipBit(com.codename1.util.TBigInteger, int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r14_o = n1;
    _r15.i = n2;
    _r13.i = -1;
    _r12.i = 1;
    _r11.i = 0;
    _r9.i = ((global::com.codename1.util.TBigInteger) _r14_o)._fsign;
    if (_r9.i != 0) goto label52;
    _r7.i = _r12.i;
    label8:;
    _r4.i = _r15.i >> (0x1f & 5);
    _r0.i = _r15.i & 31;
    _r9.i = _r4.i + 1;
    _r10.i = ((global::com.codename1.util.TBigInteger) _r14_o)._fnumberLength;
    _r9.i = global::java.lang.Math.max((int) _r9.i, (int) _r10.i);
    _r6.i = _r9.i + 1;
    _r5_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r6.i]);
    _r1.i = _r12.i << (0x1f & _r0.i);
    _r9_o = ((global::com.codename1.util.TBigInteger) _r14_o)._fdigits;
    _r10.i = ((global::com.codename1.util.TBigInteger) _r14_o)._fnumberLength;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r9_o, (int) _r11.i, (global::java.lang.Object) _r5_o, (int) _r11.i, (int) _r10.i);
    _r9.i = ((global::com.codename1.util.TBigInteger) _r14_o)._fsign;
    if (_r9.i >= 0) goto label121;
    _r9.i = ((global::com.codename1.util.TBigInteger) _r14_o)._fnumberLength;
    if (_r4.i < _r9.i) goto label56;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i] = _r1.i;
    label43:;
    _r8_o = new global::com.codename1.util.TBigInteger();
    ((global::com.codename1.util.TBigInteger) _r8_o).@this((int) _r7.i, (int) _r6.i, (global::org.xmlvm._nArrayAdapter<int>) _r5_o);
    ((global::com.codename1.util.TBigInteger) _r8_o).cutOffLeadingZeroes();
    return (global::com.codename1.util.TBigInteger) _r8_o;
    label52:;
    _r9.i = ((global::com.codename1.util.TBigInteger) _r14_o)._fsign;
    _r7.i = _r9.i;
    goto label8;
    label56:;
    _r2.i = ((global::com.codename1.util.TBigInteger) _r14_o).getFirstNonzeroDigit();
    if (_r4.i <= _r2.i) goto label68;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i];
    _r9.i = _r9.i ^ _r1.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i] = _r9.i;
    goto label43;
    label68:;
    if (_r4.i >= _r2.i) goto label91;
    _r9.i = -_r1.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i] = _r9.i;
    _r3.i = _r4.i + 1;
    label75:;
    if (_r3.i >= _r2.i) goto label82;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i] = _r13.i;
    _r3.i = _r3.i + 1;
    goto label75;
    label82:;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i];
    _r10.i = _r9.i - _r12.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i] = _r10.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i] = _r9.i;
    goto label43;
    label91:;
    _r3.i = _r4.i;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i];
    _r9.i = -_r9.i;
    _r9.i = _r9.i ^ _r1.i;
    _r9.i = -_r9.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i] = _r9.i;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i];
    if (_r9.i != 0) goto label43;
    _r3.i = _r3.i + 1;
    label105:;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i];
    if (_r9.i != _r13.i) goto label114;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i] = _r11.i;
    _r3.i = _r3.i + 1;
    goto label105;
    label114:;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i];
    _r9.i = _r9.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r3.i] = _r9.i;
    goto label43;
    label121:;
    _r9.i = ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i];
    _r9.i = _r9.i ^ _r1.i;
    ((global::org.xmlvm._nArrayAdapter<int>) _r5_o)[_r4.i] = _r9.i;
    goto label43;
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel: com.codename1.util.TBigInteger flipBit(com.codename1.util.TBigInteger, int)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.util.TBitLevel]
//XMLVM_END_WRAPPER[com.codename1.util.TBitLevel]

} // end of class: TBitLevel

} // end of namespace: com.codename1.util
