// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class NonCapFSet: global::java.util.regex.FSet {
public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NonCapFSet: void <init>(int)]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.regex.FSet) _r0_o).@this((int) _r1.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.NonCapFSet: void <init>(int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NonCapFSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::System.Object _r5_o = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r0.i = ((global::java.util.regex.NonCapFSet) _r2_o).getGroupIndex();
    _r1.i = ((global::java.util.regex.MatchResultImpl) _r5_o).getConsumed((int) _r0.i);
    _r1.i = _r3.i - _r1.i;
    ((global::java.util.regex.MatchResultImpl) _r5_o).setConsumed((int) _r0.i, (int) _r1.i);
    _r0_o = ((global::java.util.regex.NonCapFSet) _r2_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r3.i, (global::java.lang.CharSequence) _r4_o, (global::java.util.regex.MatchResultImpl) _r5_o);
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.NonCapFSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NonCapFSet: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=NonCapFSet
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)78)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 67)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 70)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.NonCapFSet: java.lang.String getName()]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.NonCapFSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.NonCapFSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.NonCapFSet]
//XMLVM_END_WRAPPER[java.util.regex.NonCapFSet]

} // end of class: NonCapFSet

} // end of namespace: java.util.regex
