// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2ReverseComparator: global::java.lang.Object,global::java.util.Comparator,global::java.io.Serializable {

static Collections_2ReverseComparator() {
    @static();
}

private static global::java.util.Collections_2ReverseComparator _fINSTANCE;

private static long _fserialVersionUID = 7207038068494060240L;

public static void @static(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$ReverseComparator: void <clinit>()]
    global::System.Object _r0_o = null;
    _r0_o = new global::java.util.Collections_2ReverseComparator();
    ((global::java.util.Collections_2ReverseComparator) _r0_o).@this();
    global::java.util.Collections_2ReverseComparator._fINSTANCE = (global::java.util.Collections_2ReverseComparator) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$ReverseComparator: void <clinit>()]
}

private void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$ReverseComparator: void <init>()]
    global::System.Object _r0_o = null;
    _r0_o = this;
    ((global::java.lang.Object) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$ReverseComparator: void <init>()]
}

public virtual int compare(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$ReverseComparator: int compare(java.lang.Object, java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r3_o = _r3_o;
    _r0.i = ((global::java.lang.Comparable) _r3_o).compareTo((global::java.lang.Object) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$ReverseComparator: int compare(java.lang.Object, java.lang.Object)]
}

private global::System.Object readResolve(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$ReverseComparator: java.lang.Object readResolve()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = global::java.util.Collections_2ReverseComparator._fINSTANCE;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$ReverseComparator: java.lang.Object readResolve()]
}

public static global::System.Object access_20(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$ReverseComparator: java.util.Collections$ReverseComparator access$0()]
    global::System.Object _r0_o = null;
    _r0_o = global::java.util.Collections_2ReverseComparator._fINSTANCE;
    return (global::java.util.Collections_2ReverseComparator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$ReverseComparator: java.util.Collections$ReverseComparator access$0()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$ReverseComparator]
//XMLVM_END_WRAPPER[java.util.Collections$ReverseComparator]

} // end of class: Collections_2ReverseComparator

} // end of namespace: java.util
