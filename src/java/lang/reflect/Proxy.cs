// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.lang.reflect {
public class Proxy: global::java.lang.Object,global::java.io.Serializable {

static Proxy() {
    @static();
}


private static global::java.util.Map _floaderCache;

private static global::java.util.Map _fproxyCache;

private static int _fNextClassNameIndex;

public global::java.lang.reflect.InvocationHandler _fh;

public static bool _f_2assertionsDisabled;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r1.i = 0;
    _r0_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.reflect.Proxy));
    _r0.i = ((global::java.lang.Class) _r0_o).desiredAssertionStatus() ? 1 : 0;
    if (_r0.i != 0) goto label29;
    _r0.i = 1;
    label10:;
    global::java.lang.reflect.Proxy._f_2assertionsDisabled = 0!=_r0.i;
    _r0_o = new global::java.util.WeakHashMap();
    ((global::java.util.WeakHashMap) _r0_o).@this();
    global::java.lang.reflect.Proxy._floaderCache = (global::java.util.Map) _r0_o;
    _r0_o = new global::java.util.WeakHashMap();
    ((global::java.util.WeakHashMap) _r0_o).@this();
    global::java.lang.reflect.Proxy._fproxyCache = (global::java.util.Map) _r0_o;
    global::java.lang.reflect.Proxy._fNextClassNameIndex = _r1.i;
    return;
    label29:;
    _r0.i = _r1.i;
    goto label10;
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: void <clinit>()]
}

private void @this(){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: void <init>()]
}

public void @this(global::java.lang.reflect.InvocationHandler n1){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: void <init>(java.lang.reflect.InvocationHandler)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.lang.reflect.Proxy) _r0_o)._fh = (global::java.lang.reflect.InvocationHandler) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: void <init>(java.lang.reflect.InvocationHandler)]
}

