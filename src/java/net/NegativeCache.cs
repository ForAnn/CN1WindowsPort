// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.net {
public class NegativeCache: global::java.util.LinkedHashMap {
private static long _fserialVersionUID = 1L;

private static global::java.net.NegativeCache _fnegCache;

private static int _fMAX_1NEGATIVE_1ENTRIES = 5;

private static float _fLOADING = (float)0.75D;

public void @this(int n1, float n2, bool n3){
//XMLVM_BEGIN_WRAPPER[java.net.NegativeCache: void <init>(int, float, boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1.i = n1;
    _r2.f = n2;
    _r3.i = n3 ? 1 : 0;
    ((global::java.util.LinkedHashMap) _r0_o).@this((int) _r1.i, (float) _r2.f, 0!=_r3.i);
    return;
//XMLVM_END_WRAPPER[java.net.NegativeCache: void <init>(int, float, boolean)]
}

public override bool removeEldestEntry(global::java.util.Map_2Entry n1){
//XMLVM_BEGIN_WRAPPER[java.net.NegativeCache: boolean removeEldestEntry(java.util.Map$Entry)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((global::java.net.NegativeCache) _r2_o).size();
    _r1.i = 5;
    if (_r0.i <= _r1.i) goto label9;
    _r0.i = 1;
    label8:;
    return _r0.i!=0;
    label9:;
    _r0.i = 0;
    goto label8;
//XMLVM_END_WRAPPER[java.net.NegativeCache: boolean removeEldestEntry(java.util.Map$Entry)]
}

public static void put(global::java.lang.String n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[java.net.NegativeCache: void put(java.lang.String, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.net.NegativeCache));
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    global::java.net.NegativeCache.checkCacheExists();
    _r1_o = global::java.net.NegativeCache._fnegCache;
    _r2_o = new global::java.net.NegCacheElement();
    ((global::java.net.NegCacheElement) _r2_o).@this((global::java.lang.String) _r4_o);
    ((global::java.net.NegativeCache) _r1_o).put((global::java.lang.Object) _r3_o, (global::java.lang.Object) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label18;
        }
        throw ex;
    } // end catch
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
    label18:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r1_o);
//XMLVM_END_WRAPPER[java.net.NegativeCache: void put(java.lang.String, java.lang.String)]
}

public static global::System.Object getFailedMessage(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.net.NegativeCache: java.lang.String getFailedMessage(java.lang.String)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = n1;
    _r7_o = null;
    _r2_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.net.NegativeCache));
    global::System.Threading.Monitor.Enter(_r2_o);
    try {
    global::java.net.NegativeCache.checkCacheExists();
    _r0_o = global::java.net.NegativeCache._fnegCache;
    _r0_o = ((global::java.net.NegativeCache) _r0_o).get((global::java.lang.Object) _r8_o);
    _r0_o = _r0_o;
    if (_r0_o == null) goto label50;
    _r1_o = new global::org.apache.harmony.luni.util.PriviAction();
    // Value=networkaddress.cache.negative.ttl
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 119)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 107)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 118)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 108))}));
    ((global::org.apache.harmony.luni.util.PriviAction) _r1_o).@this((global::java.lang.String) _r3_o);
    _r1_o = global::java.security.AccessController.doPrivileged((global::java.security.PrivilegedAction) _r1_o);
    _r1_o = _r1_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label85;
        }
        throw ex;
    } // end catch
    _r3.i = 10;
    if (_r1_o == null) goto label57;
    try {
    _r1_o = global::java.lang.Integer.decode((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.lang.Integer) _r1_o).intValue();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NumberFormatException) {
            _ex = ex;
            goto label56;
        }
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label85;
        }
        throw ex;
    } // end catch
    label42:;
    if (_r1.i != 0) goto label59;
    try {
    _r0_o = global::java.net.NegativeCache._fnegCache;
    ((global::java.net.NegativeCache) _r0_o).clear();
    _r0_o = _r7_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label85;
        }
        throw ex;
    } // end catch
    label50:;
    try {
    if (_r0_o == null) goto label83;
    _r0_o = ((global::java.net.NegCacheElement) _r0_o)._fhostName;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label85;
        }
        throw ex;
    } // end catch
    label54:;
    global::System.Threading.Monitor.Exit(_r2_o);
    return (global::java.lang.String) _r0_o;
    label56:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    label57:;
    _r1.i = _r3.i;
    goto label42;
    label59:;
    _r3.i = -1;
    if (_r1.i == _r3.i) goto label50;
    try {
    _r3.l = ((global::java.net.NegCacheElement) _r0_o)._ftimeAdded;
    _r1.i = _r1.i * 1000;
    _r5.l = (long) _r1.i;
    _r3.l = _r3.l + _r5.l;
    _r5.l = global::java.lang.System.currentTimeMillis();
    _r1.i = _r3.l > _r5.l ? 1 : (_r3.l == _r5.l ? 0 : -1);
    if (_r1.i >= 0) goto label50;
    _r0_o = global::java.net.NegativeCache._fnegCache;
    ((global::java.net.NegativeCache) _r0_o).remove((global::java.lang.Object) _r8_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label85;
        }
        throw ex;
    } // end catch
    _r0_o = _r7_o;
    goto label50;
    label83:;
    _r0_o = _r7_o;
    goto label54;
    label85:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
//XMLVM_END_WRAPPER[java.net.NegativeCache: java.lang.String getFailedMessage(java.lang.String)]
}

public static void checkCacheExists(){
//XMLVM_BEGIN_WRAPPER[java.net.NegativeCache: void checkCacheExists()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.net.NegativeCache));
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = global::java.net.NegativeCache._fnegCache;
    if (_r1_o != null) goto label18;
    _r1_o = new global::java.net.NegativeCache();
    _r2.i = 6;
    _r3.f = (float)0.75D;
    _r4.i = 1;
    ((global::java.net.NegativeCache) _r1_o).@this((int) _r2.i, (float) _r3.f, 0!=_r4.i);
    global::java.net.NegativeCache._fnegCache = (global::java.net.NegativeCache) _r1_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label20;
        }
        throw ex;
    } // end catch
    label18:;
    global::System.Threading.Monitor.Exit(_r0_o);
    return;
    label20:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r1_o);
//XMLVM_END_WRAPPER[java.net.NegativeCache: void checkCacheExists()]
}

//XMLVM_BEGIN_WRAPPER[java.net.NegativeCache]
//XMLVM_END_WRAPPER[java.net.NegativeCache]

} // end of class: NegativeCache

} // end of namespace: java.net
