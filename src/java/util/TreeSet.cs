// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class TreeSet: global::java.util.AbstractSet,global::java.util.NavigableSet,global::java.lang.Cloneable,global::java.io.Serializable {
private static long _fserialVersionUID = -2479143000061671589L;

private global::java.util.NavigableMap _fbackingMap;

private global::java.util.NavigableSet _fdescendingSet;

public void @this(global::java.util.NavigableMap n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void <init>(java.util.NavigableMap)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.AbstractSet) _r0_o).@this();
    ((global::java.util.TreeSet) _r0_o)._fbackingMap = (global::java.util.NavigableMap) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.TreeSet: void <init>(java.util.NavigableMap)]
}

public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::java.util.AbstractSet) _r1_o).@this();
    _r0_o = new global::java.util.TreeMap();
    ((global::java.util.TreeMap) _r0_o).@this();
    ((global::java.util.TreeSet) _r1_o)._fbackingMap = (global::java.util.NavigableMap) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.TreeSet: void <init>()]
}

public void @this(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void <init>(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.TreeSet) _r0_o).@this();
    ((global::java.util.TreeSet) _r0_o).addAll((global::java.util.Collection) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.TreeSet: void <init>(java.util.Collection)]
}

public void @this(global::java.util.Comparator n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void <init>(java.util.Comparator)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.AbstractSet) _r1_o).@this();
    _r0_o = new global::java.util.TreeMap();
    ((global::java.util.TreeMap) _r0_o).@this((global::java.util.Comparator) _r2_o);
    ((global::java.util.TreeSet) _r1_o)._fbackingMap = (global::java.util.NavigableMap) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.TreeSet: void <init>(java.util.Comparator)]
}

public void @this(global::java.util.SortedSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void <init>(java.util.SortedSet)]
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
    _r0_o = ((global::java.util.SortedSet) _r3_o).comparator();
    ((global::java.util.TreeSet) _r2_o).@this((global::java.util.Comparator) _r0_o);
    _r0_o = ((global::java.util.SortedSet) _r3_o).iterator();
    label11:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label18;
    return;
    label18:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    ((global::java.util.TreeSet) _r2_o).add((global::java.lang.Object) _r1_o);
    goto label11;
//XMLVM_END_WRAPPER[java.util.TreeSet: void <init>(java.util.SortedSet)]
}

public override bool add(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: boolean add(java.lang.Object)]
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
    _r0_o = ((global::java.util.TreeSet) _r2_o)._fbackingMap;
    _r1_o = global::java.lang.Boolean._fTRUE;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).put((global::java.lang.Object) _r3_o, (global::java.lang.Object) _r1_o);
    if (_r0_o != null) goto label12;
    _r0.i = 1;
    label11:;
    return _r0.i!=0;
    label12:;
    _r0.i = 0;
    goto label11;
//XMLVM_END_WRAPPER[java.util.TreeSet: boolean add(java.lang.Object)]
}

public override bool addAll(global::java.util.Collection n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: boolean addAll(java.util.Collection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = base.addAll((global::java.util.Collection) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.TreeSet: boolean addAll(java.util.Collection)]
}

public override void clear(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void clear()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    ((global::java.util.NavigableMap) _r0_o).clear();
    return;
//XMLVM_END_WRAPPER[java.util.TreeSet: void clear()]
}

public override global::System.Object clone(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object clone()]
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
    try {
    _r0_o = base.clone();
    _r0_o = _r0_o;
    _r1_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r1.i = ((_r1_o != null) && (_r1_o is global::java.util.TreeMap)) ? 1 : 0;
    if (_r1.i == 0) goto label25;
    _r3_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r3_o = _r3_o;
    _r3_o = ((global::java.util.TreeMap) _r3_o).clone();
    _r3_o = _r3_o;
    ((global::java.util.TreeSet) _r0_o)._fbackingMap = (global::java.util.NavigableMap) _r3_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.CloneNotSupportedException) {
            _ex = ex;
            goto label35;
        }
        throw ex;
    } // end catch
    label24:;
    try {
    return (global::java.lang.Object) _r0_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.CloneNotSupportedException) {
            _ex = ex;
            goto label35;
        }
        throw ex;
    } // end catch
    label25:;
    try {
    _r1_o = new global::java.util.TreeMap();
    _r2_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    ((global::java.util.TreeMap) _r1_o).@this((global::java.util.SortedMap) _r2_o);
    ((global::java.util.TreeSet) _r0_o)._fbackingMap = (global::java.util.NavigableMap) _r1_o;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.CloneNotSupportedException) {
            _ex = ex;
            goto label35;
        }
        throw ex;
    } // end catch
    goto label24;
    label35:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = null;
    goto label24;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object clone()]
}

