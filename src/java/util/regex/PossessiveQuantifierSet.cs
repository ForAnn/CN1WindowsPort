// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class PossessiveQuantifierSet: global::java.util.regex.LeafQuantifierSet {
public void @this(global::java.util.regex.LeafSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveQuantifierSet: void <init>(java.util.regex.LeafSet, java.util.regex.AbstractSet, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    ((global::java.util.regex.LeafQuantifierSet) _r0_o).@this((global::java.util.regex.LeafSet) _r1_o, (global::java.util.regex.AbstractSet) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.PossessiveQuantifierSet: void <init>(java.util.regex.LeafSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nElement _r4;
    global::System.Object _r5_o = null;
    global::System.Object _r6_o = null;
    _r3_o = this;
    _r4.i = n1;
    _r5_o = n2;
    _r6_o = n3;
    _r0.i = _r4.i;
    label1:;
    _r1_o = ((global::java.util.regex.PossessiveQuantifierSet) _r3_o)._fleaf;
    _r1.i = ((global::java.util.regex.LeafSet) _r1_o).charCount();
    _r1.i = _r1.i + _r0.i;
    _r2.i = ((global::java.util.regex.MatchResultImpl) _r6_o).getRightBound();
    if (_r1.i > _r2.i) goto label23;
    _r1_o = ((global::java.util.regex.PossessiveQuantifierSet) _r3_o)._fleaf;
    _r1.i = ((global::java.util.regex.LeafSet) _r1_o).accepts((int) _r0.i, (global::java.lang.CharSequence) _r5_o);
    _r2.i = 1;
    if (_r1.i >= _r2.i) goto label30;
    label23:;
    _r1_o = ((global::java.util.regex.PossessiveQuantifierSet) _r3_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r5_o, (global::java.util.regex.MatchResultImpl) _r6_o);
    return _r0.i;
    label30:;
    _r0.i = _r0.i + _r1.i;
    goto label1;
//XMLVM_END_WRAPPER[java.util.regex.PossessiveQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.PossessiveQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.PossessiveQuantifierSet]

} // end of class: PossessiveQuantifierSet

} // end of namespace: java.util.regex
