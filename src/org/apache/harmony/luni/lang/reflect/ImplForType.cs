// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.lang.reflect {
public class ImplForType: global::java.lang.Object,global::java.lang.reflect.ParameterizedType {
private global::org.apache.harmony.luni.lang.reflect.ListOfTypes _fargs;

private global::org.apache.harmony.luni.lang.reflect.ImplForType _fownerType0;

private global::java.lang.reflect.Type _fownerTypeRes;

private global::java.lang.Class _frawType;

private global::java.lang.String _frawTypeName;

private global::java.lang.ClassLoader _floader;

public void @this(global::org.apache.harmony.luni.lang.reflect.ImplForType n1, global::java.lang.String n2, global::org.apache.harmony.luni.lang.reflect.ListOfTypes n3, global::java.lang.ClassLoader n4){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: void <init>(org.apache.harmony.luni.lang.reflect.ImplForType, java.lang.String, org.apache.harmony.luni.lang.reflect.ListOfTypes, java.lang.ClassLoader)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    _r4_o = n4;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r0_o)._fownerType0 = (global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o;
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r0_o)._frawTypeName = (global::java.lang.String) _r2_o;
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r0_o)._fargs = (global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r3_o;
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r0_o)._floader = (global::java.lang.ClassLoader) _r4_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: void <init>(org.apache.harmony.luni.lang.reflect.ImplForType, java.lang.String, org.apache.harmony.luni.lang.reflect.ListOfTypes, java.lang.ClassLoader)]
}

public virtual global::System.Object getActualTypeArguments(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.reflect.Type[] getActualTypeArguments()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fargs;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r0_o).getResolvedTypes();
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o).clone();
    _r1_o = _r1_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.reflect.Type[] getActualTypeArguments()]
}

public virtual global::System.Object getOwnerType(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.reflect.Type getOwnerType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fownerTypeRes;
    if (_r0_o != null) goto label16;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fownerType0;
    if (_r0_o == null) goto label19;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fownerType0;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r0_o).getResolvedType();
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fownerTypeRes = (global::java.lang.reflect.Type) _r0_o;
    label16:;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fownerTypeRes;
    return (global::java.lang.reflect.Type) _r0_o;
    label19:;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o).getRawType();
    _r0_o = ((global::java.lang.Class) _r0_o).getDeclaringClass();
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fownerTypeRes = (global::java.lang.reflect.Type) _r0_o;
    goto label16;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.reflect.Type getOwnerType()]
}

public virtual global::System.Object getRawType(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.Class getRawType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r4_o)._frawType;
    if (_r1_o != null) goto label15;
    try {
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r4_o)._frawTypeName;
    _r2.i = 0;
    _r3_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r4_o)._floader;
    _r1_o = global::java.lang.Class.forName((global::java.lang.String) _r1_o, 0!=_r2.i, (global::java.lang.ClassLoader) _r3_o);
    ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r4_o)._frawType = (global::java.lang.Class) _r1_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.ClassNotFoundException) {
            _ex = ex;
            goto label18;
        }
        throw ex;
    } // end catch
    label15:;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r4_o)._frawType;
    return (global::java.lang.Class) _r1_o;
    label18:;
    _r1_o = _ex.getJavaException();
    _ex = null;
    _r0_o = _r1_o;
    _r1_o = new global::java.lang.TypeNotPresentException();
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r4_o)._frawTypeName;
    ((global::java.lang.TypeNotPresentException) _r1_o).@this((global::java.lang.String) _r2_o, (global::java.lang.Throwable) _r0_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.TypeNotPresentException) _r1_o);
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.Class getRawType()]
}

public virtual global::System.Object getResolvedType(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.reflect.Type getResolvedType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o)._fargs;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r0_o).getResolvedTypes();
    _r0.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    if (_r0.i != 0) goto label14;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r1_o).getRawType();
    label13:;
    return (global::java.lang.reflect.Type) _r0_o;
    label14:;
    _r0_o = _r1_o;
    goto label13;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.reflect.Type getResolvedType()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.String toString()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r3_o)._frawTypeName;
    ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r3_o)._fargs;
    _r1.i = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r1_o).length();
    if (_r1.i <= 0) goto label35;
    // Value=<
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60))}));
    _r1_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForType) _r3_o)._fargs;
    _r1_o = ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.Object) _r2_o);
    // Value=>
    _r2_o = new global::java.lang.String();
    ((global::java.lang.String)_r2_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)62))}));
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.String) _r2_o);
    label35:;
    _r1_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r1_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForType]

} // end of class: ImplForType

} // end of namespace: org.apache.harmony.luni.lang.reflect
