// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeMap_2AscendingSubMapKeyIterator: global::java.util.TreeMap_2AscendingSubMapIterator,global::java.util.Iterator {
public void @this(global::java.util.TreeMap_2NavigableSubMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMapKeyIterator: void <init>(java.util.TreeMap$NavigableSubMap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.TreeMap_2AscendingSubMapIterator) _r0_o).@this((global::java.util.TreeMap_2NavigableSubMap) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMapKeyIterator: void <init>(java.util.TreeMap$NavigableSubMap)]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMapKeyIterator: java.lang.Object next()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeMap_2AscendingSubMapKeyIterator) _r1_o).getNext();
    _r0_o = ((global::java.util.TreeMap_2Entry) _r0_o)._fkey;
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMapKeyIterator: java.lang.Object next()]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeMap$AscendingSubMapKeyIterator]
//XMLVM_END_WRAPPER[java.util.TreeMap$AscendingSubMapKeyIterator]

} // end of class: TreeMap_2AscendingSubMapKeyIterator

} // end of namespace: java.util