public virtual global::System.Object comparator(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.Comparator comparator()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).comparator();
    return (global::java.util.Comparator) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.Comparator comparator()]
}

public override bool contains(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: boolean contains(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0.i = ((global::java.util.NavigableMap) _r0_o).containsKey((global::java.lang.Object) _r2_o) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.TreeSet: boolean contains(java.lang.Object)]
}

public override bool isEmpty(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: boolean isEmpty()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0.i = ((global::java.util.NavigableMap) _r0_o).isEmpty() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.TreeSet: boolean isEmpty()]
}

public override global::System.Object iterator(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.Iterator iterator()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).keySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.Iterator iterator()]
}

public virtual global::System.Object descendingIterator(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.Iterator descendingIterator()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o).descendingSet();
    _r0_o = ((global::java.util.NavigableSet) _r0_o).iterator();
    return (global::java.util.Iterator) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.Iterator descendingIterator()]
}

public override bool remove(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: boolean remove(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).remove((global::java.lang.Object) _r2_o);
    if (_r0_o == null) goto label10;
    _r0.i = 1;
    label9:;
    return _r0.i!=0;
    label10:;
    _r0.i = 0;
    goto label9;
//XMLVM_END_WRAPPER[java.util.TreeSet: boolean remove(java.lang.Object)]
}

public override int size(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: int size()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0.i = ((global::java.util.NavigableMap) _r0_o).size();
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.TreeSet: int size()]
}

public virtual global::System.Object first(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object first()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).firstKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object first()]
}

public virtual global::System.Object last(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object last()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).lastKey();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object last()]
}

public virtual global::System.Object pollFirst(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object pollFirst()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).pollFirstEntry();
    if (_r0_o != null) goto label10;
    _r0_o = null;
    label9:;
    return (global::java.lang.Object) _r0_o;
    label10:;
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).getKey();
    goto label9;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object pollFirst()]
}

public virtual global::System.Object pollLast(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object pollLast()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).pollLastEntry();
    if (_r0_o != null) goto label10;
    _r0_o = null;
    label9:;
    return (global::java.lang.Object) _r0_o;
    label10:;
    _r0_o = ((global::java.util.Map_2Entry) _r0_o).getKey();
    goto label9;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object pollLast()]
}

public virtual global::System.Object higher(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object higher(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).higherKey((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object higher(java.lang.Object)]
}

public virtual global::System.Object lower(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object lower(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).lowerKey((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object lower(java.lang.Object)]
}

public virtual global::System.Object ceiling(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object ceiling(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).ceilingKey((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object ceiling(java.lang.Object)]
}

public virtual global::System.Object floor(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.lang.Object floor(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::java.util.TreeSet) _r1_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).floorKey((global::java.lang.Object) _r2_o);
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.lang.Object floor(java.lang.Object)]
}

public virtual global::System.Object descendingSet(){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.NavigableSet descendingSet()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.util.TreeSet) _r2_o)._fdescendingSet;
    if (_r0_o == null) goto label7;
    _r0_o = ((global::java.util.TreeSet) _r2_o)._fdescendingSet;
    label6:;
    return (global::java.util.NavigableSet) _r0_o;
    label7:;
    _r0_o = new global::java.util.TreeSet();
    _r1_o = ((global::java.util.TreeSet) _r2_o)._fbackingMap;
    _r1_o = ((global::java.util.NavigableMap) _r1_o).descendingMap();
    ((global::java.util.TreeSet) _r0_o).@this((global::java.util.NavigableMap) _r1_o);
    ((global::java.util.TreeSet) _r2_o)._fdescendingSet = (global::java.util.NavigableSet) _r0_o;
    goto label6;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.NavigableSet descendingSet()]
}

