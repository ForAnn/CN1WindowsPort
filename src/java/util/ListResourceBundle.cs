// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public abstract class ListResourceBundle: global::java.util.ResourceBundle {
public global::java.util.HashMap _ftable;

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.ListResourceBundle: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.util.ResourceBundle) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.ListResourceBundle: void <init>()]
}

public abstract global::System.Object getContents();

public override global::System.Object getKeys(){
//XMLVM_BEGIN_WRAPPER[java.util.ListResourceBundle: java.util.Enumeration getKeys()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.ListResourceBundle) _r1_o).initializeTable();
    _r0_o = ((global::java.util.ListResourceBundle) _r1_o)._fparent;
    if (_r0_o == null) goto label13;
    _r0_o = new global::java.util.ListResourceBundle_21();
    ((global::java.util.ListResourceBundle_21) _r0_o).@this((global::java.util.ListResourceBundle) _r1_o);
    label12:;
    return (global::java.util.Enumeration) _r0_o;
    label13:;
    _r0_o = new global::java.util.ListResourceBundle_22();
    ((global::java.util.ListResourceBundle_22) _r0_o).@this((global::java.util.ListResourceBundle) _r1_o);
    goto label12;
//XMLVM_END_WRAPPER[java.util.ListResourceBundle: java.util.Enumeration getKeys()]
}

public override global::System.Object handleGetObject(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[java.util.ListResourceBundle: java.lang.Object handleGetObject(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.ListResourceBundle) _r1_o).initializeTable();
    if (_r2_o != null) goto label11;
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    label11:;
    _r0_o = ((global::java.util.ListResourceBundle) _r1_o)._ftable;
    _r0_o = ((global::java.util.HashMap) _r0_o).get((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.ListResourceBundle: java.lang.Object handleGetObject(java.lang.String)]
}

private void initializeTable(){
//XMLVM_BEGIN_WRAPPER[java.util.ListResourceBundle: void initializeTable()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r3.i = 0;
    global::System.Threading.Monitor.Enter(_r7_o);
    try {
    _r0_o = ((global::java.util.ListResourceBundle) _r7_o)._ftable;
    if (_r0_o != null) goto label27;
    _r1_o = ((global::java.util.ListResourceBundle) _r7_o).getContents();
    _r0_o = new global::java.util.HashMap();
    _r2.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    _r2.i = _r2.i / 3;
    _r2.i = _r2.i * 4;
    _r2.i = _r2.i + 3;
    ((global::java.util.HashMap) _r0_o).@this((int) _r2.i);
    ((global::java.util.ListResourceBundle) _r7_o)._ftable = (global::java.util.HashMap) _r0_o;
    _r2.i = ((global::org.xmlvm._nIArray) _r1_o).Length;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label47;
        }
        throw ex;
    } // end catch
    label25:;
    if (_r3.i < _r2.i) goto label29;
    label27:;
    global::System.Threading.Monitor.Exit(_r7_o);
    return;
    label29:;
    try {
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o)[_r3.i];
    _r0.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    if (_r0_o == null) goto label41;
    _r0.i = 1;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    if (_r0_o != null) goto label50;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label47;
        }
        throw ex;
    } // end catch
    label41:;
    try {
    _r0_o = new global::java.lang.NullPointerException();
    ((global::java.lang.NullPointerException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.NullPointerException) _r0_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label47;
        }
        throw ex;
    } // end catch
    label47:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    global::System.Threading.Monitor.Exit(_r7_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.Throwable) _r0_o);
    label50:;
    try {
    _r5_o = ((global::java.util.ListResourceBundle) _r7_o)._ftable;
    _r0.i = 0;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r0.i];
    _r0_o = _r0_o;
    _r6.i = 1;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r4_o)[_r6.i];
    ((global::java.util.HashMap) _r5_o).put((global::java.lang.Object) _r0_o, (global::java.lang.Object) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Object) {
            _ex = ex;
            goto label47;
        }
        throw ex;
    } // end catch
    _r0.i = _r3.i + 1;
    _r3.i = _r0.i;
    goto label25;
//XMLVM_END_WRAPPER[java.util.ListResourceBundle: void initializeTable()]
}

public override global::System.Object handleKeySet(){
//XMLVM_BEGIN_WRAPPER[java.util.ListResourceBundle: java.util.Set handleKeySet()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.util.ListResourceBundle) _r1_o).initializeTable();
    _r0_o = ((global::java.util.ListResourceBundle) _r1_o)._ftable;
    _r0_o = ((global::java.util.HashMap) _r0_o).keySet();
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.ListResourceBundle: java.util.Set handleKeySet()]
}

//XMLVM_BEGIN_WRAPPER[java.util.ListResourceBundle]
//XMLVM_END_WRAPPER[java.util.ListResourceBundle]

} // end of class: ListResourceBundle

} // end of namespace: java.util
