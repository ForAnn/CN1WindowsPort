// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class DataInputStream: global::java.io.FilterInputStream,global::java.io.DataInput {
public global::org.xmlvm._nArrayAdapter<sbyte> _fbuff;

public void @this(global::java.io.InputStream n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: void <init>(java.io.InputStream)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.io.FilterInputStream) _r1_o).@this((global::java.io.InputStream) _r2_o);
    _r0.i = 8;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    ((global::java.io.DataInputStream) _r1_o)._fbuff = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.DataInputStream: void <init>(java.io.InputStream)]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int read(byte[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = ((global::java.io.DataInputStream) _r3_o)._fin;
    _r1.i = 0;
    _r2.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r0.i = ((global::java.io.InputStream) _r0_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o, (int) _r1.i, (int) _r2.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int read(byte[])]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int read(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    _r4.i = n3;
    _r0_o = ((global::java.io.DataInputStream) _r1_o)._fin;
    _r0.i = ((global::java.io.InputStream) _r0_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r3.i, (int) _r4.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int read(byte[], int, int)]
}

public virtual bool readBoolean(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: boolean readBoolean()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.DataInputStream) _r1_o)._fin;
    _r0.i = ((global::java.io.InputStream) _r0_o).read();
    if (_r0.i >= 0) goto label14;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label14:;
    if (_r0.i == 0) goto label18;
    _r0.i = 1;
    label17:;
    return _r0.i!=0;
    label18:;
    _r0.i = 0;
    goto label17;
//XMLVM_END_WRAPPER[java.io.DataInputStream: boolean readBoolean()]
}

public virtual sbyte readByte(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: byte readByte()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.DataInputStream) _r1_o)._fin;
    _r0.i = ((global::java.io.InputStream) _r0_o).read();
    if (_r0.i >= 0) goto label14;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label14:;
    _r0.i = (_r0.i << 24) >> 24;
    return (sbyte) _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: byte readByte()]
}

private int readToBuff(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int readToBuff(int)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r4_o = this;
    _r5.i = n1;
    _r0.i = 0;
    label1:;
    if (_r0.i < _r5.i) goto label4;
    label3:;
    return _r0.i;
    label4:;
    _r1_o = ((global::java.io.DataInputStream) _r4_o)._fin;
    _r2_o = ((global::java.io.DataInputStream) _r4_o)._fbuff;
    _r3.i = _r5.i - _r0.i;
    _r1.i = ((global::java.io.InputStream) _r1_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o, (int) _r0.i, (int) _r3.i);
    _r2.i = -1;
    if (_r1.i != _r2.i) goto label19;
    _r0.i = _r1.i;
    goto label3;
    label19:;
    _r0.i = _r0.i + _r1.i;
    goto label1;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int readToBuff(int)]
}

public virtual char readChar(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: char readChar()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 2;
    _r0.i = ((global::java.io.DataInputStream) _r3_o).readToBuff((int) _r0.i);
    if (_r0.i >= 0) goto label13;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label13:;
    _r0_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r1.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i << (0x1f & 8);
    _r1_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r2.i = 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r0.i = _r0.i | _r1.i;
    _r0.i = _r0.i & 0xffff;
    return (char) _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: char readChar()]
}

public virtual double readDouble(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: double readDouble()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0.l = ((global::java.io.DataInputStream) _r2_o).readLong();
    _r0.d = global::java.lang.Double.longBitsToDouble((long) _r0.l);
    return _r0.d;
//XMLVM_END_WRAPPER[java.io.DataInputStream: double readDouble()]
}

public virtual float readFloat(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: float readFloat()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.io.DataInputStream) _r1_o).readInt();
    _r0.f = global::java.lang.Float.intBitsToFloat((int) _r0.i);
    return _r0.f;
//XMLVM_END_WRAPPER[java.io.DataInputStream: float readFloat()]
}

