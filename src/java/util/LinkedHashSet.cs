// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class LinkedHashSet: global::java.util.HashSet,global::java.util.Set,global::java.lang.Cloneable,global::java.io.Serializable {
private static long _fserialVersionUID = -2851667679971038690L;

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashSet: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this();
    ((global::java.util.HashSet) _r1_o).@this((global::java.util.HashMap) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.util.LinkedHashSet: void <init>()]
}

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashSet: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this((int) _r2.i);
    ((global::java.util.HashSet) _r1_o).@this((global::java.util.HashMap) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.util.LinkedHashSet: void <init>(int)]
}

public void @this(int n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashSet: void <init>(int, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3.f = n2;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this((int) _r2.i, (float) _r3.f);
    ((global::java.util.HashSet) _r1_o).@this((global::java.util.HashMap) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.util.LinkedHashSet: void <init>(int, float)]
}

public void @this(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashSet: void <init>(java.util.Collection)]
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
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::java.util.LinkedHashMap();
    _r1.i = ((global::java.util.Collection) _r4_o).size();
    _r2.i = 6;
    if (_r1.i >= _r2.i) goto label28;
    _r1.i = 11;
    label11:;
    ((global::java.util.LinkedHashMap) _r0_o).@this((int) _r1.i);
    ((global::java.util.HashSet) _r3_o).@this((global::java.util.HashMap) _r0_o);
    _r1_o = ((global::java.util.Collection) _r4_o).iterator();
    label21:;
    _r0.i = ((global::java.util.Iterator) _r1_o).hasNext() ? 1 : 0;
    if (_r0.i != 0) goto label35;
    return;
    label28:;
    _r1.i = ((global::java.util.Collection) _r4_o).size();
    _r1.i = _r1.i * 2;
    goto label11;
    label35:;
    _r0_o = ((global::java.util.Iterator) _r1_o).next();
    _r0_o = _r0_o;
    ((global::java.util.LinkedHashSet) _r3_o).add((global::java.lang.Object) _r0_o);
    goto label21;
//XMLVM_END_WRAPPER[java.util.LinkedHashSet: void <init>(java.util.Collection)]
}

public override global::System.Object createBackingMap(int n1, float n2){
//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashSet: java.util.HashMap createBackingMap(int, float)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r3.f = n2;
    _r0_o = new global::java.util.LinkedHashMap();
    ((global::java.util.LinkedHashMap) _r0_o).@this((int) _r2.i, (float) _r3.f);
    return (global::java.util.HashMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.LinkedHashSet: java.util.HashMap createBackingMap(int, float)]
}

//XMLVM_BEGIN_WRAPPER[java.util.LinkedHashSet]
//XMLVM_END_WRAPPER[java.util.LinkedHashSet]

} // end of class: LinkedHashSet

} // end of namespace: java.util
