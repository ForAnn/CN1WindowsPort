// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.nio {
public abstract class FloatBuffer: global::java.nio.Buffer,global::java.lang.Comparable {
public static global::System.Object allocate(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer allocate(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = n1;
    if (_r1.i >= 0) goto label8;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label8:;
    _r0_o = global::java.nio.BufferFactory.newFloatBuffer((int) _r1.i);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer allocate(int)]
}

public static global::System.Object wrap(global::org.xmlvm._nArrayAdapter<float> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer wrap(float[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    _r0_o = global::java.nio.FloatBuffer.wrap((global::org.xmlvm._nArrayAdapter<float>) _r2_o, (int) _r0.i, (int) _r1.i);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer wrap(float[])]
}

public static global::System.Object wrap(global::org.xmlvm._nArrayAdapter<float> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer wrap(float[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    if (_r4_o != null) goto label8;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label8:;
    if (_r5.i < 0) goto label21;
    if (_r6.i < 0) goto label21;
    _r0.l = (long) _r5.i;
    _r2.l = (long) _r6.i;
    _r0.l = _r0.l + _r2.l;
    _r2.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r2.l = (long) _r2.i;
    _r0.i = _r0.l > _r2.l ? 1 : (_r0.l == _r2.l ? 0 : -1);
    if (_r0.i <= 0) goto label27;
    label21:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label27:;
    _r0_o = global::java.nio.BufferFactory.newFloatBuffer((global::org.xmlvm._nArrayAdapter<float>) _r4_o);
    ((global::java.nio.FloatBuffer) _r0_o)._fposition = _r5.i;
    _r1.i = _r5.i + _r6.i;
    ((global::java.nio.FloatBuffer) _r0_o)._flimit = _r1.i;
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer wrap(float[], int, int)]
}

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: void <init>(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.nio.Buffer) _r0_o).@this((int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: void <init>(int)]
}

public override global::System.Object array(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: float[] array()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.nio.FloatBuffer) _r1_o).protectedArray();
    return (global::org.xmlvm._nArrayAdapter<float>) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: float[] array()]
}

public override int arrayOffset(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: int arrayOffset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.FloatBuffer) _r1_o).protectedArrayOffset();
    return _r0.i;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: int arrayOffset()]
}

public abstract global::System.Object asReadOnlyBuffer();

public abstract global::System.Object compact();

public virtual int compareTo(global::java.nio.FloatBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: int compareTo(java.nio.FloatBuffer)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r0.i = ((global::java.nio.FloatBuffer) _r7_o).remaining();
    _r1.i = ((global::java.nio.FloatBuffer) _r8_o).remaining();
    if (_r0.i >= _r1.i) goto label33;
    _r0.i = ((global::java.nio.FloatBuffer) _r7_o).remaining();
    label14:;
    _r1.i = ((global::java.nio.FloatBuffer) _r7_o)._fposition;
    _r2.i = ((global::java.nio.FloatBuffer) _r8_o)._fposition;
    _r6.i = _r2.i;
    _r2.i = _r0.i;
    _r0.i = _r6.i;
    label21:;
    if (_r2.i > 0) goto label38;
    _r0.i = ((global::java.nio.FloatBuffer) _r7_o).remaining();
    _r1.i = ((global::java.nio.FloatBuffer) _r8_o).remaining();
    _r0.i = _r0.i - _r1.i;
    label32:;
    return _r0.i;
    label33:;
    _r0.i = ((global::java.nio.FloatBuffer) _r8_o).remaining();
    goto label14;
    label38:;
    _r3.f = ((global::java.nio.FloatBuffer) _r7_o).get((int) _r1.i);
    _r4.f = ((global::java.nio.FloatBuffer) _r8_o).get((int) _r0.i);
    _r5.i = _r3.f > _r4.f ? 1 : (_r3.f == _r4.f ? 0 : -1);
    if (_r5.i == 0) goto label66;
    _r5.i = _r3.f > _r3.f ? 1 : (_r3.f == _r3.f ? 0 : -1);
    if (_r5.i == 0) goto label58;
    _r5.i = _r4.f > _r4.f ? 1 : (_r4.f == _r4.f ? 0 : -1);
    if (_r5.i != 0) goto label66;
    label58:;
    _r0.i = _r3.f > _r4.f ? 1 : (_r3.f == _r4.f ? 0 : -1);
    if (_r0.i >= 0) goto label64;
    _r0.i = -1;
    goto label32;
    label64:;
    _r0.i = 1;
    goto label32;
    label66:;
    _r1.i = _r1.i + 1;
    _r0.i = _r0.i + 1;
    _r2.i = _r2.i + -1;
    goto label21;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: int compareTo(java.nio.FloatBuffer)]
}

