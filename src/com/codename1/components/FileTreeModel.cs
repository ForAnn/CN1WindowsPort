// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.components {
public class FileTreeModel: global::java.lang.Object,global::com.codename1.ui.tree.TreeModel {
private bool _fshowFiles;

private global::java.util.Vector _fext;

public void @this(bool n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.FileTreeModel: void <init>(boolean)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1 ? 1 : 0;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::com.codename1.components.FileTreeModel) _r0_o)._fshowFiles = 0!=_r1.i;
    return;
//XMLVM_END_WRAPPER[com.codename1.components.FileTreeModel: void <init>(boolean)]
}

public virtual void addExtensionFilter(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.FileTreeModel: void addExtensionFilter(java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::com.codename1.components.FileTreeModel) _r1_o)._fext;
    if (_r0_o != null) goto label11;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    ((global::com.codename1.components.FileTreeModel) _r1_o)._fext = (global::java.util.Vector) _r0_o;
    label11:;
    _r0_o = ((global::com.codename1.components.FileTreeModel) _r1_o)._fext;
    ((global::java.util.Vector) _r0_o).addElement((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.components.FileTreeModel: void addExtensionFilter(java.lang.String)]
}

public virtual global::System.Object getChildren(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.FileTreeModel: java.util.Vector getChildren(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    global::System.Object _r8_o = null;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::System.Object _r12_o = null;
    global::System.Object _r13_o = null;
    global::System.Object _r14_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r13_o = this;
    _r14_o = n1;
    // Value=/
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r8_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r8_o).@this();
    if (_r14_o != null) goto label29;
    try {
    _r10_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r9_o = ((global::com.codename1.io.FileSystemStorage) _r10_o).getRoots();
    _r5.i = 0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label18:;
    try {
    _r10.i = ((global::org.xmlvm._nIArray) _r9_o).Length;
    if (_r5.i >= _r10.i) goto label250;
    _r10_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r9_o)[_r5.i];
    ((global::java.util.Vector) _r8_o).addElement((global::java.lang.Object) _r10_o);
    _r5.i = _r5.i + 1;
    goto label18;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label29:;
    try {
    _r0_o = _r14_o;
    _r0_o = _r0_o;
    _r6_o = _r0_o;
    // Value=/
    _r10_o = new global::java.lang.String();
    ((global::java.lang.String)_r10_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r10.i = ((global::java.lang.String) _r6_o).endsWith((global::java.lang.String) _r10_o) ? 1 : 0;
    if (_r10.i != 0) goto label60;
    _r10_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r10_o).@this();
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r6_o);
    // Value=/
    _r11_o = new global::java.lang.String();
    ((global::java.lang.String)_r11_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)47))}));
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r11_o);
    _r6_o = ((global::java.lang.StringBuilder) _r10_o).toString();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label60:;
    try {
    _r10_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r7_o = ((global::com.codename1.io.FileSystemStorage) _r10_o).listFiles((global::java.lang.String) _r6_o);
    if (_r7_o == null) goto label250;
    _r10.i = ((global::com.codename1.components.FileTreeModel) _r13_o)._fshowFiles ? 1 : 0;
    if (_r10.i == 0) goto label192;
    _r5.i = 0;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label75:;
    try {
    _r10.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r5.i >= _r10.i) goto label250;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r5.i];
    _r10_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r11_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r11_o).@this();
    _r11_o = ((global::java.lang.StringBuilder) _r11_o).append((global::java.lang.String) _r6_o);
    _r11_o = ((global::java.lang.StringBuilder) _r11_o).append((global::java.lang.String) _r3_o);
    _r11_o = ((global::java.lang.StringBuilder) _r11_o).toString();
    _r10.i = ((global::com.codename1.io.FileSystemStorage) _r10_o).isDirectory((global::java.lang.String) _r11_o) ? 1 : 0;
    if (_r10.i != 0) goto label160;
    _r10_o = ((global::com.codename1.components.FileTreeModel) _r13_o)._fext;
    if (_r10_o == null) goto label160;
    _r10.i = 46;
    _r4.i = ((global::java.lang.String) _r3_o).lastIndexOf((int) _r10.i);
    if (_r4.i <= 0) goto label157;
    _r10.i = _r4.i + 1;
    _r11.i = ((global::java.lang.String) _r3_o).length();
    _r1_o = ((global::java.lang.String) _r3_o).substring((int) _r10.i, (int) _r11.i);
    _r10_o = ((global::com.codename1.components.FileTreeModel) _r13_o)._fext;
    _r10.i = ((global::java.util.Vector) _r10_o).contains((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r10.i == 0) goto label157;
    _r10_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r10_o).@this();
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r6_o);
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r3_o);
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).toString();
    ((global::java.util.Vector) _r8_o).addElement((global::java.lang.Object) _r10_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label157:;
    try {
    _r5.i = _r5.i + 1;
    goto label75;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label160:;
    try {
    _r10_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r10_o).@this();
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r6_o);
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r3_o);
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).toString();
    ((global::java.util.Vector) _r8_o).addElement((global::java.lang.Object) _r10_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    goto label157;
    label181:;
    _r10_o = _ex.getJavaException();
    _ex = null;
    _r2_o = _r10_o;
    ((global::java.lang.Throwable) _r2_o).printStackTrace();
    _r10_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r10_o).@this();
    label191:;
    return (global::java.util.Vector) _r10_o;
    label192:;
    _r5.i = 0;
    label193:;
    try {
    _r10.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    if (_r5.i >= _r10.i) goto label250;
    _r10_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r11_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r11_o).@this();
    _r11_o = ((global::java.lang.StringBuilder) _r11_o).append((global::java.lang.String) _r6_o);
    _r12_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r5.i];
    _r11_o = ((global::java.lang.StringBuilder) _r11_o).append((global::java.lang.String) _r12_o);
    _r11_o = ((global::java.lang.StringBuilder) _r11_o).toString();
    _r10.i = ((global::com.codename1.io.FileSystemStorage) _r10_o).isDirectory((global::java.lang.String) _r11_o) ? 1 : 0;
    if (_r10.i == 0) goto label247;
    _r10_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r10_o).@this();
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r6_o);
    _r11_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r7_o)[_r5.i];
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).append((global::java.lang.String) _r11_o);
    _r10_o = ((global::java.lang.StringBuilder) _r10_o).toString();
    ((global::java.util.Vector) _r8_o).addElement((global::java.lang.Object) _r10_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Throwable) {
            _ex = ex;
            goto label181;
        }
        throw ex;
    } // end catch
    label247:;
    _r5.i = _r5.i + 1;
    goto label193;
    label250:;
    _r10_o = _r8_o;
    goto label191;
//XMLVM_END_WRAPPER[com.codename1.components.FileTreeModel: java.util.Vector getChildren(java.lang.Object)]
}

public virtual bool isLeaf(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.components.FileTreeModel: boolean isLeaf(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = global::com.codename1.io.FileSystemStorage.getInstance();
    _r2_o = _r2_o;
    _r0.i = ((global::com.codename1.io.FileSystemStorage) _r0_o).isDirectory((global::java.lang.String) _r2_o) ? 1 : 0;
    if (_r0.i != 0) goto label14;
    _r0.i = 1;
    label13:;
    return _r0.i!=0;
    label14:;
    _r0.i = 0;
    goto label13;
//XMLVM_END_WRAPPER[com.codename1.components.FileTreeModel: boolean isLeaf(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.components.FileTreeModel]
//XMLVM_END_WRAPPER[com.codename1.components.FileTreeModel]

} // end of class: FileTreeModel

} // end of namespace: com.codename1.components
