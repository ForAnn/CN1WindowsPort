// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2CopiesList: global::java.util.AbstractList,global::java.io.Serializable {

private int _fn;

private global::java.lang.Object _felement;

public void @this(int n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CopiesList: void <init>(int, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    ((global::java.util.AbstractList) _r1_o).@this();
    if (_r2.i >= 0) goto label11;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label11:;
    ((global::java.util.Collections_2CopiesList) _r1_o)._fn = _r2.i;
    ((global::java.util.Collections_2CopiesList) _r1_o)._felement = (global::java.lang.Object) _r3_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$CopiesList: void <init>(int, java.lang.Object)]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CopiesList: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2CopiesList) _r1_o)._felement;
    if (_r0_o != null) goto label10;
    if (_r2_o != null) goto label8;
    _r0.i = 1;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = 0;
    goto label7;
    label10:;
    _r0_o = ((global::java.util.Collections_2CopiesList) _r1_o)._felement;
    _r0.i = ((global::java.lang.Object) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    goto label7;
//XMLVM_END_WRAPPER[java.util.Collections$CopiesList: boolean contains(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CopiesList: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.Collections_2CopiesList) _r1_o)._fn;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$CopiesList: int size()]
}

public override global::System.Object get(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CopiesList: java.lang.Object get(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    if (_r2.i < 0) goto label9;
    _r0.i = ((global::java.util.Collections_2CopiesList) _r1_o)._fn;
    if (_r2.i >= _r0.i) goto label9;
    _r0_o = ((global::java.util.Collections_2CopiesList) _r1_o)._felement;
    return (global::java.lang.Object) _r0_o;
    label9:;
    _r0_o = new global::java.lang.IndexOutOfBoundsException();
    ((global::java.lang.IndexOutOfBoundsException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IndexOutOfBoundsException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$CopiesList: java.lang.Object get(int)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$CopiesList]
//XMLVM_END_WRAPPER[java.util.Collections$CopiesList]

} // end of class: Collections_2CopiesList

} // end of namespace: java.util
