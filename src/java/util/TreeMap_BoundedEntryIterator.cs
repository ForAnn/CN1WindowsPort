// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeMap_2BoundedEntryIterator: global::java.util.TreeMap_2BoundedMapIterator,global::java.util.Iterator {
new public void @this(global::java.util.TreeMap_2Node n1, int n2, global::java.util.TreeMap n3, global::java.util.TreeMap_2Node n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$BoundedEntryIterator: void <init>(java.util.TreeMap$Node, int, java.util.TreeMap, java.util.TreeMap$Node, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    _r0_o = this;
    _r1_o = n1;
    _r2.i = n2;
    _r3_o = n3;
    _r4_o = n4;
    _r5.i = n5;
    ((global::java.util.TreeMap_2BoundedMapIterator) _r0_o).@this((global::java.util.TreeMap_2Node) _r1_o, (int) _r2.i, (global::java.util.TreeMap) _r3_o, (global::java.util.TreeMap_2Node) _r4_o, (int) _r5.i);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$BoundedEntryIterator: void <init>(java.util.TreeMap$Node, int, java.util.TreeMap, java.util.TreeMap$Node, int)]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$BoundedEntryIterator: java.util.Map$Entry next()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r4_o = this;
    _r0.i = ((global::java.util.TreeMap_2BoundedEntryIterator) _r4_o).hasNext() ? 1 : 0;
    if (_r0.i != 0) goto label12;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
    label12:;
    ((global::java.util.TreeMap_2BoundedEntryIterator) _r4_o).makeBoundedNext();
    _r0.i = ((global::java.util.TreeMap_2BoundedEntryIterator) _r4_o)._flastOffset;
    _r1_o = new global::java.util.MapEntry();
    _r2_o = ((global::java.util.TreeMap_2BoundedEntryIterator) _r4_o)._flastNode;
    _r2_o = ((global::java.util.TreeMap_2Node) _r2_o)._fkeys;
    _r2_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r0.i];
    _r3_o = ((global::java.util.TreeMap_2BoundedEntryIterator) _r4_o)._flastNode;
    _r3_o = ((global::java.util.TreeMap_2Node) _r3_o)._fvalues;
    _r0_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    ((global::java.util.MapEntry) _r1_o).@this((global::java.lang.Object) _r2_o, (global::java.lang.Object) _r0_o);
    return (global::java.util.Map_2Entry) _r1_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$BoundedEntryIterator: java.util.Map$Entry next()]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$BoundedEntryIterator]
//XMLVM_END_WRAPPER[java.util.TreeMap$BoundedEntryIterator]

} // end of class: TreeMap_2BoundedEntryIterator

} // end of namespace: java.util
