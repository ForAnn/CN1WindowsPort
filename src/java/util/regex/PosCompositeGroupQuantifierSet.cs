// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class PosCompositeGroupQuantifierSet: global::java.util.regex.CompositeGroupQuantifierSet {
public void @this(global::java.util.regex.Quantifier n1, global::java.util.regex.AbstractSet n2, global::java.util.regex.AbstractSet n3, int n4, int n5){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PosCompositeGroupQuantifierSet: void <init>(java.util.regex.Quantifier, java.util.regex.AbstractSet, java.util.regex.AbstractSet, int, int)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r5.i = n4;
    _r6.i = n5;
    ((global::java.util.regex.CompositeGroupQuantifierSet) _r1_o).@this((global::java.util.regex.Quantifier) _r2_o, (global::java.util.regex.AbstractSet) _r3_o, (global::java.util.regex.AbstractSet) _r4_o, (int) _r5.i, (int) _r6.i);
    _r0_o = global::java.util.regex.FSet._fposFSet;
    ((global::java.util.regex.AbstractSet) _r3_o).setNext((global::java.util.regex.AbstractSet) _r0_o);
    return;
//XMLVM_END_WRAPPER[java.util.regex.PosCompositeGroupQuantifierSet: void <init>(java.util.regex.Quantifier, java.util.regex.AbstractSet, java.util.regex.AbstractSet, int, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.PosCompositeGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r4_o = this;
    _r5.i = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r0.i = 0;
    _r1_o = ((global::java.util.regex.PosCompositeGroupQuantifierSet) _r4_o)._fquantifier;
    _r1.i = ((global::java.util.regex.Quantifier) _r1_o).max();
    _r2.i = _r5.i;
    label8:;
    _r3_o = ((global::java.util.regex.PosCompositeGroupQuantifierSet) _r4_o)._finnerSet;
    _r3.i = ((global::java.util.regex.AbstractSet) _r3_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    if (_r3.i <= _r2.i) goto label18;
    if (_r0.i < _r1.i) goto label30;
    label18:;
    if (_r3.i >= 0) goto label34;
    _r1_o = ((global::java.util.regex.PosCompositeGroupQuantifierSet) _r4_o)._fquantifier;
    _r1.i = ((global::java.util.regex.Quantifier) _r1_o).min();
    if (_r0.i >= _r1.i) goto label34;
    _r0.i = -1;
    label29:;
    return _r0.i;
    label30:;
    _r0.i = _r0.i + 1;
    _r2.i = _r3.i;
    goto label8;
    label34:;
    _r0_o = ((global::java.util.regex.PosCompositeGroupQuantifierSet) _r4_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    goto label29;
//XMLVM_END_WRAPPER[java.util.regex.PosCompositeGroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.PosCompositeGroupQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.PosCompositeGroupQuantifierSet]

} // end of class: PosCompositeGroupQuantifierSet

} // end of namespace: java.util.regex
