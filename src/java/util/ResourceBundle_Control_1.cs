// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class ResourceBundle_2Control_21: global::java.lang.Object,global::java.security.PrivilegedAction {
public global::java.util.ResourceBundle_2Control _fthis_21;

private global::java.lang.ClassLoader _fval_2clsloader;

private global::java.lang.String _fval_2bundleName;

public void @this(global::java.util.ResourceBundle_2Control n1, global::java.lang.ClassLoader n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[java.util.ResourceBundle$Control$1: void <init>(java.util.ResourceBundle$Control, java.lang.ClassLoader, java.lang.String)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::java.util.ResourceBundle_2Control_21) _r0_o)._fthis_21 = (global::java.util.ResourceBundle_2Control) _r1_o;
    ((global::java.util.ResourceBundle_2Control_21) _r0_o)._fval_2clsloader = (global::java.lang.ClassLoader) _r2_o;
    ((global::java.util.ResourceBundle_2Control_21) _r0_o)._fval_2bundleName = (global::java.lang.String) _r3_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.ResourceBundle$Control$1: void <init>(java.util.ResourceBundle$Control, java.lang.ClassLoader, java.lang.String)]
}

public virtual global::System.Object run(){
//XMLVM_BEGIN_WRAPPER[java.util.ResourceBundle$Control$1: java.lang.Class run()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r2_o = null;
    try {
    _r0_o = ((global::java.util.ResourceBundle_2Control_21) _r3_o)._fval_2clsloader;
    _r1_o = ((global::java.util.ResourceBundle_2Control_21) _r3_o)._fval_2bundleName;
    _r0_o = ((global::java.lang.ClassLoader) _r0_o).loadClass((global::java.lang.String) _r1_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label10;
        }
        if (_java_exception is global::java.lang.NoClassDefFoundError) {
            _ex = ex;
            goto label13;
        }
        throw ex;
    } // end catch
    label9:;
    return (global::java.lang.Class) _r0_o;
    label10:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r2_o;
    goto label9;
    label13:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r2_o;
    goto label9;
//XMLVM_END_WRAPPER[java.util.ResourceBundle$Control$1: java.lang.Class run()]
}

//XMLVM_BEGIN_WRAPPER[java.util.ResourceBundle$Control$1]
//XMLVM_END_WRAPPER[java.util.ResourceBundle$Control$1]

} // end of class: ResourceBundle_2Control_21

} // end of namespace: java.util
