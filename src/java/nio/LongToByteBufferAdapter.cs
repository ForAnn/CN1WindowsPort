// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio {
public class LongToByteBufferAdapter: global::java.nio.LongBuffer,global::org.apache.harmony.nio.@internal.DirectBuffer {

static LongToByteBufferAdapter() {
    @static();
}

private global::java.nio.ByteBuffer _fbyteBuffer;

public static bool _f_2assertionsDisabled;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.nio.LongToByteBufferAdapter));
    _r0.i = ((global::java.lang.Class) _r0_o).desiredAssertionStatus() ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0.i = 1;
    label9:;
    global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled = 0!=_r0.i;
    return;
    label12:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: void <clinit>()]
}

public static global::System.Object wrap(global::java.nio.ByteBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer wrap(java.nio.ByteBuffer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    _r0_o = new global::java.nio.LongToByteBufferAdapter();
    _r1_o = ((global::java.nio.ByteBuffer) _r2_o).slice();
    ((global::java.nio.LongToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer wrap(java.nio.ByteBuffer)]
}

public void @this(global::java.nio.ByteBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: void <init>(java.nio.ByteBuffer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = ((global::java.nio.ByteBuffer) _r2_o).capacity();
    _r0.i = _r0.i >> (0x1f & 3);
    ((global::java.nio.LongBuffer) _r1_o).@this((int) _r0.i);
    ((global::java.nio.LongToByteBufferAdapter) _r1_o)._fbyteBuffer = (global::java.nio.ByteBuffer) _r2_o;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r1_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: void <init>(java.nio.ByteBuffer)]
}

public virtual int getByteCapacity(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: int getByteCapacity()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r2_o = _r2_o;
    _r0.i = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).getByteCapacity();
    label14:;
    return _r0.i;
    label15:;
    _r0.i = global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0.i = -1;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: int getByteCapacity()]
}

public virtual global::System.Object getEffectiveAddress(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.lang.Object getEffectiveAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r2_o = _r2_o;
    _r0_o = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).getEffectiveAddress();
    label14:;
    return (global::java.lang.Object) _r0_o;
    label15:;
    _r0.i = global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.lang.Object getEffectiveAddress()]
}

public virtual global::System.Object getBaseAddress(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.lang.Object getBaseAddress()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r2_o = _r2_o;
    _r0_o = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).getBaseAddress();
    label14:;
    return (global::java.lang.Object) _r0_o;
    label15:;
    _r0.i = global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0_o = null;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.lang.Object getBaseAddress()]
}

public virtual bool isAddressValid(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: boolean isAddressValid()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r2_o = _r2_o;
    _r0.i = ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).isAddressValid() ? 1 : 0;
    label14:;
    return _r0.i!=0;
    label15:;
    _r0.i = global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label27;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    label27:;
    _r0.i = 0;
    goto label14;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: boolean isAddressValid()]
}

public virtual void addressValidityCheck(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: void addressValidityCheck()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r2_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r2_o = _r2_o;
    ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).addressValidityCheck();
    label13:;
    return;
    label14:;
    _r0.i = global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: void addressValidityCheck()]
}

public virtual void free(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: void free()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((_r0_o != null) && (_r0_o is global::org.apache.harmony.nio.@internal.DirectBuffer)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r2_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r2_o = _r2_o;
    ((global::org.apache.harmony.nio.@internal.DirectBuffer) _r2_o).free();
    label13:;
    return;
    label14:;
    _r0.i = global::java.nio.LongToByteBufferAdapter._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label13;
    _r0_o = new global::java.lang.AssertionError();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: void free()]
}

public override global::System.Object asReadOnlyBuffer(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer asReadOnlyBuffer()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.nio.LongToByteBufferAdapter();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1_o = ((global::java.nio.ByteBuffer) _r1_o).asReadOnlyBuffer();
    ((global::java.nio.LongToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    ((global::java.nio.LongToByteBufferAdapter) _r0_o)._flimit = _r1.i;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fposition;
    ((global::java.nio.LongToByteBufferAdapter) _r0_o)._fposition = _r1.i;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fmark;
    ((global::java.nio.LongToByteBufferAdapter) _r0_o)._fmark = _r1.i;
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer asReadOnlyBuffer()]
}

public override global::System.Object compact(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer compact()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r0.i = ((global::java.nio.ByteBuffer) _r0_o).isReadOnly() ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0_o = new global::java.nio.ReadOnlyBufferException();
    ((global::java.nio.ReadOnlyBufferException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.ReadOnlyBufferException) _r0_o);
    label14:;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    _r1.i = _r1.i << (0x1f & 3);
    ((global::java.nio.ByteBuffer) _r0_o).limit((int) _r1.i);
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fposition;
    _r1.i = _r1.i << (0x1f & 3);
    ((global::java.nio.ByteBuffer) _r0_o).position((int) _r1.i);
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r0_o).compact();
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r0_o).clear();
    _r0.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fposition;
    _r0.i = _r0.i - _r1.i;
    ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fposition = _r0.i;
    _r0.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fcapacity;
    ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit = _r0.i;
    _r0.i = -1;
    ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fmark = _r0.i;
    return (global::java.nio.LongBuffer) _r2_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer compact()]
}