public virtual global::System.Object subSet(global::java.lang.Object n1, bool n2, global::java.lang.Object n3, bool n4){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.NavigableSet subSet(java.lang.Object, boolean, java.lang.Object, boolean)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2 ? 1 : 0;
    _r6_o = n3;
    _r7.i = n4 ? 1 : 0;
    _r1_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r1_o = ((global::java.util.NavigableMap) _r1_o).comparator();
    if (_r1_o != null) goto label30;
    _r0_o = _r4_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r1.i = ((global::java.lang.Comparable) _r1_o).compareTo((global::java.lang.Object) _r6_o);
    label16:;
    if (_r1.i > 0) goto label35;
    _r1_o = new global::java.util.TreeSet();
    _r2_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r2_o = ((global::java.util.NavigableMap) _r2_o).subMap((global::java.lang.Object) _r4_o, 0!=_r5.i, (global::java.lang.Object) _r6_o, 0!=_r7.i);
    ((global::java.util.TreeSet) _r1_o).@this((global::java.util.NavigableMap) _r2_o);
    return (global::java.util.NavigableSet) _r1_o;
    label30:;
    _r1.i = ((global::java.util.Comparator) _r1_o).compare((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r6_o);
    goto label16;
    label35:;
    _r1_o = new global::java.lang.IllegalArgumentException();
    ((global::java.lang.IllegalArgumentException) _r1_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r1_o);
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.NavigableSet subSet(java.lang.Object, boolean, java.lang.Object, boolean)]
}

public virtual global::System.Object headSet(global::java.lang.Object n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.NavigableSet headSet(java.lang.Object, boolean)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2 ? 1 : 0;
    _r1_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r1_o = ((global::java.util.NavigableMap) _r1_o).comparator();
    if (_r1_o != null) goto label27;
    _r0_o = _r4_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    ((global::java.lang.Comparable) _r1_o).compareTo((global::java.lang.Object) _r4_o);
    label15:;
    _r1_o = new global::java.util.TreeSet();
    _r2_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r2_o = ((global::java.util.NavigableMap) _r2_o).headMap((global::java.lang.Object) _r4_o, 0!=_r5.i);
    ((global::java.util.TreeSet) _r1_o).@this((global::java.util.NavigableMap) _r2_o);
    return (global::java.util.NavigableSet) _r1_o;
    label27:;
    ((global::java.util.Comparator) _r1_o).compare((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r4_o);
    goto label15;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.NavigableSet headSet(java.lang.Object, boolean)]
}

public virtual global::System.Object tailSet(global::java.lang.Object n1, bool n2){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.NavigableSet tailSet(java.lang.Object, boolean)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2 ? 1 : 0;
    _r1_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r1_o = ((global::java.util.NavigableMap) _r1_o).comparator();
    if (_r1_o != null) goto label27;
    _r0_o = _r4_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    ((global::java.lang.Comparable) _r1_o).compareTo((global::java.lang.Object) _r4_o);
    label15:;
    _r1_o = new global::java.util.TreeSet();
    _r2_o = ((global::java.util.TreeSet) _r3_o)._fbackingMap;
    _r2_o = ((global::java.util.NavigableMap) _r2_o).tailMap((global::java.lang.Object) _r4_o, 0!=_r5.i);
    ((global::java.util.TreeSet) _r1_o).@this((global::java.util.NavigableMap) _r2_o);
    return (global::java.util.NavigableSet) _r1_o;
    label27:;
    ((global::java.util.Comparator) _r1_o).compare((global::java.lang.Object) _r4_o, (global::java.lang.Object) _r4_o);
    goto label15;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.NavigableSet tailSet(java.lang.Object, boolean)]
}

public virtual global::System.Object subSet(global::java.lang.Object n1, global::java.lang.Object n2){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.SortedSet subSet(java.lang.Object, java.lang.Object)]
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
    _r3_o = n1;
    _r4_o = n2;
    _r0.i = 1;
    _r1.i = 0;
    _r0_o = ((global::java.util.TreeSet) _r2_o).subSet((global::java.lang.Object) _r3_o, 0!=_r0.i, (global::java.lang.Object) _r4_o, 0!=_r1.i);
    return (global::java.util.SortedSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.SortedSet subSet(java.lang.Object, java.lang.Object)]
}

