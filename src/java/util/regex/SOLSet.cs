// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class SOLSet: global::java.util.regex.AbstractSet {
public void @this(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SOLSet: void <init>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    ((global::java.util.regex.AbstractSet) _r0_o).@this();
    return;
//XMLVM_END_WRAPPER[java.util.regex.SOLSet: void <init>()]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SOLSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r4_o = n3;
    if (_r2.i == 0) goto label14;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r4_o).hasAnchoringBounds() ? 1 : 0;
    if (_r0.i == 0) goto label21;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r4_o).getLeftBound();
    if (_r2.i != _r0.i) goto label21;
    label14:;
    _r0_o = ((global::java.util.regex.SOLSet) _r1_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    label20:;
    return _r0.i;
    label21:;
    _r0.i = -1;
    goto label20;
//XMLVM_END_WRAPPER[java.util.regex.SOLSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SOLSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
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
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.SOLSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SOLSet: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=<SOL>
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 62))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.SOLSet: java.lang.String getName()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.SOLSet]
//XMLVM_END_WRAPPER[java.util.regex.SOLSet]

} // end of class: SOLSet

} // end of namespace: java.util.regex
