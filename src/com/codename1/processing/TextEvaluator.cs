// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace com.codename1.processing {
public class TextEvaluator: global::com.codename1.processing.AbstractEvaluator {

static TextEvaluator() {
    // Value=text()
    _fFUNC_1TEXT = new global::java.lang.String();
    _fFUNC_1TEXT.@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
}

public static global::java.lang.String _fFUNC_1TEXT;

public void @this(global::java.lang.String n1){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator: void <init>(java.lang.String)]
    global::org.xmlvm._nElement _r0;
    global::System.Object _r0_o = null;
    global::org.xmlvm._nElement _r1;
    global::System.Object _r1_o = null;
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r0_o = this;
    _r1_o = n1;
    ((global::com.codename1.processing.AbstractEvaluator) _r0_o).@this((global::java.lang.String) _r1_o);
    return;
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator: void <init>(java.lang.String)]
}

private global::System.Object _1getLeftValue(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.String[] _getLeftValue(com.codename1.processing.StructuredContent, java.lang.String)]
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
    _r5_o = this;
    _r6_o = n1;
    _r7_o = n2;
    _r4.i = 0;
    // Value=text()
    _r3_o = new global::java.lang.String();
    ((global::java.lang.String)_r3_o).@this(new global::org.xmlvm._nArrayAdapter<char>(new char[] {unchecked((char) unchecked((uint)116)), unchecked((char) unchecked((uint) 101)), unchecked((char) unchecked((uint) 120)), unchecked((char) unchecked((uint) 116)), unchecked((char) unchecked((uint) 40)), unchecked((char) unchecked((uint) 41))}));
    _r3.i = ((global::java.lang.String) _r3_o).equals((global::java.lang.Object) _r7_o) ? 1 : 0;
    if (_r3.i == 0) goto label19;
    _r3.i = 1;
    _r2_o = new global::org.xmlvm._nArrayAdapter<global::System.Object>(new global::System.Object[_r3.i]);
    _r3_o = ((global::com.codename1.processing.StructuredContent) _r6_o).getText();
    ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o)[_r4.i] = _r3_o;
    label18:;
    return (global::org.xmlvm._nArrayAdapter<global::System.Object>) _r2_o;
    label19:;
    _r0_o = ((global::com.codename1.processing.StructuredContent) _r6_o).getChild((int) _r4.i);
    _r1_o = global::com.codename1.processing.Result.fromContent((global::com.codename1.processing.StructuredContent) _r0_o);
    _r2_o = ((global::com.codename1.processing.Result) _r1_o).getAsStringArray((global::java.lang.String) _r7_o);
    goto label18;
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.String[] _getLeftValue(com.codename1.processing.StructuredContent, java.lang.String)]
}

public override global::System.Object evaluateLeftLessRight(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateLeftLessRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r5_o = null;
    _r3_o = ((global::com.codename1.processing.TextEvaluator) _r6_o)._1getLeftValue((global::com.codename1.processing.StructuredContent) _r7_o, (global::java.lang.String) _r8_o);
    if (_r3_o != null) goto label9;
    _r4_o = _r5_o;
    label8:;
    return (global::java.lang.Object) _r4_o;
    label9:;
    _r0.i = 0;
    label10:;
    _r4.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r0.i >= _r4.i) goto label60;
    _r4.i = ((global::com.codename1.processing.TextEvaluator) _r6_o).isNumeric((global::java.lang.String) _r9_o) ? 1 : 0;
    if (_r4.i == 0) goto label43;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4.i = ((global::com.codename1.processing.TextEvaluator) _r6_o).isNumeric((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label43;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r1.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o);
    _r2.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r9_o);
    if (_r1.i >= _r2.i) goto label41;
    _r4_o = _r7_o;
    goto label8;
    label41:;
    _r4_o = _r5_o;
    goto label8;
    label43:;
    _r9_o = ((global::com.codename1.processing.TextEvaluator) _r6_o).stripQuotes((global::java.lang.String) _r9_o);
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4.i = ((global::java.lang.String) _r4_o).compareTo((global::java.lang.String) _r9_o);
    if (_r4.i <= 0) goto label57;
    _r4_o = _r7_o;
    goto label8;
    label57:;
    _r0.i = _r0.i + 1;
    goto label10;
    label60:;
    _r4_o = _r5_o;
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateLeftLessRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
}

