// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.lang.reflect {
public class ListOfVariables: global::java.lang.Object {

static ListOfVariables() {
    @static();
}

public static global::org.xmlvm._nArrayAdapter<global::System.Object> _fempty;

public global::java.util.ArrayList _farray;

public int _fn;

public void @this(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    ((global::java.lang.Object) _r1_o).@this();
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    ((global::org.apache.harmony.luni.lang.reflect.ListOfVariables) _r1_o)._farray = (global::java.util.ArrayList) _r0_o;
    _r0.i = 0;
    ((global::org.apache.harmony.luni.lang.reflect.ListOfVariables) _r1_o)._fn = _r0.i;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: void <init>()]
}

public virtual void add(global::java.lang.reflect.TypeVariable n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: void add(java.lang.reflect.TypeVariable)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfVariables) _r1_o)._farray;
    ((global::java.util.ArrayList) _r0_o).add((global::java.lang.Object) _r2_o);
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: void add(java.lang.reflect.TypeVariable)]
}

public virtual global::System.Object getArray(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: java.lang.reflect.TypeVariable[] getArray()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfVariables) _r2_o)._farray;
    _r1.i = ((global::java.util.ArrayList) _r1_o).size();
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r1.i]);
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfVariables) _r2_o)._farray;
    _r2_o = ((global::java.util.ArrayList) _r1_o).toArray((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    _r2_o = _r2_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: java.lang.reflect.TypeVariable[] getArray()]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0.i = 0;
    _r0_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r0.i]);
    global::org.apache.harmony.luni.lang.reflect.ListOfVariables._fempty = (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ListOfVariables]

} // end of class: ListOfVariables

} // end of namespace: org.apache.harmony.luni.lang.reflect
