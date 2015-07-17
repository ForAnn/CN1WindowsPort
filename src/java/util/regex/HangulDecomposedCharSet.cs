// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class HangulDecomposedCharSet: global::java.util.regex.JointSet {
private global::org.xmlvm._nArrayAdapter<char> _fdecomposedChar;

private global::java.lang.String _fdecomposedCharUTF16;

private int _fdecomposedCharLength;

public void @this(global::org.xmlvm._nArrayAdapter<char> n1, int n2){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: void <init>(char[], int)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r3.i = n2;
    ((global::java.util.regex.JointSet) _r1_o).@this();
    _r0_o = null;
    ((global::java.util.regex.HangulDecomposedCharSet) _r1_o)._fdecomposedCharUTF16 = (global::java.lang.String) _r0_o;
    ((global::java.util.regex.HangulDecomposedCharSet) _r1_o)._fdecomposedChar = (global::org.xmlvm._nArrayAdapter<char>) _r2_o;
    ((global::java.util.regex.HangulDecomposedCharSet) _r1_o)._fdecomposedCharLength = _r3.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: void <init>(char[], int)]
}

public override global::System.Object getNext(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: java.util.regex.AbstractSet getNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.regex.HangulDecomposedCharSet) _r1_o)._fnext;
    return (global::java.util.regex.AbstractSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: java.util.regex.AbstractSet getNext()]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: void setNext(java.util.regex.AbstractSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.HangulDecomposedCharSet) _r0_o)._fnext = (global::java.util.regex.AbstractSet) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: void setNext(java.util.regex.AbstractSet)]
}

