// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.io {
public class Storage: global::java.lang.Object {
private global::com.codename1.io.CacheMap _fcache;

private static global::com.codename1.io.Storage _fINSTANCE;

private bool _fnormalizeNames;

public void @this(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::com.codename1.io.CacheMap();
    ((global::com.codename1.io.CacheMap) _r0_o).@this();
    ((global::com.codename1.io.Storage) _r1_o)._fcache = (global::com.codename1.io.CacheMap) _r0_o;
    _r0.i = 1;
    ((global::com.codename1.io.Storage) _r1_o)._fnormalizeNames = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void <init>()]
}

public virtual void setHardCacheSize(int n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void setHardCacheSize(int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::com.codename1.io.Storage) _r1_o)._fcache;
    ((global::com.codename1.io.CacheMap) _r0_o).setCacheSize((int) _r2.i);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void setHardCacheSize(int)]
}

private global::System.Object fixFileName(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: java.lang.String fixFileName(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    // Value=_
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r0.i = ((global::com.codename1.io.Storage) _r3_o)._fnormalizeNames ? 1 : 0;
    if (_r0.i == 0) goto label62;
    // Value=/
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    // Value=\134
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)92))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    // Value=%
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)37))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    // Value=?
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)63))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    // Value=*
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)42))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    // Value=:
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)58))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    // Value==
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)61))}));
    // Value=_
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)95))}));
    _r4_o = global::com.codename1.util.StringUtil.replaceAll((global::java.lang.String) _r4_o, (global::java.lang.String) _r0_o, (global::java.lang.String) _r2_o);
    label62:;
    return (global::java.lang.String) _r4_o;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: java.lang.String fixFileName(java.lang.String)]
}

private static void init(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void init(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = n1;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).setStorageData((global::java.lang.Object) _r1_o);
    _r0_o = new global::com.codename1.io.Storage();
    ((global::com.codename1.io.Storage) _r0_o).@this();
    global::com.codename1.io.Storage._fINSTANCE = (global::com.codename1.io.Storage) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void init(java.lang.Object)]
}

public static bool isInitialized(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: boolean isInitialized()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.io.Storage._fINSTANCE;
    if (_r0_o == null) goto label6;
    _r0.i = 1;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = 0;
    goto label5;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: boolean isInitialized()]
}

public static global::System.Object getInstance(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: com.codename1.io.Storage getInstance()]
    global::System.Object _r0_o = null;
    _r0_o = global::com.codename1.io.Storage._fINSTANCE;
    if (_r0_o != null) goto label9;
    // Value=cn1
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)99)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 49))}));
    global::com.codename1.io.Storage.init((global::java.lang.Object) _r0_o);
    label9:;
    _r0_o = global::com.codename1.io.Storage._fINSTANCE;
    return (global::com.codename1.io.Storage) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: com.codename1.io.Storage getInstance()]
}

public virtual void clearCache(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void clearCache()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::com.codename1.io.Storage) _r1_o)._fcache;
    ((global::com.codename1.io.CacheMap) _r0_o).clearAllCache();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void clearCache()]
}

public virtual void flushStorageCache(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void flushStorageCache()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).flushStorageCache();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void flushStorageCache()]
}

public virtual void deleteStorageFile(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void deleteStorageFile(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r2_o = ((global::com.codename1.io.Storage) _r1_o).fixFileName((global::java.lang.String) _r2_o);
    _r0_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).deleteStorageFile((global::java.lang.String) _r2_o);
    _r0_o = ((global::com.codename1.io.Storage) _r1_o)._fcache;
    ((global::com.codename1.io.CacheMap) _r0_o).delete((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void deleteStorageFile(java.lang.String)]
}

public virtual void clearStorage(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void clearStorage()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).clearStorage();
    _r0_o = ((global::com.codename1.io.Storage) _r1_o)._fcache;
    ((global::com.codename1.io.CacheMap) _r0_o).clearAllCache();
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void clearStorage()]
}

public virtual global::System.Object createOutputStream(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: java.io.OutputStream createOutputStream(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r2_o = ((global::com.codename1.io.Storage) _r1_o).fixFileName((global::java.lang.String) _r2_o);
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).createStorageOutputStream((global::java.lang.String) _r2_o);
    return (global::java.io.OutputStream) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: java.io.OutputStream createOutputStream(java.lang.String)]
}

public virtual global::System.Object createInputStream(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: java.io.InputStream createInputStream(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r2_o = ((global::com.codename1.io.Storage) _r1_o).fixFileName((global::java.lang.String) _r2_o);
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).createStorageInputStream((global::java.lang.String) _r2_o);
    return (global::java.io.InputStream) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: java.io.InputStream createInputStream(java.lang.String)]
}

public virtual bool exists(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: boolean exists(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r2_o = ((global::com.codename1.io.Storage) _r1_o).fixFileName((global::java.lang.String) _r2_o);
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r0.i = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).storageFileExists((global::java.lang.String) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: boolean exists(java.lang.String)]
}

