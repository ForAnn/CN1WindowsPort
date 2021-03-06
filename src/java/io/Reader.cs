// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public abstract class Reader: global::java.lang.Object,global::java.lang.Readable,global::java.io.Closeable {
public global::java.lang.Object _flock;

new public void @this(){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.io.Reader) _r0_o)._flock = (global::java.lang.Object) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.io.Reader: void <init>()]
}

public void @this(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: void <init>(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.lang.Object) _r1_o).@this();
    if (_r2_o != null) goto label11;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label11:;
    ((global::java.io.Reader) _r1_o)._flock = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.io.Reader: void <init>(java.lang.Object)]
}

public abstract void close();

public virtual void mark(int n1){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: void mark(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
//XMLVM_END_WRAPPER[java.io.Reader: void mark(int)]
}

public virtual bool markSupported(){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: boolean markSupported()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.io.Reader: boolean markSupported()]
}

public virtual int read(){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: int read()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r4.i = -1;
    _r0_o = ((global::java.io.Reader) _r5_o)._flock;
    global::System.Threading.Monitor.Enter(_r0_o);
    _r1.i = 1;
    try {
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    _r2.i = 0;
    _r3.i = 1;
    _r2.i = ((global::java.io.Reader) _r5_o).read((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (int) _r2.i, (int) _r3.i);
    if (_r2.i == _r4.i) goto label21;
    _r2.i = 0;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<char>) _r1_o)[_r2.i];
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.i = _r1.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    label20:;
    try {
    return _r0.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    label21:;
    try {
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.i = _r4.i;
    goto label20;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    label24:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label24;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.io.Reader: int read()]
}

public virtual int read(global::org.xmlvm._nArrayAdapter<char> n1){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: int read(char[])]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    _r0.i = ((global::java.io.Reader) _r2_o).read((global::org.xmlvm._nArrayAdapter<char>) _r3_o, (int) _r0.i, (int) _r1.i);
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.Reader: int read(char[])]
}

public abstract int read(global::org.xmlvm._nArrayAdapter<char> n1, int n2, int n3);

public virtual bool ready(){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: boolean ready()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.io.Reader: boolean ready()]
}

public virtual void reset(){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: void reset()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = new global::java.io.IOException();
    ((global::java.io.IOException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.io.IOException) _r0_o);
//XMLVM_END_WRAPPER[java.io.Reader: void reset()]
}

public virtual long skip(long n1){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: long skip(long)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r5;
    global::org.xmlvm._nElement _r6;
    global::org.xmlvm._nElement _r7;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r9_o = this;
    _r10.l = n1;
    _r3.l = 0L;
    _r0.i = _r10.l > _r3.l ? 1 : (_r10.l == _r3.l ? 0 : -1);
    if (_r0.i >= 0) goto label12;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label12:;
    _r0_o = ((global::java.io.Reader) _r9_o)._flock;
    global::System.Threading.Monitor.Enter(_r0_o);
    _r1.l = 512L;
    _r1.i = _r10.l > _r1.l ? 1 : (_r10.l == _r1.l ? 0 : -1);
    if (_r1.i >= 0) goto label31;
    _r1.i = (int) _r10.l;
    label22:;
    try {
    _r2_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r1.i]);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label24:;
    try {
    _r5.i = _r3.l > _r10.l ? 1 : (_r3.l == _r10.l ? 0 : -1);
    if (_r5.i < 0) goto label34;
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.l = _r3.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label30:;
    try {
    return _r0.l;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label31:;
    try {
    _r1.i = 512;
    goto label22;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label34:;
    try {
    _r5.i = 0;
    _r5.i = ((global::java.io.Reader) _r9_o).read((global::org.xmlvm._nArrayAdapter<char>) _r2_o, (int) _r5.i, (int) _r1.i);
    _r6.i = -1;
    if (_r5.i != _r6.i) goto label45;
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.l = _r3.l;
    goto label30;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label45:;
    try {
    _r6.l = (long) _r5.i;
    _r3.l = _r3.l + _r6.l;
    if (_r5.i >= _r1.i) goto label52;
    global::System.Threading.Monitor.Exit(_r0_o);
    _r0.l = _r3.l;
    goto label30;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label52:;
    try {
    _r5.l = _r10.l - _r3.l;
    _r7.l = (long) _r1.i;
    _r5.i = _r5.l > _r7.l ? 1 : (_r5.l == _r7.l ? 0 : -1);
    if (_r5.i >= 0) goto label24;
    _r5.l = _r10.l - _r3.l;
    _r1.i = (int) _r5.l;
    goto label24;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    label63:;
    try {
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label63;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.io.Reader: long skip(long)]
}

public virtual int read(global::java.nio.CharBuffer n1){
//XMLVM_BEGIN_WRAPPER[java.io.Reader: int read(java.nio.CharBuffer)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    if (_r4_o != null) goto label8;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label8:;
    _r0.i = ((global::java.nio.CharBuffer) _r4_o).length();
    _r1_o = new global::org.xmlvm._nArrayAdapter<char>(new char[_r0.i]);
    _r2.i = ((global::java.io.Reader) _r3_o).read((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    _r0.i = global::java.lang.Math.min((int) _r0.i, (int) _r2.i);
    if (_r0.i <= 0) goto label28;
    _r2.i = 0;
    ((global::java.nio.CharBuffer) _r4_o).put((global::org.xmlvm._nArrayAdapter<char>) _r1_o, (int) _r2.i, (int) _r0.i);
    label28:;
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.Reader: int read(java.nio.CharBuffer)]
}

//XMLVM_BEGIN_WRAPPER[java.io.Reader]
//XMLVM_END_WRAPPER[java.io.Reader]

} // end of class: Reader

} // end of namespace: java.io
