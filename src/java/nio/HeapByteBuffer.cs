// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio {
public abstract class HeapByteBuffer: global::java.nio.ByteBuffer {
public global::org.xmlvm._nArrayAdapter<sbyte> _fbackingArray;

public int _foffset;

public void @this(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: void <init>(byte[])]
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
    _r0.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r1.i = 0;
    ((global::java.nio.HeapByteBuffer) _r2_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: void <init>(byte[])]
}

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: void <init>(int)]
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
    _r3.i = n1;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r3.i]);
    _r1.i = 0;
    ((global::java.nio.HeapByteBuffer) _r2_o).@this((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r3.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: void <init>(int)]
}

public void @this(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: void <init>(byte[], int, int)]
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
    _r4.i = n2;
    _r5.i = n3;
    ((global::java.nio.ByteBuffer) _r2_o).@this((int) _r4.i);
    ((global::java.nio.HeapByteBuffer) _r2_o)._fbackingArray = (global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o;
    ((global::java.nio.HeapByteBuffer) _r2_o)._foffset = _r5.i;
    _r0.i = _r5.i + _r4.i;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r0.i <= _r1.i) goto label18;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label18:;
    return;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: void <init>(byte[], int, int)]
}

public override global::System.Object get(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.ByteBuffer get(byte[], int, int)]
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
    _r5_o = this;
    _r6_o = n1;
    _r7.i = n2;
    _r8.i = n3;
    _r0.i = ((global::org.xmlvm._nIArray) _r6_o).Length;
    if (_r7.i < 0) goto label13;
    if (_r8.i < 0) goto label13;
    _r1.l = (long) _r7.i;
    _r3.l = (long) _r8.i;
    _r1.l = _r1.l + _r3.l;
    _r3.l = (long) _r0.i;
    _r0.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r0.i <= 0) goto label19;
    label13:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label19:;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r5_o).remaining();
    if (_r8.i <= _r0.i) goto label31;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label31:;
    _r0_o = ((global::java.nio.HeapByteBuffer) _r5_o)._fbackingArray;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r5_o)._foffset;
    _r2.i = ((global::java.nio.HeapByteBuffer) _r5_o)._fposition;
    _r1.i = _r1.i + _r2.i;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r1.i, (global::java.lang.Object) _r6_o, (int) _r7.i, (int) _r8.i);
    _r0.i = ((global::java.nio.HeapByteBuffer) _r5_o)._fposition;
    _r0.i = _r0.i + _r8.i;
    ((global::java.nio.HeapByteBuffer) _r5_o)._fposition = _r0.i;
    return (global::java.nio.ByteBuffer) _r5_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.ByteBuffer get(byte[], int, int)]
}

public override sbyte get(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: byte get()]
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
    _r0.i = ((global::java.nio.HeapByteBuffer) _r4_o)._fposition;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r4_o)._flimit;
    if (_r0.i != _r1.i) goto label12;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.HeapByteBuffer) _r4_o)._fbackingArray;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r4_o)._foffset;
    _r2.i = ((global::java.nio.HeapByteBuffer) _r4_o)._fposition;
    _r3.i = _r2.i + 1;
    ((global::java.nio.HeapByteBuffer) _r4_o)._fposition = _r3.i;
    _r1.i = _r1.i + _r2.i;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: byte get()]
}

public override sbyte get(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: byte get(int)]
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
    _r3.i = n1;
    if (_r3.i < 0) goto label6;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r2_o)._flimit;
    if (_r3.i < _r0.i) goto label12;
    label6:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.HeapByteBuffer) _r2_o)._fbackingArray;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._foffset;
    _r1.i = _r1.i + _r3.i;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: byte get(int)]
}

public override double getDouble(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: double getDouble()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.l = ((global::java.nio.HeapByteBuffer) _r2_o).getLong();
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    return _r0.d;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: double getDouble()]
}

public override double getDouble(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: double getDouble(int)]
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
    _r3.i = n1;
    _r0.l = ((global::java.nio.HeapByteBuffer) _r2_o).getLong((int) _r3.i);
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    return _r0.d;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: double getDouble(int)]
}

public override float getFloat(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: float getFloat()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r1_o).getInt();
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: float getFloat()]
}

public override float getFloat(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: float getFloat(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r1_o).getInt((int) _r2.i);
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: float getFloat(int)]
}

public override int getInt(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: int getInt()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r2_o)._fposition;
    _r0.i = _r0.i + 4;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._flimit;
    if (_r0.i <= _r1.i) goto label14;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label14:;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._fposition;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o).loadInt((int) _r1.i);
    ((global::java.nio.HeapByteBuffer) _r2_o)._fposition = _r0.i;
    return _r1.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: int getInt()]
}

