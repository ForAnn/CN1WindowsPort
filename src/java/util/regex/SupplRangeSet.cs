// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class SupplRangeSet: global::java.util.regex.JointSet {
public global::java.util.regex.AbstractCharClass _fchars;

public bool _falt;

public void @this(global::java.util.regex.AbstractCharClass n1, global::java.util.regex.AbstractSet n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: void <init>(java.util.regex.AbstractCharClass, java.util.regex.AbstractSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    ((global::java.util.regex.JointSet) _r1_o).@this();
    _r0.i = 0;
    ((global::java.util.regex.SupplRangeSet) _r1_o)._falt = 0!=_r0.i;
    _r0_o = ((global::java.util.regex.AbstractCharClass) _r2_o).getInstance();
    ((global::java.util.regex.SupplRangeSet) _r1_o)._fchars = (global::java.util.regex.AbstractCharClass) _r0_o;
    _r0.i = ((global::java.util.regex.AbstractCharClass) _r2_o)._falt ? 1 : 0;
    ((global::java.util.regex.SupplRangeSet) _r1_o)._falt = 0!=_r0.i;
    ((global::java.util.regex.SupplRangeSet) _r1_o)._fnext = (global::java.util.regex.AbstractSet) _r3_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: void <init>(java.util.regex.AbstractCharClass, java.util.regex.AbstractSet)]
}

public void @this(global::java.util.regex.AbstractCharClass n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: void <init>(java.util.regex.AbstractCharClass)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    ((global::java.util.regex.JointSet) _r1_o).@this();
    _r0.i = 0;
    ((global::java.util.regex.SupplRangeSet) _r1_o)._falt = 0!=_r0.i;
    _r0_o = ((global::java.util.regex.AbstractCharClass) _r2_o).getInstance();
    ((global::java.util.regex.SupplRangeSet) _r1_o)._fchars = (global::java.util.regex.AbstractCharClass) _r0_o;
    _r0.i = ((global::java.util.regex.AbstractCharClass) _r2_o)._falt ? 1 : 0;
    ((global::java.util.regex.SupplRangeSet) _r1_o)._falt = 0!=_r0.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: void <init>(java.util.regex.AbstractCharClass)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::System.Object _r4_o = null;
    global::org.xmlvm._nElement _r5;
    global::System.Object _r6_o = null;
    global::System.Object _r7_o = null;
    _r4_o = this;
    _r5.i = n1;
    _r6_o = n2;
    _r7_o = n3;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r7_o).getRightBound();
    if (_r5.i >= _r0.i) goto label59;
    _r1.i = _r5.i + 1;
    _r2.i = ((global::java.lang.CharSequence) _r6_o).charAt((int) _r5.i);
    _r3.i = ((global::java.util.regex.SupplRangeSet) _r4_o).contains((int) _r2.i) ? 1 : 0;
    if (_r3.i == 0) goto label28;
    _r3_o = ((global::java.util.regex.SupplRangeSet) _r4_o)._fnext;
    _r3.i = ((global::java.util.regex.AbstractSet) _r3_o).matches((int) _r1.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    if (_r3.i <= 0) goto label28;
    _r0.i = _r3.i;
    label27:;
    return _r0.i;
    label28:;
    if (_r1.i >= _r0.i) goto label59;
    _r0.i = _r1.i + 1;
    _r1.i = ((global::java.lang.CharSequence) _r6_o).charAt((int) _r1.i);
    _r3.i = global::java.lang.Character.isSurrogatePair((char) _r2.i, (char) _r1.i) ? 1 : 0;
    if (_r3.i == 0) goto label59;
    _r1.i = global::java.lang.Character.toCodePoint((char) _r2.i, (char) _r1.i);
    _r1.i = ((global::java.util.regex.SupplRangeSet) _r4_o).contains((int) _r1.i) ? 1 : 0;
    if (_r1.i == 0) goto label59;
    _r1_o = ((global::java.util.regex.SupplRangeSet) _r4_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    goto label27;
    label59:;
    _r0.i = -1;
    goto label27;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: java.lang.String getName()]
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=range:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)114)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1.i = ((global::java.util.regex.SupplRangeSet) _r2_o)._falt ? 1 : 0;
    if (_r1.i == 0) goto label32;
    // Value=^ 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)94)), unchecked((char) unchecked((uint) 32))}));
    label13:;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.util.regex.SupplRangeSet) _r2_o)._fchars;
    _r1_o = ((global::java.lang.Object) _r1_o).toString();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
    label32:;
    // Value= 
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)32))}));
    goto label13;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: java.lang.String getName()]
}

