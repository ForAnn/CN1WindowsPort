// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2SetFromMap: global::java.util.AbstractSet,global::java.io.Serializable {

private global::java.util.Map _fm;

private global::java.util.Set _fbackingSet;

public void @this(global::java.util.Map n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: void <init>(java.util.Map)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.AbstractSet) _r1_o).@this();
    ((global::java.util.Collections_2SetFromMap) _r1_o)._fm = (global::java.util.Map) _r2_o;
    _r0_o = ((global::java.util.Map) _r2_o).keySet();
    ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet = (global::java.util.Set) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: void <init>(java.util.Map)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0.i = ((global::java.util.Set) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0.i = ((global::java.util.Set) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: int hashCode()]
}

public override bool add(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean add(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r2_o)._fm;
    _r1_o = global::java.lang.Boolean._fTRUE;
    _r0_o = ((global::java.util.Map) _r0_o).put((global::java.lang.Object) _r3_o, (global::java.lang.Object) _r1_o);
    if (_r0_o != null) goto label12;
    _r0.i = 1;
    label11:;
    return _r0.i!=0;
    label12:;
    _r0.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean add(java.lang.Object)]
}

public override void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: void clear()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fm;
    ((global::java.util.Map) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: void clear()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: java.lang.String toString()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0_o = ((global::java.lang.Object) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: java.lang.String toString()]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0.i = ((global::java.util.Set) _r0_o).contains((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean contains(java.lang.Object)]
}

public override bool containsAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean containsAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0.i = ((global::java.util.Set) _r0_o).containsAll((global::java.util.Collection) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean containsAll(java.util.Collection)]
}

public override bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).isEmpty() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean isEmpty()]
}

public override bool remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean remove(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fm;
    _r0_o = ((global::java.util.Map) _r0_o).remove((global::java.lang.Object) _r2_o);
    if (_r0_o == null) goto label10;
    _r0.i = 1;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean remove(java.lang.Object)]
}

public override bool retainAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: boolean retainAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0.i = ((global::java.util.Set) _r0_o).retainAll((global::java.util.Collection) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: boolean retainAll(java.util.Collection)]
}

public override global::System.Object toArray(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: java.lang.Object[] toArray()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0_o = ((global::java.util.Set) _r0_o).toArray();
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: java.lang.Object[] toArray()]
}

public override global::System.Object toArray(global::org.xmlvm._nArrayAdapter<global::System.Object> n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: java.lang.Object[] toArray(java.lang.Object[])]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0_o = ((global::java.util.Set) _r0_o).toArray((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o);
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: java.lang.Object[] toArray(java.lang.Object[])]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: java.util.Iterator iterator()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet;
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: java.util.Iterator iterator()]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fm;
    _r0.i = ((global::java.util.Map) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: int size()]
}

private void readObject(global::java.io.ObjectInputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap: void readObject(java.io.ObjectInputStream)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.io.ObjectInputStream) _r2_o).defaultReadObject();
    _r0_o = ((global::java.util.Collections_2SetFromMap) _r1_o)._fm;
    _r0_o = ((global::java.util.Map) _r0_o).keySet();
    ((global::java.util.Collections_2SetFromMap) _r1_o)._fbackingSet = (global::java.util.Set) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap: void readObject(java.io.ObjectInputStream)]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$SetFromMap]
//XMLVM_END_WRAPPER[java.util.Collections$SetFromMap]

} // end of class: Collections_2SetFromMap

} // end of namespace: java.util
