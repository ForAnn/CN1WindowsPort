// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.apache.harmony.luni.lang.reflect {
public class ImplForWildcard: global::java.lang.Object,global::java.lang.reflect.WildcardType {
private global::org.apache.harmony.luni.lang.reflect.ListOfTypes _fextendsBound;

private global::org.apache.harmony.luni.lang.reflect.ListOfTypes _fsuperBound;

public void @this(global::org.apache.harmony.luni.lang.reflect.ListOfTypes n1, global::org.apache.harmony.luni.lang.reflect.ListOfTypes n2){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: void <init>(org.apache.harmony.luni.lang.reflect.ListOfTypes, org.apache.harmony.luni.lang.reflect.ListOfTypes)]
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
    ((global::java.lang.Object) _r0_o).@this();
    ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r0_o)._fextendsBound = (global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r1_o;
    ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r0_o)._fsuperBound = (global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r2_o;
    return;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: void <init>(org.apache.harmony.luni.lang.reflect.ListOfTypes, org.apache.harmony.luni.lang.reflect.ListOfTypes)]
}

public virtual global::System.Object getLowerBounds(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: java.lang.reflect.Type[] getLowerBounds()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r1_o)._fsuperBound;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r0_o).getResolvedTypes();
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o).clone();
    _r1_o = _r1_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: java.lang.reflect.Type[] getLowerBounds()]
}

public virtual global::System.Object getUpperBounds(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: java.lang.reflect.Type[] getUpperBounds()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r1_o)._fextendsBound;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r0_o).getResolvedTypes();
    _r1_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o).clone();
    _r1_o = _r1_o;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: java.lang.reflect.Type[] getUpperBounds()]
}

public override bool equals(global::java.lang.Object n1){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: boolean equals(java.lang.Object)]
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
    _r5_o = this;
    _r6_o = n1;
    _r4.i = 0;
    _r2.i = ((_r6_o != null) && (_r6_o is global::java.lang.reflect.WildcardType)) ? 1 : 0;
    if (_r2.i != 0) goto label7;
    _r2.i = _r4.i;
    label6:;
    return _r2.i!=0;
    label7:;
    _r0_o = _r6_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r5_o).getLowerBounds();
    _r3_o = ((global::java.lang.reflect.WildcardType) _r1_o).getLowerBounds();
    _r2.i = global::java.util.Arrays.equals((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o) ? 1 : 0;
    if (_r2.i == 0) goto label41;
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r5_o).getUpperBounds();
    _r3_o = ((global::java.lang.reflect.WildcardType) _r1_o).getUpperBounds();
    _r2.i = global::java.util.Arrays.equals((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o, (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o) ? 1 : 0;
    if (_r2.i == 0) goto label41;
    _r2.i = 1;
    goto label6;
    label41:;
    _r2.i = _r4.i;
    goto label6;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: boolean equals(java.lang.Object)]
}

public override int hashCode(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: int hashCode()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r2_o).getLowerBounds();
    _r0.i = global::java.util.Arrays.hashCode((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r0_o);
    _r0.i = _r0.i * 31;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r2_o).getUpperBounds();
    _r1.i = global::java.util.Arrays.hashCode((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r1_o);
    _r0.i = _r0.i + _r1.i;
    return _r0.i;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: int hashCode()]
}

public override global::System.Object toString(){
//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: java.lang.String toString()]
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
    _r0_o = new global::java.lang.StringBuilder();
    // Value=?
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)63))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r3_o)._fextendsBound;
    _r1.i = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r1_o).length();
    if (_r1.i <= 0) goto label31;
    // Value= extends 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r3_o)._fextendsBound;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.Object) _r2_o);
    label26:;
    _r1_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r1_o;
    label31:;
    _r1_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r3_o)._fsuperBound;
    _r1.i = ((global::org.apache.harmony.luni.lang.reflect.ListOfTypes) _r1_o).length();
    if (_r1.i <= 0) goto label26;
    // Value= super 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 32))}));
    _r1_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r2_o = ((global::org.apache.harmony.luni.lang.reflect.ImplForWildcard) _r3_o)._fsuperBound;
    ((global::java.lang.StringBuilder) _r1_o).append((global::java.lang.Object) _r2_o);
    goto label26;
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard: java.lang.String toString()]
}

//XMLVM_BEGIN_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard]
//XMLVM_END_WRAPPER[org.apache.harmony.luni.lang.reflect.ImplForWildcard]

} // end of class: ImplForWildcard

} // end of namespace: org.apache.harmony.luni.lang.reflect