public abstract global::System.Object duplicate();

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    _r7_o = this;
    _r8_o = n1;
    _r6.i = 1;
    _r5.i = 0;
    _r0.i = ((_r8_o != null) && (_r8_o is global::java.nio.FloatBuffer)) ? 1 : 0;
    if (_r0.i != 0) goto label8;
    _r0.i = _r5.i;
    label7:;
    return _r0.i!=0;
    label8:;
    _r8_o = _r8_o;
    _r0.i = ((global::java.nio.FloatBuffer) _r7_o).remaining();
    _r1.i = ((global::java.nio.FloatBuffer) _r8_o).remaining();
    if (_r0.i == _r1.i) goto label22;
    _r0.i = _r5.i;
    goto label7;
    label22:;
    _r0.i = ((global::java.nio.FloatBuffer) _r7_o)._fposition;
    _r1.i = ((global::java.nio.FloatBuffer) _r8_o)._fposition;
    _r2.i = _r0.i;
    _r0.i = _r6.i;
    label28:;
    if (_r0.i == 0) goto label7;
    _r3.i = ((global::java.nio.FloatBuffer) _r7_o)._flimit;
    if (_r2.i >= _r3.i) goto label7;
    _r0.i = _r2.i + 1;
    _r2.f = ((global::java.nio.FloatBuffer) _r7_o).get((int) _r2.i);
    _r3.i = _r1.i + 1;
    _r1.f = ((global::java.nio.FloatBuffer) _r8_o).get((int) _r1.i);
    _r4.i = _r2.f > _r1.f ? 1 : (_r2.f == _r1.f ? 0 : -1);
    if (_r4.i == 0) goto label63;
    _r2.i = _r2.f > _r2.f ? 1 : (_r2.f == _r2.f ? 0 : -1);
    if (_r2.i == 0) goto label58;
    _r1.i = _r1.f > _r1.f ? 1 : (_r1.f == _r1.f ? 0 : -1);
    if (_r1.i != 0) goto label63;
    label58:;
    _r1.i = _r5.i;
    label59:;
    _r2.i = _r0.i;
    _r0.i = _r1.i;
    _r1.i = _r3.i;
    goto label28;
    label63:;
    _r1.i = _r6.i;
    goto label59;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: boolean equals(java.lang.Object)]
}

public abstract float get();

public virtual global::System.Object get(global::org.xmlvm._nArrayAdapter<float> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer get(float[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0_o = ((global::java.nio.FloatBuffer) _r2_o).get((global::org.xmlvm._nArrayAdapter<float>) _r3_o, (int) _r0.i, (int) _r1.i);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer get(float[])]
}

public virtual global::System.Object get(global::org.xmlvm._nArrayAdapter<float> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer get(float[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
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
    _r0.i = ((global::java.nio.FloatBuffer) _r5_o).remaining();
    if (_r8.i <= _r0.i) goto label31;
    _r0_o = new global::java.nio.BufferUnderflowException();
    ((global::java.nio.BufferUnderflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferUnderflowException) _r0_o);
    label31:;
    _r0.i = _r7.i;
    label32:;
    _r1.i = _r7.i + _r8.i;
    if (_r0.i < _r1.i) goto label37;
    return (global::java.nio.FloatBuffer) _r5_o;
    label37:;
    _r1.f = ((global::java.nio.FloatBuffer) _r5_o).get();
    ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i] = _r1.f;
    _r0.i = _r0.i + 1;
    goto label32;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer get(float[], int, int)]
}

public abstract float get(int n1);

public override bool hasArray(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: boolean hasArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.nio.FloatBuffer) _r1_o).protectedHasArray() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: boolean hasArray()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.i = ((global::java.nio.FloatBuffer) _r4_o)._fposition;
    _r1.i = 0;
    _r3.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r3.i;
    label6:;
    _r2.i = ((global::java.nio.FloatBuffer) _r4_o)._flimit;
    if (_r1.i < _r2.i) goto label11;
    return _r0.i;
    label11:;
    _r2.i = _r1.i + 1;
    _r1.f = ((global::java.nio.FloatBuffer) _r4_o).get((int) _r1.i);
    _r1.i = global::java.lang.Float.floatToIntBits((float) _r1.f);
    _r0.i = _r0.i + _r1.i;
    _r1.i = _r2.i;
    goto label6;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: int hashCode()]
}

