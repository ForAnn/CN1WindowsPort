// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2CheckedSortedSet: global::java.util.Collections_2CheckedSet,global::java.util.SortedSet {

private global::java.util.SortedSet _fss;

public void @this(global::java.util.SortedSet n1, global::java.lang.Class n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: void <init>(java.util.SortedSet, java.lang.Class)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.Collections_2CheckedSet) _r0_o).@this((global::java.util.Set) _r1_o, (global::java.lang.Class) _r2_o);
    ((global::java.util.Collections_2CheckedSortedSet) _r0_o)._fss = (global::java.util.SortedSet) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: void <init>(java.util.SortedSet, java.lang.Class)]
}

public virtual global::System.Object comparator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.Comparator comparator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedSortedSet) _r1_o)._fss;
    _r0_o = ((global::java.util.SortedSet) _r0_o).comparator();
    return (global::java.util.Comparator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.Comparator comparator()]
}

public virtual global::System.Object subSet(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.SortedSet subSet(java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r5_o = n2;
    _r0_o = new global::java.util.Collections_2CheckedSortedSet();
    _r1_o = ((global::java.util.Collections_2CheckedSortedSet) _r3_o)._fss;
    _r1_o = ((global::java.util.SortedSet) _r1_o).subSet((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r5_o);
    _r2_o = ((global::java.util.Collections_2CheckedSortedSet) _r3_o)._ftype;
    ((global::java.util.Collections_2CheckedSortedSet) _r0_o).@this((global::java.util.SortedSet) _r1_o, (global::java.lang.Class) _r2_o);
    return (global::java.util.SortedSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.SortedSet subSet(java.lang.Object, java.lang.Object)]
}

public virtual global::System.Object headSet(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.SortedSet headSet(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::java.util.Collections_2CheckedSortedSet();
    _r1_o = ((global::java.util.Collections_2CheckedSortedSet) _r3_o)._fss;
    _r1_o = ((global::java.util.SortedSet) _r1_o).headSet((global::java.lang.Object) _r4_o);
    _r2_o = ((global::java.util.Collections_2CheckedSortedSet) _r3_o)._ftype;
    ((global::java.util.Collections_2CheckedSortedSet) _r0_o).@this((global::java.util.SortedSet) _r1_o, (global::java.lang.Class) _r2_o);
    return (global::java.util.SortedSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.SortedSet headSet(java.lang.Object)]
}

public virtual global::System.Object tailSet(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.SortedSet tailSet(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r3_o = this;
    _r4_o = n1;
    _r0_o = new global::java.util.Collections_2CheckedSortedSet();
    _r1_o = ((global::java.util.Collections_2CheckedSortedSet) _r3_o)._fss;
    _r1_o = ((global::java.util.SortedSet) _r1_o).tailSet((global::java.lang.Object) _r4_o);
    _r2_o = ((global::java.util.Collections_2CheckedSortedSet) _r3_o)._ftype;
    ((global::java.util.Collections_2CheckedSortedSet) _r0_o).@this((global::java.util.SortedSet) _r1_o, (global::java.lang.Class) _r2_o);
    return (global::java.util.SortedSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: java.util.SortedSet tailSet(java.lang.Object)]
}

public virtual global::System.Object first(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: java.lang.Object first()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedSortedSet) _r1_o)._fss;
    _r0_o = ((global::java.util.SortedSet) _r0_o).first();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: java.lang.Object first()]
}

public virtual global::System.Object last(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet: java.lang.Object last()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedSortedSet) _r1_o)._fss;
    _r0_o = ((global::java.util.SortedSet) _r0_o).last();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet: java.lang.Object last()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedSet]
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedSet]

} // end of class: Collections_2CheckedSortedSet

} // end of namespace: java.util