public override global::System.Object duplicate(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer duplicate()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.nio.LongToByteBufferAdapter();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1_o = ((global::java.nio.ByteBuffer) _r1_o).duplicate();
    ((global::java.nio.LongToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    ((global::java.nio.LongToByteBufferAdapter) _r0_o)._flimit = _r1.i;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fposition;
    ((global::java.nio.LongToByteBufferAdapter) _r0_o)._fposition = _r1.i;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fmark;
    ((global::java.nio.LongToByteBufferAdapter) _r0_o)._fmark = _r1.i;
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer duplicate()]
}

public override long get(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: long get()]
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
    _r0.i = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fposition;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._flimit;
    if (_r0.i != _r1.i) goto label12;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fposition;
    _r2.i = _r1.i + 1;
    ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fposition = _r2.i;
    _r1.i = _r1.i << (0x1f & 3);
    _r0.l = ((global::java.nio.ByteBuffer) _r0_o).getLong((int) _r1.i);
    return _r0.l;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: long get()]
}

public override long get(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: long get(int)]
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
    _r0.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    if (_r3.i < _r0.i) goto label12;
    label6:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = _r3.i << (0x1f & 3);
    _r0.l = ((global::java.nio.ByteBuffer) _r0_o).getLong((int) _r1.i);
    return _r0.l;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: long get(int)]
}

public override bool isDirect(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: boolean isDirect()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r1_o)._fbyteBuffer;
    _r0.i = ((global::java.nio.ByteBuffer) _r0_o).isDirect() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: boolean isDirect()]
}

public override bool isReadOnly(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: boolean isReadOnly()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r1_o)._fbyteBuffer;
    _r0.i = ((global::java.nio.ByteBuffer) _r0_o).isReadOnly() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: boolean isReadOnly()]
}

public override global::System.Object order(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.ByteOrder order()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r1_o)._fbyteBuffer;
    _r0_o = ((global::java.nio.ByteBuffer) _r0_o).order();
    return (global::java.nio.ByteOrder) _r0_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.ByteOrder order()]
}

public override global::System.Object protectedArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: long[] protectedArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: long[] protectedArray()]
}

public override int protectedArrayOffset(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: int protectedArrayOffset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: int protectedArrayOffset()]
}

public override bool protectedHasArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: boolean protectedHasArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: boolean protectedHasArray()]
}

public override global::System.Object put(long n1){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer put(long)]
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
    _r4.l = n1;
    _r0.i = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fposition;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._flimit;
    if (_r0.i != _r1.i) goto label12;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fposition;
    _r2.i = _r1.i + 1;
    ((global::java.nio.LongToByteBufferAdapter) _r3_o)._fposition = _r2.i;
    _r1.i = _r1.i << (0x1f & 3);
    ((global::java.nio.ByteBuffer) _r0_o).putLong((int) _r1.i, (long) _r4.l);
    return (global::java.nio.LongBuffer) _r3_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer put(long)]
}

public override global::System.Object put(int n1, long n2){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer put(int, long)]
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
    _r3.i = n1;
    _r4.l = n2;
    if (_r3.i < 0) goto label6;
    _r0.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    if (_r3.i < _r0.i) goto label12;
    label6:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label12:;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = _r3.i << (0x1f & 3);
    ((global::java.nio.ByteBuffer) _r0_o).putLong((int) _r1.i, (long) _r4.l);
    return (global::java.nio.LongBuffer) _r2_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer put(int, long)]
}

public override global::System.Object slice(){
//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer slice()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._flimit;
    _r1.i = _r1.i << (0x1f & 3);
    ((global::java.nio.ByteBuffer) _r0_o).limit((int) _r1.i);
    _r0_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1.i = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fposition;
    _r1.i = _r1.i << (0x1f & 3);
    ((global::java.nio.ByteBuffer) _r0_o).position((int) _r1.i);
    _r0_o = new global::java.nio.LongToByteBufferAdapter();
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    _r1_o = ((global::java.nio.ByteBuffer) _r1_o).slice();
    ((global::java.nio.LongToByteBufferAdapter) _r0_o).@this((global::java.nio.ByteBuffer) _r1_o);
    _r1_o = ((global::java.nio.LongToByteBufferAdapter) _r2_o)._fbyteBuffer;
    ((global::java.nio.ByteBuffer) _r1_o).clear();
    return (global::java.nio.LongBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter: java.nio.LongBuffer slice()]
}

//XMLVM_BEGIN_WRAPPER[java.nio.LongToByteBufferAdapter]
//XMLVM_END_WRAPPER[java.nio.LongToByteBufferAdapter]

} // end of class: LongToByteBufferAdapter

} // end of namespace: java.nio
