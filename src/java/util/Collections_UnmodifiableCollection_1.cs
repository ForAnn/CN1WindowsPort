// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util {
public class Collections_2UnmodifiableCollection_21: global::java.lang.Object,global::java.util.Iterator {
public global::java.util.Iterator _fiterator;

public global::java.util.Collections_2UnmodifiableCollection _fthis_21;

public void @this(global::java.util.Collections_2UnmodifiableCollection n1){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableCollection$1: void <init>(java.util.Collections$UnmodifiableCollection)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.Collections_2UnmodifiableCollection_21) _r1_o)._fthis_21 = (global::java.util.Collections_2UnmodifiableCollection) _r2_o;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = ((global::java.util.Collections_2UnmodifiableCollection) _r2_o)._fc;
    _r0_o = ((global::java.util.Collection) _r0_o).iterator();
    ((global::java.util.Collections_2UnmodifiableCollection_21) _r1_o)._fiterator = (global::java.util.Iterator) _r0_o;
    return;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableCollection$1: void <init>(java.util.Collections$UnmodifiableCollection)]
}

public virtual bool hasNext(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableCollection$1: boolean hasNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableCollection_21) _r1_o)._fiterator;
    _r0.i = ((global::java.util.Iterator) _r0_o).hasNext() ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableCollection$1: boolean hasNext()]
}

public virtual global::System.Object next(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableCollection$1: java.lang.Object next()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.Collections_2UnmodifiableCollection_21) _r1_o)._fiterator;
    _r0_o = ((global::java.util.Iterator) _r0_o).next();
    return (global::java.lang.Object) _r0_o;
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableCollection$1: java.lang.Object next()]
}

public virtual void remove(){
//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableCollection$1: void remove()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = new global::java.lang.UnsupportedOperationException();
    ((global::java.lang.UnsupportedOperationException) _r0_o).@this();
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.UnsupportedOperationException) _r0_o);
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableCollection$1: void remove()]
}

//XMLVM_BEGIN_WRAPPER[java.util.Collections$UnmodifiableCollection$1]
//XMLVM_END_WRAPPER[java.util.Collections$UnmodifiableCollection$1]

} // end of class: Collections_2UnmodifiableCollection_21

} // end of namespace: java.util