public virtual void readFully(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: void readFully(byte[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    ((global::java.io.DataInputStream) _r2_o).readFully((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r0.i, (int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.io.DataInputStream: void readFully(byte[])]
}

public virtual void readFully(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: void readFully(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r6.i = n3;
    if (_r6.i >= 0) goto label8;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label8:;
    if (_r6.i != 0) goto label11;
    label10:;
    return;
    label11:;
    _r0_o = ((global::java.io.DataInputStream) _r3_o)._fin;
    if (_r0_o != null) goto label27;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=luni.AA
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 65)), unchecked((char) unchecked((uint) 65))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label27:;
    if (_r4_o != null) goto label41;
    _r0_o = new global::java.lang.NullPointerException();
    // Value=luni.11
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 49)), unchecked((char) unchecked((uint) 49))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.NullPointerException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label41:;
    if (_r5.i < 0) goto label47;
    _r0.i = ((global::org.xmlvm._nIArray) _r4_o).Length;
    _r0.i = _r0.i - _r6.i;
    if (_r5.i <= _r0.i) goto label72;
    label47:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
    label53:;
    _r2_o = ((global::java.io.DataInputStream) _r3_o)._fin;
    _r2.i = ((global::java.io.InputStream) _r2_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r4_o, (int) _r1.i, (int) _r0.i);
    if (_r2.i >= 0) goto label67;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label67:;
    _r1.i = _r1.i + _r2.i;
    _r0.i = _r0.i - _r2.i;
    label69:;
    if (_r0.i > 0) goto label53;
    goto label10;
    label72:;
    _r0.i = _r6.i;
    _r1.i = _r5.i;
    goto label69;
//XMLVM_END_WRAPPER[java.io.DataInputStream: void readFully(byte[], int, int)]
}

public virtual int readInt(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int readInt()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 4;
    _r0.i = ((global::java.io.DataInputStream) _r3_o).readToBuff((int) _r0.i);
    if (_r0.i >= 0) goto label13;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label13:;
    _r0_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r1.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i << (0x1f & 24);
    _r1_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r2.i = 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r1.i = _r1.i << (0x1f & 16);
    _r0.i = _r0.i | _r1.i;
    _r1_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r2.i = 2;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r1.i = _r1.i << (0x1f & 8);
    _r0.i = _r0.i | _r1.i;
    _r1_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r2.i = 3;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r0.i = _r0.i | _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int readInt()]
}

public virtual global::System.Object readLine(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: java.lang.String readLine()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    _r1.i = 80;
    ((global::java.lang.StringBuilder) _r0_o).@this((int) _r1.i);
    _r1.i = 0;
    label8:;
    _r2_o = ((global::java.io.DataInputStream) _r4_o)._fin;
    _r2.i = ((global::java.io.InputStream) _r2_o).read();
    switch (_r2.i) {
    case -1: goto label31;
    case 10: goto label81;
    case 13: goto label46;
    }
    if (_r1.i == 0) goto label86;
    _r4_o = ((global::java.io.DataInputStream) _r4_o)._fin;
    _r4_o = _r4_o;
    ((global::java.io.PushbackInputStream) _r4_o).unread((int) _r2.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    label30:;
    return (global::java.lang.String) _r0_o;
    label31:;
    _r2.i = ((global::java.lang.StringBuilder) _r0_o).length();
    if (_r2.i != 0) goto label41;
    if (_r1.i != 0) goto label41;
    _r0_o = null;
    goto label30;
    label41:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label30;
    label46:;
    if (_r1.i == 0) goto label60;
    _r4_o = ((global::java.io.DataInputStream) _r4_o)._fin;
    _r4_o = _r4_o;
    ((global::java.io.PushbackInputStream) _r4_o).unread((int) _r2.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label30;
    label60:;
    _r1.i = 1;
    _r2_o = ((global::java.io.DataInputStream) _r4_o)._fin;
    _r2_o = ((global::java.lang.Object) _r2_o).getClass();
    _r3_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.io.PushbackInputStream));
    if (_r2_o == _r3_o) goto label8;
    _r2_o = new global::java.io.PushbackInputStream();
    _r3_o = ((global::java.io.DataInputStream) _r4_o)._fin;
    ((global::java.io.PushbackInputStream) _r2_o).@this((global::java.io.InputStream) _r3_o);
    ((global::java.io.DataInputStream) _r4_o)._fin = (global::java.io.InputStream) _r2_o;
    goto label8;
    label81:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    goto label30;
    label86:;
    _r2.i = _r2.i & 0xffff;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r2.i);
    goto label8;
//XMLVM_END_WRAPPER[java.io.DataInputStream: java.lang.String readLine()]
}

public virtual long readLong(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: long readLong()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r6_o = null;
    _r6_o = this;
    _r4.l = 4294967295L;
    _r0.i = 8;
    _r0.i = ((global::java.io.DataInputStream) _r6_o).readToBuff((int) _r0.i);
    if (_r0.i >= 0) goto label19;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label19:;
    _r0_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r1.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i << (0x1f & 24);
    _r1_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r2.i = 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r1.i = _r1.i << (0x1f & 16);
    _r0.i = _r0.i | _r1.i;
    _r1_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r2.i = 2;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r1.i = _r1.i << (0x1f & 8);
    _r0.i = _r0.i | _r1.i;
    _r1_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r2.i = 3;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r0.i = _r0.i | _r1.i;
    _r1_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r2.i = 4;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r1.i = _r1.i << (0x1f & 24);
    _r2_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r3.i = 5;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r3.i];
    _r2.i = _r2.i & 255;
    _r2.i = _r2.i << (0x1f & 16);
    _r1.i = _r1.i | _r2.i;
    _r2_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r3.i = 6;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r3.i];
    _r2.i = _r2.i & 255;
    _r2.i = _r2.i << (0x1f & 8);
    _r1.i = _r1.i | _r2.i;
    _r2_o = ((global::java.io.DataInputStream) _r6_o)._fbuff;
    _r3.i = 7;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o)[_r3.i];
    _r2.i = _r2.i & 255;
    _r1.i = _r1.i | _r2.i;
    _r2.l = (long) _r0.i;
    _r2.l = _r2.l & _r4.l;
    _r0.i = 32;
    _r2.l = _r2.l << (0x3f & _r0.i);
    _r0.l = (long) _r1.i;
    _r0.l = _r0.l & _r4.l;
    _r0.l = _r0.l | _r2.l;
    return _r0.l;
