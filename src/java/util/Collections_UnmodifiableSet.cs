// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2UnmodifiableSet: global::java.util.Collections_2UnmodifiableCollection,global::java.util.Set {

public void @this(global::java.util.Set n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSet: void <init>(java.util.Set)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Collections_2UnmodifiableCollection) _r0_o).@this((global::java.util.Collection) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSet: void <init>(java.util.Set)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSet: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2UnmodifiableSet) _r1_o)._fc;
    _r0.i = ((global::java.util.Collection) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSet: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSet: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableSet) _r1_o)._fc;
    _r0.i = ((global::java.util.Collection) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSet: int hashCode()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSet]
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSet]

} // end of class: Collections_2UnmodifiableSet

} // end of namespace: java.util
