// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.io {
public class ObjectStreamClass_21: global::java.lang.Object,global::java.util.Comparator {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamClass$1: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.io.ObjectStreamClass$1: void <init>()]
}

public virtual int compare(global::java.lang.Class n1, global::java.lang.Class n2){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamClass$1: int compare(java.lang.Class, java.lang.Class)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = ((global::java.lang.Class) _r3_o).getName();
    _r1_o = ((global::java.lang.Class) _r4_o).getName();
    _r0.i = ((global::java.lang.String) _r0_o).compareTo((global::java.lang.String) _r1_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.ObjectStreamClass$1: int compare(java.lang.Class, java.lang.Class)]
}

public virtual int compare(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamClass$1: int compare(java.lang.Object, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r2_o = _r2_o;
    _r3_o = _r3_o;
    _r0.i = ((global::java.io.ObjectStreamClass_21) _r1_o).compare((global::java.lang.Class) _r2_o, (global::java.lang.Class) _r3_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.io.ObjectStreamClass$1: int compare(java.lang.Object, java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.io.ObjectStreamClass$1]
//XMLVM_END_WRAPPER[java.io.ObjectStreamClass$1]

} // end of class: ObjectStreamClass_21

} // end of namespace: java.io