public override int getInt(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: int getInt(int)]
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
    _r3.i = n1;
    if (_r3.i < 0) goto label8;
    _r0.i = _r3.i + 4;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._flimit;
    if (_r0.i <= _r1.i) goto label14;
    label8:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label14:;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r2_o).loadInt((int) _r3.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: int getInt(int)]
}

public override long getLong(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: long getLong()]
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
    _r0.i = ((global::java.nio.HeapByteBuffer) _r3_o)._fposition;
    _r0.i = _r0.i + 8;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r3_o)._flimit;
    if (_r0.i <= _r1.i) goto label14;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label14:;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r3_o)._fposition;
    _r1.l = ((global::java.nio.HeapByteBuffer) _r3_o).loadLong((int) _r1.i);
    ((global::java.nio.HeapByteBuffer) _r3_o)._fposition = _r0.i;
    return _r1.l;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: long getLong()]
}

public override long getLong(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: long getLong(int)]
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
    _r3.i = n1;
    if (_r3.i < 0) goto label8;
    _r0.i = _r3.i + 8;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._flimit;
    if (_r0.i <= _r1.i) goto label14;
    label8:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label14:;
    _r0.l = ((global::java.nio.HeapByteBuffer) _r2_o).loadLong((int) _r3.i);
    return _r0.l;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: long getLong(int)]
}

public override short getShort(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: short getShort()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r2_o)._fposition;
    _r0.i = _r0.i + 2;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._flimit;
    if (_r0.i <= _r1.i) goto label14;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label14:;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._fposition;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o).loadShort((int) _r1.i);
    ((global::java.nio.HeapByteBuffer) _r2_o)._fposition = _r0.i;
    return (short) _r1.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: short getShort()]
}

public override short getShort(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: short getShort(int)]
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
    _r3.i = n1;
    if (_r3.i < 0) goto label8;
    _r0.i = _r3.i + 2;
    _r1.i = ((global::java.nio.HeapByteBuffer) _r2_o)._flimit;
    if (_r0.i <= _r1.i) goto label14;
    label8:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label14:;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r2_o).loadShort((int) _r3.i);
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: short getShort(int)]
}

public override bool isDirect(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: boolean isDirect()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: boolean isDirect()]
}

public virtual int loadInt(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: int loadInt(int)]
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
    _r5_o = this;
    _r6.i = n1;
    _r3.i = 0;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r5_o)._foffset;
    _r0.i = _r0.i + _r6.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r5_o)._forder;
    _r2_o = global::org.apache.harmony.luni.platform.Endianness._fBIG_1ENDIAN;
    if (_r1_o != _r2_o) goto label31;
    _r1.i = _r3.i;
    _r2.i = _r3.i;
    label12:;
    _r3.i = 4;
    if (_r1.i < _r3.i) goto label17;
    _r0.i = _r2.i;
    label16:;
    return _r0.i;
    label17:;
    _r2.i = _r2.i << (0x1f & 8);
    _r3_o = ((global::java.nio.HeapByteBuffer) _r5_o)._fbackingArray;
    _r4.i = _r0.i + _r1.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o)[_r4.i];
    _r3.i = _r3.i & 255;
    _r2.i = _r2.i | _r3.i;
    _r1.i = _r1.i + 1;
    goto label12;
    label31:;
    _r1.i = 3;
    _r2.i = _r3.i;
    label33:;
    if (_r1.i >= 0) goto label37;
    _r0.i = _r2.i;
    goto label16;
    label37:;
    _r2.i = _r2.i << (0x1f & 8);
    _r3_o = ((global::java.nio.HeapByteBuffer) _r5_o)._fbackingArray;
    _r4.i = _r0.i + _r1.i;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o)[_r4.i];
    _r3.i = _r3.i & 255;
    _r2.i = _r2.i | _r3.i;
    _r1.i = _r1.i + -1;
    goto label33;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: int loadInt(int)]
}

public virtual long loadLong(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: long loadLong(int)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11.i = n1;
    _r6.i = 8;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r10_o)._foffset;
    _r0.i = _r0.i + _r11.i;
    _r1.l = 0L;
    _r3_o = ((global::java.nio.HeapByteBuffer) _r10_o)._forder;
    _r4_o = global::org.apache.harmony.luni.platform.Endianness._fBIG_1ENDIAN;
    if (_r3_o != _r4_o) goto label36;
    _r3.i = 0;
    _r7.i = _r3.i;
    _r8.l = _r1.l;
    _r2.l = _r8.l;
    _r1.i = _r7.i;
    label18:;
    if (_r1.i < _r6.i) goto label22;
    _r0.l = _r2.l;
    label21:;
    return _r0.l;
    label22:;
    _r2.l = _r2.l << (0x3f & _r6.i);
    _r4_o = ((global::java.nio.HeapByteBuffer) _r10_o)._fbackingArray;
    _r5.i = _r0.i + _r1.i;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o)[_r5.i];
    _r4.i = _r4.i & 255;
    _r4.l = (long) _r4.i;
    _r2.l = _r2.l | _r4.l;
    _r1.i = _r1.i + 1;
    goto label18;
    label36:;
    _r3.i = 7;
    _r7.i = _r3.i;
    _r8.l = _r1.l;
    _r2.l = _r8.l;
    _r1.i = _r7.i;
    label41:;
    if (_r1.i >= 0) goto label45;
    _r0.l = _r2.l;
    goto label21;
    label45:;
    _r2.l = _r2.l << (0x3f & _r6.i);
    _r4_o = ((global::java.nio.HeapByteBuffer) _r10_o)._fbackingArray;
    _r5.i = _r0.i + _r1.i;
    _r4.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o)[_r5.i];
    _r4.i = _r4.i & 255;
    _r4.l = (long) _r4.i;
    _r2.l = _r2.l | _r4.l;
    _r1.i = _r1.i + -1;
    goto label41;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: long loadLong(int)]
}

