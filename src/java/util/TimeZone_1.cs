// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TimeZone_21: global::java.lang.Object,global::java.security.PrivilegedAction {
private global::java.lang.Object _fval_2icuTZ;

public void @this(global::org.xmlvm.runtime.RedTypeMarker n1){
//XMLVM_BEGIN_WRAPPER[java.util.TimeZone$1: void <init>(com.ibm.icu.util.TimeZone)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.TimeZone_21) _r0_o)._fval_2icuTZ = (global::org.xmlvm.runtime.RedTypeMarker) _r1_o;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.TimeZone$1: void <init>(com.ibm.icu.util.TimeZone)]
}

public virtual global::System.Object run(){
//XMLVM_BEGIN_WRAPPER[java.util.TimeZone$1: java.lang.reflect.Field run()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    // Value=defaultZone
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 90)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    try {
// Red class access removed: com.ibm.icu.util.TimeZone const-class
throw new global::org.xmlvm._nNotYetImplementedException("Red class access removed: com.ibm.icu.util.TimeZone const-class");
    // Value=defaultZone
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 90)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    _r0_o = ((global::java.lang.Class) _r0_o).getDeclaredField((global::java.lang.String) _r1_o);
    _r1.i = 1;
    ((global::java.lang.reflect.Field) _r0_o).setAccessible(0!=_r1.i);
    // Value=defaultZone
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 102)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 90)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 101))}));
    _r2_o = ((global::java.util.TimeZone_21) _r3_o)._fval_2icuTZ;
    ((global::java.lang.reflect.Field) _r0_o).set((global::java.lang.Object) _r1_o, (global::java.lang.Object) _r2_o);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.Exception) {
            _ex = ex;
            goto label22;
        }
        throw ex;
    } // end catch
    label21:;
    return (global::java.lang.reflect.Field) _r0_o;
    label22:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = null;
    goto label21;
//XMLVM_END_WRAPPER[java.util.TimeZone$1: java.lang.reflect.Field run()]
}

//XMLVM_BEGIN_WRAPPER[java.util.TimeZone$1]
//XMLVM_END_WRAPPER[java.util.TimeZone$1]

} // end of class: TimeZone_21

} // end of namespace: java.util
