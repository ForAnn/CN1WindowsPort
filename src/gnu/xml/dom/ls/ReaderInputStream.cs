// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace gnu.xml.dom.ls {
public class ReaderInputStream: global::java.io.InputStream {
private global::java.io.Reader _freader;

private global::java.lang.String _fencoding;

private global::org.xmlvm._nArrayAdapter<sbyte> _fextra;

private int _fpos;

private global::org.xmlvm._nArrayAdapter<sbyte> _fextra_1marked;

private int _fpos_1marked;

public void @this(global::java.io.Reader n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void <init>(java.io.Reader)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.io.InputStream) _r1_o).@this();
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._freader = (global::java.io.Reader) _r2_o;
    // Value=UTF-8
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 84)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 45)), unchecked((char) unchecked((uint) 56))}));
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._fencoding = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void <init>(java.io.Reader)]
}

public virtual void setEncoding(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void setEncoding(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r0_o)._fencoding = (global::java.lang.String) _r1_o;
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void setEncoding(java.lang.String)]
}

public override int read(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int read()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fextra;
    if (_r0_o == null) goto label27;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fextra;
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fpos;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o)[_r1.i];
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fpos;
    _r1.i = _r1.i + 1;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fpos = _r1.i;
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fpos;
    _r2_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fextra;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r1.i < _r2.i) goto label26;
    _r1_o = null;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._fextra = (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o;
    label26:;
    return _r0.i;
    label27:;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r3_o)._freader;
    _r0.i = ((global::java.io.Reader) _r0_o).read();
    goto label26;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int read()]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int read(byte[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o).read((global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o, (int) _r0.i, (int) _r1.i);
    return _r0.i;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int read(byte[])]
}

public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int read(byte[], int, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    global::org.xmlvm._nElement _r8;
    _r5_o = this;
    _r6_o = n1;
    _r7.i = n2;
    _r8.i = n3;
    _r2.i = -1;
    _r4.i = 0;
    if (_r8.i != 0) goto label6;
    _r0.i = _r4.i;
    label5:;
    return _r0.i;
    label6:;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra;
    if (_r0_o == null) goto label41;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fpos;
    _r0.i = _r0.i - _r1.i;
    if (_r0.i >= _r8.i) goto label39;
    label18:;
    _r1_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r1_o, (int) _r4.i, (global::java.lang.Object) _r6_o, (int) _r7.i, (int) _r0.i);
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fpos;
    _r1.i = _r1.i + _r0.i;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fpos = _r1.i;
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fpos;
    _r2_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    if (_r1.i < _r2.i) goto label5;
    _r1_o = null;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra = (global::org.xmlvm._nArrayAdapter<sbyte>) _r1_o;
    goto label5;
    label39:;
    _r0.i = _r8.i;
    goto label18;
    label41:;
    _r0_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r8.i]);
    _r1_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._freader;
    _r1.i = ((global::java.io.Reader) _r1_o).read((global::org.xmlvm._nArrayAdapter<char>) _r0_o, (int) _r4.i, (int) _r8.i);
    if (_r1.i != _r2.i) goto label53;
    _r0.i = _r2.i;
    goto label5;
    label53:;
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String) _r2_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r0_o, (int) _r4.i, (int) _r1.i);
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fencoding;
    _r0_o = ((global::java.lang.String) _r2_o).getBytes((global::java.lang.String) _r0_o);
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = _r2.i - _r8.i;
    if (_r2.i <= 0) goto label81;
    _r3_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r2.i]);
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra = (global::org.xmlvm._nArrayAdapter<sbyte>) _r3_o;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fpos = _r4.i;
    _r3_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r5_o)._fextra;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r8.i, (global::java.lang.Object) _r3_o, (int) _r4.i, (int) _r2.i);
    _r1.i = _r1.i - _r2.i;
    label81:;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r4.i, (global::java.lang.Object) _r6_o, (int) _r7.i, (int) _r1.i);
    _r0.i = _r1.i;
    goto label5;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int read(byte[], int, int)]
}

public override void close(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void close()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._freader;
    ((global::java.io.Reader) _r0_o).close();
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void close()]
}

public override bool markSupported(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: boolean markSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._freader;
    _r0.i = ((global::java.io.Reader) _r0_o).markSupported() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: boolean markSupported()]
}

