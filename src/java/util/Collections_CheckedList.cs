// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2CheckedList: global::java.util.Collections_2CheckedCollection,global::java.util.List {
private static long _fserialVersionUID = 65247728283967356L;

public global::java.util.List _fl;

public void @this(global::java.util.List n1, global::java.lang.Class n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: void <init>(java.util.List, java.lang.Class)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.Collections_2CheckedCollection) _r0_o).@this((global::java.util.Collection) _r1_o, (global::java.lang.Class) _r2_o);
    ((global::java.util.Collections_2CheckedList) _r0_o)._fl = (global::java.util.List) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: void <init>(java.util.List, java.lang.Class)]
}

public virtual bool addAll(int n1, global::java.util.Collection n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: boolean addAll(int, java.util.Collection)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6.i = n1;
    _r7_o = n2;
    _r0_o = ((global::java.util.Collection) _r7_o).toArray();
    _r1.i = ((global::org.xmlvm._nIArray) _r0_o).Length;
    _r2.i = 0;
    label6:;
    if (_r2.i < _r1.i) goto label19;
    _r1_o = ((global::java.util.Collections_2CheckedList) _r5_o)._fl;
    _r0_o = global::java.util.Arrays.asList((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    _r0.i = ((global::java.util.List) _r1_o).addAll((int) _r6.i, (global::java.util.Collection) _r0_o) ? 1 : 0;
    return _r0.i!=0;
    label19:;
    _r3_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o)[_r2.i];
    _r4_o = ((global::java.util.Collections_2CheckedList) _r5_o)._ftype;
    global::java.util.Collections.checkType((global::java.lang.Object) _r3_o, (global::java.lang.Class) _r4_o);
    _r2.i = _r2.i + 1;
    goto label6;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: boolean addAll(int, java.util.Collection)]
}

public virtual global::System.Object get(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: java.lang.Object get(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r1_o)._fl;
    _r0_o = ((global::java.util.List) _r0_o).get((int) _r2.i);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: java.lang.Object get(int)]
}

public virtual global::System.Object set(int n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: java.lang.Object set(int, java.lang.Object)]
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
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r2_o)._fl;
    _r1_o = ((global::java.util.Collections_2CheckedList) _r2_o)._ftype;
    _r1_o = global::java.util.Collections.checkType((global::java.lang.Object) _r4_o, (global::java.lang.Class) _r1_o);
    _r0_o = ((global::java.util.List) _r0_o).set((int) _r3.i, (global::java.lang.Object) _r1_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: java.lang.Object set(int, java.lang.Object)]
}

public virtual void add(int n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: void add(int, java.lang.Object)]
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
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r2_o)._fl;
    _r1_o = ((global::java.util.Collections_2CheckedList) _r2_o)._ftype;
    _r1_o = global::java.util.Collections.checkType((global::java.lang.Object) _r4_o, (global::java.lang.Class) _r1_o);
    ((global::java.util.List) _r0_o).add((int) _r3.i, (global::java.lang.Object) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: void add(int, java.lang.Object)]
}

public virtual global::System.Object remove(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: java.lang.Object remove(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r1_o)._fl;
    _r0_o = ((global::java.util.List) _r0_o).remove((int) _r2.i);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: java.lang.Object remove(int)]
}

public virtual int indexOf(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: int indexOf(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r1_o)._fl;
    _r0.i = ((global::java.util.List) _r0_o).indexOf((global::java.lang.Object) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: int indexOf(java.lang.Object)]
}

public virtual int lastIndexOf(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: int lastIndexOf(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r1_o)._fl;
    _r0.i = ((global::java.util.List) _r0_o).lastIndexOf((global::java.lang.Object) _r2_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: int lastIndexOf(java.lang.Object)]
}

public virtual global::System.Object listIterator(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: java.util.ListIterator listIterator()]
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
    _r0_o = new global::java.util.Collections_2CheckedListIterator();
    _r1_o = ((global::java.util.Collections_2CheckedList) _r3_o)._fl;
    _r1_o = ((global::java.util.List) _r1_o).listIterator();
    _r2_o = ((global::java.util.Collections_2CheckedList) _r3_o)._ftype;
    ((global::java.util.Collections_2CheckedListIterator) _r0_o).@this((global::java.util.ListIterator) _r1_o, (global::java.lang.Class) _r2_o);
    return (global::java.util.ListIterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: java.util.ListIterator listIterator()]
}

public virtual global::System.Object listIterator(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: java.util.ListIterator listIterator(int)]
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
    _r3_o = this;
    _r4.i = n1;
    _r0_o = new global::java.util.Collections_2CheckedListIterator();
    _r1_o = ((global::java.util.Collections_2CheckedList) _r3_o)._fl;
    _r1_o = ((global::java.util.List) _r1_o).listIterator((int) _r4.i);
    _r2_o = ((global::java.util.Collections_2CheckedList) _r3_o)._ftype;
    ((global::java.util.Collections_2CheckedListIterator) _r0_o).@this((global::java.util.ListIterator) _r1_o, (global::java.lang.Class) _r2_o);
    return (global::java.util.ListIterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: java.util.ListIterator listIterator(int)]
}

public virtual global::System.Object subList(int n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: java.util.List subList(int, int)]
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
    _r2_o = this;
    _r3.i = n1;
    _r4.i = n2;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r2_o)._fl;
    _r0_o = ((global::java.util.List) _r0_o).subList((int) _r3.i, (int) _r4.i);
    _r1_o = ((global::java.util.Collections_2CheckedList) _r2_o)._ftype;
    _r0_o = global::java.util.Collections.checkedList((global::java.util.List) _r0_o, (global::java.lang.Class) _r1_o);
    return (global::java.util.List) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: java.util.List subList(int, int)]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: boolean equals(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r1_o)._fl;
    _r0.i = ((global::java.util.List) _r0_o).equals((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2CheckedList) _r1_o)._fl;
    _r0.i = ((global::java.util.List) _r0_o).hashCode();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList: int hashCode()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$CheckedList]
//XMLVM_END_WRAPPER[java.util.Collections$CheckedList]

} // end of class: Collections_2CheckedList

} // end of namespace: java.util