public virtual short loadShort(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: short loadShort(int)]
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
    _r0.i = ((global::java.nio.HeapByteBuffer) _r3_o)._foffset;
    _r0.i = _r0.i + _r4.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r3_o)._forder;
    _r2_o = global::org.apache.harmony.luni.platform.Endianness._fBIG_1ENDIAN;
    if (_r1_o != _r2_o) goto label27;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r3_o)._fbackingArray;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r0.i];
    _r1.i = _r1.i << (0x1f & 8);
    _r1.i = (_r1.i << 16) >> 16;
    _r2_o = ((global::java.nio.HeapByteBuffer) _r3_o)._fbackingArray;
    _r0.i = _r0.i + 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r0.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i | _r1.i;
    _r0.i = (_r0.i << 16) >> 16;
    label26:;
    return (short) _r0.i;
    label27:;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r3_o)._fbackingArray;
    _r2.i = _r0.i + 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i << (0x1f & 8);
    _r1.i = (_r1.i << 16) >> 16;
    _r2_o = ((global::java.nio.HeapByteBuffer) _r3_o)._fbackingArray;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r0.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i | _r1.i;
    _r0.i = (_r0.i << 16) >> 16;
    goto label26;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: short loadShort(int)]
}

public virtual void store(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: void store(int, int)]
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
    _r7_o = this;
    _r8.i = n1;
    _r9.i = n2;
    _r6.i = 3;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r7_o)._foffset;
    _r0.i = _r0.i + _r8.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r7_o)._forder;
    _r2_o = global::org.apache.harmony.luni.platform.Endianness._fBIG_1ENDIAN;
    if (_r1_o != _r2_o) goto label29;
    _r1.i = _r6.i;
    _r2.i = _r9.i;
    label12:;
    if (_r1.i >= 0) goto label15;
    label14:;
    return;
    label15:;
    _r3_o = ((global::java.nio.HeapByteBuffer) _r7_o)._fbackingArray;
    _r4.i = _r0.i + _r1.i;
    _r5.i = _r2.i & 255;
    _r5.i = (_r5.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o)[_r4.i] = (sbyte)_r5.i;
    _r2.i = _r2.i >> (0x1f & 8);
    _r1.i = _r1.i + -1;
    goto label12;
    label29:;
    _r1.i = 0;
    _r2.i = _r9.i;
    label31:;
    if (_r1.i > _r6.i) goto label14;
    _r3_o = ((global::java.nio.HeapByteBuffer) _r7_o)._fbackingArray;
    _r4.i = _r0.i + _r1.i;
    _r5.i = _r2.i & 255;
    _r5.i = (_r5.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o)[_r4.i] = (sbyte)_r5.i;
    _r2.i = _r2.i >> (0x1f & 8);
    _r1.i = _r1.i + 1;
    goto label31;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: void store(int, int)]
}

public virtual void store(int n1, long n2){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: void store(int, long)]
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
    _r12_o = this;
    _r13.i = n1;
    _r14.l = n2;
    _r10.l = 255L;
    _r9.i = 8;
    _r8.i = 7;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r12_o)._foffset;
    _r0.i = _r0.i + _r13.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r12_o)._forder;
    _r2_o = global::org.apache.harmony.luni.platform.Endianness._fBIG_1ENDIAN;
    if (_r1_o != _r2_o) goto label33;
    _r1.i = _r8.i;
    _r2.l = _r14.l;
    label16:;
    if (_r1.i >= 0) goto label19;
    label18:;
    return;
    label19:;
    _r4_o = ((global::java.nio.HeapByteBuffer) _r12_o)._fbackingArray;
    _r5.i = _r0.i + _r1.i;
    _r6.l = _r2.l & _r10.l;
    _r6.i = (int) _r6.l;
    _r6.i = (_r6.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o)[_r5.i] = (sbyte)_r6.i;
    _r2.l = _r2.l >> (0x3f & _r9.i);
    _r1.i = _r1.i + -1;
    goto label16;
    label33:;
    _r1.i = 0;
    _r2.l = _r14.l;
    label35:;
    if (_r1.i > _r8.i) goto label18;
    _r4_o = ((global::java.nio.HeapByteBuffer) _r12_o)._fbackingArray;
    _r5.i = _r0.i + _r1.i;
    _r6.l = _r2.l & _r10.l;
    _r6.i = (int) _r6.l;
    _r6.i = (_r6.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o)[_r5.i] = (sbyte)_r6.i;
    _r2.l = _r2.l >> (0x3f & _r9.i);
    _r1.i = _r1.i + 1;
    goto label35;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: void store(int, long)]
}

