// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class IndexEvaluator: global::com.codename1.processing.AbstractEvaluator {

static IndexEvaluator() {
    @static();
}

public static global::java.lang.String _fFUNC_1LAST;

public static global::java.lang.String _fFUNC_1POSITION;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.processing.AbstractEvaluator) _r0_o).@this((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: void <init>(java.lang.String)]
}

private global::System.Object _1getByPositionLess(global::java.util.List n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: java.util.List _getByPositionLess(java.util.List, int)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r2.i = ((global::java.util.List) _r4_o).size();
    if (_r5.i <= _r2.i) goto label8;
    _r2_o = _r4_o;
    label7:;
    return (global::java.util.List) _r2_o;
    label8:;
    if (_r5.i >= 0) goto label12;
    _r2_o = null;
    goto label7;
    label12:;
    _r2.i = ((_r4_o != null) && (_r4_o is global::java.util.Vector)) ? 1 : 0;
    if (_r2.i == 0) goto label34;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    label21:;
    _r1.i = 0;
    label22:;
    if (_r1.i >= _r5.i) goto label40;
    _r2_o = ((global::java.util.List) _r4_o).get((int) _r1.i);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r2_o);
    _r1.i = _r1.i + 1;
    goto label22;
    label34:;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    goto label21;
    label40:;
    _r2_o = _r0_o;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: java.util.List _getByPositionLess(java.util.List, int)]
}

private global::System.Object _1getByPositionGreater(global::java.util.List n1, int n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: java.util.List _getByPositionGreater(java.util.List, int)]
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
    _r3_o = this;
    _r4_o = n1;
    _r5.i = n2;
    _r2.i = ((global::java.util.List) _r4_o).size();
    if (_r5.i < _r2.i) goto label8;
    _r2_o = null;
    label7:;
    return (global::java.util.List) _r2_o;
    label8:;
    if (_r5.i > 0) goto label12;
    _r2_o = _r4_o;
    goto label7;
    label12:;
    _r2.i = ((_r4_o != null) && (_r4_o is global::java.util.Vector)) ? 1 : 0;
    if (_r2.i == 0) goto label38;
    _r0_o = new global::java.util.Vector();
    ((global::java.util.Vector) _r0_o).@this();
    label21:;
    _r1.i = _r5.i;
    label22:;
    _r2.i = ((global::java.util.List) _r4_o).size();
    if (_r1.i >= _r2.i) goto label44;
    _r2_o = ((global::java.util.List) _r4_o).get((int) _r1.i);
    ((global::java.util.List) _r0_o).add((global::java.lang.Object) _r2_o);
    _r1.i = _r1.i + 1;
    goto label22;
    label38:;
    _r0_o = new global::java.util.ArrayList();
    ((global::java.util.ArrayList) _r0_o).@this();
    goto label21;
    label44:;
    _r2_o = _r0_o;
    goto label7;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: java.util.List _getByPositionGreater(java.util.List, int)]
}

private global::System.Object _1getByLast(global::java.util.List n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: com.codename1.processing.StructuredContent _getByLast(java.util.List, java.lang.String)]
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
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    // Value=-
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)45))}));
    _r1.i = ((global::java.lang.String) _r8_o).indexOf((global::java.lang.String) _r3_o);
    _r3.i = -1;
    if (_r1.i != _r3.i) goto label34;
    _r3_o = new global::java.lang.IllegalArgumentException();
    _r4_o = new global::java.lang.StringBuilder();
    ((global::java.lang.StringBuilder) _r4_o).@this();
    // Value=Could not handle expression: 
    _r5_o = new global::java.lang.String();
    ((global::java.lang.String)_r5_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)67)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 117)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 104)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 100)), unchecked((char) unchecked((uint) 108)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 32)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 112)), unchecked((char) unchecked((uint) 114)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 58)), unchecked((char) unchecked((uint) 32))}));
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r5_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).append((global::java.lang.String) _r8_o);
    _r4_o = ((global::java.lang.StringBuilder) _r4_o).toString();
    ((global::java.lang.IllegalArgumentException) _r3_o).@this((global::java.lang.String) _r4_o);
    throw new global::org.xmlvm._nExceptionAdapter((global::java.lang.IllegalArgumentException) _r3_o);
    label34:;
    _r3.i = _r1.i + 1;
    _r3_o = ((global::java.lang.String) _r8_o).substring((int) _r3.i);
    _r2_o = ((global::java.lang.String) _r3_o).trim();
    _r3.i = ((global::java.util.List) _r7_o).size();
    _r4.i = 1;
    _r3.i = _r3.i - _r4.i;
    _r4.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r2_o);
    _r0.i = _r3.i - _r4.i;
    if (_r0.i >= 0) goto label60;
    _r3_o = null;
    label59:;
    return (global::com.codename1.processing.StructuredContent) _r3_o;
    label60:;
    _r6_o = ((global::java.util.List) _r7_o).get((int) _r0.i);
    _r6_o = _r6_o;
    _r3_o = _r6_o;
    goto label59;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: com.codename1.processing.StructuredContent _getByLast(java.util.List, java.lang.String)]
}