public static global::System.Object getProxyClass(global::java.lang.ClassLoader n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: java.lang.Class getProxyClass(java.lang.ClassLoader, java.lang.Class[])]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
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
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r10_o = null;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r11_o = n1;
    _r12_o = n2;
    _r9.i = 46;
    _r7.i = 0;
    // Value=luni.51
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 49))}));
    // Value=
    _r8_o = new global::java.lang.String();
    ((global::java.lang.String)_r8_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    // Value=\042
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34))}));
    if (_r12_o != null) goto label17;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label17:;
    _r0_o = null;
    _r1.i = ((global::org.xmlvm._nIArray) _r12_o).Length;
    _r2_o = _r0_o;
    _r0.i = _r7.i;
    label21:;
    if (_r0.i < _r1.i) goto label157;
    _r1_o = global::java.lang.reflect.Proxy._floaderCache;
    global::System.Threading.Monitor.Enter(_r1_o);
    try {
    _r0_o = global::java.lang.reflect.Proxy._floaderCache;
    _r0_o = ((global::java.util.Map) _r0_o).get((global::java.lang.Object) _r11_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label433;
    _r0_o = global::java.lang.reflect.Proxy._floaderCache;
    _r3_o = new global::java.util.HashMap();
    ((global::java.util.HashMap) _r3_o).@this();
    ((global::java.util.Map) _r0_o).put((global::java.lang.Object) _r11_o, (global::java.lang.Object) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label46:;
    try {
    // Value=
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r0.i = ((global::org.xmlvm._nIArray) _r12_o).Length;
    _r4.i = 1;
    if (_r0.i != _r4.i) goto label300;
    _r0.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r0.i];
    _r0_o = ((global::java.lang.Class) _r0_o).getName();
    _r4_o = _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label60:;
    try {
    _r0_o = ((global::java.util.Map) _r3_o).get((global::java.lang.Object) _r4_o);
    _r0_o = _r0_o;
    if (_r0_o != null) goto label339;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=$Proxy
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)36)), unchecked((char) unchecked((uint) 80)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r5_o);
    _r5.i = global::java.lang.reflect.Proxy._fNextClassNameIndex;
    _r6.i = _r5.i + 1;
    global::java.lang.reflect.Proxy._fNextClassNameIndex = _r6.i;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((int) _r5.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    if (_r2_o == null) goto label120;
    _r5.i = ((global::java.lang.String) _r2_o).length();
    if (_r5.i <= 0) goto label120;
    _r5_o = new global::java.lang.StringBuilder();
    _r2_o = global::java.lang.String.valueOf((global::java.lang.Object) _r2_o);
    ((global::java.lang.StringBuilder) _r5_o).@this((global::java.lang.String) _r2_o);
    // Value=.
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    _r2_o = ((global::java.lang.StringBuilder) _r5_o).append((global::java.lang.String) _r2_o);
    _r0_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r0_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label120:;
    try {
// Red class access removed: org.apache.harmony.luni.internal.reflect.ProxyClassFile generateBytes
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: org.apache.harmony.luni.internal.reflect.ProxyClassFile generateBytes");
    _r5.i = 46;
    _r6.i = 47;
    _r0_o = ((global::java.lang.String) _r0_o).replace((char) _r5.i, (char) _r6.i);
    _r0_o = global::java.lang.reflect.Proxy.defineClassImpl((global::java.lang.ClassLoader) _r11_o, (global::java.lang.String) _r0_o, (global::org.xmlvm._nArrayAdapter<sbyte>) _r2_o);
    _r2_o = new global::java.lang.@ref.WeakReference();
    ((global::java.lang.@ref.WeakReference) _r2_o).@this((global::java.lang.Object) _r0_o);
    ((global::java.util.Map) _r3_o).put((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r2_o);
    _r2_o = global::java.lang.reflect.Proxy._fproxyCache;
    global::System.Threading.Monitor.Enter(_r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    try {
    _r3_o = global::java.lang.reflect.Proxy._fproxyCache;
    // Value=
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    ((global::java.util.Map) _r3_o).put((global::java.lang.Object) _r0_o, (global::java.lang.Object) _r4_o);
    global::System.Threading.Monitor.Exit(_r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label333;
        }
        throw ex;
    } // end catch
    label155:;
    try {
    global::System.Threading.Monitor.Exit(_r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    return (global::java.lang.Class) _r0_o;
    label157:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r0.i];
    if (_r3_o != null) goto label167;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label167:;
    _r4_o = ((global::java.lang.Class) _r3_o).getName();
    _r5.i = ((global::java.lang.Class) _r3_o).isInterface() ? 1 : 0;
    if (_r5.i != 0) goto label189;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.50
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 48))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (global::java.lang.Object) _r4_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label189:;
    _r5_o = ((global::java.lang.Class) _r3_o).getClassLoader();
    if (_r11_o == _r5_o) goto label227;
    _r5.i = 0;
    try {
    _r5_o = global::java.lang.Class.forName((global::java.lang.String) _r4_o, 0!=_r5.i, (global::java.lang.ClassLoader) _r11_o);
    if (_r3_o == _r5_o) goto label227;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.51
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 49))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (global::java.lang.Object) _r4_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label214;
        }
        throw ex;
    } // end catch
    label214:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.51
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 49))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r10_o, (global::java.lang.Object) _r4_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label227:;
    _r5.i = _r0.i + 1;
    label229:;
    if (_r5.i < _r1.i) goto label258;
    _r3.i = ((global::java.lang.Class) _r3_o).getModifiers();
    _r3.i = global::java.lang.reflect.Modifier.isPublic((int) _r3.i) ? 1 : 0;
    if (_r3.i != 0) goto label254;
    _r3.i = ((global::java.lang.String) _r4_o).lastIndexOf((int) _r9.i);
    _r5.i = -1;
    if (_r3.i != _r5.i) goto label277;
    // Value=
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {}));
    _r3_o = _r8_o;
    label251:;
    if (_r2_o != null) goto label282;
    _r2_o = _r3_o;
    label254:;
    _r0.i = _r0.i + 1;
    goto label21;
    label258:;
    _r6_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r5.i];
    if (_r3_o != _r6_o) goto label274;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.52
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 50))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o, (global::java.lang.Object) _r4_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label274:;
    _r5.i = _r5.i + 1;
    goto label229;
    label277:;
    _r3_o = ((global::java.lang.String) _r4_o).substring((int) _r7.i, (int) _r3.i);
    goto label251;
    label282:;
    _r3.i = ((global::java.lang.String) _r2_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r3.i != 0) goto label254;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.53
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 51))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label300:;
    try {
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r4.i = ((global::org.xmlvm._nIArray) _r12_o).Length;
    _r5.i = _r7.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label307:;
    try {
    if (_r5.i < _r4.i) goto label316;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    _r4_o = _r0_o;
    goto label60;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label316:;
    try {
    _r6_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r12_o)[_r5.i];
    _r6_o = ((global::java.lang.Class) _r6_o).getName();
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r6_o);
    _r6.i = 32;
    ((global::java.lang.StringBuilder) _r0_o).append((char) _r6.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    _r5.i = _r5.i + 1;
    goto label307;
    label333:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    try {
    global::System.Threading.Monitor.Exit(_r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label333;
        }
        throw ex;
    } // end catch
    try {
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label336:;
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
            goto label336;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r0_o);
    label339:;
    try {
    _r11_o = ((global::java.lang.@ref.WeakReference) _r0_o).get();
    _r11_o = _r11_o;
    _r0.i = global::java.lang.reflect.Proxy._f_2assertionsDisabled ? 1 : 0;
    if (_r0.i != 0) goto label430;
    if (_r11_o != null) goto label430;
    _r0_o = new global::java.lang.AssertionError();
    _r2_o = new global::java.lang.StringBuilder();
    // Value=\012interfaceKey=\042
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)10)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 75)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 34))}));
    ((global::java.lang.StringBuilder) _r2_o).@this((global::java.lang.String) _r5_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r4_o);
    // Value=\042
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r4_o);
    // Value=\012loaderCache=\042
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)10)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r4_o);
    _r4_o = global::java.lang.reflect.Proxy._floaderCache;
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.Object) _r4_o);
    // Value=\042
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r4_o);
    // Value=\012intfCache=\042
    _r4_o = new global::java.lang.String();
    ((global::java.lang.String)_r4_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)10)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r4_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.Object) _r3_o);
    // Value=\042
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    // Value=\012proxyCache=\042
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)10)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 61)), unchecked((char) unchecked((uint) 34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r3_o = global::java.lang.reflect.Proxy._fproxyCache;
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.Object) _r3_o);
    // Value=\042
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)34))}));
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).append((global::java.lang.String) _r3_o);
    _r2_o = ((global::java.lang.StringBuilder) _r2_o).toString();
    ((global::java.lang.AssertionError) _r0_o).@this((global::java.lang.Object) _r2_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.AssertionError) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label336;
        }
        throw ex;
    } // end catch
    label430:;
    _r0_o = _r11_o;
    goto label155;
    label433:;
    _r3_o = _r0_o;
    goto label46;
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: java.lang.Class getProxyClass(java.lang.ClassLoader, java.lang.Class[])]
}

