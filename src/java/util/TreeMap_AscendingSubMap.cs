// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeMap_2AscendingSubMap: global::java.util.TreeMap_2NavigableSubMap,global::java.io.Serializable {
private static long _fserialVersionUID = 912986545866124060L;

public void @this(global::java.lang.Object n1, bool n2, global::java.util.TreeMap n3, global::java.lang.Object n4, bool n5){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.lang.Object, boolean, java.util.TreeMap, java.lang.Object, boolean)]
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
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    _r3_o = n3;
    _r4_o = n4;
    _r5.i = n5 ? 1 : 0;
    ((global::java.util.TreeMap_2NavigableSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o, (global::java.lang.Object) _r4_o, 0!=_r5.i);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.lang.Object, boolean, java.util.TreeMap, java.lang.Object, boolean)]
}

public void @this(global::java.util.TreeMap n1, global::java.lang.Object n2, bool n3){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.util.TreeMap, java.lang.Object, boolean)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3 ? 1 : 0;
    ((global::java.util.TreeMap_2NavigableSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o, (global::java.lang.Object) _r2_o, 0!=_r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.util.TreeMap, java.lang.Object, boolean)]
}

public void @this(global::java.lang.Object n1, bool n2, global::java.util.TreeMap n3){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.lang.Object, boolean, java.util.TreeMap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2 ? 1 : 0;
    _r3_o = n3;
    ((global::java.util.TreeMap_2NavigableSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.lang.Object, boolean, java.util.TreeMap)]
}

public void @this(global::java.util.TreeMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.util.TreeMap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.TreeMap_2NavigableSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: void <init>(java.util.TreeMap)]
}

public override global::System.Object firstEntry(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry firstEntry()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o).theSmallestEntry();
    if (_r0_o == null) goto label13;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o)._fm;
    _r0_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    label12:;
    return (global::java.util.Map_2Entry) _r0_o;
    label13:;
    _r0_o = null;
    goto label12;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry firstEntry()]
}

public override global::System.Object lastEntry(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry lastEntry()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o).theBiggestEntry();
    if (_r0_o == null) goto label13;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o)._fm;
    _r0_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    label12:;
    return (global::java.util.Map_2Entry) _r0_o;
    label13:;
    _r0_o = null;
    goto label12;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry lastEntry()]
}

public override global::System.Object pollFirstEntry(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry pollFirstEntry()]
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
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r3_o).theSmallestEntry();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r3_o)._fm;
    _r1_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    if (_r0_o == null) goto label19;
    _r2_o = ((global::java.util.TreeMap_2AscendingSubMap) _r3_o)._fm;
    _r0_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    ((global::java.util.TreeMap) _r2_o).remove((global::java.lang.Object) _r0_o);
    label19:;
    return (global::java.util.Map_2Entry) _r1_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry pollFirstEntry()]
}

public override global::System.Object pollLastEntry(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry pollLastEntry()]
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
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r3_o).theBiggestEntry();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r3_o)._fm;
    _r1_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    if (_r0_o == null) goto label19;
    _r2_o = ((global::java.util.TreeMap_2AscendingSubMap) _r3_o)._fm;
    _r0_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    ((global::java.util.TreeMap) _r2_o).remove((global::java.lang.Object) _r0_o);
    label19:;
    return (global::java.util.Map_2Entry) _r1_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry pollLastEntry()]
}

public override global::System.Object higherEntry(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry higherEntry(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = global::java.util.TreeMap_2NavigableSubMap.access_27((global::java.util.TreeMap_2NavigableSubMap) _r2_o, (global::java.lang.Object) _r3_o);
    if (_r0_o == null) goto label21;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    _r1.i = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o).isInRange((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label21;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o)._fm;
    _r0_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    label20:;
    return (global::java.util.Map_2Entry) _r0_o;
    label21:;
    _r0_o = null;
    goto label20;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry higherEntry(java.lang.Object)]
}

public override global::System.Object lowerEntry(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry lowerEntry(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = global::java.util.TreeMap_2NavigableSubMap.access_28((global::java.util.TreeMap_2NavigableSubMap) _r2_o, (global::java.lang.Object) _r3_o);
    if (_r0_o == null) goto label21;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    _r1.i = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o).isInRange((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label21;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o)._fm;
    _r0_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    label20:;
    return (global::java.util.Map_2Entry) _r0_o;
    label21:;
    _r0_o = null;
    goto label20;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry lowerEntry(java.lang.Object)]
}

