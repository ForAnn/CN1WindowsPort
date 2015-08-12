// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io.gzip {
public class CRC32: global::java.lang.Object,global::com.codename1.io.gzip.Checksum {

static CRC32() {
    @static();
}

private int _fv;

private static global::org.xmlvm._nArrayAdapter<int> _fcrc_1table;

private static int _fGF2_1DIM = 32;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = 0;
    ((global::com.codename1.io.gzip.CRC32) _r1_o)._fv = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: void <init>()]
}

public virtual void update(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: void update(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    _r4_o = this;
    _r5_o = n1;
    _r6.i = n2;
    _r7.i = n3;
    _r2.i = ((global::com.codename1.io.gzip.CRC32) _r4_o)._fv;
    _r0.i = _r2.i ^ -1;
    _r1.i = _r6.i;
    label5:;
    _r7.i = _r7.i + -1;
    if (_r7.i < 0) goto label26;
    _r2_o = global::com.codename1.io.gzip.CRC32._fcrc_1table;
    _r6.i = _r1.i + 1;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r5_o)[_r1.i];
    _r3.i = _r3.i ^ _r0.i;
    _r3.i = _r3.i & 255;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r3.i];
    _r3.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 8)));
    _r0.i = _r2.i ^ _r3.i;
    _r1.i = _r6.i;
    goto label5;
    label26:;
    _r2.i = _r0.i ^ -1;
    ((global::com.codename1.io.gzip.CRC32) _r4_o)._fv = _r2.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: void update(byte[], int, int)]
}

public virtual void reset(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: void reset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    ((global::com.codename1.io.gzip.CRC32) _r1_o)._fv = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: void reset()]
}

public virtual void reset(long n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: void reset(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r2_o = this;
    _r3.l = n1;
    _r0.l = 4294967295L;
    _r0.l = _r0.l & _r3.l;
    _r0.i = (int) _r0.l;
    ((global::com.codename1.io.gzip.CRC32) _r2_o)._fv = _r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: void reset(long)]
}

public virtual long getValue(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: long getValue()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.i = ((global::com.codename1.io.gzip.CRC32) _r4_o)._fv;
    _r0.l = (long) _r0.i;
    _r2.l = 4294967295L;
    _r0.l = _r0.l & _r2.l;
    return _r0.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: long getValue()]
}

public static long combine(long n1, long n2, long n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: long combine(long, long, long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r9;
    global::org.xmlvm._nElement _r11;
    _r7.l = n1;
    _r9.l = n2;
    _r11.l = n3;
    _r0.i = 32;
    _r0_o = new global::org.xmlvm._nArrayAdapter<long>(new long[_r0.i]);
    _r1.i = 32;
    _r2_o = new global::org.xmlvm._nArrayAdapter<long>(new long[_r1.i]);
    _r3.l = 0L;
    _r1.i = _r11.l > _r3.l ? 1 : (_r11.l == _r3.l ? 0 : -1);
    if (_r1.i > 0) goto label15;
    label14:;
    return _r7.l;
    label15:;
    _r1.i = 0;
    _r3.l = 3988292384L;
    ((global::org.xmlvm._nArrayAdapter<long>) _r2_o)[_r1.i] = _r3.l;
    _r3.l = 1L;
    _r1.i = 1;
    label26:;
    _r5.i = 32;
    if (_r1.i >= _r5.i) goto label37;
    ((global::org.xmlvm._nArrayAdapter<long>) _r2_o)[_r1.i] = _r3.l;
    _r5.i = 1;
    _r3.l = _r3.l << (0x3f & _r5.i);
    _r1.i = _r1.i + 1;
    goto label26;
    label37:;
    global::com.codename1.io.gzip.CRC32.gf2_1matrix_1square((global::org.xmlvm._nArrayAdapter<long>) _r0_o, (global::org.xmlvm._nArrayAdapter<long>) _r2_o);
    global::com.codename1.io.gzip.CRC32.gf2_1matrix_1square((global::org.xmlvm._nArrayAdapter<long>) _r2_o, (global::org.xmlvm._nArrayAdapter<long>) _r0_o);
    label43:;
    global::com.codename1.io.gzip.CRC32.gf2_1matrix_1square((global::org.xmlvm._nArrayAdapter<long>) _r0_o, (global::org.xmlvm._nArrayAdapter<long>) _r2_o);
    _r3.l = 1L;
    _r3.l = _r3.l & _r11.l;
    _r5.l = 0L;
    _r1.i = _r3.l > _r5.l ? 1 : (_r3.l == _r5.l ? 0 : -1);
    if (_r1.i == 0) goto label59;
    _r7.l = global::com.codename1.io.gzip.CRC32.gf2_1matrix_1times((global::org.xmlvm._nArrayAdapter<long>) _r0_o, (long) _r7.l);
    label59:;
    _r1.i = 1;
    _r11.l = _r11.l >> (0x3f & _r1.i);
    _r3.l = 0L;
    _r1.i = _r11.l > _r3.l ? 1 : (_r11.l == _r3.l ? 0 : -1);
    if (_r1.i != 0) goto label69;
    label67:;
    _r7.l = _r7.l ^ _r9.l;
    goto label14;
    label69:;
    global::com.codename1.io.gzip.CRC32.gf2_1matrix_1square((global::org.xmlvm._nArrayAdapter<long>) _r2_o, (global::org.xmlvm._nArrayAdapter<long>) _r0_o);
    _r3.l = 1L;
    _r3.l = _r3.l & _r11.l;
    _r5.l = 0L;
    _r1.i = _r3.l > _r5.l ? 1 : (_r3.l == _r5.l ? 0 : -1);
    if (_r1.i == 0) goto label85;
    _r7.l = global::com.codename1.io.gzip.CRC32.gf2_1matrix_1times((global::org.xmlvm._nArrayAdapter<long>) _r2_o, (long) _r7.l);
    label85:;
    _r1.i = 1;
    _r11.l = _r11.l >> (0x3f & _r1.i);
    _r3.l = 0L;
    _r1.i = _r11.l > _r3.l ? 1 : (_r11.l == _r3.l ? 0 : -1);
    if (_r1.i != 0) goto label43;
    goto label67;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: long combine(long, long, long)]
}

