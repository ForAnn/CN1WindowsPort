// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class UEOLSet: global::java.util.regex.AbstractSet {
private int _fconsCounter;

public void @this(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UEOLSet: void <init>(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.regex.AbstractSet) _r0_o).@this();
    ((global::java.util.regex.UEOLSet) _r0_o)._fconsCounter = _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.UEOLSet: void <init>(int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UEOLSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    _r3_o = this;
    _r4.i = n1;
    _r5_o = n2;
    _r6_o = n3;
    _r2.i = 1;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r6_o).hasAnchoringBounds() ? 1 : 0;
    if (_r0.i == 0) goto label26;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r6_o).getRightBound();
    label11:;
    if (_r4.i < _r0.i) goto label31;
    _r0.i = ((global::java.util.regex.UEOLSet) _r3_o)._fconsCounter;
    _r1.i = 0;
    ((global::java.util.regex.MatchResultImpl) _r6_o).setConsumed((int) _r0.i, (int) _r1.i);
    _r0_o = ((global::java.util.regex.UEOLSet) _r3_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r4.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    label25:;
    return _r0.i;
    label26:;
    _r0.i = ((global::java.lang.CharSequence) _r5_o).length();
    goto label11;
    label31:;
    _r0.i = _r0.i - _r4.i;
    if (_r0.i != _r2.i) goto label56;
    _r0.i = ((global::java.lang.CharSequence) _r5_o).charAt((int) _r4.i);
    _r1.i = 10;
    if (_r0.i != _r1.i) goto label56;
    _r0.i = ((global::java.util.regex.UEOLSet) _r3_o)._fconsCounter;
    ((global::java.util.regex.MatchResultImpl) _r6_o).setConsumed((int) _r0.i, (int) _r2.i);
    _r0_o = ((global::java.util.regex.UEOLSet) _r3_o)._fnext;
    _r1.i = _r4.i + 1;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r1.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    goto label25;
    label56:;
    _r0.i = -1;
    goto label25;
//XMLVM_END_WRAPPER[java.util.regex.UEOLSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UEOLSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
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
    _r3_o = this;
    _r4_o = n1;
    _r0.i = ((global::java.util.regex.UEOLSet) _r3_o)._fconsCounter;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r4_o).getConsumed((int) _r0.i);
    if (_r0.i < 0) goto label18;
    if (_r0.i > 0) goto label18;
    _r0.i = 0;
    label11:;
    _r1.i = ((global::java.util.regex.UEOLSet) _r3_o)._fconsCounter;
    _r2.i = -1;
    ((global::java.util.regex.MatchResultImpl) _r4_o).setConsumed((int) _r1.i, (int) _r2.i);
    return _r0.i!=0;
    label18:;
    _r0.i = 1;
    goto label11;
//XMLVM_END_WRAPPER[java.util.regex.UEOLSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.UEOLSet: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    // Value=<EOL>
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 69)), unchecked((char) unchecked((uint) 79)), unchecked((char) unchecked((uint) 76)), unchecked((char) unchecked((uint) 62))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.UEOLSet: java.lang.String getName()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.UEOLSet]
//XMLVM_END_WRAPPER[java.util.regex.UEOLSet]

} // end of class: UEOLSet

} // end of namespace: java.util.regex
