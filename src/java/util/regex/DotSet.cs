// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class DotSet: global::java.util.regex.JointSet {
public global::java.util.regex.AbstractLineTerminator _flt;

public void @this(global::java.util.regex.AbstractLineTerminator n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: void <init>(java.util.regex.AbstractLineTerminator)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.JointSet) _r0_o).@this();
    ((global::java.util.regex.DotSet) _r0_o)._flt = (global::java.util.regex.AbstractLineTerminator) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: void <init>(java.util.regex.AbstractLineTerminator)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r4_o = this;
    _r5.i = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r3.i = -1;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r7_o).getRightBound();
    _r1.i = _r5.i + 1;
    if (_r1.i <= _r0.i) goto label14;
    _r0.i = 1;
    ((global::java.util.regex.MatchResultImpl) _r7_o)._fhitEnd = 0!=_r0.i;
    _r0.i = _r3.i;
    label13:;
    return _r0.i;
    label14:;
    _r1.i = ((global::java.lang.CharSequence) _r6_o).charAt((int) _r5.i);
    _r2.i = global::java.lang.Character.isHighSurrogate((char) _r1.i) ? 1 : 0;
    if (_r2.i == 0) goto label63;
    _r2.i = _r5.i + 2;
    if (_r2.i > _r0.i) goto label63;
    _r0.i = _r5.i + 1;
    _r0.i = ((global::java.lang.CharSequence) _r6_o).charAt((int) _r0.i);
    _r2.i = global::java.lang.Character.isSurrogatePair((char) _r1.i, (char) _r0.i) ? 1 : 0;
    if (_r2.i == 0) goto label63;
    _r2_o = ((global::java.util.regex.DotSet) _r4_o)._flt;
    _r0.i = global::java.lang.Character.toCodePoint((char) _r1.i, (char) _r0.i);
    _r0.i = ((global::java.util.regex.AbstractLineTerminator) _r2_o).isLineTerminator((int) _r0.i) ? 1 : 0;
    if (_r0.i == 0) goto label54;
    _r0.i = _r3.i;
    goto label13;
    label54:;
    _r0_o = ((global::java.util.regex.DotSet) _r4_o)._fnext;
    _r1.i = _r5.i + 2;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r1.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    goto label13;
    label63:;
    _r0_o = ((global::java.util.regex.DotSet) _r4_o)._flt;
    _r0.i = ((global::java.util.regex.AbstractLineTerminator) _r0_o).isLineTerminator((int) _r1.i) ? 1 : 0;
    if (_r0.i == 0) goto label73;
    _r0.i = _r3.i;
    goto label13;
    label73:;
    _r0_o = ((global::java.util.regex.DotSet) _r4_o)._fnext;
    _r1.i = _r5.i + 1;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r1.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    goto label13;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=.
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)46))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: java.lang.String getName()]
}

public override global::System.Object getNext(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: java.util.regex.AbstractSet getNext()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.regex.DotSet) _r1_o)._fnext;
    return (global::java.util.regex.AbstractSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: java.util.regex.AbstractSet getNext()]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: void setNext(java.util.regex.AbstractSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.DotSet) _r0_o)._fnext = (global::java.util.regex.AbstractSet) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: void setNext(java.util.regex.AbstractSet)]
}

public override int getType(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: int getType()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0.i = -2147483602;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: int getType()]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.DotSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.DotSet]
//XMLVM_END_WRAPPER[java.util.regex.DotSet]

} // end of class: DotSet

} // end of namespace: java.util.regex
