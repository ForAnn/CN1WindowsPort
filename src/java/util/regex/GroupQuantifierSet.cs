// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class GroupQuantifierSet: global::java.util.regex.QuantifierSet {
new public void @this(global::java.util.regex.AbstractSet n1, global::java.util.regex.AbstractSet n2, int n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.GroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    _r0_o = this;
    _r1_o = n1;
    _r2_o = n2;
    _r3.i = n3;
    ((global::java.util.regex.QuantifierSet) _r0_o).@this((global::java.util.regex.AbstractSet) _r1_o, (global::java.util.regex.AbstractSet) _r2_o, (int) _r3.i);
    return;
//XMLVM_END_WRAPPER[java.util.regex.GroupQuantifierSet: void <init>(java.util.regex.AbstractSet, java.util.regex.AbstractSet, int)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.GroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    _r1_o = this;
    _r2.i = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = ((global::java.util.regex.GroupQuantifierSet) _r1_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).hasConsumed((global::java.util.regex.MatchResultImpl) _r4_o) ? 1 : 0;
    if (_r0.i != 0) goto label15;
    _r0_o = ((global::java.util.regex.GroupQuantifierSet) _r1_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    label14:;
    return _r0.i;
    label15:;
    _r0_o = ((global::java.util.regex.GroupQuantifierSet) _r1_o)._finnerSet;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    if (_r0.i >= 0) goto label14;
    _r0_o = ((global::java.util.regex.GroupQuantifierSet) _r1_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r2.i, (global::java.lang.CharSequence) _r3_o, (global::java.util.regex.MatchResultImpl) _r4_o);
    goto label14;
//XMLVM_END_WRAPPER[java.util.regex.GroupQuantifierSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.GroupQuantifierSet: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    // Value=<GroupQuant>
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)60)), unchecked((char) unchecked((uint) 71)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 81)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 62))}));
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.GroupQuantifierSet: java.lang.String getName()]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.GroupQuantifierSet]
//XMLVM_END_WRAPPER[java.util.regex.GroupQuantifierSet]

} // end of class: GroupQuantifierSet

} // end of namespace: java.util.regex
