// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class UCISupplRangeSet: global::java.util.regex.SupplRangeSet {
public void @this(global::java.util.regex.AbstractCharClass n1, global::java.util.regex.AbstractSet n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UCISupplRangeSet: void <init>(java.util.regex.AbstractCharClass, java.util.regex.AbstractSet)]
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
    ((global::java.util.regex.SupplRangeSet) _r0_o).@this((global::java.util.regex.AbstractCharClass) _r1_o, (global::java.util.regex.AbstractSet) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.UCISupplRangeSet: void <init>(java.util.regex.AbstractCharClass, java.util.regex.AbstractSet)]
}

public void @this(global::java.util.regex.AbstractCharClass n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UCISupplRangeSet: void <init>(java.util.regex.AbstractCharClass)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.SupplRangeSet) _r0_o).@this((global::java.util.regex.AbstractCharClass) _r1_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.UCISupplRangeSet: void <init>(java.util.regex.AbstractCharClass)]
}

public override bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UCISupplRangeSet: boolean contains(int)]
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
    _r3.i = n1;
    _r0_o = ((global::java.util.regex.UCISupplRangeSet) _r2_o)._fchars;
    _r1.i = global::java.lang.Character.toUpperCase((int) _r3.i);
    _r1.i = global::java.lang.Character.toLowerCase((int) _r1.i);
    _r0.i = ((global::java.util.regex.AbstractCharClass) _r0_o).contains((int) _r1.i) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.UCISupplRangeSet: boolean contains(int)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UCISupplRangeSet: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=UCI range:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)85)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 73)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.util.regex.UCISupplRangeSet) _r2_o)._falt ? 1 : 0;
    if (_r1.i == 0) goto label32;
    // Value=^ 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)94)), unchecked((char) unchecked((uint) 32))}));
    label13:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.util.regex.UCISupplRangeSet) _r2_o)._fchars;
    _r1_o = ((global::java.lang.Object) _r1_o).toString();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label32:;
    // Value= 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    goto label13;
//XMLVM_END_WRAPPER[java.util.regex.UCISupplRangeSet: java.lang.String getName()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.UCISupplRangeSet]
//XMLVM_END_WRAPPER[java.util.regex.UCISupplRangeSet]

} // end of class: UCISupplRangeSet

} // end of namespace: java.util.regex
