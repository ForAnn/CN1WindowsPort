// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class ReluctantQuantifierSet: global::java.util.regex.LeafQuantifierSet {
public void @this(global::java.util.regex.LeafSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.ReluctantQuantifierSet: void <init>(java.util.regex.LeafSet, java.util.regex.AbstractSet, int)]
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
    ((global::java.util.regex.LeafQuantifierSet) _r0_o).@this((global::java.util.regex.LeafSet) _r1_o, (global::java.util.regex.AbstractSet) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.ReluctantQuantifierSet: void <init>(java.util.regex.LeafSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.ReluctantQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r5_o = this;
    _r6.i = n1;
    _r7_o = n2;
    _r8_o = n3;
    _r0.i = _r6.i;
    label1:;
    _r1_o = ((global::java.util.regex.ReluctantQuantifierSet) _r5_o)._fnext;
    _r1.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r7_o, (global::java.util.regex.MatchResultImpl) _r8_o);
    if (_r1.i < 0) goto label11;
    _r0.i = _r1.i;
    label10:;
    return _r0.i;
    label11:;
    _r2_o = ((global::java.util.regex.ReluctantQuantifierSet) _r5_o)._fleaf;
    _r2.i = ((global::java.util.regex.LeafSet) _r2_o).charCount();
    _r2.i = _r2.i + _r0.i;
    _r3.i = ((global::java.util.regex.MatchResultImpl) _r8_o).getRightBound();
    if (_r2.i > _r3.i) goto label41;
    _r1_o = ((global::java.util.regex.ReluctantQuantifierSet) _r5_o)._fleaf;
    _r1.i = ((global::java.util.regex.LeafSet) _r1_o).accepts((int) _r0.i, (global::java.lang.CharSequence) _r7_o);
    _r0.i = _r0.i + _r1.i;
    _r4.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r4.i;
    label34:;
    _r2.i = 1;
    if (_r0.i >= _r2.i) goto label39;
    _r0.i = -1;
    goto label10;
    label39:;
    _r0.i = _r1.i;
    goto label1;
    label41:;
    _r4.i = _r1.i;
    _r1.i = _r0.i;
    _r0.i = _r4.i;
    goto label34;
//XMLVM_END_WRAPPER[java.util.regex.ReluctantQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.ReluctantQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.ReluctantQuantifierSet]

} // end of class: ReluctantQuantifierSet

} // end of namespace: java.util.regex