public override global::System.Object evaluateSingle(global::java.util.List n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: java.lang.Object evaluateSingle(java.util.List, java.lang.String)]
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
    _r4_o = this;
    _r5_o = n1;
    _r6_o = n2;
    _r3_o = null;
    _r1.i = ((global::com.codename1.processing.IndexEvaluator) _r4_o).isNumeric((global::java.lang.String) _r6_o) ? 1 : 0;
    if (_r1.i == 0) goto label29;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r6_o);
    if (_r0.i < 0) goto label19;
    _r1.i = ((global::java.util.List) _r5_o).size();
    if (_r0.i < _r1.i) goto label21;
    label19:;
    _r1_o = _r3_o;
    label20:;
    return (global::java.lang.Object) _r1_o;
    label21:;
    _r4_o = ((global::java.util.List) _r5_o).get((int) _r0.i);
    _r4_o = _r4_o;
    _r1_o = _r4_o;
    goto label20;
    label29:;
    _r1_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1LAST;
    _r1.i = ((global::java.lang.String) _r6_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label59;
    _r1.i = ((global::java.util.List) _r5_o).size();
    if (_r1.i != 0) goto label45;
    _r1_o = _r3_o;
    goto label20;
    label45:;
    _r1.i = ((global::java.util.List) _r5_o).size();
    _r2.i = 1;
    _r1.i = _r1.i - _r2.i;
    _r4_o = ((global::java.util.List) _r5_o).get((int) _r1.i);
    _r4_o = _r4_o;
    _r1_o = _r4_o;
    goto label20;
    label59:;
    _r1_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1LAST;
    _r1.i = ((global::java.lang.String) _r6_o).indexOf((global::java.lang.String) _r1_o);
    _r2.i = -1;
    if (_r1.i == _r2.i) goto label73;
    _r1_o = ((global::com.codename1.processing.IndexEvaluator) _r4_o)._1getByLast((global::java.util.List) _r5_o, (global::java.lang.String) _r6_o);
    goto label20;
    label73:;
    _r1_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1POSITION;
    _r1.i = ((global::java.lang.String) _r6_o).equals((global::java.lang.Object) _r1_o) ? 1 : 0;
    if (_r1.i == 0) goto label83;
    _r1_o = _r5_o;
    goto label20;
    label83:;
    _r1_o = _r3_o;
    goto label20;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: java.lang.Object evaluateSingle(java.util.List, java.lang.String)]
}

public override global::System.Object evaluateLeftLessRight(global::java.util.List n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: java.lang.Object evaluateLeftLessRight(java.util.List, java.lang.String, java.lang.String)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1POSITION;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o);
    _r0_o = ((global::com.codename1.processing.IndexEvaluator) _r1_o)._1getByPositionLess((global::java.util.List) _r2_o, (int) _r0.i);
    label16:;
    return (global::java.lang.Object) _r0_o;
    label17:;
    _r0_o = null;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: java.lang.Object evaluateLeftLessRight(java.util.List, java.lang.String, java.lang.String)]
}

public override global::System.Object evaluateLeftGreaterRight(global::java.util.List n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: java.lang.Object evaluateLeftGreaterRight(java.util.List, java.lang.String, java.lang.String)]
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
    _r1_o = this;
    _r2_o = n1;
    _r3_o = n2;
    _r4_o = n3;
    _r0_o = global::com.codename1.processing.IndexEvaluator._fFUNC_1POSITION;
    _r0.i = ((global::java.lang.String) _r0_o).equals((global::java.lang.Object) _r3_o) ? 1 : 0;
    if (_r0.i == 0) goto label17;
    _r0.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o);
    _r0_o = ((global::com.codename1.processing.IndexEvaluator) _r1_o)._1getByPositionGreater((global::java.util.List) _r2_o, (int) _r0.i);
    label16:;
    return (global::java.lang.Object) _r0_o;
    label17:;
    _r0_o = null;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: java.lang.Object evaluateLeftGreaterRight(java.util.List, java.lang.String, java.lang.String)]
}

public static void @static(){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator: void <clinit>()]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    // Value=last()
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)108)), unchecked((char) unchecked((uint) 97)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    global::com.codename1.processing.IndexEvaluator._fFUNC_1LAST = (global::java.lang.String) _r0_o;
    // Value=position()
    _r0_o = new global::java.lang.String();
    ((global::java.lang.String)_r0_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)112)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 115)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 105)), unchecked((char) unchecked((uint) 111)), unchecked((char) unchecked((uint) 110)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    global::com.codename1.processing.IndexEvaluator._fFUNC_1POSITION = (global::java.lang.String) _r0_o;
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator: void <clinit>()]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.IndexEvaluator]
//XMLVM_END_WRAPPER[com.codename1.processing.IndexEvaluator]

} // end of class: IndexEvaluator

} // end of namespace: com.codename1.processing
