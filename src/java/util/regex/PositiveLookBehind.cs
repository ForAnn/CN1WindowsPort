// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class PositiveLookBehind: global::java.util.regex.AtomicJointSet {
public void @this(global::java.util.ArrayList n1, global::java.util.regex.FSet n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PositiveLookBehind: void <init>(java.util.ArrayList, java.util.regex.FSet)]
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
    ((global::java.util.regex.AtomicJointSet) _r0_o).@this((global::java.util.ArrayList) _r1_o, (global::java.util.regex.FSet) _r2_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.PositiveLookBehind: void <init>(java.util.ArrayList, java.util.regex.FSet)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PositiveLookBehind: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nElement _r9;
    global::System.Object _r9_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7.i = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r4.i = 0;
    _r5.i = -1;
    _r0_o = ((global::java.util.regex.PositiveLookBehind) _r6_o)._fchildren;
    _r1.i = ((global::java.util.ArrayList) _r0_o).size();
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r9_o).hasTransparentBounds() ? 1 : 0;
    if (_r0.i == 0) goto label32;
    _r2.i = _r4.i;
    label15:;
    _r0_o = ((global::java.util.regex.PositiveLookBehind) _r6_o)._fnext;
    _r3.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r7.i, (global::java.lang.CharSequence) _r8_o, (global::java.util.regex.MatchResultImpl) _r9_o);
    if (_r3.i < 0) goto label30;
    _r0.i = ((global::java.util.regex.PositiveLookBehind) _r6_o)._fgroupIndex;
    ((global::java.util.regex.MatchResultImpl) _r9_o).setConsumed((int) _r0.i, (int) _r7.i);
    label28:;
    if (_r4.i < _r1.i) goto label38;
    label30:;
    _r0.i = _r5.i;
    label31:;
    return _r0.i;
    label32:;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r9_o).getLeftBound();
    _r2.i = _r0.i;
    goto label15;
    label38:;
    _r0_o = ((global::java.util.regex.PositiveLookBehind) _r6_o)._fchildren;
    _r0_o = ((global::java.util.ArrayList) _r0_o).get((int) _r4.i);
    _r0_o = _r0_o;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).findBack((int) _r2.i, (int) _r7.i, (global::java.lang.CharSequence) _r8_o, (global::java.util.regex.MatchResultImpl) _r9_o);
    if (_r0.i < 0) goto label59;
    _r0.i = ((global::java.util.regex.PositiveLookBehind) _r6_o)._fgroupIndex;
    ((global::java.util.regex.MatchResultImpl) _r9_o).setConsumed((int) _r0.i, (int) _r5.i);
    _r0.i = _r3.i;
    goto label31;
    label59:;
    _r0.i = _r4.i + 1;
    _r4.i = _r0.i;
    goto label28;
//XMLVM_END_WRAPPER[java.util.regex.PositiveLookBehind: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PositiveLookBehind: boolean hasConsumed(java.util.regex.MatchResultImpl)]
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
//XMLVM_END_WRAPPER[java.util.regex.PositiveLookBehind: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PositiveLookBehind: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=PosBehindJointSet
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)80)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 66)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 74)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 83)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 116))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.PositiveLookBehind: java.lang.String getName()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.PositiveLookBehind]
//XMLVM_END_WRAPPER[java.util.regex.PositiveLookBehind]

} // end of class: PositiveLookBehind

} // end of namespace: java.util.regex
