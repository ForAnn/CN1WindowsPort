// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace java.util.regex {
public class LowSurrogateCharSet: global::java.util.regex.JointSet {
private char _flow;

public void @this(char n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: void <init>(char)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1.i = n1;
    ((global::java.util.regex.JointSet) _r0_o).@this();
    ((global::java.util.regex.LowSurrogateCharSet) _r0_o)._flow = (char) _r1.i;
    return;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: void <init>(char)]
}

public override global::System.Object getNext(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: java.util.regex.AbstractSet getNext()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0_o = ((global::java.util.regex.LowSurrogateCharSet) _r1_o)._fnext;
    return (global::java.util.regex.AbstractSet) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: java.util.regex.AbstractSet getNext()]
}

public override void setNext(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: void setNext(java.util.regex.AbstractSet)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::java.util.regex.LowSurrogateCharSet) _r0_o)._fnext = (global::java.util.regex.AbstractSet) _r1_o;
    return;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: void setNext(java.util.regex.AbstractSet)]
}

public override int matches(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    _r3.i = 1;
    _r2.i = -1;
    _r0.i = _r5.i + 1;
    _r1.i = ((global::java.util.regex.MatchResultImpl) _r7_o).getRightBound();
    if (_r0.i <= _r1.i) goto label14;
    ((global::java.util.regex.MatchResultImpl) _r7_o)._fhitEnd = 0!=_r3.i;
    _r0.i = _r2.i;
    label13:;
    return _r0.i;
    label14:;
    _r0.i = ((global::java.lang.CharSequence) _r6_o).charAt((int) _r5.i);
    _r1.i = ((global::java.util.regex.MatchResultImpl) _r7_o).getLeftBound();
    if (_r5.i <= _r1.i) goto label38;
    _r1.i = _r5.i - _r3.i;
    _r1.i = ((global::java.lang.CharSequence) _r6_o).charAt((int) _r1.i);
    _r1.i = global::java.lang.Character.isHighSurrogate((char) _r1.i) ? 1 : 0;
    if (_r1.i == 0) goto label38;
    _r0.i = _r2.i;
    goto label13;
    label38:;
    _r1.i = ((global::java.util.regex.LowSurrogateCharSet) _r4_o)._flow;
    if (_r1.i != _r0.i) goto label51;
    _r0_o = ((global::java.util.regex.LowSurrogateCharSet) _r4_o)._fnext;
    _r1.i = _r5.i + 1;
    _r0.i = ((global::java.util.regex.AbstractSet) _r0_o).matches((int) _r1.i, (global::java.lang.CharSequence) _r6_o, (global::java.util.regex.MatchResultImpl) _r7_o);
    goto label13;
    label51:;
    _r0.i = _r2.i;
    goto label13;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: int matches(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override int find(int n1, global::java.lang.CharSequence n2, global::java.util.regex.MatchResultImpl n3){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: int find(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r8_o = this;
    _r9.i = n1;
    _r10_o = n2;
    _r11_o = n3;
    _r7.i = -1;
    _r1.i = ((_r10_o != null) && (_r10_o is global::java.lang.String)) ? 1 : 0;
    if (_r1.i == 0) goto label65;
    _r0_o = _r10_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r2.i = ((global::java.util.regex.MatchResultImpl) _r11_o).getLeftBound();
    _r3.i = ((global::java.util.regex.MatchResultImpl) _r11_o).getRightBound();
    _r4.i = _r9.i;
    label18:;
    if (_r4.i < _r3.i) goto label22;
    _r1.i = _r7.i;
    label21:;
    return _r1.i;
    label22:;
    _r5.i = ((global::java.util.regex.LowSurrogateCharSet) _r8_o)._flow;
    _r4.i = ((global::java.lang.String) _r1_o).indexOf((int) _r5.i, (int) _r4.i);
    if (_r4.i >= 0) goto label32;
    _r1.i = _r7.i;
    goto label21;
    label32:;
    if (_r4.i <= _r2.i) goto label50;
    _r5.i = 1;
    _r5.i = _r4.i - _r5.i;
    _r5.i = ((global::java.lang.String) _r1_o).charAt((int) _r5.i);
    _r5.i = global::java.lang.Character.isHighSurrogate((char) _r5.i) ? 1 : 0;
    if (_r5.i == 0) goto label50;
    _r4.i = _r4.i + 1;
    goto label18;
    label50:;
    _r5_o = ((global::java.util.regex.LowSurrogateCharSet) _r8_o)._fnext;
    _r6.i = _r4.i + 1;
    _r5.i = ((global::java.util.regex.AbstractSet) _r5_o).matches((int) _r6.i, (global::java.lang.CharSequence) _r10_o, (global::java.util.regex.MatchResultImpl) _r11_o);
    if (_r5.i < 0) goto label62;
    _r1.i = _r4.i;
    goto label21;
    label62:;
    _r4.i = _r4.i + 1;
    goto label18;
    label65:;
    _r1.i = base.find((int) _r9.i, (global::java.lang.CharSequence) _r10_o, (global::java.util.regex.MatchResultImpl) _r11_o);
    goto label21;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: int find(int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override int findBack(int n1, int n2, global::java.lang.CharSequence n3, global::java.util.regex.MatchResultImpl n4){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: int findBack(int, int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r7_o = this;
    _r8.i = n1;
    _r9.i = n2;
    _r10_o = n3;
    _r11_o = n4;
    _r6.i = -1;
    _r1.i = ((_r10_o != null) && (_r10_o is global::java.lang.String)) ? 1 : 0;
    if (_r1.i == 0) goto label63;
    _r2.i = ((global::java.util.regex.MatchResultImpl) _r11_o).getLeftBound();
    _r0_o = _r10_o;
    _r0_o = _r0_o;
    _r1_o = _r0_o;
    _r3.i = _r9.i;
    label14:;
    if (_r3.i >= _r8.i) goto label18;
    _r1.i = _r6.i;
    label17:;
    return _r1.i;
    label18:;
    _r4.i = ((global::java.util.regex.LowSurrogateCharSet) _r7_o)._flow;
    _r3.i = ((global::java.lang.String) _r1_o).lastIndexOf((int) _r4.i, (int) _r3.i);
    if (_r3.i < 0) goto label28;
    if (_r3.i >= _r8.i) goto label30;
    label28:;
    _r1.i = _r6.i;
    goto label17;
    label30:;
    if (_r3.i <= _r2.i) goto label48;
    _r4.i = 1;
    _r4.i = _r3.i - _r4.i;
    _r4.i = ((global::java.lang.String) _r1_o).charAt((int) _r4.i);
    _r4.i = global::java.lang.Character.isHighSurrogate((char) _r4.i) ? 1 : 0;
    if (_r4.i == 0) goto label48;
    _r3.i = _r3.i + -2;
    goto label14;
    label48:;
    _r4_o = ((global::java.util.regex.LowSurrogateCharSet) _r7_o)._fnext;
    _r5.i = _r3.i + 1;
    _r4.i = ((global::java.util.regex.AbstractSet) _r4_o).matches((int) _r5.i, (global::java.lang.CharSequence) _r10_o, (global::java.util.regex.MatchResultImpl) _r11_o);
    if (_r4.i < 0) goto label60;
    _r1.i = _r3.i;
    goto label17;
    label60:;
    _r3.i = _r3.i + -1;
    goto label14;
    label63:;
    _r1.i = base.findBack((int) _r8.i, (int) _r9.i, (global::java.lang.CharSequence) _r10_o, (global::java.util.regex.MatchResultImpl) _r11_o);
    goto label17;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: int findBack(int, int, java.lang.CharSequence, java.util.regex.MatchResultImpl)]
}

public override global::System.Object getName(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: java.lang.String getName()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nElement _r2;
    global::System.Object _r2_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r2_o = this;
    _r0_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r0_o).@this();
    _r1.i = ((global::java.util.regex.LowSurrogateCharSet) _r2_o)._flow;
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).append((char) _r1.i);
    _r0_o = ((global::java.lang.StringBuilder) _r0_o).toString();
    return (global::java.lang.String) _r0_o;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: java.lang.String getName()]
}

public virtual int getChar(){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: int getChar()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r1_o = this;
    _r0.i = ((global::java.util.regex.LowSurrogateCharSet) _r1_o)._flow;
    return _r0.i;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: int getChar()]
}

public override bool first(global::java.util.regex.AbstractSet n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: boolean first(java.util.regex.AbstractSet)]
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
    _r4_o = this;
    _r5_o = n1;
    _r3.i = 1;
    _r2.i = 0;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.regex.CharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label8;
    _r0.i = _r2.i;
    label7:;
    return _r0.i!=0;
    label8:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.regex.RangeSet)) ? 1 : 0;
    if (_r0.i == 0) goto label14;
    _r0.i = _r2.i;
    goto label7;
    label14:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.regex.SupplRangeSet)) ? 1 : 0;
    if (_r0.i == 0) goto label20;
    _r0.i = _r2.i;
    goto label7;
    label20:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.regex.SupplCharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label26;
    _r0.i = _r2.i;
    goto label7;
    label26:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.regex.HighSurrogateCharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label32;
    _r0.i = _r2.i;
    goto label7;
    label32:;
    _r0.i = ((_r5_o != null) && (_r5_o is global::java.util.regex.LowSurrogateCharSet)) ? 1 : 0;
    if (_r0.i == 0) goto label48;
    _r5_o = _r5_o;
    _r0.i = ((global::java.util.regex.LowSurrogateCharSet) _r5_o)._flow;
    _r1.i = ((global::java.util.regex.LowSurrogateCharSet) _r4_o)._flow;
    if (_r0.i != _r1.i) goto label46;
    _r0.i = _r3.i;
    goto label7;
    label46:;
    _r0.i = _r2.i;
    goto label7;
    label48:;
    _r0.i = _r3.i;
    goto label7;
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: boolean first(java.util.regex.AbstractSet)]
}

public override bool hasConsumed(global::java.util.regex.MatchResultImpl n1){
//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
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
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet: boolean hasConsumed(java.util.regex.MatchResultImpl)]
}

//XMLVM_BEGIN_WRAPPER[java.util.regex.LowSurrogateCharSet]
//XMLVM_END_WRAPPER[java.util.regex.LowSurrogateCharSet]

} // end of class: LowSurrogateCharSet

} // end of namespace: java.util.regex
