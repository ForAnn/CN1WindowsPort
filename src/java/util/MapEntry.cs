// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class MapEntry: global::java.lang.Object,global::java.util.Map_2Entry,global::java.lang.Cloneable {
public global::java.lang.Object _fkey;

public global::java.lang.Object _fvalue;

public void @this(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: void <init>(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.util.MapEntry) _r0_o)._fkey = (global::java.lang.Object) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.MapEntry: void <init>(java.lang.Object)]
}

public void @this(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: void <init>(java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.lang.Object) _r0_o).@this();
    ((global::java.util.MapEntry) _r0_o)._fkey = (global::java.lang.Object) _r1_o;
    ((global::java.util.MapEntry) _r0_o)._fvalue = (global::java.lang.Object) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.util.MapEntry: void <init>(java.lang.Object, java.lang.Object)]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: java.lang.Object clone()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    try {
    _r0_o = base.clone();
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.CloneNotSupportedException) {
            _ex = ex;
            goto label5;
        }
        throw ex;
    } // end catch
    label4:;
    return (global::java.lang.Object) _r0_o;
    label5:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = null;
    goto label4;
//XMLVM_END_WRAPPER[java.util.MapEntry: java.lang.Object clone()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    _r2.i = 0;
    if (_r4_o != _r5_o) goto label6;
    _r0.i = _r3.i;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.Map_2Entry)) ? 1 : 0;
    if (_r0.i == 0) goto label61;
    _r5_o = _r5_o;
    _r0_o = ((global::java.util.MapEntry) _r4_o)._fkey;
    if (_r0_o != null) goto label34;
    _r0_o = ((global::java.util.Map_2Entry) _r5_o).getKey();
    if (_r0_o != null) goto label46;
    label22:;
    _r0_o = ((global::java.util.MapEntry) _r4_o)._fvalue;
    if (_r0_o != null) goto label48;
    _r0_o = ((global::java.util.Map_2Entry) _r5_o).getValue();
    if (_r0_o != null) goto label46;
    label32:;
    _r0.i = _r3.i;
    goto label5;
    label34:;
    _r0_o = ((global::java.util.MapEntry) _r4_o)._fkey;
    _r1_o = ((global::java.util.Map_2Entry) _r5_o).getKey();
    _r0.i = ((global::java.lang.Object) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i != 0) goto label22;
    label46:;
    _r0.i = _r2.i;
    goto label5;
    label48:;
    _r0_o = ((global::java.util.MapEntry) _r4_o)._fvalue;
    _r1_o = ((global::java.util.Map_2Entry) _r5_o).getValue();
    _r0.i = ((global::java.lang.Object) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r0.i == 0) goto label46;
    goto label32;
    label61:;
    _r0.i = _r2.i;
    goto label5;
//XMLVM_END_WRAPPER[java.util.MapEntry: boolean equals(java.lang.Object)]
}

public virtual global::System.Object getKey(){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: java.lang.Object getKey()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.MapEntry) _r1_o)._fkey;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.MapEntry: java.lang.Object getKey()]
}

public virtual global::System.Object getValue(){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: java.lang.Object getValue()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.MapEntry) _r1_o)._fvalue;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.MapEntry: java.lang.Object getValue()]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r3_o = this;
    _r2.i = 0;
    _r0_o = ((global::java.util.MapEntry) _r3_o)._fkey;
    if (_r0_o != null) goto label13;
    _r0.i = _r2.i;
    label6:;
    _r1_o = ((global::java.util.MapEntry) _r3_o)._fvalue;
    if (_r1_o != null) goto label20;
    _r1.i = _r2.i;
    label11:;
    _r0.i = _r0.i ^ _r1.i;
    return _r0.i;
    label13:;
    _r0_o = ((global::java.util.MapEntry) _r3_o)._fkey;
    _r0.i = ((global::java.lang.Object) _r0_o).hashCode();
    goto label6;
    label20:;
    _r1_o = ((global::java.util.MapEntry) _r3_o)._fvalue;
    _r1.i = ((global::java.lang.Object) _r1_o).hashCode();
    goto label11;
//XMLVM_END_WRAPPER[java.util.MapEntry: int hashCode()]
}

public virtual global::System.Object setValue(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: java.lang.Object setValue(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.MapEntry) _r1_o)._fvalue;
    ((global::java.util.MapEntry) _r1_o)._fvalue = (global::java.lang.Object) _r2_o;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.MapEntry: java.lang.Object setValue(java.lang.Object)]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.util.MapEntry: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1_o = ((global::java.util.MapEntry) _r2_o)._fkey;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    // Value==
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)61))}));
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.util.MapEntry) _r2_o)._fvalue;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.Object) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.MapEntry: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[java.util.MapEntry]
//XMLVM_END_WRAPPER[java.util.MapEntry]

} // end of class: MapEntry

} // end of namespace: java.util
