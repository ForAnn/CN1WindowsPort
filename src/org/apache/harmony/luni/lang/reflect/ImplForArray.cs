// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.lang.reflect {
public class ImplForArray: global::java.lang.Object,global::java.lang.reflect.GenericArrayType {
private global::java.lang.reflect.Type _fcomponentType;

public void @this(global::java.lang.reflect.Type n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray: void <init>(java.lang.reflect.Type)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::org.apache.harmony.luni.lang.reflect.ImplForArray) _r0_o)._fcomponentType = (global::java.lang.reflect.Type) _r1_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray: void <init>(java.lang.reflect.Type)]
}

public virtual global::System.Object getGenericComponentType(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray: java.lang.reflect.Type getGenericComponentType()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    try {
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForArray) _r2_o)._fcomponentType;
    _r1_o = _r1_o;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o).getResolvedType();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassCastException) {
            _ex = ex;
            goto label9;
        }
        throw ex;
    } // end catch
    label8:;
    return (global::java.lang.reflect.Type) _r1_o;
    label9:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r1_o;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForArray) _r2_o)._fcomponentType;
    goto label8;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray: java.lang.reflect.Type getGenericComponentType()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForArray) _r2_o)._fcomponentType;
    _r1_o = ((global::java.lang.Object) _r1_o).toString();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    // Value=[]
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)91)), unchecked((char) unchecked((uint) 93))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForArray]

} // end of class: ImplForArray

} // end of namespace: org.apache.harmony.luni.lang.reflect