public virtual void store(int n1, short n2){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: void store(int, short)]
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
    _r4_o = this;
    _r5.i = n1;
    _r6.i = n2;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r4_o)._foffset;
    _r0.i = _r0.i + _r5.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r4_o)._forder;
    _r2_o = global::org.apache.harmony.luni.platform.Endianness._fBIG_1ENDIAN;
    if (_r1_o != _r2_o) goto label28;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r4_o)._fbackingArray;
    _r2.i = _r6.i >> (0x1f & 8);
    _r2.i = _r2.i & 255;
    _r2.i = (_r2.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r0.i] = (sbyte)_r2.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r4_o)._fbackingArray;
    _r0.i = _r0.i + 1;
    _r2.i = _r6.i & 255;
    _r2.i = (_r2.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r0.i] = (sbyte)_r2.i;
    label27:;
    return;
    label28:;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r4_o)._fbackingArray;
    _r2.i = _r0.i + 1;
    _r3.i = _r6.i >> (0x1f & 8);
    _r3.i = _r3.i & 255;
    _r3.i = (_r3.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i] = (sbyte)_r3.i;
    _r1_o = ((global::java.nio.HeapByteBuffer) _r4_o)._fbackingArray;
    _r2.i = _r6.i & 255;
    _r2.i = (_r2.i << 24) >> 24;
    ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r0.i] = (sbyte)_r2.i;
    goto label27;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: void store(int, short)]
}

public override global::System.Object asCharBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.CharBuffer asCharBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::java.nio.CharToByteBufferAdapter.wrap((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.CharBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.CharBuffer asCharBuffer()]
}

public override global::System.Object asDoubleBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.DoubleBuffer asDoubleBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::java.nio.DoubleToByteBufferAdapter.wrap((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.DoubleBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.DoubleBuffer asDoubleBuffer()]
}

public override global::System.Object asFloatBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.FloatBuffer asFloatBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::java.nio.FloatToByteBufferAdapter.wrap((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.FloatBuffer asFloatBuffer()]
}

public override global::System.Object asIntBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.IntBuffer asIntBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::java.nio.IntToByteBufferAdapter.wrap((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.IntBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.IntBuffer asIntBuffer()]
}

public override global::System.Object asLongBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.LongBuffer asLongBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::java.nio.LongToByteBufferAdapter.wrap((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.LongBuffer asLongBuffer()]
}

public override global::System.Object asShortBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.ShortBuffer asShortBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = global::java.nio.ShortToByteBufferAdapter.wrap((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.ShortBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.ShortBuffer asShortBuffer()]
}

public override char getChar(){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: char getChar()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r1_o).getShort();
    _r0.i = _r0.i & 0xffff;
    return (char) _r0.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: char getChar()]
}

public override char getChar(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: char getChar(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = ((global::java.nio.HeapByteBuffer) _r1_o).getShort((int) _r2.i);
    _r0.i = _r0.i & 0xffff;
    return (char) _r0.i;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: char getChar(int)]
}

public override global::System.Object putChar(char n1){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.ByteBuffer putChar(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0.i = (_r2.i << 16) >> 16;
    _r0_o = ((global::java.nio.HeapByteBuffer) _r1_o).putShort((short) _r0.i);
    return (global::java.nio.ByteBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.ByteBuffer putChar(char)]
}

public override global::System.Object putChar(int n1, char n2){
//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer: java.nio.ByteBuffer putChar(int, char)]
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
    _r2.i = n1;
    _r3.i = n2;
    _r0.i = (_r3.i << 16) >> 16;
    _r0_o = ((global::java.nio.HeapByteBuffer) _r1_o).putShort((int) _r2.i, (short) _r0.i);
    return (global::java.nio.ByteBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer: java.nio.ByteBuffer putChar(int, char)]
}

//XMLVM_BEGIN_WRAPPER[java.nio.HeapByteBuffer]
//XMLVM_END_WRAPPER[java.nio.HeapByteBuffer]

} // end of class: HeapByteBuffer

} // end of namespace: java.nio