public virtual global::System.Object headSet(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.SortedSet headSet(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    _r0_o = ((global::java.util.TreeSet) _r1_o).headSet((global::java.lang.Object) _r2_o, 0!=_r0.i);
    return (global::java.util.SortedSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.SortedSet headSet(java.lang.Object)]
}

public virtual global::System.Object tailSet(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: java.util.SortedSet tailSet(java.lang.Object)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    _r0_o = ((global::java.util.TreeSet) _r1_o).tailSet((global::java.lang.Object) _r2_o, 0!=_r0.i);
    return (global::java.util.SortedSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.TreeSet: java.util.SortedSet tailSet(java.lang.Object)]
}

private void writeObject(global::java.io.ObjectOutputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void writeObject(java.io.ObjectOutputStream)]
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
    ((global::java.io.ObjectOutputStream) _r3_o).defaultWriteObject();
    _r0_o = ((global::java.util.TreeSet) _r2_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).comparator();
    ((global::java.io.ObjectOutputStream) _r3_o).writeObject((global::java.lang.Object) _r0_o);
    _r0_o = ((global::java.util.TreeSet) _r2_o)._fbackingMap;
    _r0.i = ((global::java.util.NavigableMap) _r0_o).size();
    ((global::java.io.ObjectOutputStream) _r3_o).writeInt((int) _r0.i);
    if (_r0.i <= 0) goto label39;
    _r0_o = ((global::java.util.TreeSet) _r2_o)._fbackingMap;
    _r0_o = ((global::java.util.NavigableMap) _r0_o).keySet();
    _r0_o = ((global::java.util.Set) _r0_o).iterator();
    label33:;
    _r1.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    if (_r1.i != 0) goto label40;
    label39:;
    return;
    label40:;
    _r1_o = ((global::java.util.Iterator) _r0_o).next();
    ((global::java.io.ObjectOutputStream) _r3_o).writeObject((global::java.lang.Object) _r1_o);
    goto label33;
//XMLVM_END_WRAPPER[java.util.TreeSet: void writeObject(java.io.ObjectOutputStream)]
}

private void readObject(global::java.io.ObjectInputStream n1){
//XMLVM_BEGIN_WRAPPER[java.util.TreeSet: void readObject(java.io.ObjectInputStream)]
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
    _r7_o = this;
    _r8_o = n1;
    ((global::java.io.ObjectInputStream) _r8_o).defaultReadObject();
    _r1_o = new global::java.util.TreeMap();
    _r0_o = ((global::java.io.ObjectInputStream) _r8_o).readObject();
    _r0_o = _r0_o;
    ((global::java.util.TreeMap) _r1_o).@this((global::java.util.Comparator) _r0_o);
    _r0.i = ((global::java.io.ObjectInputStream) _r8_o).readInt();
    if (_r0.i <= 0) goto label27;
    _r2_o = null;
    _r3.i = 0;
    _r6.i = _r3.i;
    _r3_o = _r2_o;
    _r2.i = _r6.i;
    label25:;
    if (_r2.i < _r0.i) goto label30;
    label27:;
    ((global::java.util.TreeSet) _r7_o)._fbackingMap = (global::java.util.NavigableMap) _r1_o;
    return;
    label30:;
    _r4_o = ((global::java.io.ObjectInputStream) _r8_o).readObject();
    _r5_o = global::java.lang.Boolean._fTRUE;
    _r3_o = ((global::java.util.TreeMap) _r1_o).addToLast((global::java.util.TreeMap_2Node) _r3_o, (global::java.lang.Object) _r4_o, (global::java.lang.Object) _r5_o);
    _r2.i = _r2.i + 1;
    goto label25;
//XMLVM_END_WRAPPER[java.util.TreeSet: void readObject(java.io.ObjectInputStream)]
}

//XMLVM_BEGIN_WRAPPER[java.util.TreeSet]
//XMLVM_END_WRAPPER[java.util.TreeSet]

} // end of class: TreeSet

} // end of namespace: java.util