private global::System.Object getDecomposedChar(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: java.lang.String getDecomposedChar()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = ((global::java.util.regex.HangulDecomposedCharSet) _r2_o)._fdecomposedCharUTF16;
    if (_r0_o != null) goto label14;
    _r0_o = new global::java.lang.String();
    _r1_o = ((global::java.util.regex.HangulDecomposedCharSet) _r2_o)._fdecomposedChar;
    ((global::java.lang.String) _r0_o).@this((global::org.xmlvm._nArrayAdapter<char>) _r1_o);
    ((global::java.util.regex.HangulDecomposedCharSet) _r2_o)._fdecomposedCharUTF16 = (global::java.lang.String) _r0_o;
    label13:;
    return (global::java.lang.String) _r0_o;
    label14:;
    _r0_o = ((global::java.util.regex.HangulDecomposedCharSet) _r2_o)._fdecomposedCharUTF16;
    goto label13;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: java.lang.String getDecomposedChar()]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    // Value=decomposed Hangul syllable:
    _r1_o = new global::java.lang.String();
    ((global::java.lang.String)_r1_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)100)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 99)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 109)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 72)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 103)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 121)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 98)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 58))}));
    ((global::java.lang.StringBuilder) _r0_o).@this((global::java.lang.String) _r1_o);
    _r1_o = ((global::java.util.regex.HangulDecomposedCharSet) _r2_o).getDecomposedChar();
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((global::java.lang.String) _r1_o);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: java.lang.String getName()]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nElement _r10;
    global::System.Object _r10_o = null;
    global::org.xmlvm._nElement _r11;
    global::System.Object _r11_o = null;
    global::org.xmlvm._nElement _r12;
    global::System.Object _r12_o = null;
    global::org.xmlvm._nElement _r13;
    global::System.Object _r13_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r10_o = this;
    _r11.i = n1;
    _r12_o = n2;
    _r13_o = n3;
    _r0.i = ((global::java.util.regex.MatchResultImpl) _r13_o).getRightBound();
    _r1.i = 0;
    _r2.i = 3;
    _r2_o = new global::org.xmlvm._nArrayAdapter<int>(new int[_r2.i]);
    _r3.i = -1;
    _r4.i = -1;
    if (_r11.i < _r0.i) goto label14;
    _r0.i = -1;
    label13:;
    return _r0.i;
    label14:;
    _r5.i = _r11.i + 1;
    _r6.i = ((global::java.lang.CharSequence) _r12_o).charAt((int) _r11.i);
    _r7_o = global::java.util.regex.Lexer.getHangulDecomposition((int) _r6.i);
    if (_r7_o != null) goto label174;
    _r7.i = _r1.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i] = _r6.i;
    _r1.i = 4352;
    _r1.i = _r6.i - _r1.i;
    if (_r1.i < 0) goto label40;
    _r8.i = 19;
    if (_r1.i < _r8.i) goto label42;
    label40:;
    _r0.i = -1;
    goto label13;
    label42:;
    if (_r5.i >= _r0.i) goto label210;
    _r1.i = ((global::java.lang.CharSequence) _r12_o).charAt((int) _r5.i);
    _r3.i = 4449;
    _r3.i = _r1.i - _r3.i;
    _r9.i = _r3.i;
    _r3.i = _r1.i;
    _r1.i = _r9.i;
    label55:;
    if (_r1.i < 0) goto label61;
    _r6.i = 21;
    if (_r1.i < _r6.i) goto label63;
    label61:;
    _r0.i = -1;
    goto label13;
    label63:;
    _r1.i = _r5.i + 1;
    _r5.i = _r7.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r7.i] = _r3.i;
    if (_r1.i >= _r0.i) goto label208;
    _r0.i = ((global::java.lang.CharSequence) _r12_o).charAt((int) _r1.i);
    _r3.i = 4519;
    _r3.i = _r0.i - _r3.i;
    _r9.i = _r3.i;
    _r3.i = _r0.i;
    _r0.i = _r9.i;
    label82:;
    if (_r0.i < 0) goto label88;
    _r4.i = 28;
    if (_r0.i < _r4.i) goto label122;
    label88:;
    _r0.i = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedCharLength;
    _r3.i = 2;
    if (_r0.i != _r3.i) goto label120;
    _r0.i = 0;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    _r3_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedChar;
    _r4.i = 0;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r3_o)[_r4.i];
    if (_r0.i != _r3.i) goto label120;
    _r0.i = 1;
    _r0.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r0.i];
    _r2_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedChar;
    _r3.i = 1;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r3.i];
    if (_r0.i != _r2.i) goto label120;
    _r0_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r1.i, (global::java.lang.CharSequence) _r12_o, (global::java.util.regex.MatchResultImpl) _r13_o);
    goto label13;
    label120:;
    _r0.i = -1;
    goto label13;
    label122:;
    _r0.i = _r1.i + 1;
    _r1.i = _r5.i + 1;
    ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r5.i] = _r3.i;
    _r1.i = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedCharLength;
    _r3.i = 3;
    if (_r1.i != _r3.i) goto label171;
    _r1.i = 0;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    _r3_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedChar;
    _r4.i = 0;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r3_o)[_r4.i];
    if (_r1.i != _r3.i) goto label171;
    _r1.i = 1;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    _r3_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedChar;
    _r4.i = 1;
    _r3.i = ((global::org.xmlvm._nArrayAdapter<char>) _r3_o)[_r4.i];
    if (_r1.i != _r3.i) goto label171;
    _r1.i = 2;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r2_o)[_r1.i];
    _r2_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedChar;
    _r3.i = 2;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r3.i];
    if (_r1.i != _r2.i) goto label171;
    _r1_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r1_o).matches((int) _r0.i, (global::java.lang.CharSequence) _r12_o, (global::java.util.regex.MatchResultImpl) _r13_o);
    goto label13;
    label171:;
    _r0.i = -1;
    goto label13;
    label174:;
    _r0.i = 0;
    _r1.i = ((global::org.xmlvm._nIArray) _r7_o).Length;
    _r2.i = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedCharLength;
    if (_r1.i == _r2.i) goto label196;
    _r0.i = -1;
    goto label13;
    label183:;
    _r1.i = ((global::org.xmlvm._nArrayAdapter<int>) _r7_o)[_r0.i];
    _r2_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedChar;
    _r2.i = ((global::org.xmlvm._nArrayAdapter<char>) _r2_o)[_r0.i];
    if (_r1.i == _r2.i) goto label194;
    _r0.i = -1;
    goto label13;
    label194:;
    _r0.i = _r0.i + 1;
    label196:;
    _r1.i = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fdecomposedCharLength;
    if (_r0.i < _r1.i) goto label183;
    _r0_o = ((global::java.util.regex.HangulDecomposedCharSet) _r10_o)._fnext;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r5.i, (global::java.lang.CharSequence) _r12_o, (global::java.util.regex.MatchResultImpl) _r13_o);
    goto label13;
    label208:;
    _r0.i = _r4.i;
    goto label82;
    label210:;
    _r1.i = _r3.i;
    _r3.i = _r6.i;
    goto label55;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override bool first(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: boolean first(java.util.regex.AbstractSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nElement _r3;
    global::System.Object _r3_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r3_o = n1;
    _r0.i = ((_r3_o != null) && (_r3_o is global::java.util.regex.HangulDecomposedCharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label19;
    _r3_o = _r3_o;
    _r0_o = ((global::java.util.regex.HangulDecomposedCharSet) _r3_o).getDecomposedChar();
    _r1_o = ((global::java.util.regex.HangulDecomposedCharSet) _r2_o).getDecomposedChar();
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    label18:;
    return _r0.i!=0;
    label19:;
    _r0.i = 1;
    goto label18;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: boolean first(java.util.regex.AbstractSet)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r2_o = n1;
    _r0.i = 1;
    return _r0.i!=0;
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.HangulDecomposedCharSet]
//XMLVM_END_WRAPPER[java.util.regex.HangulDecomposedCharSet]

} // end of class: HangulDecomposedCharSet

} // end of namespace: java.util.regex