private static long gf2_1matrix_1times(global::org.xmlvm._nArrayAdapter<long> n1, long n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: long gf2_matrix_times(long[], long)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    _r7_o = n1;
    _r8.l = n2;
    _r5.l = 0L;
    _r1.l = 0L;
    _r0.i = 0;
    label5:;
    _r3.i = _r8.l > _r5.l ? 1 : (_r8.l == _r5.l ? 0 : -1);
    if (_r3.i == 0) goto label24;
    _r3.l = 1L;
    _r3.l = _r3.l & _r8.l;
    _r3.i = _r3.l > _r5.l ? 1 : (_r3.l == _r5.l ? 0 : -1);
    if (_r3.i == 0) goto label19;
    _r3.l = ((global::org.xmlvm._nArrayAdapter<long>) _r7_o)[_r0.i];
    _r1.l = _r1.l ^ _r3.l;
    label19:;
    _r3.i = 1;
    _r8.l = _r8.l >> (0x3f & _r3.i);
    _r0.i = _r0.i + 1;
    goto label5;
    label24:;
    return _r1.l;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: long gf2_matrix_times(long[], long)]
}

public static void gf2_1matrix_1square(global::org.xmlvm._nArrayAdapter<long> n1, global::org.xmlvm._nArrayAdapter<long> n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: void gf2_matrix_square(long[], long[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = n1;
    _r4_o = n2;
    _r0.i = 0;
    label1:;
    _r1.i = 32;
    if (_r0.i >= _r1.i) goto label16;
    _r1.l = ((global::org.xmlvm._nArrayAdapter<long>) _r4_o)[_r0.i];
    _r1.l = global::com.codename1.io.gzip.CRC32.gf2_1matrix_1times((global::org.xmlvm._nArrayAdapter<long>) _r4_o, (long) _r1.l);
    ((global::org.xmlvm._nArrayAdapter<long>) _r3_o)[_r0.i] = _r1.l;
    _r0.i = _r0.i + 1;
    goto label1;
    label16:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: void gf2_matrix_square(long[], long[])]
}

public virtual global::System.Object copy(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: com.codename1.io.gzip.CRC32 copy()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::com.codename1.io.gzip.CRC32();
    ((global::com.codename1.io.gzip.CRC32) _r0_o).@this();
    _r1.i = ((global::com.codename1.io.gzip.CRC32) _r2_o)._fv;
    ((global::com.codename1.io.gzip.CRC32) _r0_o)._fv = _r1.i;
    return (global::com.codename1.io.gzip.CRC32) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: com.codename1.io.gzip.CRC32 copy()]
}

public static global::System.Object getCRC32Table(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: int[] getCRC32Table()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r3.i = 0;
    _r1_o = global::com.codename1.io.gzip.CRC32._fcrc_1table;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r1.i]);
    _r1_o = global::com.codename1.io.gzip.CRC32._fcrc_1table;
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r3.i, (global::java.lang.Object) _r0_o, (int) _r3.i, (int) _r2.i);
    return (global::org.xmlvm._nArrayAdapter<int>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: int[] getCRC32Table()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    _r5.i = 256;
    _r3_o = null;
    global::com.codename1.io.gzip.CRC32._fcrc_1table = (global::org.xmlvm._nArrayAdapter<int>) _r3_o;
    _r3_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r5.i]);
    global::com.codename1.io.gzip.CRC32._fcrc_1table = (global::org.xmlvm._nArrayAdapter<int>) _r3_o;
    _r2.i = 0;
    label10:;
    if (_r2.i >= _r5.i) goto label41;
    _r0.i = _r2.i;
    _r1.i = 8;
    label15:;
    _r1.i = _r1.i + -1;
    if (_r1.i < 0) goto label34;
    _r3.i = _r0.i & 1;
    if (_r3.i == 0) goto label31;
    _r3.i = -306674912;
    _r4.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 1)));
    _r0.i = _r3.i ^ _r4.i;
    goto label15;
    label31:;
    _r0.i = (int) (((uint) _r0.i) >> (0x1f & ((int) 1)));
    goto label15;
    label34:;
    _r3_o = global::com.codename1.io.gzip.CRC32._fcrc_1table;
    ((global::org.xmlvm._nArrayAdapter<int>) _r3_o)[_r2.i] = _r0.i;
    _r2.i = _r2.i + 1;
    goto label10;
    label41:;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.gzip.CRC32]
//XMLVM_END_WRAPPER[com.codename1.io.gzip.CRC32]

} // end of class: CRC32

} // end of namespace: com.codename1.io.gzip