public override global::System.Object evaluateLeftGreaterRight(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateLeftGreaterRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r5_o = null;
    _r3_o = ((global::com.codename1.processing.TextEvaluator) _r6_o)._1getLeftValue((global::com.codename1.processing.StructuredContent) _r7_o, (global::java.lang.String) _r8_o);
    if (_r3_o != null) goto label9;
    _r4_o = _r5_o;
    label8:;
    return (global::java.lang.Object) _r4_o;
    label9:;
    _r0.i = 0;
    label10:;
    _r4.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r0.i >= _r4.i) goto label60;
    _r4.i = ((global::com.codename1.processing.TextEvaluator) _r6_o).isNumeric((global::java.lang.String) _r9_o) ? 1 : 0;
    if (_r4.i == 0) goto label43;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4.i = ((global::com.codename1.processing.TextEvaluator) _r6_o).isNumeric((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label43;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r1.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o);
    _r2.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r9_o);
    if (_r1.i <= _r2.i) goto label41;
    _r4_o = _r7_o;
    goto label8;
    label41:;
    _r4_o = _r5_o;
    goto label8;
    label43:;
    _r9_o = ((global::com.codename1.processing.TextEvaluator) _r6_o).stripQuotes((global::java.lang.String) _r9_o);
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4.i = ((global::java.lang.String) _r4_o).compareTo((global::java.lang.String) _r9_o);
    if (_r4.i >= 0) goto label57;
    _r4_o = _r7_o;
    goto label8;
    label57:;
    _r0.i = _r0.i + 1;
    goto label10;
    label60:;
    _r4_o = _r5_o;
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateLeftGreaterRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
}

public override global::System.Object evaluateLeftEqualsRight(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2, global::java.lang.String n3){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateLeftEqualsRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
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
    global::org.xmlvm._nExceptionAdapter _ex = null;
    _r6_o = this;
    _r7_o = n1;
    _r8_o = n2;
    _r9_o = n3;
    _r5_o = null;
    _r3_o = ((global::com.codename1.processing.TextEvaluator) _r6_o)._1getLeftValue((global::com.codename1.processing.StructuredContent) _r7_o, (global::java.lang.String) _r8_o);
    if (_r3_o != null) goto label9;
    _r4_o = _r5_o;
    label8:;
    return (global::java.lang.Object) _r4_o;
    label9:;
    _r0.i = 0;
    label10:;
    _r4.i = ((global::org.xmlvm._nIArray) _r3_o).Length;
    if (_r0.i >= _r4.i) goto label60;
    _r4.i = ((global::com.codename1.processing.TextEvaluator) _r6_o).isNumeric((global::java.lang.String) _r9_o) ? 1 : 0;
    if (_r4.i == 0) goto label43;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4.i = ((global::com.codename1.processing.TextEvaluator) _r6_o).isNumeric((global::java.lang.String) _r4_o) ? 1 : 0;
    if (_r4.i == 0) goto label43;
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r1.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r4_o);
    _r2.i = global::java.lang.Integer.parseInt((global::java.lang.String) _r9_o);
    if (_r1.i != _r2.i) goto label41;
    _r4_o = _r7_o;
    goto label8;
    label41:;
    _r4_o = _r5_o;
    goto label8;
    label43:;
    _r9_o = ((global::com.codename1.processing.TextEvaluator) _r6_o).stripQuotes((global::java.lang.String) _r9_o);
    _r4_o = ((global::org.xmlvm._nArrayAdapter<global::System.Object>) _r3_o)[_r0.i];
    _r4.i = ((global::java.lang.String) _r4_o).compareTo((global::java.lang.String) _r9_o);
    if (_r4.i != 0) goto label57;
    _r4_o = _r7_o;
    goto label8;
    label57:;
    _r0.i = _r0.i + 1;
    goto label10;
    label60:;
    _r4_o = _r5_o;
    goto label8;
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateLeftEqualsRight(com.codename1.processing.StructuredContent, java.lang.String, java.lang.String)]
}

public override global::System.Object evaluateSingle(global::com.codename1.processing.StructuredContent n1, global::java.lang.String n2){
//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateSingle(com.codename1.processing.StructuredContent, java.lang.String)]
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
    _r5_o = n2;
    _r2.i = 0;
    _r2_o = ((global::com.codename1.processing.StructuredContent) _r4_o).getChild((int) _r2.i);
    _r0_o = global::com.codename1.processing.Result.fromContent((global::com.codename1.processing.StructuredContent) _r2_o);
    _r1_o = ((global::com.codename1.processing.Result) _r0_o).getAsString((global::java.lang.String) _r5_o);
    if (_r1_o != null) goto label17;
    _r2_o = null;
    label16:;
    return (global::java.lang.Object) _r2_o;
    label17:;
    _r2_o = _r4_o;
    goto label16;
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator: java.lang.Object evaluateSingle(com.codename1.processing.StructuredContent, java.lang.String)]
}

//XMLVM_BEGIN_WRAPPER[com.codename1.processing.TextEvaluator]
//XMLVM_END_WRAPPER[com.codename1.processing.TextEvaluator]

} // end of class: TextEvaluator

} // end of namespace: com.codename1.processing
