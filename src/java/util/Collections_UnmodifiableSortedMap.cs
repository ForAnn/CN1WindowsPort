// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2UnmodifiableSortedMap: global::java.util.Collections_2UnmodifiableMap,global::java.util.SortedMap {
private static long _fserialVersionUID = -8806743815996713206L;

private global::java.util.SortedMap _fsm;

public void @this(global::java.util.SortedMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: void <init>(java.util.SortedMap)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.Collections_2UnmodifiableMap) _r0_o).@this((global::java.util.Map) _r1_o);
    ((global::java.util.Collections_2UnmodifiableSortedMap) _r0_o)._fsm = (global::java.util.SortedMap) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: void <init>(java.util.SortedMap)]
}

public virtual global::System.Object comparator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.Comparator comparator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableSortedMap) _r1_o)._fsm;
    _r0_o = ((global::java.util.SortedMap) _r0_o).comparator();
    return (global::java.util.Comparator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.Comparator comparator()]
}

public virtual global::System.Object firstKey(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.lang.Object firstKey()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableSortedMap) _r1_o)._fsm;
    _r0_o = ((global::java.util.SortedMap) _r0_o).firstKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.lang.Object firstKey()]
}

public virtual global::System.Object headMap(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.SortedMap headMap(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::java.util.Collections_2UnmodifiableSortedMap();
    _r1_o = ((global::java.util.Collections_2UnmodifiableSortedMap) _r2_o)._fsm;
    _r1_o = ((global::java.util.SortedMap) _r1_o).headMap((global::java.lang.Object) _r3_o);
    ((global::java.util.Collections_2UnmodifiableSortedMap) _r0_o).@this((global::java.util.SortedMap) _r1_o);
    return (global::java.util.SortedMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.SortedMap headMap(java.lang.Object)]
}

public virtual global::System.Object lastKey(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.lang.Object lastKey()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableSortedMap) _r1_o)._fsm;
    _r0_o = ((global::java.util.SortedMap) _r0_o).lastKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.lang.Object lastKey()]
}

public virtual global::System.Object subMap(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.SortedMap subMap(java.lang.Object, java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r4_o = n2;
    _r0_o = new global::java.util.Collections_2UnmodifiableSortedMap();
    _r1_o = ((global::java.util.Collections_2UnmodifiableSortedMap) _r2_o)._fsm;
    _r1_o = ((global::java.util.SortedMap) _r1_o).subMap((global::java.lang.Object) _r3_o, (global::java.lang.Object) _r4_o);
    ((global::java.util.Collections_2UnmodifiableSortedMap) _r0_o).@this((global::java.util.SortedMap) _r1_o);
    return (global::java.util.SortedMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.SortedMap subMap(java.lang.Object, java.lang.Object)]
}

public virtual global::System.Object tailMap(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.SortedMap tailMap(java.lang.Object)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = new global::java.util.Collections_2UnmodifiableSortedMap();
    _r1_o = ((global::java.util.Collections_2UnmodifiableSortedMap) _r2_o)._fsm;
    _r1_o = ((global::java.util.SortedMap) _r1_o).tailMap((global::java.lang.Object) _r3_o);
    ((global::java.util.Collections_2UnmodifiableSortedMap) _r0_o).@this((global::java.util.SortedMap) _r1_o);
    return (global::java.util.SortedMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap: java.util.SortedMap tailMap(java.lang.Object)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableSortedMap]
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableSortedMap]

} // end of class: Collections_2UnmodifiableSortedMap

} // end of namespace: java.util
