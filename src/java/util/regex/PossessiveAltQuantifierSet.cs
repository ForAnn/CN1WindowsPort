// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class PossessiveAltQuantifierSet: global::java.util.regex.AltQuantifierSet {
public void @this(global::java.util.regex.LeafSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveAltQuantifierSet: void <init>(java.util.regex.LeafSet, java.util.regex.AbstractSet, int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    ((global::java.util.regex.AltQuantifierSet) _r0_o).@this((global::java.util.regex.LeafSet) _r1_o, (global::java.util.regex.AbstractSet) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.PossessiveAltQuantifierSet: void <init>(java.util.regex.LeafSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveAltQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3.i = n1;
    _r4_o = n2;
    _r5_o = n3;
    _r0_o = ((global::java.util.regex.PossessiveAltQuantifierSet) _r2_o)._fleaf;
    _r0.i = ((global::java.util.regex.LeafSet) _r0_o).charCount();
    _r0.i = _r0.i + _r3.i;
    _r1.i = ((global::java.util.regex.MatchResultImpl) _r5_o).getRightBound();
    if (_r0.i > _r1.i) goto label30;
    _r0_o = ((global::java.util.regex.PossessiveAltQuantifierSet) _r2_o)._fleaf;
    _r0.i = ((global::java.util.regex.LeafSet) _r0_o).accepts((int) _r3.i, (global::java.lang.CharSequence) _r4_o);
    _r1.i = 1;
    if (_r0.i < _r1.i) goto label30;
    _r0.i = _r0.i + _r3.i;
    label23:;
    _r1_o = ((global::java.util.regex.PossessiveAltQuantifierSet) _r2_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r4_o, (global::java.util.regex.MatchResultImpl) _r5_o);
    return _r0.i;
    label30:;
    _r0.i = _r3.i;
    goto label23;
//XMLVM_END_WRAPPER[java.util.regex.PossessiveAltQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveAltQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.PossessiveAltQuantifierSet]

} // end of class: PossessiveAltQuantifierSet

} // end of namespace: java.util.regex