public virtual global::System.Object listEntries(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: java.lang.String[] listEntries()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r0_o = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).listStorageEntries();
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: java.lang.String[] listEntries()]
}

public virtual int entrySize(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: int entrySize(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r2_o = ((global::com.codename1.io.Storage) _r1_o).fixFileName((global::java.lang.String) _r2_o);
    _r0_o = global::com.codename1.io.Util.getImplementation();
    _r0.i = ((global::com.codename1.impl.CodenameOneImplementation) _r0_o).getStorageEntrySize((global::java.lang.String) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: int entrySize(java.lang.String)]
}

public virtual bool writeObject(global::java.lang.String n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: boolean writeObject(java.lang.String, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r5_o = ((global::com.codename1.io.Storage) _r4_o).fixFileName((global::java.lang.String) _r5_o);
    _r3_o = ((global::com.codename1.io.Storage) _r4_o)._fcache;
    ((global::com.codename1.io.CacheMap) _r3_o).put((global::java.lang.Object) _r5_o, (global::java.lang.Object) _r6_o);
    _r0_o = null;
    try {
    _r1_o = new global::java.io.DataOutputStream();
    _r3_o = ((global::com.codename1.io.Storage) _r4_o).createOutputStream((global::java.lang.String) _r5_o);
    ((global::java.io.DataOutputStream) _r1_o).@this((global::java.io.OutputStream) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label28;
        }
        throw ex;
    } // end catch
    try {
    global::com.codename1.io.Util.writeObject((global::java.lang.Object) _r6_o, (global::java.io.DataOutputStream) _r1_o);
    ((global::java.io.DataOutputStream) _r1_o).close();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label49;
        }
        throw ex;
    } // end catch
    _r3.i = 1;
    _r0_o = _r1_o;
    label27:;
    return _r3.i!=0;
    label28:;
    _r3_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r3_o;
    label30:;
    ((global::java.lang.Exception) _r2_o).printStackTrace();
    _r3_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r3_o).deleteStorageFile((global::java.lang.String) _r5_o);
    _r3_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r3_o).cleanup((global::java.lang.Object) _r0_o);
    _r3.i = 0;
    goto label27;
    label49:;
    _r3_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r3_o;
    _r0_o = _r1_o;
    goto label30;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: boolean writeObject(java.lang.String, java.lang.Object)]
}

public virtual global::System.Object readObject(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: java.lang.Object readObject(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r5_o = null;
    _r7_o = ((global::com.codename1.io.Storage) _r6_o).fixFileName((global::java.lang.String) _r7_o);
    _r4_o = ((global::com.codename1.io.Storage) _r6_o)._fcache;
    _r3_o = ((global::com.codename1.io.CacheMap) _r4_o).get((global::java.lang.Object) _r7_o);
    if (_r3_o == null) goto label15;
    _r4_o = _r3_o;
    label14:;
    return (global::java.lang.Object) _r4_o;
    label15:;
    _r0_o = null;
    try {
    _r4.i = ((global::com.codename1.io.Storage) _r6_o).exists((global::java.lang.String) _r7_o) ? 1 : 0;
    if (_r4.i != 0) goto label24;
    _r4_o = _r5_o;
    goto label14;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label47;
        }
        throw ex;
    } // end catch
    label24:;
    try {
    _r1_o = new global::java.io.DataInputStream();
    _r4_o = ((global::com.codename1.io.Storage) _r6_o).createInputStream((global::java.lang.String) _r7_o);
    ((global::java.io.DataInputStream) _r1_o).@this((global::java.io.InputStream) _r4_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label47;
        }
        throw ex;
    } // end catch
    try {
    _r3_o = global::com.codename1.io.Util.readObject((global::java.io.DataInputStream) _r1_o);
    ((global::java.io.DataInputStream) _r1_o).close();
    _r4_o = ((global::com.codename1.io.Storage) _r6_o)._fcache;
    ((global::com.codename1.io.CacheMap) _r4_o).put((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r3_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label61;
        }
        throw ex;
    } // end catch
    _r4_o = _r3_o;
    goto label14;
    label47:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r4_o;
    label49:;
    ((global::java.lang.Exception) _r2_o).printStackTrace();
    _r4_o = global::com.codename1.io.Util.getImplementation();
    ((global::com.codename1.impl.CodenameOneImplementation) _r4_o).cleanup((global::java.lang.Object) _r0_o);
    _r4_o = _r5_o;
    goto label14;
    label61:;
    _r4_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r4_o;
    _r0_o = _r1_o;
    goto label49;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: java.lang.Object readObject(java.lang.String)]
}

public virtual bool isNormalizeNames(){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: boolean isNormalizeNames()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::com.codename1.io.Storage) _r1_o)._fnormalizeNames ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: boolean isNormalizeNames()]
}

public virtual void setNormalizeNames(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage: void setNormalizeNames(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::com.codename1.io.Storage) _r0_o)._fnormalizeNames = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.io.Storage: void setNormalizeNames(boolean)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.io.Storage]
//XMLVM_END_WRAPPER[com.codename1.io.Storage]

} // end of class: Storage

} // end of namespace: com.codename1.io