public abstract override bool isDirect();

public abstract global::System.Object order();

public abstract global::System.Object protectedArray();

public abstract int protectedArrayOffset();

public abstract bool protectedHasArray();

public abstract global::System.Object put(float n1);

public virtual global::System.Object put(global::org.xmlvm._nArrayAdapter<float> n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer put(float[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0_o = ((global::java.nio.FloatBuffer) _r2_o).put((global::org.xmlvm._nArrayAdapter<float>) _r3_o, (int) _r0.i, (int) _r1.i);
    return (global::java.nio.FloatBuffer) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer put(float[])]
}

public virtual global::System.Object put(global::org.xmlvm._nArrayAdapter<float> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer put(float[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
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
    _r0.i = ((global::java.nio.FloatBuffer) _r5_o).remaining();
    if (_r8.i <= _r0.i) goto label31;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label31:;
    _r0.i = _r7.i;
    label32:;
    _r1.i = _r7.i + _r8.i;
    if (_r0.i < _r1.i) goto label37;
    return (global::java.nio.FloatBuffer) _r5_o;
    label37:;
    _r1.f = ((global::org.xmlvm._nArrayAdapter<float>) _r6_o)[_r0.i];
    ((global::java.nio.FloatBuffer) _r5_o).put((float) _r1.f);
    _r0.i = _r0.i + 1;
    goto label32;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer put(float[], int, int)]
}

public virtual global::System.Object put(global::java.nio.FloatBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer put(java.nio.FloatBuffer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    if (_r3_o != _r2_o) goto label8;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label8:;
    _r0.i = ((global::java.nio.FloatBuffer) _r3_o).remaining();
    _r1.i = ((global::java.nio.FloatBuffer) _r2_o).remaining();
    if (_r0.i <= _r1.i) goto label24;
    _r0_o = new global::java.nio.BufferOverflowException();
    ((global::java.nio.BufferOverflowException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.nio.BufferOverflowException) _r0_o);
    label24:;
    _r0.i = ((global::java.nio.FloatBuffer) _r3_o).remaining();
    _r0_o = new global::org.xmlvm._nArrayAdapter<float>(new float[_r0.i]);
    ((global::java.nio.FloatBuffer) _r3_o).get((global::org.xmlvm._nArrayAdapter<float>) _r0_o);
    ((global::java.nio.FloatBuffer) _r2_o).put((global::org.xmlvm._nArrayAdapter<float>) _r0_o);
    return (global::java.nio.FloatBuffer) _r2_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.nio.FloatBuffer put(java.nio.FloatBuffer)]
}

public abstract global::System.Object put(int n1, float n2);

public abstract global::System.Object slice();

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::java.lang.Object) _r2_o).getClass();
    _r1_o = ((global::java.lang.Class) _r1_o).getName();
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value=, status: capacity=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 61))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.nio.FloatBuffer) _r2_o).capacity();
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value= position=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 61))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.nio.FloatBuffer) _r2_o).position();
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    // Value= limit=
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 61))}));
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.nio.FloatBuffer) _r2_o).limit();
    ((global::java.lang.StringBuilder) _r0_o).append((int) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: java.lang.String toString()]
}

public virtual int compareTo(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer: int compareTo(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r2_o = _r2_o;
    _r0.i = ((global::java.nio.FloatBuffer) _r1_o).compareTo((global::java.nio.FloatBuffer) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.nio.FloatBuffer: int compareTo(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.nio.FloatBuffer]
//XMLVM_END_WRAPPER[java.nio.FloatBuffer]

} // end of class: FloatBuffer

} // end of namespace: java.nio
