// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class AbstractList_2SimpleListIterator: global::java.lang.Object,global::java.util.Iterator {
public int _fnumLeft;

public int _fexpectedModCount;

public int _flastPosition;

public global::java.util.AbstractList _fthis_20;

private void @this(global::java.util.AbstractList n1){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator: void <init>(java.util.AbstractList)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.AbstractList_2SimpleListIterator) _r1_o)._fthis_20 = (global::java.util.AbstractList) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0.i = ((global::java.util.AbstractList) _r2_o).size();
    ((global::java.util.AbstractList_2SimpleListIterator) _r1_o)._fnumLeft = _r0.i;
    _r0.i = ((global::java.util.AbstractList) _r2_o)._fmodCount;
    ((global::java.util.AbstractList_2SimpleListIterator) _r1_o)._fexpectedModCount = _r0.i;
    _r0.i = -1;
    ((global::java.util.AbstractList_2SimpleListIterator) _r1_o)._flastPosition = _r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator: void <init>(java.util.AbstractList)]
}

public virtual bool hasNext(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator: boolean hasNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r1_o)._fnumLeft;
    if (_r0.i <= 0) goto label6;
    _r0.i = 1;
    label5:;
    return _r0.i!=0;
    label6:;
    _r0.i = 0;
    goto label5;
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator: boolean hasNext()]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator: java.lang.Object next()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r3_o = this;
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fexpectedModCount;
    _r1_o = ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fthis_20;
    _r1.i = ((global::java.util.AbstractList) _r1_o)._fmodCount;
    if (_r0.i == _r1.i) goto label14;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
    label14:;
    try {
    _r0_o = ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fthis_20;
    _r0.i = ((global::java.util.AbstractList) _r0_o).size();
    _r1.i = ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fnumLeft;
    _r0.i = _r0.i - _r1.i;
    _r1_o = ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fthis_20;
    _r1_o = ((global::java.util.AbstractList) _r1_o).get((int) _r0.i);
    ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._flastPosition = _r0.i;
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fnumLeft;
    _r2.i = 1;
    _r0.i = _r0.i - _r2.i;
    ((global::java.util.AbstractList_2SimpleListIterator) _r3_o)._fnumLeft = _r0.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IndexOutOfBoundsException) {
            _ex = ex;
            goto label38;
        }
        throw ex;
    } // end catch
    return (global::java.lang.Object) _r1_o;
    label38:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::java.util.NoSuchElementException();
    ((global::java.util.NoSuchElementException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.NoSuchElementException) _r0_o);
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator: java.lang.Object next()]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator: void remove()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r3.i = -1;
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._flastPosition;
    if (_r0.i != _r3.i) goto label11;
    _r0_o = new global::java.lang.IllegalStateException();
    ((global::java.lang.IllegalStateException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalStateException) _r0_o);
    label11:;
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fexpectedModCount;
    _r1_o = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fthis_20;
    _r1.i = ((global::java.util.AbstractList) _r1_o)._fmodCount;
    if (_r0.i == _r1.i) goto label25;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
    label25:;
    try {
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._flastPosition;
    _r1_o = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fthis_20;
    _r1.i = ((global::java.util.AbstractList) _r1_o).size();
    _r2.i = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fnumLeft;
    _r1.i = _r1.i - _r2.i;
    if (_r0.i != _r1.i) goto label44;
    _r0.i = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fnumLeft;
    _r1.i = 1;
    _r0.i = _r0.i - _r1.i;
    ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fnumLeft = _r0.i;
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IndexOutOfBoundsException) {
            _ex = ex;
            goto label60;
        }
        throw ex;
    } // end catch
    label44:;
    try {
    _r0_o = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fthis_20;
    _r1.i = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._flastPosition;
    ((global::java.util.AbstractList) _r0_o).remove((int) _r1.i);
    }
    catch (global::System.Exception e) {
 global::org.xmlvm._nExceptionAdapter ex = e as global::org.xmlvm._nExceptionAdapter ?? new global::org.xmlvm._nExceptionAdapter(e.ToString(), e.ToJavaException());
        global::System.Object _java_exception = ex.getJavaException();
        if (_java_exception is global::java.lang.IndexOutOfBoundsException) {
            _ex = ex;
            goto label60;
        }
        throw ex;
    } // end catch
    _r0_o = ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fthis_20;
    _r0.i = ((global::java.util.AbstractList) _r0_o)._fmodCount;
    ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._fexpectedModCount = _r0.i;
    ((global::java.util.AbstractList_2SimpleListIterator) _r4_o)._flastPosition = _r3.i;
    return;
    label60:;
    _r0_o = _ex.getJavaException();
    _ex = null;
    _r0_o = new global::java.util.ConcurrentModificationException();
    ((global::java.util.ConcurrentModificationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.util.ConcurrentModificationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator: void remove()]
}

public void @this(global::java.util.AbstractList n1, global::java.util.AbstractList_2SimpleListIterator n2){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator: void <init>(java.util.AbstractList, java.util.AbstractList$SimpleListIterator)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    ((global::java.util.AbstractList_2SimpleListIterator) _r0_o).@this((global::java.util.AbstractList) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator: void <init>(java.util.AbstractList, java.util.AbstractList$SimpleListIterator)]
}

public void @this(global::java.util.AbstractList n1, global::java.util.AbstractList_2SimpleListIterator n2, global::java.util.AbstractList_2SimpleListIterator n3){
//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator: void <init>(java.util.AbstractList, java.util.AbstractList$SimpleListIterator, java.util.AbstractList$SimpleListIterator)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3_o = n3;
    ((global::java.util.AbstractList_2SimpleListIterator) _r0_o).@this((global::java.util.AbstractList) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator: void <init>(java.util.AbstractList, java.util.AbstractList$SimpleListIterator, java.util.AbstractList$SimpleListIterator)]
}

//XMLVM_BEGIN_WRAPPER[java.util.AbstractList$SimpleListIterator]
//XMLVM_END_WRAPPER[java.util.AbstractList$SimpleListIterator]

} // end of class: AbstractList_2SimpleListIterator

} // end of namespace: java.util