public override void mark(int n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void mark(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r3.i = 0;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra;
    if (_r0_o == null) goto label32;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r0_o = new global::org.xmlvm._nArrayAdapter<sbyte>(new sbyte[_r0.i]);
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra_1marked = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra;
    _r1_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra_1marked;
    _r2_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra;
    _r2.i = ((global::org.xmlvm._nIArray) _r2_o).Length;
    global::java.lang.System.arraycopy((global::java.lang.Object) _r0_o, (int) _r3.i, (global::java.lang.Object) _r1_o, (int) _r3.i, (int) _r2.i);
    _r0.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fpos;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fpos_1marked = _r0.i;
    label26:;
    try {
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._freader;
    ((global::java.io.Reader) _r0_o).mark((int) _r5.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.io.IOException) {
            _ex = ex;
            goto label36;
        }
        throw ex;
    } // end catch
    return;
    label32:;
    _r0_o = null;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r4_o)._fextra_1marked = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    goto label26;
    label36:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.lang.RuntimeException();
    ((global::java.lang.RuntimeException) _r1_o).@this((global::java.lang.Throwable) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.RuntimeException) _r1_o);
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void mark(int)]
}

public override void reset(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void reset()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._fextra_1marked;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._fextra = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    _r0.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._fpos_1marked;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._fpos = _r0.i;
    _r0_o = null;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._fextra_1marked = (global::org.xmlvm._nArrayAdapter<sbyte>) _r0_o;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r1_o)._freader;
    ((global::java.io.Reader) _r0_o).reset();
    return;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: void reset()]
}

public override long skip(long n1){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: long skip(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nElement _r7;
    _r6_o = this;
    _r7.l = n1;
    _r4.l = 0L;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fextra;
    if (_r0_o == null) goto label51;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fextra;
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r1.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fpos;
    _r0.i = _r0.i - _r1.i;
    _r1.l = (long) _r0.i;
    _r1.i = _r1.l > _r7.l ? 1 : (_r1.l == _r7.l ? 0 : -1);
    if (_r1.i >= 0) goto label49;
    _r0.l = (long) _r0.i;
    label18:;
    _r2.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fpos;
    _r2.l = (long) _r2.i;
    _r2.l = _r2.l + _r0.l;
    _r2.i = (int) _r2.l;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fpos = _r2.i;
    _r2.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fpos;
    _r3_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fextra;
    _r3.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r2.i < _r3.i) goto label35;
    _r2_o = null;
    ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._fextra = (global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o;
    label35:;
    _r2.l = _r7.l - _r0.l;
    _r4.i = _r2.l > _r4.l ? 1 : (_r2.l == _r4.l ? 0 : -1);
    if (_r4.i <= 0) goto label48;
    _r4_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r6_o)._freader;
    _r2.l = ((global::java.io.Reader) _r4_o).skip((long) _r2.l);
    _r0.l = _r0.l + _r2.l;
    label48:;
    return _r0.l;
    label49:;
    _r0.l = _r7.l;
    goto label18;
    label51:;
    _r0.l = _r4.l;
    goto label35;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: long skip(long)]
}

public override int available(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int available()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o)._fextra;
    if (_r0_o == null) goto label11;
    _r0.i = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o)._fpos;
    _r1_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o)._fextra;
    _r1.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r0.i = _r0.i - _r1.i;
    label10:;
    return _r0.i;
    label11:;
    _r0_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o)._freader;
    _r0.i = ((global::java.io.Reader) _r0_o).ready() ? 1 : 0;
    if (_r0.i == 0) goto label21;
    _r0.i = 1;
    goto label10;
    label21:;
    _r0.i = 0;
    goto label10;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: int available()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    _r1_o = ((global::java.lang.Object) _r2_o).getClass();
    _r1_o = ((global::java.lang.Class) _r1_o).getName();
    _r1_o = global::java.lang.String.valueOf((global::java.lang.Object) _r1_o);
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    // Value=[
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o)._freader;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value=, 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)44)), unchecked((char) unchecked((uint) 32))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::gnu.xml.dom.ls.ReaderInputStream) _r2_o)._fencoding;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value=]
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)93))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[gnu.xml.dom.ls.ReaderInputStream]
//XMLVM_END_WRAPPER[gnu.xml.dom.ls.ReaderInputStream]

} // end of class: ReaderInputStream

} // end of namespace: gnu.xml.dom.ls