public virtual bool contains(int n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: boolean contains(int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    _r1_o = this;
    _r2.i = n1;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r1_o)._fchars;
    _r0.i = ((global::java.util.regex.AbstractCharClass) _r0_o).contains((int) _r2.i) ? 1 : 0;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: boolean contains(int)]
}

public override bool first(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: boolean first(java.util.regex.AbstractSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    global::System.Object _r3_o = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.regex.SupplCharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r2_o)._fchars;
    _r3_o = _r3_o;
    _r1.i = ((global::java.util.regex.SupplCharSet) _r3_o).getCodePoint();
    _r0.i = global::java.util.regex.AbstractCharClass.intersects((global::java.util.regex.AbstractCharClass) _r0_o, (int) _r1.i) ? 1 : 0;
    label16:;
    return _r0.i!=0;
    label17:;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.regex.CharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label34;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r2_o)._fchars;
    _r3_o = _r3_o;
    _r1.i = ((global::java.util.regex.CharSet) _r3_o).getChar();
    _r0.i = global::java.util.regex.AbstractCharClass.intersects((global::java.util.regex.AbstractCharClass) _r0_o, (int) _r1.i) ? 1 : 0;
    goto label16;
    label34:;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.regex.SupplRangeSet)) ? 1 : 0;
    if (_r0.i == 0) goto label49;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r2_o)._fchars;
    _r3_o = _r3_o;
    _r1_o = ((global::java.util.regex.SupplRangeSet) _r3_o)._fchars;
    _r0.i = global::java.util.regex.AbstractCharClass.intersects((global::java.util.regex.AbstractCharClass) _r0_o, (global::java.util.regex.AbstractCharClass) _r1_o) ? 1 : 0;
    goto label16;
    label49:;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.regex.RangeSet)) ? 1 : 0;
    if (_r0.i == 0) goto label66;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r2_o)._fchars;
    _r3_o = _r3_o;
    _r1_o = ((global::java.util.regex.RangeSet) _r3_o).getChars();
    _r0.i = global::java.util.regex.AbstractCharClass.intersects((global::java.util.regex.AbstractCharClass) _r0_o, (global::java.util.regex.AbstractCharClass) _r1_o) ? 1 : 0;
    goto label16;
    label66:;
    _r0.i = 1;
    goto label16;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: boolean first(java.util.regex.AbstractSet)]
}

public virtual global::System.Object getChars(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: java.util.regex.AbstractCharClass getChars()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r1_o)._fchars;
    return (global::java.util.regex.AbstractCharClass) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: java.util.regex.AbstractCharClass getChars()]
}

public override global::System.Object getNext(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: java.util.regex.AbstractSet getNext()]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r1_o = this;
    _r0_o = ((global::java.util.regex.SupplRangeSet) _r1_o)._fnext;
    return (global::java.util.regex.AbstractSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: java.util.regex.AbstractSet getNext()]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: void setNext(java.util.regex.AbstractSet)]
    global::System.Object _r0_o = null;
    global::System.Object _r1_o = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.SupplRangeSet) _r0_o)._fnext = (global::java.util.regex.AbstractSet) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: void setNext(java.util.regex.AbstractSet)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r1_o = null;
    global::System.Object _r2_o = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.SupplRangeSet]
//XMLVM_END_WRAPPER[java.util.regex.SupplRangeSet]

} // end of class: SupplRangeSet

} // end of namespace: java.util.regex