public static global::System.Object newProxyInstance(global::java.lang.ClassLoader n1, global::org.xmlvm._nArrayAdapter<global::System.Object> n2, global::java.lang.reflect.InvocationHandler n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: java.lang.Object newProxyInstance(java.lang.ClassLoader, java.lang.Class[], java.lang.reflect.InvocationHandler)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = n1;
    _r5_o = n2;
    _r6_o = n3;
    if (_r6_o != null) goto label8;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label8:;
    try {
    _r0_o = global::java.lang.reflect.Proxy.getProxyClass((global::java.lang.ClassLoader) _r4_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r5_o);
    _r1.i = 1;
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r2.i = 0;
    _r3_o = global::org.xmlvm._nTIB.getClass(typeof(global::java.lang.reflect.InvocationHandler));
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r3_o;
    _r0_o = ((global::java.lang.Class) _r0_o).getConstructor((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    _r1.i = 1;
    _r1_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r2.i = 0;
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r2.i] = _r6_o;
    _r0_o = ((global::java.lang.reflect.Constructor) _r0_o).newInstance((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.NoSuchMethodException) {
            _ex = ex;
            goto label35;
        }
        if (_java_exception is global::java.lang.IllegalAccessException) {
            _ex = ex;
            goto label52;
        }
        if (_java_exception is global::java.lang.InstantiationException) {
            _ex = ex;
            goto label69;
        }
        if (_java_exception is global::java.lang.reflect.InvocationTargetException) {
            _ex = ex;
            goto label86;
        }
        throw ex;
    } // end catch
    return (global::java.lang.Object) _r0_o;
    label35:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.lang.InternalError();
    _r2_o = ((global::java.lang.NoSuchMethodException) _r0_o).toString();
    ((global::java.lang.InternalError) _r1_o).@this((global::java.lang.String) _r2_o);
    _r4_o = ((global::java.lang.InternalError) _r1_o).initCause((global::java.lang.Throwable) _r0_o);
    _r4_o = _r4_o;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.InternalError) _r4_o);
    label52:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.lang.InternalError();
    _r2_o = ((global::java.lang.IllegalAccessException) _r0_o).toString();
    ((global::java.lang.InternalError) _r1_o).@this((global::java.lang.String) _r2_o);
    _r4_o = ((global::java.lang.InternalError) _r1_o).initCause((global::java.lang.Throwable) _r0_o);
    _r4_o = _r4_o;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.InternalError) _r4_o);
    label69:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r1_o = new global::java.lang.InternalError();
    _r2_o = ((global::java.lang.InstantiationException) _r0_o).toString();
    ((global::java.lang.InternalError) _r1_o).@this((global::java.lang.String) _r2_o);
    _r4_o = ((global::java.lang.InternalError) _r1_o).initCause((global::java.lang.Throwable) _r0_o);
    _r4_o = _r4_o;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.InternalError) _r4_o);
    label86:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = ((global::java.lang.reflect.InvocationTargetException) _r0_o).getTargetException();
    _r1_o = new global::java.lang.InternalError();
    _r2_o = ((global::java.lang.Throwable) _r0_o).toString();
    ((global::java.lang.InternalError) _r1_o).@this((global::java.lang.String) _r2_o);
    _r4_o = ((global::java.lang.InternalError) _r1_o).initCause((global::java.lang.Throwable) _r0_o);
    _r4_o = _r4_o;
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.InternalError) _r4_o);
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: java.lang.Object newProxyInstance(java.lang.ClassLoader, java.lang.Class[], java.lang.reflect.InvocationHandler)]
}

