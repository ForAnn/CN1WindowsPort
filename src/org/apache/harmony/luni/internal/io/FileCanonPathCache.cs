// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.@internal.io {
public class FileCanonPathCache: global::java.lang.Object {

static FileCanonPathCache() {
    @static();
}

public static int _fCACHE_1SIZE = 256;

private static global::java.util.HashMap _fcache;

private static global::java.util.LinkedList _flist;

private static global::java.lang.Object _flock;

private static long _ftimeout;

new public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = new global::java.util.HashMap();
    _r1.i = 256;
    ((global::java.util.HashMap) _r0_o).@this((int) _r1.i);
    global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache = (global::java.util.HashMap) _r0_o;
    _r0_o = new global::java.util.LinkedList();
    ((global::java.util.LinkedList) _r0_o).@this();
    global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flist = (global::java.util.LinkedList) _r0_o;
    _r0_o = new global::java.lang.Object();
    ((global::java.lang.Object) _r0_o).@this();
    global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flock = (global::java.lang.Object) _r0_o;
    _r0.l = 600000L;
    global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._ftimeout = _r0.l;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void <clinit>()]
}

new public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void <init>()]
}

public static global::System.Object get(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: java.lang.String get(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = n1;
    _r5_o = null;
    _r1_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flock;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    _r0_o = ((global::java.util.HashMap) _r0_o).get((global::java.lang.Object) _r6_o);
    global::System.Threading.Monitor.Exit(_r1_o);
    if (_r0_o != null) goto label20;
    _r0_o = _r5_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    label16:;
    try {
    return (global::java.lang.String) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    label17:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label17;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label20:;
    _r1.l = global::java.lang.System.currentTimeMillis();
    _r3.l = ((global::org.apache.harmony.luni.@internal.io.FileCanonPathCache_2CacheElement) _r0_o)._ftimestamp;
    _r1.l = _r1.l - _r3.l;
    _r3.l = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._ftimeout;
    _r1.i = _r1.l > _r3.l ? 1 : (_r1.l == _r3.l ? 0 : -1);
    if (_r1.i <= 0) goto label69;
    _r1_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flock;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    _r0_o = ((global::java.util.HashMap) _r0_o).get((global::java.lang.Object) _r6_o);
    if (_r0_o == null) goto label63;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label66;
        }
        throw ex;
    } // end catch
    label44:;
    try {
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flist;
    _r0_o = ((global::java.util.LinkedList) _r0_o).removeFirst();
    _r2_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    ((global::java.util.HashMap) _r2_o).remove((global::java.lang.Object) _r0_o);
    _r0.i = ((global::java.lang.String) _r6_o).equals((global::java.lang.Object) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label44;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label66;
        }
        throw ex;
    } // end catch
    label63:;
    try {
    global::System.Threading.Monitor.Exit(_r1_o);
    _r0_o = _r5_o;
    goto label16;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label66;
        }
        throw ex;
    } // end catch
    label66:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label66;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label69:;
    _r0_o = ((global::org.apache.harmony.luni.@internal.io.FileCanonPathCache_2CacheElement) _r0_o)._fcanonicalPath;
    goto label16;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: java.lang.String get(java.lang.String)]
}

public static void put(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void put(java.lang.String, java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = n1;
    _r5_o = n2;
    _r1_o = new global::org.apache.harmony.luni.@internal.io.FileCanonPathCache_2CacheElement();
    ((global::org.apache.harmony.luni.@internal.io.FileCanonPathCache_2CacheElement) _r1_o).@this((global::java.lang.String) _r5_o);
    _r2_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flock;
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    _r0.i = ((global::java.util.HashMap) _r0_o).size();
    _r3.i = 256;
    if (_r0.i < _r3.i) goto label31;
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flist;
    _r0_o = ((global::java.util.LinkedList) _r0_o).removeFirst();
    _r3_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    ((global::java.util.HashMap) _r3_o).remove((global::java.lang.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label43;
        }
        throw ex;
    } // end catch
    label31:;
    try {
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    ((global::java.util.HashMap) _r0_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r1_o);
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flist;
    ((global::java.util.LinkedList) _r0_o).addLast((global::java.lang.Object) _r4_o);
    global::System.Threading.Monitor.Exit(_r2_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label43;
        }
        throw ex;
    } // end catch
    label43:;
    try {
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label43;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void put(java.lang.String, java.lang.String)]
}

public static void clear(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flock;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._fcache;
    ((global::java.util.HashMap) _r1_o).clear();
    _r1_o = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._flist;
    ((global::java.util.LinkedList) _r1_o).clear();
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label15;
        }
        throw ex;
    } // end catch
    label15:;
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
            goto label15;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void clear()]
}

public static long getTimeout(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: long getTimeout()]
    global::org.xmlvm._nElement _r0;
    _r0.l = global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._ftimeout;
    return _r0.l;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: long getTimeout()]
}

public static void setTimeout(long n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void setTimeout(long)]
    global::org.xmlvm._nElement _r0;
    _r0.l = n1;
    global::org.apache.harmony.luni.@internal.io.FileCanonPathCache._ftimeout = _r0.l;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache: void setTimeout(long)]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.internal.io.FileCanonPathCache]

} // end of class: FileCanonPathCache

} // end of namespace: org.apache.harmony.luni.@internal.io