//XMLVM_END_WRAPPER[java.io.DataInputStream: long readLong()]
}

public virtual short readShort(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: short readShort()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 2;
    _r0.i = ((global::java.io.DataInputStream) _r3_o).readToBuff((int) _r0.i);
    if (_r0.i >= 0) goto label13;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label13:;
    _r0_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r1.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i << (0x1f & 8);
    _r1_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r2.i = 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r0.i = _r0.i | _r1.i;
    _r0.i = (_r0.i << 16) >> 16;
    return (short) _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: short readShort()]
}

public virtual int readUnsignedByte(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int readUnsignedByte()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.io.DataInputStream) _r1_o)._fin;
    _r0.i = ((global::java.io.InputStream) _r0_o).read();
    if (_r0.i >= 0) goto label14;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label14:;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int readUnsignedByte()]
}

public virtual int readUnsignedShort(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int readUnsignedShort()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0.i = 2;
    _r0.i = ((global::java.io.DataInputStream) _r3_o).readToBuff((int) _r0.i);
    if (_r0.i >= 0) goto label13;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label13:;
    _r0_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r1.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r0.i = _r0.i & 255;
    _r0.i = _r0.i << (0x1f & 8);
    _r1_o = ((global::java.io.DataInputStream) _r3_o)._fbuff;
    _r2.i = 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o)[_r2.i];
    _r1.i = _r1.i & 255;
    _r0.i = _r0.i | _r1.i;
    _r0.i = _r0.i & 0xffff;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int readUnsignedShort()]
}

public virtual global::System.Object readUTF(){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: java.lang.String readUTF()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.io.DataInputStream) _r1_o).readUnsignedShort();
    _r0_o = ((global::java.io.DataInputStream) _r1_o).decodeUTF((int) _r0.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.io.DataInputStream: java.lang.String readUTF()]
}

public virtual global::System.Object decodeUTF(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: java.lang.String decodeUTF(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = global::java.io.DataInputStream.decodeUTF((int) _r2.i, (global::java.io.DataInput) _r1_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.io.DataInputStream: java.lang.String decodeUTF(int)]
}

private static global::System.Object decodeUTF(int n1, global::java.io.DataInput n2){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: java.lang.String decodeUTF(int, java.io.DataInput)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    _r3.i = n1;
    _r4_o = n2;
    _r2.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r3.i]);
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r3.i]);
    ((global::java.io.DataInput) _r4_o).readFully((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (int) _r2.i, (int) _r3.i);
    _r0_o = global::org.apache.harmony.luni.util.Util.convertUTF8WithBuf((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o, (global::org.xmlvm._nArrayAdapter<char>) _r1_o, (int) _r2.i, (int) _r3.i);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.io.DataInputStream: java.lang.String decodeUTF(int, java.io.DataInput)]
}

public static global::System.Object readUTF(global::java.io.DataInput n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: java.lang.String readUTF(java.io.DataInput)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0.i = ((global::java.io.DataInput) _r1_o).readUnsignedShort();
    _r0_o = global::java.io.DataInputStream.decodeUTF((int) _r0.i, (global::java.io.DataInput) _r1_o);
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.io.DataInputStream: java.lang.String readUTF(java.io.DataInput)]
}

public virtual int skipBytes(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream: int skipBytes(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    _r5_o = this;
    _r6.i = n1;
    _r0.i = 0;
    label1:;
    if (_r0.i >= _r6.i) goto label18;
    _r1_o = ((global::java.io.DataInputStream) _r5_o)._fin;
    _r2.i = _r6.i - _r0.i;
    _r2.l = (long) _r2.i;
    _r1.l = ((global::java.io.InputStream) _r1_o).skip((long) _r2.l);
    _r3.l = 0L;
    _r3.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r3.i != 0) goto label26;
    label18:;
    if (_r0.i >= 0) goto label31;
    _r0_o = new global::java.io.EOFException();
    ((global::java.io.EOFException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.EOFException) _r0_o);
    label26:;
    _r3.l = (long) _r0.i;
    _r0.l = _r3.l + _r1.l;
    _r0.i = (int) _r0.l;
    goto label1;
    label31:;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.DataInputStream: int skipBytes(int)]
}

//XMLVM_BEGIN_WRAPPER[java.io.DataInputStream]
//XMLVM_END_WRAPPER[java.io.DataInputStream]

} // end of class: DataInputStream

} // end of namespace: java.io