public override global::System.Object ceilingEntry(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry ceilingEntry(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = global::java.util.TreeMap_2NavigableSubMap.access_29((global::java.util.TreeMap_2NavigableSubMap) _r2_o, (global::java.lang.Object) _r3_o);
    if (_r0_o == null) goto label21;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    _r1.i = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o).isInRange((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label21;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o)._fm;
    _r0_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    label20:;
    return (global::java.util.Map_2Entry) _r0_o;
    label21:;
    _r0_o = null;
    goto label20;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry ceilingEntry(java.lang.Object)]
}

public override global::System.Object floorEntry(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry floorEntry(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = global::java.util.TreeMap_2NavigableSubMap.access_210((global::java.util.TreeMap_2NavigableSubMap) _r2_o, (global::java.lang.Object) _r3_o);
    if (_r0_o == null) goto label21;
    _r1_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    _r1.i = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o).isInRange((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label21;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r2_o)._fm;
    _r0_o = ((global::java.util.TreeMap) _r1_o).newImmutableEntry((global::java.util.TreeMap_2Entry) _r0_o);
    label20:;
    return (global::java.util.Map_2Entry) _r0_o;
    label21:;
    _r0_o = null;
    goto label20;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Map$Entry floorEntry(java.lang.Object)]
}

public override global::System.Object entrySet(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Set entrySet()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMapEntrySet();
    ((global::java.util.TreeMap_2AscendingSubMapEntrySet) _r0_o).@this((global::java.util.TreeMap_2NavigableSubMap) _r1_o);
    return (global::java.util.Set) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.Set entrySet()]
}

public override global::System.Object navigableKeySet(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableSet navigableKeySet()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMapKeySet();
    ((global::java.util.TreeMap_2AscendingSubMapKeySet) _r0_o).@this((global::java.util.TreeMap_2NavigableSubMap) _r1_o);
    return (global::java.util.NavigableSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableSet navigableKeySet()]
}

public override global::System.Object descendingMap(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap descendingMap()]
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
    _r6_o = this;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label24;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label24;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r2.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r4_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r5.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o, (global::java.lang.Object) _r4_o, 0!=_r5.i);
    label23:;
    return (global::java.util.NavigableMap) _r0_o;
    label24:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label40;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r2_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r3.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o, (global::java.lang.Object) _r2_o, 0!=_r3.i);
    goto label23;
    label40:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label56;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r2.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o);
    goto label23;
    label56:;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o);
    goto label23;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap descendingMap()]
}

public override global::System.Object descendingSubMap(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.TreeMap$NavigableSubMap descendingSubMap()]
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
    _r6_o = this;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label24;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label24;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r2.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r4_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r5.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o, (global::java.lang.Object) _r4_o, 0!=_r5.i);
    label23:;
    return (global::java.util.TreeMap_2NavigableSubMap) _r0_o;
    label24:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label40;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r2_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r3.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o, (global::java.lang.Object) _r2_o, 0!=_r3.i);
    goto label23;
    label40:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label56;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r2.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o);
    goto label23;
    label56:;
    _r0_o = new global::java.util.TreeMap_2DescendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    ((global::java.util.TreeMap_2DescendingSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o);
    goto label23;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.TreeMap$NavigableSubMap descendingSubMap()]
}

public override global::System.Object subMap(global::java.lang.Object n1, bool n2, global::java.lang.Object n3, bool n4){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap subMap(java.lang.Object, boolean, java.lang.Object, boolean)]
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
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2 ? 1 : 0;
    _r9_o = n3;
    _r10.i = n4 ? 1 : 0;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label20;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    if (_r0.i != 0) goto label54;
    if (_r8.i == 0) goto label54;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i <= 0) goto label48;
    label20:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label75;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    if (_r0.i != 0) goto label65;
    if (_r10.i != 0) goto label38;
    if (_r8.i == 0) goto label65;
    _r0.i = ((global::java.lang.Object) _r7_o).equals((global::java.lang.Object) _r9_o) ? 1 : 0;
    if (_r0.i == 0) goto label65;
    label38:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r9_o, (global::java.lang.Object) _r1_o);
    if (_r0.i < 0) goto label75;
    label48:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label54:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i < 0) goto label48;
    goto label20;
    label65:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r9_o, (global::java.lang.Object) _r1_o);
    if (_r0.i > 0) goto label48;
    label75:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r9_o);
    if (_r0.i <= 0) goto label89;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label89:;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMap();
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = _r7_o;
    _r2.i = _r8.i;
    _r4_o = _r9_o;
    _r5.i = _r10.i;
    ((global::java.util.TreeMap_2AscendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o, (global::java.lang.Object) _r4_o, 0!=_r5.i);
    return (global::java.util.NavigableMap) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap subMap(java.lang.Object, boolean, java.lang.Object, boolean)]
}

