// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2CheckedSortedMap: global::java.util.Collections_2CheckedMap,global::java.util.SortedMap {
private static long _fserialVersionUID = 1599671320688067438L;

public global::java.util.SortedMap _fsm;

public void @this(global::java.util.SortedMap n1, global::java.lang.Class n2, global::java.lang.Class n3){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: void <init>(java.util.SortedMap, java.lang.Class, java.lang.Class)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = null;
    ((global::java.util.Collections_2CheckedMap) _r1_o).@this((global::java.util.Map) _r2_o, (global::java.lang.Class) _r3_o, (global::java.lang.Class) _r4_o, (global::java.util.Collections_2CheckedMap) _r0_o);
    ((global::java.util.Collections_2CheckedSortedMap) _r1_o)._fsm = (global::java.util.SortedMap) _r2_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: void <init>(java.util.SortedMap, java.lang.Class, java.lang.Class)]
}

public virtual global::System.Object comparator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.Comparator comparator()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedSortedMap) _r1_o)._fsm;
    _r0_o = ((global::java.util.SortedMap) _r0_o).comparator();
    return (global::java.util.Comparator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.Comparator comparator()]
}

public virtual global::System.Object subMap(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.SortedMap subMap(java.lang.Object, java.lang.Object)]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nElement _r6;
    global::System.Object _r6_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r0_o = new global::java.util.Collections_2CheckedSortedMap();
    _r1_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fsm;
    _r1_o = ((global::java.util.SortedMap) _r1_o).subMap((global::java.lang.Object) _r5_o, (global::java.lang.Object) _r6_o);
    _r2_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fkeyType;
    _r3_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fvalueType;
    ((global::java.util.Collections_2CheckedSortedMap) _r0_o).@this((global::java.util.SortedMap) _r1_o, (global::java.lang.Class) _r2_o, (global::java.lang.Class) _r3_o);
    return (global::java.util.SortedMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.SortedMap subMap(java.lang.Object, java.lang.Object)]
}

public virtual global::System.Object headMap(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.SortedMap headMap(java.lang.Object)]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = new global::java.util.Collections_2CheckedSortedMap();
    _r1_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fsm;
    _r1_o = ((global::java.util.SortedMap) _r1_o).headMap((global::java.lang.Object) _r5_o);
    _r2_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fkeyType;
    _r3_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fvalueType;
    ((global::java.util.Collections_2CheckedSortedMap) _r0_o).@this((global::java.util.SortedMap) _r1_o, (global::java.lang.Class) _r2_o, (global::java.lang.Class) _r3_o);
    return (global::java.util.SortedMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.SortedMap headMap(java.lang.Object)]
}

public virtual global::System.Object tailMap(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.SortedMap tailMap(java.lang.Object)]
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
    global::org.xmlvm._nElement _r5;
    global::System.Object _r5_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5_o = n1;
    _r0_o = new global::java.util.Collections_2CheckedSortedMap();
    _r1_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fsm;
    _r1_o = ((global::java.util.SortedMap) _r1_o).tailMap((global::java.lang.Object) _r5_o);
    _r2_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fkeyType;
    _r3_o = ((global::java.util.Collections_2CheckedSortedMap) _r4_o)._fvalueType;
    ((global::java.util.Collections_2CheckedSortedMap) _r0_o).@this((global::java.util.SortedMap) _r1_o, (global::java.lang.Class) _r2_o, (global::java.lang.Class) _r3_o);
    return (global::java.util.SortedMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: java.util.SortedMap tailMap(java.lang.Object)]
}

public virtual global::System.Object firstKey(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: java.lang.Object firstKey()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedSortedMap) _r1_o)._fsm;
    _r0_o = ((global::java.util.SortedMap) _r0_o).firstKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: java.lang.Object firstKey()]
}

public virtual global::System.Object lastKey(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap: java.lang.Object lastKey()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedSortedMap) _r1_o)._fsm;
    _r0_o = ((global::java.util.SortedMap) _r0_o).lastKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap: java.lang.Object lastKey()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedSortedMap]
//XMLVM_END_WRAPPER[java.util.Collections$CheckedSortedMap]

} // end of class: Collections_2CheckedSortedMap

} // end of namespace: java.util