public static bool isProxyClass(global::java.lang.Class n1){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: boolean isProxyClass(java.lang.Class)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = n1;
    if (_r2_o != null) goto label8;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label8:;
    _r0_o = global::java.lang.reflect.Proxy._fproxyCache;
    global::System.Threading.Monitor.Enter(_r0_o);
    try {
    _r1_o = global::java.lang.reflect.Proxy._fproxyCache;
    _r1.i = ((global::java.util.Map) _r1_o).containsKey((global::java.lang.Object) _r2_o) ? 1 : 0;
    global::System.Threading.Monitor.Exit(_r0_o);
    return _r1.i!=0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label19;
        }
        throw ex;
    } // end catch
    label19:;
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
            goto label19;
        }
        throw ex;
    } // end catch
    throw new global::org.xmlvm._nExceptionAdapter((global::System.Object) _r1_o);
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: boolean isProxyClass(java.lang.Class)]
}

public static global::System.Object getInvocationHandler(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: java.lang.reflect.InvocationHandler getInvocationHandler(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = n1;
    _r0_o = ((global::java.lang.Object) _r2_o).getClass();
    _r0.i = global::java.lang.reflect.Proxy.isProxyClass((global::java.lang.Class) _r0_o) ? 1 : 0;
    if (_r0.i == 0) goto label15;
    _r2_o = _r2_o;
    _r0_o = ((global::java.lang.reflect.Proxy) _r2_o)._fh;
    return (global::java.lang.reflect.InvocationHandler) _r0_o;
    label15:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    // Value=luni.54
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 46)), unchecked((char) unchecked((uint) 53)), unchecked((char) unchecked((uint) 52))}));
    _r1_o = global::org.apache.harmony.luni.@internal.nls.Messages.getString((global::java.lang.String) _r1_o);
    ((global::java.lang.IllegalArgumentException) _r0_o).@this((global::java.lang.String) _r1_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: java.lang.reflect.InvocationHandler getInvocationHandler(java.lang.Object)]
}

private static global::System.Object defineClassImpl(global::java.lang.ClassLoader n1, global::java.lang.String n2, global::org.xmlvm._nArrayAdapter<sbyte> n3){
//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy: java.lang.Class defineClassImpl(java.lang.ClassLoader, java.lang.String, byte[])]
      throw new org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy: java.lang.Class defineClassImpl(java.lang.ClassLoader, java.lang.String, byte[])]
}

//XMLVM_BEGIN_WRAPPER[java.lang.reflect.Proxy]
//XMLVM_END_WRAPPER[java.lang.reflect.Proxy]

} // end of class: Proxy

} // end of namespace: java.lang.reflect