public override global::System.Object headMap(global::java.lang.Object n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap headMap(java.lang.Object, boolean)]
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
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2 ? 1 : 0;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label36;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    if (_r0.i != 0) goto label26;
    if (_r8.i == 0) goto label26;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i > 0) goto label36;
    label20:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label26:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i < 0) goto label20;
    label36:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label72;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    if (_r0.i != 0) goto label62;
    if (_r8.i == 0) goto label62;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i < 0) goto label72;
    label56:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label62:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i > 0) goto label56;
    label72:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o).checkUpperBound((global::java.lang.Object) _r7_o) ? 1 : 0;
    if (_r0.i == 0) goto label104;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label96;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r2.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r4_o = _r7_o;
    _r5.i = _r8.i;
    ((global::java.util.TreeMap_2AscendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o, (global::java.lang.Object) _r4_o, 0!=_r5.i);
    label95:;
    return (global::java.util.NavigableMap) _r0_o;
    label96:;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    ((global::java.util.TreeMap_2AscendingSubMap) _r0_o).@this((global::java.util.TreeMap) _r1_o, (global::java.lang.Object) _r7_o, 0!=_r8.i);
    goto label95;
    label104:;
    _r0_o = _r6_o;
    goto label95;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap headMap(java.lang.Object, boolean)]
}

public override global::System.Object tailMap(global::java.lang.Object n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap tailMap(java.lang.Object, boolean)]
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
    global::org.xmlvm._nElement _r7;
    global::System.Object _r7_o = null;
    global::org.xmlvm._nElement _r8;
    global::System.Object _r8_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8.i = n2 ? 1 : 0;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ffromStart ? 1 : 0;
    if (_r0.i == 0) goto label36;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._floInclusive ? 1 : 0;
    if (_r0.i != 0) goto label26;
    if (_r8.i == 0) goto label26;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i > 0) goto label36;
    label20:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label26:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._flo;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i < 0) goto label20;
    label36:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label72;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    if (_r0.i != 0) goto label62;
    if (_r8.i == 0) goto label62;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i < 0) goto label72;
    label56:;
    _r0_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r0_o);
    label62:;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r0.i = ((global::java.util.TreeMap) _r0_o).keyCompare((global::java.lang.Object) _r7_o, (global::java.lang.Object) _r1_o);
    if (_r0.i > 0) goto label56;
    label72:;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o).checkLowerBound((global::java.lang.Object) _r7_o) ? 1 : 0;
    if (_r0.i == 0) goto label104;
    _r0.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._ftoEnd ? 1 : 0;
    if (_r0.i == 0) goto label96;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMap();
    _r3_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    _r4_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhi;
    _r5.i = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fhiInclusive ? 1 : 0;
    _r1_o = _r7_o;
    _r2.i = _r8.i;
    ((global::java.util.TreeMap_2AscendingSubMap) _r0_o).@this((global::java.lang.Object) _r1_o, 0!=_r2.i, (global::java.util.TreeMap) _r3_o, (global::java.lang.Object) _r4_o, 0!=_r5.i);
    label95:;
    return (global::java.util.NavigableMap) _r0_o;
    label96:;
    _r0_o = new global::java.util.TreeMap_2AscendingSubMap();
    _r1_o = ((global::java.util.TreeMap_2AscendingSubMap) _r6_o)._fm;
    ((global::java.util.TreeMap_2AscendingSubMap) _r0_o).@this((global::java.lang.Object) _r7_o, 0!=_r8.i, (global::java.util.TreeMap) _r1_o);
    goto label95;
    label104:;
    _r0_o = _r6_o;
    goto label95;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap: java.util.NavigableMap tailMap(java.lang.Object, boolean)]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMap]
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMap]

} // end of class: TreeMap_2AscendingSubMap

} // end of namespace: java.util
